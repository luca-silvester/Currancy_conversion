using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Error checking variables
            int customer_pounds_C = 0;
            int customer_convertion = 0;
            int customer_check = 0;

            //Money / percentage variables
            float customer_pounds = 0;
            float fee = 0;
            float v = 0;
            v = customer_pounds;
            string conversion;
            float customer_converted = 0;
            double customer_fee = 0;
            string customer;
            double customer_Total = 0;
            double customer_total = 0;


            //This is the first line of error checking which is used in different veriation all over the code (no need to point it out ever time its used)
            while (customer_pounds_C < 1)
            {
                //This is the first prompt that the user will get and ticks off the fist piece of critiria
                Console.WriteLine("What is the value that the customer wants to exchange? (The maximum is £2500) ");
                customer_pounds = float.Parse(Console.ReadLine());

                fee = customer_pounds;

                //The IF staements acts as a form of error checking making sure taht the user is first of all inputting intergers but is also within the range that they 
                if (customer_pounds <= 2500 && customer_pounds >= 1)
                {
                    customer_pounds_C = 2;
                }

                else
                {
                    //This is one of the point which was mentioned in teh test plan which make sure that the user knows that the thing they inputted is invalid and will continue the loop
                    Console.WriteLine("You have entered a higher / lower value then you are able to exchange. ");
                }

            }

            //This is the chunkies part which could be optimised to make it either less chunky / get rid of most of the code but for now, this will survice
            while (customer_convertion < 1)
            {
                Console.WriteLine("What currency do you want to exchange it into? (American Dollars(USD), Euros(EUR), Brazilian real(BRL), Japanese Yen(JPY) or Turkish Lira(TRY)) ");
                conversion = Console.ReadLine();

                //The part bellow shows conversion proccess which is repeated with minor differences which allows for the 
                if (conversion == "USD" || conversion == "usd")
                {
                    customer_converted = customer_pounds * 1.40f;
                    if (customer_pounds >= 1 || customer_pounds <= 300)
                    {
                        customer_fee = fee * 3.5f;
                        customer_convertion = 2;
                    }
                    else if ((customer_pounds > 300) && (customer_pounds <= 750))
                    {
                        customer_fee = fee * 3f;
                        customer_convertion = 2;
                    }
                    else if ((customer_pounds > 750) && (customer_pounds <= 1000))
                    {
                        customer_fee = fee * 2.5f;
                        customer_convertion = 2;
                    }
                    else if ((customer_pounds > 100) && (customer_pounds <= 2000))
                    {
                        customer_fee = fee * 2f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 2000) && (customer_pounds <= 2500))
                    {
                        customer_fee = fee * 1.5;
                        customer_convertion = 2;
                    }
                    else
                    {
                        Console.WriteLine("There was a error, enter to go back ");
                    }
                }

                else if (conversion == "EUR")
                {
                    customer_converted = customer_pounds * 1.14f;
                    if (customer_pounds >= 1 || customer_pounds <= 300)
                    {
                        customer_fee = fee * 3.5f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 300) && (customer_pounds <= 750))
                    {
                        customer_fee = fee * 3f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 750) && (customer_pounds <= 1000))
                    {
                        customer_fee = fee * 2.5f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 100) && (customer_pounds <= 2000))
                    {
                        customer_fee = fee * 2f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 2000) && (customer_pounds <= 2500))
                    {
                        customer_fee = fee * 1.5f;
                        customer_convertion = 2;
                    }
                    else
                    {
                        Console.WriteLine("There was a error, enter to go back ");
                    }

                }

                else if (conversion == "BRL")
                {
                    customer_converted = customer_pounds * 4.77f;
                    if (customer_pounds >= 1 || customer_pounds <= 300)
                    {
                        customer_fee = fee * 3.5f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 300) && (customer_pounds <= 750))
                    {
                        customer_fee = fee * 3f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 750) && (customer_pounds <= 1000))
                    {
                        customer_fee = fee * 2.5f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 100) && (customer_pounds <= 2000))
                    {
                        customer_fee = fee * 2f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 2000) && (customer_pounds <= 2500))
                    {
                        customer_fee = fee * 1.5f;
                        customer_convertion = 2;
                    }
                    else
                    {
                        Console.WriteLine("There was a error, enter to go back ");
                    }

                }

                else if (conversion == "JPY")
                {
                    customer_converted = customer_pounds * 151.05f;
                    if (customer_pounds >= 1 || customer_pounds <= 300)
                    {
                        customer_fee = fee * 3.5f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 300) && (customer_pounds <= 750))
                    {
                        customer_fee = fee * 3f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 750) && (customer_pounds <= 1000))
                    {
                        customer_fee = fee * 2.5f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 100) && (customer_pounds <= 2000))
                    {
                        customer_fee = fee * 2f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 2000) && (customer_pounds <= 2500))
                    {
                        customer_fee = fee * 1.5f;
                        customer_convertion = 2;
                    }
                    else
                    {
                        Console.WriteLine("There was a error, enter to go back ");
                    }

                }

                else if (conversion == "TRY")
                {
                    customer_converted = customer_pounds * 5.68f;
                    if (customer_pounds >= 1 || customer_pounds <= 300)
                    {
                        customer_fee = fee * 3.5f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 300) && (customer_pounds <= 750))
                    {
                        customer_fee = fee * 3f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 750) && (customer_pounds <= 1000))
                    {
                        customer_fee = fee * 2.5f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 100) && (customer_pounds <= 2000))
                    {
                        customer_fee = fee * 2f;
                        customer_convertion = 2;
                    }
                    else if((customer_pounds > 2000) && (customer_pounds <= 2500))
                    {
                        customer_fee = fee * 1.5f;
                        customer_convertion = 2;
                    }
                    else
                    {
                        Console.WriteLine("There was a error, enter to go back ");
                    }

                }

                else
                {
                    Console.WriteLine("You have entered a invalid currency, enter to try again ");
                    Console.ReadLine();
                }

            }

            //This is the final loop and section to be exectuted which wraps everything into one with checking off the final piece of critirea and giving the user the total
            while (customer_check < 1)
            {
                Console.WriteLine("is the customer a member of staff? ");
                customer = Console.ReadLine();

                if (customer == "yes" || customer == "YES")
                {
                    customer_Total = customer_pounds / 5f;
                    customer_total = customer_fee + customer_Total;
                    Console.WriteLine("Your total is £" + customer_total+ " and your converted total is "+ customer_converted);
                    Console.ReadLine();
                    customer_check = 2;
                }
                else if (customer == "no" || customer == "NO")
                {
                    
                    Console.WriteLine("Your total is £" + customer_fee + " and your converted total is " + customer_converted);
                    Console.ReadLine();
                    customer_check = 2;
                }

            }



        }
    }
}
