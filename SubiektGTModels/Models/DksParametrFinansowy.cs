using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DksParametrFinansowy
{
    public int FinId { get; set; }

    public int FinTypDok { get; set; }

    public int? FinIdKategorii { get; set; }

    public int FinZaliczka { get; set; }

    public int? FinTypKursu { get; set; }

    public bool FinInfoNiesplacone { get; set; }

    public int? FinStatus { get; set; }

    public int? FinRodzajOdsetek { get; set; }

    public decimal? FinStopaOdsetek { get; set; }

    public bool FinOstatniKurs { get; set; }

    public bool FinDrukujPoZapisie { get; set; }

    public bool FinKorekty { get; set; }

    public int? FinIdKatTransfer { get; set; }

    public bool FinPrzepisujKatZdok { get; set; }

    public int? FinParamEwidId { get; set; }

    public int FinSposobZaplaty { get; set; }

    public bool FinKarta { get; set; }

    public int? FinKartaId { get; set; }

    public bool FinGenerujTytul { get; set; }

    public bool FinPrzepisujTytulDoOpisu { get; set; }

    public int FinDataKursu { get; set; }

    public int? FinIdKategoriiAov { get; set; }

    public int? FinNieGenerujAov { get; set; }

    public virtual SlFormaPlatnosci? FinKartaNavigation { get; set; }

    public virtual ParEwid? FinParamEwid { get; set; }
}
