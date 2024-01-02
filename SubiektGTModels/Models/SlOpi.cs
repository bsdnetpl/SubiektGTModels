using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlOpi
{
    public int SopId { get; set; }

    public string SopOpis { get; set; } = null!;

    public virtual ICollection<ApAp> ApAps { get; set; } = new List<ApAp>();

    public virtual ICollection<ApZapisy> ApZapisies { get; set; } = new List<ApZapisy>();

    public virtual ICollection<ImSchematImportuPozDekretu> ImSchematImportuPozDekretus { get; set; } = new List<ImSchematImportuPozDekretu>();
}
