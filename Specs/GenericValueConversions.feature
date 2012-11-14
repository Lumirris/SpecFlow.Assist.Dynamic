Feature: Generic conversions of values
	In order to have more control of value types
	As a user of SpecFlow Dynamic
	I want to use generics to specify the type into which to convert strings


Scenario: Strings should be converted to type 'string'
	When I create a generic dynamic instance from this table of type 'string'
	| value  |
	| Marcus |
	Then the Name property should be of type 'string' and equal 'Marcus'

Scenario: Strings should be converted to type 'int'
	When I create a generic dynamic instance from this table of type 'int'
	| value |
	| 39    |
	Then the Age property should be of type 'int' and equal '39'

Scenario: Strings should be converted to type 'double'
	When I create a generic dynamic instance from this table of type 'double'
	| value |
	| 1.96  |
	Then the LengthInMeters property should be of type 'double' and equal '1.96'

Scenario: Strings should be converted to type 'DateTime'
	When I create a generic dynamic instance from this table of type 'DateTime'
	| value      |
	| 1972-10-09 |
	Then the BirthDate property should be of type 'DateTime' and equal '1972-10-09'

Scenario: Strings should be converted to type 'bool'
	When I create a generic dynamic instance from this table of type 'bool'
	| value |
	| false |
	Then the IsDeveloper property should be of type 'bool' and equal 'false'