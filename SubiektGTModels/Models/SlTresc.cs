using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlTresc
{
    public int SltrId { get; set; }

    public string SltrTresc { get; set; } = null!;

    public virtual ICollection<ImSchematImportuPozDekretu> ImSchematImportuPozDekretus { get; set; } = new List<ImSchematImportuPozDekretu>();

    public virtual ICollection<ImSchematImportu> ImSchematImportuSiDokumIdTresciOperacjiNavigations { get; set; } = new List<ImSchematImportu>();

    public virtual ICollection<ImSchematImportu> ImSchematImportuSiEwidVatopisIdTresciOperacjiNavigations { get; set; } = new List<ImSchematImportu>();
}
