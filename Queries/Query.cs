using NETGraphQLSample.Data;

namespace NETGraphQLSample.Queries
{
	public class Query
	{
		/// <summary>
		/// Один объект - книга
		/// </summary>
		/// <returns></returns>
		public Book GetBook()
		{
			var book = new Book()
			{
				Title = "C# in depth.",
				Author = new Author
				{
					Name = "Jon Skeet"
				}
			};

			return book;
		}

		/// <summary>
		/// Будет доступна как books
		/// </summary>
		/// <returns></returns>
		public Book[] GetBooks()
		{
			var book1 = new Book()
			{
				Title = "The Memoirs of Sherlock Holmes",
				Author = new Author
				{
					Name = "Arthur Conan Doyle"
				}
			};

			var book2 = new Book()
			{
				Title = "The Mysterious Island",
				Author = new Author
				{
					Name = "Jules Verne"
				}
			};


			return new Book[] { book1, book2 };
		}

	}
}
