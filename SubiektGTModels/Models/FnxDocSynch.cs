using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class FnxDocSynch
{
    public int MtId { get; set; }

    public int? MtMultiStoreId { get; set; }

    public DateTime? MtLastSynchDate { get; set; }

    public DateTime? MtLastChangeDate { get; set; }

    public byte MtFirstStateId { get; set; }

    public byte MtSecondStateId { get; set; }

    public byte MtFirstTypeId { get; set; }

    public byte MtSecondTypeId { get; set; }

    public int? MtFirstDocId { get; set; }

    public int? MtSecondDocId { get; set; }

    public byte MtStateId { get; set; }

    public string? MtDescription { get; set; }

    public bool? MtIsPaid { get; set; }

    public int? MtFirstDocRealisationDocumentId { get; set; }
}
