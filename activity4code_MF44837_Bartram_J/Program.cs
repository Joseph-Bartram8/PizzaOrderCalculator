using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //customer details
            string name = "";
            string address = "";
            string phoneNumber = "";

            //pizza details
            int NoPizzas = 0;

            double total = 0.00;

            double toppingcost = 0.00;

            //delivery details
            string dilivery = "";



            // gettings details from customer through user inputs
            // using while loop to ensure a valid value is entered so no error message comes up
            // using IF statement to ensure something is entered and isn't left blank.
            while (name == "")
            {
                Console.Write("Please enter the name of the customer: ");
                name = Console.ReadLine();
                if (name == "")
                {
                    Console.Write("Invalid entry. Please enter the customers name!!");
                }
            }

            while (address == "")
            {
                Console.Write("Please enter the address of the customer: ");
                address = Console.ReadLine();
                if (address == "")
                {
                    Console.WriteLine("Invalid entry. Please enter the customers address!!");
                }
            }

            while (phoneNumber == "")
            {
                try
                {
                    Console.Write("Please enter the phone number of the customer: ");
                    phoneNumber = Console.ReadLine();
                    if (phoneNumber == "")
                    {
                        Console.WriteLine("Invalid entry. Please enter a valid phone number!!");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid entry. Please enter a valid phone number!!");
                }
            }

            // Getting the number of pizzas the customer is ordering through user inputs
            //
            while (NoPizzas < 1 || NoPizzas > 6)
            {
                try
                {
                    Console.Write("Please enter the number of pizzas the customer has ordered between 1 and 6: ");
                    NoPizzas = Convert.ToInt32(Console.ReadLine());
                    if (NoPizzas < 1 || NoPizzas > 6)
                    {
                        Console.WriteLine("Invalid entry. Please enter a number between 1 and 6!!");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid entry. Please enter a number between 1 and 6!!");
                }

            }

            // declare arrays to hold size and toppings for each pizza
            string[] pizzasize = new string[NoPizzas];
            int[] toppings = new int[NoPizzas];


            // get details for each pizza
            for (int i = 0; i < NoPizzas; i++)
            {
                Console.WriteLine("Pizza {0}: What size of pizza S/M/L", i + 1);
                pizzasize[i] = Console.ReadLine();

                if (pizzasize[i] == "S" || pizzasize[i] == "M" || pizzasize[i] == "L")
                {

                }
                else
                {
                    Console.WriteLine("Invalid entry. Please enter erither S for small, M for " +
                                      "medium or L for large");
                    i = i - 1;
                }
            }
            for (int i = 0; i < NoPizzas; i++)
            {
                try
                {
                    Console.WriteLine("Pizza {0}: How many toppings", i + 1);
                    toppings[i] = int.Parse(Console.ReadLine());

                    if (toppings[i] < 0)
                    {
                        Console.WriteLine("Invalid entry. Please enter erither a number valid number 0 or over");
                        i = i - 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid entry. Please enter erither a number valid number 0 or over");
                    i = i - 1;
                }

            }


            // Display itemised bill & calculate total cost
            for (int i = 0; i < NoPizzas; i++)
            {
                if (pizzasize[i] == "S")
                {
                    if (toppings[i] == 0)
                    {
                        toppingcost = 0.00;
                    }
                    else if (toppings[i] == 1)
                    {
                        toppingcost = 0.75;
                    }
                    else if (toppings[i] == 2)
                    {
                        toppingcost = 1.35;
                    }
                    else
                    {
                        toppingcost = 2.00;
                    }

                    Console.WriteLine("Small Pizza at £3.25 with {0} toppings at £{1}", toppings[i], toppingcost);
                    total = total + 3.25 + toppingcost;
                    Console.Read();
                }
                else if (pizzasize[i] == "M")
                {
                    if (toppings[i] == 0)
                    {
                        toppingcost = 0.00;
                    }
                    else if (toppings[i] == 1)
                    {
                        toppingcost = 0.75;
                    }
                    else if (toppings[i] == 2)
                    {
                        toppingcost = 1.35;
                    }
                    else
                    {
                        toppingcost = 2.00;
                    }

                    Console.WriteLine("Medium pizza at £5.50 with {0} toppings at £{1}", toppings[i], toppingcost);
                    total = total + 5.50 + toppingcost;
                    Console.Read();
                }
                else if (pizzasize[i] == "L")
                {
                    if (toppings[i] == 0)
                    {
                        toppingcost = 0.00;
                    }
                    else if (toppings[i] == 1)
                    {
                        toppingcost = 0.75;
                    }
                    else if (toppings[i] == 2)
                    {
                        toppingcost = 1.35;
                    }
                    else
                    {
                        toppingcost = 2.00;
                    }

                    Console.WriteLine("Large pizza at £7.15 with {0} toppings at £{1}", toppings[i], toppingcost);
                    total = total + 7.15 + toppingcost;
                    Console.Read();
                }
            }

            if (total < 20)
            {
                Console.WriteLine("Customer doesn't get a discount");
                Console.WriteLine("The current total is: £" + total);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Customer gets a 10% discount");
                total = total * 0.9;
                Console.WriteLine("The current total is: £" + total);
                Console.ReadLine();
            }

            while (dilivery == "")
            {
                Console.Write("Does the customer want dilivery? ");
                dilivery = Console.ReadLine();

                if (dilivery == "yes")
                {
                    total = total + 2.50;
                    Console.WriteLine("The total of your order is: £" + total);
                    Console.ReadLine();
                }
                else if (dilivery == "no")
                {
                    Console.WriteLine("The total of your order is: £" + total);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid entry. please put 'yes' or 'no'");
                }
            }

        }
    }
}
