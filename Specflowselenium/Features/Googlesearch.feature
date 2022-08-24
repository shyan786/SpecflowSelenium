Feature: Calculator

@mytag
Scenario: Google search for execute automation 

	Given i have navigated to google pages
	And i see google page is fully loaded
	When i type search Keyword as 
	| Keyword            |
	| execute automation |

	Then i should see the result of Keyboard as

	| Keyboard           |
	| Execute automation |
