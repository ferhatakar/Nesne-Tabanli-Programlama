using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_Interfaces.Interfaces
{
    interface IAraba:IRenk,IHiz
    {
        string _IMarka { get; set; }
    }
}
