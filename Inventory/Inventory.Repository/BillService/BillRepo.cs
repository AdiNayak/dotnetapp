using Inventory.Repository.Paging;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.BillService
{
	internal class BillRepo : IBillRepo
	{
		private readonly ApplicationDbContext _context;

		public BillRepo(ApplicationDbContext context)
		{
			_context = context;
		}
		
		public async Task<PaginatedList<BillListViewModel>> GetAll(int pageSize, int pageNumber)
		{
			var billList = _context.Bills;
			var vm = billList.ModelToVM().AsQueryable();
			return  PaginatedList<BillListViewModel>.CreateAsync(vm, pageNumber, pageSize);
		}
	}
}
