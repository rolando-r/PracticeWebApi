using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion.Repository;
public class PaisRepository : GenericRepository<Pais>, IPaisRepository
{
    public PaisRepository(ApiIncidenciasContext contex) : base(contex)
}