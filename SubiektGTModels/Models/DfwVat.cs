using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DfwVat
{
    public int FwvId { get; set; }

    public int FwvDokId { get; set; }

    public int FwvVatId { get; set; }

    public decimal FwvVatProc { get; set; }

    public decimal FwvWartNetto { get; set; }

    public decimal FwvWartVat { get; set; }

    public decimal FwvWartBrutto { get; set; }

    public virtual DfwFakturyWewnetrzne FwvDok { get; set; } = null!;

    public virtual SlStawkaVat FwvVat { get; set; } = null!;
}
