using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
	internal class Brand
	{
        public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string Description { get; set; } = string.Empty;	
	
    }
}
