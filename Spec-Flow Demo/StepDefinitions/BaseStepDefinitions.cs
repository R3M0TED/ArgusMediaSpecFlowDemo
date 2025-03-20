using SeleniumWebDriverExamples.PageObjectModels;
using SeleniumWebDriverExamples.Runtime;
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

        private Dictionary<string, TestParticipant> Participants =>
            _scenarioContext.Get<Dictionary<string, TestParticipant>>("Participants");

        private void AddOrUpdateParticipant(string name, TestParticipant participant)
        {
            Participants[name] = participant;
        }

        protected TestParticipant CreateParticipant(string name)
        {
            var participant = new TestParticipant(WebDriverFactory.CreateWebDriver());

            participant.Driver.Navigate().GoToUrl("https://www.argusmedia.com/en");
            CookiesPopupPageObjectModel.ClickAcceptCookies(participant);

            AddOrUpdateParticipant(name, participant);

            return participant;
        }

        protected TestParticipant GetParticipant(string name)
        {
            if (Participants.ContainsKey(name))
            {
                return Participants[name];
            }
            throw new KeyNotFoundException($"Participant '{name}' was not found.");
        }
    }
}
