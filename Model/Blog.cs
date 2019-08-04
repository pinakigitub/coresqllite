using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreWithSqlLite.Model
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
