using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IwPozycja
{
    public int IwpId { get; set; }

    public int IwpLp { get; set; }

    public string? IwpOpisPozycji { get; set; }

    public string? IwpKodDostawy { get; set; }

    public decimal IwpStanKomp { get; set; }

    public decimal? IwpStanMagazyn { get; set; }

    public decimal? IwpRozchod { get; set; }

    public decimal? IwpPrzychod { get; set; }

    public decimal? IwpRezerwacja { get; set; }

    public decimal? IwpDostepne { get; set; }

    public decimal? IwpBrakuje { get; set; }

    public decimal? IwpCenaNetto { get; set; }

    public decimal IwpCenaBrutto { get; set; }

    public decimal? IwpWartNetto { get; set; }

    public decimal? IwpWartBrutto { get; set; }

    public int? IwpKategoriaId { get; set; }

    public int? IwpRd { get; set; }

    public int? IwpRozbitaAuto { get; set; }

    public int IwpIdTowaru { get; set; }

    public int IwpDoDokId { get; set; }

    public DateTime? IwpTerminWaznosci { get; set; }

    public virtual IwDokument IwpDoDok { get; set; } = null!;

    public virtual TwTowar IwpIdTowaruNavigation { get; set; } = null!;
}
