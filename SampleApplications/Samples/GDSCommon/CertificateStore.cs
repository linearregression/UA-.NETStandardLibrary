//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Opc.Ua.Gds
{
    using System;
    using System.Collections.Generic;
    
    public partial class CertificateStore
    {
        public CertificateStore()
        {
            this.HttpsApplications = new HashSet<Application>();
            this.Applications = new HashSet<Application>();
        }
    
        public int ID { get; set; }
        public string Path { get; set; }
        public string AuthorityId { get; set; }
    
        public virtual ICollection<Application> HttpsApplications { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
    }
}
