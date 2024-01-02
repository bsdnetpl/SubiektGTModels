using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GtDefinicja
{
    public int GtdId { get; set; }

    public int GtdObiektId { get; set; }

    public string GtdNazwa { get; set; } = null!;

    public byte[]? GtdDefinicja { get; set; }

    public virtual ICollection<GtObiekt> GtObiekts { get; set; } = new List<GtObiekt>();

    public virtual ICollection<GtTransformacja> GtTransformacjas { get; set; } = new List<GtTransformacja>();

    public virtual GtObiekt GtdObiekt { get; set; } = null!;
}
