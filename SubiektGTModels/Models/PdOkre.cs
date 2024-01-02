using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdOkre
{
    public int OkrId { get; set; }

    public string OkrNazwa { get; set; } = null!;

    public int OkrTypOkresu { get; set; }

    public DateTime OkrDataOd { get; set; }

    public DateTime OkrDataDo { get; set; }

    public bool OkrAktywny { get; set; }

    public virtual ICollection<KprKsiega> KprKsiegas { get; set; } = new List<KprKsiega>();

    public virtual ICollection<PdUzytkOkre> PdUzytkOkres { get; set; } = new List<PdUzytkOkre>();

    public virtual ICollection<PrzPrzychod> PrzPrzychods { get; set; } = new List<PrzPrzychod>();
}
