using Inventory.Repository.Paging;
using Inventory.ViewModel.Bill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.BillService
{
	internal interface IBillRepo
	{
		Task<PaginatedList<BillListViewModel>> GetAll(int pageSize, int pageNumber);
	}
}
