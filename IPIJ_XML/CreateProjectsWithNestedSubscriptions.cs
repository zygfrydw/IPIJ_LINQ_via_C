using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Model;
using System.ComponentModel;

namespace ITSILESIA.IPIJ.IPIJ_XML
{
    static class CreateProjectsWithNestedSubscriptions
    {
        public static void Run()
        {
            var projects = new XElement("projects",
                from project in SampleData.AllProjects
                select new XElement("project",
                                    new XAttribute("name", project.Name),
                                    from subscription in SampleData.AllSubscriptions
                                    where subscription.Project == project
                                    select new XElement("subscription",
                                        new XAttribute("email", subscription.EmailAddress)
                                    )
                )
            );

            Console.WriteLine(projects);
        }
    }
}
