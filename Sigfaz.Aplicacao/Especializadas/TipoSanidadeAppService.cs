﻿using Sigfaz.Aplicacao.Interfaces.Especializadas;
using Sigfaz.Dominio.Entidades;
using Sigfaz.Dominio.Interfaces.Servicos;

namespace Sigfaz.Aplicacao.Especializadas
{
    public class TipoSanidadeAppService : AppServiceBase<TipoSanidade>, ITipoSanidadeAppService
    {
        private readonly ITipoSanidadeService _tipoApp;

        public TipoSanidadeAppService(ITipoSanidadeService service) : base(service)
        {
            _tipoApp = service;
        }
    }
}
