using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLaunch.Helpers
{
    public class NavigationHelper : HelperBase
    {
        public NavigationHelper(ApplicationManager manager) : base(manager) { }

        public void GoToHome()
        {
            manager._iWebDriver.Navigate().GoToUrl("https://www.mywishbook.ru/");
        }
        public void GoToAllNotes()
        {
            manager._iWebDriver.Navigate().GoToUrl("https://www.mywishbook.ru/mydiary/all");
        }
        public void GoToMyDiary()
        {
            manager._iWebDriver.FindElement(By.CssSelector("input.button-input")).Click();
            manager._iWebDriver.FindElement(By.LinkText("Мой личный дневник")).Click();

        }
    }
}
