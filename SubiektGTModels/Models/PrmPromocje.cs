using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrmPromocje
{
    public int PrmId { get; set; }

    public int PrmTyp { get; set; }

    public string? PrmNazwa { get; set; }

    public string? PrmNazwaPelna { get; set; }

    public bool? PrmNieaktywna { get; set; }

    public int? PrmPriorytet { get; set; }

    public DateTime? PrmOd { get; set; }

    public DateTime? PrmDo { get; set; }

    public bool PrmOgraniczonaCzasowo { get; set; }

    public int PrmInterwal { get; set; }

    public bool PrmCalyDzien { get; set; }

    public bool PrmRobocze { get; set; }

    public DateTime? PrmPoczatekZcyklu { get; set; }

    public int PrmCoIle { get; set; }

    public int PrmDniTygodnia { get; set; }

    public int PrmDzienMiesiaca { get; set; }

    public bool? PrmDefinicjaZlozona { get; set; }

    public int PrmDzienPorzadek { get; set; }

    public int PrmDzienRodzaj { get; set; }

    public int PrmMiesiac { get; set; }

    public int PrmRodzajPowtorzen { get; set; }

    public int PrmIlePowtorzen { get; set; }

    public DateTime? PrmKoniecPowtorzen { get; set; }

    public bool PrmIlePowtorzenWdniach { get; set; }

    public bool PrmKumulujeSie { get; set; }

    public bool PrmKrytMag { get; set; }

    public bool PrmKrytKh { get; set; }

    public bool PrmKrytTw { get; set; }

    public bool PrmKrytDok { get; set; }

    public bool PrmKrytKhLista { get; set; }

    public bool PrmKrytKhGrupy { get; set; }

    public bool PrmKrytKhCechy { get; set; }

    public bool PrmKrytKhSql { get; set; }

    public string? PrmKrytKhSqlquery { get; set; }

    public bool PrmKrytKhAndOr { get; set; }

    public bool PrmKrytTwLista { get; set; }

    public bool PrmKrytTwListaDowolny { get; set; }

    public bool PrmKrytTwGrupy { get; set; }

    public bool PrmKrytTwCechy { get; set; }

    public bool PrmKrytTwSql { get; set; }

    public string? PrmKrytTwSqlquery { get; set; }

    public bool PrmKrytTwAndOr { get; set; }

    public int PrmKrytDokTypWartosci { get; set; }

    public decimal PrmKrytDokWartosc { get; set; }

    public decimal? PrmKrytKhObrotOstMies { get; set; }

    public string? PrmKrytKhMaskaKoduPoczt { get; set; }

    public decimal? PrmKrytTwStProcWyzszyStMin { get; set; }

    public bool PrmKrytTwPowyzejStMin { get; set; }

    public decimal? PrmKrytTwStWartWyzszyStMin { get; set; }

    public decimal? PrmKrytTwWartTwNaDokumencie { get; set; }

    public bool PrmKrytTwWartTwNaDokumencieOsobno { get; set; }

    public decimal? PrmKrytTwIloscTwNaDokumencie { get; set; }

    public bool PrmKrytTwIloscTwNaDokumencieOsobno { get; set; }

    public int PrmKrytDokNpierwszychKh { get; set; }

    public int? PrmKrytDokTypFormyPlatnosci { get; set; }

    public int? PrmKrytDokIdPlatnosci { get; set; }

    public bool PrmAkcjaCenyTyp { get; set; }

    public decimal? PrmAkcjaProcent { get; set; }

    public decimal? PrmAkcjaKwota { get; set; }

    public int? PrmAkcjaCoNty { get; set; }

    public decimal? PrmAkcjaIlosc { get; set; }

    public int PrmAkcjaCenaRodzaj { get; set; }

    public decimal? PrmAkcjaCena { get; set; }

    public int? PrmAkcjaTowaryTyp { get; set; }

    public bool PrmAkcjaTwLista { get; set; }

    public bool PrmAkcjaTwGrupy { get; set; }

    public bool PrmAkcjaTwCechy { get; set; }

    public bool PrmAkcjaTwSql { get; set; }

    public string? PrmAkcjaTwSqlquery { get; set; }

    public bool PrmAkcjaTwAndOr { get; set; }

    public decimal? PrmAkcjaTwStProcWyzszyStMin { get; set; }

    public bool PrmAkcjaTwPowyzejStMin { get; set; }

    public decimal? PrmAkcjaTwStWartWyzszyStMin { get; set; }

    public decimal? PrmAkcjaTwWartTwNaDokumencie { get; set; }

    public bool PrmAkcjaTwWartTwNaDokumencieOsobno { get; set; }

    public decimal? PrmAkcjaTwIloscTwNaDokumencie { get; set; }

    public bool PrmAkcjaTwIloscTwNaDokumencieOsobno { get; set; }

    public virtual ICollection<PrmPromocjeAkcja> PrmPromocjeAkcjas { get; set; } = new List<PrmPromocjeAkcja>();

    public virtual ICollection<PrmPromocjeKontrahent> PrmPromocjeKontrahents { get; set; } = new List<PrmPromocjeKontrahent>();

    public virtual ICollection<PrmPromocjeMagazyn> PrmPromocjeMagazyns { get; set; } = new List<PrmPromocjeMagazyn>();

    public virtual ICollection<PrmPromocjeTowar> PrmPromocjeTowars { get; set; } = new List<PrmPromocjeTowar>();
}
