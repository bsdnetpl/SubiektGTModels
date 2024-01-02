using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RbRachBankowyWirtualny
{
    public int RbwId { get; set; }

    public int RbwIdRachunku { get; set; }

    public string RbwIdentyfikator { get; set; } = null!;

    public string RbwPelnyNumer { get; set; } = null!;

    public virtual ICollection<IsInstytucja> IsInstytucjas { get; set; } = new List<IsInstytucja>();

    public virtual ICollection<KhKontrahent> KhKontrahents { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<NzFinanse> NzFinanses { get; set; } = new List<NzFinanse>();

    public virtual ICollection<PdWspolnik> PdWspolniks { get; set; } = new List<PdWspolnik>();

    public virtual ICollection<PrPracownik> PrPracowniks { get; set; } = new List<PrPracownik>();

    public virtual ICollection<RbRachBankowyWirtualnyInstytucji> RbRachBankowyWirtualnyInstytucjis { get; set; } = new List<RbRachBankowyWirtualnyInstytucji>();

    public virtual ICollection<RbRachBankowyWirtualnyKontrahentum> RbRachBankowyWirtualnyKontrahenta { get; set; } = new List<RbRachBankowyWirtualnyKontrahentum>();

    public virtual ICollection<RbRachBankowyWirtualnyPracownika> RbRachBankowyWirtualnyPracownikas { get; set; } = new List<RbRachBankowyWirtualnyPracownika>();

    public virtual ICollection<RbRachBankowyWirtualnyWspolnika> RbRachBankowyWirtualnyWspolnikas { get; set; } = new List<RbRachBankowyWirtualnyWspolnika>();

    public virtual RbRachBankowy RbwIdRachunkuNavigation { get; set; } = null!;
}
