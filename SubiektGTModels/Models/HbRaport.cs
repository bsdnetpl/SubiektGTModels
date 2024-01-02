using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbRaport
{
    public int HbrId { get; set; }

    public int HbrTypOperacji { get; set; }

    public int? HbrIdTransakcji { get; set; }

    public string? HbrOpis { get; set; }

    public int HbrStatus { get; set; }

    public int? HbrIdUzytkownik { get; set; }

    public DateTime? HbrData { get; set; }

    public string? HbrOpisBledu { get; set; }

    public int? HbrBank { get; set; }

    public virtual HbTransakcjaOczekujaca? HbrIdTransakcjiNavigation { get; set; }

    public virtual PdUzytkownik? HbrIdUzytkownikNavigation { get; set; }
}
