//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_WATCHLIST_ELEMENT
    {
        public string WatchListName { get; set; }
        public string imdbId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Notes { get; set; }
        public int WatchListElementId { get; set; }
    
        public virtual TBL_MOVIE TBL_MOVIE { get; set; }
        public virtual TBL_WATCHLIST TBL_WATCHLIST { get; set; }
    }
}
