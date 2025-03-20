using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriverExamples.PageObjectModels.NavigationBar;
using SeleniumWebDriverExamples.Runtime;
using Spec_Flow_Demo.StepDefinitions;
using SpecFlowDemo.PageObjectModels;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace SpecFlowDemo
{
    [Binding]
    internal class SearchFeatureSteps : BaseStepDefinitions
    {
        public SearchFeatureSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }


        [Given(@"I have a user called (.*)")]
        public void GivenIHaveAUserCalled(string name)
        {
            var participant = CreateParticipant(name);
        }

        [When(@"(.*) clicks commodities")]
        public void WhenUserClicksCommodities(string name)
        {
            NavigationBarPageObjectModel.ClickCommodities(GetParticipant(name));
        }

        [Then(@"Commodities popover opens for (.*)")]
        public void ThenCommoditiesPopoverOpens(string name)
        {
            CommoditiesPopoverPageObjectModel.WaitForAllCommodites(GetParticipant(name));
        }
    }
}
