﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
	public class CustomerType
	{
		public int CustomerTypeId { get; set; }
		[Required]
		public string CustomerTypeName { get; set; }
		public string Description { get; set; }

	}
}
