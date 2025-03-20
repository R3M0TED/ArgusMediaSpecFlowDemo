using SeleniumWebDriverExamples.PageObjectModels;
using SeleniumWebDriverExamples.Runtime;

namespace SpecFlowDemo.PageObjectModels
{
    internal class NavigationBarPageObjectModel : BasePageObjectModel
    {
        private const string _commoditiesButton = "//button[@class='cta MainNavigation_primaryLink__tYxec' and normalize-space(text())='Commodities']";

        public static void ClickCommodities(TestParticipant testParticipant)
        {
            ClickElement(testParticipant, _commoditiesButton);
        }
    }
}
