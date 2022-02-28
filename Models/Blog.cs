using System;

namespace MyBlog.Models
{
    public class Blog : BaseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
