using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwKreatorPkwiU2015RegulyStawekVat
{
    public string Pkwiu2015toVatKod { get; set; } = null!;

    public int Pkwiu2015toVatTyp { get; set; }

    public int Pkwiu2015toVatIdVat { get; set; }

    public virtual SlStawkaVat Pkwiu2015toVatIdVatNavigation { get; set; } = null!;
}
