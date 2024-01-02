using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GtObiekt
{
    public int GtoId { get; set; }

    public string GtoNazwa { get; set; } = null!;

    public int? GtoPodstDefId { get; set; }

    public int? GtoPodstTransId { get; set; }

    public virtual ICollection<GtDefinicja> GtDefinicjas { get; set; } = new List<GtDefinicja>();

    public virtual ICollection<GtTransformacja> GtTransformacjas { get; set; } = new List<GtTransformacja>();

    public virtual GtDefinicja? GtoPodstDef { get; set; }

    public virtual GtTransformacja? GtoPodstTrans { get; set; }

    public virtual ICollection<KsKlasyfikatory> KsKlasyfikatories { get; set; } = new List<KsKlasyfikatory>();

    public virtual ICollection<KsPrzypisaniaWlasne> KsPrzypisaniaWlasnes { get; set; } = new List<KsPrzypisaniaWlasne>();
}
