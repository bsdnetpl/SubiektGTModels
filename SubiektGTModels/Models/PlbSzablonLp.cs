using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbSzablonLp
{
    public int SlpId { get; set; }

    public string SlpNazwa { get; set; } = null!;

    public string SlpOpis { get; set; } = null!;

    public int? SlpIdSzablonuNazwyLp { get; set; }

    public int? SlpIdSzablonuNumeruLp { get; set; }

    public string SlpTekst { get; set; } = null!;

    public string SlpFormatNazwy { get; set; } = null!;

    public string SlpFormatNumeru { get; set; } = null!;

    public int? SlpIdKategorii { get; set; }

    public int SlpDataWyplaty { get; set; }

    public int SlpDataPrzekazaniaZaliczek { get; set; }

    public int SlpDataPrzekazaniaSkladek { get; set; }

    public virtual ICollection<PlbUmowaZestaw> PlbUmowaZestaws { get; set; } = new List<PlbUmowaZestaw>();

    public virtual SlFormatNumeracji? SlpIdSzablonuNazwyLpNavigation { get; set; }

    public virtual SlFormatNumeracji? SlpIdSzablonuNumeruLpNavigation { get; set; }
}
