using System;
using System.Security.Cryptography;
using System.Text;

namespace IRunes.Services
{
    public static class EncryptionService
    {
        public static string Encrypt(string value)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed encrypter = new SHA256Managed();

            var hashedValue = encrypter.ComputeHash(encoder.GetBytes(value));

            return Convert.ToBase64String(hashedValue);
        }

        public static string Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
