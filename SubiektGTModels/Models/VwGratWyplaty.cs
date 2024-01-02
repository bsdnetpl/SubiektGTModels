using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratWyplaty
{
    public int LpId { get; set; }

    public int WypId { get; set; }

    public int UpId { get; set; }

    public int PrId { get; set; }

    public int? KatId { get; set; }

    public int UzId { get; set; }

    public bool LpZatwierdzona { get; set; }

    public int LpStatusKsiegowyLp { get; set; }

    public int LpStatusKsiegowySkladki { get; set; }

    public int LpStatusKsiegowyZaliczki { get; set; }

    public bool WypRozliczaEcp { get; set; }

    public bool WypRozliczaNadgodziny { get; set; }

    public bool WypRozliczaAkordy { get; set; }

    public bool WypRozliczaProwizje { get; set; }

    public bool WypRozliczaNalPotr { get; set; }

    public int WypStatus { get; set; }

    public int WypFlagi { get; set; }

    public string LpNumer { get; set; } = null!;

    public DateTime LpMiesiac { get; set; }

    public DateTime LpDataWyplaty { get; set; }

    public DateTime LpDataSkladek { get; set; }

    public DateTime LpDataZaliczek { get; set; }

    public string AdrNazwa { get; set; } = null!;

    public decimal WypBruttoDuze { get; set; }

    public decimal WypBruttoMale { get; set; }

    public decimal WypZusprac { get; set; }

    public decimal WypZusfirma { get; set; }

    public decimal WypZaliczkaNaPodatek { get; set; }

    public decimal WypNetto { get; set; }

    public decimal WypPracownikOtrzymuje { get; set; }

    public decimal? ZdrowotneRazem { get; set; }

    public decimal WypObciazeniePracodawcy { get; set; }

    public string UzIdentyfikator { get; set; } = null!;

    public string? KatNazwa { get; set; }

    public string WypOpis { get; set; } = null!;

    public bool WypCzyKorygowana { get; set; }

    public decimal WypKwotaChorobowego { get; set; }

    public decimal WypKwotaUrlopowegoStale { get; set; }

    public decimal WypKwotaUrlopowegoZmienne { get; set; }

    public string PrNip { get; set; } = null!;

    public string PrPesel { get; set; } = null!;

    public decimal WypPodstawaOpodatkowania { get; set; }

    public decimal WypPodstUbEmerRent { get; set; }

    public decimal WypPrzelew { get; set; }

    public decimal WypDoReki { get; set; }

    public int WypBylPrzelew { get; set; }

    public int WypBylKw { get; set; }

    public int WypBylWydruk { get; set; }

    public int WypOstatniaWyplataPracownika { get; set; }

    public bool LpCzyPrzychodZaInnyRok { get; set; }

    public int? RokPrzychodu { get; set; }

    public decimal? Ppksuma { get; set; }

    public decimal? Ppkpracownika { get; set; }

    public decimal? Ppkpracodawcy { get; set; }

    public int LpStatusKsiegowyPpk { get; set; }
}
