using DemoAutomationTesting.PageObject;
using System;
using TechTalk.SpecFlow;

namespace DemoAutomationTesting.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {

        RegistrationPage registrationPage;
        public RegistrationStepDefinitions()
        {
            registrationPage= new RegistrationPage();   
        }

        [Given(@"I Navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string website)
        {
            registrationPage.NavigateToWebSite(website);
        }

        [Given(@"I enter my First Name")]
        public void GivenIEnterMyFirstName()
        {
            registrationPage.EnterFirstName();
        }

        [Given(@"I enter my Last Name")]
        public void GivenIEnterMyLastName()
        {
            registrationPage.EnteredLastName();
        }

        [Given(@"I enter Address")]
        public void GivenIEnterAddress()
        {
            registrationPage.EnterAddress();
        }

        [Given(@"I enter Email address")]
        public void GivenIEnterEmailAddress()
        {
            registrationPage.EnterEmail();
        }

        [Given(@"I enter phone")]
        public void GivenIEnterPhone()
        {
            registrationPage.EnterPhone();
        }

        [Given(@"I select Gender")]
        public void GivenISelectGender()
        {
            registrationPage.ClickOnGender();
        }

        [Given(@"I select Hobbies")]
        public void GivenISelectHobbies()
        {
            registrationPage.ClickOnHobbies();
        }

        [Given(@"I select Languages")]
        public void GivenISelectLanguages()
        {
           
            registrationPage.ClickOnLanguage();
        }
        [Given(@"I select English")]
        public void GivenISelectEnglish()
        {
            
            registrationPage.ClickOnEnglish();
        }

        [Given(@"I select Skills")]
        public void GivenISelectSkills()
        {
            registrationPage.SelectFromSkills();
        }

        [Given(@"I select Country")]
        public void GivenISelectCountry()
        {
            throw new PendingStepException();
        }

        [Given(@"I select Select Country")]
        public void GivenISelectSelectCountry()
        {
         
            registrationPage.EnterSelectCountry();
        }

        [Given(@"I select year of birth")]
        public void GivenISelectYearOfBirth()
        {
            registrationPage.SelectFromYOB();
        }

        [Given(@"I select month of birth")]
        public void GivenISelectMonthOfBirth()
        {
            registrationPage.SelectFromMOB();
        }

        [Given(@"I select day of birth")]
        public void GivenISelectDayOfBirth()
        {
            registrationPage.SelectFromDOB();
        }

        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            registrationPage.EnterPassword();
        }

        [Given(@"I enter comfirm password")]
        public void GivenIEnterComfirmPassword()
        {
            registrationPage.EnterConfirmPassword();
        }

        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be able to register successfully on the platform")]
        public void ThenIShouldBeAbleToRegisterSuccessfullyOnThePlatform()
        {
            throw new PendingStepException();
        }
    }
}
