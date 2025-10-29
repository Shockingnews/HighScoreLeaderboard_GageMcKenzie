using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace HighScoreLeaderboard_GageMcKenzie
{
    internal class Program
    {
        static Random score = new Random();
        static void Main(string[] args)
        {
            // string[] Inputs = { };
            Console.Clear();
            string userInput = "";
            int yourscore = score.Next(1, 1001);
            string path = @"data.txt";
            
            string data = File.ReadAllText(path);

            

            Console.WriteLine("write three initials: ");

            userInput = Console.ReadLine();
            while (userInput.Length != 3)
            {
             Console.WriteLine("There isn't three initials try again");
                userInput = Console.ReadLine();
            }
            Console.WriteLine("Your score is: " + yourscore);
            data += (yourscore + " " + userInput + ',');

            string[] test = data.Split(',');

            File.WriteAllText(path, data);
            Array.Sort(test);
            Array.Reverse(test);
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }

            



            //Console.WriteLine(data);




















            //Console.WriteLine(Inputs[0]);

            //if (userInput.Length != 3)
            //{
                //Console.WriteLine("There isn't three initials try again");
            //}

            // Process notepad = Process.Start("notepad.exe", path);


            // for (int i = 0; i < data.Length; i++)
            // {
                // Console.WriteLine(data[i]);
            // }
            
            
            // Thread.Sleep(1000);
            
        }
    }
}
