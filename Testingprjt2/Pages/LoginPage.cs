using OpenQA.Selenium;
using Testingprjt2.Utilities;

namespace Testingprjt2.Pages
{
    public class LoginPage
    {
        public void LoginActons(IWebDriver driver)
        {
            //navigate to the turnup portal login page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

            //maximize the window
            driver.Manage().Window.Maximize();

            //identify the username field
            Wait.WaitToBeVisible(driver, "Id", "UserName", 5);
            IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));

            //Enter the username
            userNameTextBox.SendKeys("hari");

            //identify the password field
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));

            //Enter the username
            passwordTextBox.SendKeys("123123");

            //Identify the login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));

            //click on the login button
            loginButton.Click();
            //driver.SwitchTo().Alert().Accept();

            Thread.Sleep(5000);
        }
    }
}
