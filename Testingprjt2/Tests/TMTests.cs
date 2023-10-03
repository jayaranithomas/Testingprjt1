using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Testingprjt2.Pages;
using Testingprjt2.Utilities;

namespace Testingprjt2.Tests
{
    [TestFixture]
    public class TMTests : CommonDriver
    {
        [SetUp]
        public void SetupTM()
        {

            // open the chrome browser
            driver = new ChromeDriver();
            LoginPage logObj = new LoginPage();
            logObj.LoginActons(driver);
            HomePage homeObj = new HomePage();
            homeObj.GoToTMPage(driver);

        }
        [Test, Order(1), Description("This test creates a new TM record")]
        public void TestCreateTMRecord()
        {
            TMPage tMPageObj = new TMPage();
            tMPageObj.createTMrecord(driver);
        }
        [Test, Order(2), Description("This test edits an existing TM record")]
        public void TestEditTMRecord()
        {
            TMPage tMPageObj = new TMPage();
            tMPageObj.editTMRecord(driver);
        }
        [Test, Order(3), Description("This test deletes a TM record")]
        public void TestDeleteTMRecord()
        {
            TMPage tMPageObj = new TMPage();
            tMPageObj.deleteTMRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    



               
        
       
    }
}
