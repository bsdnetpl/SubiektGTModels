using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ApZapisy
{
    public int ZaId { get; set; }

    public int ZaIdAp { get; set; }

    public int ZaLp { get; set; }

    public bool ZaPoczatekGrupy { get; set; }

    public int ZaTypDefinicjZd { get; set; }

    public string? ZaDefZrodlaDanych { get; set; }

    public string? ZaDefWartosc { get; set; }

    public string? ZaDefNrKontaWynikowego { get; set; }

    public int ZaTypOpisuDekretu { get; set; }

    public string ZaUOpisDekretu { get; set; } = null!;

    public int? ZaSlIdOpisuDekretu { get; set; }

    public virtual ApAp ZaIdApNavigation { get; set; } = null!;

    public virtual SlOpi? ZaSlIdOpisuDekretuNavigation { get; set; }
}
