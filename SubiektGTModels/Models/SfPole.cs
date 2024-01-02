using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SfPole
{
    public int SfpId { get; set; }

    public int SfpIdSprawozdania { get; set; }

    public int SfpPoziom { get; set; }

    public string SfpEtykieta1 { get; set; } = null!;

    public string SfpEtykieta2 { get; set; } = null!;

    public string SfpEtykieta3 { get; set; } = null!;

    public string? SfpPrefix { get; set; }

    public bool SfpSumowane { get; set; }

    public bool SfpKorygujaco { get; set; }

    public bool SfpDefiniowalne { get; set; }

    public int SfpKolejnosc { get; set; }

    public int? SfpIdXmlDef { get; set; }

    public int SfpTyp { get; set; }

    public virtual ICollection<SfDefinicjaWzorzec> SfDefinicjaWzorzecs { get; set; } = new List<SfDefinicjaWzorzec>();

    public virtual ICollection<SfSprawozdanieZmiany> SfSprawozdanieZmianies { get; set; } = new List<SfSprawozdanieZmiany>();

    public virtual SfSprawozdanie SfpIdSprawozdaniaNavigation { get; set; } = null!;
}
