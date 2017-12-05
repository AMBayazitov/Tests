using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestLaunch.Tests
{
    [TestFixture]
    class ValidAndInvalidLogin : TestBase
    {
        [Test]
        public void ValidLoginTest()
        {
            AccountData AD = new AccountData(Properties.Login,Properties.Password);
            Notification NF = new Notification("Validation test", "Test passed");
            appMan._loginHelper.Login(AD);
            Thread.Sleep(5000);
            //appMan._noteHelper.CreateNotification(NF);
            appMan._loginHelper.Logout();
            Assert.AreEqual(AD.UserName, "SaturnAlla");
        }

        [Test]
        public void InvalidLoginTest()
        {
            AccountData AD = new AccountData(Properties.Login,Properties.Password);
            Notification NF = new Notification("Validation test", "Test failed");
            appMan._loginHelper.Login(AD);
            Thread.Sleep(5000);
            //appMan._noteHelper.CreateNotification(NF);
            appMan._loginHelper.Logout();
            Assert.AreNotEqual(AD.UserName, "SaturnAlla");
        }
        
    }
}
