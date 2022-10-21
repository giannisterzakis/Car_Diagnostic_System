using System;

namespace Car_Diagnostic_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int menuChoice;

            Console.WriteLine(" -----------------------");
            Console.WriteLine("| Car Diagnostic System |");
            Console.WriteLine(" -----------------------");
            Console.WriteLine();
            Console.WriteLine();

            ShowSimplePercentage();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1. Diagnosis");
            Console.WriteLine("2. Exit");
            Console.WriteLine();
            Console.Write("Select: ");
            menuChoice = Convert.ToInt32(Console.ReadLine());

            static void ShowSimplePercentage()
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.Write($"\rProgress: {i}%   ");
                    Thread.Sleep(25);
                }
                Console.Write("\rUpdated!          ");
            }


            if (menuChoice == 1)
            {
                Console.WriteLine();
                Console.Write("!! Please answer the following questions using y/n !!");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Starter cranks? ");
                answer = Console.ReadLine();

                if (answer == "y")
                {
                    Console.Write("Engine fires? ");
                    answer = Console.ReadLine();

                    if (answer == "y")
                    {
                        Console.Write("Starts and stalls? ");
                        answer = Console.ReadLine();

                        if (answer == "y")
                        {
                            Console.Write("Check OBD, blink code? ");
                            answer = Console.ReadLine();

                            if (answer == "y")
                            {
                                Console.Write("Stalls on key release to run? ");
                                answer = Console.ReadLine();

                                if (answer == "y")
                                {
                                    Console.WriteLine("Ignition 'run' circuit or colum key switch failure. Ring out with meter.");
                                    Console.Write("Press any key to exit the application: ");
                                    Console.ReadKey();
                                }
                                else if (answer == "n")
                                {
                                    Console.Write("Stalls in rain? ");
                                    answer = Console.ReadLine();

                                    if (answer == "y")
                                    {
                                        Console.WriteLine("Check for cracked coil, distributor. Check visible electrical arcing running in dark.");
                                        Console.Write("Press any key to exit the application: ");
                                        Console.ReadKey();
                                    }
                                    else if (answer == "n")
                                    {
                                        Console.Write("Stalls warm? ");
                                        answer = Console.ReadLine();

                                        if (answer == "y")
                                        {
                                            Console.WriteLine("Adjust idle, blow out fuel filter, check fuel pump output. Check vacuum leak or sensor failure.");
                                            Console.Write("Press any key to exit the application: ");
                                            Console.ReadKey();
                                        }
                                        else if (answer == "n")
                                        {
                                            Console.WriteLine("On cold stalling, check for stuck choke, EGR. Check for vacuum leak.");
                                            Console.Write("Press any key to exit the application: ");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("No valid answer.");
                                            Console.Write("Press any key to exit the application: ");
                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("No valid answer.");
                                        Console.Write("Press any key to exit the application: ");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No valid answer.");
                                    Console.Write("Press any key to exit the application: ");
                                    Console.ReadKey();
                                }
                            }
                            else if (answer == "n")
                            {
                                Console.Write("Read OBD or OBD II or check for blink code access.");
                                answer = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("No valid answer.");
                                Console.Write("Press any key to exit the application: ");
                                Console.ReadKey();
                            }
                        }
                        else if (answer == "n")
                        {
                            Console.WriteLine("Ignition timing, fuel problem, cranking too slow, battery, starter.");
                            Console.Write("Press any key to exit the application: ");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("No valid answer.");
                            Console.Write("Press any key to exit the application: ");
                            Console.ReadKey();
                        }
                    }
                    else if (answer == "n")
                    {
                        Console.Write("Spark to plugs? ");
                        answer = Console.ReadLine();

                        if (answer == "y")
                        {
                            Console.Write("Fuel to filter? ");
                            answer = Console.ReadLine();

                            if (answer == "y")
                            {
                                Console.Write("Fuel injected? ");
                                answer = Console.ReadLine();

                                if (answer == "y")
                                {
                                    Console.WriteLine("Single point, check throttle body, Electronic multipoint, separate disgnostic.");
                                    Console.Write("Press any key to exit the application: ");
                                    Console.ReadKey();
                                }
                                else if (answer == "n")
                                {
                                    Console.WriteLine("Try starter spray in crab, throttle open.");
                                    Console.Write("Press any key to exit the application: ");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("No valid answer.");
                                    Console.Write("Press any key to exit the application: ");
                                    Console.ReadKey();
                                }
                            }
                            else if (answer == "n")
                            {
                                Console.WriteLine("Vapor lock, fuel pump, blockage.");
                                Console.Write("Press any key to exit the application: ");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("No valid answer.");
                                Console.Write("Press any key to exit the application: ");
                                Console.ReadKey();
                            }
                        }
                        else if (answer == "n")
                        {
                            Console.Write("Spark from coil? ");
                            answer = Console.ReadLine();

                            if (answer == "y")
                            {
                                Console.WriteLine("Mechanical distributor? ");
                                answer = Console.ReadLine();

                                if ( answer == "y")
                                {
                                    Console.WriteLine("Check condenser, points or magnetic pick-up, rotor, or cap damage.");
                                    Console.Write("Press any key to exit the application: ");
                                    Console.ReadKey();
                                }
                                else if (answer == "n")
                                {
                                    Console.WriteLine("For electronic distribution, see model manual for diagnostic checks.");
                                    Console.Write("Press any key to exit the application: ");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("No valid answer.");
                                    Console.Write("Press any key to exit the application: ");
                                    Console.ReadKey();
                                }
                            }
                            else if (answer == "n")
                            {
                                Console.Write("12V+ at coil primary? ");
                                answer = Console.ReadLine();

                                if (answer == "y")
                                {
                                    Console.WriteLine("Test coil for internal short. Check secondary output wire resistance.");
                                    Console.Write("Press any key to exit the application: ");
                                    Console.ReadKey();
                                }
                                else if (answer == "n")
                                {
                                    Console.WriteLine("Ignition system wiring , voltage regulator.");
                                    Console.Write("Press any key to exit the application: ");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("No valid answer.");
                                    Console.Write("Press any key to exit the application: ");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.WriteLine("No valid answer.");
                                Console.Write("Press any key to exit the application: ");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No valid answer.");
                            Console.Write("Press any key to exit the application: ");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No valid answer.");
                        Console.Write("Press any key to exit the application: ");
                        Console.ReadKey();
                    }
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Starter spins? ");
                    answer = Console.ReadLine();

                    if (answer == "y")
                    {
                        Console.WriteLine("Solenoid stuck, not powered. Missing teeth on flywheel.");
                        Console.Write("Press any key to exit the application: ");
                        Console.ReadKey();
                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("Battery read over 12V? ");
                        answer = Console.ReadLine();

                        if (answer == "y")
                        {
                            Console.WriteLine("Cleaned terminals? ");
                            answer = Console.ReadLine();

                            if (answer == "y")
                            {
                                Console.WriteLine("With car in park or neutral, use heavy jumper or screwdriver to bypass starter relay solenoid. Test starter.");
                                Console.Write("Press any key to exit the application: ");
                                Console.ReadKey();
                            }
                            else if (answer == "n")
                            {
                                Console.WriteLine("Clean battery terminals and connectors, engine ground.");
                                Console.Write("Press any key to exit the application: ");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("No valid answer.");
                                Console.Write("Press any key to exit the application: ");
                                Console.ReadKey();
                            }
                        }
                        else if (answer == "n")
                        {
                            Console.WriteLine("Jump start or pop start car and check if battery is charging.");
                            Console.Write("Press any key to exit the application: ");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("No valid answer.");
                            Console.Write("Press any key to exit the application: ");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No valid answer.");
                        Console.Write("Press any key to exit the application: ");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("No valid answer.");
                    Console.Write("Press any key to exit the application: ");
                    Console.ReadKey();
                }
            }

            else if (menuChoice == 2)
            {
                Console.Write("Press any key to exit the application: ");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No valid answer.");
                Console.Write("Press any key to exit the application: ");
                Console.ReadKey();
            }
        }
    }
}
            

    
        
        