using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowaCpgodzPrzepr
{
    public int UpgpId { get; set; }

    public int UpgpIdUmowy { get; set; }

    public DateTime UpgpDataWpisu { get; set; }

    public DateTime UpgpMiesiac { get; set; }

    public int UpgpLiczbaGodzin { get; set; }

    public string UpgpOpis { get; set; } = null!;

    public virtual PlbUmowaCp UpgpIdUmowyNavigation { get; set; } = null!;
}
