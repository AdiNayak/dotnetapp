using Inventory.Model;
using Inventory.Repository;
using Inventory.Utility.HelperClass;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Utility
{
	public class DbInitialize:IDbInitialize
	{

		private readonly UserManager<AppUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private SuperAdmin _superAdmin;
		private ApplicationDbContext _context;
		private IRoleInventory _roleInventory;
		public DbInitialize(UserManager<AppUser> userManager,
			RoleManager<IdentityRole> roleManager,
			IOptions<SuperAdmin> superAdmin,
			ApplicationDbContext context,
			IRoleInventory roleInventory)
		{
			_userManager = userManager;
			_roleManager = roleManager;
			_superAdmin = superAdmin.Value;
			_context = context;
			_roleInventory = roleInventory;
		}

		public async void CreateSuperAdmin()
		{
			AppUser appUser = new AppUser();
			appUser.Email = "";
			appUser.UserName = "";
			appUser.EmailConfirmed = true;
			appUser.UserName = "";
			appUser.UserName = "";
			var response = await _userManager.CreateAsync(appUser,_superAdmin.Password);
			if (response.Succeeded)
			{
				UserProfile userProfile = new UserProfile();
				userProfile.FirstName = "Admin";
				userProfile.LastName = "Admin";
				userProfile.Email = appUser.Email;
				userProfile.AppUserId = appUser.Id;
				await _context.UserProfiles.AddAsync(userProfile);
				await _context.SaveChangesAsync();
				await _roleInventory.AddRoleAsync(appUser.Id);
			}
		}

		public async Task SendEmail(string fromEmail,
			string subject,
			string fromName,
			string message,
			string toEmail,
			string toName,
			string smtpUser,
			string smtpPassword,
			string smtpHost,
			string smtpPort,
			bool smtpSSL)
		{
			var body = message;
			var messageRequest = new MailMessage();
			messageRequest.To.Add(new MailAddress(toEmail, toName));
			messageRequest.From = new MailAddress(fromEmail, fromName);
			messageRequest.Subject = subject;
			messageRequest.Body = body;
			messageRequest.IsBodyHtml = true;
			using (var smtp = new SmtpClient())
			{
				var credential = new NetworkCredential
				{
					UserName = smtpUser,
					Password = smtpPassword
				};
				smtp.Credentials = credential;
				smtp.Host= smtpHost;
				smtp.Port = Convert.ToInt32( smtpPort);
				smtp.EnableSsl= smtpSSL;
				await smtp.SendMailAsync(messageRequest);
			}
		}

		public async Task<string> UploadFile(List<IFormFile> files, IWebHostEnvironment env, string directory)
		{
			var response = string.Empty;
			var upload = Path.Combine(env.WebRootPath, directory);
			var fileExtension = string.Empty;
			var filePath = string.Empty;
			var fileName = string.Empty;
            foreach (var file in files)
            {
				if (file.Length > 0)
				{
					fileExtension = Path.GetExtension(file.FileName);
					fileName = Guid.NewGuid().ToString()+fileExtension;
					filePath = Path.Combine(upload, fileName);
					using (var fileStream = new FileStream(filePath,FileMode.Create))
					{
						await file.CopyToAsync(fileStream);
					}
					response = fileName;
				}
            }

			return response;
        }
	}
}
