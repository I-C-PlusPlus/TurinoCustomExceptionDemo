using System.Runtime.CompilerServices;

namespace CustomExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    /*int num1 = int.Parse(Input("Enter a number: "));
                    int num2 = int.Parse(Input("Enter another number: "));
                    int result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result}");*/
                    string userInput = Input("Enter a social Security Number:");
                    SocialSecurityNumber ssn = new SocialSecurityNumber();
                    ssn.SSn = userInput;
                    Console.WriteLine(($"Thank you for entering a valid SocialSecurity Number: {ssn.SSn}"));
                }

                catch (DivideByZeroException)
                {
                    Console.WriteLine($"Second number must not be zero.");
                }
                
                catch( FormatException)
                {
                    Console.WriteLine($"Please use a valid number");
                }

                catch (OverflowException)
                {
                    Console.WriteLine($"Number was too large");
                }
                catch(SSNFormatException)
                {
                    Console.WriteLine($"Please format that as a social security number.");
                }

                catch (Exception exc)
                {
                    Console.WriteLine($"An error opcurred: {exc.Message}\nException type: {exc.GetType()}");
                }


            } while (DoAnother());



            Console.Write("Press any key to quit.");
            Console.ReadKey();

        }
        private static string Input(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
            private static bool DoAnother()
            {
                Console.Write("Do you want another? (y/n): ");
                var response = Console.ReadLine();
                return response.ToLower()[0] == 'y';
            }
        }
    }

