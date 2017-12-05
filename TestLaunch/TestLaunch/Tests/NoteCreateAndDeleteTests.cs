using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestLaunch.Tests
{
    [TestFixture]
    class NoteCreateAndDeleteTests : AuthBase
    {
        [Test, TestCaseSource("NotesFromXmlFile")]
        public void CreateTest(Notification note)
        {
            Notification NF = new Notification(note.Title, note.Note);
            appMan._noteHelper.CreateNotification(NF);
            appMan._loginHelper.Logout();
            //Assert.AreEqual(NF.Title, "test");
            //Assert.AreEqual(NF.Note, "test1");
        }
        [Test]
        public void NoteDelete()
        { 
            appMan._noteHelper.DeleteLastNotification();
            appMan._loginHelper.Logout();
        }

        public static IEnumerable<Notification> NotesFromXmlFile()
        {
            return (List<Notification>)new XmlSerializer(typeof(List<Notification>))
                .Deserialize(new StreamReader(@"E:\DotNET\Tests\Tests\TestLaunch\Generator\bin\Release\notes.xml"));
        }

    }
}
