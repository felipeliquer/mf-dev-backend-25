using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_25.Models
{
    [Table("Consumos")]
    public class Consumos
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Obrigatório informar a descrição")]
       
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem")]
        public int km { get; set; }

       [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel TipoCombustivel { get; set; }

        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatório informar o veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }

        public ICollection<Consumos> Consumo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
       
    }
    

}
