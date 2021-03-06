﻿using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace RegualtExpression
{
    namespace validator_c_sharp
    {
        class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Create a PIN between 4 to 8 digits.  Numbers only.");
                var pin = Console.ReadLine();
                var validPin = false;

                while (!validPin)
                {
                    if (pin.Length < 4 || pin.Length > 8)
                    {
                        Console.WriteLine("Invalid PIN length.  Please enter between 4 to 8 digits.");
                        pin = Console.ReadLine();
                    }
                    else
                    {
                        foreach (char number in pin)
                        {
                            if (char.IsDigit(number))
                            {
                                validPin = true;
                            }

                            else
                            {
                                validPin = false;
                            }
                        }

                        if (validPin == true)
                        {
                            Console.WriteLine("Valid PIN.  Your PIN has been created.");
                        }

                        else
                        {
                            Console.WriteLine("Invalid PIN.  Please try again.  Numbers only.  No letters or special characters.");
                        }

                    }

                }

                Console.WriteLine("Please enter a valid phone number.");
                var telNo = Console.ReadLine();
                var validPhoneNumber = false;

                while (!validPhoneNumber)
                {
                    //string telNo = Console.ReadLine();
                    var areaCode = telNo.Substring(0, 3);
                    Console.WriteLine(areaCode);
                    if (areaCode == "555")
                    {
                        Console.WriteLine("Invalid area code.  Please enter a valid phone number.");
                        telNo = Console.ReadLine();
                    }
                    else
                    {
                    Console.WriteLine("{0}Valid Phone Number", IsPhoneNumber(telNo) ? "" : "in");
                    validPhoneNumber = true;
                    }

                }
                Console.WriteLine("Enter a valid email address.");
                var email = Console.ReadLine();
                string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

                if (Regex.IsMatch(email, pattern))
                {
                    //if email is valid
                    Console.WriteLine(email + " is a valid Email address ");
                }
                else
                {
                    Console.WriteLine(email + " is not a valid Email address");
                }

                // SpongeBob
                Console.WriteLine("Enter a SpongeBob quote");
                var quote = Console.ReadLine();

                string wackyQuote = string.Concat(
                quote.ToLower().AsEnumerable().Select((c, i) => i % 2 == 0 ? c : char.ToUpper(c)));

                Console.WriteLine(wackyQuote);

                // Power Rangers

                Console.WriteLine("Are you a Power Ranger?  What's your name?");
                var enteredName = Console.ReadLine();

                switch (enteredName)
                {
                    case "Zack Taylor":
                        Console.WriteLine("Hello Power Ranger!");
                        break;
                    case "Jason Lee Scott":
                        Console.WriteLine("Hello Power Ranger!");
                        break;
                    case "Kimberly Hart":
                        Console.WriteLine("Hello Power Ranger!");
                        break;
                    case "Trini Kwan":
                        Console.WriteLine("Hello Power Ranger!");
                        break;
                    case "Billy Cranston":
                        Console.WriteLine("Hello Power Ranger!");
                        break;
                    default:
                        Console.WriteLine("You are not a Power Ranger, but maybe someday you will be");
                        break;
                }

                // Palindrome

                Console.WriteLine("Enter a word to determine if it's a palindrome.");
                string string1, rev;
                string1 = Console.ReadLine();
                char[] ch = string1.ToCharArray();
                Array.Reverse(ch);
                rev = new string(ch);
                bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
                if (b == true)
                {
                    Console.WriteLine("" + string1 + " is a Palindrome!");
                }
                else
                {
                    Console.WriteLine(" " + string1 + " is not a Palindrome!");
                }
                Console.Read();

            }

            public static bool IsPhoneNumber(string number)
            {
                return Regex.Match(number, @"[^0-9]+").Success;
            }

            


        }
        }
    }
