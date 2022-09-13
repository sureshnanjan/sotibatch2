Feature: BinarySearcher
	The Binary Search mechanism allows to look for  element in a sequence of items.

@mytag
Scenario: An existing element returns the Index of the element within the sorted array
	Given A Sorted Array has these elements 1,2,3,4
	When I search for 4
	Then the search result should be 3

Scenario: An non existing element returns the 2s Complement of the element higher than that
	Given A Sorted Array has these elements 2,4,6,8
	When I search for 5
	Then the search result should be complement of 2