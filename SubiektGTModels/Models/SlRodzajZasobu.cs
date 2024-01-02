using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlRodzajZasobu
{
    public int ZasId { get; set; }

    public string ZasNazwa { get; set; } = null!;

    public string ZasOpis { get; set; } = null!;

    public bool ZasZablokowany { get; set; }

    public DateTime ZasPoczatek { get; set; }

    public DateTime ZasKoniec { get; set; }

    public int ZasDniTygodnia { get; set; }

    public int ZasSkala { get; set; }

    public bool ZasCalodobowy { get; set; }

    public virtual ICollection<ZsZasob> ZsZasobs { get; set; } = new List<ZsZasob>();

    public virtual ICollection<PdUzytkownik> ZpfIdUzytkownikas { get; set; } = new List<PdUzytkownik>();
}
