namespace EsGarage_Andreella
{
    partial class Form1
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
            txtMarca = new TextBox();
            lblMarca = new Label();
            btnAggiungi = new Button();
            lblAnno = new Label();
            txtAnno = new TextBox();
            lblCilindrata = new Label();
            txtCilindrata = new TextBox();
            cmbAlimentazione = new ComboBox();
            cmbTempi = new ComboBox();
            lblAlimentazione = new Label();
            lblAuto = new Label();
            lblMoto = new Label();
            lblFurgone = new Label();
            lblTempi = new Label();
            lblCapacità = new Label();
            txtCapacità = new TextBox();
            lblPorte = new Label();
            txtPorte = new TextBox();
            lstGarage = new ListBox();
            lblVeicolo = new Label();
            cmbVeicolo = new ComboBox();
            btnRimuovi = new Button();
            btnInformazioni = new Button();
            lblGarage = new Label();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Verdana", 9F);
            txtMarca.Location = new Point(278, 91);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 26);
            txtMarca.TabIndex = 0;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblMarca.Location = new Point(279, 61);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(69, 18);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "MARCA";
            // 
            // btnAggiungi
            // 
            btnAggiungi.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnAggiungi.Location = new Point(33, 437);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(110, 29);
            btnAggiungi.TabIndex = 2;
            btnAggiungi.Text = "AGGIUNGI";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // lblAnno
            // 
            lblAnno.AutoSize = true;
            lblAnno.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblAnno.Location = new Point(125, 61);
            lblAnno.Name = "lblAnno";
            lblAnno.Size = new Size(57, 18);
            lblAnno.TabIndex = 4;
            lblAnno.Text = "ANNO";
            // 
            // txtAnno
            // 
            txtAnno.Font = new Font("Verdana", 9F);
            txtAnno.Location = new Point(124, 91);
            txtAnno.Name = "txtAnno";
            txtAnno.Size = new Size(125, 26);
            txtAnno.TabIndex = 3;
            txtAnno.KeyPress += txtAnno_KeyPress;
            // 
            // lblCilindrata
            // 
            lblCilindrata.AutoSize = true;
            lblCilindrata.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblCilindrata.Location = new Point(439, 61);
            lblCilindrata.Name = "lblCilindrata";
            lblCilindrata.Size = new Size(115, 18);
            lblCilindrata.TabIndex = 6;
            lblCilindrata.Text = "CILINDRATA";
            // 
            // txtCilindrata
            // 
            txtCilindrata.Font = new Font("Verdana", 9F);
            txtCilindrata.Location = new Point(438, 91);
            txtCilindrata.Name = "txtCilindrata";
            txtCilindrata.Size = new Size(125, 26);
            txtCilindrata.TabIndex = 5;
            txtCilindrata.KeyPress += txtCilindrata_KeyPress;
            // 
            // cmbAlimentazione
            // 
            cmbAlimentazione.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlimentazione.Font = new Font("Verdana", 9F);
            cmbAlimentazione.FormattingEnabled = true;
            cmbAlimentazione.Location = new Point(270, 162);
            cmbAlimentazione.Name = "cmbAlimentazione";
            cmbAlimentazione.Size = new Size(151, 26);
            cmbAlimentazione.TabIndex = 7;
            // 
            // cmbTempi
            // 
            cmbTempi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTempi.Font = new Font("Verdana", 9F);
            cmbTempi.FormattingEnabled = true;
            cmbTempi.Location = new Point(125, 242);
            cmbTempi.Name = "cmbTempi";
            cmbTempi.Size = new Size(151, 26);
            cmbTempi.TabIndex = 8;
            // 
            // lblAlimentazione
            // 
            lblAlimentazione.AutoSize = true;
            lblAlimentazione.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblAlimentazione.Location = new Point(270, 139);
            lblAlimentazione.Name = "lblAlimentazione";
            lblAlimentazione.Size = new Size(149, 18);
            lblAlimentazione.TabIndex = 9;
            lblAlimentazione.Text = "ALIMENTAZIONE";
            // 
            // lblAuto
            // 
            lblAuto.AutoSize = true;
            lblAuto.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblAuto.Location = new Point(14, 162);
            lblAuto.Name = "lblAuto";
            lblAuto.Size = new Size(55, 18);
            lblAuto.TabIndex = 10;
            lblAuto.Text = "AUTO";
            // 
            // lblMoto
            // 
            lblMoto.AutoSize = true;
            lblMoto.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblMoto.Location = new Point(14, 242);
            lblMoto.Name = "lblMoto";
            lblMoto.Size = new Size(58, 18);
            lblMoto.TabIndex = 11;
            lblMoto.Text = "MOTO";
            // 
            // lblFurgone
            // 
            lblFurgone.AutoSize = true;
            lblFurgone.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblFurgone.Location = new Point(14, 317);
            lblFurgone.Name = "lblFurgone";
            lblFurgone.Size = new Size(89, 18);
            lblFurgone.TabIndex = 12;
            lblFurgone.Text = "FURGONE";
            // 
            // lblTempi
            // 
            lblTempi.AutoSize = true;
            lblTempi.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblTempi.Location = new Point(125, 219);
            lblTempi.Name = "lblTempi";
            lblTempi.Size = new Size(61, 18);
            lblTempi.TabIndex = 13;
            lblTempi.Text = "TEMPI";
            // 
            // lblCapacità
            // 
            lblCapacità.AutoSize = true;
            lblCapacità.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblCapacità.Location = new Point(125, 305);
            lblCapacità.Name = "lblCapacità";
            lblCapacità.Size = new Size(100, 18);
            lblCapacità.TabIndex = 15;
            lblCapacità.Text = "CAPACITA'";
            // 
            // txtCapacità
            // 
            txtCapacità.Font = new Font("Verdana", 9F);
            txtCapacità.Location = new Point(125, 328);
            txtCapacità.Name = "txtCapacità";
            txtCapacità.Size = new Size(125, 26);
            txtCapacità.TabIndex = 14;
            txtCapacità.KeyPress += txtCapacità_KeyPress;
            // 
            // lblPorte
            // 
            lblPorte.AutoSize = true;
            lblPorte.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblPorte.Location = new Point(125, 139);
            lblPorte.Name = "lblPorte";
            lblPorte.Size = new Size(64, 18);
            lblPorte.TabIndex = 17;
            lblPorte.Text = "PORTE";
            // 
            // txtPorte
            // 
            txtPorte.Font = new Font("Verdana", 9F);
            txtPorte.Location = new Point(125, 163);
            txtPorte.Name = "txtPorte";
            txtPorte.Size = new Size(125, 26);
            txtPorte.TabIndex = 16;
            txtPorte.KeyPress += txtPorte_KeyPress;
            // 
            // lstGarage
            // 
            lstGarage.Font = new Font("Verdana", 9F);
            lstGarage.FormattingEnabled = true;
            lstGarage.Location = new Point(439, 163);
            lstGarage.Name = "lstGarage";
            lstGarage.Size = new Size(671, 310);
            lstGarage.TabIndex = 18;
            // 
            // lblVeicolo
            // 
            lblVeicolo.AutoSize = true;
            lblVeicolo.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblVeicolo.Location = new Point(596, 61);
            lblVeicolo.Name = "lblVeicolo";
            lblVeicolo.Size = new Size(84, 18);
            lblVeicolo.TabIndex = 20;
            lblVeicolo.Text = "VEICOLO";
            // 
            // cmbVeicolo
            // 
            cmbVeicolo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVeicolo.Font = new Font("Verdana", 9F);
            cmbVeicolo.FormattingEnabled = true;
            cmbVeicolo.Location = new Point(596, 91);
            cmbVeicolo.Name = "cmbVeicolo";
            cmbVeicolo.Size = new Size(151, 26);
            cmbVeicolo.TabIndex = 19;
            // 
            // btnRimuovi
            // 
            btnRimuovi.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnRimuovi.Location = new Point(182, 437);
            btnRimuovi.Name = "btnRimuovi";
            btnRimuovi.Size = new Size(94, 29);
            btnRimuovi.TabIndex = 21;
            btnRimuovi.Text = "RIMUOVI";
            btnRimuovi.UseVisualStyleBackColor = true;
            btnRimuovi.Click += btnRimuovi_Click;
            // 
            // btnInformazioni
            // 
            btnInformazioni.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnInformazioni.Location = new Point(309, 437);
            btnInformazioni.Name = "btnInformazioni";
            btnInformazioni.Size = new Size(94, 29);
            btnInformazioni.TabIndex = 22;
            btnInformazioni.Text = "INFO";
            btnInformazioni.UseVisualStyleBackColor = true;
            btnInformazioni.Click += btnInformazioni_Click;
            // 
            // lblGarage
            // 
            lblGarage.AutoSize = true;
            lblGarage.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblGarage.Location = new Point(14, 18);
            lblGarage.Name = "lblGarage";
            lblGarage.Size = new Size(169, 18);
            lblGarage.TabIndex = 23;
            lblGarage.Text = "GESTIONE GARAGE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 529);
            Controls.Add(lblGarage);
            Controls.Add(btnInformazioni);
            Controls.Add(btnRimuovi);
            Controls.Add(lblVeicolo);
            Controls.Add(cmbVeicolo);
            Controls.Add(lstGarage);
            Controls.Add(lblPorte);
            Controls.Add(txtPorte);
            Controls.Add(lblCapacità);
            Controls.Add(txtCapacità);
            Controls.Add(lblTempi);
            Controls.Add(lblFurgone);
            Controls.Add(lblMoto);
            Controls.Add(lblAuto);
            Controls.Add(lblAlimentazione);
            Controls.Add(cmbTempi);
            Controls.Add(cmbAlimentazione);
            Controls.Add(lblCilindrata);
            Controls.Add(txtCilindrata);
            Controls.Add(lblAnno);
            Controls.Add(txtAnno);
            Controls.Add(btnAggiungi);
            Controls.Add(lblMarca);
            Controls.Add(txtMarca);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarca;
        private Label lblMarca;
        private Button btnAggiungi;
        private Label lblAnno;
        private TextBox txtAnno;
        private Label lblCilindrata;
        private TextBox txtCilindrata;
        private ComboBox cmbAlimentazione;
        private ComboBox cmbTempi;
        private Label lblAlimentazione;
        private Label lblAuto;
        private Label lblMoto;
        private Label lblFurgone;
        private Label lblTempi;
        private Label lblCapacità;
        private TextBox txtCapacità;
        private Label lblPorte;
        private TextBox txtPorte;
        private ListBox lstGarage;
        private Label lblVeicolo;
        private ComboBox cmbVeicolo;
        private Button btnRimuovi;
        private Button btnInformazioni;
        private Label lblGarage;
    }
}
