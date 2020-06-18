using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf.Reflection;

namespace client.Interceptors
{
    public class MessageSignature
    {
        private string apiKey;
        private string apiSecret;
        global::Google.Protobuf.IMessage message;
        private SortedDictionary<string, Object> simpleFields = new SortedDictionary<string, Object>();
        private List<FieldType> simpleKinds = new List<FieldType>{
            FieldType.Double,
	        FieldType.Float,
	        FieldType.Int64,
	        FieldType.UInt64,
	        FieldType.Int32,
	        FieldType.Fixed64,
	        FieldType.Fixed32,
	        FieldType.Bool,
	        FieldType.String,
	        FieldType.Bytes,
	        FieldType.UInt32,
	        FieldType.SFixed32,
	        FieldType.SFixed64,
	        FieldType.SInt32,
            FieldType.SInt64
		};

        public MessageSignature(string apiKey, string apiSecret, global::Google.Protobuf.IMessage request)
        {
            this.apiKey = apiKey;
            this.apiSecret = apiSecret;
            this.message = request;
        }

        public string calculateSign()
        {
            var fields = message.Descriptor.Fields;
            
            SortedDictionary<string, Object> simpleFields =
                    new SortedDictionary<string, Object>();


            foreach (var field in fields.InDeclarationOrder())
            {
                if (simpleKinds.Contains(field.FieldType) && !field.IsRepeated) {
                    if (field.FieldType == FieldType.Bool)
                    {
                        simpleFields[field.Name] = field.Accessor.GetValue(message).ToString().ToLower();
                    }
                    else
                    {
                        simpleFields[field.Name] = field.Accessor.GetValue(message);
                    }

                }
            }
            
            return getMd5Hash(buildSignString(simpleFields));
        }

        private string getMd5Hash(String source)
        {
            string hashed = "";
            using (MD5 md5 = MD5.Create())
            {
                 hashed = string.Join(string.Empty, md5.ComputeHash(Encoding.UTF8.GetBytes(source)).Select(b => b.ToString("x2")));
            }
            return hashed;
        }

        private string buildSignString(SortedDictionary<string, Object> simpleFields)
        {
            StringBuilder source = new StringBuilder("");
            simpleFields.Add("api_key", apiKey);
            simpleFields.Add("t", new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds());
            
            foreach (var entry in simpleFields)
            {
                source.Append(entry.Key + "=" + entry.Value);
            }
            source.Append(apiSecret);
            return source.ToString();
        }
    }
}
