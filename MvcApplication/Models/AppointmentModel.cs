using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models
{
    public class AppointmentModel
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        [Display(Name ="Doctor")]
        public int DoctorId { get; set; }
        [Display(Name = "Appointment Date and Time")] 
        public DateTime AppointmentDateTime { get; set; }
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Display(Name = "Appointment Status")] 
        public string AppointmentStatus { get; set; }
    }
}