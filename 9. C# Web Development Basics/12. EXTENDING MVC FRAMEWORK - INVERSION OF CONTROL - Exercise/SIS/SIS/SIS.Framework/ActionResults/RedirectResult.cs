namespace SIS.Framework.ActionResults
{
    public class RedirectResult : IRedirectable
    {
        public RedirectResult(string redirectUrl)
        {
            RedirectUrl = redirectUrl;
        }

        public string RedirectUrl { get; set; }

        public string Invoke()
            => RedirectUrl;
    }
}
