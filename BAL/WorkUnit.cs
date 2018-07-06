using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class WorkUnit : IDisposable
    {
        protected BD_LogisticaTransporteEntities BDContext { get; set; }

        public WorkUnit()
        {
            BDContext = new BD_LogisticaTransporteEntities();
        }
        public WorkUnit(BD_LogisticaTransporteEntities _context)
        {
            BDContext = _context;
        }
        public void Dispose()
        {
            BDContext.Dispose();
        }
        public void Save()
        {
            BDContext.SaveChanges();
        }
    }
}
