using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlGrupaKh
{
    public int GrkId { get; set; }

    public string GrkNazwa { get; set; } = null!;

    public virtual ICollection<IcenCennikGrupaKh> IcenCennikGrupaKhs { get; set; } = new List<IcenCennikGrupaKh>();

    public virtual ICollection<ImSchematImportuGrupaKontrahentum> ImSchematImportuGrupaKontrahenta { get; set; } = new List<ImSchematImportuGrupaKontrahentum>();

    public virtual ICollection<KhKontrahent> KhKontrahents { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhPracownik> KhPracowniks { get; set; } = new List<KhPracownik>();
}
