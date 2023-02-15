using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAccess.Base
{
    public interface IManipulador<T> where T : Comando
    {
        Task</*IResultado*/object> ManipularAsync(T comando);
    }
}
