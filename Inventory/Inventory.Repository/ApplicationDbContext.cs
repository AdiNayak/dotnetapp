using Inventory.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository
{
	public class ApplicationDbContext: IdentityDbContext
	{
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }
       public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<Bank> Bank { get; set; }
		public DbSet<Bill> Bills { get; set; }
		public DbSet<BillType> BillTypes { get; set; }
		public DbSet<Branch> Branches { get; set; }
		public DbSet<Currency> Currencies { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<CustomerType> CustomerTypes { get; set; }
		public DbSet<Invoice> Invoices { get; set; }
		public DbSet<InvoiceType> InvoiceTypes { get; set; }
		public DbSet<MeasureUnit> MeasureUnits { get; set; }
		public DbSet<NumberSequence> NumberSequences { get; set; }
		public DbSet<PaymentReceive> PaymentReceives { get; set; }
		public DbSet<PaymentType> PaymentTypes { get; set; }
		public DbSet<PaymentVoucher> PaymentVouchers { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductType> ProductTypes  { get; set; }
		public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
		public DbSet<PurchaseOrderLine> PurchaseOrderLines { get; set; }
		public DbSet<ReceiveNote> ReceiveNotes { get; set; }
		public DbSet<ReceiveNote> SalesOrders { get; set; }
		public DbSet<SaleOrderLine> SaleOrderLines { get; set; }
		public DbSet<SalesType> SalesTypes { get; set; }
		public DbSet<Shipment> Shipments { get; set; }
		public DbSet<ShipmentType> ShipmentTypes { get; set; }
		public DbSet<UserProfile> UserProfiles { get; set; }
		public DbSet<Vendor> Vendors { get; set; }
		public DbSet<VendorType> VendorTypes { get; set; }
		public DbSet<Warehouse> Warehouses { get; set; }
    }
}
