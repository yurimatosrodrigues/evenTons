using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace evenTons.Models
{
    public class Product
    {
        [Display(Name = "Código")]         
        public int Codigo { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Preço")]
        public double Preco { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data Fabricação")]
        public DateTime DataFabricacao { get; set; }        
    }
}
