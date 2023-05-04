using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
	internal class SaleType
	{
		public int SaleTypeId { get; set; }
		[Required]
		public string SaleTypeName { get; set; }
		public string Description { get; set; }
	}
}
