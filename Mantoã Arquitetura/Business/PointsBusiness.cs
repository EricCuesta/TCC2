using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantoã_Arquitetura.Business
{
    class PointsBusiness
    {
        Database.PointsDatabase db = new Database.PointsDatabase();

        public void Inserir(Database.Entities.tb_points points)
        {
            db.Inserir(points);
        }
    }
}
