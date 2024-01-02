using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwCenaHistorium
{
    public int TchId { get; set; }

    public int TchIdTowar { get; set; }

    public decimal? TchCenaNetto0 { get; set; }

    public decimal? TchCenaBrutto0 { get; set; }

    public string? TchWalutaId { get; set; }

    public int? TchIdWalutaKurs { get; set; }

    public decimal? TchWalutaKurs { get; set; }

    public decimal? TchCenaNettoWaluta { get; set; }

    public decimal? TchCenaNettoWaluta2 { get; set; }

    public decimal? TchCenaWalutaNarzut { get; set; }

    public string TchWalutaJedn { get; set; } = null!;

    public int? TchPodstawaKc { get; set; }

    public decimal? TchCenaNetto1 { get; set; }

    public decimal? TchCenaNetto2 { get; set; }

    public decimal? TchCenaNetto3 { get; set; }

    public decimal? TchCenaNetto4 { get; set; }

    public decimal? TchCenaNetto5 { get; set; }

    public decimal? TchCenaNetto6 { get; set; }

    public decimal? TchCenaNetto7 { get; set; }

    public decimal? TchCenaNetto8 { get; set; }

    public decimal? TchCenaNetto9 { get; set; }

    public decimal? TchCenaNetto10 { get; set; }

    public decimal? TchCenaBrutto1 { get; set; }

    public decimal? TchCenaBrutto2 { get; set; }

    public decimal? TchCenaBrutto3 { get; set; }

    public decimal? TchCenaBrutto4 { get; set; }

    public decimal? TchCenaBrutto5 { get; set; }

    public decimal? TchCenaBrutto6 { get; set; }

    public decimal? TchCenaBrutto7 { get; set; }

    public decimal? TchCenaBrutto8 { get; set; }

    public decimal? TchCenaBrutto9 { get; set; }

    public decimal? TchCenaBrutto10 { get; set; }

    public decimal? TchZysk1 { get; set; }

    public decimal? TchZysk2 { get; set; }

    public decimal? TchZysk3 { get; set; }

    public decimal? TchZysk4 { get; set; }

    public decimal? TchZysk5 { get; set; }

    public decimal? TchZysk6 { get; set; }

    public decimal? TchZysk7 { get; set; }

    public decimal? TchZysk8 { get; set; }

    public decimal? TchZysk9 { get; set; }

    public decimal? TchZysk10 { get; set; }

    public decimal? TchNarzut1 { get; set; }

    public decimal? TchNarzut2 { get; set; }

    public decimal? TchNarzut3 { get; set; }

    public decimal? TchNarzut4 { get; set; }

    public decimal? TchNarzut5 { get; set; }

    public decimal? TchNarzut6 { get; set; }

    public decimal? TchNarzut7 { get; set; }

    public decimal? TchNarzut8 { get; set; }

    public decimal? TchNarzut9 { get; set; }

    public decimal? TchNarzut10 { get; set; }

    public decimal? TchMarza1 { get; set; }

    public decimal? TchMarza2 { get; set; }

    public decimal? TchMarza3 { get; set; }

    public decimal? TchMarza4 { get; set; }

    public decimal? TchMarza5 { get; set; }

    public decimal? TchMarza6 { get; set; }

    public decimal? TchMarza7 { get; set; }

    public decimal? TchMarza8 { get; set; }

    public decimal? TchMarza9 { get; set; }

    public decimal? TchMarza10 { get; set; }

    public string TchIdWaluta0 { get; set; } = null!;

    public string TchIdWaluta1 { get; set; } = null!;

    public string TchIdWaluta2 { get; set; } = null!;

    public string TchIdWaluta3 { get; set; } = null!;

    public string TchIdWaluta4 { get; set; } = null!;

    public string TchIdWaluta5 { get; set; } = null!;

    public string TchIdWaluta6 { get; set; } = null!;

    public string TchIdWaluta7 { get; set; } = null!;

    public string TchIdWaluta8 { get; set; } = null!;

    public string TchIdWaluta9 { get; set; } = null!;

    public string TchIdWaluta10 { get; set; } = null!;

    public int? TchKursWaluty1 { get; set; }

    public int? TchKursWaluty2 { get; set; }

    public int? TchKursWaluty3 { get; set; }

    public int? TchKursWaluty4 { get; set; }

    public int? TchKursWaluty5 { get; set; }

    public int? TchKursWaluty6 { get; set; }

    public int? TchKursWaluty7 { get; set; }

    public int? TchKursWaluty8 { get; set; }

    public int? TchKursWaluty9 { get; set; }

    public int? TchKursWaluty10 { get; set; }

    public DateTime? TchDataKursuWaluty { get; set; }

    public int? TchBankKursuWaluty { get; set; }

    public DateTime TchDataObowiazywaniaDo { get; set; }

    public int? TchIdPromocji { get; set; }

    public bool? TchEtapPromocji { get; set; }

    public virtual TwTowar TchIdTowarNavigation { get; set; } = null!;
}
