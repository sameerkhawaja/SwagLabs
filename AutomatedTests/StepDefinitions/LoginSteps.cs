namespace AutomatedTests.StepDefinitions
{
    using TechTalk.SpecFlow;

    [Binding]
    public class LoginSteps
    {
        public void Start()
        {

        }

        [Given(@"I am on the Sauce Demo Login Page")]
        public void GivenIAmOnTheSauceDemoLoginPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I fill the account information for account StandardUser into the Username field and the Password field")]
        public void WhenIFillTheAccountInformationForAccountStandardUserIntoTheUsernameFieldAndThePasswordField()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click the Login Button")]
        public void WhenIClickTheLoginButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I fill the account information for account LockedOutUser into the Username field and the Password field")]
        public void WhenIFillTheAccountInformationForAccountLockedOutUserIntoTheUsernameFieldAndThePasswordField()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I am redirected to the Sauce Demo Main Page")]
        public void ThenIAmRedirectedToTheSauceDemoMainPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I verify the App Logo exists")]
        public void ThenIVerifyTheAppLogoExists()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I verify the Error Message contains the text ""(.*)""")]
        public void ThenIVerifyTheErrorMessageContainsTheText(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}