using Inventory.Repository.Paging;
using Inventory.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.CustomerTypeService
{
	public interface ICustomerTypeRepo
	{
		Task<PaginatedList<CustomerTypeListViewModel>> GetAll(int pageSize, int pageNumber);
	}
}
