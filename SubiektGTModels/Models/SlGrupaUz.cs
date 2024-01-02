using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlGrupaUz
{
    public int UgId { get; set; }

    public string UgNazwa { get; set; } = null!;

    public virtual ICollection<PdUzytkownik> PdUzytkowniks { get; set; } = new List<PdUzytkownik>();
}
