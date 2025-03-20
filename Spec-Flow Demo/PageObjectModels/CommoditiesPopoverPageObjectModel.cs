using SeleniumWebDriverExamples.Runtime;

namespace SeleniumWebDriverExamples.PageObjectModels.NavigationBar
{
    internal class CommoditiesPopoverPageObjectModel : BasePageObjectModel
    {
        private const string _commoditiesOverviewButton = "//a[@class='cta MainNavigation_secondaryLink__dWmVz' and @href='/en/commodities']";
        private const string _crudeOilButton = "//a[@class='cta MainNavigation_secondaryLink__dWmVz' and @href='/en/commodities/crude' and text()='Crude oil']";
        private const string _oilProductsButton = "//button[@class='cta MainNavigation_secondaryLink__dWmVz' and text()='Oil products']";
        private const string _lpgNglButton = "//a[@class='cta MainNavigation_secondaryLink__dWmVz' and @href='/en/commodities/lpg' and text()='LPG/NGL']";
        private const string _gasAndPowerButton = "//button[@class='cta MainNavigation_secondaryLink__dWmVz' and text()='Gas and power']";
        private const string _coalButton = "//a[@class='cta MainNavigation_secondaryLink__dWmVz' and @href='/en/commodities/coal' and text()='Coal']";
        private const string _netZeroButton = "//button[@class='cta MainNavigation_secondaryLink__dWmVz' and text()='Net zero']";
        private const string _chemicalsButton = "//button[@class='cta MainNavigation_secondaryLink__dWmVz' and text()='Chemicals']";
        private const string _fertilizersButton = "//button[@class='cta MainNavigation_secondaryLink__dWmVz' and text()='Fertilizers']";
        private const string _metalsButton = "//button[@class='cta MainNavigation_secondaryLink__dWmVz' and text()='Metals']";
        private const string _agricultureButton = "//a[@class='cta MainNavigation_secondaryLink__dWmVz' and @href='/en/commodities/agriculture' and text()='Agriculture']";

        private static IEnumerable<string> _allButtons = new List<string>
        {
            _commoditiesOverviewButton,
            _crudeOilButton,
            _oilProductsButton,
            _lpgNglButton,
            _gasAndPowerButton,
            _coalButton,
            _netZeroButton,
            _chemicalsButton,
            _fertilizersButton,
            _metalsButton,
            _agricultureButton
        };

        public static void ClickCommoditiesOverviewButton(TestParticipant testParticipant)
        {
            ClickElement(testParticipant, _commoditiesOverviewButton);
        }

        public static void ClickCrudeOilButton(TestParticipant testParticipant)
        {
            ClickElement(testParticipant, _crudeOilButton);
        }

        public static void WaitForAllCommodites(TestParticipant testParticipant)
        {
            foreach (var button in _allButtons)
            {
                WaitForElementToBeDisplayed(testParticipant, button);
            }
        }
    }
}
