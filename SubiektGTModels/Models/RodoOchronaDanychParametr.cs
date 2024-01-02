using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RodoOchronaDanychParametr
{
    public int RodoId { get; set; }

    public bool? RodoAdminToPodmiot { get; set; }

    public bool? RodoInspektorToPodmiot { get; set; }

    public string? RodoOdbiorcy { get; set; }

    public string? RodoZrodloDanychOsobowych { get; set; }

    public string? RodoPrawoDoDanychOsobowych { get; set; }

    public string? RodoPrawoDoCofnieciaZgody { get; set; }

    public string RodoAnonimizacjaZnakZastapienia { get; set; } = null!;

    public string RodoAnonimizacjaZastapNazweText { get; set; } = null!;

    public int RodoAnonimizacjaOkresPrzechowDanychDokLata { get; set; }

    public bool RodoSoKontrahenci { get; set; }

    public bool RodoSoPracownicy { get; set; }

    public bool RodoSoPracownicyFirm { get; set; }

    public bool RodoSoWspolnicy { get; set; }

    public bool RodoSzDodanieObiektu { get; set; }

    public bool RodoSzEdycjaObiektu { get; set; }

    public bool RodoSzKopiowanieListy { get; set; }

    public bool RodoSzOdczytDanych { get; set; }

    public bool RodoSzWydrukDanych { get; set; }

    public bool RodoSzWyswietlanieListy { get; set; }

    public bool RodoSzEksportDanych { get; set; }

    public bool RodoSzDrukowanieListy { get; set; }

    public bool RodoSzPodgladDanych { get; set; }
}
