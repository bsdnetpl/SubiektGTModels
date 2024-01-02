using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrParametrDziennika
{
    public int DkpdIdRoku { get; set; }

    public int DkpdNumerLp { get; set; }

    public int DkpdNumerPozycji { get; set; }

    public virtual PdRokObrotowy DkpdIdRokuNavigation { get; set; } = null!;
}
