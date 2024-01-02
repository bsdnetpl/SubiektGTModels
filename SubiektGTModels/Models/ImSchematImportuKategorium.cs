using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImSchematImportuKategorium
{
    public int SikId { get; set; }

    public int SikIdSchematImportu { get; set; }

    public int? SikIdKategorii { get; set; }

    public virtual SlKategorium? SikIdKategoriiNavigation { get; set; }

    public virtual ImSchematImportu SikIdSchematImportuNavigation { get; set; } = null!;
}
