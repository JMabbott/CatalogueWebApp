//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Catalogue.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Catalogue
    {
        public Catalogue()
        {
            this.CatalogueItems = new HashSet<CatalogueItem>();
        }
    
        public int CataID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<CatalogueItem> CatalogueItems { get; set; }
    }
}
