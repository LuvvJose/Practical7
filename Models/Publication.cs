using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical7.Models
{
	public abstract class Publication
	{
        public string Title { get; set; }
        public Author Author { get; set; }
        public string Summary { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public DateTime PublicationDate { get; set; }
        public abstract string Type { get; }
        public string GetDate()
        {
            return PublicationDate.ToString("dddd, dd MMMM yyyy");
        }
    }

    public class Article : Publication
    {
        public override string Type => "Article";
    }

    public class Book : Publication
    {
        public int EditionCount { get; set; }
        public override string Type => "Book";
        public string GetEditionDisplay()
        {
            return EditionCount == 1 ? "1st Edition" : $"{EditionCount} Editions";
        }

    }
}
