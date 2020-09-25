using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financial.Entities.Entities
{
    public class FinancialMovement : Base
    {
        [Display(Name = "Tipo de Movimentação")]
        [Column("Tipo_movimentacao", TypeName = "bit")]
        public bool Tipo_movimentacao { get; set; } //debito ou crédito

        [Display(Name = "Forma de Pagamento")]
        [Column("Forma_pagamento", TypeName = "varchar(100)")]
        public string Forma_pagamento { get; set; } //boleto, cartão, dinheiro)

        [Display(Name = "Categoria")]
        [Column("Categoria", TypeName = "varchar(100)")]
        public string Categoria { get; set; } //moradia, transporte, lazer

        [Display(Name = "Valor")]
        [Column("Valor", TypeName = "decimal")]
        public decimal Valor { get; set; }

        [Display(Name = "Data de Recebimento")]
        [Column("Data_recebimento", TypeName = "datetime")]
        public DateTime Data_recebimento { get; set; }

        [Display(Name = "Data de Vencimento")]
        [Column("Data_vencimento", TypeName = "datetime")]
        public DateTime Data_vencimento { get; set; }

        [Display(Name = "Data de Pagamento")]
        [Column("Data_pagamento", TypeName = "datetime")]
        public DateTime Data_pagamento { get; set; }

        [Display(Name = "Taxas")]
        [Column("Taxas", TypeName = "decimal")]
        public decimal Taxas { get; set; } //juros, descontos, etc
    }
}
