using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical7.Models
{
	public static class FakeData
	{
        public static List<Publication> GetAllPublications()
        {
            var author1 = new Author { Name = "Koffi Umukoro" };
            var author2 = new Author { Name = "Octavia Barret" };
            var author3 = new Author { Name = "Gunnhild Aric" };
            var author4 = new Author { Name = "Jakob Ayanda" };

            var publications = new List<Publication>
            {
                new Article
                {
                    Title = "Improving the foundation of our falling sand simulator",
                    Author = author1,
                    Summary = "Addison is a detective from Sale who falls in love with his best friend. The two are separated when the best friend falls for somebody else. However, Addison manages to rescue the situation by buying a magnificent t-shirt.,",
                    Url = "https://bait.example.net/bag.aspx",
                    PublicationDate = new DateTime(2018, 07, 24),
                    ImageUrl = "/images/sktop-3194194_340.jpg"
                },
                new Book
                {
                    Title = "NASA fed some Apollo 11 lunar samples to cockroaches and mice",
                    Author = author2,
                    Summary = "A farmer from Markham is delighted when she gets the chance to take part in the final of X-Factor. However, her chances are scuppered when her son goes missing. Unexpectedly, the farmer is bitten by a zombie and therefore is disqualified from competing.",
                    Url = "https://www.example.com/bite.aspx",
                    PublicationDate = new DateTime(2006, 5, 15),
                    EditionCount = 2,
                    ImageUrl = "/images/lemur-1602313_340.jpg"

                },
                new Article
                {
                    Title = "When Your Smart ID Card Reader Comes with Malware",
                    Author = author3,
                    Summary = "A caretaker from Lehi is delighted when she gets the chance to take part in the final of X-Factor. However, her chances are scuppered by an angyy camel. After the drama, the caretaker realises there is more to life than winning X-Factor and goes on a picninc with her great aunt instead.\"",
                    Url = "https://example.com/bone/basin.php?bed=bedroom&boat=amusement#boundary",
                    PublicationDate = new DateTime(2023, 3, 21),
                    ImageUrl = "/images/meadow.jpg"


                },
                new Book
                {
                    Title = "Jailer: A truly relational database tool",
                    Author = author4,
                    Summary = "In a world where robots are wealthy, one golfer has no choice but to assasinate an honorable man by killing his own ex-wife. Eventually, the golfer forms an army and teaches the robots a little respect.",
                    Url = "https://www.example.com/baseball/basin.php?attraction=anger&bead=amusement",
                    PublicationDate = new DateTime(1989, 6, 6),
                    EditionCount = 3,
                    ImageUrl = "/images/clock.jpg"
                }
            };

            // Link publications back to authors
            author1.Publications.Add(publications[0]);
            author2.Publications.Add(publications[1]);
            author3.Publications.Add(publications[2]);
            author4.Publications.Add(publications[3]);

            return publications;
        }
    }
}