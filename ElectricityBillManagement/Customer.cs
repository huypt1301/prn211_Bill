using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBillManagement
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public double Bill { get; set; }
        public Customer()
        {
        }

        public Customer(int id, string name, string address, int quantity, int unitprice, double bill)
        {
            Id = id;
            Name = name;
            Address = address;
            Quantity = quantity;
            UnitPrice = unitprice;
            Bill = bill;
        }

        public override string ToString()
        {
            return $"Id = {Id} || Name = {Name} || Address = {Address} || Quantity(KW) = {Quantity} || UnitPrice = {UnitPrice} || Bill = {Bill}";
        }
    }
    public class DomesticCustomers : Customer
    {
        public string ObjectCustomer { get; set; }
        public int Limit { get; set; }

        public DomesticCustomers()
        {
        }

        public DomesticCustomers(int id, string name, string address, string objectCustomer, int quantity, int unitprice, int limit, double bill) :base (id,name, address,quantity,unitprice, bill)
        {
            ObjectCustomer = objectCustomer;
            Limit = limit;
        }
        public DomesticCustomers Intput()
        {
            Console.WriteLine("Enter ID: ");
            Id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Emter Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Enter Kind Cus: ");
            ObjectCustomer = Console.ReadLine();
            Console.WriteLine("Enter quantity (kw) : ");
            Quantity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price: ");
            UnitPrice = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Limit: ");
            Limit = Int32.Parse(Console.ReadLine());
            Bill = this.ResultBill(Quantity, Limit, UnitPrice);
            return new DomesticCustomers(Id, Name, Address, ObjectCustomer, Quantity, UnitPrice, Limit, Bill);
        }

        public double ResultBill(int quantity, int limit, int unitPrice)
        {
            double bill;
            if(quantity <= limit)
            {
                bill = quantity * unitPrice;
            }
            else
            {
                bill = quantity * unitPrice + (quantity - limit) * unitPrice * 2.5;
            }
            return bill;
        }

        public override string ToString()
        {
            return $"Id = {Id} || Name = {Name} || Address = {Address} || ObjectCustomer = {ObjectCustomer} || Quantity(KW) = {Quantity} || UnitPrice = {UnitPrice} || Limit = {Limit} || Bill = {Bill}";
        }
    }

    public class ForeignCustomers : Customer
    {
        public string Nationality { get; set; }

        public ForeignCustomers()
        {
        }

        public ForeignCustomers(int id, string name, string address, string nationality,  int quantity, int unitprice, double bill) :base (id, name, address, quantity, unitprice, bill)
        {
            Nationality = nationality;
        }
        public ForeignCustomers Intput()
        {
            Console.WriteLine("Enter ID: ");
            Id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Emter Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Enter the country: ");
            Nationality = Console.ReadLine();
            Console.WriteLine("Enter quantity (kw): ");
            Quantity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price: ");
            UnitPrice = Int32.Parse(Console.ReadLine());
            Bill = Quantity * UnitPrice;
            return new  ForeignCustomers(Id, Name, Address, Nationality, Quantity, UnitPrice, Bill);
        }

        public override string ToString()
        {
            return $"Id = {Id} || Name = {Name} || Address = {Address} || Nationallity = {Nationality} || Quantity(KW) = {Quantity} || UnitPrice = {UnitPrice} || Bill = {Bill}";
        }
    }
}
