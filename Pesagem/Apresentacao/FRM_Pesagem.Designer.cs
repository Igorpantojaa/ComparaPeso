namespace Pesagem
{
    partial class FRM_Pesagem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GP_Parametros = new GroupBox();
            NUD_PESO_Balanca = new NumericUpDown();
            NUD_PESO_Guias = new NumericUpDown();
            GP_PesoAdicional = new GroupBox();
            LBL_PESO_Caixas = new Label();
            LBL_PESO_Gaiolas = new Label();
            LBL_PESO_Pallets = new Label();
            LBL_UND_Caixas = new Label();
            LBL_UND_Gaiolas = new Label();
            LBL_UND_Pallets = new Label();
            NUD_PESO_Caixas = new NumericUpDown();
            CHK_Caixas = new CheckBox();
            NUD_QTD_Caixas = new NumericUpDown();
            NUD_PESO_Gaiolas = new NumericUpDown();
            NUD_PESO_Pallets = new NumericUpDown();
            CHK_Pallets = new CheckBox();
            CHK_Gaiolas = new CheckBox();
            NUD_QTD_Pallets = new NumericUpDown();
            NUD_QTD_Gaiolas = new NumericUpDown();
            LBL_PesoBalanca = new Label();
            LBL_PesoGuias = new Label();
            LBL_PESO_TOTAL_Pallets = new Label();
            TXB_PESO_TOTAL_Pallets = new TextBox();
            TXB_PESO_TOTAL_Gaiolas = new TextBox();
            LBL_PESO_TOTAL_Gaiolas = new Label();
            TXB_PESO_TOTAL_Caixas = new TextBox();
            LBL_PESO_TOTAL_Caixas = new Label();
            TXB_PESO_DIFERENCA = new TextBox();
            groupBox4 = new GroupBox();
            LBL_PESO_AdicionalTotal = new Label();
            TXB_PESO_TOTAL_Adicional = new TextBox();
            LBL_PesoAdicional = new Label();
            BTN_Limpar = new Button();
            GP_Parametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_PESO_Balanca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_PESO_Guias).BeginInit();
            GP_PesoAdicional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_PESO_Caixas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_QTD_Caixas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_PESO_Gaiolas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_PESO_Pallets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_QTD_Pallets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_QTD_Gaiolas).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // GP_Parametros
            // 
            GP_Parametros.Controls.Add(NUD_PESO_Balanca);
            GP_Parametros.Controls.Add(NUD_PESO_Guias);
            GP_Parametros.Controls.Add(GP_PesoAdicional);
            GP_Parametros.Controls.Add(LBL_PesoBalanca);
            GP_Parametros.Controls.Add(LBL_PesoGuias);
            GP_Parametros.Location = new Point(12, 12);
            GP_Parametros.Name = "GP_Parametros";
            GP_Parametros.Size = new Size(264, 306);
            GP_Parametros.TabIndex = 0;
            GP_Parametros.TabStop = false;
            // 
            // NUD_PESO_Balanca
            // 
            NUD_PESO_Balanca.DecimalPlaces = 3;
            NUD_PESO_Balanca.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            NUD_PESO_Balanca.Location = new Point(135, 37);
            NUD_PESO_Balanca.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NUD_PESO_Balanca.Name = "NUD_PESO_Balanca";
            NUD_PESO_Balanca.Size = new Size(123, 23);
            NUD_PESO_Balanca.TabIndex = 1;
            NUD_PESO_Balanca.TextAlign = HorizontalAlignment.Center;
            NUD_PESO_Balanca.ThousandsSeparator = true;
            NUD_PESO_Balanca.ValueChanged += NUD_PESO_Guias_ValueChanged;
            // 
            // NUD_PESO_Guias
            // 
            NUD_PESO_Guias.DecimalPlaces = 3;
            NUD_PESO_Guias.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            NUD_PESO_Guias.Location = new Point(6, 36);
            NUD_PESO_Guias.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NUD_PESO_Guias.Name = "NUD_PESO_Guias";
            NUD_PESO_Guias.Size = new Size(123, 23);
            NUD_PESO_Guias.TabIndex = 0;
            NUD_PESO_Guias.TextAlign = HorizontalAlignment.Center;
            NUD_PESO_Guias.ThousandsSeparator = true;
            NUD_PESO_Guias.ValueChanged += NUD_PESO_Guias_ValueChanged;
            // 
            // GP_PesoAdicional
            // 
            GP_PesoAdicional.Controls.Add(LBL_PESO_Caixas);
            GP_PesoAdicional.Controls.Add(LBL_PESO_Gaiolas);
            GP_PesoAdicional.Controls.Add(LBL_PESO_Pallets);
            GP_PesoAdicional.Controls.Add(LBL_UND_Caixas);
            GP_PesoAdicional.Controls.Add(LBL_UND_Gaiolas);
            GP_PesoAdicional.Controls.Add(LBL_UND_Pallets);
            GP_PesoAdicional.Controls.Add(NUD_PESO_Caixas);
            GP_PesoAdicional.Controls.Add(CHK_Caixas);
            GP_PesoAdicional.Controls.Add(NUD_QTD_Caixas);
            GP_PesoAdicional.Controls.Add(NUD_PESO_Gaiolas);
            GP_PesoAdicional.Controls.Add(NUD_PESO_Pallets);
            GP_PesoAdicional.Controls.Add(CHK_Pallets);
            GP_PesoAdicional.Controls.Add(CHK_Gaiolas);
            GP_PesoAdicional.Controls.Add(NUD_QTD_Pallets);
            GP_PesoAdicional.Controls.Add(NUD_QTD_Gaiolas);
            GP_PesoAdicional.Location = new Point(6, 70);
            GP_PesoAdicional.Name = "GP_PesoAdicional";
            GP_PesoAdicional.Size = new Size(252, 230);
            GP_PesoAdicional.TabIndex = 8;
            GP_PesoAdicional.TabStop = false;
            GP_PesoAdicional.Text = "Peso Adiconal";
            // 
            // LBL_PESO_Caixas
            // 
            LBL_PESO_Caixas.AutoSize = true;
            LBL_PESO_Caixas.Enabled = false;
            LBL_PESO_Caixas.Location = new Point(222, 191);
            LBL_PESO_Caixas.Name = "LBL_PESO_Caixas";
            LBL_PESO_Caixas.Size = new Size(21, 15);
            LBL_PESO_Caixas.TabIndex = 22;
            LBL_PESO_Caixas.Text = "Kg";
            // 
            // LBL_PESO_Gaiolas
            // 
            LBL_PESO_Gaiolas.AutoSize = true;
            LBL_PESO_Gaiolas.Enabled = false;
            LBL_PESO_Gaiolas.Location = new Point(222, 126);
            LBL_PESO_Gaiolas.Name = "LBL_PESO_Gaiolas";
            LBL_PESO_Gaiolas.Size = new Size(21, 15);
            LBL_PESO_Gaiolas.TabIndex = 21;
            LBL_PESO_Gaiolas.Text = "Kg";
            // 
            // LBL_PESO_Pallets
            // 
            LBL_PESO_Pallets.AutoSize = true;
            LBL_PESO_Pallets.Enabled = false;
            LBL_PESO_Pallets.Location = new Point(222, 57);
            LBL_PESO_Pallets.Name = "LBL_PESO_Pallets";
            LBL_PESO_Pallets.Size = new Size(21, 15);
            LBL_PESO_Pallets.TabIndex = 20;
            LBL_PESO_Pallets.Text = "Kg";
            // 
            // LBL_UND_Caixas
            // 
            LBL_UND_Caixas.AutoSize = true;
            LBL_UND_Caixas.Enabled = false;
            LBL_UND_Caixas.Location = new Point(80, 191);
            LBL_UND_Caixas.Name = "LBL_UND_Caixas";
            LBL_UND_Caixas.Size = new Size(32, 15);
            LBL_UND_Caixas.TabIndex = 19;
            LBL_UND_Caixas.Text = "Und.";
            // 
            // LBL_UND_Gaiolas
            // 
            LBL_UND_Gaiolas.AutoSize = true;
            LBL_UND_Gaiolas.Enabled = false;
            LBL_UND_Gaiolas.Location = new Point(80, 126);
            LBL_UND_Gaiolas.Name = "LBL_UND_Gaiolas";
            LBL_UND_Gaiolas.Size = new Size(32, 15);
            LBL_UND_Gaiolas.TabIndex = 18;
            LBL_UND_Gaiolas.Text = "Und.";
            // 
            // LBL_UND_Pallets
            // 
            LBL_UND_Pallets.AutoSize = true;
            LBL_UND_Pallets.Enabled = false;
            LBL_UND_Pallets.Location = new Point(80, 57);
            LBL_UND_Pallets.Name = "LBL_UND_Pallets";
            LBL_UND_Pallets.Size = new Size(32, 15);
            LBL_UND_Pallets.TabIndex = 16;
            LBL_UND_Pallets.Text = "Und.";
            // 
            // NUD_PESO_Caixas
            // 
            NUD_PESO_Caixas.DecimalPlaces = 3;
            NUD_PESO_Caixas.Enabled = false;
            NUD_PESO_Caixas.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            NUD_PESO_Caixas.Location = new Point(128, 185);
            NUD_PESO_Caixas.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NUD_PESO_Caixas.Name = "NUD_PESO_Caixas";
            NUD_PESO_Caixas.Size = new Size(93, 23);
            NUD_PESO_Caixas.TabIndex = 11;
            NUD_PESO_Caixas.TextAlign = HorizontalAlignment.Center;
            NUD_PESO_Caixas.Value = new decimal(new int[] { 3, 0, 0, 0 });
            NUD_PESO_Caixas.ValueChanged += NUD_PESO_Guias_ValueChanged;
            // 
            // CHK_Caixas
            // 
            CHK_Caixas.AutoSize = true;
            CHK_Caixas.Location = new Point(14, 161);
            CHK_Caixas.Name = "CHK_Caixas";
            CHK_Caixas.Size = new Size(60, 19);
            CHK_Caixas.TabIndex = 9;
            CHK_Caixas.Text = "Caixas";
            CHK_Caixas.UseVisualStyleBackColor = true;
            CHK_Caixas.CheckedChanged += CHK_Caixas_CheckedChanged;
            // 
            // NUD_QTD_Caixas
            // 
            NUD_QTD_Caixas.Enabled = false;
            NUD_QTD_Caixas.Location = new Point(14, 185);
            NUD_QTD_Caixas.Name = "NUD_QTD_Caixas";
            NUD_QTD_Caixas.Size = new Size(64, 23);
            NUD_QTD_Caixas.TabIndex = 10;
            NUD_QTD_Caixas.TextAlign = HorizontalAlignment.Center;
            NUD_QTD_Caixas.ValueChanged += NUD_PESO_Guias_ValueChanged;
            // 
            // NUD_PESO_Gaiolas
            // 
            NUD_PESO_Gaiolas.DecimalPlaces = 3;
            NUD_PESO_Gaiolas.Enabled = false;
            NUD_PESO_Gaiolas.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            NUD_PESO_Gaiolas.Location = new Point(128, 119);
            NUD_PESO_Gaiolas.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NUD_PESO_Gaiolas.Name = "NUD_PESO_Gaiolas";
            NUD_PESO_Gaiolas.Size = new Size(93, 23);
            NUD_PESO_Gaiolas.TabIndex = 8;
            NUD_PESO_Gaiolas.TextAlign = HorizontalAlignment.Center;
            NUD_PESO_Gaiolas.Value = new decimal(new int[] { 80, 0, 0, 0 });
            NUD_PESO_Gaiolas.ValueChanged += NUD_PESO_Guias_ValueChanged;
            // 
            // NUD_PESO_Pallets
            // 
            NUD_PESO_Pallets.DecimalPlaces = 3;
            NUD_PESO_Pallets.Enabled = false;
            NUD_PESO_Pallets.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            NUD_PESO_Pallets.Location = new Point(128, 53);
            NUD_PESO_Pallets.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NUD_PESO_Pallets.Name = "NUD_PESO_Pallets";
            NUD_PESO_Pallets.Size = new Size(93, 23);
            NUD_PESO_Pallets.TabIndex = 5;
            NUD_PESO_Pallets.TextAlign = HorizontalAlignment.Center;
            NUD_PESO_Pallets.Value = new decimal(new int[] { 30, 0, 0, 0 });
            NUD_PESO_Pallets.ValueChanged += NUD_PESO_Guias_ValueChanged;
            // 
            // CHK_Pallets
            // 
            CHK_Pallets.AutoSize = true;
            CHK_Pallets.Location = new Point(14, 28);
            CHK_Pallets.Name = "CHK_Pallets";
            CHK_Pallets.Size = new Size(60, 19);
            CHK_Pallets.TabIndex = 3;
            CHK_Pallets.Text = "Pallets";
            CHK_Pallets.UseVisualStyleBackColor = true;
            CHK_Pallets.CheckedChanged += CHK_Pallets_CheckedChanged;
            // 
            // CHK_Gaiolas
            // 
            CHK_Gaiolas.AutoSize = true;
            CHK_Gaiolas.Location = new Point(14, 97);
            CHK_Gaiolas.Name = "CHK_Gaiolas";
            CHK_Gaiolas.Size = new Size(64, 19);
            CHK_Gaiolas.TabIndex = 6;
            CHK_Gaiolas.Text = "Gaiolas";
            CHK_Gaiolas.UseVisualStyleBackColor = true;
            CHK_Gaiolas.CheckedChanged += CHK_Gaiolas_CheckedChanged;
            // 
            // NUD_QTD_Pallets
            // 
            NUD_QTD_Pallets.Enabled = false;
            NUD_QTD_Pallets.Location = new Point(14, 53);
            NUD_QTD_Pallets.Name = "NUD_QTD_Pallets";
            NUD_QTD_Pallets.Size = new Size(64, 23);
            NUD_QTD_Pallets.TabIndex = 4;
            NUD_QTD_Pallets.TextAlign = HorizontalAlignment.Center;
            NUD_QTD_Pallets.ValueChanged += NUD_PESO_Guias_ValueChanged;
            // 
            // NUD_QTD_Gaiolas
            // 
            NUD_QTD_Gaiolas.Enabled = false;
            NUD_QTD_Gaiolas.Location = new Point(14, 119);
            NUD_QTD_Gaiolas.Name = "NUD_QTD_Gaiolas";
            NUD_QTD_Gaiolas.Size = new Size(64, 23);
            NUD_QTD_Gaiolas.TabIndex = 7;
            NUD_QTD_Gaiolas.TextAlign = HorizontalAlignment.Center;
            NUD_QTD_Gaiolas.ValueChanged += NUD_PESO_Guias_ValueChanged;
            // 
            // LBL_PesoBalanca
            // 
            LBL_PesoBalanca.AutoSize = true;
            LBL_PesoBalanca.Location = new Point(135, 18);
            LBL_PesoBalanca.Name = "LBL_PesoBalanca";
            LBL_PesoBalanca.Size = new Size(76, 15);
            LBL_PesoBalanca.TabIndex = 5;
            LBL_PesoBalanca.Text = "Peso Balança";
            // 
            // LBL_PesoGuias
            // 
            LBL_PesoGuias.AutoSize = true;
            LBL_PesoGuias.Location = new Point(6, 18);
            LBL_PesoGuias.Name = "LBL_PesoGuias";
            LBL_PesoGuias.Size = new Size(64, 15);
            LBL_PesoGuias.TabIndex = 3;
            LBL_PesoGuias.Text = "Peso Guias";
            // 
            // LBL_PESO_TOTAL_Pallets
            // 
            LBL_PESO_TOTAL_Pallets.AutoSize = true;
            LBL_PESO_TOTAL_Pallets.Location = new Point(6, 19);
            LBL_PESO_TOTAL_Pallets.Name = "LBL_PESO_TOTAL_Pallets";
            LBL_PESO_TOTAL_Pallets.Size = new Size(97, 15);
            LBL_PESO_TOTAL_Pallets.TabIndex = 1;
            LBL_PESO_TOTAL_Pallets.Text = "Peso Total Pallets";
            // 
            // TXB_PESO_TOTAL_Pallets
            // 
            TXB_PESO_TOTAL_Pallets.BackColor = SystemColors.ButtonHighlight;
            TXB_PESO_TOTAL_Pallets.Enabled = false;
            TXB_PESO_TOTAL_Pallets.Location = new Point(7, 37);
            TXB_PESO_TOTAL_Pallets.Name = "TXB_PESO_TOTAL_Pallets";
            TXB_PESO_TOTAL_Pallets.ReadOnly = true;
            TXB_PESO_TOTAL_Pallets.Size = new Size(174, 23);
            TXB_PESO_TOTAL_Pallets.TabIndex = 10;
            TXB_PESO_TOTAL_Pallets.TextAlign = HorizontalAlignment.Center;
            // 
            // TXB_PESO_TOTAL_Gaiolas
            // 
            TXB_PESO_TOTAL_Gaiolas.BackColor = SystemColors.ButtonHighlight;
            TXB_PESO_TOTAL_Gaiolas.Enabled = false;
            TXB_PESO_TOTAL_Gaiolas.Location = new Point(7, 81);
            TXB_PESO_TOTAL_Gaiolas.Name = "TXB_PESO_TOTAL_Gaiolas";
            TXB_PESO_TOTAL_Gaiolas.ReadOnly = true;
            TXB_PESO_TOTAL_Gaiolas.Size = new Size(174, 23);
            TXB_PESO_TOTAL_Gaiolas.TabIndex = 12;
            TXB_PESO_TOTAL_Gaiolas.TextAlign = HorizontalAlignment.Center;
            // 
            // LBL_PESO_TOTAL_Gaiolas
            // 
            LBL_PESO_TOTAL_Gaiolas.AutoSize = true;
            LBL_PESO_TOTAL_Gaiolas.Location = new Point(6, 63);
            LBL_PESO_TOTAL_Gaiolas.Name = "LBL_PESO_TOTAL_Gaiolas";
            LBL_PESO_TOTAL_Gaiolas.Size = new Size(101, 15);
            LBL_PESO_TOTAL_Gaiolas.TabIndex = 11;
            LBL_PESO_TOTAL_Gaiolas.Text = "Peso Total Gaiolas";
            // 
            // TXB_PESO_TOTAL_Caixas
            // 
            TXB_PESO_TOTAL_Caixas.BackColor = SystemColors.ButtonHighlight;
            TXB_PESO_TOTAL_Caixas.Enabled = false;
            TXB_PESO_TOTAL_Caixas.Location = new Point(7, 125);
            TXB_PESO_TOTAL_Caixas.Name = "TXB_PESO_TOTAL_Caixas";
            TXB_PESO_TOTAL_Caixas.ReadOnly = true;
            TXB_PESO_TOTAL_Caixas.Size = new Size(174, 23);
            TXB_PESO_TOTAL_Caixas.TabIndex = 14;
            TXB_PESO_TOTAL_Caixas.TextAlign = HorizontalAlignment.Center;
            // 
            // LBL_PESO_TOTAL_Caixas
            // 
            LBL_PESO_TOTAL_Caixas.AutoSize = true;
            LBL_PESO_TOTAL_Caixas.Location = new Point(6, 107);
            LBL_PESO_TOTAL_Caixas.Name = "LBL_PESO_TOTAL_Caixas";
            LBL_PESO_TOTAL_Caixas.Size = new Size(97, 15);
            LBL_PESO_TOTAL_Caixas.TabIndex = 13;
            LBL_PESO_TOTAL_Caixas.Text = "Peso Total Caixas";
            // 
            // TXB_PESO_DIFERENCA
            // 
            TXB_PESO_DIFERENCA.BackColor = SystemColors.ButtonHighlight;
            TXB_PESO_DIFERENCA.Enabled = false;
            TXB_PESO_DIFERENCA.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TXB_PESO_DIFERENCA.Location = new Point(7, 213);
            TXB_PESO_DIFERENCA.Multiline = true;
            TXB_PESO_DIFERENCA.Name = "TXB_PESO_DIFERENCA";
            TXB_PESO_DIFERENCA.ReadOnly = true;
            TXB_PESO_DIFERENCA.Size = new Size(174, 34);
            TXB_PESO_DIFERENCA.TabIndex = 15;
            TXB_PESO_DIFERENCA.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(LBL_PESO_AdicionalTotal);
            groupBox4.Controls.Add(TXB_PESO_TOTAL_Adicional);
            groupBox4.Controls.Add(LBL_PesoAdicional);
            groupBox4.Controls.Add(BTN_Limpar);
            groupBox4.Controls.Add(LBL_PESO_TOTAL_Pallets);
            groupBox4.Controls.Add(TXB_PESO_DIFERENCA);
            groupBox4.Controls.Add(TXB_PESO_TOTAL_Pallets);
            groupBox4.Controls.Add(TXB_PESO_TOTAL_Caixas);
            groupBox4.Controls.Add(LBL_PESO_TOTAL_Gaiolas);
            groupBox4.Controls.Add(LBL_PESO_TOTAL_Caixas);
            groupBox4.Controls.Add(TXB_PESO_TOTAL_Gaiolas);
            groupBox4.Location = new Point(282, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(188, 306);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            // 
            // LBL_PESO_AdicionalTotal
            // 
            LBL_PESO_AdicionalTotal.AutoSize = true;
            LBL_PESO_AdicionalTotal.Location = new Point(6, 195);
            LBL_PESO_AdicionalTotal.Name = "LBL_PESO_AdicionalTotal";
            LBL_PESO_AdicionalTotal.Size = new Size(57, 15);
            LBL_PESO_AdicionalTotal.TabIndex = 19;
            LBL_PESO_AdicionalTotal.Text = "Diferença";
            // 
            // TXB_PESO_TOTAL_Adicional
            // 
            TXB_PESO_TOTAL_Adicional.BackColor = SystemColors.ButtonHighlight;
            TXB_PESO_TOTAL_Adicional.Enabled = false;
            TXB_PESO_TOTAL_Adicional.Location = new Point(7, 169);
            TXB_PESO_TOTAL_Adicional.Name = "TXB_PESO_TOTAL_Adicional";
            TXB_PESO_TOTAL_Adicional.ReadOnly = true;
            TXB_PESO_TOTAL_Adicional.Size = new Size(174, 23);
            TXB_PESO_TOTAL_Adicional.TabIndex = 18;
            TXB_PESO_TOTAL_Adicional.TextAlign = HorizontalAlignment.Center;
            // 
            // LBL_PesoAdicional
            // 
            LBL_PesoAdicional.AutoSize = true;
            LBL_PesoAdicional.Location = new Point(6, 151);
            LBL_PesoAdicional.Name = "LBL_PesoAdicional";
            LBL_PesoAdicional.Size = new Size(113, 15);
            LBL_PesoAdicional.TabIndex = 17;
            LBL_PesoAdicional.Text = "Peso Adicional Total";
            // 
            // BTN_Limpar
            // 
            BTN_Limpar.Location = new Point(7, 257);
            BTN_Limpar.Name = "BTN_Limpar";
            BTN_Limpar.Size = new Size(174, 43);
            BTN_Limpar.TabIndex = 16;
            BTN_Limpar.Text = "Limpar";
            BTN_Limpar.UseVisualStyleBackColor = true;
            BTN_Limpar.Click += BTN_Limpar_Click;
            // 
            // FRM_Pesagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(485, 330);
            Controls.Add(groupBox4);
            Controls.Add(GP_Parametros);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FRM_Pesagem";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesagem";
            GP_Parametros.ResumeLayout(false);
            GP_Parametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_PESO_Balanca).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_PESO_Guias).EndInit();
            GP_PesoAdicional.ResumeLayout(false);
            GP_PesoAdicional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_PESO_Caixas).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_QTD_Caixas).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_PESO_Gaiolas).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_PESO_Pallets).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_QTD_Pallets).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_QTD_Gaiolas).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GP_Parametros;
        private GroupBox GP_PesoAdicional;
        private NumericUpDown NUD_QTD_Pallets;
        private NumericUpDown NUD_QTD_Gaiolas;
        private Label LBL_PesoBalanca;
        private Label LBL_PesoGuias;
        private NumericUpDown NUD_PESO_Gaiolas;
        private NumericUpDown NUD_PESO_Pallets;
        private CheckBox CHK_Pallets;
        private CheckBox CHK_Gaiolas;
        private Label LBL_PESO_TOTAL_Pallets;
        private NumericUpDown NUD_PESO_Caixas;
        private CheckBox CHK_Caixas;
        private NumericUpDown NUD_QTD_Caixas;
        private TextBox TXB_PESO_TOTAL_Pallets;
        private TextBox TXB_PESO_TOTAL_Gaiolas;
        private Label LBL_PESO_TOTAL_Gaiolas;
        private TextBox TXB_PESO_TOTAL_Caixas;
        private Label LBL_PESO_TOTAL_Caixas;
        private TextBox TXB_PESO_DIFERENCA;
        private GroupBox groupBox4;
        private Label LBL_UND_Caixas;
        private Label LBL_UND_Gaiolas;
        private Label LBL_UND_Pallets;
        private Label LBL_PESO_Caixas;
        private Label LBL_PESO_Gaiolas;
        private Label LBL_PESO_Pallets;
        private Button BTN_Limpar;
        private NumericUpDown NUD_PESO_Balanca;
        private NumericUpDown NUD_PESO_Guias;
        private TextBox TXB_PESO_TOTAL_Adicional;
        private Label LBL_PesoAdicional;
        private Label LBL_PESO_AdicionalTotal;
    }
}