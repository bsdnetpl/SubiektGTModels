using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlZestawAkordowy
{
    public int ZaId { get; set; }

    public string ZaNazwa { get; set; } = null!;

    public virtual ICollection<SlZestawAkordowyAkord> SlZestawAkordowyAkords { get; set; } = new List<SlZestawAkordowyAkord>();
}
