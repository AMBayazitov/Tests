using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLaunch.Tests
{
    [TestFixture]
    class NoteCreateAndDeleteTests : AuthBase
    {
        [Test]
        public void CreateTest()
        {
            Notification NF = new Notification("test", "test1");
            appMan._noteHelper.CreateNotification(NF);
            appMan._loginHelper.Logout();
        }
        [Test]
        public void NoteDelete()
        { 
            appMan._noteHelper.DeleteLastNotification();
            appMan._loginHelper.Logout();
        }
    }
}
