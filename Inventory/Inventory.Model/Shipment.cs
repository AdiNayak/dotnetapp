using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventory.Model
{
	internal class Shipment
	{
        public int Id { get; set; }
		[Display(Name = "Shipment Name")]
		public string ShipmentName { get; set; }
		[Display(Name = "Sales Order")]
		public int SaleOrderId { get; set; }
        public DateTimeOffset ShipmentDate { get; set; }
		[Display(Name = "Shipment Type")]
		public int ShipmentTypeId { get; set; }
		[Display(Name = "Warehouse")]
		public int WarehouseId { get; set; }
		[Display(Name = "Full Shipment")]
		public bool IsFullShipment { get; set; } = true;	
	
	}
}
