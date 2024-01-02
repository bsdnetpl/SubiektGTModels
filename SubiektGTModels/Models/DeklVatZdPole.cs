using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklVatZdPole
{
    public int DzdpId { get; set; }

    public int DzdpIdDekleracji { get; set; }

    public string DzdpPodatnikNazwa { get; set; } = null!;

    public string DzdpPodatnikNip { get; set; } = null!;

    public string DzdpNrFaktury { get; set; } = null!;

    public DateTime? DzdpDataWystawienia { get; set; }

    public DateTime? DzdpTerminPlatnosci { get; set; }

    public decimal DzdpKorektaNetto { get; set; }

    public decimal DzdpKorektaVat { get; set; }

    public virtual DeklEwid DzdpIdDekleracjiNavigation { get; set; } = null!;
}
