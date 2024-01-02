using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class MkKoszt
{
    public int MkId { get; set; }

    public string MkNumer { get; set; } = null!;

    public string MkNazwa { get; set; } = null!;

    public DateTime MkData { get; set; }

    public string MkOpis { get; set; } = null!;

    public string MkDokZrodlowy { get; set; } = null!;

    public decimal? MkKwotaDokZrodl { get; set; }

    public decimal MkKwota { get; set; }

    public decimal? MkKwotaPoKorektach { get; set; }

    public DateTime? MkOkresOd { get; set; }

    public DateTime? MkOkresDo { get; set; }

    public int MkInterwal { get; set; }

    public int? MkLiczbaRat { get; set; }

    public int? MkIdKategoria { get; set; }

    public int? MkIdMpk { get; set; }

    public int MkStatusKsiegowy { get; set; }

    public string MkNrAnalityka { get; set; } = null!;

    public bool MkPlanRozliczenia { get; set; }

    public int MkStatus { get; set; }

    public virtual SlKategorium? MkIdKategoriaNavigation { get; set; }

    public virtual StMpk? MkIdMpkNavigation { get; set; }

    public virtual ICollection<MkKorektum> MkKorekta { get; set; } = new List<MkKorektum>();

    public virtual ICollection<MkPrzesuniecie> MkPrzesuniecies { get; set; } = new List<MkPrzesuniecie>();

    public virtual ICollection<MkRatum> MkRata { get; set; } = new List<MkRatum>();
}
