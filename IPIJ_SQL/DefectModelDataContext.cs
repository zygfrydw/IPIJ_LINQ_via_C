using System;
namespace ITSILESIA.IPIJ.IPIJ_SQL
{
    partial class Defect
    {
        public override string ToString()
        {
            return Summary + " " + Created.ToShortDateString();
        } 
    }
}
