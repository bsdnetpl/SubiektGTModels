using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class StMpk
{
    public int StmId { get; set; }

    public string StmNazwa { get; set; } = null!;

    public string StmNrAnalityka { get; set; } = null!;

    public string? StmSymbol { get; set; }

    public virtual ICollection<KwPozycja> KwPozycjas { get; set; } = new List<KwPozycja>();

    public virtual ICollection<MkKoszt> MkKoszts { get; set; } = new List<MkKoszt>();

    public virtual ICollection<MkPrzesuniecie> MkPrzesuniecies { get; set; } = new List<MkPrzesuniecie>();

    public virtual ICollection<PlbSkladnik> PlbSkladniks { get; set; } = new List<PlbSkladnik>();

    public virtual ICollection<StOperacja> StOperacjas { get; set; } = new List<StOperacja>();

    public virtual ICollection<StSrodekTrwalyDane> StSrodekTrwalyDanes { get; set; } = new List<StSrodekTrwalyDane>();

    public virtual ICollection<ZlpZlecenie> ZlpZlecenies { get; set; } = new List<ZlpZlecenie>();
}
