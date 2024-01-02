using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlCrmBranza
{
    public int BraId { get; set; }

    public string BraNazwa { get; set; } = null!;

    public virtual ICollection<KhKontrahent> KhKontrahents { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhPracownik> KhPracowniks { get; set; } = new List<KhPracownik>();
}
