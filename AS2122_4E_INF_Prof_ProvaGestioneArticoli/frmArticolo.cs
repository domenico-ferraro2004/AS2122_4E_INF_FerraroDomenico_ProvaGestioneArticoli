using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4E_INF_Prof_ProvaGestioneArticoli
{
    public partial class frmArticolo : Form
    {
        DialogResult status = DialogResult.Cancel;

        // TODO: (5) aggiungere attributi privati dei dati inseriti nella frmArticoli
        // ...
        private string descrizione;
        private string unitaMisura;
        private double prezzo;
        

        public DialogResult Status { get { return status; } }

        // TODO: (6) aggiungere property di sola lettura dei dati inseriti nella frmArticoli per l'utilizzo in frmMain
        // ...
        
        public string Descrizione
        {
            get { return descrizione; }
        }

        public string UnitaMisura
        {
            get { return unitaMisura; }
        }

        public double Prezzo
        {
            get { return prezzo; }
        }
           
        public frmArticolo()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // TODO: (7) passaggio all' attributo/property dei dati inseriti nella frmArticoli con controllo di valorizzazione del dato
            // ... descrizione, unitaMisura, prezzo
            if (txtPrezzo.text != "" && txtDescrizione.text != "" & cmbUnitaMisura.text != "")
            {
                descrizione = txtDescrizione.text;
                unitaMisura = cmbUnitaMisura;
                prezzo = txtPrezzo;
            }
            else
            {
                Message.Box("Inserisci tutti i dati");
            }
            status = DialogResult.OK;
            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            status = DialogResult.Cancel;
            Close();
        }
    }
}
