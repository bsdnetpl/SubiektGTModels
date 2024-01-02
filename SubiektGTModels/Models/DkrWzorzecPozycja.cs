using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrWzorzecPozycja
{
    public int DkowId { get; set; }

    public int DkowIdDokumentu { get; set; }

    public string DkowKonto { get; set; } = null!;

    public decimal DkowKwotaWn { get; set; }

    public decimal? DkowKwotaWnWaluta { get; set; }

    public decimal DkowKwotaMa { get; set; }

    public decimal? DkowKwotaMaWaluta { get; set; }

    public string DkowWaluta { get; set; } = null!;

    public decimal DkowKurs { get; set; }

    public string DkowOpis { get; set; } = null!;

    public string? DkowTransakcja { get; set; }

    public int? DkowGrupa { get; set; }

    public virtual DkrWzorzec DkowIdDokumentuNavigation { get; set; } = null!;

    public virtual SlWalutum DkowWalutaNavigation { get; set; } = null!;
}
