using Inventory.Model;
using Inventory.Repository.Paging;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.CustomerService
{
	internal class CustomerRepo : ICustomerRepo
	{
		private readonly ApplicationDbContext _context;

		public CustomerRepo(ApplicationDbContext context)
		{
			_context = context;
		}

	
		public async Task<PaginatedList<CustomerListViewModel>> GetAll(int pageSize, int pageNumber)
		{
			var customerList = _context.Customers;
			var vm = customerList.ModelToVM().AsQueryable();
			return  PaginatedList<CustomerListViewModel>.CreateAsync( vm, pageNumber, pageSize);
		}
	}
}
