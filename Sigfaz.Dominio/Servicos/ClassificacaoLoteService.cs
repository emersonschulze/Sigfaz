﻿using Sigfaz.Dominio.Entidades;
using Sigfaz.Dominio.Interfaces.Repositorios;
using Sigfaz.Dominio.Interfaces.Servicos;

namespace Sigfaz.Dominio.Servicos
{
    public class ClassificacaoLoteService : ServiceBase<ClassificacaoLote>, IClassificacaoLoteService
    {
        private readonly IClassificacaoLoteRepository _repository;

        public ClassificacaoLoteService(IClassificacaoLoteRepository classificacaoRepository) : base(classificacaoRepository)
        {
            _repository = classificacaoRepository;
        }
    }
}
