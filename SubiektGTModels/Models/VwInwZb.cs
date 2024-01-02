using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwInwZb
{
    public int IwId { get; set; }

    public int IwTyp { get; set; }

    public int IwMagId { get; set; }

    public string? IwDoIwNrPelny { get; set; }

    public int IwStatus { get; set; }

    public int? IwNr { get; set; }

    public string? IwNrRoz { get; set; }

    public string IwNrPelny { get; set; } = null!;

    public bool IwStatusBlok { get; set; }

    public DateTime IwDataWyst { get; set; }

    public string IwMiejsceWyst { get; set; } = null!;

    public DateTime? IwDataZatw { get; set; }

    public DateTime? IwDataMag { get; set; }

    public decimal IwWartosc { get; set; }

    public string IwWystawil { get; set; } = null!;

    public string IwZatwierdzil { get; set; } = null!;

    public int? IwKatId { get; set; }

    public string IwTytul { get; set; } = null!;

    public string IwPodtytul { get; set; } = null!;

    public int? IwPwId { get; set; }

    public string? IwPwNrPelny { get; set; }

    public int? IwRwId { get; set; }

    public string? IwRwNrPelny { get; set; }

    public string IwUwagi { get; set; } = null!;

    public int? IwCenyPoziom { get; set; }

    public decimal IwCenyNarzut { get; set; }

    public bool IwFiltrCheckRodzaje { get; set; }

    public int IwFiltrRodzaje { get; set; }

    public bool IwFiltrCheckStan { get; set; }

    public int IwFiltrStan { get; set; }

    public bool IwFiltrCheckPlu { get; set; }

    public int? IwFiltrPluod { get; set; }

    public int? IwFiltrPludo { get; set; }

    public bool IwFiltrCheckGrupa { get; set; }

    public bool? IwFiltrCheckCecha { get; set; }

    public bool IwFiltrCheckFlaga { get; set; }

    public int? IwIdIwcRaport { get; set; }

    public int? IwCenyIdBanku { get; set; }

    public decimal? IwCenyKurs { get; set; }

    public DateTime? IwCenyKursData { get; set; }

    public bool IwStatusMagOdlozony { get; set; }

    public int IwCenyLiczbaJedn { get; set; }

    public int? IwCenyRodzajKursu { get; set; }

    public bool? IwPodpisanoElektronicznie { get; set; }

    public int? IwPersonelId { get; set; }

    public DateTime? SsDataZamkniecia { get; set; }

    public DateTime? SsDataBlokadyRach { get; set; }
}
