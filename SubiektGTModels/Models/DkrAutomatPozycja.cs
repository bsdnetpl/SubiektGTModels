using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrAutomatPozycja
{
    public int AppId { get; set; }

    public int AppIdAutomatu { get; set; }

    public int AppTyp { get; set; }

    public string AppKontoZ { get; set; } = null!;

    public int AppKwotaZ { get; set; }

    public string AppKontoWn { get; set; } = null!;

    public string AppKontoMa { get; set; } = null!;

    public decimal AppUdzial { get; set; }

    public string AppOpis { get; set; } = null!;

    public int? AppIdAutomatuPoz { get; set; }

    public bool AppWszystkieAnalityki { get; set; }

    public bool AppPobierajKontoZwn { get; set; }

    public bool AppPobierajKontoZma { get; set; }

    public virtual DkrAutomat AppIdAutomatuNavigation { get; set; } = null!;
}
