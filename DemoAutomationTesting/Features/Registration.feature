Feature: Registration

As a user to access this plaftform,
i need to register on the website

@tag1
Scenario: Validate Registration
	Given I Navigate to "https://demo.automationtesting.in/Register.html"
	And I enter my First Name
	And I enter my Last Name
	And I enter Address
	And I enter Email address
	And I enter phone
	And I select Gender
	And I select Hobbies
	And I select Languages
	#And I select English
	And I select Skills
	#And I select Country
	And I select Select Country
	And I select year of birth
	And I select month of birth
	And I select day of birth
	And I enter password
	And I enter comfirm password
	#When I click on submit button 
	#Then I should be able to register successfully on the platform
