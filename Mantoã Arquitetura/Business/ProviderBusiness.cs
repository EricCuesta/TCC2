﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mantoã_Arquitetura.Business
{
    class ProviderBusiness
    {
        Database.ProviderDatabase db = new Database.ProviderDatabase();

        public void Inserir(Database.Entities.tb_provider provider)
        {
            if (provider.nm_provider == string.Empty)
                throw new ArgumentException("O campo fornecedor deve ser preenchido");
            if (provider.nm_name == string.Empty)
                throw new ArgumentException("O campo nome fantásia deve ser preenchido");
            if (provider.ds_typePerson == string.Empty)
                throw new ArgumentException("O campo tipo de pessoa deve ser definido");
            if (provider.nr_identification == string.Empty)
                throw new ArgumentException("O campo de indentificação deve ser definido");
            if (provider.ds_state == string.Empty)
                throw new ArgumentException("O campo estado deve ser definido");
            if (provider.nr_cep == string.Empty)
                throw new ArgumentException("O campo cep deve ser preenchido");
            if (provider.ds_address == string.Empty)
                throw new ArgumentException("O campo endereço deve ser preenchido");
            if (provider.nr_cellphone == string.Empty && provider.nr_tellphone == string.Empty)
                throw new ArgumentException("Celular ou Telefone devem ser preenchidos");
            if (provider.ds_email == string.Empty)
                throw new ArgumentException("E-mail devem ser preenchidos");
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(provider.ds_email);
            if (match.Success == false)
                throw new ArgumentException(provider.ds_email + " é um e-mail inválido!");

            db.Inserir(provider);
        }

        public Database.Entities.tb_provider ConsultarPorID(int id)
        {
            Database.Entities.tb_provider provider = db.ConsultaPorID(id);

            return provider;
        }

        public List<Database.Entities.tb_provider> Consultar(Database.Entities.tb_provider provider)
        {
            List<Database.Entities.tb_provider> list = new List<Database.Entities.tb_provider>();

            if (provider.nm_provider != string.Empty && provider.ds_typePerson == "-")
                list = db.ConsultarPorNome(provider);
            else if (provider.nm_provider == string.Empty || provider.nm_provider == null && provider.ds_typePerson != "-")
                list = db.ConsultarPorTipoDePessoa(provider);
            else if (provider.nm_provider != string.Empty && provider.ds_typePerson != "-")
                list = db.ConsultarPorTipoDePessoa(provider);

            return list;
        }

        public List<Database.Entities.tb_provider> ConsultarTodos()
        {
            List<Database.Entities.tb_provider> list = db.ConsultarTodos();
            return list;
        }

        public void Alterar(Database.Entities.tb_provider provider)
        {
            if (provider.nm_provider == string.Empty)
                throw new ArgumentException("O campo fornecedor deve ser preenchido");
            if (provider.nm_name == string.Empty)
                throw new ArgumentException("O campo nome fantásia deve ser preenchido");
            if (provider.ds_typePerson == string.Empty)
                throw new ArgumentException("O campo tipo de pessoa deve ser definido");
            if (provider.nr_identification == string.Empty)
                throw new ArgumentException("O campo de indentificação deve ser definido");
            if (provider.ds_state == string.Empty)
                throw new ArgumentException("O campo estado deve ser definido");
            if (provider.nr_cep == string.Empty)
                throw new ArgumentException("O campo cep deve ser preenchido");
            if (provider.ds_address == string.Empty)
                throw new ArgumentException("O campo endereço deve ser preenchido");
            if (provider.nr_cellphone == string.Empty && provider.nr_tellphone == string.Empty)
                throw new ArgumentException("Celular ou Telefone devem ser preenchidos");
            if (provider.ds_email == string.Empty)
                throw new ArgumentException("E-mail devem ser preenchidos");
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(provider.ds_email);
            if (match.Success == false)
                throw new ArgumentException(provider.ds_email + " é um e-mail inválido!");

            db.Alterar(provider);
        }

        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}
