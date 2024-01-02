using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwAlarmyUzytkownika
{
    public int ZdId { get; set; }

    public int? ZdPersonel { get; set; }

    public int? ZdkIdKlienta { get; set; }

    public DateTime? ZdNastepnePrzypomnienie { get; set; }

    public DateTime? ZdkNastepnePrzypomnienie { get; set; }

    public bool ZdPrzypomniane { get; set; }

    public bool? ZdkPrzypomniane { get; set; }
}
