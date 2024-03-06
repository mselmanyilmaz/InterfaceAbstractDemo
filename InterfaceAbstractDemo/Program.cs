using InterfaceAbstractDemo.Abstract;
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
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateofBirth = new DateTime(1991, 04, 21), FirstName = "Muharrem Selman", LastName = "YILMAZ", NationalityId = "17771400502" });
        }
    }
}
