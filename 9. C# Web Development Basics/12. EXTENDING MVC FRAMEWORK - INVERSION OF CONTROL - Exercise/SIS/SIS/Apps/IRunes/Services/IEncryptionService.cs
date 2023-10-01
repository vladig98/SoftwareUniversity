namespace IRunes.Services
{
    public interface IEncryptionService
    {
        public string Encrypt(string value);
        public string Encode(string plainText);
        public string Decode(string base64EncodedData);
    }
}
