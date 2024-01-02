using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbWyplatum
{
    public int WypId { get; set; }

    public int WypIdListyPlac { get; set; }

    public int WypIdUmowy { get; set; }

    public int? WypIdZestawu { get; set; }

    public int WypStatus { get; set; }

    public int WypFlagi { get; set; }

    public string WypOpis { get; set; } = null!;

    public decimal WypBruttoDuze { get; set; }

    public decimal WypBruttoMale { get; set; }

    public decimal WypKosztUzyskMc { get; set; }

    public decimal WypKosztUzysk50 { get; set; }

    public decimal WypKosztUzysk { get; set; }

    public decimal WypPodstawaOpodatkowania { get; set; }

    public decimal WypPodatek { get; set; }

    public decimal WypOdliczenia { get; set; }

    public decimal WypOdliczeniaZeZwolnionych { get; set; }

    public decimal WypUbezpZdrowotne { get; set; }

    public decimal WypZaliczkaObliczona { get; set; }

    public decimal WypZaliczkaNaPodatek { get; set; }

    public decimal WypNetto { get; set; }

    public decimal WypUbezpZdrowotne2 { get; set; }

    public decimal WypNeFirmaNaliczenia { get; set; }

    public decimal WypNeFirmaPotracenia { get; set; }

    public decimal WypNeFirma { get; set; }

    public decimal WypZuszasilkiBr { get; set; }

    public decimal WypZuszasilkiNe { get; set; }

    public decimal WypNeRazem { get; set; }

    public decimal WypPracownikOtrzymuje { get; set; }

    public decimal WypPrzelew { get; set; }

    public decimal WypDoReki { get; set; }

    public decimal WypZusEmer1Prac { get; set; }

    public decimal WypZusEmer1Firma { get; set; }

    public decimal WypZusEmer2Prac { get; set; }

    public decimal WypZusRentPrac { get; set; }

    public decimal WypZusRentFirma { get; set; }

    public decimal WypZusChorPrac { get; set; }

    public decimal WypZusWypFirma { get; set; }

    public decimal WypFp { get; set; }

    public decimal WypFgsp { get; set; }

    public decimal WypZusprac { get; set; }

    public decimal WypZusfirma { get; set; }

    public decimal WypZus { get; set; }

    public decimal WypZuszasilki { get; set; }

    public decimal WypZusrazem { get; set; }

    public decimal WypZusrozliczenie { get; set; }

    public decimal WypObciazeniePracodawcy { get; set; }

    public decimal WypPodstUbEmerRentOryg { get; set; }

    public decimal WypPodstUbEmerRent { get; set; }

    public decimal WypPodstUbChorWyp { get; set; }

    public decimal WypPodstUbZdr { get; set; }

    public bool WypPodstUbEmerRentPrzekroczona { get; set; }

    public int WypIdOsobyWyst { get; set; }

    public bool WypCzyWchodziDoWyznaczaniaChor { get; set; }

    public decimal WypKwotaChorobowego { get; set; }

    public decimal WypKwotaUrlopowegoStale { get; set; }

    public decimal WypKwotaUrlopowegoZmienne { get; set; }

    public decimal WypPodstUrlopSt0 { get; set; }

    public decimal WypPodstUrlopSt3 { get; set; }

    public decimal WypPodstUrlopSt12 { get; set; }

    public decimal WypPodstUrlopZm3 { get; set; }

    public decimal WypPodstUrlopZm12 { get; set; }

    public int WypLiczbaDniWynChorobowego { get; set; }

    public int WypLiczbaDniZasChorobowego { get; set; }

    public int WypLiczbaGodzinUrlopowego { get; set; }

    public int WypLiczbaDniUrlopowego { get; set; }

    public bool WypRozliczaEcp { get; set; }

    public bool WypRozliczaNadgodziny { get; set; }

    public bool WypRozliczaAkordy { get; set; }

    public bool WypRozliczaProwizje { get; set; }

    public bool WypRozliczaNalPotr { get; set; }

    public int WypStatDniChoroby { get; set; }

    public int WypStatDniUrlWyp { get; set; }

    public int WypStatDniUrlMac { get; set; }

    public int WypStatDniUrlWych { get; set; }

    public int WypStatDniUrlBezpl { get; set; }

    public int WypStatDniZwolnOkolPl { get; set; }

    public int WypStatDniZwolnPl { get; set; }

    public int WypStatDniOpiekiNadDzieckiem { get; set; }

    public int WypStatDniOpieki { get; set; }

    public int WypStatDniNieobUspPl { get; set; }

    public int WypStatDniNieobNieusp { get; set; }

    public int WypStatDniNieobUspNiepl { get; set; }

    public int WypStatDniPoszPracy { get; set; }

    public int WypStatDniSluzby { get; set; }

    public int WypStatDniZwolnZeSwiadPracy { get; set; }

    public int WypStatDniMiesiaca { get; set; }

    public int WypStatDniDoPrzepr { get; set; }

    public int WypStatDniPrzepr { get; set; }

    public int WypStatGodzDoPrzepr { get; set; }

    public int WypStatGodzPrzepr { get; set; }

    public int WypStatGodzNadlDoWypl { get; set; }

    public int WypStatGodzNadlNoc { get; set; }

    public int WypStatGodzNadlDoRozl { get; set; }

    public int WypStatGodzAbsDoPotr { get; set; }

    public int WypStatGodzAbsDoRozl { get; set; }

    public int WypStatGodzNoc { get; set; }

    public int WypStatGodzBilansDoRozl { get; set; }

    public decimal WypBudzetMacPodstEmRe { get; set; }

    public decimal WypBudzetMacEmer { get; set; }

    public decimal WypBudzetMacRent { get; set; }

    public decimal WypBudzetWychPodstEmRe { get; set; }

    public decimal WypBudzetWychPodstZdr { get; set; }

    public decimal WypBudzetWychEmer { get; set; }

    public decimal WypBudzetWychRent { get; set; }

    public decimal WypBudzetWychZdr { get; set; }

    public decimal WypZusZasChor { get; set; }

    public decimal WypZusZasOp { get; set; }

    public decimal WypZusZasMac { get; set; }

    public string? WypSledz { get; set; }

    public int WypSledzWersja { get; set; }

    public bool WypCzyKorygowana { get; set; }

    public DateTime? WypKorektaKiedy { get; set; }

    public int? WypKorektaKto { get; set; }

    public decimal WypPodstChorob { get; set; }

    public int WypPierwDzienZasChor { get; set; }

    public DateTime? WypMcPodstChorOd { get; set; }

    public DateTime? WypMcPodstChorDo { get; set; }

    public decimal WypPodstChorob30 { get; set; }

    public decimal? WypUbezpZdrowotneNiepomniejszone { get; set; }

    public decimal? WypUbezpZdrowotnePomniejszenie { get; set; }

    public int WypBylKwprzelewWydruk { get; set; }

    public bool WypRozliczaPotraceniaKomornicze { get; set; }

    public int WypStatDniDoPodstChorWyplKoryg { get; set; }

    public int WypStatGodzNadlDoWyplPierwsze { get; set; }

    public int WypStatGodzNadlDoWyplKolejne { get; set; }

    public decimal WypFep { get; set; }

    public decimal WypPodstUbFep { get; set; }

    public decimal WypPodstUbFeporyg { get; set; }

    public bool WypPodstUbFepprzekroczona { get; set; }

    public decimal WypZusZasReh { get; set; }

    public int WypSposobPrzeliczania { get; set; }

    public decimal WypBruttoDuzeOdl { get; set; }

    public decimal WypPodstUbEmReOdl { get; set; }

    public decimal WypPodstUbChWyOdl { get; set; }

    public decimal WypPodstUbZdrOdl { get; set; }

    public decimal WypZuspracOdl { get; set; }

    public decimal WypKosztUzyskDeklRoczne { get; set; }

    public decimal WypPodstUbEmReNieodlNieogr { get; set; }

    public decimal WypPodstUbChWyNieodlNieogr { get; set; }

    public decimal WypZuspracNieodlNieogr { get; set; }

    public decimal WypPodstUbZdrNieodlNieogr { get; set; }

    public decimal WypUbezpZdrowotneNieodlNieogr { get; set; }

    public int WypStatGodzNadlDniWolne { get; set; }

    public int WypStatGodzNadlDniSwiateczne { get; set; }

    public decimal WypPodstPpk { get; set; }

    public decimal WypWplataPodstPracodawcyPpk { get; set; }

    public decimal WypWplataDodatkPracodawcyPpk { get; set; }

    public decimal WypWplataPodstPracownikaPpk { get; set; }

    public decimal WypWplataDodatkPracownikaPpk { get; set; }

    public decimal WypPrzychodObjetyZwolnieniemZpit { get; set; }

    public decimal WypKosztUzyskDekl { get; set; }

    public decimal WypPodstUbEmReZeZwolnionych { get; set; }

    public decimal WypPodstUbChWyZeZwolnionych { get; set; }

    public decimal WypPodstUbZdrZeZwolnionych { get; set; }

    public decimal WypZusPracEmReZeZwolnionych { get; set; }

    public decimal WypZusPracChWyZeZwolnionych { get; set; }

    public decimal WypZusPracZdrZeZwolnionych { get; set; }

    public decimal WypPodstUbEmReZeZwolnionychZeZdr { get; set; }

    public decimal WypPodstUbChWyZeZwolnionychZeZdr { get; set; }

    public decimal WypZusPracEmReZeZwolnionychZeZdr { get; set; }

    public decimal WypZusPracChWyZeZwolnionychZeZdr { get; set; }

    public int WypStatGodzNadlDoRozlSuma { get; set; }

    public decimal WypWplataPracodawcyPpkdoPodatku { get; set; }

    public decimal WypPodstawaUlgiDlaKlasySredniej { get; set; }

    public decimal WypUlgaDlaKlasySredniej { get; set; }

    public decimal WypZaliczkaNaPodatekOryginalna { get; set; }

    public decimal WypZaliczkaNaPodatekWirtualna { get; set; }

    public decimal WypZaliczkaNaPodatekBilans { get; set; }

    public int WypRodzajUlgi { get; set; }

    public decimal WypKwotaWylaczonaZpodstawySkladekZus { get; set; }

    public decimal WypKwotaZwolnieniaZpodatkuInne { get; set; }

    public int WypStatDniUrlopSilaWyzsza { get; set; }

    public virtual ICollection<EcpZapi> EcpZapis { get; set; } = new List<EcpZapi>();

    public virtual ICollection<KpPozycjaDefinicji> KpPozycjaDefinicjis { get; set; } = new List<KpPozycjaDefinicji>();

    public virtual ICollection<PlbWyplataSkladnik> PlbWyplataSkladniks { get; set; } = new List<PlbWyplataSkladnik>();

    public virtual PlbListaPlac WypIdListyPlacNavigation { get; set; } = null!;

    public virtual PdUzytkownik WypIdOsobyWystNavigation { get; set; } = null!;

    public virtual PlbUmowa WypIdUmowyNavigation { get; set; } = null!;

    public virtual PdUzytkownik? WypKorektaKtoNavigation { get; set; }
}
