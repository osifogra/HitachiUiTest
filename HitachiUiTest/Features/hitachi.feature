Feature: Hitachi search

#The Problem:
#We want to automate crucial user work flows for https://global.hitachi-solutions.com/ site.
#We need to cover the following functionalities :

#User can successfully navigate to the site
#User can successfully search for keywords
#User can successfully open returned search results
#The Solution:
#
#- Please code up a suite of functional test cases in the language of your choice
#- Include both positive and negative cases
#- Be able to quantify the number of distinct tests run
#- Clearly articulate your assumption


@searchTest
Scenario Outline: Verify that user can search when on the Hitachi site
	Given I navigate to Hitachi site
	When I choose to enter '<SearchText>' as my search text
	Then I should see '<SearchText>' search result return
	When I choose to select '<SearchText>'
	Then I should see 'Data & Analytics' page displayed
Examples: 
		| SearchText         |
		| Data and Analytics |
	

@searchTest
Scenario Outline: Verify that user can search does NOT return any result
	Given I navigate to Hitachi site
	When I choose to enter '<SearchText>' as my search text
	Then I should see "Sorry, your search didn't return any results." message returned
Examples: 
		| SearchText  |
		| Testing1234 |
