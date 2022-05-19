using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


// Create new Chrome browser Instance
var Driver = new ChromeDriver();

//navigate to wikipedia
Driver.Url = "https://wikipedia.org";

System.Console.WriteLine("Current Title: " + Driver.Title);


//locate search field by Id
var searchField = Driver.FindElement(By.Id("searchInput"));

//Click on element
searchField.Click();
searchField.SendKeys("QA" + Keys.Enter);

System.Console.WriteLine("Title after search: " + Driver.Title);

// close 
Driver.Quit();