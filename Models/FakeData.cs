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
            var author5 = new Author { Name = "Shyam Benson" };
            var author6 = new Author { Name = "Lucas Asim" };
            var author7 = new Author { Name = "Harmon Deeann" };
            var author8 = new Author { Name = "Gargi Sudheer" };

            var publications = new List<Publication>
            {
                new Article
                {
                    Title = "Improving the foundation of our falling sand simulator",
                    Author = author1,
                    Summary = "Addison is a detective from Sale who falls in love with his best friend. The two are separated when the best friend falls for somebody else. However, Addison manages to rescue the situation by buying a magnificent t-shirt.,",
                    Url = "https://bait.example.net/bag.aspx",
                    PublicationDate = new DateTime(2018, 07, 24),
                    ImageUrl = "https://cdn.pixabay.com/photo/2018/03/02/20/22/sktop-3194194__340.jpg"
                },
                new Book
                {
                    Title = "NASA fed some Apollo 11 lunar samples to cockroaches and mice",
                    Author = author2,
                    Summary = "A farmer from Markham is delighted when she gets the chance to take part in the final of X-Factor. However, her chances are scuppered when her son goes missing. Unexpectedly, the farmer is bitten by a zombie and therefore is disqualified from competing.",
                    Url = "https://www.example.com/bite.aspx",
                    PublicationDate = new DateTime(2006, 5, 15),
                    EditionCount = 2,
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/08/18/08/31/lemur-1602313__340.jpg"

                },
                new Article
                {
                    Title = "When Your Smart ID Card Reader Comes with Malware",
                    Author = author3,
                    Summary = "A caretaker from Lehi is delighted when she gets the chance to take part in the final of X-Factor. However, her chances are scuppered by an angyy camel. After the drama, the caretaker realises there is more to life than winning X-Factor and goes on a picninc with her great aunt instead.\"",
                    Url = "https://example.com/bone/basin.php?bed=bedroom&boat=amusement#boundary",
                    PublicationDate = new DateTime(2023, 3, 21),
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/06/14/11/34/meadow-2401931__340.jpg"


                },
                new Book
                {
                    Title = "Jailer: A truly relational database tool",
                    Author = author4,
                    Summary = "In a world where robots are wealthy, one golfer has no choice but to assasinate an honorable man by killing his own ex-wife. Eventually, the golfer forms an army and teaches the robots a little respect.",
                    Url = "https://www.example.com/baseball/basin.php?attraction=anger&bead=amusement",
                    PublicationDate = new DateTime(1989, 6, 6),
                    EditionCount = 3,
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/08/20/05/44/clock-1606919__340.jpg"
                },

                new Article
                {
                    Title = "Everything you ever wanted to know about terminal",
                    Author = author5,
                    Summary = "In a world where robots are miraculously transformed into angels, one pop star has no choice but to bring down the goverment by killing her own step-sister. It turns out all the robots were a manifestations of the pop star's multiple personality disorder and her real fight is one to regain sanity.",
                    Url = "https://www.example.com/bait/bath.php",
                    PublicationDate = new DateTime(2020, 1, 23),
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/09/01/10/33/witchs-house-1635770_960_720.jpg",
                },

                new Article
                {
                    Title = "NaturalSpeech: End-to-end text to speech synthesis with human-level quality",
                    Author = author6,
                    Summary = "When a movie star from West Des Moines learns to sing, not everybody is supportive. However, her fortunes improve when her step-sister buys a deralict castle. Eventually, the movie star realises that she has always been a worthwhile person and does not need to change.",
                    Url = "http://www.example.com/bear",
                    PublicationDate = new DateTime(2022, 10, 28),
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/04/25/07/15/man-1351317__340.png",
                },

                new Article
                {
                    Title = "Husky, Datadog's Third-Generation Event Store",
                    Author = author7,
                    Summary = "A WW2 veteran Brisbane who recieves an invitation to a modern battle. It turns out the invitations is spam and is from a scammer who is famous for making up stories.",
                    Url = "https://www.example.com/bells",
                    PublicationDate = new DateTime(2022, 3, 4),
                    ImageUrl = "https://cdn.pixabay.com/photo/2020/03/13/08/19/ornaments-4927258__340.jpg",
                },

                new Book
                {
                    Title = "Singers and Vampires",
                    Author = new Author { Name = "Gargi Sudheer" },
                    Summary = "In a world where vampires run large corporations, one singer has no choice but to protect mankind using a magic ring. It turns out the vampires are all sheep.",
                    Url = "https://example.com/baseball/adjustment.aspx?airplane=border&advertisement=argument",
                    PublicationDate = new DateTime(1972, 4, 24),
                    EditionCount = 3,
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/08/07/18/22/back-to-school-1576791__340.jpg"
                }
            };

            author1.Publications.Add(publications[0]);
            author2.Publications.Add(publications[1]);
            author3.Publications.Add(publications[2]);
            author4.Publications.Add(publications[3]);
            author5.Publications.Add(publications[4]);
            author6.Publications.Add(publications[5]);
            author7.Publications.Add(publications[6]);
            author8.Publications.Add(publications[7]);

            return publications;
        }
    }
}