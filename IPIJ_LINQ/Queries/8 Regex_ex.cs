using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ITSILESIA.IPIJ_LINQ.Queries
{
    /// <summary>
    /// The listings are scattered around .cs files within various directories.
    /// This class uses LINQ to find all classes with a suitable Description
    /// attribute, groups them by chapters and orders them by chapter and listing number.
    /// </summary>
    class DisplayListingsMap
    {

        //    [Description("Listing 11.11")]
        static readonly Regex ListingPattern = new Regex(
           @"\[Description\(\""Listing\ 
            (?<text>
            (?<chapter>\d+)\.
            (?<listing>\d+)            
            [^\""]*)\""\)\]",
            RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace);

        public static void Run()
        {
            DirectoryInfo directory = new DirectoryInfo(@"..\..\C# in Depth");

            var query = from file in directory.GetFiles("*.cs", SearchOption.AllDirectories)
                        let match = ListingPattern.Match(File.ReadAllText(file.FullName))
                        where match.Success
                        let Details = new
                        {
                            Text = match.Groups["text"].Value,
                            Chapter = int.Parse(match.Groups["chapter"].Value),
                            Listing = int.Parse(match.Groups["listing"].Value)
                        }
                        orderby Details.Chapter, Details.Listing
                        group new { File = file, Description=Details.Text } by Details.Chapter;

            foreach (var chapter in query)
            {
                Console.WriteLine("Chapter {0}", chapter.Key);
                foreach (var listing in chapter)
                {
                    Console.WriteLine("{0}: {1}", listing.Description, listing.File.Name);
                }
                Console.WriteLine();                
            }
        }
    }
}
