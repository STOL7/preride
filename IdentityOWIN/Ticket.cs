//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdentityOWIN
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int Id { get; set; }
        public string User_Id { get; set; }
        public int Bus_Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Bus Bus { get; set; }
    }
}
