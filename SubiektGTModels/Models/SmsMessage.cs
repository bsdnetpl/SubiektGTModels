using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SmsMessage
{
    public int SmsmId { get; set; }

    public int SmsmCurrentStatus { get; set; }

    public int? SmsmClientId { get; set; }

    public int? SmsmClientAddressId { get; set; }

    public int? SmsmClientType { get; set; }

    public int? SmsmClientPhoneId { get; set; }

    public string SmsmClientPhoneNo { get; set; } = null!;

    public string SmsmContent { get; set; } = null!;

    public int SmsmCreatorId { get; set; }

    public DateTime SmsmCreated { get; set; }

    public DateTime? SmsmScheduledSend { get; set; }

    public bool SmsmDiacritics { get; set; }

    public bool SmsmFlash { get; set; }

    public int SmsmCharacters { get; set; }

    public int SmsmParts { get; set; }

    public int? SmsmModifierId { get; set; }

    public DateTime? SmsmModified { get; set; }

    public int? SmsmSubmitterId { get; set; }

    public DateTime? SmsmSubmitted { get; set; }

    public DateTime? SmsmSent { get; set; }

    public string? SmsmGuid { get; set; }

    public DateTime? SmsmDelivered { get; set; }

    public string? SmsmLastError { get; set; }

    public int? SmsmCategoryId { get; set; }

    public string? SmsmRemarks { get; set; }

    public int SmsmTariffId { get; set; }

    public bool SmsmResend { get; set; }

    public int SmsmCheckStatusCount { get; set; }

    public DateTime? SmsmLastCheckStatus { get; set; }

    public int SmsmMinuteDiffCheckSend { get; set; }

    public int? SmsmTemplateId { get; set; }

    public int? SmsmObjectId { get; set; }

    public int? SmsmObjectType { get; set; }

    public virtual SlKategorieSm? SmsmCategory { get; set; }

    public virtual TelEwid? SmsmClientPhone { get; set; }

    public virtual PdUzytkownik SmsmCreator { get; set; } = null!;

    public virtual PdUzytkownik? SmsmModifier { get; set; }

    public virtual PdUzytkownik? SmsmSubmitter { get; set; }

    public virtual SmsTariffHist SmsmTariff { get; set; } = null!;
}
