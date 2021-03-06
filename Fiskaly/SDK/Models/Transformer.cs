﻿using Newtonsoft.Json;
using System;
using System.Text;

namespace Fiskaly.Client.Models
{
    public class Transformer
    {
        public static byte[] EncodeJsonRpcRequest(JsonRpcRequest request)
        {
            string payload = JsonConvert.SerializeObject(request);
            System.Diagnostics.Debug.WriteLine("Sending payload: " + payload);
            return Encoding.UTF8.GetBytes(payload);
        }

        public static string DecodeBase64Body(byte[] body)
        {
            string base64Body = Convert.ToBase64String(body);
            byte[] decodedBodyBytes = Convert.FromBase64String(base64Body);

            return Encoding.UTF8.GetString(decodedBodyBytes);
        }

        public static byte[] DecodeBase64BytesToUtf8Bytes(byte[] body)
        {
            string base64Body = Convert.ToBase64String(body);

            return Convert.FromBase64String(base64Body);
        }
    }
}
