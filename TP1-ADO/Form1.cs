using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace TP1_ADO
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ADO ado = new ADO();
        public static int cpt;
     
        //On crée une méthode global pour vider n'importe quel champ 
        //Déclaration de la méthode nombre
        public int PrimaryKey()
        {
            int cpt1;
            //On déclare variable pour le nombre de count
            
            ado.cmd.CommandText = "select count(Mat) from STAGIAIRE1 where Mat = '"+ txtmat.Text+ "'";
            ado.cmd.Connection = ado.con;
            cpt1 = (int)ado.cmd.ExecuteScalar();//Si on cherche a retourné une seul valeur on utilise ExecuteScalar()  
            return cpt1;
        }
        //Déclaration de la méthode AJOUTER
        public bool Ajouter()
        {
            //if(PrimaryKey() == 0)
            //{
            //    ado.cmd.CommandText = "insert into STAGIAIRE1 values ('" + txtmat.Text + "','" + txtNom.Text + "','" + txtPrenom.Text + "','" +  txtMoyenne.Text + "','" + txtAge.Text+ "')";
            //    ado.cmd.Connection = ado.con;
            //    ado.cmd.ExecuteNonQuery();//On execute la méthod ExecuteNonQuery dans le mode connecté, dans le cas de Insert Update or Delete
            //    return true;
            //}
            //return false;
            if (PrimaryKey() == 0)
            {
                ado.cmd.CommandText = " insert into STAGIAIRE1 values ('" + txtmat.Text + "','" + txtNom.Text + "','" + txtPrenom.Text + "','" + txtMoyenne.Text + "','" + txtAge.Text + "')";
                ado.cmd.Connection = ado.con;
                ado.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        //Déclaration de la méthode Update
        public bool Modifie()
        {
            if (PrimaryKey() != 0)
            {
                ado.cmd.CommandText = "update STAGIAIRE1 set Nom = '"  + txtNom.Text + "', Prenom = '" + txtPrenom.Text + "', Moyenne = '" + txtMoyenne.Text + "', Age = '" + txtAge.Text + "' where Mat = '" + txtmat.Text + "'";
                ado.cmd.Connection = ado.con;
                ado.cmd.ExecuteNonQuery();//On execute la méthod ExecuteNonQuery (dans le mode connecté), dans le cas de Insert Update or Delete
                return true;
            }
            return false;
        }
        //Déclaration de la méthode SUPRIMER
        public bool Supprimer()
        {
            if (PrimaryKey() != 0)
            {
                ado.cmd.CommandText = "delete from STAGIAIRE1 where Mat = '" + txtmat.Text + "'";
                ado.cmd.Connection = ado.con;
                ado.cmd.ExecuteNonQuery();//On execute la méthod ExecuteNonQuery dans le modfe connecté, dans le cas de Insert Update or Delete
                return true;
            }
            return false;
        }
        //Remplissage de DataGridView
        public void RemplissageDataGrideViex()
        {
            if(ado.dt.Rows != null)
            {
                ado.dt.Clear();
            }
            ado.cmd.CommandText = "select * from STAGIAIRE1";
            ado.cmd.Connection = ado.con;
            ado.dr = ado.cmd.ExecuteReader();
            ado.dt.Load(ado.dr);
            dataGridView1.DataSource = ado.dt;
            ado.dr.Close();
        }
        public void VIDER(Control f)
        {
            foreach( Control ct in f.Controls)
            {
                if(ct.GetType() == typeof(TextBox))
                {
                    ct.Text = "";
                }
                if(ct.Controls.Count !=0)
                {
                    VIDER(ct);
                }
                
            }
        }
        public void Navigation()
        {
            txtmat.Text = ado.dt.Rows[cpt][0].ToString();
            txtNom.Text = ado.dt.Rows[cpt][1].ToString();
            txtPrenom.Text = ado.dt.Rows[cpt][2].ToString();
            txtMoyenne.Text = ado.dt.Rows[cpt][3].ToString();
            txtAge.Text = ado.dt.Rows[cpt][4].ToString();
        }
        public void RemplirComboMatricule()
        {
            cmbMat.Items.Clear();
            //On crée la requête pour remplir le combo
            ado.cmd.CommandText = "select Mat from STAGIAIRE1";
            ado.cmd.Connection = ado.con;
            ado.dr = ado.cmd.ExecuteReader();
            //ado.dt.Load(ado.dr);
            while (ado.dr.Read())
            {
                cmbMat.Items.Add(ado.dr[0]);
            }
            ado.dr.Close();
        }
        DataTable dataExporter = new DataTable();
        public void ExporterDonneesText()
        {
            ado.cmd.CommandText = "select * from STAGIAIRE1";
            ado.cmd.Connection = ado.con;
            ado.dr = ado.cmd.ExecuteReader();
            //On mit les données retournées dans la variable dataExporter
            dataExporter.Load(ado.dr);
            if(MessageBox.Show("Voulez vous vraiment enregistrer vos données ?", "Confirmation", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                try
                {
                    string chemin = "";
                    saveFileDialog1.Filter = "Text Files |.*txt";
                    if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        chemin = saveFileDialog1.FileName;
                    }
                    StreamWriter streamWriter = new StreamWriter(chemin);
                    for(int i = 0; i < dataExporter.Rows.Count; i++)
                    {
                        streamWriter.WriteLine(dataExporter.Rows[i][0].ToString() + ";" + dataExporter.Rows[i][1].ToString() + ";" + dataExporter.Rows[i][2].ToString() + ";"+ dataExporter.Rows[i][3].ToString() + ";" + dataExporter.Rows[i][4].ToString() + ";");
                    }
                    streamWriter.Close();
                }
                catch
                {
                    MessageBox.Show("Erreur d'Exportation !");
                }
            }
            ado.dr.Close();
        }
        public void ExporterDonnesHTML() 
        {
            ado.cmd.CommandText = "select * from STAGIAIRE1";
            ado.cmd.Connection = ado.con;
            ado.dr = ado.cmd.ExecuteReader();
            //On mit les données retournées dans la variable dataExporter
            dataExporter.Load(ado.dr);
            if (MessageBox.Show("Voulez vous vraiment enregistrer vos données ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string chemin = "";
                    saveFileDialog1.Filter = "html files |.*html";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        chemin = saveFileDialog1.FileName;
                    }
                    StreamWriter streamWriter = new StreamWriter(chemin);
                    FileInfo info = new FileInfo(chemin);
                    StringBuilder sb = new StringBuilder(); //Pour crée l'arbre de html
                    sb.AppendFormat("<html>");
                    sb.AppendFormat("<head>");
                    sb.AppendFormat("<title>Gestion des stagiaires</title>");
                    sb.AppendFormat("<meta charest='UTF-8'/>");
                    sb.AppendFormat("</head>");
                    sb.AppendFormat("<body>");
                    sb.AppendFormat("<table border=1 cellspacing=10 cellpadding=10 style='border-collapse:collapse';>");
                    sb.AppendFormat("<thead>");
                    sb.AppendFormat("<tr>");
                    foreach (DataColumn c in dataExporter.Columns)
                    {
                        sb.AppendFormat("<th> {0} </th>", c.ColumnName);
                    }
                    sb.AppendFormat("</tr>");
                    sb.AppendFormat("</thead>");
                    sb.AppendFormat("<tr>");
                    foreach(DataRow r in dataExporter.Rows)//Pour chaque Rows j'ajoute une balise <tr>
                    {
                        sb.AppendFormat("<tr>");
                        for(int i = 0; i < dataExporter.Columns.Count; i++)
                        {
                            sb.AppendFormat("<td> {0} </td>", r[i].ToString());
                        }
                        sb.AppendFormat("</tr>");
                    }



                    //sb.AppendFormat("</thead>");
                    sb.AppendFormat("</table>");
                    sb.AppendFormat("</body>");
                    sb.AppendFormat("</html>");
                    //On écrit de le fichier streamWriter ce qu'on écrit
                    streamWriter.WriteLine(sb.ToString());
                    MessageBox.Show("l'exportation a bien réussi !");
                    streamWriter.Close();
                }
                catch
                {
                    MessageBox.Show("Erreur d'Exportation !");
                }
            }
            ado.dr.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Au load de la page on ouvre la connection
            ado.CONNECTER();
            //On crée une commande
            //ado.cmd.CommandText = "select * from STAGIAIRE1";
            ////Cette command veut dire la commande cmd.commandeText fonction dans la chaine de connection pour atteindre la base de donnée pour exécuté la requête et récupéré les données 
            //ado.cmd.Connection = ado.con;
            ////On utilise exécute reader si on veut avoir un flot de donnée
            //ado.dr = ado.cmd.ExecuteReader();
            ////dt son rôle et de prendre tout les données qui sont dans la bse de donnée et de les mettre dans le DataTable
            //ado.dt.Load(ado.dr);//méthode Load prend les données et les mettre dans le dt(DataTable)
            //dataGridView1.DataSource = ado.dt;
            //ado.dr.Close();
            RemplissageDataGrideViex();
            RemplirComboMatricule();


        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez vous quitter ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //On ferme la connection
                ado.DECONNECTER();
                //On ferme cette forme
                //this.Close();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void BtnVider_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Vouslez vous vider les champs ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                VIDER(this);
            }
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            if(txtmat.Text == string.Empty
                || txtNom.Text == string.Empty
                || txtPrenom.Text == string.Empty
                || txtMoyenne.Text == string.Empty
                || txtAge.Text == string.Empty)
            {
                MessageBox.Show("Merci de remplir tous les champs !");
            }
            if(Ajouter() == true)
            {
                MessageBox.Show("Ce stagiaire est ajouter avec succès !");
                RemplissageDataGrideViex();
            }
            else
            {
                MessageBox.Show("Ce stagiaire existe déjà ! ");
            }
        }

        private void BtnSuprimer_Click(object sender, EventArgs e)
        {
            if (txtmat.Text == string.Empty)
            {
                MessageBox.Show("Merci de remplir tous les champs de matricule !");
            }
            if (Supprimer() == true)
            {
                MessageBox.Show("Ce stagiaire est supprimer de la base de donnée !");
                RemplissageDataGrideViex();
            }
            else
            {
                MessageBox.Show("Ce stagiaire n'existe pas ! ");
            }
        }

        private void BtnModifie_Click(object sender, EventArgs e)
        {
            if (txtmat.Text == string.Empty
                || txtNom.Text == string.Empty
                || txtPrenom.Text == string.Empty
                || txtMoyenne.Text == string.Empty
                || txtAge.Text == string.Empty)
            {
                MessageBox.Show("Merci de remplir tous les champs de matricule !");
            }
            if (Modifie() == true)
            {
                MessageBox.Show("Ce stagiaire est mis à jour dans la base de donnée !");
                RemplissageDataGrideViex();
            }
            else
            {
                MessageBox.Show("Ce stagiaire n'existe pas ! ");
            }
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            cpt = 0;
            Navigation();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            cpt = ado.dt.Rows.Count - 1;
            Navigation();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            try
            {
                cpt++;
                Navigation();
            }
            catch
            {
                MessageBox.Show("Vous êtes sur le dernier enregistrement !");
                cpt--;
            }
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            try
            {
                cpt--;
                Navigation();
            }
            catch
            {
                MessageBox.Show("Vous êtes sur le premier enregistrement !");
                cpt++;
            }
        }

        private void btnExporterDonnee_Click(object sender, EventArgs e)
        {
            ExporterDonneesText();
        }

        private void btnExpoterDonnesHTML_Click(object sender, EventArgs e)
        {
            ExporterDonnesHTML();
        }
    }
}
