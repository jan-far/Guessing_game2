using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomGenerator generator = new RandomGenerator();
            int rand = 0;
            int counts = 0;
            int guess = 0;
            string user_input = "";
            
            int[] count = new int [3];
            count[0] = 6;
            count[1] = 4;
            count[2] = 3;

            Console.WriteLine("There are 3 levels, EASY, MEDIUM and HARD\n");

            while (true)
            {
                 Console.Write("Choose your level: ");
                 user_input = Console.ReadLine().ToUpper();

                 if (user_input == "EASY"){
                     counts = count[0];
                     rand = generator.RandomNumber(1,10);
                     while (counts != 0){
                         Console.Write("\nEnter your guess: ");
                         guess = int.Parse(Console.ReadLine());
                         counts -=1;

                         if (guess == rand){
                             Console.WriteLine("YOU GOT IT RIGHT!");
                     break;
                         }
                         else{
                             Console.WriteLine("\nThat was wrong!");
                             if (counts > 1){
                                 Console.WriteLine($"You have {counts} guesses left\n");
                             }
                             else if (counts == 1){
                                 Console.WriteLine($"You have {counts} guess left\n");
                             }
                         }
                     }
                     if (counts == 0){
                         Console.WriteLine("You've ran out of guessing Life");
                         Console.WriteLine("GAME OVER!\n");
                     }
                     break;
                 }
                 else if (user_input == "MEDIUM"){
                     counts = count[1];
                     rand = generator.RandomNumber(1,20);
                     while (counts != 0){
                         Console.Write("\nEnter your guess: ");
                         guess = int.Parse(Console.ReadLine());
                         counts -=1;

                         if (guess == rand){
                             Console.WriteLine("YOU GOT IT RIGHT!");
                     break;
                         }
                         else{
                             Console.WriteLine("\nThat was wrong!");
                             if (counts > 1){
                                 Console.WriteLine($"You have {counts} guesses left\n");
                             }
                             else if (counts == 1){
                                 Console.WriteLine($"You have {counts} guess left\n");
                             }
                         }
                         
                     }
                     if (counts == 0){
                         Console.WriteLine("You've ran out of guessing Life");
                         Console.WriteLine("GAME OVER!\n");
                     }
                    break;

                 }
                 else if (user_input == "HARD"){
                     counts = count[2];
                     rand = generator.RandomNumber(1,50);
                     while (counts != 0){
                         Console.Write("\nEnter your guess: ");
                         guess = int.Parse(Console.ReadLine());
                         counts -=1;

                         if (guess == rand){
                             Console.WriteLine("YOU GOT IT RIGHT!");
                     break;
                         }
                         else{
                             Console.WriteLine("\nThat was wrong!");
                             if (counts > 1){
                                 Console.WriteLine($"You have {counts} guesses left \n");
                             }
                             else if (counts == 1){
                                 Console.WriteLine($"You have {counts} guess left\n");
                             }
                         }
                     }
                     if (counts == 0){
                         Console.WriteLine("You've ran out of guessing Life");
                         Console.WriteLine("GAME OVER!\n");
                     }
                     break;
                }
             Console.WriteLine("Wrong input! please choose from the available LEVELS");
            }
        }
    }
    public class RandomGenerator {
        public int RandomNumber(int min, int max){
            Random random = new Random();
            return random.Next(min, max);
        }
            
    }
}