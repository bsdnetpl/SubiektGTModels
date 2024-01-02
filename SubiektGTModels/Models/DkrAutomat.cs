using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrAutomat
{
    public int ApId { get; set; }

    public int ApIdRoku { get; set; }

    public string ApNazwa { get; set; } = null!;

    public int? ApIdKategorii { get; set; }

    public string ApUwagi { get; set; } = null!;

    public DateTime? ApData { get; set; }

    public DateTime? ApOkresDo { get; set; }

    public int ApZakres { get; set; }

    public int? ApIdRejestru { get; set; }

    public virtual SlKategorium? ApIdKategoriiNavigation { get; set; }

    public virtual SlRejestrKsiegowy? ApIdRejestruNavigation { get; set; }

    public virtual PdRokObrotowy ApIdRokuNavigation { get; set; } = null!;

    public virtual ICollection<DkrAutomatPozycja> DkrAutomatPozycjas { get; set; } = new List<DkrAutomatPozycja>();
}
