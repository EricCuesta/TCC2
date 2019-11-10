using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantoã_Arquitetura.Database
{
    class PointsDatabase
    {
        Entities.mantoadbEntities db = new Entities.mantoadbEntities();

        public void Inserir(Entities.tb_points points)
        {
            db.tb_points.Add(points);

            db.SaveChanges();
        }
    }
}
