using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
	public class Branch
	{
        public int BranchId { get; set; }
		[Required]
		public string BranchName { get; set; }
		public string Description { get; set; }
		[Display(Name = "Currency")]
		public int CurrencyId { get; set; }
		public string Address { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public string Zipcode { get; set; }

		public string Phone { get; set; }

		public string Email { get; set; }
		[Display(Name = "Contanct Person")]
		public string ContanctPerson { get; set; }
	}
}
