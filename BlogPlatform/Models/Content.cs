using System;

namespace BlogPlatform.Models
{
    public class Content
    {
        public int ContentId { get; set; }
        public int GenreID { get; set; }
        public string Title { get; set; }

        public string Body { get; set; }

        public string Author { get; set; }

        public DateTime PublishDate { get; set; }



        public Content(int contentID, int genreID, string title, string body, string author, DateTime publishDate)
        {

            this.ContentId = contentID;
            this.GenreID = genreID;
            this.Title = title;
            this.Body = body;
            this.Author = author;
            this.PublishDate = publishDate;


        }


    }
}