using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;

namespace _30dayChallenge
{
    class Program
    {
       public  static void Main(string[] args)
        {
            Day10();
        }



        public static void Day10()
        {
          

            
            List<string> final = new List<string>();
            int input  = int.Parse(Console.ReadLine());
            string result = Convert.ToString(input, 2);
           // Console.WriteLine("binary number {0}", result);
           
            char[] number = result.ToCharArray();
            for(int i=0;i<number.Length;i++)
            {   
                if(number[i]=='1')
                {
                    final.Add(number[i].ToString());
                }
                if(number[i]=='0')
                {
                    break;
                }

                
            }
            

            Console.WriteLine(final.Count.ToString());

          Console.Read();
        } 
    
     
    
    }
}
