using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlCrmDzial
{
    public int DziId { get; set; }

    public string DziNazwa { get; set; } = null!;

    public virtual ICollection<KhPracownik> KhPracowniks { get; set; } = new List<KhPracownik>();
}
