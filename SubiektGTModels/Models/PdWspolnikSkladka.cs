using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdWspolnikSkladka
{
    public int PwsId { get; set; }

    public int PwsIdWspolnika { get; set; }

    public int PwsRok { get; set; }

    public int PwsMiesiac { get; set; }

    public decimal PwsPodstawaEmRe { get; set; }

    public decimal PwsPodstawaChWy { get; set; }

    public decimal PwsPodstawaZdr { get; set; }

    public bool PwsPodstawaEmRePrzekroczona { get; set; }

    public decimal PwsSkladkaEm { get; set; }

    public decimal PwsSkladkaRe { get; set; }

    public decimal PwsSkladkaChor { get; set; }

    public decimal PwsSkladkaWyp { get; set; }

    public decimal? PwsSkladkiSpol { get; set; }

    public decimal PwsSkladkaFp { get; set; }

    public decimal PwsSkladkaZdr1 { get; set; }

    public decimal PwsSkladkaZdr2 { get; set; }

    public decimal PwsSkladkaZdr3 { get; set; }

    public decimal? PwsSkladkaRazem { get; set; }

    public int PwsStatusKsiegowy { get; set; }

    public int? PwsIdKsiegi { get; set; }

    public int? PwsIdDekretu { get; set; }

    public DateTime? PwsDataKsiegowania { get; set; }

    public int? PwsIdKategorii { get; set; }

    public decimal? PwsSkladkaRazemSpolFp { get; set; }

    public decimal? PwsRazemZdr { get; set; }

    public bool PwsZaplacono { get; set; }

    public DateTime? PwsDataZaplaty { get; set; }

    public int? PwsZaksiegowaneSkladki { get; set; }

    public int? PwsFormaPrawna { get; set; }

    public decimal? PwsSumaPrzychodow { get; set; }

    public bool? PwsRozlicznieWedlugPrzychZzeszlegoRoku { get; set; }

    public decimal? PwsKwotaPrzychodowZzeszlegoRoku { get; set; }

    public decimal? PwsKwotaDochoduZpoprzedniegoMiesiaca { get; set; }

    public int? PwsIdWspOsWspolpracujacej { get; set; }

    public bool PwsMozliwoscEdycjiWspolnika { get; set; }

    public int PwsRodzajNaliczenia { get; set; }

    public decimal? PwsRocznaKwotaDochodu { get; set; }

    public decimal? PwsRocznaKwotaPodatkuNaleznego { get; set; }

    public decimal? PwsRocznaPodstawaSkladkiZdrowotnej { get; set; }

    public decimal? PwsRocznaSkladkaZdrowotna { get; set; }

    public decimal? PwsSumaMiesiecznychNaleznychZaliczek { get; set; }

    public decimal? PwsKwotaDoDoplaty { get; set; }

    public decimal? PwsKwotaDoZwrotu { get; set; }

    public int PwsTrybNaliczenia { get; set; }

    public virtual SlKategorium? PwsIdKategoriiNavigation { get; set; }

    public virtual PdWspolnik? PwsIdWspOsWspolpracujacejNavigation { get; set; }

    public virtual PdWspolnik PwsIdWspolnikaNavigation { get; set; } = null!;
}
