using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_ADO
{
    public partial class LOGIN : Form
    {
        

        public LOGIN()
        {
            InitializeComponent();
        }
        ADO ado = new ADO();
        private void LOGIN_Load(object sender, EventArgs e)
        {
            ado.CONNECTER();
            this.TopMost = true;
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            bool login = false;
            //On a crée la commande de SQL
            ado.cmd.CommandText = "select Mat, Nom from STAGIAIRE1";
            //On a exécuté la commande dans la connection
            ado.cmd.Connection = ado.con;
            //On a exécuter la commande avec ExecuteReader()
            ado.dr = ado.cmd.ExecuteReader();

            while (ado.dr.Read())
            {
                if(txtUtilisateur.Text.Equals(ado.dr[1].ToString()) && txtMotDePasse.Text.Equals(ado.dr[0].ToString()))
                {
                    login = true;
                    break;
                    //Form1 f1 = new Form1();
                    //f1.Show();
                }
            }
            if(login == true)
            {
                this.Hide();
                Form1 formPrincipale = new Form1();
                formPrincipale.Show();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrecte !");
            }
            ado.dr.Close();
                
        }
    }
}
