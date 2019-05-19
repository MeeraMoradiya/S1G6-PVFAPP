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
    
    public partial class tblModelVersion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblModelVersion()
        {
            this.tblEvents = new HashSet<tblEvent>();
            this.tblNotificationQueues = new HashSet<tblNotificationQueue>();
            this.tblSecurityRoleAccessMembers = new HashSet<tblSecurityRoleAccessMember>();
            this.tblSubscriptionViews = new HashSet<tblSubscriptionView>();
            this.tblSyncRelationships = new HashSet<tblSyncRelationship>();
            this.tblSyncRelationships1 = new HashSet<tblSyncRelationship>();
        }
    
        public int ID { get; set; }
        public System.Guid MUID { get; set; }
        public int Model_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Status_ID { get; set; }
        public int Display_ID { get; set; }
        public Nullable<int> VersionFlag_ID { get; set; }
        public Nullable<int> AsOfVersion_ID { get; set; }
        public System.DateTime EnterDTM { get; set; }
        public int EnterUserID { get; set; }
        public System.DateTime LastChgDTM { get; set; }
        public int LastChgUserID { get; set; }
        public byte[] LastChgTS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEvent> tblEvents { get; set; }
        public virtual tblModel tblModel { get; set; }
        public virtual tblModelVersionFlag tblModelVersionFlag { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNotificationQueue> tblNotificationQueues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSecurityRoleAccessMember> tblSecurityRoleAccessMembers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSubscriptionView> tblSubscriptionViews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSyncRelationship> tblSyncRelationships { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSyncRelationship> tblSyncRelationships1 { get; set; }
    }
}
