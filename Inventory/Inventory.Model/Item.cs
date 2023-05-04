using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
	internal class Item
	{
        public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set;}

        public int AvailQuantity { get; set; }

		public Status Status { get; set; }

    }
}

namespace Inventory.Model
{
	public enum Status
	{
		Ok,
		Defective
	}
}