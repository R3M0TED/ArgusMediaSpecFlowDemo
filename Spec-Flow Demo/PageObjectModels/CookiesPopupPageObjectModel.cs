using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels
{
    internal class CookiesPopupPageObjectModel : BasePageObjectModel
    {
        private const string _acceptCookiesButton = "//button[@id='onetrust-accept-btn-handler']";

        public static void ClickAcceptCookies(TestParticipant testParticipant)
        {
            ClickElement(testParticipant, _acceptCookiesButton);
        }
    }
}
