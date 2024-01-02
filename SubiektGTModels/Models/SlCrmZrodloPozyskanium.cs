using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlCrmZrodloPozyskanium
{
    public int ZpoId { get; set; }

    public string ZpoNazwa { get; set; } = null!;

    public virtual ICollection<KhKontrahent> KhKontrahents { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhPracownik> KhPracowniks { get; set; } = new List<KhPracownik>();
}
