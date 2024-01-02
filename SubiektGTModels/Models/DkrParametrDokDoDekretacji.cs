using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrParametrDokDoDekretacji
{
    public int DddpId { get; set; }

    public bool DddpPrzerwaniePoBledzie { get; set; }

    public int? DddpParamEwidId { get; set; }

    public int DddpDataZakupowe { get; set; }

    public bool DddpAutoNadawanieAnalityk { get; set; }

    public bool DddpUzupelniajLukiAnalityk { get; set; }

    public bool DddpDekretacjaUsuwajKwotyZerowe { get; set; }

    public bool DddpRozniceZaokraglenDekretowWalutowych { get; set; }

    public bool DddpProbojBilansowacBezGrup { get; set; }

    public bool DddpPrzenosPlatnosciMasowe { get; set; }

    public bool DddpUsuwajNieprawidloweKonta { get; set; }

    public bool DddpDekretyZerowe { get; set; }

    public virtual ParEwid? DddpParamEwid { get; set; }
}
