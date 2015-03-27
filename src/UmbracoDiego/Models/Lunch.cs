using System;
using System.ComponentModel.DataAnnotations;

namespace UmbracoDiego.Models
{
    public class Lunch
    {
        public int UmbracoID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LunchChoice { get; set; }
    }
}