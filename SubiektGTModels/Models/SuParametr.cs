using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SuParametr
{
    public int SuId { get; set; }

    public int SuAlgorytm { get; set; }

    public bool SuKontrola { get; set; }

    public bool SuPlatOdr { get; set; }

    public bool SuKartaSpr { get; set; }

    public int? SuKartaSprId { get; set; }

    public bool SuKartaZak { get; set; }

    public int? SuKartaZakId { get; set; }

    public bool SuKredytSpr { get; set; }

    public int? SuKredytSprId { get; set; }

    public int? SuVatExId { get; set; }

    public decimal? SuVatExProc { get; set; }

    public int? SuVatZwId { get; set; }

    public decimal? SuVatZwProc { get; set; }

    public int? SuVatUjid { get; set; }

    public decimal? SuVatUjproc { get; set; }

    public int? SuRabat { get; set; }

    public int? SuVatUeid { get; set; }

    public decimal? SuVatUeproc { get; set; }

    public decimal? SuKursEur { get; set; }

    public int SuWizard { get; set; }

    public decimal SuMinMarza { get; set; }

    public int SuStatusDokSp { get; set; }

    public int SuStatusDokZak { get; set; }

    public int SuStatusDokWyd { get; set; }

    public int SuStatusDokPrz { get; set; }

    public int SuStatusDokMm { get; set; }

    public int SuStatusDokZk { get; set; }

    public int SuAutoDyspozycja { get; set; }

    public int? SuParamEwidId { get; set; }

    public bool SuPrzelewSpr { get; set; }

    public bool SuPrzelewZak { get; set; }

    public bool SuPrzedplataSpr { get; set; }

    public bool SuPrzedplataZak { get; set; }

    public bool SuPdpSprPodlaczajZal { get; set; }

    public bool SuPdpSprSplatyNiepowiazane { get; set; }

    public bool SuPdpZakPodlaczajZal { get; set; }

    public bool SuPdpZakSplatyNiepowiazane { get; set; }

    public bool SuWlaczBlokadeKk { get; set; }

    public bool SuPrzejsciowyVatzaliczki { get; set; }

    public bool SuNaliczajVatfaktWewn { get; set; }

    public int? SuVatOoid { get; set; }

    public decimal? SuVatOoproc { get; set; }

    public bool SuPodpisPdf { get; set; }

    public bool SuPodpisEpp { get; set; }

    public string? SuPodpisSkrot { get; set; }

    public string? SuPodpisOpis { get; set; }

    public string? SuPodpisPin { get; set; }

    public int SuFoPlNaPoprDok { get; set; }

    public bool SuFoPlNaPoprZam { get; set; }

    public bool SuPokazDokDost { get; set; }

    public int SuAutoDyspozZk { get; set; }

    public string? SuSynchronizatorNazwaKomputera { get; set; }

    public bool SuMarzaNieKoloruj { get; set; }

    public int SuFakturyMieszane { get; set; }

    public int? SuVatSptkid { get; set; }

    public decimal? SuVatSptkproc { get; set; }

    public bool SuWymagajPrzyczynyKorekty { get; set; }

    public byte[]? SuPozycjeWklej { get; set; }

    public byte[]? SuPozycjeWklejSpecjalne { get; set; }

    public bool SuIgnorujBlokadeMagSs { get; set; }

    public bool SuIgnorujMoozLimitami { get; set; }

    public bool SuPromocjaCzasOtwarciaDokum { get; set; }

    public int SuStraznikRezerwacjiKontrola { get; set; }

    public int SuStraznikRezerwacjiTryb { get; set; }

    public int SuStraznikRezerwacjiTypDaty { get; set; }

    public bool SuWlaczBlokadeRfp { get; set; }

    public int SuOplatyRecyklingowe { get; set; }

    public int SuPodsumowanieDokRozmiar { get; set; }

    public bool SuDokUkryjNieaktywneStawkiVat { get; set; }

    public int SuWlaczMarketInsert { get; set; }

    public bool SuWlaczBlokadeNz { get; set; }

    public int SuPanstwoWysylkiWsto { get; set; }

    public bool SuWstowszystkieWaluty { get; set; }

    public bool SuLimitPlatnosciGotowka { get; set; }

    public bool SuWegielObslugaOswiadczenPochodzenia { get; set; }

    public int SuWegielOswiadczenieIdNumeracji { get; set; }

    public bool SuOplSpecObslugaOznaczaniaDok { get; set; }

    public virtual ParEwid? SuParamEwid { get; set; }

    public virtual SlStawkaVat? SuVatEx { get; set; }

    public virtual SlStawkaVat? SuVatUe { get; set; }

    public virtual SlStawkaVat? SuVatUj { get; set; }

    public virtual SlStawkaVat? SuVatZw { get; set; }

    public virtual SlFormatNumeracji SuWegielOswiadczenieIdNumeracjiNavigation { get; set; } = null!;
}
