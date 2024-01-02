using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlSlownik
{
    public int SlId { get; set; }

    public string SlNazwa { get; set; } = null!;

    public string SlOpis { get; set; } = null!;

    public int SlProgramy { get; set; }

    public int SlStatusNowosci { get; set; }

    public bool SlUkryte { get; set; }

    public virtual ICollection<KsKlasyfikatory> KsKlasyfikatories { get; set; } = new List<KsKlasyfikatory>();

    public virtual ICollection<PwPole> PwPoles { get; set; } = new List<PwPole>();

    public virtual ICollection<SlWlasny> SlWlasnies { get; set; } = new List<SlWlasny>();

    public virtual ICollection<PdUzytkownik> PfIdUzytkownikas { get; set; } = new List<PdUzytkownik>();
}
