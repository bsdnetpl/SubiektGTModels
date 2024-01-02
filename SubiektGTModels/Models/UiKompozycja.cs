using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiKompozycja
{
    public int UiId { get; set; }

    public string UiNazwa { get; set; } = null!;

    public string UiDefinicja { get; set; } = null!;

    public string UiOpis { get; set; } = null!;

    public virtual ICollection<PdUzytkownik> PdUzytkowniks { get; set; } = new List<PdUzytkownik>();
}
