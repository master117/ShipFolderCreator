using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipFolderCreator
{
    class Program
    {
        //This tool creates folders according to all size 2 permutations of a list, in alphabetic order
        static void Main(string[] args)
        {
            //Create List
            List<string> candidates = new List<string>()
            {
                "Honoka",
                "Kotori",
                "Umi",
                "Hanayo",
                "Maki",
                "Rin",
                "Nico",
                "Nozomi",
                "Eli",
                "Chika",
                "You",
                "Riko",
                "Hanamaru",
                "Ruby",
                "Yoshiko",
                "Mari",
                "Dia",
                "Kanan"
            };

            //Sort Alphabetically
            candidates.Sort();

            //2 Loops for size 2
            // Go 1 -> n-1
            for(int i = 0; i < candidates.Count - 1; i++)
            {
                //Go 2 -> n
                for(int j = i + 1; j < candidates.Count; j++)
                {
                    Directory.CreateDirectory(candidates[i] + " x " + candidates[j]);
                }
            }
        }
    }
}
