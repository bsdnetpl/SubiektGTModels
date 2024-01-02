using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImSchematImportuGrupaKontrahentum
{
    public int SigkId { get; set; }

    public int SigkIdSchematImportu { get; set; }

    public int SigkIdGrupaKontrahenta { get; set; }

    public virtual SlGrupaKh SigkIdGrupaKontrahentaNavigation { get; set; } = null!;

    public virtual ImSchematImportu SigkIdSchematImportuNavigation { get; set; } = null!;
}
