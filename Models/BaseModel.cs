using System;

namespace MyBlog.Models
{
    public abstract class BaseModel
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
