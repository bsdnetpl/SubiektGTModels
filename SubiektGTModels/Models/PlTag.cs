using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlTag
{
    public int TagId { get; set; }

    public string TagTekst { get; set; } = null!;

    public string TagTabela { get; set; } = null!;

    public string TagPole { get; set; } = null!;

    public int TagGrupa { get; set; }

    public int TagEkstra { get; set; }
}
