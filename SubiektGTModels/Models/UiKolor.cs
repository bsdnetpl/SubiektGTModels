using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiKolor
{
    public int UicId { get; set; }

    public string UicNazwa { get; set; } = null!;

    public string UicSerwisTloGora { get; set; } = null!;

    public string UicSerwisTloDol { get; set; } = null!;

    public string UicSerwisTekst { get; set; } = null!;

    public virtual ICollection<UiModul> UiModuls { get; set; } = new List<UiModul>();
}
