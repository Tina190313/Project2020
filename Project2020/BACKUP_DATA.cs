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
    
    public partial class BACKUP_DATA
    {
        public string Backup_ID { get; set; }
        public string Assistant_ID { get; set; }
        public Nullable<System.TimeSpan> Backup_Time { get; set; }
        public Nullable<System.DateTime> Backup_Date { get; set; }
    
        public virtual ASSISTANT ASSISTANT { get; set; }
    }
}