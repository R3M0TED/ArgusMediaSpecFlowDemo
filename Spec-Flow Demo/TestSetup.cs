using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using SeleniumWebDriverExamples.Runtime;

namespace SpecFlowDemo
{
    [Binding]
    public class TestSetup
    {
        private readonly ScenarioContext _scenarioContext;


        public TestSetup(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeEachScenario()
        {
            _scenarioContext["Participants"] = new Dictionary<string, TestParticipant>();

        }
        [AfterScenario]
        public void AfterEachScenario()
        {
            var participants = (Dictionary<string, TestParticipant>)_scenarioContext["Participants"];
            foreach (var participant in participants.Values)
            {
                participant.Driver.Quit();
                participant.Driver.Dispose();
            }
        }
    }
}
