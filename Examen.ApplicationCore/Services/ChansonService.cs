using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Examen.ApplicationCore.Domaine;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ChansonService : Service<Chanson>, IChansonService
    {
        public ChansonService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
