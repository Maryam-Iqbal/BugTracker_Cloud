//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BugTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.CompilerServices;

    public partial class Ticket
    {
        public int TicketID { get; set; }
        public string Title { get; set; }
        [Required(ErrorMessage ="This field is required.")]
        public string Category { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string User { get; set; }
        public string Priority { get; set; }
        public string Assign { get; set; }
        public string Status { get; set; }
    }
}
