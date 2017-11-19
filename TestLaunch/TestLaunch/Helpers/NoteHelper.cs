using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestLaunch
{
    public class NoteHelper : HelperBase
    {
        public NoteHelper(ApplicationManager manager) : base(manager) { }
        public void CreateNotification(Notification NF)
        {
            manager._navigation.GoToMyDiary();
            manager._iWebDriver.FindElement(By.Id("title")).Clear();
            manager._iWebDriver.FindElement(By.Id("title")).SendKeys(NF.Title);
            //manager._iWebDriver.FindElement(By.Id("imp_redactor_frame_itemtext")).SendKeys(manager._iWebDriver.FindElement(By.ClassName("f_title")).Text);
            manager._iWebDriver.FindElement(By.Id("imp_redactor_frame_itemtext")).SendKeys(NF.Note);
            try
            {
                manager._iWebDriver.FindElement(By.CssSelector("a.close")).Click();
            }
            catch { }
            manager._iWebDriver.FindElement(By.CssSelector("input.button-input")).Click();
        }


        public void DeleteLastNotification()
        {
            manager._navigation.GoToMyDiary();
            manager._navigation.GoToAllNotes();
            manager._iWebDriver.FindElement(By.CssSelector("img[alt=\"Удалить\"]")).Click();
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Запись будет удалена, продолжить[\\s\\S]$"));
            manager._iWebDriver.FindElement(By.CssSelector("input.button-input")).Click();
        }

       

    }
}
