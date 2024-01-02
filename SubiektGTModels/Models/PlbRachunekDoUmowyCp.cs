using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbRachunekDoUmowyCp
{
    public int RuId { get; set; }

    public int RuIdUmowy { get; set; }

    public int RuStatusImportuRachunku { get; set; }

    public int RuStatusImportuSkladek { get; set; }

    public int RuStatusImportuZaliczek { get; set; }

    public string RuNumer { get; set; } = null!;

    public DateTime RuDataWystawienia { get; set; }

    public int? RuIdKategorii { get; set; }

    public decimal RuKwotaRachunku { get; set; }

    public decimal RuBruttoDuze { get; set; }

    public decimal RuZasilekChorobowy { get; set; }

    public decimal RuZasilekMacierzynski { get; set; }

    public decimal RuZasilekOpiekunczy { get; set; }

    public decimal RuZasilekRodzinny { get; set; }

    public decimal RuDodatekRodzinny { get; set; }

    public decimal RuZasilekPielegnacyjny { get; set; }

    public decimal RuSwiadczenieRehab { get; set; }

    public decimal RuAkord { get; set; }

    public decimal RuProwizja { get; set; }

    public decimal RuPodstUbEmerRent { get; set; }

    public decimal RuPodstUbChorWyp { get; set; }

    public decimal RuZusemer1Firma { get; set; }

    public decimal RuZusemer1Prac { get; set; }

    public decimal RuZusemer2Firma { get; set; }

    public decimal RuZusemer2Prac { get; set; }

    public decimal RuZusrentFirma { get; set; }

    public decimal RuZusrentPrac { get; set; }

    public decimal RuZuschorPrac { get; set; }

    public decimal RuZuswypFirma { get; set; }

    public decimal RuFp { get; set; }

    public decimal RuFgsp { get; set; }

    public decimal RuZusprac { get; set; }

    public decimal RuZusfirma { get; set; }

    public decimal RuZus { get; set; }

    public decimal RuZuszasilki { get; set; }

    public decimal RuZusrazem { get; set; }

    public decimal RuZusrozliczenie { get; set; }

    public decimal RuBruttoMale { get; set; }

    public decimal RuKosztUzyskProcent { get; set; }

    public decimal RuKosztUzysk { get; set; }

    public decimal RuPodstawaOpodatkowania { get; set; }

    public decimal RuPodatekProcent { get; set; }

    public decimal RuPodatek { get; set; }

    public decimal RuUbezpZdrowotne { get; set; }

    public decimal RuZaliczkaNaPodatek { get; set; }

    public decimal RuNetto { get; set; }

    public decimal RuUbezpZdrowotne2 { get; set; }

    public decimal RuPotraceniaNetto { get; set; }

    public decimal RuPrzelew { get; set; }

    public decimal RuPracownikOtrzymuje { get; set; }

    public decimal RuObciazeniePracodawcy { get; set; }

    public int? RuRodzajPrzychodu { get; set; }

    public bool RuPodstUbEmerRentPrzekroczona { get; set; }

    public DateTime RuDataZaliczek { get; set; }

    public DateTime RuDataSkladek { get; set; }

    public bool RuRozliczaEcp { get; set; }

    public DateTime? RuEcpmiesiac { get; set; }

    public bool RuRozliczaAkordy { get; set; }

    public bool RuRozliczaProwizje { get; set; }

    public int? RuIdTresciRachunku { get; set; }

    public int RuIdOsobyWyst { get; set; }

    public int? RuIdHarmonogramu { get; set; }

    public int RuStatus { get; set; }

    public decimal RuNeRazem { get; set; }

    public decimal RuDoReki { get; set; }

    public DateTime? RuDataHarm { get; set; }

    public decimal RuBudzetMacPodstEmRe { get; set; }

    public decimal RuBudzetMacPodstZdr { get; set; }

    public decimal RuBudzetMacEmer { get; set; }

    public decimal RuBudzetMacRent { get; set; }

    public decimal RuBudzetMacZdr { get; set; }

    public int RuFlagi { get; set; }

    public string RuOpis { get; set; } = null!;

    public bool RuZatwierdzony { get; set; }

    public int RuBylKwprzelewWydruk { get; set; }

    public decimal RuDodatkiNieopodatkowane { get; set; }

    public bool RuRyczalt { get; set; }

    public decimal RuFep { get; set; }

    public bool RuPit8c { get; set; }

    public bool RuKosztyAutorskie { get; set; }

    public decimal RuPodstUbWyp { get; set; }

    public bool RuUnikaniePodwojnegoOpodatkowania { get; set; }

    public bool RuRozliczaEwGodz { get; set; }

    public DateTime? RuGodzinyPracyMiesiac { get; set; }

    public int RuRokPrzychodu { get; set; }

    public decimal RuPodstPpk { get; set; }

    public decimal RuWplataPodstPracodawcyPpk { get; set; }

    public decimal RuWplataDodatkPracodawcyPpk { get; set; }

    public decimal RuWplataPodstPracownikaPpk { get; set; }

    public decimal RuWplataDodatkPracownikaPpk { get; set; }

    public decimal RuPrzychodObjetyZwolnieniemZpit { get; set; }

    public decimal RuZusPracZeZwolnionych { get; set; }

    public decimal RuPodstUbZdr { get; set; }

    public decimal RuPodstUbZdrZeZwolnionych { get; set; }

    public int RuSledzWersja { get; set; }

    public decimal RuZusPracZdrZeZwolnionych { get; set; }

    public DateTime RuDataWplatyPpk { get; set; }

    public decimal RuWplataPracodawcyPpkdoPodatku { get; set; }

    public int RuStatusImportuPpk { get; set; }

    public decimal RuZaliczkaNaPodatekOryginalna { get; set; }

    public decimal RuZaliczkaNaPodatekWirtualna { get; set; }

    public decimal RuZaliczkaNaPodatekBilans { get; set; }

    public int RuRodzajUlgi { get; set; }

    public decimal RuMiesiecznaUlgaPodatkowa { get; set; }

    public virtual PlbUmowaCpharmonogram? RuIdHarmonogramuNavigation { get; set; }

    public virtual SlKategorium? RuIdKategoriiNavigation { get; set; }

    public virtual PdUzytkownik RuIdOsobyWystNavigation { get; set; } = null!;

    public virtual SlGratTrescDok? RuIdTresciRachunkuNavigation { get; set; }
}
