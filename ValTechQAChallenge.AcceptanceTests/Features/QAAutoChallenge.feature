Feature: ValtechWebsite
	In order to view relevant information that I am interested in easily
	As a user
	I want to be shown links to sections for the relevant information

@NavigateToWebsite
Scenario: View Latest News
	Given I am on the valtech Home page
	Then I should see the Latest News section

@ViewSectionPages
Scenario Outline: View Section Pages
	Given I am on the valtech Home page
	When I navigate to the <Section> section
	Then I should see the <Page> page

	Scenarios: 
	| Section  | Page     |
	| ABOUT    | About    |
	| SERVICES | Services |
	| WORK     | Work     |

@ViewValtechOffices
Scenario: Number Of Valtech Offices
	Given I am on the valtech Home page
	When I navigate to the Contact Us page
	Then I should see 39 offices in total
