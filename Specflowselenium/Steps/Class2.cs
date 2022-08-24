using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace Specflowselenium.Features
{

    [Binding]
    class Class2
    {

        IWebDriver driver;
        
        [Given(@"i have navigated to google pages")]
        public void GivenIHaveNavigatedToGooglePages()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://www.google.com/");
        }
        
        [Given(@"i see google page is fully loaded")]
        public void GivenISeeGooglePageIsFullyLoaded()
        {
            IWebElement linksearch = driver.FindElement(By.XPath("//input[@class='gLFyf gsfi']"));


            if (linksearch.Displayed == true)
            {
                Console.WriteLine("page fully loaded ");
            }
            else
                Console.WriteLine("page not fuly laoded ");
        }

        [When(@"i type search Keyword as")]
        public void WhenITypeSearchKeywordAs(Table table)
        {
            dynamic tabledetali = table.CreateDynamicInstance();
            driver.FindElement(By.XPath("//input[@class='gLFyf gsfi']")).SendKeys(tabledetali.Keyword);
            driver.FindElement(By.XPath("//input[@class='gLFyf gsfi']")).SendKeys(Keys.Return);
        }

        [Then(@"i should see the result of Keyboard as")]
        public void ThenIShouldSeeTheResultOfKeyboardAs(Table table)
        {
            dynamic tabledetali = table.CreateDynamicInstance();
            IWebElement keyexecute = driver.FindElement(By.PartialLinkText("ExecuteAutomation"));
            {
                if (keyexecute.Displayed == true)
                    keyexecute.Click();

                else
                    Console.WriteLine("bhai kuch na ho payega ");

            }

        }

    }
}
