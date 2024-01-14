namespace Pesagem.Classes
{
    public class Comparador
    {
        public decimal QtdPallets { get; set; } = 0;
        public decimal PesoPallets { get; set; } = 0;
        public decimal QtdGaiolas { get; set; } = 0;
        public decimal PesoGaiolas { get; set; } = 0;
        public decimal QtdCaixas { get; set; } = 0;
        public decimal PesoCaixas { get; set; } = 0;
        public decimal PesoGuias { get; set; } = 0;
        public decimal PesoBalanca { get; set; } = 0;

        public Comparador() { }

        public decimal GetPesoTotalPallets()
        {
            return PesoPallets * QtdPallets;
        }

        public decimal GetPesoTotalGaiolas()
        {
            return PesoGaiolas * QtdGaiolas;
        }

        public decimal GetPesoTotalCaixas()
        {
            return PesoCaixas * QtdCaixas;
        }

        public decimal GetPesoAdicionalTotal()
        {
            var total = GetPesoTotalCaixas() 
                      + GetPesoTotalGaiolas()
                      + GetPesoTotalPallets();
            return total;
        }

        public decimal GetDiferencaPeso()
        {
            return PesoBalanca - (PesoGuias + GetPesoAdicionalTotal());
        }
    }
}
