using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_KatelynNicholson
{
    internal class Program
    {
        //elements of the array "element" 
        static string[] partyNames = { "Number1", "Number2", "Number3", "Number4" };
        static int[] partyLevels = new int[4];

        static void Main()
        {
            partyLevels[0] = 1;
            partyLevels[1] = 1;
            partyLevels[2] = 1;
            partyLevels[3] = 1;

            LevelUpPartyMember("Number2");
            LevelUpPartyMember("Number2");
            LevelUpPartyMember("Number2");
            LevelUpPartyMember("Number3");
            LevelUpPartyMember("Number3");
            LevelUpPartyMember("Number3");
            LevelUpPartyMember("Number4");

            Console.WriteLine(partyLevels[0]);
            Console.WriteLine(partyLevels[1]);
            Console.WriteLine(partyLevels[2]);
            Console.WriteLine(partyLevels[3]);
            Console.WriteLine(partyLevels[4]);

            Console.ReadKey();

        }

        static void LevelUpPartyMember(string memberName)
        {
            int indextofPartyMember = Array.IndexOf(partyNames, memberName);

            partyLevels[indextofPartyMember] += 1;
        }
    }
}
