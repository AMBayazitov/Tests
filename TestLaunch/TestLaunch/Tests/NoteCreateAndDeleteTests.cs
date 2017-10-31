using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLaunch.Tests
{
    [TestFixture]
    class NoteCreateAndDeleteTests : TestBase
    {
        [Test]
        public void CreateTest()
        {
            AccountData AD = new AccountData("SaturnAlla", "a'q]w[ep");
            Notification NF = new Notification("test", "test1");
            appMan._loginHelper.Login(AD);
            appMan._noteHelper.CreateNotification(NF);
            appMan._loginHelper.LogOut();
        }
        [Test]
        public void NoteDelete()
        {
            AccountData AD = new AccountData("SaturnAlla", "a'q]w[ep");
            appMan._loginHelper.Login(AD);
            appMan._noteHelper.DeleteLastNotification();
            appMan._loginHelper.LogOut();
        }
    }
}
