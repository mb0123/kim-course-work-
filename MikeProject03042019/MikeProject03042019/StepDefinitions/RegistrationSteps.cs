using System;
using TechTalk.SpecFlow;

namespace MikeProject03042019.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"i click on registered link")]
        public void WhenIClickOnRegisteredLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"The registration page is displayed")]
        public void ThenTheRegistrationPageIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
