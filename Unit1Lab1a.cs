using System;

namespace GCLab1Part1
// Created by Aquoinette L Blair
{
    class MainClass
    {
        public static void Main(string[] args) //Method/Function - when program starts

        {
            //Variables
          
            string n1 = "4", n2 = "5";
            int num1 = Convert.ToInt32(n1);
            int num2 = Convert.ToInt32(n2);
            char[] ent1 = new char[4];
            char[] ent2 = new char[4];
          

            /* set parameters for 3 digit inputs so all numbers would
               be the same length. */
            int[] nums = new int[4];


            //user input info and prompts

            {
                Console.WriteLine("Please enter your first 3 digit number");
                n1 = Console.ReadLine();

                Console.WriteLine("Please enter your second 3 digit number");
                n2 = Console.ReadLine();

                //User 3 digit input broken out as 3 individual numbers via array. 

                ent1 = n1.ToCharArray();
                Console.WriteLine(ent1[0]);

                ent2 = n2.ToCharArray();
                Console.WriteLine(ent2[0]);

                ent1 = n1.ToCharArray();
                Console.WriteLine(ent1[1]);

                ent2 = n2.ToCharArray();
                Console.WriteLine(ent2[1]);

                ent1 = n1.ToCharArray();
                Console.WriteLine(ent1[2]); 

                ent2 = n2.ToCharArray();
                Console.WriteLine(ent2[2]);

                int first = (ent1[0] - '0') + (ent2[0] - '0');
                int second = (ent1[1] - '0') + (ent2[1] - '0');
                int third = (ent1[2] - '0') + (ent2[2] - '0');

                Console.WriteLine("Your first place total is " + first);
                Console.WriteLine("Your second place total is " + second);
                Console.WriteLine("Your third place total is " + third);

                //bool;  testing to see if sum totals are the same or not.

                if (first == second)
                {
                    if (second == third){
                        Console.WriteLine("True");
                        
                    }
                    else 
                    {
                        Console.WriteLine("False");   
                    }

                }
                else
                {
                    Console.WriteLine("False");
                }

            }
        

            Console.ReadLine();
           
                
        }


    }
}