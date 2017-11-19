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
            //manager._iWebDriver.FindElement(By.LinkText("Вход")).Click();
            //manager._iWebDriver.FindElement(By.LinkText("Вход")).Click();
            manager._iWebDriver.FindElement(By.ClassName("login-link")).Click();
            manager._iWebDriver.FindElement(By.Name("login")).Clear();
            manager._iWebDriver.FindElement(By.Name("login")).SendKeys(AD.UserName);
            manager._iWebDriver.FindElement(By.Name("psswd")).Clear();
            manager._iWebDriver.FindElement(By.Name("psswd")).SendKeys(AD.Password);
        }
        public void LogOut()
        {
                if (IsLoggedIn())
               {
                    manager._iWebDriver.FindElement(By.LinkText("Выход")).Click();
               }
        }
        public bool IsLoggedIn()
        {   
            return IsElementPresent(By.LinkText("Выход"));
        }
        public bool IsLoggedIn(string username)
        {
            string tempUser = manager._iWebDriver.FindElement(By.ClassName("f_title")).Text;
            if (tempUser == username) { return true; }
            return false;
        }
        public void LogOut(string uname)
        {
            if (IsLoggedIn(uname))
            {
                manager._iWebDriver.FindElement(By.LinkText("Выход")).Click();
            }
        }
    }
    
}
