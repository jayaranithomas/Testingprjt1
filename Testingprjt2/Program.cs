
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Testingprjt2.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        // open the chrome browser
        IWebDriver driver = new ChromeDriver();

        //initializing objects for all the classes
        LoginPage logObj = new LoginPage();
        HomePage homeObj = new HomePage();  
        TMPage tMPageObj = new TMPage();

        //call methods using objects
        logObj.LoginActons(driver);
        homeObj.GoToTMPage(driver);
        tMPageObj.createTMrecord(driver);
        tMPageObj.editTMRecord(driver);
        tMPageObj.deleteTMRecord(driver);





    }
}