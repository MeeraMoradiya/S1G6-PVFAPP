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
    
    public partial class viw_SYSTEM_SCHEMA_BUSINESSRULES
    {
        public int Model_ID { get; set; }
        public System.Guid Model_MUID { get; set; }
        public string Model_Name { get; set; }
        public int Entity_ID { get; set; }
        public System.Guid Entity_MUID { get; set; }
        public string Entity_Name { get; set; }
        public byte MemberType_ID { get; set; }
        public int BusinessRule_ID { get; set; }
        public System.Guid BusinessRule_MUID { get; set; }
        public string BusinessRule_Name { get; set; }
        public string BusinessRule_Description { get; set; }
        public string BusinessRule_RuleConditionText { get; set; }
        public string BusinessRule_RuleActionText { get; set; }
        public string BusinessRule_RuleElseActionText { get; set; }
        public int BusinessRule_StatusID { get; set; }
        public string BusinessRule_StatusName { get; set; }
        public Nullable<int> BusinessRule_Priority { get; set; }
        public Nullable<int> BusinessRule_NotificationGroupID { get; set; }
        public Nullable<System.Guid> BusinessRule_NotificationGroupMUID { get; set; }
        public string BusinessRule_NotificationGroupName { get; set; }
        public Nullable<int> BusinessRule_NotificationUserID { get; set; }
        public Nullable<System.Guid> BusinessRule_NotificationUserMUID { get; set; }
        public string BusinessRule_NotificationUserName { get; set; }
        public byte[] BusinessRule_LastChgTS { get; set; }
        public int BusinessRule_CreatedUserID { get; set; }
        public Nullable<System.Guid> BusinessRule_CreatedUserMUID { get; set; }
        public string BusinessRule_CreatedUserName { get; set; }
        public System.DateTime BusinessRule_DateCreated { get; set; }
        public int BusinessRule_UpdatedUserID { get; set; }
        public Nullable<System.Guid> BusinessRule_UpdatedUserMUID { get; set; }
        public string BusinessRule_UpdatedUserName { get; set; }
        public System.DateTime BusinessRule_DateUpdated { get; set; }
    }
}