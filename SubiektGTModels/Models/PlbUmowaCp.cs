using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowaCp
{
    public int UcpId { get; set; }

    public int UcpIdPracownika { get; set; }

    public string UcpNumer { get; set; } = null!;

    public int UcpRodzajUmowy { get; set; }

    public int UcpNaCzas { get; set; }

    public DateTime UcpDataOd { get; set; }

    public DateTime? UcpDataDo { get; set; }

    public bool UcpRozwiazana { get; set; }

    public DateTime? UcpDataRozwiazania { get; set; }

    public int? UcpIdPrzyczynaRozwiazania { get; set; }

    public string UcpTytul { get; set; } = null!;

    public string UcpSzczegoly { get; set; } = null!;

    public decimal UcpKwota { get; set; }

    public bool UcpSkladkaUbezpEm { get; set; }

    public bool UcpSkladkaUbezpRe { get; set; }

    public bool UcpSkladkaUbezpChor { get; set; }

    public bool UcpSkladkaUbezpWyp { get; set; }

    public bool UcpSkladkaUbezpZdr { get; set; }

    public bool UcpSkladkaFp { get; set; }

    public bool UcpSkladkaFgsp { get; set; }

    public string UcpZustytulUbezpieczenia { get; set; } = null!;

    public string? UcpZuskodZawodu { get; set; }

    public string? UcpZuskodPracySzczegCharakter { get; set; }

    public DateTime? UcpPracaSzczegCharOkresOd { get; set; }

    public DateTime? UcpPracaSzczegCharOkresDo { get; set; }

    public int UcpGenerowanaDeklaracjaZus { get; set; }

    public int UcpPrzelewRachNaKonto { get; set; }

    public decimal UcpProcentRachNaKonto { get; set; }

    public decimal UcpKwotaRachNaKonto { get; set; }

    public int? UcpIdRachBankowyPracownika { get; set; }

    public int? UcpIdSzablonuUmowy { get; set; }

    public byte[]? UcpSzablonUmowy { get; set; }

    public bool UcpSzablonUmowyIndywidualny { get; set; }

    public int? UcpIdFmtNumeracjiRachunkow { get; set; }

    public int UcpRodzajPrzychodu { get; set; }

    public int? UcpIdSzablonuRachunku { get; set; }

    public decimal UcpZryczaltowanyPodatek { get; set; }

    public int UcpKosztyUzyskaniaMetoda { get; set; }

    public decimal UcpKosztyUzyskaniaKwota { get; set; }

    public decimal UcpKosztyUzyskaniaProcent { get; set; }

    public int? UcpIdDzialu { get; set; }

    public int? UcpRachKategoria { get; set; }

    public bool UcpOgraniczKwoteRachunkow { get; set; }

    public bool UcpSkladkaFep { get; set; }

    public bool UcpNieOgraniczajKwotyChorobowego { get; set; }

    public bool UcpKosztyAutorskie { get; set; }

    public bool UcpNieOgraniczajKwotyZdrowotnego { get; set; }

    public bool UcpNiePomniejszajPodstawyOpodatkowania { get; set; }

    public int UcpCzasOczekNaZasChorob { get; set; }

    public bool UcpUnikaniePodwojnegoOpodatkowania { get; set; }

    public int? UcpIdSlownikZawodu { get; set; }

    public bool UcpNieKontrolujSkladek { get; set; }

    public bool UcpKontrolujStawkeMinimalna { get; set; }

    public DateTime? UcpDataZawarcia { get; set; }

    public bool UcpCzyLiczycAutoFp { get; set; }

    public bool UcpZwolnienieZpodatku { get; set; }

    public bool UcpZgloszenieZusRud { get; set; }

    public int? UcpIdDeklaracjiZusRud { get; set; }

    public bool UcpCzyNaliczacZaliczke { get; set; }

    public bool UcpCzyOdraczacPoborZaliczki { get; set; }

    public bool UcpCzyOdliczacUlge { get; set; }

    public int UcpWymiarUlgiPodatkowej { get; set; }

    public int UcpNaliczanieZaliczki { get; set; }

    public virtual ICollection<KpAkord> KpAkords { get; set; } = new List<KpAkord>();

    public virtual ICollection<KpProwizja> KpProwizjas { get; set; } = new List<KpProwizja>();

    public virtual ICollection<PlbUmowaCpgodzPrzepr> PlbUmowaCpgodzPrzeprs { get; set; } = new List<PlbUmowaCpgodzPrzepr>();

    public virtual ICollection<PlbUmowaCpprzelewy> PlbUmowaCpprzelewies { get; set; } = new List<PlbUmowaCpprzelewy>();

    public virtual SlDzial? UcpIdDzialuNavigation { get; set; }

    public virtual SlFormatNumeracji? UcpIdFmtNumeracjiRachunkowNavigation { get; set; }

    public virtual SlGratPrzyczynaRozwUmowy? UcpIdPrzyczynaRozwiazaniaNavigation { get; set; }

    public virtual SlGratTrescDok? UcpIdSzablonuRachunkuNavigation { get; set; }

    public virtual SlGratTrescDok? UcpIdSzablonuUmowyNavigation { get; set; }

    public virtual SlKategorium? UcpRachKategoriaNavigation { get; set; }

    public virtual SlTytulUbezpieczenium UcpZustytulUbezpieczeniaNavigation { get; set; } = null!;
}
