using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLaunch.Tests
{
    [TestFixture]
    class ValidAndInvalidLogin : AuthBase
    {
        [Test]
        public void ValidLoginTest()
        {
            Notification NF = new Notification("Validation test", "Test passed");
            appMan._noteHelper.CreateNotification(NF);
            appMan._loginHelper.LogOut();
        }

        [Test]
        public void InvalidLoginTest()
        {
            Notification NF = new Notification("Validation test", "Test failed");
            appMan._noteHelper.CreateNotification(NF);
            appMan._loginHelper.LogOut("weterg");
        }
        
    }
}
