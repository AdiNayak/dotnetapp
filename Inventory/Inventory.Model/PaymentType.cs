using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
	public class PaymentType
	{
        public int PaymentTypeId { get; set; }
		[Required]
		public string PaymenTypeName { get; set; }
        public string Description { get; set; }
    }
}
