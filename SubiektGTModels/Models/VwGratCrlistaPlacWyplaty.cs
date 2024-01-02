using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrlistaPlacWyplaty
{
    public int IdRecordu { get; set; }

    public decimal BruttoDuze { get; set; }

    public decimal BruttoMale { get; set; }

    public decimal KosztUzyskania { get; set; }

    public decimal PodstawaOpodatkowania { get; set; }

    public decimal Podatek { get; set; }

    public decimal Odliczenia { get; set; }

    public decimal UbezpieczenieZdrowotne { get; set; }

    public decimal ZaliczkaObliczona { get; set; }

    public decimal ZaliczkaNaPodatek { get; set; }

    public decimal Netto { get; set; }

    public decimal? UbezpieczenieZdrowotne2 { get; set; }

    public decimal PracownikOtrzymuje { get; set; }

    public decimal Przelew { get; set; }

    public decimal DoReki { get; set; }

    public decimal ZusEmer1Prac { get; set; }

    public decimal ZusEmer1Firma { get; set; }

    public decimal ZusEmer2Prac { get; set; }

    public decimal ZusRentPrac { get; set; }

    public decimal ZusRentFirma { get; set; }

    public decimal ZusChorPrac { get; set; }

    public decimal ZusWypFirma { get; set; }

    public decimal Fp { get; set; }

    public decimal Fgsp { get; set; }

    public decimal ZusPrac { get; set; }

    public decimal ZusFirma { get; set; }

    public decimal Zus { get; set; }

    public int StatDniChoroby { get; set; }

    public int StatDniUrlWyp { get; set; }

    public int StatDniUrlMac { get; set; }

    public int StatDniUrlWych { get; set; }

    public int StatDniUrlBezpl { get; set; }

    public int StatDniZwolnOkolPl { get; set; }

    public int StatDniZwolnPl { get; set; }

    public int StatDniOpiekiNadDzieckiem { get; set; }

    public int StatDniOpieki { get; set; }

    public int StatDniNieobUspPl { get; set; }

    public int StatDniNieobNieusp { get; set; }

    public int StatDniNieobUspNiepl { get; set; }

    public int StatDniPoszPracy { get; set; }

    public int StatDniSluzby { get; set; }

    public int StatDniMiesiaca { get; set; }

    public int StatDniDoPrzepr { get; set; }

    public int StatDniPrzepr { get; set; }

    public int StatGodzDoPrzepr { get; set; }

    public int StatGodzPrzepr { get; set; }

    public int StatGodzNadlDoWypl { get; set; }

    public int StatGodzNadlDoWyplPierwsze { get; set; }

    public int StatGodzNadlDoWyplKolejne { get; set; }

    public int StatGodzNadlNoc { get; set; }

    public int StatGodzNadlRozl { get; set; }

    public int StatGodzAbsDoPotr { get; set; }

    public int StatGodzAbsDoRozl { get; set; }

    public int StatGodzNoc { get; set; }

    public int StatGodzBilansDoRozl { get; set; }

    public int IdListyPlac { get; set; }

    public string TytulLp { get; set; } = null!;

    public string NumerLp { get; set; } = null!;

    public DateTime MiesiacLp { get; set; }

    public DateTime DataWyplaty { get; set; }

    public int IdPracownika { get; set; }

    public string Pracownik { get; set; } = null!;

    public string NumerUmowy { get; set; } = null!;

    public decimal PodstawaUbezpieczeniaZdrowotnego { get; set; }

    public decimal? SumaUbezpieczeniaZdrowotnegoPrac { get; set; }

    public decimal PodstawaEmRe { get; set; }

    public decimal PodstawaChWy { get; set; }

    public decimal Fep { get; set; }

    public int? StatGodzPrzeprWszystkie { get; set; }

    public int? StatSumaGodzNocnych { get; set; }

    public int StatGodzNadlWDniWolne { get; set; }

    public int StatGodzNadlWDniSwiateczne { get; set; }

    public decimal? PpkPracodawcy { get; set; }

    public decimal? PpkPracownika { get; set; }

    public int StatGodzNadlRozlSuma { get; set; }

    public decimal UlgaDlaKlasySredniej { get; set; }

    public decimal ObnizeniePodstawyZus { get; set; }

    public decimal InneZwolnienia { get; set; }

    public decimal PpkOpodatkowane { get; set; }
}
