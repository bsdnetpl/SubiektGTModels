using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlWyplatum
{
    public int WypId { get; set; }

    public int WypIdListyPlac { get; set; }

    public int WypIdUmowy { get; set; }

    public string WypOpis { get; set; } = null!;

    public decimal WypBrPodstawa { get; set; }

    public decimal WypBrGodzNadliczbowe { get; set; }

    public decimal WypBrGodzNocne { get; set; }

    public decimal WypBrAkord { get; set; }

    public decimal WypBrProwizja { get; set; }

    public decimal WypBrPremiaProcOdPodst { get; set; }

    public decimal WypBrPremiaUznaniowa { get; set; }

    public decimal WypBrNagrodaRegul { get; set; }

    public decimal WypBrWynagrChorob { get; set; }

    public decimal WypBrWynagrUrlop { get; set; }

    public decimal WypBrEkwiwalentZaUrlop { get; set; }

    public decimal WypBrDodatekFunkc { get; set; }

    public decimal WypBrDodatekZaWysluge { get; set; }

    public decimal WypBrDodatekZaWarUciazliw { get; set; }

    public decimal WypBrInnePrac { get; set; }

    public decimal WypBrZasilekOpiekunczy { get; set; }

    public decimal WypBrZasilekWyrownawczy { get; set; }

    public decimal WypBrSwiadczRehabilit { get; set; }

    public decimal WypBrZasilekChorobowy { get; set; }

    public decimal WypBrZasilekMacierzynski { get; set; }

    public decimal WypBrInneZus { get; set; }

    public decimal WypBrInneEmRe { get; set; }

    public decimal WypBrInneChWy { get; set; }

    public decimal WypBrInneZdr { get; set; }

    public decimal WypBrZasilkiZus { get; set; }

    public decimal WypBruttoDuze { get; set; }

    public decimal WypBruttoMale { get; set; }

    public decimal WypKosztUzysk { get; set; }

    public decimal WypPodstawaOpodatkowania { get; set; }

    public decimal WypPodatek { get; set; }

    public decimal WypOdliczenia { get; set; }

    public decimal WypUbezpZdrowotne { get; set; }

    public decimal WypZaliczkaNaPodatek { get; set; }

    public decimal WypNetto { get; set; }

    public decimal WypUbezpZdrowotne2 { get; set; }

    public decimal WypNeDoplaty { get; set; }

    public decimal WypNePotracenia { get; set; }

    public decimal WypNeZasilekRodzinny { get; set; }

    public decimal WypNeZasilekPielegnacyjny { get; set; }

    public decimal WypNeZasilekPorodowy { get; set; }

    public decimal WypNeZasilekPogrzebowy { get; set; }

    public decimal WypNeZasilekWychowawczy { get; set; }

    public decimal WypNeInnePrac { get; set; }

    public decimal WypNeInneZus { get; set; }

    public decimal WypNeZasilkiZus { get; set; }

    public decimal WypNeRazem { get; set; }

    public decimal WypPracownikOtrzymuje { get; set; }

    public decimal WypPrzelew { get; set; }

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

    public decimal WypObciazeniePracodawcy { get; set; }

    public decimal WypPodstUbEmerRent { get; set; }

    public decimal WypPodstUbChorWyp { get; set; }

    public decimal WypPodstUbZdr { get; set; }

    public bool WypPodstUbEmerRentPrzekroczona { get; set; }

    public int WypIdOsobyWyst { get; set; }

    public decimal WypPrzychodObjetyZwolnieniemZpit { get; set; }

    public decimal WypKosztUzyskDekl { get; set; }

    public decimal WypPodstUbEmReZeZwolnionych { get; set; }

    public decimal WypPodstUbChWyZeZwolnionych { get; set; }

    public decimal WypPodstUbZdrZeZwolnionych { get; set; }

    public decimal WypZusPracEmReZeZwolnionych { get; set; }

    public decimal WypZusPracChWyZeZwolnionych { get; set; }

    public decimal WypZusPracZdrZeZwolnionych { get; set; }

    public decimal WypPodstPpk { get; set; }

    public decimal WypWplataPodstPracodawcyPpk { get; set; }

    public decimal WypWplataDodatkPracodawcyPpk { get; set; }

    public decimal WypWplataPodstPracownikaPpk { get; set; }

    public decimal WypWplataDodatkPracownikaPpk { get; set; }

    public decimal WypWplataPracodawcyPpkdoPodatkuOryg { get; set; }

    public decimal WypWplataPracodawcyPpkdoPodatku { get; set; }

    public decimal WypWplataPracodawcyPpkzeZwolnionych { get; set; }

    public decimal WypUlgaDlaKlasySredniej { get; set; }

    public decimal WypPodstawaUlgiDlaKlasySredniej { get; set; }

    public decimal WypZaliczkaNaPodatekOryginalna { get; set; }

    public decimal WypZaliczkaNaPodatekWirtualna { get; set; }

    public decimal WypZaliczkaNaPodatekBilans { get; set; }

    public int WypRodzajUlgi { get; set; }

    public virtual ICollection<PlWyplataSkladnik> PlWyplataSkladniks { get; set; } = new List<PlWyplataSkladnik>();

    public virtual PlListaPlac WypIdListyPlacNavigation { get; set; } = null!;

    public virtual PdUzytkownik WypIdOsobyWystNavigation { get; set; } = null!;

    public virtual PlUmowaOprace WypIdUmowyNavigation { get; set; } = null!;
}
