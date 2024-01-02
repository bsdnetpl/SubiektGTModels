using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksKontrahentSync
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public byte StateId { get; set; }

    public bool CustomerIsNaturalPerson { get; set; }

    public string CustomerName { get; set; } = null!;

    public string CustomerFullName { get; set; } = null!;

    public string CustomerSymbol { get; set; } = null!;

    public string CustomerNip { get; set; } = null!;

    public string CustomerRegon { get; set; } = null!;

    public string CustomerPhone { get; set; } = null!;

    public string CustomerEmail { get; set; } = null!;

    public string CustomerWww { get; set; } = null!;

    public string AddressStreet { get; set; } = null!;

    public string AddressStreetNumber { get; set; } = null!;

    public string AddressLocalNumber { get; set; } = null!;

    public string AddressPostCode { get; set; } = null!;

    public string AddressCity { get; set; } = null!;

    public string? AddressCounty { get; set; }

    public string? AddressCountry { get; set; }

    public int? DiscountMultistoreId { get; set; }

    public int? PriceLevelMultistoreId { get; set; }
}
