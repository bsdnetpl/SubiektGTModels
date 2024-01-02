using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SmsParam
{
    public int SmsId { get; set; }

    public bool SmsActive { get; set; }

    public DateTime? SmsLastRefresh { get; set; }

    public string? SmsTariffName { get; set; }

    public int? SmsCurrentBalance { get; set; }

    public DateTime? SmsExpirationDate { get; set; }

    public bool? SmsDiacriticsAllowed { get; set; }

    public short? SmsCharactersInMessagePart { get; set; }

    public short? SmsCharactersInMessagePartWithDiactricts { get; set; }

    public short? SmsMessagePartLimit { get; set; }

    public short? SmsMessagePartLimitWithDiactricts { get; set; }

    public bool? SmsCustomSenderAllowed { get; set; }

    public string? SmsActivationDenialReason { get; set; }

    public int? SmsActivationStatus { get; set; }

    public string? SmsActiveCustomSenderName { get; set; }

    public string? SmsMostRecentCustomSenderName { get; set; }

    public int SmsSendIntervalSec { get; set; }

    public bool SmsFlashMessages { get; set; }

    public bool SmsDiacriticts { get; set; }

    public int? SmsCategoryId { get; set; }

    public int SmsPackageSize { get; set; }
}
