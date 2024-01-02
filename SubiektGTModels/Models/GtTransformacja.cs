using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GtTransformacja
{
    public int GttId { get; set; }

    public int GttObiektId { get; set; }

    public string GttNazwa { get; set; } = null!;

    public int GttRodzajId { get; set; }

    public byte[]? GttTransformacja { get; set; }

    public string? GttSchemat { get; set; }

    public int? GttDefinicjaId { get; set; }

    public bool GttDomyslna { get; set; }

    public int GttStatusNowosci { get; set; }

    public virtual ICollection<GtObiekt> GtObiekts { get; set; } = new List<GtObiekt>();

    public virtual GtDefinicja? GttDefinicja { get; set; }

    public virtual GtObiekt GttObiekt { get; set; } = null!;

    public virtual ICollection<PdUzytkownik> PfIdUzytkownikas { get; set; } = new List<PdUzytkownik>();
}
