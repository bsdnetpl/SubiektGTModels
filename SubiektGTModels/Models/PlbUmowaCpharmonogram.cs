using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowaCpharmonogram
{
    public int UchId { get; set; }

    public int UchIdUmowy { get; set; }

    public string UchNazwa { get; set; } = null!;

    public int UchRodzajPozycji { get; set; }

    public int UchRodzajCyklu { get; set; }

    public int UchOkresSposobOkreslenia { get; set; }

    public int UchOkresWydluzOkres { get; set; }

    public DateTime UchOkresOd { get; set; }

    public DateTime UchOkresDo { get; set; }

    public DateTime UchDataRachData { get; set; }

    public int? UchDataRachDzien { get; set; }

    public int? UchDataRachDzienTygodnia { get; set; }

    public int? UchDataRachKorekta { get; set; }

    public decimal UchKwotaRachunku { get; set; }

    public decimal UchKwotaPotracen { get; set; }

    public decimal UchKwotaZasilkuRodzinnego { get; set; }

    public decimal UchKwotaDodatkuRodzinnego { get; set; }

    public decimal UchKwotaZasilkuPielegnacyjnego { get; set; }

    public decimal UchKwotaZasilkuPogrzebowego { get; set; }

    public decimal UchKwotaZasilkuPorodowego { get; set; }

    public decimal UchKwotaZasilkuSwiadczeniaReh { get; set; }

    public bool UchRozliczAkordy { get; set; }

    public bool UchRozliczProwizje { get; set; }

    public bool UchRozliczEcp { get; set; }

    public int? UchRozliczEcpmiesiac { get; set; }

    public int? UchIdSzablonuWydruku { get; set; }

    public int? UchRodzajPrzychodu { get; set; }

    public decimal UchKwotaDodatkowNieopodatkowanych { get; set; }

    public bool UchRyczalt { get; set; }

    public bool UchRozliczEwidGodzinPracy { get; set; }

    public int? UchRozliczEwidGodzinPracyMiesiac { get; set; }

    public virtual ICollection<PlbRachunekDoUmowyCp> PlbRachunekDoUmowyCps { get; set; } = new List<PlbRachunekDoUmowyCp>();

    public virtual SlGratTrescDok? UchIdSzablonuWydrukuNavigation { get; set; }
}
