using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
	public class PurchaseType
	{
        public int PurchaseTypeId { get; set; }
		[Required]
		public string PurchaseTypeName { get; set; }
		public string Description { get; set; }
    }
}
