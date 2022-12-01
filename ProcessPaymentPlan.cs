using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;


namespace Installmental_payment_app
{

    public enum PaymentPlans
    {
        Weekly = 7,
        Monthly = 30,
        Yearly = 365
    }



    public class ProcessPaymentPlan
    {
        public double _amountOwed { get; set; } = new Random().Next(10000, 100000);
        public DateTime currentDate = DateTime.Now;


        double installmentAmount;
        int totalTimespan;
        string? recordString;

        const string filename = "records.txt";

        static string file = "C:\\Users\\user\\source\\repos\\Installmental_payment_app\\PaymentRecords\\records.txt";

        StreamWriter writer = File.AppendText(file);


        public void RunInstallmentProcess()
        {
            try
            {
                mainPrompt:
                Console.WriteLine($"Mr Buhari's installmental payment calculator \n\nAmount Owed: {_amountOwed} \n\nPlease select a payment plan: \n1: {PaymentPlans.Weekly}\n2: {PaymentPlans.Monthly}\n3: {PaymentPlans.Yearly}");

                string? planSelect = Console.ReadLine();

                Console.Write("\nEnter payment plan span, shouldn't be greater than 5: ");
                
                int validTimespan;

                if(!Int32.TryParse(Console.ReadLine(), out validTimespan))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid input\n");
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    goto mainPrompt;
                }

                if(validTimespan > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nI'm sorry, but span cannot be greater than 5\n");
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    goto mainPrompt;
                }

                

                switch (planSelect)
                {
                    case "1":
                        totalTimespan = (int)PaymentPlans.Weekly * validTimespan;

                        installmentAmount = Math.Floor(_amountOwed / totalTimespan);

                        Console.ForegroundColor = ConsoleColor.Blue;
                        recordString = ($"\n\nNEW RECORD ADDED\nPayment plan selected: {PaymentPlans.Weekly}\nPayment plan span: {validTimespan}\nAmount to pay in installments: {installmentAmount}\nNumber of days left: {totalTimespan - 1}\nStart date: {currentDate.ToShortDateString()}\nEnd date: {currentDate.AddDays(totalTimespan).ToShortDateString()}\n");
                        Console.WriteLine(recordString);
                        Console.ForegroundColor = ConsoleColor.White;

                        Thread.Sleep(2000);

                        Console.WriteLine("Entering details into records file...");
                        Thread.Sleep(1000);


                        writer.Write(recordString);
                        writer.Write("---------------------------------------\n---------------------------------------");
                        writer.Close();


                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Records entered successfully...");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;
                    case "2":
                        totalTimespan = (int)PaymentPlans.Monthly * validTimespan;

                        installmentAmount = Math.Floor(_amountOwed / totalTimespan);

                        Console.ForegroundColor = ConsoleColor.Blue;
                        recordString = ($"\n\nNEW RECORD ADDED\nPayment plan selected: {PaymentPlans.Monthly}\nPayment plan span: {validTimespan}\nAmount to pay in installments: {installmentAmount}\nNumber of days left: {totalTimespan - 1}\nStart date: {currentDate.ToShortDateString()}\nEnd date: {currentDate.AddDays(totalTimespan).ToShortDateString()}\n");
                        Console.WriteLine(recordString);
                        Console.ForegroundColor = ConsoleColor.White;

                        Thread.Sleep(2000);

                        Console.WriteLine("Entering details into records file...");
                        Thread.Sleep(1000);

                        writer.Write(recordString);
                        writer.Write("---------------------------------------\n---------------------------------------");
                        writer.Close();


                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Records entered successfully...");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;
                    case "3":
                        totalTimespan = (int)PaymentPlans.Yearly * validTimespan;

                        installmentAmount = Math.Floor(_amountOwed / totalTimespan);

                        Console.ForegroundColor = ConsoleColor.Blue;
                        recordString = ($"\n\nNEW RECORD ADDED\nPayment plan selected: {PaymentPlans.Yearly}\nPayment plan span: {validTimespan}\nAmount to pay in installments: {installmentAmount}\nNumber of days left: {totalTimespan - 1}\nStart date: {currentDate.ToShortDateString()}\nEnd date: {currentDate.AddDays(totalTimespan).ToShortDateString()}\n");
                        Console.WriteLine(recordString);
                        Console.ForegroundColor = ConsoleColor.White;

                        Thread.Sleep(2000);

                        Console.WriteLine("Entering details into records file...");
                        Thread.Sleep(1000);

                        writer.Write(recordString);
                        writer.Write("---------------------------------------\n---------------------------------------");
                        writer.Close();


                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Records entered successfully...");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;
                    default:
                        Console.WriteLine("Please select from the available payment plans");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
