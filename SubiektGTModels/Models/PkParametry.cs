using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PkParametry
{
    public int KspIdRoku { get; set; }

    public string? KspRozliczanieKosztow { get; set; }

    public string? KspRozliczeniaMokrKosztow { get; set; }

    public string? KspRozrachDostDet { get; set; }

    public string? KspRozrachOdbDet { get; set; }

    public string? KspDodatnichRoznicKurs { get; set; }

    public string? KspUjemnychRoznicKurs { get; set; }

    public string? KspPrzychPrzyszlychOkr { get; set; }

    public string? KspKorektaZaokraglen { get; set; }

    public int KspNkkDost { get; set; }

    public int KspNkkOdb { get; set; }

    public int KspNkkPrac { get; set; }

    public int KspNkkWsp { get; set; }

    public int KspNkkUs { get; set; }

    public int? KspNkkZus { get; set; }

    public int KspNkkSt { get; set; }

    public int KspNkkWniP { get; set; }

    public int KspNkkRb { get; set; }

    public int KspNkkKasa { get; set; }

    public int KspNkkMag { get; set; }

    public int KspNkkMpk { get; set; }

    public int KspNkkGrTow { get; set; }

    public int KspNkkZlecenia { get; set; }

    public int KspNkkPojazdy { get; set; }

    public int KspNkkMk { get; set; }

    public string? KspNiezrealizowanychDroznicKurs { get; set; }

    public string? KspNiezrealizowanychUroznicKurs { get; set; }

    public string? KspKosztyDroznicKurs { get; set; }

    public string? KspKosztyUroznicKurs { get; set; }

    public string? KspKompDroznicKurs { get; set; }

    public string? KspKompUroznicKurs { get; set; }

    public int KspNkkInIst { get; set; }

    public string? KspNiezrDodatnichRoznicKursFin { get; set; }

    public string? KspNiezrUjemnychRoznicKursFin { get; set; }

    public string? KspZrealDodatnichRoznicKursFin { get; set; }

    public string? KspZrealUjemnychRoznicKursFin { get; set; }

    public int KspNkkPpk { get; set; }

    public virtual PdRokObrotowy KspIdRokuNavigation { get; set; } = null!;
}
