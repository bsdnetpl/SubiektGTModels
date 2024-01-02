using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImSchematImportuKontrahent
{
    public int SikhId { get; set; }

    public int SikhIdSchematImportu { get; set; }

    public int SikhIdKontrahent { get; set; }

    public virtual KhKontrahent SikhIdKontrahentNavigation { get; set; } = null!;

    public virtual ImSchematImportu SikhIdSchematImportuNavigation { get; set; } = null!;
}
