using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksDokumentSync
{
    public byte StateId { get; set; }

    public int? MultiStoreId { get; set; }

    public string? Description { get; set; }

    public int? FirstDocId { get; set; }

    public byte FirstDocTyp { get; set; }

    public int? WarehouseId { get; set; }

    public string? FirstDocNrPelny { get; set; }

    public byte FirstDocStatus { get; set; }

    public string? FirstDocRealisationDocumentNumber { get; set; }

    public int? SecondDocId { get; set; }

    public byte SecondDocTyp { get; set; }

    public string? SecondDocNrPelny { get; set; }

    public byte SecondDocStatus { get; set; }

    public bool? IsPaid { get; set; }
}
