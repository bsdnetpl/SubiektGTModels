using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class FnxFenik
{
    public int MtId { get; set; }

    public byte MtSyncState { get; set; }

    public string? MtApiKey { get; set; }

    public string? MtSyncMachine { get; set; }

    public string? MtWizardAddress { get; set; }

    public bool? MtTriggersEnabled { get; set; }

    public int? MtAmountOfProducts { get; set; }

    public int? MtAmountOfPictures { get; set; }

    public int? MtWebsiteType { get; set; }

    public string? MtWebsiteName { get; set; }

    public int? MtWebsiteStatus { get; set; }

    public string? MtWebsiteAddress { get; set; }

    public string? MtWebsiteAdminEmail { get; set; }

    public int? MtLicenseStatus { get; set; }

    public int? MtLicenseType { get; set; }

    public string? MtLicenseDescription { get; set; }

    public DateTime? MtLicenseExpirationDate { get; set; }

    public DateTime? MtLastSyncDate { get; set; }

    public int? MtNewOrders { get; set; }
}
