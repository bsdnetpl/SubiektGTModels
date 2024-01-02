using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VatKorektaProporcji
{
    public int VkpId { get; set; }

    public int VkpIdEwidVat { get; set; }

    public decimal? VkpZastPreproporcja { get; set; }

    public decimal? VkpZastProporcja { get; set; }

    public decimal? VkpRzeczPreproporcja { get; set; }

    public decimal? VkpRzeczProporcja { get; set; }

    public decimal? VkpVatcalkowity { get; set; }

    public decimal? VkpVatdoOdliczenia { get; set; }

    public decimal? VkpVatrzeczProporcja { get; set; }

    public virtual VatEwidVat VkpIdEwidVatNavigation { get; set; } = null!;
}
