using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
	public class InvoiceType
	{
        public int InvoiceTypeId { get; set; }
		[Required]
		public string InvoiceName { get; set; }
		public string Description { get; set;}
	}

    }
}
