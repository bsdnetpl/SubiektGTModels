using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdPodmiot
{
    public int PdId { get; set; }

    public byte[]? PdObraz { get; set; }

    public int PdTypKsiegowosci { get; set; }

    public bool PdLicInneDane { get; set; }

    public string PdLicNazwaFirmy { get; set; } = null!;

    public string PdLicUlica { get; set; } = null!;

    public string PdLicKod { get; set; } = null!;

    public string PdLicMiejscowosc { get; set; } = null!;

    public int PdLicWojewodztwo { get; set; }

    public string PdLicNip { get; set; } = null!;

    public string PdLicTelefon { get; set; } = null!;

    public string PdLicFaks { get; set; } = null!;

    public string PdLicEmail { get; set; } = null!;

    public string PdLicOsobaOdp { get; set; } = null!;

    public bool PdLicUzInneDane { get; set; }

    public string PdLicUzKod { get; set; } = null!;

    public string PdLicUzMiejscowosc { get; set; } = null!;

    public string PdLicUzUlica { get; set; } = null!;

    public string PdLicUzTelefon { get; set; } = null!;

    public string PdLicUzOsobaOdp { get; set; } = null!;

    public bool? PdLicKorInneDane { get; set; }

    public string PdLicKorNazwa { get; set; } = null!;

    public string PdLicKorUlica { get; set; } = null!;

    public string PdLicKorKod { get; set; } = null!;

    public int PdLicKorWojewodztwo { get; set; }

    public string PdLicKorMiejscowosc { get; set; } = null!;

    public string PdLicKorOsobaOdp { get; set; } = null!;

    public string PdRegon { get; set; } = null!;

    public int? PdFormaPrawna { get; set; }

    public int? PdTypDzialalnosci { get; set; }

    public bool? PdDzHandlowa { get; set; }

    public bool? PdDzUslugowa { get; set; }

    public bool? PdDzProdukcyjna { get; set; }

    public int? PdRachBankowy { get; set; }

    public int? PdKasa { get; set; }

    public int? PdUrzSkarbowy { get; set; }

    public bool PdOsobaFizyczna { get; set; }

    public int? PdIdWlasciciela { get; set; }

    public string PdWww { get; set; } = null!;

    public string PdEmail { get; set; } = null!;

    public string PdOpisDzialalnosci { get; set; } = null!;

    public DateTime? PdDataRozpDzial { get; set; }

    public string PdOrganZaloz { get; set; } = null!;

    public string PdOrganRejestrowy { get; set; } = null!;

    public string PdNazwaRejestru { get; set; } = null!;

    public string PdNumerRejestru { get; set; } = null!;

    public DateTime? PdDataRejestracji { get; set; }

    public string PdKodEkd { get; set; } = null!;

    public string PdKodKgn { get; set; } = null!;

    public bool? PdPlatKarSprzedaz { get; set; }

    public bool? PdPlatKarZakup { get; set; }

    public bool? PdPlatOdrocz { get; set; }

    public DateTime? PdMiesiacPierwszejWyplaty { get; set; }

    public int? PdRokBoHopGrat { get; set; }

    public bool PdPodVatzarejestrowanyWue { get; set; }

    public string PdNipue { get; set; } = null!;

    public string PdNazwaDlaPlatnika { get; set; } = null!;

    public int PdTypKadr { get; set; }

    public byte[] PdInfoHtml { get; set; } = null!;

    public bool PdCrm { get; set; }

    public bool PdAnkDemo { get; set; }

    public int PdKlientEmail { get; set; }

    public bool PdDisableScripts { get; set; }

    public int? PdKatDkr { get; set; }

    public bool PdPlanKontWylaczAkt { get; set; }

    public bool PdAbonPokazDymki { get; set; }

    public int? PdEbankSaldo { get; set; }

    public int? PdKmr { get; set; }

    public int? PdDmn { get; set; }

    public bool PdLicCentrala { get; set; }

    public bool? PdTelemetriaZgoda { get; set; }

    public DateTime? PdTelemetriaZgodaPytano { get; set; }

    public bool PdKonto { get; set; }

    public int? PdLicIdGminy { get; set; }

    public bool? PdTelemetriaPlusZgoda { get; set; }

    public DateTime? PdTelemetriaPlusZgodaPytano { get; set; }

    public int? PdTypPdmAkcyzowego { get; set; }

    public string? PdNrPdmPosredniczacego { get; set; }

    public bool PdUzywajNipJakoNrAkcyzowy { get; set; }

    public string PdNrKrs { get; set; } = null!;

    public string PdNrBdo { get; set; } = null!;

    public bool PdCzyUstawionoDateRozpDzial { get; set; }

    public string? PdUtworzonoZpodmiotu { get; set; }

    public string? PdUtworzonoZbazy { get; set; }

    public int? PdRodzajZmianyFormyOpodatkowania { get; set; }

    public DateTime? PdDataRezygnacjiZryczaltu { get; set; }

    public bool? PdDaneDemo { get; set; }

    public virtual ICollection<PdDokument> PdDokuments { get; set; } = new List<PdDokument>();

    public virtual PdWspolnik? PdIdWlascicielaNavigation { get; set; }
}
