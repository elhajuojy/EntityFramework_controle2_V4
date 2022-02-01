using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_controle2_V4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MaconModels()
        {
            List<Macon> Macons = new List<Macon>
            {
                new Macon{ nom="elhajuojy",prenom="mehdi"},
                new Macon{nom="belhaid",prenom="zineb"},
                new Macon{nom="Bounacer",prenom="Ahmed"},
                new Macon{nom="jebbar",prenom="houssam"}
            };
            db.Macons.AddRange(Macons);
            db.SaveChanges();
        }

        private void ModelConstruction()
        {
            List<Construction> constructions = new List<Construction>
            {
                new Construction { dateConstruction=DateTime.Parse("1/1/2020 10:20:00 AM"),surface="2000", idMacon=1},
                new Construction { dateConstruction=DateTime.Parse("12/12/2021 8:17:00 AM"),surface="5554", idMacon=4},
                new Construction { dateConstruction=DateTime.Parse("10/7/2019 5:10:00 PM"),surface="354", idMacon=3},
                new Construction { dateConstruction=DateTime.Parse("5/10/2020 7:30:00 PM"),surface="998", idMacon=3},
                new Construction { dateConstruction=DateTime.Parse("12/6/2022 10:00:34 AM"),surface="4940", idMacon=1},

            };
            db.Constructions.AddRange(constructions);
            db.SaveChanges();
        }


        Entite_ConstructionContainer db = new Entite_ConstructionContainer();
        private void Form1_Load(object sender, EventArgs e)
        {
            // MaconModels();
            //ModelConstruction();
            var fillcomboMacons = from m in db.Macons
                                  select new
                                  {
                                      nom = m.nom,
                                      Id = m.Id
                                  };
            cbMacon2.DataSource = fillcomboMacons.ToList();
            cbMacon2.DisplayMember = "nom"; 
            cbMacon2.ValueMember = "Id";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            Macon m1 = new Macon();
            m1.Id = int.Parse(cbMacon2.SelectedValue.ToString());

            var allConstructionsbyMacons = from cons in db.Constructions
                                           join m in db.Macons
                                           on cons.idMacon equals m.Id
                                           where cons.idMacon == m1.Id
                                           select new
                                           {
                                               idConstruction = cons.id,
                                               DateConstructier = cons.dateConstruction,
                                               surface = cons.surface,
                                               Nom_Prenom_Macons = m.nom + " " + m.prenom
                                           };


            dataGridView1.DataSource = allConstructionsbyMacons.ToList();
                                           
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            Construction c1 = new Construction();
            c1.id = int.Parse(txtIDConstructions.Text);

            var findConstruction = from Cons in db.Constructions
                                   join m in db.Macons
                                   on Cons.idMacon equals m.Id
                                   where Cons.id == c1.id
                                   select new
                                   {
                                       Cons,
                                       m
                                   };


            foreach(var f in findConstruction)
            {
                txtSurface.Text = f.Cons.surface;
                dateConruction.Value = f.Cons.dateConstruction.Value;
                //cbMacon1.DataSource = f.m;
                //cbMacon1.ValueMember = f.m.Id.ToString() ;
                //cbMacon1.DisplayMember = f.m.nom;
                
            }
                                   

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Construction c1 = new Construction();
            c1.surface = txtSurface.Text;
            c1.dateConstruction = dateConruction.Value;
            c1.idMacon = int.Parse(cbMacon2.SelectedValue.ToString());
            db.Constructions.Add(c1);
            db.SaveChanges();
        }

        private void btnModifer_Click(object sender, EventArgs e)
        {
            Construction c1 = new Construction();
            c1.id =int.Parse( txtIDConstructions.Text);
            c1 = (from c in db.Constructions
                  where c.id == c1.id
                  select c).FirstOrDefault();

            c1.dateConstruction = dateConruction.Value;
            c1.surface = txtSurface.Text;
            c1.idMacon = int.Parse(cbMacon2.SelectedValue.ToString());
            db.SaveChanges();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            Construction c1 = new Construction();
            c1 = (from c in db.Constructions
                  where c.id == c1.id
                  select c).FirstOrDefault();
            db.Constructions.Remove(c1);
            db.SaveChanges();
        }
    }
}
