using SeleniumWebDriverExamples.PageObjectModels;
using SeleniumWebDriverExamples.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Spec_Flow_Demo.StepDefinitions
{
    internal class BaseStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public BaseStepDefinitions(ScenarioContext scenarioContext)
        {
            this._scenarioContext = scenarioContext;
        }

        protected TestParticipant CreateParticipant(string name)
        {
            var participant = new TestParticipant(WebDriverFactory.CreateWebDriver());
            var participants = _scenarioContext.Get<Dictionary<string, TestParticipant>>("Participants");
            participants[name] = participant;

            participant.Driver.Navigate().GoToUrl("https://www.argusmedia.com/en");
            CookiesPopupPageObjectModel.ClickAcceptCookies(participant);

            return participant;
        }

        protected TestParticipant GetParticipant(string name)
        {
            var participants = _scenarioContext.Get<Dictionary<string, TestParticipant>>("Participants");
            var participant = participants[name];

            return participant;
        }
    }
}
 