using Microsoft.EntityFrameworkCore;
using OrdensDeServico.Data;
using OrdensDeServico.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrdensDeServico.Presenters
{
    public class TecnicoPresenter
    {
        private readonly Contexto db;

        public TecnicoPresenter()
        {
            db = new Contexto();
            db.Database.EnsureCreated();
        }

        public TecnicoPresenter(Contexto db)
        {
            this.db = db;
        }

        public List<Tecnico> Buscar(string nome)
        {
            nome = nome ?? string.Empty;
            return db.Tecnicos
                .Where(c => c.Nome.ToUpper().Contains(nome.ToUpper()))
                .ToList();
        }

        public bool Cadastrar(Tecnico tecnico)
        {
            db.Tecnicos.Add(tecnico);
            return db.SaveChanges() > 0;
        }

        public bool Remover(Tecnico tecnico)
        {
            db.Tecnicos.Remove(tecnico);
            return db.SaveChanges() > 0;
        }

        public bool Editar(Tecnico tecnico)
        {
            db.Tecnicos.Update(tecnico);
            return db.SaveChanges() > 0;
        }

        // Obtém apenas as Ordens de Serviço do técnico com status DIFERENTE de "Concluído" e "Cancelado"
        public List<OrdemServico> ObterOrdensAtivasDoTecnico(int tecnicoId)
        {
            return db.OrdensServico
                .Where(os => os.TecnicoId == tecnicoId &&
                             os.Status != "Concluído" &&
                             os.Status != "Cancelado")
                .ToList();
        }

        // Atualiza o status diretamente na Ordem de Serviço
        public bool AtualizarStatusOrdem(int ordemServicoId, string novoStatus)
        {
            var os = db.OrdensServico.Find(ordemServicoId);
            if (os != null)
            {
                os.Status = novoStatus;
                db.OrdensServico.Update(os);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
