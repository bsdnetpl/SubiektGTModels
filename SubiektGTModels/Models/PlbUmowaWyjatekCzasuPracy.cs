using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowaWyjatekCzasuPracy
{
    public int UwcpId { get; set; }

    public int UwcpIdUmowy { get; set; }

    public int? UwcpIdAtrybut { get; set; }

    public DateTime UwcpData { get; set; }

    public string UwcpNazwa { get; set; } = null!;

    public int UwcpRodzaj { get; set; }

    public int? UwcpIleDzienne { get; set; }

    public int? UwcpIleNocne { get; set; }

    public bool UwcpUstawowy { get; set; }

    public int? UwcpGodzinyPracyOd { get; set; }

    public int? UwcpTypDniaWolnego { get; set; }

    public int UwcpTypPracy { get; set; }

    public virtual PlbUmowa UwcpIdUmowyNavigation { get; set; } = null!;

    public virtual SlTypDniaWolnego? UwcpTypDniaWolnegoNavigation { get; set; }
}
