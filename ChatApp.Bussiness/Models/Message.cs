using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApp.Bussiness.Enums;

namespace ChatApp.Bussiness.Models
{
   public class Message
    {
        public int MessageId { get; set; }

        public string UserName { get; set; }

        public bool Deleted { get; set; }

        public DateTime Date { get; set; }

        public ChatType Type { get; set; }
        public string Content { get; set; }
        public string GifLink { get; set; }

        public string EmoticonLink { get; set; }

        public Chat Chat { get; set; }
        

        
    }
}
