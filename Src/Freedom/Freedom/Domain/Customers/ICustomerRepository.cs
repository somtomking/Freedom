using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.Domain.Customers
{
    public partial interface ICustomerRepository
    {
        Customer GetById(long id);

        void Update(Customer customer);
        void Add(Customer customer);


    }
}
