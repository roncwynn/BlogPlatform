using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IList<ContentTag> ContentTags { get; set; }

        public Tag()
        {
        }

        public Tag(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
