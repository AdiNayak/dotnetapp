using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
	public class Warehouse
	{
		public int WarehouseId { get; set; }
		public string WarehouseName { get; set; }
		public string Description { get;}
		[Display(Name = "Branch")]
        public int BranchId { get; set; }
    }
}
