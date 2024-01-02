using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwCena
{
    public int TcId { get; set; }

    public int TcIdTowar { get; set; }

    public decimal? TcCenaNetto0 { get; set; }

    public decimal? TcCenaBrutto0 { get; set; }

    public string? TcWalutaId { get; set; }

    public int? TcIdWalutaKurs { get; set; }

    public decimal? TcWalutaKurs { get; set; }

    public decimal? TcCenaNettoWaluta { get; set; }

    public decimal? TcCenaNettoWaluta2 { get; set; }

    public decimal? TcCenaWalutaNarzut { get; set; }

    public string TcWalutaJedn { get; set; } = null!;

    public int? TcPodstawaKc { get; set; }

    public decimal? TcCenaNetto1 { get; set; }

    public decimal? TcCenaNetto2 { get; set; }

    public decimal? TcCenaNetto3 { get; set; }

    public decimal? TcCenaNetto4 { get; set; }

    public decimal? TcCenaNetto5 { get; set; }

    public decimal? TcCenaNetto6 { get; set; }

    public decimal? TcCenaNetto7 { get; set; }

    public decimal? TcCenaNetto8 { get; set; }

    public decimal? TcCenaNetto9 { get; set; }

    public decimal? TcCenaNetto10 { get; set; }

    public decimal? TcCenaBrutto1 { get; set; }

    public decimal? TcCenaBrutto2 { get; set; }

    public decimal? TcCenaBrutto3 { get; set; }

    public decimal? TcCenaBrutto4 { get; set; }

    public decimal? TcCenaBrutto5 { get; set; }

    public decimal? TcCenaBrutto6 { get; set; }

    public decimal? TcCenaBrutto7 { get; set; }

    public decimal? TcCenaBrutto8 { get; set; }

    public decimal? TcCenaBrutto9 { get; set; }

    public decimal? TcCenaBrutto10 { get; set; }

    public decimal? TcZysk1 { get; set; }

    public decimal? TcZysk2 { get; set; }

    public decimal? TcZysk3 { get; set; }

    public decimal? TcZysk4 { get; set; }

    public decimal? TcZysk5 { get; set; }

    public decimal? TcZysk6 { get; set; }

    public decimal? TcZysk7 { get; set; }

    public decimal? TcZysk8 { get; set; }

    public decimal? TcZysk9 { get; set; }

    public decimal? TcZysk10 { get; set; }

    public decimal? TcNarzut1 { get; set; }

    public decimal? TcNarzut2 { get; set; }

    public decimal? TcNarzut3 { get; set; }

    public decimal? TcNarzut4 { get; set; }

    public decimal? TcNarzut5 { get; set; }

    public decimal? TcNarzut6 { get; set; }

    public decimal? TcNarzut7 { get; set; }

    public decimal? TcNarzut8 { get; set; }

    public decimal? TcNarzut9 { get; set; }

    public decimal? TcNarzut10 { get; set; }

    public decimal? TcMarza1 { get; set; }

    public decimal? TcMarza2 { get; set; }

    public decimal? TcMarza3 { get; set; }

    public decimal? TcMarza4 { get; set; }

    public decimal? TcMarza5 { get; set; }

    public decimal? TcMarza6 { get; set; }

    public decimal? TcMarza7 { get; set; }

    public decimal? TcMarza8 { get; set; }

    public decimal? TcMarza9 { get; set; }

    public decimal? TcMarza10 { get; set; }

    public string TcIdWaluta0 { get; set; } = null!;

    public string TcIdWaluta1 { get; set; } = null!;

    public string TcIdWaluta2 { get; set; } = null!;

    public string TcIdWaluta3 { get; set; } = null!;

    public string TcIdWaluta4 { get; set; } = null!;

    public string TcIdWaluta5 { get; set; } = null!;

    public string TcIdWaluta6 { get; set; } = null!;

    public string TcIdWaluta7 { get; set; } = null!;

    public string TcIdWaluta8 { get; set; } = null!;

    public string TcIdWaluta9 { get; set; } = null!;

    public string TcIdWaluta10 { get; set; } = null!;

    public int? TcKursWaluty1 { get; set; }

    public int? TcKursWaluty2 { get; set; }

    public int? TcKursWaluty3 { get; set; }

    public int? TcKursWaluty4 { get; set; }

    public int? TcKursWaluty5 { get; set; }

    public int? TcKursWaluty6 { get; set; }

    public int? TcKursWaluty7 { get; set; }

    public int? TcKursWaluty8 { get; set; }

    public int? TcKursWaluty9 { get; set; }

    public int? TcKursWaluty10 { get; set; }

    public DateTime? TcDataKursuWaluty { get; set; }

    public int? TcBankKursuWaluty { get; set; }

    public virtual TwTowar TcIdTowarNavigation { get; set; } = null!;

    public virtual ICollection<TwNarzutTw> TwNarzutTws { get; set; } = new List<TwNarzutTw>();
}
