using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrRoznicaKursowaPozycja
{
    public int DkrkpIdRoznicy { get; set; }

    public int? DkrkpIdPozycji { get; set; }

    public int? DkrkpIdPozycjiBo { get; set; }

    public decimal DkrkpKwota { get; set; }

    public virtual DkrBilansOtwarciaDostawy? DkrkpIdPozycjiBoNavigation { get; set; }

    public virtual DkrPozycja? DkrkpIdPozycjiNavigation { get; set; }

    public virtual DkrRoznicaKursowa DkrkpIdRoznicyNavigation { get; set; } = null!;
}
