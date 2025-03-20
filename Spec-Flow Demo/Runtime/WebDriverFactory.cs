using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SeleniumWebDriverExamples.Runtime
{
    internal class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver()
        {
            return "chrome" switch
            {
                "chrome" => CreateChromeDriver(),
                "firefox" => CreateFirefoxDriver(),
                "edge" => CreateEdgeDriver(),
                _ => throw new ArgumentException("Unsupported browser")
            };
        }

        private static IEnumerable<string> GetBrowserOptions()
        {
            var options = new List<string>() { "--start-maximized" } ;

            return options;
        }

        private static ChromeDriver CreateChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArguments(GetBrowserOptions());
            return new ChromeDriver(options);
        }

        private static FirefoxDriver CreateFirefoxDriver()
        {
            var options = new FirefoxOptions();
            options.AddArguments(GetBrowserOptions());
            return new FirefoxDriver(options);
        }

        private static EdgeDriver CreateEdgeDriver()
        {
            var options = new EdgeOptions();
            options.AddArguments(GetBrowserOptions());
            return new EdgeDriver(options);
        }
    }
}
