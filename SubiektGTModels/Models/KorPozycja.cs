using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KorPozycja
{
    public int KkpId { get; set; }

    public int KkpIdKorKoszt { get; set; }

    public int KkpTypPozycji { get; set; }

    public int KkpTypOkresu { get; set; }

    public int KkpDokId { get; set; }

    public DateTime KkpDokDataWyst { get; set; }

    public string KkpDokNrPelny { get; set; } = null!;

    public int KkpKorId { get; set; }

    public DateTime KkpKorDataWyst { get; set; }

    public string KkpKorNrPelny { get; set; } = null!;

    public decimal? KkpWartPrzedKor { get; set; }

    public decimal? KkpWartKorekty { get; set; }

    public decimal? KkpWartPoKor { get; set; }

    public virtual DokDokument KkpDok { get; set; } = null!;

    public virtual KorKorektaKosztow KkpIdKorKosztNavigation { get; set; } = null!;
}
