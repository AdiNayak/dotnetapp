using Inventory.Model;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Product;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventory.ViewModel.Mapping
{
	public static class Relationshp
	{
		public static IEnumerable<CustomerTypeListViewModel> ModelToVM(this IEnumerable<CustomerType> customerTypes)
		{
            List<CustomerTypeListViewModel> list = new List<CustomerTypeListViewModel>();
			foreach (var customerType in customerTypes)
			{
				list.Add(
					new CustomerTypeListViewModel
					{
						CustomerTypeId = customerType.CustomerTypeId,
						CustomerTypeName = customerType.CustomerTypeName,
						Description = customerType.Description
					}
					);
			}
			return list;
		}

		public static IEnumerable<CustomerListViewModel> ModelToVM(this IEnumerable<Inventory.Model.Customer> customers)
		{
			List<CustomerListViewModel> list = new List<CustomerListViewModel>();
			foreach (var customer in customers)
			{
				list.Add(
					new CustomerListViewModel
					{
						CustomerId = customer.CustomerId,
						CustomerName = customer.CustomerName,
						Address = customer.Address,
						City = customer.City,
						State = customer.State,
						ZipCode = customer.ZipCode,
						Phone = customer.Phone,
						Email = customer.Email,
						ContactPerson = customer.ContactPerson
					}
					);
			}
			return list;
		}

		public static IEnumerable<BillTypeListViewModel> ModelToVM(this IEnumerable<BillType> billTypes)
		{
			List<BillTypeListViewModel> list = new List<BillTypeListViewModel>();
			foreach (var billType in billTypes)
			{
				list.Add(
					new BillTypeListViewModel
					{
						BillTypeId = billType.BillTypeId,
						BillTypeName = billType.BillTypeName,
						Description = billType.Description
					}
					);
			}
			return list;
		}

		public static IEnumerable<BillListViewModel> ModelToVM(this IEnumerable<Inventory.Model.Bill> bills)
		{
			List<BillListViewModel> list = new List<BillListViewModel>();
			foreach (var bill in bills)
			{

				list.Add(
							new BillListViewModel
							{
								BillTypeId = bill.BillTypeId,
								BillName = bill.BillName,
								GoodReceivedNotedId = bill.GoodReceivedNotedId,
								VendorDoNumber = bill.VendorDoNumber,
								VendorInvoiceNumber = bill.VendorInvoiceNumber,
								BillDate = bill.BillDate,
								BillDueDate = bill.BillDueDate,
								BillId = bill.BillId
							}
							);
			}
			return list;
		}

		public static IEnumerable<ProductTypeListViewModel> ModelToVM(this IEnumerable<ProductType> productTypes)
		{
			List<ProductTypeListViewModel> list = new List<ProductTypeListViewModel>();
			foreach (var productType in productTypes)
			{

				list.Add(
							new ProductTypeListViewModel
							{
								ProductTypeId = productType.ProductTypeId,
								ProductTypeName = productType.ProductTypeName,
								Description = productType.Description
							}
							);
			}
			return list;
		}

		public static IEnumerable<ProductListViewModel> ModelToVM(this IEnumerable<Inventory.Model. Product> products)
		{
			List<ProductListViewModel> list = new List<ProductListViewModel>();
			foreach (var product in products)
			{

				list.Add(
							new ProductListViewModel
							{
								ProductId= product.ProductId,
								ProductName= product.ProductName,
								ProductCode= product.ProductCode,
								BarCode= product.BarCode,
								Description= product.Description,
								ProductImage= product.ProductImage,
								MeasureUnitId= product.MeasureUnitId,
								BuyingPrice= product.BuyingPrice,
								SellingPrice= product.SellingPrice,
								BranchId= product.BranchId,
								CurrencyId= product.CurrencyId,
							}
							);
			}
			return list;
		}

	}
}
