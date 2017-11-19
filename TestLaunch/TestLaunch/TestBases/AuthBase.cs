using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLaunch
{
    class AuthBase : TestBase
    {
        [SetUp]
        public void AuthTest()
        {
            AccountData AD = new AccountData("SaturnAlla", "a'q]w[ep");
            appMan._loginHelper.Login(AD);
        }
    }
}
