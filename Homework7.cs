using System.Security.Cryptography;

namespace Homework7;

class Program
{
static void Main (string[] args)
{
    Customer c1 = new Customer(110, "Alice", 28);
    c1.PrintCustInfo();

    Customer c2 = new Customer(111, "Bob", 30);
    c2.PrintCustInfo();

    c1.ChangeID(220);
    c2.ChangeID(221);

    c1.PrintCustInfo();
    c2.PrintCustInfo();

    c1.CompareAge(c2);
  }
}

class Customer
{
private int cust_ID;
public string cust_Name;
public int cust_age;

public Customer(int ID, string Name, int age) 
{
     cust_ID = ID;
     cust_Name = Name;
     cust_age = age;
 }
 public void ChangeID(int new_ID) 
{
     cust_ID = new_ID;
}

 public void PrintCustInfo()
{
     Console.WriteLine($"Customer: "+cust_ID+",name: "+cust_Name+", age: "+cust_age);
}


public void CompareAge(Customer objCustomer)
{
Customer c1 = new Customer(110, "Alice", 28);
Customer c2 = new Customer(111, "Bob", 30);

c1.CompareAge(c2);
c2.CompareAge(c1);
Console.WriteLine($"{cust_Name} is older.");

}
}