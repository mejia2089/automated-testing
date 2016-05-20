Automated Business Readable Web Tests with Selenium and SpecFlow

1. Getting started with Selenium.

* Create class library project for testing.
* Install unit testing framework (xUnit.net).
* Install test runner (xunit.runner.visualstudio).
* Install Selenium.WebDriver.
* After setup, create basic tests to navigate the Loan Application
web site and populate application form. 

2. Adding business readability with SpecFlow.
* Why SpecFlow?
** Documents features in non-technical way.
** Useful for onboarding and in audit situations.
** Living document that is executable and source controlled.
** Better communication of correct features that reduces wasted time and effort (you don't spend time building wrong or unneeded features). Everyone is on the same page.
* Overview of SpecFlow
** SpecFlow Feature File maps to methods in C# class where test code is written--calls in Selenium webdriver api. 
** Feature File: Header, one or more scenarios that have logical steps (high level, non-technical)
** Gherkin steps: scenario: given, when, then
* Installing SpecFlow
** SpecFlow.xunit
** SpecFlow Visual Studio Extension
* UI Automation Styles
** Declarative Style (Less detail, more business readable, UI agnostic, data agnostic)
** Imperative Style (also UI agnostic)
** Code Style (More detail, more developer oriented)
** Not all scenarios/featurs have to use same style.




3. Creating more maintainable web automation.