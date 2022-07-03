using System;

namespace ElectricBill


{
        class residential
        {
            public float original_bill, taxes, total_bill;

            public void resident()
            {
                Console.WriteLine("\n\n Enter your this month units: \n\n");
                float units = float.Parse(Console.ReadLine());
                Console.WriteLine("\n\n Your this month units are: \n\n" + units);

                if (units > 0 && units <= 100)
                {
                    original_bill = units * 5;
                    Console.WriteLine("\n\n Your monthly bill is: \n\n" + original_bill);
                    taxes = original_bill * 13 / 100;
                    Console.WriteLine("\n\n Your bill with taxes: \n\n" + taxes);
                    total_bill = original_bill + taxes;
                    Console.WriteLine("\n\n Your total bill of this month is: \n\n" + total_bill);
                }
                else if (units > 100 && units <= 200)
                {
                    original_bill = units * 17;
                    Console.WriteLine("\n\n Your today month bill is: \n\n" + original_bill);
                    taxes = original_bill * 13 / 100;
                    Console.WriteLine("\n\n Your bill with taxes: \n\n" + taxes);
                    total_bill = original_bill + taxes;
                    Console.WriteLine("\n\n Your total bill of this month is: \n\n" + total_bill);
                }
                else if (units > 200 && units <= 500)
                {
                    original_bill = units * 23;
                    Console.WriteLine("\n\n Your today month bill is: \n\n" + original_bill);
                    taxes = original_bill * 13 / 100;
                    Console.WriteLine("\n\n Your bill with taxes: \n\n" + taxes);
                    total_bill = original_bill + taxes;
                    Console.WriteLine("\n\n Your total bill of this month is: \n\n" + total_bill);
                }
                else if (units > 500)
                {
                    original_bill = units * 69;
                    Console.WriteLine("\n\n Your today month bill is: \n\n" + original_bill);
                    taxes = original_bill * 13 / 100;
                    Console.WriteLine("\n\n Your bill with taxes: \n\n" + taxes);
                    total_bill = original_bill + taxes;
                    Console.WriteLine("\n\n Your total bill of this month is: \n\n" + total_bill);
                }
                else
                {
                    Console.WriteLine("\n\n You are Entering Wrong Units:");

                }

            }
        }

        class commercial
        {
            public float original_bill, taxes, total_bill;
            public void commer()
            {
                Console.WriteLine("\n\n Enter your this month units: \n\n");
                float units = float.Parse(Console.ReadLine());
                Console.WriteLine("\n\n Your this month units are: \n\n" + units);

                if (units > 0 && units <= 100)
                {
                    original_bill = units * 8;
                    Console.WriteLine("\n\n Your today month bill is: \n\n" + original_bill);
                    taxes = original_bill * 17 / 100;
                    Console.WriteLine("\n\n Your bill with taxes: \n\n" + taxes);
                    total_bill = original_bill + taxes;
                    Console.WriteLine("\n\n Your total bill of this month is: \n\n" + total_bill);
                }
                else if (units > 100 && units <= 200)
                {
                    original_bill = units * 21;
                    Console.WriteLine("\n\n Your today month bill is: \n\n" + original_bill);
                    taxes = original_bill * 17 / 100;
                    Console.WriteLine("\n\n Your bill with taxes: \n\n" + taxes);
                    total_bill = original_bill + taxes;
                    Console.WriteLine("\n\n Your total bill of this month is: \n\n" + total_bill);
                }
                else if (units > 200 && units <= 500)
                {
                    original_bill = units * 23;
                    Console.WriteLine("\n\n Your today month bill is: \n\n" + original_bill);
                    taxes = original_bill * 17 / 100;
                    Console.WriteLine("\n\n Your bill with taxes: \n\n" + taxes);
                    total_bill = original_bill + taxes;
                    Console.WriteLine("\n\n Your total bill of this month is: \n\n" + total_bill);
                }
                else if (units > 500)
                {
                    original_bill = units * 79;
                    Console.WriteLine("\n\n Your today month bill is: \n\n" + original_bill);
                    taxes = original_bill * 17 / 100;
                    Console.WriteLine("\n\n Your bill with taxes: \n\n" + taxes);
                    total_bill = original_bill + taxes;
                    Console.WriteLine("\n\n Your total bill of this month is: \n\n" + total_bill);
                }
                else
                {
                    Console.WriteLine("\n\n You are Entering Wrong Units:");

                }
            }
        }
        
    class Electricity_Bill
    { 

        static void Main (string[] args)
        {
            residential res = new residential();
            commercial com = new commercial();
            Console.WriteLine("\n\n Enter your Bill location:\n 1: Residential \n 2: Commercial \n\n");
            string location = Console.ReadLine();
            Console.WriteLine("\n\n Your Bill location is: \n\n" + location);

            if(location=="resident")
            {
                res.resident();
            }
            else if(location == "commercial")
            {
                com.commer();
            }
            else
            {
                Console.WriteLine("\n\n Your Billing location does not match.");
            }
        }
    }

}