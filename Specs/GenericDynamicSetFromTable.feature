Feature: Create generic dynamic sets objects from SpecFlow table
	In order to have more control of value types
	As a user of SpecFlow Dynamic
	I want to use generics to specify the type for the created set of dynamic objects from a table

Scenario Outline: Create set of dynamic objects with all properties able to cast to string and bool
	When I create a set of dynamic instances from this table of type '<type>'
		| Property1 | Property2 | Property3 | Property4 |
		| true      | false     | true      | false     |
		| false     | true      | false     | true      |
		| true      | false     | true      | false     |
		| false     | true      | false     | true      |
	Then I should have a list of 4 dynamic objects
	And each item should be of type '<type>'

	Examples: 
	| type     |
	| string   |
	| bool     |
	#| int      |
	#| double   |
	#| DateTime |

Scenario Outline: Create set of dynamic objects with all properties able to cast to string, int, and double
	When I create a set of dynamic instances from this table of type '<type>'
		| Property1 | Property2 | Property3 | Property4 |
		| 0         | 1         | 0         | 1         |
		| 0         | 1         | 0         | 1         |
		| 0         | 1         | 0         | 1         |
		| 0         | 1         | 0         | 1         | 
	Then I should have a list of 4 dynamic objects
	And each item should be of type '<type>'
	
	Examples:
	| type     |
	| string   |
	| int      |
	| double   |
	#| DateTime |
	#| bool     |

Scenario Outline: Create set of dynamic objects with all properties able to cast to string and DateTime
	When I create a set of dynamic instances from this table of type '<type>'
		| Property1        | Property2        | Property3           | Property4               |
		| 1901-05-31       | 1901-05-31 10:03 | 1901-05-31 10:03:05 | 1901-05-31 10:03:06.231 |
		| 1901-05-31 10:03 | 1901-05-31 10:03 | 1901-05-31 10:03    | 1901-05-31 10:03        |
		| 1901-05-31 10:03 | 1901-05-31 10:03 | 1901-05-31 10:03    | 1901-05-31 10:03        |
		| 1901-05-31 10:03 | 1901-05-31 10:03 | 1901-05-31 10:03    | 1901-05-31 10:03        |
	Then I should have a list of 4 dynamic objects
	And each item should be of type '<type>'
	
	Examples:
	| type     |
	| string   |
	| DateTime |
	#| int      |
	#| double   |
	#| bool     |

Scenario Outline: Create set of dynamic objects with no properties able to cast to DateTime
	When I create a set of dynamic instances from this table of type '<type>'
		| Property1 | Property2 | Property3 | Property4 |
		| 0         | 1         | 0         | 1         |
		| 0         | 1         | 0         | 1         |
		| 0         | 1         | 0         | 1         |
		| 0         | 1         | 0         | 1         |
	Then I should have a list of 4 dynamic objects
	And each item should be of type 'string'
	
	Examples:
	| type     |
	| DateTime |
	#| int      |
	#| double   |
	#| bool     |