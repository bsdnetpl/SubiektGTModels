using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwInwPowiazaneCzastkoweOrazDokMag
{
    public int DokId { get; set; }

    public DateTime DokDataWyst { get; set; }

    public int DokTyp { get; set; }

    public int? DokPodtyp { get; set; }

    public int? DokNr { get; set; }

    public string DokNrPelny { get; set; } = null!;

    public int? AdrhNazwa { get; set; }

    public decimal? DokKwWartosc { get; set; }

    public decimal? DokWartNetto { get; set; }

    public DateTime? DokDataMag { get; set; }

    public int? DokKatId { get; set; }

    public string DokWystawil { get; set; } = null!;

    public int? DokDoDokNrPelny { get; set; }

    public int? DokPlatnikAdreshId { get; set; }

    public int? IwRwId { get; set; }

    public int? IwPwId { get; set; }

    public int IwaIdZb { get; set; }
}
