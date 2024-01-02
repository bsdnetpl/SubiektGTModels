using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImSchematImportuAnalitykiKp
{
    public int AkpId { get; set; }

    public int AkpIdPozycjiSi { get; set; }

    public int AkpPoziom { get; set; }

    public int AkpMetodaWyznaczania { get; set; }

    public int? AkpTypObiektuZdokImp { get; set; }

    public string AkpWartoscAnalityki { get; set; } = null!;

    public int AkpTypKartotekiPowiazanej { get; set; }

    public virtual PkKartoteka AkpTypKartotekiPowiazanejNavigation { get; set; } = null!;
}
