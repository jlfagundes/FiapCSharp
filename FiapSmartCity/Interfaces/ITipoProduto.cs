namespace FiapSmartCity.Interfaces
{
    public interface ITipoProduto
    {
        public int IdTypeProduct { get; set; }
        public string DescriptionTypeProduct { get; set; }
        public bool Marketed { get; set; }
    }
}
