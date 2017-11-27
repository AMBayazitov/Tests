using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TestLaunch
{
    public class TestBase
    {
        protected ApplicationManager appMan;
        [SetUp]
        public void SetupTest()
        {
            appMan = ApplicationManager.GetInstance();
        }
    }
}
