using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DfwFakturyWewnetrzne
{
    public int FwnId { get; set; }

    public int FwnTyp { get; set; }

    public int FwnPodtyp { get; set; }

    public int FwnMagId { get; set; }

    public int FwnNr { get; set; }

    public string? FwnNrRoz { get; set; }

    public string FwnNrPelny { get; set; } = null!;

    public int? FwnDoDokId { get; set; }

    public string FwnDoDokNrPelny { get; set; } = null!;

    public DateTime? FwnDoDokDataWyst { get; set; }

    public int? FwnKorId { get; set; }

    public string FwnKorNrPelny { get; set; } = null!;

    public DateTime? FwnKorDataWyst { get; set; }

    public string FwnMscWyst { get; set; } = null!;

    public DateTime FwnDataWyst { get; set; }

    public DateTime FwnDataSprz { get; set; }

    public int? FwnKhntId { get; set; }

    public int? FwnKhntAdreshId { get; set; }

    public decimal FwnWartNetto { get; set; }

    public decimal FwnWartVat { get; set; }

    public decimal FwnWartBrutto { get; set; }

    public string FwnWystawil { get; set; } = null!;

    public string FwnOdebral { get; set; } = null!;

    public int FwnPersonelId { get; set; }

    public int FwnStatus { get; set; }

    public int FwnStatusKsieg { get; set; }

    public int? FwnKatId { get; set; }

    public string FwnUwagi { get; set; } = null!;

    public string FwnTytul { get; set; } = null!;

    public string FwnPodtytul { get; set; } = null!;

    public int FwnRodzajOperacjiVat { get; set; }

    public int? FwnKodRodzajuTransakcji { get; set; }

    public int? FwnKontrolaTyp { get; set; }

    public int? FwnCenyPoziom { get; set; }

    public decimal FwnWartUsNetto { get; set; }

    public decimal FwnWartUsBrutto { get; set; }

    public decimal FwnWartTwNetto { get; set; }

    public decimal FwnWartTwBrutto { get; set; }

    public decimal FwnWartOpZwr { get; set; }

    public decimal FwnWartOpWyd { get; set; }

    public bool FwnJestVatAuto { get; set; }

    public int? FwnVatTyp { get; set; }

    public bool? FwnPodpisanoElektronicznie { get; set; }

    public string FwnNrPelnyOryg { get; set; } = null!;

    public bool FwnVatRozliczanyPrzezUslugobiorce { get; set; }

    public bool FwnPodlegaOplSpec { get; set; }

    public virtual ICollection<DfwPozycja> DfwPozycjas { get; set; } = new List<DfwPozycja>();

    public virtual ICollection<DfwVat> DfwVats { get; set; } = new List<DfwVat>();

    public virtual SlKategorium? FwnKat { get; set; }
}
