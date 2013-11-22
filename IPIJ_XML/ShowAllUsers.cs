using System;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;

namespace ITSILESIA.IPIJ.IPIJ_XML
{

    static class ShowAllUsers
    {
        public static void Run()
        {
            XDocument doc = XDocument.Load("../../defect_system.xml");
            XElement root = doc.Root;

            var query = root.Element("users").Elements()
                            .Select(user => new { Name=(string)user.Attribute("name"),
                                                  UserType=(string)user.Attribute("type") });

            foreach (var user in query)
            {
                Console.WriteLine ("{0}: {1}", user.Name, user.UserType);
            }
        }
    }
}
