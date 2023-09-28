using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Thread.Sleep(1000);
        }
    }
}
