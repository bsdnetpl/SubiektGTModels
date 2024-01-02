using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WyWzorzecUzytkownik
{
    public int WzuTyp { get; set; }

    public int WzuIdWzorca { get; set; }

    public int WzuIdUzytkownika { get; set; }
}
