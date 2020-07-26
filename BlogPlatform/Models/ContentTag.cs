using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class ContentTag
    {
        public int ContentId { get; set; }
        public virtual Content Content { get; set; }

        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
        
        public ContentTag()
        { }

        public ContentTag(int contentId, int tagId)
        {
            this.ContentId = contentId;
            this.TagId = tagId;
        }
    }
}
