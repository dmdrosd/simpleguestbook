using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleGuestBook.Models
{
    public class GuestbookEntry
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(20), Required(ErrorMessage = "¬ведите им€")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(1000), Required(ErrorMessage = "¬ведите сообщение")]
        public string Message { get; set; }
        public DateTime DateAdded { get; set; }
    }
}