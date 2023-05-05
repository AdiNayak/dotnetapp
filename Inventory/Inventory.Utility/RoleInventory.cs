using Inventory.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Utility
{
	public class RoleInventory : IRoleInventory
	{
		private RoleManager<IdentityRole> _roleManager;
		private UserManager<AppUser> _userManager;
		public RoleInventory(RoleManager<IdentityRole> roleManager,
			UserManager<AppUser> userManager)
		{
			_roleManager = roleManager;
			_userManager = userManager;
		}
		public async Task AddRoleAsync( string appUserId)
		{
			var user = await _userManager.FindByIdAsync(appUserId);
			var roles = _roleManager.Roles;
			List<string> roleNames = new List<string>();
			if (user != null)
			{
                foreach (var item in roles)
                {
					roleNames.Add(item.Name);
				}
				await _userManager.AddToRolesAsync(user, roleNames);
            }
		}

		public async Task CreateNewRoleAsync()
		{
			Type type = typeof(TopMenu);
            foreach (var classObj in type.GetNestedTypes())
            {
                foreach (var objField in classObj.GetFields()  )
                {
					if (objField.Name.Contains("RoleName") )
					{
						var roleName = (string)objField.GetValue(objField);
						var isRoleExist  = await _roleManager.RoleExistsAsync(roleName);
						if (!isRoleExist)
						{
							await _roleManager.CreateAsync(new IdentityRole(roleName));
						}
					}
                }
            }
        }
	}
}
