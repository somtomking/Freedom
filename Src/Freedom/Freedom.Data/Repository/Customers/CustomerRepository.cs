using Freedom.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.Data.Repository.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly EfRepository<Customer> _repository;

        public CustomerRepository(EfRepository<Customer> repository)
        {
            _repository = repository;
        }

        public Customer GetById(long id)
        {
            return _repository.Find(id);
        }
        public void Update(Customer customer)
        {
            _repository.Update(customer);
        }
        public void Add(Customer customer)
        {
            _repository.Add(customer);
        }
    }
}





