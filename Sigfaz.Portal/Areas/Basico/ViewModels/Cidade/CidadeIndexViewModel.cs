﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sigfaz.Portal.Areas.Basico.ViewModels.Cidade
{
    public class CidadeIndexViewModel
    {
        [Key]
        public int CidadeId { get; set; }

        [Required(ErrorMessage = "Preencha o nome da cidade")]
        [MaxLength(200)]
        [DisplayName("Cidade")]
        public string Nome { get; set; }

        public int EstadoId { get; set; }

        [DisplayName("Estado")]
        public virtual Dominio.Entidades.Estado Estado { get; set; }
    }
}