using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models
{
    public class FeedbackModel
    {
        [Display(Name ="Please provide us suggestions.")]
        public string Message { get; set; }
        public int Rating { get; set; }
        public int UserID { get; set; }
    }
}