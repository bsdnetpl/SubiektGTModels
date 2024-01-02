using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VatOznaczeniaJpksprzedaz
{
    public int VjsId { get; set; }

    public int VjsIdEwidVat { get; set; }

    public int? VjsOznaczenieDowodu { get; set; }

    public bool? VjsSw { get; set; }

    public bool? VjsEe { get; set; }

    public bool? VjsTp { get; set; }

    public bool? VjsTtWnt { get; set; }

    public bool? VjsTtD { get; set; }

    public bool? VjsMrT { get; set; }

    public bool? VjsMrUz { get; set; }

    public bool? VjsI42 { get; set; }

    public bool? VjsI63 { get; set; }

    public bool? VjsBSpv { get; set; }

    public bool? VjsBSpvDostawa { get; set; }

    public bool? VjsBMpvProwizja { get; set; }

    public bool? VjsMpp { get; set; }

    public bool? VjsGtu01 { get; set; }

    public bool? VjsGtu02 { get; set; }

    public bool? VjsGtu03 { get; set; }

    public bool? VjsGtu04 { get; set; }

    public bool? VjsGtu05 { get; set; }

    public bool? VjsGtu06 { get; set; }

    public bool? VjsGtu07 { get; set; }

    public bool? VjsGtu08 { get; set; }

    public bool? VjsGtu09 { get; set; }

    public bool? VjsGtu10 { get; set; }

    public bool? VjsGtu11 { get; set; }

    public bool? VjsGtu12 { get; set; }

    public bool? VjsGtu13 { get; set; }

    public bool? VjsWstoEe { get; set; }

    public bool? VjsIed { get; set; }

    public virtual VatEwidVat VjsIdEwidVatNavigation { get; set; } = null!;
}
