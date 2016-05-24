using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Tests
{
    class ApplicationConfirmationPage
    {
        private readonly IWebDriver _driver;

        public ApplicationConfirmationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string FirstName => _driver.FindElement(By.Id("firstName")).Text;
    }
}
