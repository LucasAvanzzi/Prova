﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DjalmaProva.Models
{
    public class Cliente
    {

        public int ClienteId { get; set; }

        [MaxLength(128)]
        public string NomeCompleto { get; set; }

        [MaxLength(11)]
        public string Telefone { get; set; }

        [MaxLength(128)]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(11)]
        public string CPF { get; set; }

        [MaxLength(14)]
        public string CNPJ { get; set; }

        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }

        
    }
}
