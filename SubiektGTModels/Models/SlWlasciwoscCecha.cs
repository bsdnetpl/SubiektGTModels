using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlWlasciwoscCecha
{
    public int WchId { get; set; }

    public int WchIdWlasciwosc { get; set; }

    public int WchIdCecha { get; set; }

    public virtual SlCechaTw WchIdCechaNavigation { get; set; } = null!;

    public virtual SlWlasciwCechTw WchIdWlasciwoscNavigation { get; set; } = null!;
}
