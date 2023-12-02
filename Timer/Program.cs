using System;
using System.Security.Cryptography.X509Certificates;

namespace Timer
{
    internal class Program
    {
        static int _minutes;
        static int _seconds;
        static bool _runningTimer = false;
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            while (true)
            {
                Console.Clear();

                Console.ForegroundColor =  ConsoleColor.Green;
                Console.SetCursorPosition(50, 0);
                Console.Write($"Current minutes {_minutes}");

                Console.SetCursorPosition(50, 1);
                Console.Write($"Current seconds {_seconds}");

                Console.SetCursorPosition(0, 0);
                Console.WriteLine
                ("1. Set minutes"
                + "\n2. Set seconds"
                + "\n3. Start");

                Console.SetCursorPosition (0, 10);
          
                Console.SetCursorPosition (0, 3);
                char input = Console.ReadKey(true).KeyChar;
                int inputNumber;

                if (int.TryParse(input.ToString(), out inputNumber))
                {
                    switch (inputNumber)
                    {
                        case 1:
                            SetMinutes();
                            break;
                        case 2:
                            SetSeconds();
                            break;
                        case 3:
                            StartTimer();  
                            break;

                    }
                }
                Console.WriteLine("Enter available numbers");
                Console.ReadLine();
            }            
        }

        static void SetMinutes()
        {
            Console.Clear();

            while(true)
            { 
                Console.WriteLine("Enter minutes or \"c\" to cancel");
                string? input = Console.ReadLine();
                
                if ((int.TryParse(input, out _minutes) && input.Length <= 2) || input == "c")
                {
                    Menu();
                }
                Console.Clear();
                Console.WriteLine("Еnter no more than two numbers");
            }
        }

        static void SetSeconds()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Enter seconds or \"c\" to cancel");
                string? input = Console.ReadLine();

                if ((int.TryParse(input, out _seconds) && input.Length <= 2) || input == "c")
                {
                    Menu();
                }
                Console.Clear();
                Console.WriteLine("Еnter no more than two numbers");
            }
        }

        static void StartTimer()
        {
            _runningTimer = true;

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            DateTime dateTime = DateTime.Today;
            DateTime timerTime = dateTime.AddMinutes(_minutes).AddSeconds(_seconds);
        
            Digit digit = new Digit();

            Thread inputThread = new Thread(ReadInput);
            inputThread.Start();
;
            for (int i = 0; true; i++)
            {
                Console.SetCursorPosition(0, 10);
                Console.WriteLine("Cancel = \"c\"");
                Colon colon = new Colon();
                colon.DrawColon();

                DateTime currentTimerTime = timerTime - TimeSpan.FromSeconds(i);
                string time = currentTimerTime.ToString("mm:ss");

                int one = int.Parse(time[0].ToString());
                int two = int.Parse(time[1].ToString());
                int three = int.Parse(time[3].ToString());
                int four = int.Parse(time[4].ToString());

                digit.CreateDigit(one, 0);
                digit.CreateDigit(two, 1);

                digit.CreateDigit(three, 2);
                digit.CreateDigit(four, 3);
                Thread.Sleep(1000);
                if ((currentTimerTime.Minute == 0 && currentTimerTime.Second == 0) || _runningTimer == false) { break; }

                Console.Clear();

            }
            Console.Clear();
            Menu();
        }
        
        static void ReadInput()
        {
            while (true && _runningTimer)
            {
                char userInput = Console.ReadKey(true).KeyChar;
                if (userInput == 'c')
                {
                    _runningTimer = false;
                }
            }
        }

    }
}
