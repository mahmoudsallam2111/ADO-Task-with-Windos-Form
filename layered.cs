using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_mode
{
    public partial class layered : Form
    {
        public layered()
        {
            InitializeComponent();

        }

        public void combofill()
        {
            try
            {
                 
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["iti"].ConnectionString);
                // define quary
                SqlCommand command2 = new SqlCommand("select Top_Id , Top_Name from Topic", connection);
                // open connection
                connection.Open();
                // excute query
                SqlDataReader sdr2 = command2.ExecuteReader();

                //prepare data
                List<topic> topics = new List<topic>();
                while (sdr2.Read())  // read row by row
                {
                    topic t = new topic();
                    t.topic_id = (int)sdr2[0];
                    t.topic_name = sdr2[1].ToString();

                    topics.Add(t);
                }
                //close connection
                connection.Close();
                combo_topic.DataSource = topics;

            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + ex);


            }

            combo_topic.DisplayMember = "topic_name";
            combo_topic.ValueMember = "topic_id";
        }


        private void layered_Load(object sender, EventArgs e)
        {
            d_G_V.DataSource = coursebusinessLayer.GetAll();
            combofill();

        }
        private void d_G_V_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

       //add
        private void btn_add_Click(object sender, EventArgs e)
        {
            int id = DatabaseLayer.getmaxid() + 1;

            int res = coursebusinessLayer.add(id, txt_name.Text,(int) nud_duration.Value, (int)combo_topic.SelectedValue);

            if (res> 0)
            {
                MessageBox.Show("added successfully");

               d_G_V.DataSource = DatabaseLayer.select("select * from Course");
            }

        }


        private int id;   // specify id when duble click on row 
//to get id from selected Row
        private void d_G_V_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)d_G_V.SelectedRows[0].Cells[0].Value;
            txt_name.Text = d_G_V.SelectedRows[0].Cells[1].Value.ToString();
            nud_duration.Value = (int)d_G_V.SelectedRows[0].Cells[2].Value;
            combo_topic.SelectedValue = (int)d_G_V.SelectedRows[0].Cells[3].Value;

        }
        //update
        private void btn_update_Click(object sender, EventArgs e)
        {
            int res = coursebusinessLayer.Edit(id, txt_name.Text, (int)nud_duration.Value, (int)combo_topic.SelectedValue);
            if (res > 0)
            {
                MessageBox.Show("updated successfully");

                d_G_V.DataSource = DatabaseLayer.select("select * from Course");
            }

        }
        // delete 
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int res = coursebusinessLayer.Delete(id);
            if (res > 0)
            {
                MessageBox.Show("deleted successfully");

                d_G_V.DataSource = DatabaseLayer.select("select * from Course");
            }

        }
    }
}
