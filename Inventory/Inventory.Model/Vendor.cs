using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
	public class Vendor
	{
		public int VendorId { get; set; }
		public string VendorName { get; set; }
		[Display(Name = "Vendor Type")]
		public int VendorTypeId { get; set; }
		public string Address { get; set; }
		public string State { get; set; }
		[Display(Name = "Zip Code")]
		public string ZipCode { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }

		[Display(Name = "Contanct Person")]
		public string ContanctPersons { get; set; }

	}
}
