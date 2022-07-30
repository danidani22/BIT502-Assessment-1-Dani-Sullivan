namespace assessment_1_try_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First declaring variables
            int userMainMenuChoice;
            int userBMIMenuChoice;
            int userMembershipMenuChoice;
            string userMainMenuInput;
            string userBMIMenuInput;
            string userMembershipMenuInput;
            string mainMenuMessage = "------------------------\n CITY GYM  /  Main Menu\n------------------------\n\n[1] Calculate BMI\n[2] View Membership Rates\n\n[0] Quit program\n\nSelect option: ";
            string BMIMenuMessage = "----------------------------\n CITY GYM  /  Calculate BMI\n----------------------------\n";
            string quitMessage = "\nGoodbye. Please press any key to exit...";
            string BMIHeightMessage = "\nPlease enter your height (in cm): ";
            string BMIWeightMessage = "\nPlease enter your weight (in kg): ";
            float BMIHeightCM;
            float BMIHeightM;
            string userHeightInput;
            float BMIWeight;
            string userWeightInput;
            float userBMI;
            string userBMIMessage = "\n\nYour BMI is ";
            string userUnderweight = ". You are Underweight";
            string userNormal = ". You are Normal";
            string userOverweight = ". You are Overweight";
            string userObese = ". You are Obese";
            string BMIResultMessage = "\n\n[9] Return to Main Menu\n[0] Quit program\n\nSelect option: ";
            string dashForBMIMenu = "\n----------------------------";
            string membershipRatesTitle = "------------------------------------\n CITY GYM  /  View Membership Rates\n------------------------------------";
            string membershipRatesMessage = "\n\n[1] Basic\n[2] Regular\n[3] Premium";
            string basicMembership = "\n\nBasic Membership Rates\n\nBasic weekly membership rate is $10\nBasic monthly membership rate is $40";
            string regularMembership = "\n\nRegular Membership Rates\n\nRegular weekly membership rate is $15\nRegular monthly membership rate is $60";
            string premiumMembership = "\n\nPremium Membership Rates\n\nPremium weekly membership rate is $20\nPremium monthly membership rate is $80";
            string returnMembershipMenu = "\nPress any key to return to membership menu...";
            string invalidResponse = "\nYou have selected an invalid response. Please type any key to try again...";

            while (true)
            {
                Console.Clear();
                Console.Write(mainMenuMessage);
                userMainMenuInput = Console.ReadLine();

                Console.Clear();

                if (int.TryParse(userMainMenuInput, out userMainMenuChoice))
                {
                    switch (userMainMenuChoice)
                    {
                        case 0:
                            {
                                Console.WriteLine(quitMessage);
                                Console.ReadKey();

                                Environment.Exit(0);
                                break;
                            }

                        case 1:
                            {
                                BMIHeightCM = 0;
                                while (true)
                                {
                                    Console.Clear();
                                    Console.Write(BMIMenuMessage + BMIHeightMessage);
                                    userHeightInput = Console.ReadLine();
                                    if (float.TryParse(userHeightInput, out BMIHeightCM))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(invalidResponse);
                                        Console.ReadKey();
                                    }
                                }

                                BMIWeight = 0;
                                while (true)
                                {
                                    Console.Write(BMIWeightMessage);
                                    userWeightInput = Console.ReadLine();
                                    if (float.TryParse(userWeightInput, out BMIWeight))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(invalidResponse);
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.Write(BMIMenuMessage);
                                        Console.WriteLine(BMIHeightMessage + BMIHeightCM);
                                    }
                                }

                                BMIHeightM = BMIHeightCM * 0.01f;
                                userBMI = MathF.Round((BMIWeight / (BMIHeightM * BMIHeightM)), 2);

                                userBMIMenuChoice = 0;
                                while (true)
                                {
                                    if (userBMI < 18.5) Console.WriteLine(userBMIMessage + userBMI + userUnderweight);
                                    else if (userBMI >= 18.5 && userBMI < 25) Console.WriteLine(userBMIMessage + userBMI + userNormal);
                                    else if (userBMI >= 25 && userBMI < 30) Console.WriteLine(userBMIMessage + userBMI + userOverweight);
                                    else if (userBMI >= 30) Console.WriteLine(userBMIMessage + userBMI + userObese);

                                    Console.Write(dashForBMIMenu + BMIResultMessage);
                                    userBMIMenuInput = Console.ReadLine();
                                    if (int.TryParse(userBMIMenuInput, out userBMIMenuChoice))
                                    {
                                        if (userBMIMenuChoice == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine(quitMessage);
                                            Console.ReadKey();

                                            Environment.Exit(0);
                                        }
                                        else if (userBMIMenuChoice == 9) break;

                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine(invalidResponse);
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.WriteLine(BMIMenuMessage + "\n" + BMIHeightMessage + BMIHeightCM + "\n" + BMIWeightMessage + BMIWeight + "\n");
                                        }

                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(invalidResponse);
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine(BMIMenuMessage + "\n" + BMIHeightMessage + BMIHeightCM + "\n" + BMIWeightMessage + BMIWeight + "\n");
                                    }
                                }

                                break;
                            }

                        case 2:
                            {
                                userMembershipMenuChoice = 0;

                                while (true)
                                {
                                    Console.Clear();
                                    Console.Write(membershipRatesTitle + membershipRatesMessage + BMIResultMessage);
                                    userMembershipMenuInput = Console.ReadLine();
                                    if (int.TryParse(userMembershipMenuInput, out userMembershipMenuChoice))
                                    {
                                        if (userMembershipMenuChoice == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine(quitMessage);
                                            Console.ReadKey();

                                            Environment.Exit(0);
                                        }

                                        else if (userMembershipMenuChoice == 9) break;

                                        else if (userMembershipMenuChoice == 1)
                                        {
                                            Console.Clear();
                                            Console.WriteLine(membershipRatesTitle + basicMembership);
                                            Console.Write(returnMembershipMenu);
                                            Console.ReadLine();
                                        }
                                        else if (userMembershipMenuChoice == 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine(membershipRatesTitle + regularMembership);
                                            Console.Write(returnMembershipMenu);
                                            Console.ReadLine();
                                        }
                                        else if (userMembershipMenuChoice == 3)
                                        {
                                            Console.Clear();
                                            Console.WriteLine(membershipRatesTitle + premiumMembership);
                                            Console.Write(returnMembershipMenu);
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.Write(invalidResponse);
                                            Console.ReadKey();
                                            Console.Clear();
                                            Console.Write(membershipRatesTitle + membershipRatesMessage);
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(invalidResponse);
                                        Console.ReadKey();
                                    }
                                }

                                break;
                            }
                        default:
                            {
                                Console.WriteLine(invalidResponse);
                                Console.ReadKey();

                                break;
                            }


                    }


                }
                else
                {
                    Console.WriteLine(invalidResponse);
                    Console.ReadKey();
                }
            }
        }


    }
}
