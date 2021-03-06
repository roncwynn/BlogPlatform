﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }

        public virtual ICollection<Content> Content { get; set;}

        public Genre()
        {
        }

        public Genre(int id, string name, string description, string imageName)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.ImageName = imageName;
        }
    }
}
