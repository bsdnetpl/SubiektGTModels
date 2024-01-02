using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlStawkaAkordowa
{
    public int SaId { get; set; }

    public string SaNazwa { get; set; } = null!;

    public string SaJednostka { get; set; } = null!;

    public int SaTypStawki { get; set; }

    public decimal? SaLiniowaPrzelicznik { get; set; }

    public virtual ICollection<KpAkord> KpAkords { get; set; } = new List<KpAkord>();

    public virtual ICollection<SlZestawAkordowyAkord> SlZestawAkordowyAkords { get; set; } = new List<SlZestawAkordowyAkord>();
}
