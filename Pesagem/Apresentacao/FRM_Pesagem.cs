using Pesagem.Classes;

namespace Pesagem
{
    public partial class FRM_Pesagem : Form
    {
        private Comparador Pesos;

        public FRM_Pesagem()
        {
            InitializeComponent();
            Pesos = new();
        }

        private void CHK_Caixas_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Caixas.Checked == true)
            {
                LBL_PESO_TOTAL_Caixas.Enabled = true;
                LBL_PESO_Caixas.Enabled = true;
                LBL_UND_Caixas.Enabled = true;
                NUD_QTD_Caixas.Enabled = true;
                NUD_PESO_Caixas.Enabled = true;
            }
            else
            {
                Pesos.QtdCaixas = 0;
                NUD_QTD_Caixas.Value = 0;
                LBL_PESO_TOTAL_Gaiolas.Enabled = false;
                LBL_PESO_Caixas.Enabled = false;
                LBL_UND_Caixas.Enabled = false;
                NUD_QTD_Caixas.Enabled = false;
                NUD_PESO_Caixas.Enabled = false;
            }
        }

        private void CHK_Gaiolas_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Gaiolas.Checked == true)
            {
                LBL_PESO_TOTAL_Gaiolas.Enabled = true;
                LBL_PESO_Gaiolas.Enabled = true;
                LBL_UND_Gaiolas.Enabled = true;
                NUD_QTD_Gaiolas.Enabled = true;
                NUD_PESO_Gaiolas.Enabled = true;
            }
            else
            {
                Pesos.QtdGaiolas = 0;
                NUD_QTD_Gaiolas.Value = 0;
                LBL_PESO_TOTAL_Gaiolas.Enabled = false;
                LBL_PESO_Gaiolas.Enabled = false;
                LBL_UND_Gaiolas.Enabled = false;
                NUD_QTD_Gaiolas.Enabled = false;
                NUD_PESO_Gaiolas.Enabled = false;
            }
        }

        private void CHK_Pallets_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Pallets.Checked == true)
            {
                LBL_PESO_TOTAL_Pallets.Enabled = true;
                LBL_PESO_Pallets.Enabled = true;
                LBL_UND_Pallets.Enabled = true;
                NUD_QTD_Pallets.Enabled = true;
                NUD_PESO_Pallets.Enabled = true;
            }
            else
            {
                Pesos.QtdPallets = 0;
                NUD_QTD_Pallets.Value = 0;
                LBL_PESO_TOTAL_Pallets.Enabled = false;
                LBL_PESO_Pallets.Enabled = false;
                LBL_UND_Pallets.Enabled = false;
                NUD_QTD_Pallets.Enabled = false;
                NUD_PESO_Pallets.Enabled = false;
            }
        }

        private void NUD_PESO_Guias_ValueChanged(object sender, EventArgs e)
        {
            AtualizaValores();
        }

        private void AtualizaValores()
        {
            AtualizaPesoAdicional();
            Pesos.PesoGuias = NUD_PESO_Guias.Value;
            Pesos.PesoBalanca = NUD_PESO_Balanca.Value;
            TXB_PESO_DIFERENCA.Text = $"{Pesos.GetDiferencaPeso():N3}";
            TXB_PESO_TOTAL_Caixas.Text = $"{Pesos.GetPesoTotalCaixas():N3}";
            TXB_PESO_TOTAL_Pallets.Text = $"{Pesos.GetPesoTotalPallets():N3}";
            TXB_PESO_TOTAL_Gaiolas.Text = $"{Pesos.GetPesoTotalGaiolas():N3}";
            TXB_PESO_TOTAL_Adicional.Text = $"{Pesos.GetPesoAdicionalTotal():N3}";
        }

        private void AtualizaPesoAdicional()
        {
            if (CHK_Pallets.Checked == true)
            {
                Pesos.QtdPallets = NUD_QTD_Pallets.Value;
                Pesos.PesoPallets = NUD_PESO_Pallets.Value;
            }

            if (CHK_Gaiolas.Checked == true)
            {
                Pesos.QtdGaiolas = NUD_QTD_Gaiolas.Value;
                Pesos.PesoGaiolas = NUD_PESO_Gaiolas.Value;
            }

            if (CHK_Caixas.Checked == true)
            {
                Pesos.QtdCaixas = NUD_QTD_Caixas.Value;
                Pesos.PesoCaixas = NUD_PESO_Caixas.Value;
            };
        }

        private void BTN_Limpar_Click(object sender, EventArgs e)
        {
            Pesos = new();
            NUD_QTD_Caixas.Value = 0;
            NUD_QTD_Pallets.Value = 0;
            NUD_QTD_Gaiolas.Value = 0;
            NUD_PESO_Guias.Value = 0;
            NUD_PESO_Balanca.Value = 0;
            AtualizaValores();
        }
    }
}