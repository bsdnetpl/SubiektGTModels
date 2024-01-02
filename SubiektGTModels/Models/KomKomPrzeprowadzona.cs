using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KomKomPrzeprowadzona
{
    public int OdkId { get; set; }

    public DateTime OdkData { get; set; }

    public DateTime? OdkDataOd { get; set; }

    public DateTime? OdkDataDo { get; set; }

    public int? OdkIdMagazyn { get; set; }

    public int OdkTypKom { get; set; }

    public int OdkLiczbaOk { get; set; }

    public int OdkLiczbaWszystko { get; set; }

    public int OdkLiczbaNieOk { get; set; }

    public virtual ICollection<KomKomunikacjaLog> KomKomunikacjaLogs { get; set; } = new List<KomKomunikacjaLog>();
}
