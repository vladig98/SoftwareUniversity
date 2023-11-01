using Eventures.Tests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Eventures.Tests
{
    public class SeleniumTests
    {
        //Start the server before you run these.

        private readonly IWebDriver Browser;
        private string URL;

        public SeleniumTests()
        {
            URL = @"https://localhost:7243";
            var browserOptions = new ChromeOptions();
            browserOptions.AddArgument("--headless");

            Browser = new ChromeDriver(browserOptions);
        }

        [Fact]
        public void TestIfTheHomePageHasTheCorrectHeadings()
        {
            Browser.Navigate().GoToUrl(URL);

            var mainHeadingText = Browser.FindElement(By.TagName("h1")).Text;

            Assert.Equal("Eventures - The best ticket service in the world.", mainHeadingText);
            Browser.Quit();
        }

        [Fact]
        public void TestIfTheHomePageHasTheCorrectHeadingsForALoggedInUser()
        {
            Browser.Navigate().GoToUrl(URL + "/Users/Login");

            var usernameInput = Browser.FindElement(By.CssSelector(@"input[name='UserName']"));
            var passwordInput = Browser.FindElement(By.CssSelector(@"input[name='Password']"));

            usernameInput.SendKeys("Vladi");
            passwordInput.SendKeys("123");

            var loginForm = Browser.FindElement(By.TagName("form"));
            loginForm.Submit();

            var mainHeadingText = Browser.FindElement(By.TagName("h1")).Text;

            Assert.Equal("Welcome, Vladi!", mainHeadingText);
            Browser.Quit();
        }

        [Fact]
        public void TestIfTheHomePageHasTheCorrectHeadingsForAnAdmin()
        {
            Browser.Navigate().GoToUrl(URL + "/Users/Login");

            var usernameInput = Browser.FindElement(By.CssSelector(@"input[name='UserName']"));
            var passwordInput = Browser.FindElement(By.CssSelector(@"input[name='Password']"));

            usernameInput.SendKeys("Vladi2");
            passwordInput.SendKeys("123456");

            var loginForm = Browser.FindElement(By.TagName("form"));
            loginForm.Submit();

            var mainHeadingText = Browser.FindElement(By.TagName("h1")).Text;

            Assert.Equal("Greetings, Administrator - Vladi2!", mainHeadingText);
            Browser.Quit();
        }

        [Fact]
        public void TestIfTheLoginLinkAndRegisterLinkInTheHeadingOfTheHomePageWorkCorrectly()
        {
            Browser.Navigate().GoToUrl(URL);

            var loginLink = Browser.FindElements(By.CssSelector("h3 > a")).First();

            loginLink.Click();

            var title = Browser.Title;

            Assert.Equal("Login - Eventures", title);

            Browser.Navigate().GoToUrl(URL);

            var registerLink = Browser.FindElements(By.CssSelector("h3 > a")).Last();

            registerLink.Click();

            title = Browser.Title;

            Assert.Equal("Register - Eventures", title);
            Browser.Quit();
        }
    }
}
