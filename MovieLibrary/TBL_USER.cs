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
    
    public partial class TBL_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_USER()
        {
            this.TBL_FAVOURITE = new HashSet<TBL_FAVOURITE>();
            this.TBL_WATCHLIST = new HashSet<TBL_WATCHLIST>();
        }
    
        public short userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_FAVOURITE> TBL_FAVOURITE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_WATCHLIST> TBL_WATCHLIST { get; set; }
    }
}
