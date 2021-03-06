﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BlogPlatform.Models
{
    public class Content
    {
        public int ContentId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }

        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        public virtual IList<ContentTag> ContentTags { get; set; }

        public Content()
        {
        }

        public Content(int contentID, int genreID, string title, string body, string author, DateTime publishDate)
        {
            this.ContentId = contentID;
            this.GenreId = genreID;
            this.Title = title;
            this.Body = body;
            this.Author = author;
            this.PublishDate = publishDate;
        }
    }
}