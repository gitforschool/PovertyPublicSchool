//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EducationOutcomes
{
    using System;
    using System.Collections.Generic;
    
    public partial class GraduationRate
    {
        public int GraduationId { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public Nullable<int> SchoolId { get; set; }
        public Nullable<int> SocioeconomicStatusId { get; set; }
        public Nullable<decimal> GraduationRate1 { get; set; }
    
        public virtual District District { get; set; }
        public virtual School School { get; set; }
        public virtual SocioeconomicStatu SocioeconomicStatu { get; set; }
    }
}
