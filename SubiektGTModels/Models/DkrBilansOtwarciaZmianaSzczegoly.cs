using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrBilansOtwarciaZmianaSzczegoly
{
    public int BozsId { get; set; }

    public int BozsIdBoz { get; set; }

    public int BozsTyp { get; set; }

    public string BozsKonto { get; set; } = null!;

    public int BozsStrona { get; set; }

    public decimal BozsStanPrzed { get; set; }

    public decimal BozsStanPo { get; set; }

    public virtual DkrBilansOtwarciaZmiana BozsIdBozNavigation { get; set; } = null!;
}
