using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Utility
{
	public interface IDbInitialize
	{
		void CreateSuperAdmin();

		Task SendEmail(string fromEmail,
			string subject,
			string fromName,
			string message,
			string toEmail,
			string toName,
			string smtpUser,
			string smtpPassword,
			string smtpHost,
			string smtpPort,
			bool smtpSSL
			);
		Task <string> UploadFile (List<IFormFile> files,
			IWebHostEnvironment env,
			string directory);
	}
}
