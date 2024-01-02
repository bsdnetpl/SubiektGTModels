using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklPitZdPole
{
    public int DpzdId { get; set; }

    public int DpzdIdDeklaracji { get; set; }

    public int? DpzdIdKorekty { get; set; }

    public int DpzdTyp { get; set; }

    public string DpzdPodatnikNazwa { get; set; } = null!;

    public string DpzdPodatnikNip { get; set; } = null!;

    public string DpzdNrDokumentu { get; set; } = null!;

    public DateTime? DpzdDataWystawienia { get; set; }

    public DateTime? DpzdTerminPlatnosci { get; set; }

    public int DpzdRodzaj { get; set; }

    public decimal DpzdKwotaKorekty { get; set; }

    public decimal DpzdKwotaWspolnika { get; set; }

    public decimal DpzdKwotaDoRozliczenia { get; set; }

    public bool DpzdZmienione { get; set; }

    public DateTime? DpzdDataSplaty { get; set; }

    public int DpzdOkresSplaty { get; set; }

    public int? DpzdIdZaliczenia { get; set; }

    public int DpzdDzialalnosc { get; set; }

    public int DpzdPodatnikTypIdent { get; set; }

    public virtual DeklEwid DpzdIdDeklaracjiNavigation { get; set; } = null!;

    public virtual NzKorektaPit? DpzdIdKorektyNavigation { get; set; }

    public virtual NzKorektaZaliczenie? DpzdIdZaliczeniaNavigation { get; set; }
}
