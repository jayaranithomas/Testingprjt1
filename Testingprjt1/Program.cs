
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

Thread.Sleep(5000);//Wait for 5 seconds for the page to load

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

//Test Case - Create a new Time & Material record

//Navgate to the Time and Material Module
IWebElement administratorDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administratorDropdown.Click();

//Identify and Click the Time & Material option
IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();

//Click the Create New Button
IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
CreateNewButton.Click();

// Select Time from dropdown
IWebElement typeCodeMainDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typeCodeMainDropdown.Click();
IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
typeCodeDropdown.Click();

//Enter Code
IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
codeTextBox.SendKeys("Time&MaterialSample");

//Enter Description
IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
descriptionTextBox.SendKeys("Description Time&MaterialSample");

//Enter Price
IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextbox.SendKeys("150.50");

//Click the Save Button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();

Thread.Sleep(5000);

//Verify if a new time record has been created successfully
IWebElement gotolastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
gotolastpageButton.Click();

//get the last entered record
IWebElement newRecordCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (newRecordCode.Text == "Time&MaterialSample")
{
    Console.WriteLine("Time record has been created successfully");
}
else 
{
    Console.WriteLine("Time record has not been created");
}