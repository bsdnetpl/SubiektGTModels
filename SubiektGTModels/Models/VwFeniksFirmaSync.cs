using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksFirmaSync
{
    public int SubiektId { get; set; }

    public string PdRegon { get; set; } = null!;

    public string PdWww { get; set; } = null!;

    public string PdEmail { get; set; } = null!;

    public string AdrNazwa { get; set; } = null!;

    public string AdrNazwaPelna { get; set; } = null!;

    public string AdrTelefon { get; set; } = null!;

    public string AdrFaks { get; set; } = null!;

    public string AdrUlica { get; set; } = null!;

    public string AdrNrDomu { get; set; } = null!;

    public string AdrNrLokalu { get; set; } = null!;

    public string AdrAdres { get; set; } = null!;

    public string AdrKod { get; set; } = null!;

    public string AdrMiejscowosc { get; set; } = null!;

    public string AdrNip { get; set; } = null!;

    public string AdrPoczta { get; set; } = null!;

    public string AdrGmina { get; set; } = null!;

    public string AdrPowiat { get; set; } = null!;

    public string AdrSkrytka { get; set; } = null!;

    public string AdrSymbol { get; set; } = null!;

    public string? NazwaWojewodztwa { get; set; }

    public string? NazwaPanstwa { get; set; }

    public int? MultiStoreId { get; set; }

    public byte? StateId { get; set; }

    public DateTime? MtLastSynchDate { get; set; }

    public DateTime? MtLastChangeDate { get; set; }

    public byte? MtStateId { get; set; }

    public string? NumerRachunku { get; set; }

    public string? NazwaRachunku { get; set; }

    public string? NazwaBanku { get; set; }
}
