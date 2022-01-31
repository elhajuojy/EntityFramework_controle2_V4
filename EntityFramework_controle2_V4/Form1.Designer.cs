
namespace EntityFramework_controle2_V4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIDConstructions = new System.Windows.Forms.TextBox();
            this.txtSurface = new System.Windows.Forms.TextBox();
            this.cbMacon1 = new System.Windows.Forms.ComboBox();
            this.cbMacon2 = new System.Windows.Forms.ComboBox();
            this.dateConruction = new System.Windows.Forms.DateTimePicker();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnChercher = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion Constructions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Constructions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Construction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surface";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Macon ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Macon ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(491, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(426, 159);
            this.dataGridView1.TabIndex = 6;
            // 
            // txtIDConstructions
            // 
            this.txtIDConstructions.Location = new System.Drawing.Point(179, 127);
            this.txtIDConstructions.Name = "txtIDConstructions";
            this.txtIDConstructions.Size = new System.Drawing.Size(174, 22);
            this.txtIDConstructions.TabIndex = 7;
            // 
            // txtSurface
            // 
            this.txtSurface.Location = new System.Drawing.Point(179, 248);
            this.txtSurface.Name = "txtSurface";
            this.txtSurface.Size = new System.Drawing.Size(174, 22);
            this.txtSurface.TabIndex = 8;
            // 
            // cbMacon1
            // 
            this.cbMacon1.FormattingEnabled = true;
            this.cbMacon1.Location = new System.Drawing.Point(179, 298);
            this.cbMacon1.Name = "cbMacon1";
            this.cbMacon1.Size = new System.Drawing.Size(174, 24);
            this.cbMacon1.TabIndex = 9;
            // 
            // cbMacon2
            // 
            this.cbMacon2.FormattingEnabled = true;
            this.cbMacon2.Location = new System.Drawing.Point(623, 129);
            this.cbMacon2.Name = "cbMacon2";
            this.cbMacon2.Size = new System.Drawing.Size(174, 24);
            this.cbMacon2.TabIndex = 10;
            // 
            // dateConruction
            // 
            this.dateConruction.Location = new System.Drawing.Point(179, 194);
            this.dateConruction.Name = "dateConruction";
            this.dateConruction.Size = new System.Drawing.Size(200, 22);
            this.dateConruction.TabIndex = 11;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(32, 390);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(94, 29);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnModifer
            // 
            this.btnModifer.Location = new System.Drawing.Point(149, 390);
            this.btnModifer.Name = "btnModifer";
            this.btnModifer.Size = new System.Drawing.Size(94, 29);
            this.btnModifer.TabIndex = 13;
            this.btnModifer.Text = "Modifer";
            this.btnModifer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(274, 390);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(94, 29);
            this.btnSupprimer.TabIndex = 14;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnChercher
            // 
            this.btnChercher.Location = new System.Drawing.Point(388, 126);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(94, 29);
            this.btnChercher.TabIndex = 15;
            this.btnChercher.Text = "Chercher";
            this.btnChercher.UseVisualStyleBackColor = true;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(823, 129);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(94, 29);
            this.btnAfficher.TabIndex = 16;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 446);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.btnChercher);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dateConruction);
            this.Controls.Add(this.cbMacon2);
            this.Controls.Add(this.cbMacon1);
            this.Controls.Add(this.txtSurface);
            this.Controls.Add(this.txtIDConstructions);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FormGesContruction";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIDConstructions;
        private System.Windows.Forms.TextBox txtSurface;
        private System.Windows.Forms.ComboBox cbMacon1;
        private System.Windows.Forms.ComboBox cbMacon2;
        private System.Windows.Forms.DateTimePicker dateConruction;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.Button btnAfficher;
    }
}

