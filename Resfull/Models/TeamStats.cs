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
    
    public partial class TeamStats
    {
        public int TeamStats_ID { get; set; }
        public Nullable<int> TeamStatsWins { get; set; }
        public Nullable<int> TeamStatsLoss { get; set; }
        public Nullable<double> TeamStatsWinratio { get; set; }
        public Nullable<int> TeamPoints { get; set; }
        public int TeamStatsTeam_ID { get; set; }
    
        public virtual Teams Teams { get; set; }
    }
}
