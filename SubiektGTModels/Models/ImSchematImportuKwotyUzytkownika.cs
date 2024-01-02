using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImSchematImportuKwotyUzytkownika
{
    public int KusId { get; set; }

    public int KusIdSchematImportu { get; set; }

    public string KusNazwa { get; set; } = null!;

    public string KusOpis { get; set; } = null!;

    public virtual ICollection<ImSchematImportuPozDekretu> ImSchematImportuPozDekretus { get; set; } = new List<ImSchematImportuPozDekretu>();

    public virtual ImSchematImportu KusIdSchematImportuNavigation { get; set; } = null!;
}
