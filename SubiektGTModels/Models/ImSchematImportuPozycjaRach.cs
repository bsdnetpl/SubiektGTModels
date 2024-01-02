using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImSchematImportuPozycjaRach
{
    public int SirId { get; set; }

    public int SirIdSchematImportu { get; set; }

    public int SirKolumna { get; set; }

    public int SirImportWartosci { get; set; }

    public virtual ImSchematImportu SirIdSchematImportuNavigation { get; set; } = null!;
}
