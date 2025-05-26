using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical7.Models
{
	public class Author
	{
        
        public string Name { get; set; }

        public List<Publication> Publications { get; set; } = new List<Publication>();
    }
}