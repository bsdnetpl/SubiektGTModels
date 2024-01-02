using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SySyncParam
{
    public int SypId { get; set; }

    public int SypPdmType { get; set; }

    public bool SypEnabled { get; set; }

    public bool SypBlockMag { get; set; }

    public bool SypBlockKasa { get; set; }

    public int SypSendTimeoutType { get; set; }

    public int SypSendInterval { get; set; }

    public int SypSendIntervalSec { get; set; }

    public DateTime SypSendHour { get; set; }

    public DateTime SypSendHourCheck { get; set; }

    public int SypReceiveTimeoutType { get; set; }

    public int SypReceiveInterval { get; set; }

    public int SypReceiveIntervalSec { get; set; }

    public DateTime SypReceiveHour { get; set; }

    public DateTime SypReceiveHourCheck { get; set; }

    public int SypCmdTaskMode { get; set; }

    public int SypCmdTaskTimeout { get; set; }

    public int SypCmdRequestTimeout { get; set; }

    public int SypCmdPackageLifetime { get; set; }

    public int SypDataPackageLifetime { get; set; }

    public int SypCmdPackageReadLimit { get; set; }

    public int SypDataPackageReadLimit { get; set; }

    public int SypDataPackageSendLimit { get; set; }

    public bool SypCmdTaskUseThreads { get; set; }

    public int SypCmdTaskThreadsLimit { get; set; }

    public int SypStorageReadTimeout { get; set; }

    public int SypStartTasks { get; set; }

    public int? SypStorageSizeLimit { get; set; }

    public string? SypStorageUri { get; set; }

    public string? SypServiceBusUri { get; set; }

    public string? SypLicServerUri { get; set; }

    public string? SypOauthUri { get; set; }

    public bool SypSyncPriceSend { get; set; }

    public bool SypSyncPriceReceive { get; set; }

    public bool SypSyncPriceEditionBlockage { get; set; }

    public bool SypLogowanie { get; set; }

    public byte[]? SypExchangeData { get; set; }

    public bool SypBlokujZapis { get; set; }

    public int SypErrorInfoType { get; set; }

    public string? SypErrorInfoText { get; set; }

    public byte[]? SypErrorInfoUsers { get; set; }

    public int? SypErrorInfoTimeout { get; set; }

    public bool SypTwStanRefreshEnabled { get; set; }

    public int SypTwStanRefreshTimeout { get; set; }

    public int SypDataPackageSendLimitSize { get; set; }

    public bool SypSendPhotos { get; set; }

    public bool SypSf2Enabled { get; set; }

    public byte[]? SypErrorMailConfig { get; set; }

    public bool SypErrorMailEnabled { get; set; }

    public bool SypSendKhNalHist { get; set; }
}
