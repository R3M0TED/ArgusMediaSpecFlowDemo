using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels
{
    internal class BasePageObjectModel
    {
        protected static void TypeIntoElement(TestParticipant testParticipant, string content, string xPath, int timeout = 6)
        {
            var element = ClickElement(testParticipant, xPath);
            element.SendKeys(content);
        }

        protected static IWebElement ClickElement(TestParticipant testParticipant, string xPath, int timeout = 6)
        {
            var element = WaitForElementToBeDisplayed(testParticipant, xPath);
            Wait(testParticipant, timeout).Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();

            return element;
        }

        protected static IWebElement WaitForElementToBeDisplayed(TestParticipant testParticipant, string xPath, int timeout = 6)
        {
            var element = Wait(testParticipant, timeout).Until(d => d.FindElement(By.XPath(xPath)));
            Wait(testParticipant, timeout).Until(d => element.Displayed);

            return element;
        }

        private static WebDriverWait Wait(TestParticipant testParticipant, int timeout)
        {
            return new WebDriverWait(testParticipant.Driver, TimeSpan.FromSeconds(timeout));
        }
    }
}
