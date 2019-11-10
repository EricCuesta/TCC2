using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantoã_Arquitetura.Business
{
    class BenefitsBusiness
    {
        Database.BenefitsDatabase db = new Database.BenefitsDatabase();

        public void Inserir(Database.Entities.tb_benefits benefits)
        {
            db.Inserir(benefits);
        }

        public List<Database.Entities.tb_benefits> Consultar()
        {
            List<Database.Entities.tb_benefits> list = db.Consultar();
            return list;
        }

        public void Alterar(Database.Entities.tb_benefits benefits)
        {
            db.Alterar(benefits);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
