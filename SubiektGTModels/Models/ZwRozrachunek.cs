using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZwRozrachunek
{
    public int ZwrId { get; set; }

    public int ZwrIdZw { get; set; }

    public int ZwrIdRoz { get; set; }

    public decimal ZwrOdsetki { get; set; }

    public int ZwrTypOdsetek { get; set; }

    public decimal ZwrStopaOdsetek { get; set; }

    public int ZwrStatus { get; set; }

    public DateTime ZwrDataPowstania { get; set; }

    public string ZwrNumerPelny { get; set; } = null!;

    public DateTime ZwrTerminPlatnosci { get; set; }

    public int ZwrSpoznienie { get; set; }

    public decimal? ZwrNalPierwotnaWaluta { get; set; }

    public decimal ZwrNalWaluta { get; set; }

    public string ZwrTxtWaluta { get; set; } = null!;

    public decimal? ZwrNalPierwotna { get; set; }

    public decimal ZwrNaleznosc { get; set; }

    public virtual NzFinanse ZwrIdRozNavigation { get; set; } = null!;

    public virtual ZwZdarzenieWindykacyjne ZwrIdZwNavigation { get; set; } = null!;
}
