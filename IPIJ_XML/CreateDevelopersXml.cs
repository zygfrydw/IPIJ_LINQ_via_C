using System;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;

using Model;

namespace ITSILESIA.IPIJ.IPIJ_XML
{
    static class CreateDevelopersXml
    {
        public static void Run()
        {
            var developers = new XElement("developers",
                from user in SampleData.AllUsers
                where user.UserType == UserType.Developer
                select new XElement("developer", user.Name)
            );
            Console.WriteLine(developers);
        }
    }
}
