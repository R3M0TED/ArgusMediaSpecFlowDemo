using SeleniumWebDriverExamples.PageObjectModels;
using SeleniumWebDriverExamples.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
