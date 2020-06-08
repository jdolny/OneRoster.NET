using System;
using System.Collections.Generic;

namespace OneRoster.NET.SharedDtos
{
    /// <summary>
    /// Demographics information is taken from the Common Educational Data Standards from the US government. (http://ceds.ed.gov). Demographics 
    /// are OPTIONAL.  Note that demographics data is held in its own service, and that access to this service is considered privileged. Not all
    /// consumer keys will be able to request demographics data.  Demographic Data is modeled in LIS, but the sort of demographic data required 
    /// by K12 is very different to that modeled in LIS.For this reason, new structures have been created.
    /// The 'sourcedId' of the demographics MUST be the same as the 'sourcedId' of the user to which it refers.
    /// </summary>
    public class Demographics
    {
        public string SourcedId { get; set; }

        public string Status { get; set; }

        public DateTimeOffset DateLastModified { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public DateTimeOffset BirthDate { get; set; }

        public string Sex { get; set; }

        public string CountryOfBirthCode { get; set; }

        public string StateOfBirthAbbreviation { get; set; }

        public string CityOfBirth { get; set; }

        public string PublicSchoolResidenceStatus { get; set; }

        public bool AmericanIndianOrAlaskaNative { get; set; }

        public bool Asian { get; set; }

        public bool BlackOrAfricanAmerican { get; set; }

        public bool DemographicRaceTwoOrMoreRaces { get; set; }

        public bool HispanicOrLatinoEthnicity { get; set; }

        public bool NativeHawaiianOrOtherPacificIslander { get; set; }

        public bool White { get; set; }


    }

    public class Demographicss
    {
        public List<Demographics> demographics { get; set; }
    }

    public class SingleDemographic
    {
        public Demographics demographics { get; set; }
    }
}