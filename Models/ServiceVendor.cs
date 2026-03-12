using System;

namespace DesignTattva.Models
{
    public class ServiceVendor
    {
        public int VendorID { get; set; }
        public string VendorName { get; set; }
        public string ServiceType { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string PaymentTerms { get; set; }
        public decimal Rate { get; set; }
    }
}