using OneRoster.NET.SharedDtos;
using System;
using System.Collections.Generic;
using static OneRoster.NET.v1p1.Vocabulary;

namespace OneRoster.NET.v1p1
{
    /// <summary>
    /// ORG is defined here as a structure for holding organizational information. An ORG might be a school, or it might be a local, statewide, 
    /// or national entity. ORGs will typically have a parent ORG (up to the national level), and children, allowing a hierarchy to be 
    /// established. School is defined here as the place where the learning happens.Most commonly this is the data that describes a bricks and 
    /// mortar building, or, in the case of a virtual school, the virtual school organization. For enrollment and result reporting purposes, 
    /// little information about this organization is required.Later versions of the specification could add further information, such as an 
    /// address, for example.A common example of a local organization is a school district.Note that although School is a type of org, the 
    /// default entry point for requests in most places will be a school. The API provides many school based entry points, whilst still 
    /// allowing for more generic reading of ORGs, for those applications that need to.
    /// </summary>
    public class Org
    {
        public string SourcedId { get; set; }

        public string Status { get; set; }

        public DateTimeOffset DateLastModified { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Name { get; set; }

        public string Identifier { get; set; }

        public List<GuidRef> Children { get; set; }

        public GuidRef Parent { get; set; }

        public OrgType Type { get; set; }


    }

    public class Orgs
    {
        public List<Org> orgs { get; set; }
    }

    public class SingleOrg
    {
        public Org org { get; set; }
    }

    
}