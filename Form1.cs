using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace csharpzh2
{
    public partial class Form1 : Form
    {

        DataTable dt = new DataTable();
        SQLiteDataAdapter sda;
        SQLiteCommand cmd = new SQLiteCommand();
        public Form1()
        {
            InitializeComponent();
            set_dg();
            dataGridView1.CellMouseClick += dataGridView1_CellContentClick;
        }


        private void push_data()

        {
            int id = 0;
            try
            {
                id = Convert.ToInt32(Nr.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Nr must be a number");
                return;
            }

            String pilot = Pilota.Text;
            if(pilot !="Verstappen" && pilot != "Leclerc" && pilot != "Hamilton" &&
                pilot != "Bottas"&& pilot != "Vettel"&& pilot != "Albon")
            {
                MessageBox.Show("Not known pilot");
                return;
            }

            String istal = Istallo.Text;
            if(istal !="Red Bull" && istal != "Mercedes" && istal != "Ferrari")
            {
                MessageBox.Show("Not known team");
                return;
            }


            DB db = new DB();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("insert into formula(Nr,Pilota,Istallo,Futam,Pont) values('" + id + "','"+pilot +"','"+istal +"','"+Futam.Text+"','"+Pont.Text+"')", db.GetConnection());
            cmd.ExecuteNonQuery();
            db.closeconnection();

            set_dg();


        }


        private void set_dg()
        {
            dt = new DataTable();
            DB db = new DB();
            cmd = new SQLiteCommand("select * from formula", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
           
        }

        private void pushDB_Click(object sender, EventArgs e)
        {
            push_data();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int nr = Convert.ToInt32(deleteLBL.Text);
            DB db = new DB();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM formula WHERE Nr=" + nr.ToString(),db.GetConnection());
            cmd.ExecuteNonQuery();
            db.closeconnection();
            set_dg();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void changeBTN_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Nr_change.Text);
            String helyszin = futam_change.Text;
            int pont = Convert.ToInt32(pontszam_change.Text);

            DB db = new DB();
            db.openconnection();
            SQLiteCommand cmd = new SQLiteCommand("UPDATE formula SET Pont='"+pont+"'WHERE Nr="+Id.ToString()+" AND Futam='"+helyszin+"';", db.GetConnection());
            cmd.ExecuteNonQuery();
            db.closeconnection();
            set_dg();

        }

        private void lekerdez_Click(object sender, EventArgs e)
        {
            String Name = lekerd_txt.Text;
            DataTable dt2 = new DataTable();
            DB db = new DB();
            cmd = new SQLiteCommand("select * from formula WHERE Pilota ='"+Name+"'", db.GetConnection());
            sda = new SQLiteDataAdapter(cmd);
            sda.Fill(dt2);
            personalDG.DataSource = dt2;

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Készítette: Ficsor Attila, LF1RAK, 2021.12.09 (yes leállítja a programot)","Info",MessageBoxButtons.YesNo);
           if(result== DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int nr = Convert.ToInt32(row.Cells["Nr"].Value);
                String pilot = row.Cells["Pilota"].Value.ToString();
                String istal = row.Cells["Istallo"].Value.ToString();
                String fut = row.Cells["Futam"].Value.ToString();
                int pont = Convert.ToInt32(row.Cells["Pont"].Value);

                Nr.Text = nr.ToString();
                Pilota.Text = pilot;
                Istallo.Text = istal;
                Futam.Text = fut;
                Pont.Text = pont.ToString();



            }
        }
    }
}
