using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IsInstytucja
{
    public int IsId { get; set; }

    public string IsSymbol { get; set; } = null!;

    public int IsRodzaj { get; set; }

    public string IsWww { get; set; } = null!;

    public string IsEmail { get; set; } = null!;

    public string? IsNrAnalityka { get; set; }

    public int? IsRachunekPit { get; set; }

    public int? IsRachunekVat { get; set; }

    public int? IsRachunekCit { get; set; }

    public int? IsKodUs { get; set; }

    public bool IsFunduszPromocji { get; set; }

    public int? IsSposobNaliczania { get; set; }

    public decimal? IsWartoscNaliczenia { get; set; }

    public int? IsIdRachunkuWirtualnego { get; set; }

    public bool IsIzbaCelna { get; set; }

    public virtual ICollection<EdZfss> EdZfsses { get; set; } = new List<EdZfss>();

    public virtual RbRachBankowyWirtualny? IsIdRachunkuWirtualnegoNavigation { get; set; }

    public virtual SlUrzadSkarbowy? IsKodUsNavigation { get; set; }

    public virtual IsRodzajInstytucji IsRodzajNavigation { get; set; } = null!;

    public virtual ICollection<PdWspolnik> PdWspolniks { get; set; } = new List<PdWspolnik>();

    public virtual ICollection<PlbSkladnik> PlbSkladniks { get; set; } = new List<PlbSkladnik>();

    public virtual ICollection<PpkParametry> PpkParametries { get; set; } = new List<PpkParametry>();

    public virtual ICollection<PrPracownik> PrPracowniks { get; set; } = new List<PrPracownik>();
}
