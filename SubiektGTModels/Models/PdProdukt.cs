using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdProdukt
{
    public int EprId { get; set; }

    public string EprNazwa { get; set; } = null!;

    public int? EprLiczbaStanowisk { get; set; }

    public int EprStatusNowosci { get; set; }

    public virtual ICollection<PdUzytkownik> PfIdUzytkownikas { get; set; } = new List<PdUzytkownik>();
}
