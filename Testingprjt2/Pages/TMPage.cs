﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testingprjt2.Pages
{
    public class TMPage
    {
        public void createTMrecord(IWebDriver driver)
        {
            //Click on the Create New Button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            // Click on the Typecode Dropdown
            IWebElement tcDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            tcDropdown.Click();

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
        }
        public void editTMRecord(IWebDriver driver)
        {
            //Verify the Edit functionality of Time and Material Module
            //Click on the Edit Button of the last record
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            Thread.Sleep(5000);

            // Click on the Dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeDropdown.Click();
            Thread.Sleep(1000);

            // Select material Option from the typecode Dropdown
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
        }
        public void deleteTMRecord(IWebDriver driver)
        {
            //Verify the delete functionality of Time and Material Module
            //Click on the Delete Button of the last record
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            //For Accepting the deletion confirmation Alert
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(5000);

            //Verify if the delete has done
            IWebElement LastPButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            LastPButton.Click();


            IWebElement newLastRec = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newLastRec.Text != "CodeEdited")
            {
                Console.WriteLine("Delete Successfull");
            }
            else
            {
                Console.WriteLine("Delete NOT Successfull");
            }
        }
    }
}