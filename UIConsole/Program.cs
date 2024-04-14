using Business.Abstract;
using Business.Adapters;
using Business.Concrete;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisCheckService());
            customerManager.Save(new Entities.Concrete.Customer { 
                Id = 1, FirstName = "", LastName = "", BirthDate = new DateTime(), NationalityId = "0"
            });
        }
    }
}