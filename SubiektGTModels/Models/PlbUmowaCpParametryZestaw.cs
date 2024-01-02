using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowaCpParametryZestaw
{
    public int UpzId { get; set; }

    public int UpzIdParametrow { get; set; }

    public string UpzNazwa { get; set; } = null!;

    public int? UpzUmowaIdFmtNumeru { get; set; }

    public int UpzUmowaRodzaj { get; set; }

    public int? UpzUmowaIdTresci { get; set; }

    public int? UpzUmowaTytulUbezpieczenia { get; set; }

    public int? UpzRachIdFmtNumeru { get; set; }

    public int UpzRachRodzajPrzychodu { get; set; }

    public int? UpzRachTrescRachunku { get; set; }

    public decimal UpzRachRyczaltPodatek { get; set; }

    public int UpzRachRyczaltKosztyMetoda { get; set; }

    public decimal UpzRachRyczaltKosztyProcent { get; set; }

    public decimal UpzRachRyczaltKosztyKwota { get; set; }

    public bool UpzRachNaliczajEmertyalny { get; set; }

    public bool UpzRachNaliczajRentowy { get; set; }

    public bool UpzRachNaliczajChorobowy { get; set; }

    public bool UpzRachNaliczajWypadkowy { get; set; }

    public bool UpzRachNaliczajZdrowotny { get; set; }

    public bool UpzRachNaliczajFp { get; set; }

    public bool UpzRachNaliczajFgsp { get; set; }

    public int UpzRachPrzelewRachNaKonto { get; set; }

    public decimal UpzRachProcentRachNaKonto { get; set; }

    public decimal UpzRachKwotaRachNaKonto { get; set; }

    public bool UpzDomyslny { get; set; }

    public int? UpzRachKategoria { get; set; }

    public int UpzUmowaGenerowanaDeklaracjaZus { get; set; }

    public bool UpzRachNaliczajFep { get; set; }

    public bool UpzUmowaOgraniczSumeRach { get; set; }

    public bool UpzRachKosztyAutorskie { get; set; }

    public bool UpzKontrolujStawkeMinimalna { get; set; }

    public bool UpzRachPodwojneOpodatkowanie { get; set; }

    public bool UpzRachPomniejszaniePodstawy { get; set; }

    public bool UpzRachZwolnienieZPodatku { get; set; }

    public bool UpzUmowaZgloszenieZusRud { get; set; }

    public bool UpzCzyNaliczacZaliczke { get; set; }

    public virtual PlbUmowaCpParametry UpzIdParametrowNavigation { get; set; } = null!;

    public virtual SlFormatNumeracji? UpzRachIdFmtNumeruNavigation { get; set; }

    public virtual SlKategorium? UpzRachKategoriaNavigation { get; set; }

    public virtual SlGratTrescDok? UpzRachTrescRachunkuNavigation { get; set; }

    public virtual SlFormatNumeracji? UpzUmowaIdFmtNumeruNavigation { get; set; }

    public virtual SlGratTrescDok? UpzUmowaIdTresciNavigation { get; set; }

    public virtual SlTytulUbezpieczenium? UpzUmowaTytulUbezpieczeniaNavigation { get; set; }
}
