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
           // Day10();
            Day11();
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
    
      public static void Day11()
        {

            int[][] arr = new int[6][];


            arr[0] = new int[] { 1,1,1,0,0,0 };
            arr[1] = new int[] { 0,1,0,0,0,0 };
            arr[2] = new int[] { 1,1,1,0,0,0 };
            arr[3] = new int[] { 0,0,2,4,4,0 };
            arr[4] = new int[] { 0,0,0,2,0,0 };
            arr[5] = new int[] { 0,0,1,2,4,0 };


    
                //for (int arr_i = 0; arr_i < 6; arr_i++)
                //{
                //    string[] arr_temp = Console.ReadLine().Split(' ');
                //    arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
                //}

            int h = 0;
            // int[] Result = new int[16
            int[] Sum = new int[16];

            for(int i=0; i<4;i++)
            {
                for ( int j=0; j<4;j++)
                {

                    Sum[h] = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    Console.WriteLine(Sum[h]);
                    h++;
                }
                
            }
            

            int Result= Sum.Max();

            Console.WriteLine(Result);

            Console.Read();
        }

      
    }
}
