//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S1G6_PVFAPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFile()
        {
            this.tblFile1 = new HashSet<tblFile>();
        }
    
        public int ID { get; set; }
        public System.Guid MUID { get; set; }
        public Nullable<int> Source_ID { get; set; }
        public byte[] Source_LastChgTS { get; set; }
        public string FileName { get; set; }
        public string FileContentType { get; set; }
        public byte[] FileContent { get; set; }
        public System.DateTime EnterDTM { get; set; }
        public int EnterUserID { get; set; }
        public System.DateTime LastChgDTM { get; set; }
        public int LastChgUserID { get; set; }
        public byte[] LastChgTS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFile> tblFile1 { get; set; }
        public virtual tblFile tblFile2 { get; set; }
    }
}