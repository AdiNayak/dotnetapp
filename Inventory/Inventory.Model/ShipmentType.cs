using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
	public class ShipmentType
	{
		public int ShipmentTypeId { get; set; }
		[Required]
		public string ShipmentTypeName { get; set; }
		public string Description { get; set; }
	}
}
