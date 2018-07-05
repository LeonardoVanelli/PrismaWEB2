using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Customise
{
    public class CustomBase
    {
        public virtual void AfterInsert()
        {
            var a = "a";
        }
    }
}
