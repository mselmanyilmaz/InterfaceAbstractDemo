using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    public class Program
    {
        static void Main(string[] args)
        { 
            BaseCustomerManager customerManager1 = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager1.Save(new Customer { DateofBirth = new DateTime(1234, 12, 45), FirstName = "Muharrem Selman", LastName = "YILMAZ", NationalityId = "12345678901" });

            Console.ReadLine();
        }
    }
}
