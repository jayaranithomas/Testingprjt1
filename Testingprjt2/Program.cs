
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// open the chrome browser
IWebDriver driver = new ChromeDriver();

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

//Verify if the logged in page is correct
IWebElement homePage = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (homePage.Text == "Hello hari!")
{
    Console.WriteLine("You have succesfully logged in");
}
else
{
    Console.WriteLine("You are in the wrong page");
}
driver.Close();