//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_SQLBuilder
{
    using System;
    using System.Collections.Generic;
    
    public partial class insert_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public insert_table()
        {
            this.custom_field = new HashSet<custom_field>();
            this.select_field = new HashSet<select_field>();
        }
    
        public int id { get; set; }
        public int fk_project { get; set; }
        public string table { get; set; }
        public int order { get; set; }
        public string insert_comand { get; set; }
        public string from_comand { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<custom_field> custom_field { get; set; }
        public virtual project project { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<select_field> select_field { get; set; }
    }
}
