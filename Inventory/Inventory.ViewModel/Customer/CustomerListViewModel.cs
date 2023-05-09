using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
	public class CustomerListViewModel
	{
		public int CustomerId { get; set; }
		[Required]
		public string CustomerName { get; set; }
		[Display(Name = "Customer Type")]
		public int CustomerTypeId { get; set; }
		[Display(Name = "Street Address")]
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		[Display(Name = "Zip Code")]
		public string ZipCode { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }

        public string ContactPerson { get; set; }
    }
}
