//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airline_Reservation.web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cancellation
    {
        public long CancellationId { get; set; }
        public int FlightId { get; set; }
        public int BookingId { get; set; }
        public System.DateTime DateOfCancellation { get; set; }
        public decimal RefundAmount { get; set; }
    
        public virtual Booking Booking { get; set; }
        public virtual Flight Flight { get; set; }
    }
}
