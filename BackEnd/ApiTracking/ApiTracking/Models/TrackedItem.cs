//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiTracking.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrackedItem
    {
        public int ID { get; set; }
        public int TrackID { get; set; }
        public int ItemID { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public virtual Item Item { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        public virtual Track Track { get; set; }
    }
}
