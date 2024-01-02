using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImSchematImportuOznaczeniaJpkVat
{
    public int SijvId { get; set; }

    public int SijvIdSchematImportu { get; set; }

    public string SijvNazwa { get; set; } = null!;

    public int SijvTyp { get; set; }

    public virtual ImSchematImportu SijvIdSchematImportuNavigation { get; set; } = null!;
}
