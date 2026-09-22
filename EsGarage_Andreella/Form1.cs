namespace EsGarage_Andreella
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            cmbAlimentazione.DataSource = new string[] { "Diesel", "Benzina" };
            cmbVeicolo.DataSource = new string[] { "Auto", "Moto", "Furgone" };
            cmbTempi.DataSource = new string[] { "2 tempi", "4 tempi" };
        }
        public CGarage garage = new CGarage();

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (garage.elencoVeicoli.Count < CGarage.MaxVeicoli)
            {
                int id = garage.elencoVeicoli.Count;
                string marca = txtMarca.Text;
                if (string.IsNullOrEmpty(marca))
                {
                    MessageBox.Show("Marca vuota");
                    return;
                }
                int anno;
                if (!int.TryParse(txtAnno.Text, out anno) || anno < 1850 || anno > DateTime.Now.Year)
                {
                    MessageBox.Show("Anno non valido");
                    txtAnno.Text = "";
                    return;
                }
                int cilindrata;
                if (!int.TryParse(txtCilindrata.Text, out cilindrata) || cilindrata < 0 || cilindrata > 100000)
                {
                    MessageBox.Show("Cilindrata non valida");
                    txtCilindrata.Text = "";
                    return;
                }
                try
                {
                    switch (cmbVeicolo.SelectedItem)
                    {
                        case "Auto":
                            int porte;
                            if (!int.TryParse(txtPorte.Text, out porte) || porte < 0 || porte > 10)
                            {
                                MessageBox.Show("Porte non valide");
                                txtPorte.Text = "";
                                return;
                            }
                            if (cmbAlimentazione.SelectedItem == null)
                            {
                                MessageBox.Show("Seleziona un tipo di alimentazione.");
                                return;
                            }
                            string alimentazione = cmbAlimentazione.SelectedItem.ToString();
                            CAuto auto = new CAuto(id, marca, anno, cilindrata, porte, alimentazione);
                            garage.AggiungiVeicolo(auto);
                            break;
                        case "Moto":
                            if (cmbTempi.SelectedItem == null)
                            {
                                MessageBox.Show("Seleziona un tipo di motore.");
                                return;
                            }
                            string tempi = cmbTempi.SelectedItem.ToString();
                            CMoto moto = new CMoto(id, marca, anno, cilindrata, tempi);
                            garage.AggiungiVeicolo(moto);
                            break;
                        case "Furgone":
                            int capacità;
                            if (!int.TryParse(txtCapacità.Text, out capacità) || capacità < 0 || capacità > 10000)
                            {
                                MessageBox.Show("Capacità non valida");
                                txtCapacità.Text = "";
                                return;
                            }
                            CFurgone furgone = new CFurgone(id, marca, anno, cilindrata, capacità);
                            garage.AggiungiVeicolo(furgone);
                            break;
                        default:
                            MessageBox.Show("Seleziona un tipo di veicolo valido.");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                AggiornaListaVeicoli();
                SvuotaCampi();
            }
            else
            {
                MessageBox.Show("Garage pieno");
            }
        }

        private void AggiornaListaVeicoli()
        {
            lstGarage.Items.Clear();
            foreach (var veicolo in garage.elencoVeicoli)
            {
                lstGarage.Items.Add(veicolo.StampaInformazioni());
            }
        }

        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            int posto = lstGarage.SelectedIndex;
            if (posto >= 0)
            {
                CVeicolo risultato = garage.EstrazioneVeicolo(posto);
                MessageBox.Show("Rimosso: " + risultato.StampaInformazioni());
                AggiornaListaVeicoli();
            }
            else
            {
                MessageBox.Show("Seleziona un veicolo da rimuovere.");
            }
        }

        private void btnInformazioni_Click(object sender, EventArgs e)
        {
            if (garage.elencoVeicoli.Count > 0)
            {
                string informazioni = garage.StampaSituazione();
                MessageBox.Show(informazioni);
            }
            else
            {
                MessageBox.Show("Il garage è vuoto.");
            }
        }

        private void SvuotaCampi()
        {
            txtMarca.Text = "";
            txtAnno.Text = "";
            txtCilindrata.Text = "";
            txtPorte.Text = "";
            txtCapacità.Text = "";
        }

        private void txtAnno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Clear)
            {
                e.KeyChar = (char)0;
            }
        }

        private void txtCilindrata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Clear)
            {
                e.KeyChar = (char)0;
            }
        }

        private void txtPorte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Clear)
            {
                e.KeyChar = (char)0;
            }
        }

        private void txtCapacità_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Clear)
            {
                e.KeyChar = (char)0;
            }
        }

    }
}
