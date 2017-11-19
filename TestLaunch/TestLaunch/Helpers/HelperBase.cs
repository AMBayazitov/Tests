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
        public bool IsElementPresent(By by)
        {
            try
            {
                manager._iWebDriver.FindElement(by); //почему напрямую через драйвер не работает?
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

        public string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = manager._iWebDriver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (_acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                _acceptNextAlert = true;
            }
        }

    }
}
