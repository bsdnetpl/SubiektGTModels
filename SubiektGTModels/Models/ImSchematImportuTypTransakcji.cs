using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImSchematImportuTypTransakcji
{
    public int SitId { get; set; }

    public int SitIdSchematImportu { get; set; }

    public int SitTypTransakcji { get; set; }

    public virtual ImSchematImportu SitIdSchematImportuNavigation { get; set; } = null!;
}
