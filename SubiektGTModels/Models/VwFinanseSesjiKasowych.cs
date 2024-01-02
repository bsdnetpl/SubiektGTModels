using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseSesjiKasowych
{
    public int NzfId { get; set; }

    public int NzfTyp { get; set; }

    public int? NzfPodtyp { get; set; }

    public string NzfIdWaluty { get; set; } = null!;

    public decimal NzfKurs { get; set; }

    public bool NzfTransfer { get; set; }

    public DateTime NzfData { get; set; }

    public string? NzfNumerPelny { get; set; }

    public string? NzfTytulem { get; set; }

    public int? NzfIdDokumentAuto { get; set; }

    public int? NzfIdAdresu { get; set; }

    public int? NzfIdSesjiKasowej { get; set; }

    public int? VwfskFormaPlatnosci { get; set; }

    public int? VwfskGridTyp { get; set; }

    public decimal? VwfskPrzychod { get; set; }

    public decimal? VwfskPrzychodWaluta { get; set; }

    public decimal? VwfskRozchod { get; set; }

    public decimal? VwfskRozchodWaluta { get; set; }

    public string? VwfskNumerPelny { get; set; }
}
