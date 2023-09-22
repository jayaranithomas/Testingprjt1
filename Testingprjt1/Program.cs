
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Open chrome browser
IWebDriver driver = new ChromeDriver();

//Maximize it
driver.Manage().Window.Maximize();

//navigate to the TurnUp Portal login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

//Identify the username field
IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));

//Enter username
usernameTextBox.SendKeys("hari");

//Identify password field
IWebElement PasswordTextBox = driver.FindElement(By.Id("Password"));

//Enter password
PasswordTextBox.SendKeys("123123");

//Identify login button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));

//Click on the login button
loginButton.Click();

//Check if the user has logged in successfully ,Verify the homepage by checking the username
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("User logged in successfully");
}
else
{
    Console.WriteLine("User not logged in");
}

