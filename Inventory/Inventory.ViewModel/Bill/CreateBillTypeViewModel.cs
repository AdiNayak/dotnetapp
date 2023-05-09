using Inventory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModel.Bill
{
    public class CreateBillTypeViewModel
    {
        public int BillTypeId { get; set; }
        public string BillTypeName { get; set; }
        public string Description { get; set; }

        public BillType VMToModel()
        {
            return new BillType
            { 
                BillTypeId = BillTypeId, 
                BillTypeName = BillTypeName, 
                Description = Description 
            };
        }
    }
}
