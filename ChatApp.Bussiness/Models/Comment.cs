using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Bussiness.Models
{
   public class Comment
    {
        public int CommentId { get; set; }

        public string UserName { get; set; }

        public DateTime Date { get; set; }
        public string Content { get; set; }

        public Chat Chat { get; set; }
        

        
    }
}
