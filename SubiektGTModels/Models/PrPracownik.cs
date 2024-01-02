using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrPracownik
{
    public int PrId { get; set; }

    public string PrImie { get; set; } = null!;

    public string PrImie2 { get; set; } = null!;

    public string PrNazwisko { get; set; } = null!;

    public string PrNazwiskoRodowe { get; set; } = null!;

    public string PrEmail { get; set; } = null!;

    public DateTime PrDataObowiazywania { get; set; }

    public DateTime PrDataUrodzenia { get; set; }

    public string PrMiejsceUrodzenia { get; set; } = null!;

    public string PrImieOjca { get; set; } = null!;

    public string PrImieMatki { get; set; } = null!;

    public int? PrIdStanuCywilnego { get; set; }

    public int? PrPlec { get; set; }

    public string PrObywatelstwo { get; set; } = null!;

    public string? PrTypIdentyfikatora { get; set; }

    public string PrDtnr { get; set; } = null!;

    public string PrDtwydanyPrzez { get; set; } = null!;

    public DateTime? PrDtdataWydania { get; set; }

    public int PrRodzajUbezp { get; set; }

    public string? PrPrawoDoEmer { get; set; }

    public string? PrStopienNiepelnosprawnosci { get; set; }

    public string PrNip { get; set; } = null!;

    public string PrPesel { get; set; } = null!;

    public int? PrIdUrzeduSkarbowego { get; set; }

    public int? PrIdGrupy { get; set; }

    public string? PrNrAnalityki { get; set; }

    public bool PrUzywajAdresKorespondencyjny { get; set; }

    public string PrNazwiskoRodoweMatki { get; set; } = null!;

    public string PrNarodowosc { get; set; } = null!;

    public bool PrAktywny { get; set; }

    public bool PrUzywajAdresZameldowania { get; set; }

    public string PrWww { get; set; } = null!;

    public DateTime? PrStNiepelnosprawnosciDataOd { get; set; }

    public DateTime? PrStNiepelnosprawnosciDataDo { get; set; }

    public string? PrStopienNiezdolnosciDoPracy { get; set; }

    public DateTime? PrStNiezdolnosciDataOd { get; set; }

    public DateTime? PrStNiezdolnosciDataDo { get; set; }

    public bool PrKartaPobytuStalego { get; set; }

    public bool PrKartaPobytuCzasowego { get; set; }

    public bool PrRozliczanieZmalzonkiem { get; set; }

    public string? PrOddzialNfz { get; set; }

    public DateTime? PrDataPrzystapieniaDoNfz { get; set; }

    public bool PrGospodarstwoZpracodawca { get; set; }

    public string? PrPokrewienstwoZpracodawca { get; set; }

    public string? PrWyksztalcenie { get; set; }

    public string PrZawodWyuczony { get; set; } = null!;

    public string PrUkonczonaSzkola { get; set; } = null!;

    public int? PrRokUkonczeniaSzkoly { get; set; }

    public int? PrLiczbaLatNauki { get; set; }

    public string PrObowiazekObrony { get; set; } = null!;

    public string PrWku { get; set; } = null!;

    public string PrStopienWojskowy { get; set; } = null!;

    public string PrNrKsiazeczkiWojskowej { get; set; } = null!;

    public string PrNrSpecjalnosciWojskowej { get; set; } = null!;

    public bool PrDaneOsobowePrzetwarzanie { get; set; }

    public bool PrDaneOsoboweMarketing { get; set; }

    public int? PrIdRachunkuWirtualnego { get; set; }

    public int PrDniDodatkowyUrlop { get; set; }

    public int PrIdentyfikacjaPodatkowa { get; set; }

    public int PrIdentyfikacjaPodatkowaMal { get; set; }

    public DateTime? PrZwolnienieZeSkladekFpiFgspod { get; set; }

    public DateTime? PrZwolnienieZeSkladekFpiFgspdo { get; set; }

    public bool PrNieOgraniczajKosztyAutorskie { get; set; }

    public DateTime? PrDataUkonczeniaSzkoly { get; set; }

    public bool PrPomijajPoprzOkrZatrWfirmie { get; set; }

    public int PrTypIdentyfikatoraDlaCudzoziemcow { get; set; }

    public string PrDtnrDlaCudzoziemcow { get; set; } = null!;

    public bool PrSzczegolneSchorzenia { get; set; }

    public bool PrZwolnienieZpodatku { get; set; }

    public int? PrIdObywatelstwa { get; set; }

    public virtual ICollection<EcpBlokadum> EcpBlokada { get; set; } = new List<EcpBlokadum>();

    public virtual ICollection<EdZfss> EdZfsses { get; set; } = new List<EdZfss>();

    public virtual ICollection<KpKomornikPozyczkaDefinicja> KpKomornikPozyczkaDefinicjas { get; set; } = new List<KpKomornikPozyczkaDefinicja>();

    public virtual ICollection<KwKartum> KwKarta { get; set; } = new List<KwKartum>();

    public virtual ICollection<PdUzytkownik> PdUzytkowniks { get; set; } = new List<PdUzytkownik>();

    public virtual ICollection<PlUmowaCp> PlUmowaCps { get; set; } = new List<PlUmowaCp>();

    public virtual ICollection<PlUmowaOprace> PlUmowaOpraces { get; set; } = new List<PlUmowaOprace>();

    public virtual ICollection<PlWyplataDataZaliczki> PlWyplataDataZaliczkis { get; set; } = new List<PlWyplataDataZaliczki>();

    public virtual ICollection<PlbPracownikZespol> PlbPracownikZespols { get; set; } = new List<PlbPracownikZespol>();

    public virtual ICollection<PprBlokadum> PprBlokada { get; set; } = new List<PprBlokadum>();

    public virtual ICollection<PprPlanPracy> PprPlanPracies { get; set; } = new List<PprPlanPracy>();

    public virtual ICollection<PrBadaniaOkresowe> PrBadaniaOkresowes { get; set; } = new List<PrBadaniaOkresowe>();

    public virtual ICollection<PrBo> PrBos { get; set; } = new List<PrBo>();

    public virtual ICollection<PrCechaPr> PrCechaPrs { get; set; } = new List<PrCechaPr>();

    public virtual ICollection<PrDokument> PrDokuments { get; set; } = new List<PrDokument>();

    public virtual ICollection<PrGiodo> PrGiodos { get; set; } = new List<PrGiodo>();

    public virtual SlGrupaPrac? PrIdGrupyNavigation { get; set; }

    public virtual SlObywatelstwo? PrIdObywatelstwaNavigation { get; set; }

    public virtual RbRachBankowyWirtualny? PrIdRachunkuWirtualnegoNavigation { get; set; }

    public virtual SlStanCywilny? PrIdStanuCywilnegoNavigation { get; set; }

    public virtual IsInstytucja? PrIdUrzeduSkarbowegoNavigation { get; set; }

    public virtual ICollection<PrInneDochody> PrInneDochodies { get; set; } = new List<PrInneDochody>();

    public virtual ICollection<PrJezyki> PrJezykis { get; set; } = new List<PrJezyki>();

    public virtual ICollection<PrKosztyZprawAutorskich> PrKosztyZprawAutorskiches { get; set; } = new List<PrKosztyZprawAutorskich>();

    public virtual ICollection<PrKursy> PrKursies { get; set; } = new List<PrKursy>();

    public virtual ICollection<PrKursyBhp> PrKursyBhps { get; set; } = new List<PrKursyBhp>();

    public virtual ICollection<PrMotywacja> PrMotywacjas { get; set; } = new List<PrMotywacja>();

    public virtual SlOddzialNfz? PrOddzialNfzNavigation { get; set; }

    public virtual ICollection<PrOrganizacje> PrOrganizacjes { get; set; } = new List<PrOrganizacje>();

    public virtual ICollection<PrParametry> PrParametries { get; set; } = new List<PrParametry>();

    public virtual ICollection<PrParametryWplatPpk> PrParametryWplatPpks { get; set; } = new List<PrParametryWplatPpk>();

    public virtual SlPokrewienstwo? PrPokrewienstwoZpracodawcaNavigation { get; set; }

    public virtual ICollection<PrPpk> PrPpks { get; set; } = new List<PrPpk>();

    public virtual SlPrawoDoEmerytury? PrPrawoDoEmerNavigation { get; set; }

    public virtual ICollection<PrRezygnacjaPpk> PrRezygnacjaPpks { get; set; } = new List<PrRezygnacjaPpk>();

    public virtual ICollection<PrRodzina> PrRodzinas { get; set; } = new List<PrRodzina>();

    public virtual SlStopienNiepelnosprawnosci? PrStopienNiepelnosprawnosciNavigation { get; set; }

    public virtual SlStopienNiezdolnosciDoPracy? PrStopienNiezdolnosciDoPracyNavigation { get; set; }

    public virtual SlTypIdentyfikatora? PrTypIdentyfikatoraNavigation { get; set; }

    public virtual ICollection<PrUlgi> PrUlgis { get; set; } = new List<PrUlgi>();

    public virtual ICollection<PrUprawnienium> PrUprawnienia { get; set; } = new List<PrUprawnienium>();

    public virtual ICollection<PrUrlopy> PrUrlopies { get; set; } = new List<PrUrlopy>();

    public virtual SlWyksztalcenie? PrWyksztalcenieNavigation { get; set; }

    public virtual ICollection<PrZatrudnienie> PrZatrudnienies { get; set; } = new List<PrZatrudnienie>();

    public virtual ICollection<PrZdjecie> PrZdjecies { get; set; } = new List<PrZdjecie>();

    public virtual ICollection<PrZwolnienieZpodatku> PrZwolnienieZpodatkus { get; set; } = new List<PrZwolnienieZpodatku>();

    public virtual ICollection<RbRachBankowyWirtualnyPracownika> RbRachBankowyWirtualnyPracownikas { get; set; } = new List<RbRachBankowyWirtualnyPracownika>();
}
