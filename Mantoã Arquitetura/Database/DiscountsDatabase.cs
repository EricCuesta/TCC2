using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantoã_Arquitetura.Database
{
    class DiscountsDatabase
    {
        Entities.mantoadbEntities db = new Entities.mantoadbEntities();

        public void Inserir(Entities.tb_discounts discounts)
        {
            db.tb_discounts.Add(discounts);

            db.SaveChanges();
        }

        public List<Entities.tb_discounts> Consultar()
        {
            List<Entities.tb_discounts> list = db.tb_discounts.ToList();

            return list;
        }

        public void Alterar(Entities.tb_discounts discounts)
        {
            Entities.tb_discounts list = db.tb_discounts.First(t => t.id_discounts == discounts.id_discounts);
            list.vl_fgts = list.vl_fgts;
            list.vl_incomeTax = list.vl_incomeTax;
            list.vl_inss = list.vl_inss;


            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_discounts remover = db.tb_discounts.First(t => t.id_discounts == id);

            db.tb_discounts.Remove(remover);
            db.SaveChanges();
        }
    }
}
