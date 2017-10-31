using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLaunch.Helpers;

namespace TestLaunch
{
    public class ApplicationManager
    { 
        private IWebDriver driver;
        private string baseURL;
        private LoginHelper auth;
        private NoteHelper note;
        private NavigationHelper navigation;
        
        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.mywishbook.ru/";
            auth = new LoginHelper(this);
            note = new NoteHelper(this);
            navigation = new NavigationHelper(this);
        }
        public IWebDriver _iWebDriver
        {
            get
            {
                return driver;
            }
        }
        public LoginHelper _loginHelper
        {
            get
            {
                return auth;
            }
        }
        public NoteHelper _noteHelper
        {
            get
            {
                return note;
            }
        }
        public NavigationHelper _navigation
        {
            get
            {
                return navigation;
            }
        }
        public string _baseURL
        {
            get
            {
                return baseURL;
            }
            set
            {
                baseURL = value;
            }
        }
        public void Stop()
        {
            driver.Quit();
        }

    }
}
