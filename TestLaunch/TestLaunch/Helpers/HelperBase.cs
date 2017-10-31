using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLaunch
{
    public class HelperBase
    {
        private bool acceptNextAlert = true;
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        protected ApplicationManager manager;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;

        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        public bool _acceptNextAlert
        {
            get
            {
                return acceptNextAlert;
            }
            set
            {
                acceptNextAlert = value;
            }
        }
    }
}
