using FiapSmartCity.Interfaces;

namespace FiapSmartCity.Models
{
    public class TipoProduto : ITipoProduto
    {
        public int IdTypeProduct { get; set; }
        public string DescriptionTypeProduct { get; set; }
        public bool Marketed { get; set; }
    }
}
