//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NUBEAccounts.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseReturn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseReturn()
        {
            this.PurchaseReturnDetails = new HashSet<PurchaseReturnDetail>();
        }
    
        public long Id { get; set; }
        public System.DateTime PRDate { get; set; }
        public string RefNo { get; set; }
        public string RefCode { get; set; }
        public int LedgerId { get; set; }
        public int TransactionTypeId { get; set; }
        public decimal ItemAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal GSTAmount { get; set; }
        public decimal ExtraAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string Narration { get; set; }
    
        public virtual Ledger Ledger { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }
    }
}
