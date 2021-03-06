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
    
    public partial class CompanyDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyDetail()
        {
            this.AccountGroups = new HashSet<AccountGroup>();
            this.CompanyDetail1 = new HashSet<CompanyDetail>();
            this.CustomFormats = new HashSet<CustomFormat>();
            this.ProductDetails = new HashSet<ProductDetail>();
            this.StockGroups = new HashSet<StockGroup>();
            this.UOMs = new HashSet<UOM>();
            this.UserTypes = new HashSet<UserType>();
        }
    
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }
        public string TelephoneNo { get; set; }
        public string MobileNo { get; set; }
        public string EMailId { get; set; }
        public string GSTNo { get; set; }
        public byte[] Logo { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> UnderCompanyId { get; set; }
        public string CompanyType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountGroup> AccountGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyDetail> CompanyDetail1 { get; set; }
        public virtual CompanyDetail CompanyDetail2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomFormat> CustomFormats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockGroup> StockGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UOM> UOMs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserType> UserTypes { get; set; }
    }
}
