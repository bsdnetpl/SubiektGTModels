using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RfVat
{
    public int RfvId { get; set; }

    public int RfvDokId { get; set; }

    public int RfvVatId { get; set; }

    public decimal RfvVatProc { get; set; }

    public decimal RfvWartNetto { get; set; }

    public decimal RfvWartVat { get; set; }

    public decimal RfvWartBrutto { get; set; }

    public virtual RfRaportyFiskalne RfvDok { get; set; } = null!;

    public virtual SlStawkaVat RfvVat { get; set; } = null!;
}
