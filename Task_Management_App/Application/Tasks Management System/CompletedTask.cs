//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tasks_Management_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompletedTask
    {
        public int TaskID { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public string TaskStatus { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
    }
}
