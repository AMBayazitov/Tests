using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLaunch.Tests
{
    [TestFixture]
    class ValidAndInvalidLogin : TestBase
    {
        [Test]
        public void ValidLoginTest()
        {
            AccountData AD = new AccountData("SaturnAlla","a'q]w[ep");
            Notification NF = new Notification("Validation test", "Test passed");
            appMan._loginHelper.Login(AD);
            appMan._noteHelper.CreateNotification(NF);
            appMan._loginHelper.Logout();
        }

        [Test]
        public void InvalidLoginTest()
        {
            AccountData AD = new AccountData("SaturnAlla", "a'q]w[ep");
            Notification NF = new Notification("Validation test", "Test failed");
            appMan._loginHelper.Login(AD);
            appMan._noteHelper.CreateNotification(NF);
            appMan._loginHelper.Logout();
        }
        
    }
}
