//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resfull.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Leagues
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Leagues()
        {
            this.Tournaments = new HashSet<Tournaments>();
        }
    
        public int League_ID { get; set; }
        public string LeagueName { get; set; }
        public string LeagueReferee { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tournaments> Tournaments { get; set; }
    }
}
