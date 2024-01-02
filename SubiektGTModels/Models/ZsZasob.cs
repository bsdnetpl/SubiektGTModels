using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZsZasob
{
    public int ZsId { get; set; }

    public string ZsSymbol { get; set; } = null!;

    public string ZsNazwa { get; set; } = null!;

    public int ZsIdRodzaj { get; set; }

    public bool ZsZablokowany { get; set; }

    public string ZsNrInwRej { get; set; } = null!;

    public int? ZsIdPersonel { get; set; }

    public string ZsOpis { get; set; } = null!;

    public string ZsKolor { get; set; } = null!;

    public string? ZsCharakterystyka { get; set; }

    public virtual ICollection<ZsCechaZ> ZsCechaZs { get; set; } = new List<ZsCechaZ>();

    public virtual PdUzytkownik? ZsIdPersonelNavigation { get; set; }

    public virtual SlRodzajZasobu ZsIdRodzajNavigation { get; set; } = null!;

    public virtual ICollection<ZsRezerwacja> ZsRezerwacjas { get; set; } = new List<ZsRezerwacja>();

    public virtual ICollection<ZsZdjecieZ> ZsZdjecieZs { get; set; } = new List<ZsZdjecieZ>();
}
