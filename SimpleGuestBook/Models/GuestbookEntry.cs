using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleGuestBook.Models
{
    public class GuestbookEntry
    {
        //[Key]
        public int Id { get; set; }
        //[Required(ErrorMessage = "You must enter your Name first")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "You must enter Message")]
        public string Message { get; set; }
        public DateTime DateAdded { get; set; }
    }
}