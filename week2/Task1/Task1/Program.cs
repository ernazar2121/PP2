using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        
        
            public static bool Palindrome(string s)// check palindrom or not
        {
                for (int i = 0, j = s.Length - 1; i < j; i++, j--)
                if (s[i] != s[j])
                    return false;
                return true;
            }
        
        
        static void Main(string[] args)
        {
            string s; //created string
            s = Console.ReadLine();
            if (Palindrome(s)) //check palindrome line or not with cycle


                Console.WriteLine("Yes");
            
            else
                Console.WriteLine("No");
    

                Console.ReadKey();
        }
    }
}
