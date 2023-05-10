using Inventory.Model;
using Inventory.Repository.Paging;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.BillTypeService
{
	public class BillTypeRepo : IBillTypeRepo
	{
		private readonly ApplicationDbContext _context;

		public BillTypeRepo(ApplicationDbContext context)
		{
			_context = context;
		}
        public void Add(CreateBillTypeViewModel model)
        {
            var billType = model.VMToModel();
            _context.BillTypes.Add(billType);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var model = _context.BillTypes.Where(x => x.BillTypeId == id ).FirstOrDefault();
            if (model != null)
            {
                _context.BillTypes.Remove(model);
            }
            _context.SaveChanges();
        }
        public async Task<PaginatedList<BillTypeListViewModel>> GetAll(int pageSize, int pageNumber)
		{
			var billTypesList = _context.BillTypes;
			var vm = billTypesList.ModelToVM().ToList().AsQueryable();
            var  res =  PaginatedList<BillTypeListViewModel>.CreateAsync(vm, pageNumber, pageSize);
            return res;

        }
        public BillTypeViewModel GetById(int id)
        {
            var model = _context.BillTypes.Where( x => x.BillTypeId == id ).FirstOrDefault();
            var vm = new BillTypeViewModel(model);
            return vm;
        }
        public void Update(BillTypeViewModel vm)
        {
            var model = _context.BillTypes.Where( x=> x.BillTypeId  == vm.BillTypeId ).FirstOrDefault();
            if (model != null)
            {
                model.BillTypeName = vm.BillTypeName;
                model.Description = vm.Description;
            }
            _context.SaveChanges();
        }
    }
}
