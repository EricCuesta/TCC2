using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantoã_Arquitetura.Database
{
    class BankAccountDatabase
    {
        Entities.mantoadbEntities db = new Entities.mantoadbEntities();

        public void Inserir(Entities.tb_bankaccount bank)
        {
            db.tb_bankaccount.Add(bank);

            db.SaveChanges();
        }
    }
}
