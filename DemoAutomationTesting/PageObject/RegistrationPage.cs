using DemoAutomationTesting.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAutomationTesting.PageObject
{
     class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }   
        IWebDriver driver;

        IWebElement FirstName => driver.FindElement(By.XPath("//input[@placeholder=\"First Name\"]"));
        IWebElement LastName => driver.FindElement(By.XPath("//input[@placeholder=\"Last Name\"]"));
        IWebElement Address => driver.FindElement(By.XPath("//textarea[@rows=\"3\"]"));
        IWebElement Email => driver.FindElement(By.XPath(" //input[@type=\"email\"]"));
        IWebElement Phone => driver.FindElement(By.XPath(" //input[@type=\"tel\"]"));
        IWebElement Gender => driver.FindElement(By.XPath("//input[@value=\"Male\"]"));
        IWebElement Hobbies => driver.FindElement(By.XPath("//input[@value=\"Movies\"]"));
        IWebElement Language => driver.FindElement(By.XPath("//*[@id=\"msdd\"]"));
        IWebElement English => driver.FindElement(By.XPath("(//*[@style=\"text-decoration:none\"])[8]"));
        IWebElement Skills => driver.FindElement(By.XPath("//select[@ng-init=\"Skill=''\"]"));
        IWebElement SelectCountry => driver.FindElement(By.XPath("//*[@role=\"combobox\"]"));
        IWebElement YOB => driver.FindElement(By.XPath("//select[@ng-init=\"yearbox=''\"]"));
        IWebElement MOB => driver.FindElement(By.XPath("//select[@placeholder=\"Month\"]"));
        IWebElement DOB => driver.FindElement(By.XPath("//select[@id=\"daybox\"]"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@id=\"firstpassword\"]"));
        IWebElement ConfirmPassword => driver.FindElement(By.XPath("//input[@id=\"secondpassword\"]"));




        public void NavigateToWebSite(string website)
        {
            driver.Navigate().GoToUrl(website);
        }
        public void EnterFirstName()
        {
            FirstName.SendKeys("QUDUS");
        }
        public void EnteredLastName() 
        {
            LastName.SendKeys("KEHINDE");
        }
        public void EnterAddress()
        {
            Address.SendKeys("17 airport road Nigeria");
        }
        public void EnterEmail()
        {
            Email.SendKeys("example@1223@gmail.com");
        }
        public void EnterPhone()
        {
            Phone.SendKeys("+234711111111111111111111");
        }
        public void ClickOnGender()
        {
            Gender.Click();
        }
        public void ClickOnHobbies()
        { 
            Hobbies.Click();
        }
        public void SelectFromSkills()
        {
            SelectElement select = new SelectElement(Skills);
            select.SelectByText("Adobe Photoshop");

        }
        public void EnterSelectCountry()
        {
            SelectCountry.SendKeys("Denmark");
        }
        public void SelectFromYOB()
        {
            SelectElement select = new SelectElement(YOB);
            select.SelectByText("1990");
        }

        public void SelectFromMOB()
        {
            SelectElement select = new SelectElement(MOB);
            select.SelectByText("April");
        }
        public void SelectFromDOB()
        {
            SelectElement select = new SelectElement(DOB);
            select.SelectByText("21");
        }
        public void ClickOnLanguage()
        {
            Language.Click();   
        }
        public void ClickOnEnglish()
        {
            English.Click();
        }
        public void EnterPassword()
        {
            Password.SendKeys("Password");
        }
        public void EnterConfirmPassword()
        {
            ConfirmPassword.SendKeys("Password");
        }


    }
}
