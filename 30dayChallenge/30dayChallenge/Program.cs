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
            //Day11();
            Student.Day12();

      
        }

//**************************************************************Day 10 Code Begins**********************************************
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


//**************************************************************Day 11 Code Begins**********************************************
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

 //**************************************************************Day 12 Code Begins**********************************************
//********************** *******************************Class Person begins***************************************************************
    class Person
    {

    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}
//**************************************************Class Student Begins*****************************************************
    class Student:Person
        {
    private int[] testScores;

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string firstName, string lastName, int id, int[] scores)
    {
        base.firstName = firstName;
        base.lastName = lastName;
        base.id = id;
        this.testScores = scores;
    }
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public char Calculate()
    {
        int Result = testScores.Sum() / testScores.Length;
        char[] average = new char[6] { 'O', 'E', 'A', 'P', 'D', 'T' };

        if (Result >= 90 && Result <= 100)
        {
            return average[0];
        }
        else if (Result >= 80 && Result <90)
        {
            return average[1];
        }
        else if (Result >= 70 && Result <80)
        {
            return average[2];
        }
        else if (Result >= 55 && Result <70)
        {
            return average[3];
        }
        else if (Result>=40 && Result <55)
        {
            return average[4];
        }
        else if (Result <40)
        {
            return average[5];
        }
            return '0';


    }
  
        public static void Day12()
        {

            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");

            Console.Read();
        }


}












}

