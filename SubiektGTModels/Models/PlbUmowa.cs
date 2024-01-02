using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowa
{
    public int UpId { get; set; }

    public int UpIdPracownika { get; set; }

    public string UpNumer { get; set; } = null!;

    public int UpRodzaj { get; set; }

    public DateTime UpDataOd { get; set; }

    public DateTime? UpDataDo { get; set; }

    public DateTime? UpDataRozwiazania { get; set; }

    public int? UpPowodRozwiazaniaId { get; set; }

    public int UpSposobRozliczaniaNadgodzin { get; set; }

    public int UpSposobRozliczaniaAbsencji { get; set; }

    public int UpSposobRozliczaniaPoZbilansowaniu { get; set; }

    public string? UpTytulUbezp { get; set; }

    public string? UpKodPracyWszczChar { get; set; }

    public DateTime? UpOkresPracySzczOd { get; set; }

    public DateTime? UpOkresPracySzczDo { get; set; }

    public int UpGenerowanyRaport { get; set; }

    public int UpPrzenLiczbaDniChorob { get; set; }

    public int UpCzasOczekNaZasChorob { get; set; }

    public int UpLiczbaDniWykorzystUrlopu { get; set; }

    public int UpKosztyUzyskania { get; set; }

    public int UpPrzelewNaKonto { get; set; }

    public decimal UpPrzelewKwota { get; set; }

    public decimal UpPrzelewProcent { get; set; }

    public int? UpPrzelewRachunekId { get; set; }

    public bool UpCzyOdliczacUlge { get; set; }

    public bool UpCzyNaliczacPodatek { get; set; }

    public bool UpIndywidSkalaPodatk { get; set; }

    public bool UpIndywidZfss { get; set; }

    public decimal UpIndywidZfsskwota { get; set; }

    public int UpIspliczbaProgow { get; set; }

    public decimal UpIspprog1 { get; set; }

    public decimal UpIspprog2 { get; set; }

    public decimal UpIspstopa1 { get; set; }

    public decimal UpIspstopa2 { get; set; }

    public decimal UpIspstopa3 { get; set; }

    public decimal UpIspulgaMiesieczna { get; set; }

    public decimal UpIspulgaRoczna { get; set; }

    public decimal UpIspkoszty { get; set; }

    public int? UpIdZawodu { get; set; }

    public string? UpKodZawodu { get; set; }

    public bool UpRozwiazana { get; set; }

    public bool UpTrescIndywidualna { get; set; }

    public byte[]? UpTresc { get; set; }

    public int? UpIdSzablonu { get; set; }

    public int UpSposobRozliczaniaUrlopu { get; set; }

    public bool UpCzyNaliczacEmer { get; set; }

    public bool UpCzyNaliczacRent { get; set; }

    public bool UpCzyNaliczacChor { get; set; }

    public bool UpCzyNaliczacWyp { get; set; }

    public bool UpCzyNaliczacZdr { get; set; }

    public bool UpCzyNaliczacFp { get; set; }

    public bool UpCzyNaliczacFgsp { get; set; }

    public bool UpIndywidWynChor { get; set; }

    public int UpIndywidLiczbaDniWynChor { get; set; }

    public bool UpCzyNaliczacZaliczke { get; set; }

    public bool UpIndywidWynMin { get; set; }

    public decimal UpIndywidWynMinKwota { get; set; }

    public bool UpCzyNaliczacFep { get; set; }

    public int UpUczen { get; set; }

    public DateTime? UpDataZawarcia { get; set; }

    public string? UpCelZawarcia { get; set; }

    public int? UpIdPracZastepowanego { get; set; }

    public bool UpCzyLiczycAutoFp { get; set; }

    public bool UpNieUwzglWpfron { get; set; }

    public bool UpCzyNaliczacUlgeDlaKlasySredniej { get; set; }

    public bool UpCzyOdraczacPoborZaliczki { get; set; }

    public int UpWymiarUlgiPodatkowej { get; set; }

    public int UpNaliczanieZaliczki { get; set; }

    public bool UpCzyKontrolowacLimitPracyZdalnejOkazjonalnej { get; set; }

    public virtual ICollection<KpAkord> KpAkords { get; set; } = new List<KpAkord>();

    public virtual ICollection<KpNaliczeniePotracenie> KpNaliczeniePotracenies { get; set; } = new List<KpNaliczeniePotracenie>();

    public virtual ICollection<KpProwizja> KpProwizjas { get; set; } = new List<KpProwizja>();

    public virtual ICollection<PlbUmowaDzialStanowisko> PlbUmowaDzialStanowiskos { get; set; } = new List<PlbUmowaDzialStanowisko>();

    public virtual ICollection<PlbUmowaKalendarz> PlbUmowaKalendarzs { get; set; } = new List<PlbUmowaKalendarz>();

    public virtual ICollection<PlbUmowaPrzelewy> PlbUmowaPrzelewies { get; set; } = new List<PlbUmowaPrzelewy>();

    public virtual ICollection<PlbUmowaSkladnik> PlbUmowaSkladniks { get; set; } = new List<PlbUmowaSkladnik>();

    public virtual ICollection<PlbUmowaWyjatekCzasuPracy> PlbUmowaWyjatekCzasuPracies { get; set; } = new List<PlbUmowaWyjatekCzasuPracy>();

    public virtual ICollection<PlbUmowaZestaw> PlbUmowaZestaws { get; set; } = new List<PlbUmowaZestaw>();

    public virtual ICollection<PlbWyplatum> PlbWyplata { get; set; } = new List<PlbWyplatum>();

    public virtual SlGratTrescDok? UpIdSzablonuNavigation { get; set; }

    public virtual SlGratPrzyczynaRozwUmowy? UpPowodRozwiazania { get; set; }
}
