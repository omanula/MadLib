using System;

namespace MadLib
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /* A Dove saw an Ant fall into a brook. The Ant struggled in 
             * vain to reach the bank, and in pity, the Dove dropped a 
             * blade of straw close beside it. Clinging to the straw like 
             * a shipwrecked sailor to a broken spar, the Ant floated safely
             * to shore.
             * Soon after, the Ant saw a man getting ready to kill the Dove
             * with a stone. But just as he cast the stone, the Ant stung
             * him in the heel, so that the pain made him miss his aim, and 
             * the startled Dove flew to safely in a distant wood. 
             * 
             * A kindness is never wasted. 
             */


            Console.WriteLine("Mad Lib : The And and The _____");
            Console.WriteLine("");
            Console.WriteLine("Pick an animal ");
            String animal = Console.ReadLine();
            Console.WriteLine("Pick a noun");
            String where = Console.ReadLine();
            Console.WriteLine("Pick another noun ");
            String noun = Console.ReadLine();
            Console.WriteLine("Pick a past tense action verb ");
            String verb1 = Console.ReadLine();
            Console.WriteLine("Pick an action verb ");
            String verb2 = Console.ReadLine();
            Console.WriteLine("Pick an adjective ");
            String adjective = Console.ReadLine();

            Console.Write("A Dove saw a(n) {0}", animal);
            Console.Write(" fall into a {0}", where);
            Console.Write("The {0}", animal);        
            Console.Write(" struggled in vain to reach the bank, and in pity, ");
            Console.Write("the Dove dropped a {0}", noun);
            Console.Write(" close beside it. Clinging to the {0}", noun);
            Console.Write(" like a shipwrecked sailor to a broken spar, the {0}", animal);
            Console.Write(" {0}", verb1);
            Console.Write(" safely to shore.");
            Console.Write(" Soon after, the {0}", animal);
            Console.Write(" saw a man getting ready to {0}", verb2);
            Console.Write(" the Dove with a stone. But just as he cast the stone");
            Console.Write(" the {0}", animal);
            Console.Write(" stung him in the heel, so that the pain made him miss");
            Console.Write(" his aim, and the startled");
            Console.Write(" Dove flew to safety in a {0}", adjective);
            Console.Write(" wood.");
            Console.WriteLine("");
            Console.Write("A kindness is never wasted.");



            /*
            Console.Write("Pick a noun ");
            String noun1 = Console.ReadLine();
            Console.WriteLine("Hello, {0}", noun1);


*/



        }
    }
}
