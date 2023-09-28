
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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

//Thread.Sleep(5000);

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
//driver.Close();

// New Test Case - verify if a new Time & Material record is created and also verify its edit and delete features

//Click on the Administration dropdown
IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdown.Click();

//select the Time and Material option
IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();

//Click on the Create New Button
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();

// Click on the Typecode Dropdown
IWebElement materialDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
materialDropdown.Click();

// Select Time Option from the Material Dropdown
IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
timeOption.Click();

//Enter the Code
IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
codeTextBox.SendKeys("NewRecord");

//Enter the Description
IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
descriptionTextBox.SendKeys("Desc NewRecord");

//Enter the Price
IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextBox.SendKeys("100.00");

//Click on the Save Button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();

Thread.Sleep(5000);
//Verify if the new record ha been created Successfully
IWebElement lastrRecordButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastrRecordButton.Click();

IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (lastRecord.Text == "NewRecord")
{
    Console.WriteLine("Successfull");
}
else
{
    Console.WriteLine("NOT Successfull");
}

Thread.Sleep(5000);

//Verify the Edit functionality of Time and Material Module
//Click on the Edit Button of the last record
IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
editButton.Click();

Thread.Sleep(5000);

// Click on the Dropdown
IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typeCodeDropdown.Click();
Thread.Sleep(1000);

// Select material Option from the Material Dropdown
IWebElement materialOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]"));
materialOption.Click();

//Edit the Code
IWebElement codeEditTextBox = driver.FindElement(By.Id("Code"));
codeEditTextBox.Clear();
codeEditTextBox.SendKeys("CodeEdited");

//Edit the Description
IWebElement descriptionEditTextBox = driver.FindElement(By.Id("Description"));
descriptionEditTextBox.Clear();
descriptionEditTextBox.SendKeys("Desc EditedRecord");

Thread.Sleep(1000);

//Edit the Price
IWebElement editpriceoverlappingtag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
IWebElement editpricetextbox = driver.FindElement(By.Id("Price"));
editpriceoverlappingtag.Click();
editpricetextbox.Clear();
editpriceoverlappingtag.Click();
editpricetextbox.SendKeys("300.50");

//save the updates

IWebElement newSaveButton = driver.FindElement(By.Id("SaveButton"));
newSaveButton.Click();

Thread.Sleep(2000);

//Verify if the edit has done
IWebElement newLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
newLastPageButton.Click();

IWebElement newLastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (newLastRecord.Text == "CodeEdited")
{
    Console.WriteLine("Edit Successfull");
}
else
{
    Console.WriteLine("Edit NOT Successfull");
}

//Verify the delete functionality of Time and Material Module
//Click on the Delete Button of the last record
IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deleteButton.Click();
driver.SwitchTo().Alert().Accept();

Thread.Sleep(5000);

//Verify if the delete has done
IWebElement delLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
delLastPageButton.Click();


IWebElement newLastRec = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (newLastRec.Text != "CodeEdited")
{
    Console.WriteLine("Delete Successfull");
}
else
{
    Console.WriteLine("Delete NOT Successfull");
}