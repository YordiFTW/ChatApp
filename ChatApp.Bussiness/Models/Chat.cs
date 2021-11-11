using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Bussiness.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public bool Hidden { get; set; }

        public int UserCount { get; set; }

        //public List<Comment> Comments2 {get; set;}

        public ICollection<Comment> Comments { get; set; }
    }
}
