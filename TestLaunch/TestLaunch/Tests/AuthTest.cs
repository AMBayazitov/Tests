using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLaunch.Tests
{
    [TestFixture]
    class AuthTest : TestBase
    {
        [Test]
        public void AuthTest1()
        {
            AccountData AD = new AccountData("SaturnAlla", "a'q]w[ep");
            Notification NF = new Notification("test", "test1");
            appMan._noteHelper.CreateNotification(NF);
            appMan._loginHelper.LogOut();
        }
        
    }
}
