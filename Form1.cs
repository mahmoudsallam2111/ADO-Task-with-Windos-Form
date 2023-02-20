using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Disconnected_mode;


public partial class Form1 : Form
{
    private SqlConnection connection;
   private DataTable dt; // defining global data table

    public Form1()
    {
        InitializeComponent();

        connection = new SqlConnection(ConfigurationManager.ConnectionStrings["iti"].ConnectionString);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        SqlDataAdapter dataAdapter= new SqlDataAdapter("select * from Course" , connection);

        dt = new DataTable();

        //loading data into table
        dataAdapter.Fill(dt); 

        dgv_course.DataSource = dt;

        try
        {
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

    private void dgv_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    public int getmaxid()
    {
        SqlCommand command = new SqlCommand("select max(crs_id) from Course ", connection);
        // open connection
        connection.Open();
        // excute query
        var res = command.ExecuteScalar();
        int id = (int)res;

        connection.Close();
        return id;

    }

    private void btn_add_Click(object sender, EventArgs e)
    {
        int id = getmaxid() + 1;
        DataRow datarow = dt.NewRow();  // defining new row on table
        datarow[0] = id;
        datarow[1] = txt_name.Text;
        datarow[2] =(int) nud_duration.Value;
        datarow[3] = (int)combo_topic.SelectedValue;

        dt.Rows.Add(datarow);
        MessageBox.Show("Added successfully");
    }

    private int id;   // specify id when duble click on row 
    private void dgv_course_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        id = (int)dgv_course.SelectedRows[0].Cells[0].Value;
        txt_name.Text = dgv_course.SelectedRows[0].Cells[1].Value.ToString();
        nud_duration.Value = (int)dgv_course.SelectedRows[0].Cells[2].Value;
        combo_topic.SelectedValue = (int)dgv_course.SelectedRows[0].Cells[3].Value;

    }

    private void btn_update_Click(object sender, EventArgs e)
    {
        foreach(DataRow row in dt.Rows)
        {
            if ((int)row["crs_id"] ==id)
            {
                row["Crs_name"] = txt_name.Text;
                row["Crs_Duration"] = nud_duration.Value;
                row["Top_id"] = combo_topic.SelectedValue;


            }
         

        }
        MessageBox.Show("updated  successfully");
    }

    private void btn_delete_Click(object sender, EventArgs e)
    {

        foreach (DataRow row in dt.Rows)
        {
            if (row.RowState !=DataRowState.Deleted  &&(int)row["crs_id"] == id)
            {
                row.Delete();
            }
        }
        MessageBox.Show("Deleted successfully");

    }


    // save changes
    private void button1_Click(object sender, EventArgs e)
    {
        /// defining commands 

        string updatetext = "update Course set Crs_Name = @name , Crs_Duration = @dur , Top_Id=@topic where Crs_Id = @id";
        SqlCommand updatecommand = new SqlCommand(updatetext, connection);
        updatecommand.Parameters.Add("name", SqlDbType.NVarChar , 50 ,"Crs_name" );
        updatecommand.Parameters.Add("dur", SqlDbType.Int , 4 ,"Crs_Duration" );
        updatecommand.Parameters.Add("topic", SqlDbType.Int , 4 ,"Top_id" );
        updatecommand.Parameters.Add("id", SqlDbType.Int, 4 ,"Crs_id" );


        string inserttxt = "insert into Course(Crs_Id ,Crs_Name , Crs_Duration , Top_Id )\r\nvalues(@id,@name ,@dur, @topic)";
        SqlCommand insertcommand = new SqlCommand(inserttxt, connection);
        insertcommand.Parameters.Add("name", SqlDbType.NVarChar, 50, "Crs_name");
        insertcommand.Parameters.Add("dur", SqlDbType.Int, 4, "Crs_Duration");
        insertcommand.Parameters.Add("topic", SqlDbType.Int, 4, "Top_id");
        insertcommand.Parameters.Add("id", SqlDbType.Int, 4, "Crs_id");

        string deletetxt = "delete from Course where Crs_Id = @id";
        SqlCommand deletecommand = new SqlCommand(deletetxt, connection);
        deletecommand.Parameters.Add("id", SqlDbType.Int, 4, "Crs_id");


        /// define dataadaptor
        SqlDataAdapter dataAdaptor = new SqlDataAdapter();

        dataAdaptor.UpdateCommand = updatecommand;
        dataAdaptor.InsertCommand = insertcommand;
        dataAdaptor.DeleteCommand = deletecommand;

        // updating database
        dataAdaptor.Update(dt);


        MessageBox.Show("saved changes");

    }


}

