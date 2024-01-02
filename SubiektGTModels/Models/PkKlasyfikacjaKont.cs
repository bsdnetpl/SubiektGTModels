using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PkKlasyfikacjaKont
{
    public int PkkId { get; set; }

    public int PkkIdRokuObrotowego { get; set; }

    public int PkkTyp { get; set; }

    public string PkkNr { get; set; } = null!;

    public string PkkNazwa { get; set; } = null!;

    public string? PkkKategoria { get; set; }

    public string? PkkZespol { get; set; }

    public virtual PdRokObrotowy PkkIdRokuObrotowegoNavigation { get; set; } = null!;
}
