using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZlpZlecenie
{
    public int ZlpzId { get; set; }

    public string ZlpzNumerZlecenia { get; set; } = null!;

    public DateTime? ZlpzDataRejestracjiZlecenia { get; set; }

    public DateTime? ZlpzDataPlanowanegoRozpoczeciaZlecenia { get; set; }

    public DateTime? ZlpzDataPlanowanegoZakonczeniaZlecenia { get; set; }

    public DateTime? ZlpzDataRzeczywistegoRozpoczeciaZlecenia { get; set; }

    public DateTime? ZlpzDataRzeczywistegoZakonczeniaZlecenia { get; set; }

    public DateTime? ZlpzTerminWykonania { get; set; }

    public int ZlpzIdKontrahenta { get; set; }

    public string? ZlpzNazwa { get; set; }

    public string? ZlpzOpis { get; set; }

    public string? ZlpzAnalityka { get; set; }

    public int ZlpzStatusZlecenia { get; set; }

    public int? ZlpzMpk { get; set; }

    public virtual ICollection<KwPozycja> KwPozycjas { get; set; } = new List<KwPozycja>();

    public virtual ICollection<PlbSkladnik> PlbSkladniks { get; set; } = new List<PlbSkladnik>();

    public virtual KhKontrahent ZlpzIdKontrahentaNavigation { get; set; } = null!;

    public virtual StMpk? ZlpzMpkNavigation { get; set; }
}
