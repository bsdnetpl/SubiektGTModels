using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class LogLogowanie
{
    public int LogId { get; set; }

    public int LogZrodlo { get; set; }

    public int LogRodzaj { get; set; }

    public DateTime LogData { get; set; }

    public string LogStanowisko { get; set; } = null!;

    public int LogWatekId { get; set; }

    public int LogProcesId { get; set; }

    public int LogUzytkownikId { get; set; }

    public string LogUzytkownikIdentyfikator { get; set; } = null!;

    public int? LogObiektTyp { get; set; }

    public int? LogObiektTypEx { get; set; }

    public int? LogObiektId { get; set; }

    public string LogInformacje { get; set; } = null!;
}
