using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GridViewProject.Models
{
    public class Currency
    {
        [ScaffoldColumn(false)]
        [Key]
        public int CurrencyId { get; set; }     

        [Required, StringLength(100), Display(Name = "Currency Name")]
        public string CurrencyName { get; set; }

        [Required, StringLength(20), Display(Name = "Currency Symbol")]
        public string CurrencySymbol { get; set; }

        [Required, DataType(DataType.Currency), Display(Name = "Exchange Rate")]
        public decimal ExchangeRate { get; set; }

        [ScaffoldColumn(false)]
        [Required, DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime? Modified { get; set; }
    }
}