using System;

namespace MakeOurListMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> languages = new MyList<string>();
            languages.Add("Turkish");
            Console.WriteLine(languages.LenghtOfArray);
            languages.Add("English");
            Console.WriteLine(languages.LenghtOfArray);
            foreach (var language in languages.ListItems)
            {
                Console.WriteLine(language);
            }
        }
    }
}
