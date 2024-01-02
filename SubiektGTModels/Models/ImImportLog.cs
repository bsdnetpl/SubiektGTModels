using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImImportLog
{
    public int IlId { get; set; }

    public int? IlIdImportu { get; set; }

    public string IlNumerDokumentu { get; set; } = null!;

    public int IlNrBledu { get; set; }

    public string IlOpisBledu { get; set; } = null!;

    public int? IlInDokId { get; set; }

    public int? IlInDokTyp { get; set; }

    public int? IlIdDekretu { get; set; }

    public int? IlIdVat { get; set; }

    public int? IlIdVatOss { get; set; }

    public virtual ImImportPrzeprowadzony? IlIdImportuNavigation { get; set; }
}
