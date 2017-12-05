using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TestLaunch;

namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = args[0];
            int count = Convert.ToInt32(args[1]);
            string filename = args[2];
            string format = args[3];
            if (type == "notes")
            {
                GenerateForNotes(count, filename, format);
            }
            else
            {
                Console.Out.Write("Unrecognized type of data" + type);
            }
        }

        static void GenerateForNotes(int count, string filename, string format)
        {
            List<Notification> notes = new List<Notification>();
            for (int i = 0; i < count; i++)
            {
                notes.Add(new Notification(GenerateRandomString(10), GenerateRandomString(12))
                {
                    Title = GenerateRandomString(20),
                    Note = GenerateRandomString(20)
                });
            }
            StreamWriter writer = null;
            if (format == "xml")
            {
                writer = new StreamWriter(filename);
                WriteGroupsToXmlFile(notes, writer);

            }
            else
            {
                Console.Out.Write("Unrecognized format" + format);
            }
            writer.Close();
        }

        static void WriteGroupsToXmlFile(List<Notification> notes, StreamWriter writer)
        {
            new XmlSerializer(typeof(List<Notification>)).Serialize(writer, notes);
        }
        public static Random rnd = new Random();
        public static string GenerateRandomString(int num)
        {
            int l = Convert.ToInt32(rnd.NextDouble() * num);
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < l; i++)
            {
                builder.Append(Convert.ToChar(65 + Convert.ToInt32(rnd.NextDouble() * 26)));
            }
            return builder.ToString();
        }
    }
}
