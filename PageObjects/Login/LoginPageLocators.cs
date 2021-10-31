using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.Login
{
    public static class LoginPageLocators
    {
        public static By UserNameField => By.Id("user-name");
        public static By PasswordField => By.Id("password");
        public static By LoginButton => By.Id("login-button");
        public static By ErrorText=> By.XPath("//*[@id=\"login_button_container\"]/div/form/div[3]/h3/text()");

        public static By ErrorContainer => By.ClassName("error-message-container");

    }
}
