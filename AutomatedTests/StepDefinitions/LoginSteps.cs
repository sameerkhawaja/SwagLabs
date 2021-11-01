namespace AutomatedTests.StepDefinitions
{
    using BoDi;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using PageObjects;
    using PageObjects.TheSauceDemoPage;
    using TechTalk.SpecFlow;

    [Binding]
    public class LoginSteps
    {
        private readonly IObjectContainer _objectContainer;
        private readonly IWebDriver _driver;

        private readonly LoginPage loginPage;
        private readonly TheSauceDemoMainPage theSauceDemoMainPage;

        public LoginSteps(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
            _driver = _objectContainer.Resolve<IWebDriver>(Constants.WEBDRIVER);

            loginPage = new LoginPage(_driver);
            theSauceDemoMainPage = new TheSauceDemoMainPage(_driver);
        }

        [Given(@"I am on the Sauce Demo Login Page")]
        public void GivenIAmOnTheSauceDemoLoginPage()
        {
            loginPage.NavigateToPage();
        }

        [When(@"I fill the account information for account StandardUser into the Username field and the Password field")]
        public void WhenIFillTheAccountInformationForAccountStandardUserIntoTheUsernameFieldAndThePasswordField()
        {
            loginPage.FillCredentials();
        }

        [When(@"I click the Login Button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.Login();
        }

        [When(@"I fill the account information for account LockedOutUser into the Username field and the Password field")]
        public void WhenIFillTheAccountInformationForAccountLockedOutUserIntoTheUsernameFieldAndThePasswordField()
        {
            loginPage.FillBadCredentials();
        }

        [Then(@"I am redirected to the Sauce Demo Main Page")]
        public void ThenIAmRedirectedToTheSauceDemoMainPage()
        {
            Assert.True(theSauceDemoMainPage.DidUserLandOnPage());
        }

        [Then(@"I verify the App Logo exists")]
        public void ThenIVerifyTheAppLogoExists()
        {
            Assert.True(theSauceDemoMainPage.DoesLogoExist());
        }

        [Then(@"I verify the Error Message contains the text ""(.*)""")]
        public void ThenIVerifyTheErrorMessageContainsTheText(string errorMessage)
        {
            Assert.True(loginPage.DoesErrorMessageExist());
            Assert.True(loginPage.DoesErrorMessageContainText(errorMessage));
        }
    }
}