using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        // Starbucks need customer validation
        ICustomerCheckService _customerCheckService;
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            // Dependency Injection
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if(_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Ekleme işlemi BAŞARISIZ!");
            }
        }
    }
}
