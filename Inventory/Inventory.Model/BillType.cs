﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
	public class BillType
	{
		[Key]
        public int BillTypeId  { get; set; }
		[Required]
		public string BillTypeName { get; set; }
		public string Description { get; set; }

	}
}
