using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class NewsModel
    {
        public int id { get; set; }
        public string news_content { get; set; }
        public Nullable<int> category_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<System.DateTime> posted_at { get; set; }
    }
}
