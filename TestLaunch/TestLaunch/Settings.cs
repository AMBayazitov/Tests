using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using TestLaunch;

namespace TestLaunch
{
    public static class Properties
    {
        public static string file = @"E:\DotNET\Tests\Tests\TestLaunch\TestLaunch\Properties.xml";
        //public static string file = "Properties.xml";
        private static string baseURL;
        private static string login;
        private static string password;

        private static XmlDocument document;

        static Properties()
        {
            if (!File.Exists(file)) { throw new Exception("Settings file not found: "+file); }
            document = new XmlDocument();
            document.Load(file);

        }
        public static string BaseURL
        {
            get
            {
                if (baseURL == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("BaseURL");
                    baseURL = node.InnerText;
                }
                return baseURL;
            }
        }
        public static string Login
        {
            get
            {
                if (login == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("Login");
                    login = node.InnerText;
                }
                return login;
            }
        }
        public static string Password
        {
            get
            {
                if (password == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("Password");
                    password = node.InnerText;
                }
                return password;
            }
        }
    }
}
