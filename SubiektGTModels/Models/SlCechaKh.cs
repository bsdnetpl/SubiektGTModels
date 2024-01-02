using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlCechaKh
{
    public int CkhId { get; set; }

    public string CkhNazwa { get; set; } = null!;

    public virtual ICollection<IcenCennikCechaKh> IcenCennikCechaKhs { get; set; } = new List<IcenCennikCechaKh>();

    public virtual ICollection<ImSchematImportuCechaKontrahentum> ImSchematImportuCechaKontrahenta { get; set; } = new List<ImSchematImportuCechaKontrahentum>();

    public virtual ICollection<KhCechaKh> KhCechaKhs { get; set; } = new List<KhCechaKh>();

    public virtual ICollection<KhCechaPrac> KhCechaPracs { get; set; } = new List<KhCechaPrac>();
}
