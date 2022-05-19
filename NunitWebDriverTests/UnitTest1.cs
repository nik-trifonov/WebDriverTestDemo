using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitWebDriverTests
{
    public class SoftUniTests
    {
        private WebDriver driver;

        [OneTimeSetUp]
        public void OpenBrowserAndNavigate()
        {
            this.driver = new ChromeDriver();
            driver.Url = "https://softuni.bg";
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void ShutDown()
        {
            driver.Quit();
        }

        [Test]
        public void AssertMainPageTitle()
        {
           
            //Act
            driver.Url = "https://softuni.bg";
            string expectedTitle = "�������� �� ������������ - ��������� �����������";
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));
            //
            
         }

        [Test]
        public void Test_AssertAboutUsTitle()
        {
            
            
            driver.Url = "https://softuni.bg";
           
            var zaNasElement = driver.FindElement(By.CssSelector("#header-nav > div.toggle-nav.toggle-holder > ul > li:nth-child(1) > a > span"));
            zaNasElement.Click();
            string expectedTitle = "�� ��� - ��������� �����������";

            Assert.That(driver.Title, Is.EqualTo(expectedTitle));
            //
            
        }


    }

}