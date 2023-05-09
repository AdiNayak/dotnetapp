using Inventory.Repository.Paging;
using Inventory.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.ProductService
{
	public interface IProductRepo
	{
		Task<PaginatedList<ProductListViewModel>> GetAll(int pageSize, int pageNumber);
	}
}
