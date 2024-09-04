using System;

namespace StringFunction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string randomString = "This is a String";
            Console.WriteLine("String Length :{0}",randomString.Length);
            Console.WriteLine("String Contains is :{0}", randomString.Contains("is"));
            Console.WriteLine("Index of is :{0}", randomString.IndexOf("is"));
            Console.WriteLine("Remove String :{0}", randomString.Remove(10,6));
            Console.WriteLine("Insert String Short :{0}",randomString.Insert(10,"Short"));
            Console.WriteLine("Replace String :{0}", randomString.Replace("String","Sentence"));
            Console.WriteLine("String Comparison :{0}", string.Compare("A","B",StringComparison.OrdinalIgnoreCase));
            //Compare strings and ignore case
            // < 0 : str1 preceeds str2
            // = : Zero
            // > 0 : str2 preceeds str1
            Console.WriteLine("Pad Left :{0}", randomString.PadLeft(20, '.'));
            Console.WriteLine("Pad Right :{0}", randomString.PadRight(20,'.'));
            Console.WriteLine("A == a :{0}",String.Equals("A","a",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Trim : {0}", randomString.Trim());
            Console.WriteLine("Uppercase :{0}", randomString.ToUpper());
            Console.WriteLine("Lowercase :{0}", randomString.ToLower());

            string newString = String.Format("{0} saw a {1} {2} in the {3}","Peter","rabbit","carrots","fields");
            Console.WriteLine(newString + "\n");

            //Verbatim
            Console.WriteLine(@"Print What I Typed\n");


            Console.ReadKey();
        }
    }
}