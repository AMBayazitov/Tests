using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLaunch.Helpers;

namespace TestLaunch
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager manager) : base(manager) { }
        public void Login(AccountData AD)
        {
            manager._navigation.GoToHome();
            manager._iWebDriver.FindElement(By.LinkText("Вход")).Click();
            manager._iWebDriver.FindElement(By.LinkText("Вход")).Click();
            manager._iWebDriver.FindElement(By.Name("login")).Clear();
            manager._iWebDriver.FindElement(By.Name("login")).SendKeys(AD.UserName);
            manager._iWebDriver.FindElement(By.Name("psswd")).Clear();
            manager._iWebDriver.FindElement(By.Name("psswd")).SendKeys(AD.Password);
        }
        public void LogOut()
        {
            manager._iWebDriver.FindElement(By.LinkText("Выход")).Click();
        }

    }
    
}
