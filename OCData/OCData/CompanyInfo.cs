using System;

namespace OCData
{
    public class CompanyInfo
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string JurisdictionCode { get; set; }
        public string IncorporationDate { get; set; }
        public string DissolutionDate { get; set; }
        public string CompanyType { get; set; }
        public string RegistryUrl { get; set; }
        public string Branch { get; set; }

        public string BranchStatus { get; set; }
        public string Inactive { get; set; }
        public string CurrentStatus { get; set; }
        public string CreatedAt { get; set; }
        public string RetrievedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string OpenCorporatesUrl { get; set; }
        public string PreviousNames { get; set; }
        public string DataSource { get; set; }
        public string DataSourceUrl { get; set; }
        public string RetrievedFromSourceAt { get; set; }
        public string RegisteredAddress { get; set; }         
        public string StreetAddress { get; set; }
        public string Locality { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string RegisteredAddressFull { get; set; }
        public string IndustryCodes { get; set; }
        public string RestrictedForMarketing { get; set; }
        public string NativeCompanyNumber { get; set; }
    }
}
