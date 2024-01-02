using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbPowiazanieTransakcji
{
    public int HbptId { get; set; }

    public int? HbptIdTransakcjiZwyciagu { get; set; }

    public int? HbptIdTransakcjiBankowej { get; set; }

    public virtual HbTransakcjaElektroniczna? HbptIdTransakcjiBankowejNavigation { get; set; }

    public virtual HbTransakcja? HbptIdTransakcjiZwyciaguNavigation { get; set; }
}
