using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantoã_Arquitetura.Business
{
    class BankAccountBusiness
    {
        Database.BankAccountDatabase db = new Database.BankAccountDatabase();

        public void Inserir(Database.Entities.tb_bankaccount bank)
        {
            db.Inserir(bank);
        }
    }
}
