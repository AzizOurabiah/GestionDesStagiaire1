
namespace TP1_ADO
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoyenne = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.BtnVider = new System.Windows.Forms.Button();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.BtnModifie = new System.Windows.Forms.Button();
            this.BtnSuprimer = new System.Windows.Forms.Button();
            this.txtmat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.cmbMat = new System.Windows.Forms.ComboBox();
            this.Mat = new System.Windows.Forms.Label();
            this.btnExporterDonnee = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnExpoterDonnesHTML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(215, 105);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(210, 33);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(215, 146);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(210, 33);
            this.txtPrenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(101, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom :";
            // 
            // txtMoyenne
            // 
            this.txtMoyenne.Location = new System.Drawing.Point(215, 186);
            this.txtMoyenne.Name = "txtMoyenne";
            this.txtMoyenne.Size = new System.Drawing.Size(210, 33);
            this.txtMoyenne.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(101, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Moyenne :";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(215, 225);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(210, 33);
            this.txtAge.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(101, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(573, 257);
            this.dataGridView1.TabIndex = 8;
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnFermer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnFermer.Location = new System.Drawing.Point(289, 384);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(119, 37);
            this.BtnFermer.TabIndex = 9;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // BtnVider
            // 
            this.BtnVider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnVider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVider.Location = new System.Drawing.Point(148, 384);
            this.BtnVider.Name = "BtnVider";
            this.BtnVider.Size = new System.Drawing.Size(119, 37);
            this.BtnVider.TabIndex = 10;
            this.BtnVider.Text = "Vider";
            this.BtnVider.UseVisualStyleBackColor = false;
            this.BtnVider.Click += new System.EventHandler(this.BtnVider_Click);
            // 
            // BtnAjout
            // 
            this.BtnAjout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAjout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAjout.Location = new System.Drawing.Point(27, 326);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(106, 37);
            this.BtnAjout.TabIndex = 12;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.UseVisualStyleBackColor = false;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // BtnModifie
            // 
            this.BtnModifie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnModifie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModifie.Location = new System.Drawing.Point(289, 326);
            this.BtnModifie.Name = "BtnModifie";
            this.BtnModifie.Size = new System.Drawing.Size(119, 37);
            this.BtnModifie.TabIndex = 11;
            this.BtnModifie.Text = "Modifie";
            this.BtnModifie.UseVisualStyleBackColor = false;
            this.BtnModifie.Click += new System.EventHandler(this.BtnModifie_Click);
            // 
            // BtnSuprimer
            // 
            this.BtnSuprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSuprimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSuprimer.Location = new System.Drawing.Point(148, 326);
            this.BtnSuprimer.Name = "BtnSuprimer";
            this.BtnSuprimer.Size = new System.Drawing.Size(119, 37);
            this.BtnSuprimer.TabIndex = 14;
            this.BtnSuprimer.Text = "Supprimer";
            this.BtnSuprimer.UseVisualStyleBackColor = false;
            this.BtnSuprimer.Click += new System.EventHandler(this.BtnSuprimer_Click);
            // 
            // txtmat
            // 
            this.txtmat.Location = new System.Drawing.Point(215, 65);
            this.txtmat.Name = "txtmat";
            this.txtmat.Size = new System.Drawing.Size(210, 33);
            this.txtmat.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(101, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Matricule :";
            // 
            // btnSuivant
            // 
            this.btnSuivant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuivant.Location = new System.Drawing.Point(604, 354);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(119, 37);
            this.btnSuivant.TabIndex = 18;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDernier.Location = new System.Drawing.Point(910, 354);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(119, 37);
            this.btnDernier.TabIndex = 20;
            this.btnDernier.Text = "Dernier";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrecedent.Location = new System.Drawing.Point(753, 354);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(119, 37);
            this.btnPrecedent.TabIndex = 19;
            this.btnPrecedent.Text = "Précedent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPremier.Location = new System.Drawing.Point(456, 354);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(119, 37);
            this.btnPremier.TabIndex = 21;
            this.btnPremier.Text = "Premier";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // cmbMat
            // 
            this.cmbMat.FormattingEnabled = true;
            this.cmbMat.Location = new System.Drawing.Point(1088, 70);
            this.cmbMat.Name = "cmbMat";
            this.cmbMat.Size = new System.Drawing.Size(121, 33);
            this.cmbMat.TabIndex = 22;
            // 
            // Mat
            // 
            this.Mat.AutoSize = true;
            this.Mat.Location = new System.Drawing.Point(1035, 73);
            this.Mat.Name = "Mat";
            this.Mat.Size = new System.Drawing.Size(47, 25);
            this.Mat.TabIndex = 23;
            this.Mat.Text = "Mat";
            // 
            // btnExporterDonnee
            // 
            this.btnExporterDonnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExporterDonnee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExporterDonnee.Location = new System.Drawing.Point(27, 446);
            this.btnExporterDonnee.Name = "btnExporterDonnee";
            this.btnExporterDonnee.Size = new System.Drawing.Size(133, 67);
            this.btnExporterDonnee.TabIndex = 24;
            this.btnExporterDonnee.Text = "Exporter données Text";
            this.btnExporterDonnee.UseVisualStyleBackColor = false;
            this.btnExporterDonnee.Click += new System.EventHandler(this.btnExporterDonnee_Click);
            // 
            // btnExpoterDonnesHTML
            // 
            this.btnExpoterDonnesHTML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExpoterDonnesHTML.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExpoterDonnesHTML.Location = new System.Drawing.Point(215, 446);
            this.btnExpoterDonnesHTML.Name = "btnExpoterDonnesHTML";
            this.btnExpoterDonnesHTML.Size = new System.Drawing.Size(133, 67);
            this.btnExpoterDonnesHTML.TabIndex = 26;
            this.btnExpoterDonnesHTML.Text = "Exporter données HTML";
            this.btnExpoterDonnesHTML.UseVisualStyleBackColor = false;
            this.btnExpoterDonnesHTML.Click += new System.EventHandler(this.btnExpoterDonnesHTML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1257, 750);
            this.Controls.Add(this.btnExpoterDonnesHTML);
            this.Controls.Add(this.btnExporterDonnee);
            this.Controls.Add(this.Mat);
            this.Controls.Add(this.cmbMat);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.txtmat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSuprimer);
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.BtnModifie);
            this.Controls.Add(this.BtnVider);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoyenne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoyenne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Button BtnVider;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.Button BtnModifie;
        private System.Windows.Forms.Button BtnSuprimer;
        private System.Windows.Forms.TextBox txtmat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.ComboBox cmbMat;
        private System.Windows.Forms.Label Mat;
        private System.Windows.Forms.Button btnExporterDonnee;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnExpoterDonnesHTML;
    }
}

