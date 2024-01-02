using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DekzNaliczenie
{
    public int DznId { get; set; }

    public DateTime? DznMiesiac { get; set; }

    public DateTime DznData { get; set; }

    public string DznOpis { get; set; } = null!;

    public int DznTyp { get; set; }

    public int DznFormat { get; set; }

    public bool DznWyslane { get; set; }

    public virtual ICollection<DekzDeklaracja> DekzDeklaracjas { get; set; } = new List<DekzDeklaracja>();
}
