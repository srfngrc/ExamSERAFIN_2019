using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        SqlConnection connection_Exam_Serafin3 = new SqlConnection(CS_Exam);
        SqlConnection connection_Exam_Serafin4 = new SqlConnection(CS_Exam);
        SqlConnection connection_Exam_Serafin5 = new SqlConnection(CS_Exam);

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
            if (DataGridEXAM.SelectedRows.Count > 0)
            {
                textBox1.Text = DataGridEXAM.SelectedRows[0].Cells[0].Value.ToString() + string.Empty;
                textBox2.Text = DataGridEXAM.SelectedRows[0].Cells[1].Value.ToString() + string.Empty;
                textBox3.Text = DataGridEXAM.SelectedRows[0].Cells[2].Value.ToString() + string.Empty;
                textBox4.Text = DataGridEXAM.SelectedRows[0].Cells[3].Value.ToString() + string.Empty;
                textBox5.Text = DataGridEXAM.SelectedRows[0].Cells[4].Value.ToString() + string.Empty;
                textBox6.Text = DataGridEXAM.SelectedRows[0].Cells[5].Value.ToString() + string.Empty;
                textBox7.Text = DataGridEXAM.SelectedRows[0].Cells[6].Value.ToString() + string.Empty;
                textBox8.Text = DataGridEXAM.SelectedRows[0].Cells[7].Value.ToString() + string.Empty;
                textBox9.Text = DataGridEXAM.SelectedRows[0].Cells[8].Value.ToString() + string.Empty;
                textBox10.Text = DataGridEXAM.SelectedRows[0].Cells[9].Value.ToString() + string.Empty;
                textBox11.Text = DataGridEXAM.SelectedRows[0].Cells[10].Value.ToString() + string.Empty;
            }
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
                    //After inserted the row in the DB, I reload the data updated.
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
                    connection_Exam_Serafin2.Close();
                }
            }

            


        }

        private void BTNcloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            string SQLDELETE_ONE_TEAM = "delete dbo.Teams where TeamId = " +
                Int32.Parse(textBox1.Text) +
                ";";

            try
            {
                    connection_Exam_Serafin3.Open();
                    SqlCommand command_Exam_Delete_Serafin = new SqlCommand(SQLDELETE_ONE_TEAM, connection_Exam_Serafin3);
                    command_Exam_Delete_Serafin.ExecuteNonQuery();
                    //After deleted the row from the DB, I reload the data updated.
                    DataLoadExamSerafin();
            }
            catch (Exception execption_Exam_Serafin3)
            {
                MessageBox.Show(execption_Exam_Serafin3.Message);
            }
            finally
            {
                if (connection_Exam_Serafin3.State == ConnectionState.Open)
                {
                    connection_Exam_Serafin3.Close();
                }
            }
        }

        private void BTNmodify_Click(object sender, EventArgs e)
        {
            string SQLUPDATE_ONE_TEAM = "update  dbo.Teams set " +
                        "TeamName=@TeamName," +
                        "CoachName=@CoachName," +
                        "DirectorName=@DirectorName," +
                        "AddressLine1=@AddressLine1," +
                        "AddressLine2=@AddressLine2," +
                        "PostCode=@PostCode," +
                        "City=@City," +
                        "ContactNumber=@ContactNumber," +
                        "EmailAddress=@EmailAddress," +
                        "CreatedBy='Serafin' " +
                        "where TeamId=@TeamId;";

            try
            {
                connection_Exam_Serafin4.Open();
                SqlCommand command_Exam_Update_Serafin = new SqlCommand(SQLUPDATE_ONE_TEAM, connection_Exam_Serafin4);
                command_Exam_Update_Serafin.Parameters.AddWithValue("@TeamId", Int32.Parse(textBox1.Text));
                command_Exam_Update_Serafin.Parameters.AddWithValue("@TeamName", textBox2.Text);
                command_Exam_Update_Serafin.Parameters.AddWithValue("@CoachName", textBox3.Text);
                command_Exam_Update_Serafin.Parameters.AddWithValue("@DirectorName", textBox4.Text);
                command_Exam_Update_Serafin.Parameters.AddWithValue("@AddressLine1", textBox5.Text);
                command_Exam_Update_Serafin.Parameters.AddWithValue("@AddressLine2", textBox6.Text);
                command_Exam_Update_Serafin.Parameters.AddWithValue("@PostCode", textBox7.Text);
                command_Exam_Update_Serafin.Parameters.AddWithValue("@City", textBox8.Text);
                command_Exam_Update_Serafin.Parameters.AddWithValue("@ContactNumber", textBox9.Text);
                command_Exam_Update_Serafin.Parameters.AddWithValue("@EmailAddress", textBox10.Text);

                command_Exam_Update_Serafin.ExecuteNonQuery();
                //After updated or modified the row at the DB, I reload the data updated.
                DataLoadExamSerafin();
            }
            catch (Exception execption_Exam_Serafin4)
            {
                MessageBox.Show(execption_Exam_Serafin4.Message);
            }
            finally
            {
                if (connection_Exam_Serafin4.State == ConnectionState.Open)
                {
                    connection_Exam_Serafin4.Close();
                }
            }
        }

        private void BTNreset_Click(object sender, EventArgs e)
        {
                textBox1.Text = "";
                textBox2.ResetText();
                textBox3.ResetText();
                textBox4.ResetText();
                textBox5.ResetText();
                textBox6.ResetText();
                textBox7.ResetText();
                textBox8.ResetText();
                textBox9.ResetText();
                textBox10.ResetText();
                textBox11.ResetText();
        }

        private void BTNSaveToaFile_Click(object sender, EventArgs e)
        {
            //There is no access possible to unit C:
            //StreamWriter StrWtr_Serafin = new StreamWriter(@"C:\TEAMLIST.TXT", true);
            StreamWriter StrWtr_Serafin = new StreamWriter(@"C:\Users\Programming8\Documents\TEAMLIST.TXT", true);

            try
            {
                SqlCommand SaveFile5 = new SqlCommand("SELECT * FROM dbo.Teams;", connection_Exam_Serafin5);
                connection_Exam_Serafin5.Open();

                SqlDataReader reader_Exam_Serafin5 = SaveFile5.ExecuteReader();

                while (reader_Exam_Serafin5.Read())
                {
                    StrWtr_Serafin.Write(reader_Exam_Serafin5[0] + ";");
                    StrWtr_Serafin.Write(reader_Exam_Serafin5[1] + ";");
                    StrWtr_Serafin.Write(reader_Exam_Serafin5[2] + ";");
                    StrWtr_Serafin.Write(reader_Exam_Serafin5[3] + ";");
                    StrWtr_Serafin.Write(reader_Exam_Serafin5[4] + ";");
                    StrWtr_Serafin.Write(reader_Exam_Serafin5[5] + ";");
                    StrWtr_Serafin.Write(reader_Exam_Serafin5[6] + ";");
                    StrWtr_Serafin.Write(reader_Exam_Serafin5[7] + ";");
                    StrWtr_Serafin.Write(reader_Exam_Serafin5[8] + ";");
                    StrWtr_Serafin.Write(reader_Exam_Serafin5[9] + ";");
                    StrWtr_Serafin.WriteLine(reader_Exam_Serafin5[10]+ "\t");
                }
                reader_Exam_Serafin5.Close();
                StrWtr_Serafin.Close();
                MessageBox.Show("Data correctly inserted in file TEAMLIST.TXT in C-Users-Programming8-Documents.");
            }
            catch (Exception execption_Exam_Serafin5)
            {
                MessageBox.Show(execption_Exam_Serafin5.Message);
            }
            finally
            {
                if (connection_Exam_Serafin5.State == ConnectionState.Open)
                {
                    connection_Exam_Serafin5.Close();
                }
            }

        }

        private void BTNcredits_Click(object sender, EventArgs e)
        {
            Credits_Screen infoAuthor = new Credits_Screen();
            infoAuthor.Show();
        }
    }
}
