//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project2020
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOOKING
    {
        public int Booking_Number { get; set; }
        public string Client_ID { get; set; }
        public Nullable<int> Court_Number { get; set; }
        public Nullable<int> Event_Number { get; set; }
        public Nullable<int> Number_Of_Bookings_Per_day { get; set; }
    
        public virtual CLIENT CLIENT { get; set; }
        public virtual COURT COURT { get; set; }
        public virtual EVENT EVENT { get; set; }
    }
}
