using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Det_var_en_gång
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad älskar du mest?");
            string ord = Console.ReadLine();
            Console.WriteLine("Vad hatar du mest?");
            string ord2 = Console.ReadLine();
            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine("Favoritmöbel?");
            string ord4 = Console.ReadLine();
            Console.WriteLine("Det var en grabb, han bodde i staden.");
            Console.WriteLine("Han var många år gammal och hans bästa vän hade ett namn");
            Console.WriteLine("Vännen " + namn +  " var lika många år gammal som grabben");
            
            Console.WriteLine("Han äskade " + ord + " och hatade " + ord2);
            Console.WriteLine("Sen ramla han från en " + ord4);
        }
    }
}
