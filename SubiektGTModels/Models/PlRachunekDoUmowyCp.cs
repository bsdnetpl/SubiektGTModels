using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlRachunekDoUmowyCp
{
    public int RuId { get; set; }

    public int RuIdUmowy { get; set; }

    public DateTime RuDataWystawienia { get; set; }

    public DateTime RuDataZus { get; set; }

    public string RuNumer { get; set; } = null!;

    public decimal RuKwota { get; set; }

    public decimal RuKwotaBrutto { get; set; }

    public decimal RuKosztUzyskProcent { get; set; }

    public decimal RuKosztUzysk { get; set; }

    public decimal RuPodstawaOpodatkowania { get; set; }

    public decimal RuPodatekProcent { get; set; }

    public decimal RuPodatek { get; set; }

    public decimal RuUbezpZdrowotne { get; set; }

    public decimal RuZaliczkaNaPodatek { get; set; }

    public decimal RuKwotaNetto { get; set; }

    public decimal RuUbezpZdrowotne2 { get; set; }

    public decimal RuPracownikOtrzymuje { get; set; }

    public decimal RuPrzelew { get; set; }

    public decimal RuObciazeniePracodawcy { get; set; }

    public decimal RuZusemer1Prac { get; set; }

    public decimal RuZusemer2Prac { get; set; }

    public decimal RuZusemer1Firma { get; set; }

    public decimal RuZusrentPrac { get; set; }

    public decimal RuZusrentFirma { get; set; }

    public decimal RuZuschorPrac { get; set; }

    public decimal RuZuswypFirma { get; set; }

    public decimal RuZusfirma { get; set; }

    public decimal RuZusprac { get; set; }

    public decimal RuFp { get; set; }

    public decimal RuFgsp { get; set; }

    public decimal RuZusrazem { get; set; }

    public int RuStatusImportu { get; set; }

    public int RuStatusImportuSkladek { get; set; }

    public int RuIdOsobyWyst { get; set; }

    public int? RuIdKategorii { get; set; }

    public bool RuPonizejLimituPit8b { get; set; }

    public decimal RuPodstUbEmerRent { get; set; }

    public bool RuPodstUbEmerRentPrzekroczona { get; set; }

    public bool RuRyczalt { get; set; }

    public int RuRokPrzychodu { get; set; }

    public decimal RuPrzychodObjetyZwolnieniemZpit { get; set; }

    public decimal RuZusPracZeZwolnionych { get; set; }

    public decimal RuPodstUbZdr { get; set; }

    public decimal RuPodstUbZdrZeZwolnionych { get; set; }

    public DateTime RuDataWplatyPpk { get; set; }

    public decimal RuPodstPpk { get; set; }

    public decimal RuWplataPodstPracodawcyPpk { get; set; }

    public decimal RuWplataDodatkPracodawcyPpk { get; set; }

    public decimal RuWplataPodstPracownikaPpk { get; set; }

    public decimal RuWplataDodatkPracownikaPpk { get; set; }

    public decimal RuWplataPracodawcyPpkdoPodatkuOryg { get; set; }

    public decimal RuWplataPracodawcyPpkdoPodatku { get; set; }

    public decimal RuWplataPracodawcyPpkzeZwolnionych { get; set; }

    public int RuStatusImportuPpk { get; set; }

    public decimal RuZusPracZdrZeZwolnionych { get; set; }

    public decimal RuZaliczkaNaPodatekOryginalna { get; set; }

    public decimal RuZaliczkaNaPodatekWirtualna { get; set; }

    public decimal RuZaliczkaNaPodatekBilans { get; set; }

    public int RuRodzajUlgi { get; set; }

    public decimal RuMiesiecznaUlgaPodatkowa { get; set; }

    public virtual SlKategorium? RuIdKategoriiNavigation { get; set; }

    public virtual PdUzytkownik RuIdOsobyWystNavigation { get; set; } = null!;

    public virtual PlUmowaCp RuIdUmowyNavigation { get; set; } = null!;
}
