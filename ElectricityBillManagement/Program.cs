using System;
using System.Collections.Generic;

namespace ElectricityBillManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DomesticCustomers> list1 = new List<DomesticCustomers>();
            List<ForeignCustomers> list2 = new List<ForeignCustomers>();
            DomesticCustomers dc = new DomesticCustomers();
            ForeignCustomers fc = new ForeignCustomers();
            int select;
            do
            {
                Console.WriteLine("================================");
                Console.WriteLine("1.List Customer ");
                Console.WriteLine("2.total consumption");
                Console.WriteLine("3.average amount of foreign visitors");
                Console.WriteLine("Other - Out");
                Console.WriteLine("Other Choice");
                select = Int32.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        int number = 0;
                        do
                        {
                            Console.WriteLine("========================");
                            Console.WriteLine("1.Khach hang trong nuoc");
                            Console.WriteLine("2.Khach hang ngoai nuoc");
                            Console.WriteLine("Other - Out");
                            Console.WriteLine("Lua chon:");
                            number = Int32.Parse(Console.ReadLine());
                            if (number == 1)
                            {
                                DomesticCustomers dcx = dc.Intput();
                                list1.Add(dcx);
                                Console.WriteLine(dc);
                                Console.WriteLine("Success!");
                            }
                            else if(number == 2)
                            {
                                ForeignCustomers fcx = fc.Intput();
                                list2.Add(fcx);
                                Console.WriteLine(fc);
                                Console.WriteLine("Success!");
                            }
                            else
                            {
                                number = 0;
                            }
                        } while (number <=2 && number >0);
                        break;
                    case 2:
                        int sum1 =0, sum2 = 0;
                        foreach(DomesticCustomers dcl in list1)
                        {
                            sum1 += dcl.Quantity; 
                        }
                        foreach (ForeignCustomers fcl in list2)
                        {
                            sum2 += fcl.Quantity;
                        }
                        Console.WriteLine("Total KW:" + (sum1 + sum2));
                        Console.WriteLine("Khach hang trong nuoc: " + sum1 + " KW");
                        Console.WriteLine("Khach hang ngoai nuoc: " + sum2 + " KW");
                        break;
                    case 3:
                        double sumBill = 0;
                        int count = 0;
                        foreach (ForeignCustomers fcl in list2)
                        {
                            sumBill += fcl.Bill;
                            count++;
                        }
                        double tbBill = sumBill / count;
                        Console.WriteLine("average amount of foreign visitors is: " + tbBill);
                        break;
                }
            } while (select <= 3 && select > 0);


        }
    }
    
}
