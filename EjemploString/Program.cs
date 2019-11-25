using System;

namespace EjemploString
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "      HOLA mundo HOLA mundo HOLA!!!      ";

            string cadena2 = "HOLA mundo";

            //Contains    //ver en clase
            Console.WriteLine("Contains");
            Console.WriteLine(cadena.Contains("mundo"));
            Console.WriteLine(cadena.Contains("hola"));
            Console.WriteLine();

            //CompareTo
            Console.WriteLine("CompareTo");
            Console.WriteLine(cadena2.CompareTo(null));
            Console.WriteLine(cadena2.CompareTo("HOLA"));
            Console.WriteLine(cadena2.CompareTo("HOLA mundo"));
            Console.WriteLine(cadena2.CompareTo("MUNDO"));
            Console.WriteLine();

            //Compare
            Console.WriteLine("Compare");
            Console.WriteLine(string.Compare(cadena2, null));
            Console.WriteLine(string.Compare(cadena2, "HOLA"));
            Console.WriteLine(string.Compare(cadena2, "HOLA mundo"));
            Console.WriteLine(string.Compare(cadena2 , "MUNDO"));
            Console.WriteLine();
            
            //StartsWith
            Console.WriteLine("StartsWith");
            Console.WriteLine(cadena2.StartsWith("H"));
            Console.WriteLine(cadena2.StartsWith("h"));
            Console.WriteLine();

            //StartsWith
            Console.WriteLine("EndsWith");
            Console.WriteLine(cadena2.StartsWith("k"));
            Console.WriteLine(cadena2.StartsWith("o"));
            Console.WriteLine(cadena2.StartsWith("O"));
            Console.WriteLine();

            //IndexOf
            Console.WriteLine("IndexOf");
            Console.WriteLine(cadena2.IndexOf("k"));
            Console.WriteLine(cadena2.IndexOf("o"));
            Console.WriteLine(cadena2.IndexOf("A"));
            Console.WriteLine();

            //LastIndexOf
            Console.WriteLine("LastIndexOf");
            Console.WriteLine(cadena2.IndexOf("k"));
            Console.WriteLine(cadena2.IndexOf("o"));
            Console.WriteLine(cadena2.IndexOf("A"));
            Console.WriteLine();

            //Equals
            Console.WriteLine("Equals");
            Console.WriteLine(cadena2.Equals("HOLA mundo"));
            Console.WriteLine(cadena2.Equals("hola mundo"));
            Console.WriteLine(cadena2.Equals("lalala"));
            Console.WriteLine();

            //Insert
            Console.WriteLine("Insert");
            Console.WriteLine(cadena2.Insert(2, "nueva cadena"));
            // Console.WriteLine(cadena2.Insert(20, "nueva cadena"));
            // Console.WriteLine(cadena2.Insert(-1, "nueva cadena"));
            Console.WriteLine();

            //Length
            Console.WriteLine("Length");
            Console.WriteLine(cadena2.Length);
            Console.WriteLine();
            
            //Remove
            Console.WriteLine("Remove");
            Console.WriteLine(cadena2.Remove(4));
            Console.WriteLine(cadena2.Remove(3, 4));
            Console.WriteLine();

            //Replace
            Console.WriteLine("Replace");
            Console.WriteLine(cadena2.Replace('m', 'w'));
            Console.WriteLine(cadena2.Replace("HOLA", "CHAU"));
            Console.WriteLine();

            //Subtring
            Console.WriteLine("Substring");
            Console.WriteLine(cadena2.Substring(3));
            Console.WriteLine(cadena2.Substring(3, 4));
            Console.WriteLine();

            //ToLower
            Console.WriteLine("ToLower");
            Console.WriteLine(cadena2.ToLower());
            Console.WriteLine();

            //ToUpper
            Console.WriteLine("ToUpper");
            Console.WriteLine(cadena2.ToUpper());
            Console.WriteLine();

            //Trim
            Console.WriteLine("Trim");
            Console.WriteLine("-{0}-", cadena.Trim());
            Console.WriteLine();

            //TrimStart
            Console.WriteLine("TrimStart");
            Console.WriteLine("-{0}-", cadena.TrimStart());
            Console.WriteLine();

            //TrimEnd
            Console.WriteLine("TrimEnd");
            Console.WriteLine("-{0}-", cadena.TrimEnd());
            Console.WriteLine();
        }
    }
}
