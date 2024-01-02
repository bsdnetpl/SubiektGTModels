using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImSchematImportuCechaKontrahentum
{
    public int SickId { get; set; }

    public int SickIdSchematImportu { get; set; }

    public int SickIdCechaKontrahenta { get; set; }

    public virtual SlCechaKh SickIdCechaKontrahentaNavigation { get; set; } = null!;

    public virtual ImSchematImportu SickIdSchematImportuNavigation { get; set; } = null!;
}
