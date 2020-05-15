using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace chatApplicationWithDb.Models
{
    public class Message
    {
        public Message()
        {
            date = DateTime.Now;  
        }
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Text { get; set; }
        public DateTime date { get; set; }

        public string UserId { get; set; }

        public virtual AppUser Sender { get; set; }

    }
}
