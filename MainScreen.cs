using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSERAFIN_July2019
{
    public partial class MainScreen : Form
    {
        static string CS_Exam = "Server=INSTRUCTORIT;" +
                "Database=TournamentManager;" +
                "User Id=ProfileUser;" +
                "Password = ProfileUser2019; ";
        SqlConnection connection_Exam_Serafin = new SqlConnection(CS_Exam);
        SqlConnection connection_Exam_Serafin2 = new SqlConnection(CS_Exam);

        public MainScreen()
        {
            InitializeComponent();
            DataLoadExamSerafin();
        }


        private void DataLoadExamSerafin()
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.Teams;", connection_Exam_Serafin);
                connection_Exam_Serafin.Open();
                SqlDataReader reader_Exam_Serafin = command.ExecuteReader();
                DataTable dataTable_Exam_Serafin = new DataTable();
                dataTable_Exam_Serafin.Load(reader_Exam_Serafin);
                DataGridEXAM.DataSource = dataTable_Exam_Serafin;
            }
            catch (Exception execption_Exam_Serafin)
            {
                MessageBox.Show(execption_Exam_Serafin.Message);
            }
            finally
            {
                if (connection_Exam_Serafin.State == ConnectionState.Open)
                {
                    connection_Exam_Serafin.Close();
                }
            }
        }
        private void DataGridEXAM_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void BTNinsert_Click(object sender, EventArgs e)
        {
            string SQLINSERT_NEW_TEAM = "insert into dbo.Teams(" +
                "TeamName,CoachName,DirectorName,AddressLine1,AddressLine2,PostCode" +
                ",City,ContactNumber,EmailAddress,CreatedBy) " +
                "values('" +
                textBox2.Text +
                "', '" +
                textBox3.Text +
                "', '" +
                textBox4.Text +
                "', '" +
                textBox5.Text +
                "', '" +
                textBox6.Text +
                "', '" +
                textBox7.Text +
                "', '" +
                textBox8.Text +
                "', '" +
                textBox9.Text +
                "', '" +
                textBox10.Text +
                "', '" +
                textBox11.Text +
                 "')";

            try
            {
                if ((textBox2.Text.Length != 0) && (textBox3.Text.Length != 0) && (textBox4.Text.Length != 0) && (textBox5.Text.Length != 0)
                    && (textBox6.Text.Length != 0) && (textBox7.Text.Length != 0) && (textBox8.Text.Length != 0) && (textBox9.Text.Length != 0)
                    && (textBox10.Text.Length != 0) && (textBox11.Text.Length != 0))
                {
                    connection_Exam_Serafin2.Open();
                    SqlCommand command_Exam_Insert_Serafin = new SqlCommand(SQLINSERT_NEW_TEAM, connection_Exam_Serafin2);
                    command_Exam_Insert_Serafin.ExecuteNonQuery();
                    //this.Close();
                    DataLoadExamSerafin();

                }
                else
                {
                    MessageBox.Show("Please insert all the fields. They are all mandatory");
                }

            }
            catch (Exception execption_Exam_Serafin2)
            {
                MessageBox.Show(execption_Exam_Serafin2.Message);
            }
            finally
            {
                if (connection_Exam_Serafin2.State == ConnectionState.Open)
                {
                    connection_Exam_Serafin.Close();
                }
            }

            


        }

        private void BTNcloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {

        }
    }
}
