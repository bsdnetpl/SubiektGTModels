using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SfRz
{
    public int SfrId { get; set; }

    public int? SfrIdRoku { get; set; }

    public DateTime? SfrData { get; set; }

    public bool? SfrTylkoZaksiegowane { get; set; }

    public int? SfrJezyk { get; set; }

    public int? SfrIdSprawozdania { get; set; }

    public int? SfrIdRokuZrodlowego { get; set; }

    public virtual ICollection<SfPozycjaRz> SfPozycjaRzs { get; set; } = new List<SfPozycjaRz>();

    public virtual PdRokObrotowy? SfrIdRokuNavigation { get; set; }

    public virtual SfSprawozdanie? SfrIdSprawozdaniaNavigation { get; set; }
}
