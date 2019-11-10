﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantoã_Arquitetura.Database
{
    class SupplyDatabase
    {
        Entities.mantoadbEntities db = new Entities.mantoadbEntities();

        public void Inserir(Entities.tb_supply supply)
        {
            db.tb_supply.Add(supply);

            db.SaveChanges();
        }

        public Entities.tb_supply ConsultaPorID(int id)
        {
            Entities.tb_supply supply = db.tb_supply.FirstOrDefault(t => t.id_supply == id);

            return supply;
        }

        public List<Entities.tb_supply> ConsultarPorNome(Entities.tb_supply supply)
        {
            List<Entities.tb_supply> list = db.tb_supply.Where(l => l.nm_supply == supply.nm_supply).ToList();

            return list;
        }

        public List<Entities.tb_supply> ConsultarTodos()
        {
            List<Entities.tb_supply> list = db.tb_supply.ToList();

            return list;
        }

        public void Alterar(Entities.tb_supply supply)
        {
            Entities.tb_supply list = db.tb_supply.FirstOrDefault(t => t.id_supply == supply.id_supply);
            list.nm_supply = supply.nm_supply;
            list.vl_amount = supply.vl_amount;
            list.vl_value = Convert.ToDecimal(supply.vl_value);
            list.ds_note = supply.ds_note;

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Entities.tb_supply supply = db.tb_supply.First(t => t.id_supply == id);

            db.tb_supply.Remove(supply);
            db.SaveChanges();
        }
    }
}
