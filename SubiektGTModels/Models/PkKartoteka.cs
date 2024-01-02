using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PkKartoteka
{
    public int KwId { get; set; }

    public int KwTyp { get; set; }

    public int? KwIdZrodla { get; set; }

    public string KwNazwa { get; set; } = null!;

    public bool KwZablokowana { get; set; }

    public int KwDlugoscAnalityki { get; set; }

    public bool KwWbudowana { get; set; }

    public bool? KwFiltruj1 { get; set; }

    public bool? KwFiltruj2 { get; set; }

    public bool? KwFiltruj3 { get; set; }

    public int? KwFiltr1 { get; set; }

    public int? KwFiltr2 { get; set; }

    public int? KwFiltr3 { get; set; }

    public bool? KwFiltrujSql { get; set; }

    public string? KwFiltrSql { get; set; }

    public virtual ICollection<ImSchematImportuAnalitykiKp> ImSchematImportuAnalitykiKps { get; set; } = new List<ImSchematImportuAnalitykiKp>();

    public virtual ICollection<PkKartotekaPozycja> PkKartotekaPozycjas { get; set; } = new List<PkKartotekaPozycja>();

    public virtual ICollection<PkPlanKont> PkPlanKontKoIdBiezacejKartotekiNavigations { get; set; } = new List<PkPlanKont>();

    public virtual ICollection<PkPlanKont> PkPlanKontKoIdKartoteki01Navigations { get; set; } = new List<PkPlanKont>();

    public virtual ICollection<PkPlanKont> PkPlanKontKoIdKartoteki02Navigations { get; set; } = new List<PkPlanKont>();

    public virtual ICollection<PkPlanKont> PkPlanKontKoIdKartoteki03Navigations { get; set; } = new List<PkPlanKont>();

    public virtual ICollection<PkPlanKont> PkPlanKontKoIdKartoteki04Navigations { get; set; } = new List<PkPlanKont>();

    public virtual ICollection<PkPlanKont> PkPlanKontKoIdKartoteki05Navigations { get; set; } = new List<PkPlanKont>();

    public virtual ICollection<PkPlanKont> PkPlanKontKoIdKartotekiNavigations { get; set; } = new List<PkPlanKont>();

    public virtual ICollection<PkPlanKont> PkPlanKontKoRozrachObjTypNavigations { get; set; } = new List<PkPlanKont>();

    public virtual ICollection<PkWzorzec> PkWzorzecs { get; set; } = new List<PkWzorzec>();
}
