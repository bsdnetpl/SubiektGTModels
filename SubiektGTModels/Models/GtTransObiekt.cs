using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GtTransObiekt
{
    public int ToTransformacjaId { get; set; }

    public int ToDefinicjaId { get; set; }

    public int? ToUzytkownikId { get; set; }

    public virtual GtDefinicja ToDefinicja { get; set; } = null!;

    public virtual GtTransformacja ToTransformacja { get; set; } = null!;

    public virtual PdUzytkownik? ToUzytkownik { get; set; }
}
