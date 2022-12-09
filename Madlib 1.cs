using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string KingName;
            string Kingplace;
            string Queenname;
            string Queenplace;
            string Sonname;
            string Sonsplace;
            string Enemyking;
            string Enemyplace;
            string win;
            string Story;

            //write header and instructions
            Console.WriteLine("-------");
            Console.WriteLine("Madlib!");
            Console.WriteLine("-------");

            //ask player to enter words
            Console.Write("Please enter a name of any king : ");
            KingName = Console.ReadLine();

            Console.Write("Please enter a name of any place 1: ");
            Kingplace = Console.ReadLine();

            Console.Write("Please enter a name of any queen: ");
            Queenname = Console.ReadLine();

            Console.Write("Please enter a name of place 2: ");
            Queenplace = Console.ReadLine();

            Console.Write("Please enter a name of son: ");
            Sonname = Console.ReadLine();

            Console.Write("Please enter a name of place 3: ");
            Sonsplace = Console.ReadLine();

            Console.Write("Please enter a name of enemy king: ");
            Enemyking = Console.ReadLine();

            Console.Write("Please enter a name of any place 4: ");
            Enemyplace = Console.ReadLine();

            Console.Write("Please enter a similar word of win: ");
            win = Console.ReadLine();


            //write out story
            Story = "Once there was a king named " + KingName + " of " + Kingplace + ". He loves a queen " + Queenname + " of " + Queenplace + ". Then he goes for his marriage proposal. Then after the queen " + Queenname + " accept for his proposal. After that they built a palace at " + Sonsplace + " for his son named " + Sonname + ". Then one day " + Enemyking + " the king of " + Enemyplace + " attcked at " + Sonsplace + " but " + KingName + " and his son both fight and get a " + win + " against " + Enemyking + ".";
            Console.WriteLine(Story);

            //keep window open and prompt for exit
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
    }
}
