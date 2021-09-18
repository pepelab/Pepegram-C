//Pepegram C (Console edition) by PepeLab 2021

using System;
using System.Threading;

namespace Pepegram_C
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пароль
            //string name = Console.ReadLine();
            //string maskedName = name.Replace(name.Substring(1, name.Length - 1), new string('*', name.Length - 1));
            //Console.WriteLine(maskedName);



            //Регистрация 
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("\t\t\t██████╗░███████╗██████╗░███████╗░██████╗░██████╗░░█████╗░███╗░░░███╗");
            Console.WriteLine("\t\t\t██╔══██╗██╔════╝██╔══██╗██╔════╝██╔════╝░██╔══██╗██╔══██╗████╗░████║");
            Console.WriteLine("\t\t\t██████╔╝█████╗░░██████╔╝█████╗░░██║░░██╗░██████╔╝███████║██╔████╔██║");
            Console.WriteLine("\t\t\t██╔═══╝░██╔══╝░░██╔═══╝░██╔══╝░░██║░░╚██╗██╔══██╗██╔══██║██║╚██╔╝██║");
            Console.WriteLine("\t\t\t██║░░░░░███████╗██║░░░░░███████╗╚██████╔╝██║░░██║██║░░██║██║░╚═╝░██║");
            Console.WriteLine("\t\t\t╚═╝░░░░░╚══════╝╚═╝░░░░░╚══════╝░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝");

            Console.Beep(264, 125);

            Console.Write("\n\n\n\n\t\t\t\t\t\tLogin: ");
            string login = Console.ReadLine();
            Console.Beep(264, 125);
            Console.Write("\n\t\t\t\t\t\tPassword: ");
            string password = Console.ReadLine();
            Console.Beep(264, 125);
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\t\t\t");
            

            //Список команд
            Console.WriteLine("\n\n\n\n\t\t\t\t\t\tCommands:\n");
            Console.WriteLine("\t\t\t\t\t\"/chat user\" - Start chatting");
            Console.WriteLine("\t\t\t\t\t\"/end\" - End the chatter");
            Console.WriteLine("\t\t\t\t\t\"/music\" - Playing music");
            Console.WriteLine("\t\t\t\t\t\"/help\" - Commands"); 
            Console.WriteLine("\t\t\t\t\t\"/logout\" - Sign out");
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\t\t\t");

            
            //переменные
            string сhatMember;
            string[] words = { "привет", "чё как", "че", "как дела", "норм", "ок", "без б", "пока", "как тебя зовут", "что ты здесь делаешь?",
                        "да", "нет", "блять", "иди нахуй", "лох", "ты кто", "чем ты занимаешся?", "продаешь?", "соси", "интересно", "ку", "го в кс", "просто сижу",
                        "пепеграм топовый", "согл", ":D", ":/", "<3", "8===D", "похуй", "класс", "не знал", ":)"};
            //Console.Write(words[temp]); - генератор случайных слов

            Boolean repeatСommand = true;
            Boolean chatStart = true;
            Boolean musicStart = true;

            //Вся программа 
            do
            {   
                //Ввод команд
                Console.Write($"\n\t\t\t{login}@pepegram:");
                string command = Console.ReadLine();
                Console.Beep(264, 125);


                switch (command)
                {

                    case "/chat":
                        Console.Write($"\n\t\t\t{login}@pepegram/chat ");
                        string chatMember = Console.ReadLine();
                        Console.Beep(264, 125);
                        Console.Write($"\t\t\t{chatMember} connected\n");

                            do
                            {
                                chatStart = true;
                                repeatСommand = false;
                                Random rand = new Random();
                                int temp;
                                temp = rand.Next(34);
                                Console.Write($"\n\t\t\t{chatMember}: {words[temp]}\n");
                                Console.Write($"\n\t\t\t{login}: ");
                                string chatCommand = Console.ReadLine();
                                Console.Beep(264, 125);
                                
                                switch (chatCommand)
                                {
                                    case "/end":
                                        chatStart = false;
                                        repeatСommand = true;
                                        Console.WriteLine("\n\t\t\tChat is over...");
                                        Console.WriteLine($"\t\t\t{chatMember} disconnected");
                                        break;
                                }
                            } 
                            while (chatStart == true);  
                        break;

                        //Музыка
                    case "/music":
                        Console.WriteLine("\n\n\n\n\t\t\t\t\t\tMusic:\n");
                        Console.WriteLine("\t\t\t\t\t\"/1\" - The Forest Raised a Christmas Tree");
                        Console.WriteLine("\t\t\t\t\t\"/2\" - Imperial March");
                        Console.WriteLine("\t\t\t\t\t\"/3\" - Super Mario");
                        Console.WriteLine("\t\t\t\t\t\"/4\" - Tetris");
                        Console.WriteLine("\t\t\t\t\t\"/5\" - Happy birthday");
                        Console.WriteLine("\t\t\t\t\t\"/6\" - The Legend of Zelda");
                        Console.Write("\n\n\n\t\t\t");

                        Console.Write($"\n\t\t\t{login}@pepegram/music");
                        string musicNubmer = Console.ReadLine();
                        Console.Beep(264, 125);

                       
                        
                        musicStart = true;
                        repeatСommand = false;

                        switch (musicNubmer)
                        {
                            case "/1":
                                musicStart = false;
                                repeatСommand = true;
                                Console.Write($"\n\t\t\t\"The Forest Raised a Christmas Tree\" plays...\n");
                                Console.Beep(247, 500);
                                Console.Beep(417, 500);
                                Console.Beep(417, 500);
                                Console.Beep(370, 500);
                                Console.Beep(417, 500);
                                Console.Beep(329, 500);
                                Console.Beep(247, 500);
                                Console.Beep(247, 500);
                                Console.Beep(247, 500);
                                Console.Beep(417, 500);
                                Console.Beep(417, 500);
                                Console.Beep(370, 500);
                                Console.Beep(497, 500);
                                Console.Beep(417, 650);
                                Thread.Sleep(700);
                                Console.Beep(497, 500);
                                Console.Beep(277, 500);
                                Console.Beep(277, 500);
                                Console.Beep(440, 500);
                                Console.Beep(440, 500);
                                Console.Beep(417, 500);
                                Console.Beep(370, 500);
                                Console.Beep(329, 500);
                                Console.Beep(247, 500);
                                Console.Beep(417, 500);
                                Console.Beep(417, 500);
                                Console.Beep(370, 500);
                                Console.Beep(417, 500);
                                Console.Beep(329, 650);
                                Console.WriteLine("\t\t\tMusic is over...");
                                musicStart = false;
                                repeatСommand = true;
                                break;


                            case "/2":
                                musicStart = false;
                                repeatСommand = true;
                                Console.Write($"\n\t\t\t\"Imperial March\" plays...\n");
                                Console.Beep(440, 500);
                                Console.Beep(440, 500);
                                Console.Beep(440, 500);
                                Console.Beep(349, 350);
                                Console.Beep(523, 150);
                                Console.Beep(440, 500);
                                Console.Beep(349, 350);
                                Console.Beep(523, 150);
                                Console.Beep(440, 1000);
                                Console.Beep(659, 500);
                                Console.Beep(659, 500);
                                Console.Beep(659, 500);
                                Console.Beep(698, 350);
                                Console.Beep(523, 150);
                                Console.Beep(415, 500);
                                Console.Beep(349, 350);
                                Console.Beep(523, 150);
                                Console.Beep(440, 1000);
                                Console.Beep(880, 500);
                                Console.Beep(440, 350);
                                Console.Beep(440, 150);
                                Console.Beep(880, 500);
                                Console.Beep(830, 250);
                                Console.Beep(784, 250);
                                Console.Beep(740, 125);
                                Console.Beep(698, 125);
                                Console.Beep(740, 250);
                                Thread.Sleep(300); 
                                Console.Beep(455, 250);
                                Console.Beep(622, 500);
                                Console.Beep(587, 250);
                                Console.Beep(554, 250);
                                Console.Beep(523, 125);
                                Console.Beep(466, 125);
                                Console.Beep(523, 250);
                                Thread.Sleep(300); 
                                Console.Beep(349, 125);
                                Console.Beep(415, 500);
                                Console.Beep(349, 375);
                                Console.Beep(440, 125);
                                Console.Beep(523, 500);
                                Console.Beep(440, 375);
                                Console.Beep(523, 125);
                                Console.Beep(659, 1000);
                                Console.Beep(880, 500);
                                Console.Beep(440, 350);
                                Console.Beep(440, 150);
                                Console.Beep(880, 500);
                                Console.Beep(830, 250);
                                Console.Beep(784, 250);
                                Console.Beep(740, 125);
                                Console.Beep(698, 125);
                                Console.Beep(740, 250);
                                Thread.Sleep(300);
                                Console.Beep(455, 250);
                                Console.Beep(622, 500);
                                Console.Beep(587, 250);
                                Console.Beep(554, 250);
                                Console.Beep(523, 125);
                                Console.Beep(466, 125);
                                Console.Beep(523, 250);
                                Thread.Sleep(300);
                                Console.Beep(349, 250);
                                Console.Beep(415, 500);
                                Console.Beep(349, 375);
                                Console.Beep(523, 125);
                                Console.Beep(440, 500);
                                Console.Beep(349, 375);
                                Console.Beep(261, 125);
                                Console.Beep(440, 1000);
                                Console.WriteLine("\t\t\tMusic is over...");
                                musicStart = false;
                                repeatСommand = true;
                                break;

                            case "/3":
                                musicStart = false;
                                repeatСommand = true;
                                Console.Write($"\n\t\t\t\"Super Mario\" plays...\n");
                                Console.Beep(659, 125);
                                Console.Beep(659, 125); 
                                Thread.Sleep(125);
                                Console.Beep(659, 125); 
                                Thread.Sleep(167); 
                                Console.Beep(523, 125); 
                                Console.Beep(659, 125); 
                                Thread.Sleep(125); 
                                Console.Beep(784, 125); 
                                Thread.Sleep(375); 
                                Console.Beep(392, 125);
                                Thread.Sleep(375);
                                Console.Beep(523, 125);
                                Thread.Sleep(250);
                                Console.Beep(392, 125);
                                Thread.Sleep(250);
                                Console.Beep(330, 125);
                                Thread.Sleep(250); 
                                Console.Beep(440, 125);
                                Thread.Sleep(125);
                                Console.Beep(494, 125);
                                Thread.Sleep(125);
                                Console.Beep(466, 125);
                                Thread.Sleep(42);
                                Console.Beep(440, 125);
                                Thread.Sleep(125);
                                Console.Beep(392, 125);
                                Thread.Sleep(125);
                                Console.Beep(659, 125);
                                Thread.Sleep(125);
                                Console.Beep(784, 125);
                                Thread.Sleep(125);
                                Console.Beep(880, 125);
                                Thread.Sleep(125);
                                Console.Beep(698, 125);
                                Console.Beep(784, 125);
                                Thread.Sleep(125);
                                Console.Beep(659, 125);
                                Thread.Sleep(125);
                                Console.Beep(523, 125);
                                Thread.Sleep(125);
                                Console.Beep(587, 125);
                                Console.Beep(494, 125);
                                Thread.Sleep(125);
                                Console.Beep(523, 125);
                                Thread.Sleep(250);
                                Console.Beep(392, 125);
                                Thread.Sleep(250);
                                Console.Beep(330, 125);
                                Thread.Sleep(250);
                                Console.Beep(440, 125);
                                Thread.Sleep(125);
                                Console.Beep(494, 125);
                                Thread.Sleep(125);
                                Console.Beep(466, 125);
                                Thread.Sleep(42);
                                Console.Beep(440, 125);
                                Thread.Sleep(125);
                                Console.Beep(392, 125);
                                Thread.Sleep(125);
                                Console.Beep(659, 125);
                                Thread.Sleep(125);
                                Console.Beep(784, 125);
                                Thread.Sleep(125);
                                Console.Beep(880, 125);
                                Thread.Sleep(125);
                                Console.Beep(698, 125);
                                Console.Beep(784, 125);
                                Thread.Sleep(125);
                                Console.Beep(659, 125);
                                Thread.Sleep(125);
                                Console.Beep(523, 125);
                                Thread.Sleep(125);
                                Console.Beep(587, 125);
                                Console.Beep(494, 125);
                                Thread.Sleep(375);
                                Console.Beep(784, 125);
                                Console.Beep(740, 125);
                                Console.Beep(698, 125);
                                Thread.Sleep(42);
                                Console.Beep(622, 125);
                                Thread.Sleep(125);
                                Console.Beep(659, 125);
                                Thread.Sleep(167);
                                Console.Beep(415, 125);
                                Console.Beep(440, 125);
                                Console.Beep(523, 125);
                                Thread.Sleep(125);
                                Console.Beep(440, 125);
                                Console.Beep(523, 125);
                                Console.Beep(587, 125);
                                Thread.Sleep(250);
                                Console.Beep(784, 125);
                                Console.Beep(740, 125);
                                Console.Beep(698, 125);
                                Thread.Sleep(42);
                                Console.Beep(622, 125);
                                Thread.Sleep(125);
                                Console.Beep(659, 125);
                                Thread.Sleep(167);
                                Console.Beep(698, 125);
                                Thread.Sleep(125);
                                Console.Beep(698, 125);
                                Console.Beep(698, 125);
                                Thread.Sleep(625);
                                Console.Beep(784, 125);
                                Console.Beep(740, 125);
                                Console.Beep(698, 125);
                                Thread.Sleep(42);
                                Console.Beep(622, 125);
                                Thread.Sleep(125);
                                Console.Beep(659, 125);
                                Thread.Sleep(167);
                                Console.Beep(415, 125);
                                Console.Beep(440, 125);
                                Console.Beep(523, 125);
                                Thread.Sleep(125);
                                Console.Beep(440, 125);
                                Console.Beep(523, 125);
                                Console.Beep(587, 125);
                                Thread.Sleep(250);
                                Console.Beep(622, 125);
                                Thread.Sleep(250);
                                Console.Beep(587, 125);
                                Thread.Sleep(250);
                                Console.Beep(523, 125);
                                Thread.Sleep(1125);
                                Console.Beep(784, 125);
                                Console.Beep(740, 125);
                                Console.Beep(698, 125);
                                Thread.Sleep(42);
                                Console.Beep(622, 125);
                                Thread.Sleep(125);
                                Console.Beep(659, 125);
                                Thread.Sleep(167);
                                Console.Beep(415, 125);
                                Console.Beep(440, 125);
                                Console.Beep(523, 125);
                                Thread.Sleep(125);
                                Console.Beep(440, 125);
                                Console.Beep(523, 125);
                                Console.Beep(587, 125);
                                Thread.Sleep(250);
                                Console.Beep(784, 125);
                                Console.Beep(740, 125);
                                Console.Beep(698, 125);
                                Thread.Sleep(42);
                                Console.Beep(622, 125);
                                Thread.Sleep(125);
                                Console.Beep(659, 125);
                                Thread.Sleep(167); 
                                Console.Beep(698, 125); 
                                Thread.Sleep(125); 
                                Console.Beep(698, 125);
                                Console.Beep(698, 125);
                                Thread.Sleep(625); 
                                Console.Beep(784, 125);
                                Console.Beep(740, 125);
                                Console.Beep(698, 125); 
                                Thread.Sleep(42); 
                                Console.Beep(622, 125);
                                Thread.Sleep(125);
                                Console.Beep(659, 125);
                                Thread.Sleep(167); 
                                Console.Beep(415, 125);
                                Console.Beep(440, 125);
                                Console.Beep(523, 125);
                                Thread.Sleep(125); 
                                Console.Beep(440, 125);
                                Console.Beep(523, 125);
                                Console.Beep(587, 125); 
                                Thread.Sleep(250); 
                                Console.Beep(622, 125);
                                Thread.Sleep(250); 
                                Console.Beep(587, 125);
                                Thread.Sleep(250);
                                Console.Beep(523, 125);
                                Console.WriteLine("\t\t\tMusic is over...");
                                musicStart = false;
                                repeatСommand = true;
                                break;

                            case "/4":
                                musicStart = false;
                                repeatСommand = true;
                                Console.Write($"\n\t\t\t\"Tetris\" plays...\n");
                                Console.Beep(1320, 500);
                                Console.Beep(990, 250);
                                Console.Beep(1056, 250);
                                Console.Beep(1188, 250);
                                Console.Beep(1320, 125);
                                Console.Beep(1188, 125);
                                Console.Beep(1056, 250);
                                Console.Beep(990, 250);
                                Console.Beep(880, 500);
                                Console.Beep(880, 250);
                                Console.Beep(1056, 250);
                                Console.Beep(1320, 500);
                                Console.Beep(1188, 250);
                                Console.Beep(1056, 250);
                                Console.Beep(990, 750);
                                Console.Beep(1056, 250);
                                Console.Beep(1188, 500);
                                Console.Beep(1320, 500);
                                Console.Beep(1056, 500);
                                Console.Beep(880, 500);
                                Console.Beep(880, 500);
                                Thread.Sleep(300);
                                Console.Beep(1188, 500);
                                Console.Beep(1408, 250);
                                Console.Beep(1760, 500);
                                Console.Beep(1584, 250);
                                Console.Beep(1408, 250);
                                Console.Beep(1320, 750);
                                Console.Beep(1056, 250);
                                Console.Beep(1320, 500);
                                Console.Beep(1188, 250);
                                Console.Beep(1056, 250);
                                Console.Beep(990, 500);
                                Console.Beep(990, 250);
                                Console.Beep(1056, 250);
                                Console.Beep(1188, 500);
                                Console.Beep(1320, 500);
                                Console.Beep(1056, 500);
                                Console.Beep(880, 500);
                                Console.Beep(880, 500);
                                Console.WriteLine("\t\t\tMusic is over...");
                                musicStart = false;
                                repeatСommand = true;
                                break;

                            case "/5":
                                musicStart = false;
                                repeatСommand = true;
                                Console.Write($"\n\t\t\t\"Happy birthday\" plays...\n");
                                int C = 264;
                                int D = 297;
                                int E = 330;
                                int F = 352;
                                int G = 396;
                                int A = 440;
                                int Bb = 466;
                                int B = 495;
                                int C2 = 528;

                                int note = 1000;
                                int half = 1000 / 2;
                                int quarter = 1000 / 4;
                                int eighth = 1000 / 8;

                                Console.Beep(C, eighth);
                                Thread.Sleep(quarter);
                                Console.Beep(C, eighth);
                                Thread.Sleep(eighth);
                                Console.Beep(D, half);
                                Thread.Sleep(eighth);
                                Console.Beep(C, half);
                                Thread.Sleep(eighth);
                                Console.Beep(F, half);
                                Thread.Sleep(eighth);
                                Console.Beep(E, note);
                                Thread.Sleep(quarter);

                                Console.Beep(C, eighth);
                                Thread.Sleep(quarter);
                                Console.Beep(C, eighth);
                                Thread.Sleep(eighth);
                                Console.Beep(D, half);
                                Thread.Sleep(eighth);
                                Console.Beep(C, half);
                                Thread.Sleep(eighth);
                                Console.Beep(G, half);
                                Thread.Sleep(eighth);
                                Console.Beep(F, note);

                                Thread.Sleep(quarter);
                                Console.Beep(C, eighth);
                                Thread.Sleep(quarter);
                                Console.Beep(C, eighth);
                                Thread.Sleep(eighth);
                                Console.Beep(C2, half);
                                Thread.Sleep(eighth);
                                Console.Beep(A, half);
                                Thread.Sleep(eighth);
                                Console.Beep(F, quarter);
                                Thread.Sleep(eighth);
                                Console.Beep(F, eighth);
                                Thread.Sleep(eighth);
                                Console.Beep(E, half);
                                Thread.Sleep(eighth);
                                Console.Beep(D, note);

                                Thread.Sleep(quarter);
                                Console.Beep(Bb, eighth);
                                Thread.Sleep(quarter);
                                Console.Beep(Bb, eighth);
                                Thread.Sleep(eighth);
                                Console.Beep(A, half);
                                Thread.Sleep(eighth);
                                Console.Beep(F, half);
                                Thread.Sleep(eighth);
                                Console.Beep(G, half);
                                Thread.Sleep(eighth);
                                Console.Beep(F, note);
                                Console.WriteLine("\t\t\tMusic is over...");
                                musicStart = false;
                                repeatСommand = true;
                                break;

                            case "/6":
                                musicStart = false;
                                repeatСommand = true;
                                Console.Write($"\n\t\t\t\"The Legend of Zelda\" plays...\n");
                                Console.Beep(880, 500);
                                Console.Beep(587, 1000);
                                Console.Beep(698, 500);
                                Console.Beep(880, 500);
                                Console.Beep(587, 1000);
                                Console.Beep(698, 500);
                                Console.Beep(880, 250);
                                Console.Beep(1046, 250);
                                Console.Beep(1046, 250);
                                Console.Beep(987, 500);
                                Console.Beep(783, 500);
                                Console.Beep(698, 250);
                                Console.Beep(783, 250);
                                Console.Beep(880, 500);
                                Console.Beep(587, 500);
                                Console.Beep(523, 250);
                                Console.Beep(659, 750);
                                Console.WriteLine("\t\t\tMusic is over...");
                                musicStart = false;
                                repeatСommand = true;
                                break;

                            case "/end":
                                musicStart = false;
                                repeatСommand = true;
                                Console.WriteLine("\t\t\tMusic is over...");
                                break;

                            default: //неизвестная команда
                                Console.WriteLine("\t\t\tUnknown command");
                                musicStart = false;
                                repeatСommand = true;
                                break;
                        }
                    
                        break;


                    case "/help": //помощь команды
                        Console.WriteLine("\n\n\n\n\t\t\t\t\t\tCommands:\n");
                        Console.WriteLine("\t\t\t\t\t\"/chat user\" - Start chatting");
                        Console.WriteLine("\t\t\t\t\t\"/end\" - End the chatter, music");
                        Console.WriteLine("\t\t\t\t\t\"/music\" - Playing music");
                        Console.WriteLine("\t\t\t\t\t\"/help\" - Commands");
                        Console.WriteLine("\t\t\t\t\t\"/logout\" - Sign out");
                        Console.Write("\n\n\n\t\t\t");
                        break;


                    case "/logout": //выход
                        Console.WriteLine("\t\t\tSign out");
                        repeatСommand = false;
                        Environment.Exit(0);
                        break;


                    default: //неизвестная команда
                        Console.WriteLine("\t\t\tUnknown command");
                        break;
                }
            } while (repeatСommand == true);


            Console.ReadLine();
        }
        
    }
    
}