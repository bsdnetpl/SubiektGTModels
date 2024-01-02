using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class JpkPaczka
{
    public int JpkpId { get; set; }

    public string? JpkpNazwa { get; set; }

    public string? JpkpSygnatura { get; set; }

    public int? JpkpIdUrzeduSkarbowego { get; set; }

    public string? JpkpOpis { get; set; }

    public DateTime? JpkpDataDodania { get; set; }

    public DateTime? JpkpDataOd { get; set; }

    public DateTime? JpkpDataDo { get; set; }

    public bool? JpkpZatwierdzona { get; set; }

    public bool? JpkpWyslana { get; set; }

    public virtual ICollection<JpkPlik> JpkPliks { get; set; } = new List<JpkPlik>();

    public virtual ICollection<JpkWysylkaElektroniczna> JpkWysylkaElektronicznas { get; set; } = new List<JpkWysylkaElektroniczna>();

    public virtual SlUrzadSkarbowy? JpkpIdUrzeduSkarbowegoNavigation { get; set; }
}
