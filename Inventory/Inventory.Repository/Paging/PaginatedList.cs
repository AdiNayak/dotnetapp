

namespace Inventory.Repository.Paging
{
	public class PaginatedList<T>:List<T>
	{
		public int PageIndex { get; private set; }
		public int TotalPages { get; private set; }
		public int Pagesize { get; private set; }

		public int TotalRecords { get; private set; }

		public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
		{
			PageIndex = pageIndex;
			TotalRecords = count;
			Pagesize = pageSize;
			TotalPages = (int)Math.Ceiling(count / (double)pageSize);

			this.AddRange(items);
		}

		public bool HasPreviousPage
		{
			get
			{
				return (PageIndex > 1);
			}
		}

		public bool HasNextPage
		{
			get
			{
				return (PageIndex < TotalPages);
			}
		}

		public static  PaginatedList<T> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
		{
			try
			{
				var count =  source.Count();
				var items =  source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
				return new PaginatedList<T>(items, count, pageIndex, pageSize);
			}
			catch (Exception exception)
			{
				return null;
			}
		}
	}
}
