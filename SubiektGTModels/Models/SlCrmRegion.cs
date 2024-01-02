using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlCrmRegion
{
    public int RegId { get; set; }

    public string RegNazwa { get; set; } = null!;

    public virtual ICollection<KhKontrahent> KhKontrahents { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhParametr> KhParametrs { get; set; } = new List<KhParametr>();

    public virtual ICollection<KhPracownik> KhPracowniks { get; set; } = new List<KhPracownik>();
}
