using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwAlarm
{
    public int ZdId { get; set; }

    public int? ZdPersonel { get; set; }

    public bool ZdBezCzasu { get; set; }

    public int ZdRodzaj { get; set; }

    public DateTime? ZdPoczatek { get; set; }

    public string ZdTemat { get; set; } = null!;

    public int ZdPriorytet { get; set; }

    public string? PtzNazwa { get; set; }

    public bool ZdPrzypomniane { get; set; }

    public DateTime? ZdNastepnePrzypomnienie { get; set; }

    public int? ZdvwStatus { get; set; }

    public string? ZdUczestnicy { get; set; }

    public string? AdrNazwa { get; set; }

    public int? FlgNumer { get; set; }

    public string? FlwKomentarz { get; set; }

    public int? FlwIdFlagi { get; set; }

    public string? FlgText { get; set; }

    public int? FlgId { get; set; }

    public int? ZdkIdKlienta { get; set; }

    public DateTime? ZdkNastepnePrzypomnienie { get; set; }

    public bool? ZdkPrzypomniane { get; set; }

    public int ZdCykliczne { get; set; }

    public int JestDokumentWzorcowy { get; set; }
}
