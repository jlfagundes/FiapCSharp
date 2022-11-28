using FiapSmartCity.Interfaces;

namespace FiapSmartCity.Models
{
    public class Produto : IProduto
    {
        public int IdProduto { get; set; }
        public String NomeProduto { get; set; }
        public String Caracteristicas { get; set; }
        public double PrecoMedio { get; set; }
        public String Logotipo { get; set; }
        public bool Ativo { get; set; }

        // Referência para classe TipoProduto
        public TipoProduto Tipo { get; set; }
    }
}
