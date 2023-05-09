using Inventory.Repository.Paging;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.ProductTypeService
{
	public interface IProductTypeRepo
	{
		Task<PaginatedList<ProductTypeListViewModel>> GetAll(int pageSize, int pageNumber);
	}
}
