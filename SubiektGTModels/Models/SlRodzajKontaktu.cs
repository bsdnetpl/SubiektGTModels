using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlRodzajKontaktu
{
    public int RkId { get; set; }

    public string RkNazwa { get; set; } = null!;

    public virtual ICollection<KhKontrahent> KhKontrahents { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhPracownik> KhPracowniks { get; set; } = new List<KhPracownik>();
}
