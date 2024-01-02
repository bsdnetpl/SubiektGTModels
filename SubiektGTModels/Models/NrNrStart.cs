using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NrNrStart
{
    public int NsId { get; set; }

    public int NsTyp { get; set; }

    public int? NsRok { get; set; }

    public int? NsMiesiac { get; set; }

    public int? NsIdRokuObr { get; set; }

    public int? NsRejId { get; set; }

    public int NsGranica { get; set; }

    public int NsRodzaj { get; set; }

    public int NsDefiniowalnyId { get; set; }

    public virtual ICollection<NrNrStartRk> NrNrStartRks { get; set; } = new List<NrNrStartRk>();
}
