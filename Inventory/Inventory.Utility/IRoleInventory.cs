using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Utility
{
	public interface IRoleInventory
	{
		Task CreateNewRoleAsync();
		Task AddRoleAsync( string appUserId);
	}
}
