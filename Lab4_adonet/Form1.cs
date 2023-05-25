using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab4_adonet
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Server=(local); Database=Lab7Sharp; User=Danil; Password=1234";

        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=(local); Database=Lab7Sharp; User=Danil; Password=1234";
            LoadProfessors();
            LoadSubjects();
            LoadProfessorsSubject();
        }

        private void LoadProfessors()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Professors";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable professorTable = new DataTable();
                adapter.Fill(professorTable);

                professorsDataGridView.DataSource = professorTable;
            }
        }

        private void LoadSubjects()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Subjects";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable subjectsTable = new DataTable();
                adapter.Fill(subjectsTable);

                subjectsDataGridView.DataSource = subjectsTable;
            }
        }
        private void LoadProfessorsSubject()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ProfessorSubject";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable profsubjtable = new DataTable();
                adapter.Fill(profsubjtable);

                ProfSubjDTG.DataSource = profsubjtable;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string professorName = professorNameTextBox.Text;
            int professorAge = Convert.ToInt32(professorAgeTextBox.Text);
            decimal professorSalary = Convert.ToDecimal(professorSalaryTextBox.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Professors (Name, Age, Salary) VALUES (@Name, @Age, @Salary)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", professorName);
                command.Parameters.AddWithValue("@Age", professorAge);
                command.Parameters.AddWithValue("@Salary", professorSalary);

                connection.Open();
                command.ExecuteNonQuery();
            }

            LoadProfessors();
            ClearProfessorFields();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int professorId = Convert.ToInt32(professorsDataGridView.CurrentRow.Cells["ID"].Value);
            string professorName = professorNameTextBox.Text;
            int professorAge = Convert.ToInt32(professorAgeTextBox.Text);
            decimal professorSalary = Convert.ToDecimal(professorSalaryTextBox.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Professors SET Name = @Name, Age = @Age, Salary = @Salary WHERE ID = @ProfessorID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", professorName);
                command.Parameters.AddWithValue("@Age", professorAge);
                command.Parameters.AddWithValue("@Salary", professorSalary);
                command.Parameters.AddWithValue("@ProfessorID", professorId);

                connection.Open();
                command.ExecuteNonQuery();
            }

            LoadProfessors();
            ClearProfessorFields();
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            string subjectName = subjectNameTextBox.Text;
            int subjectHours = Convert.ToInt32(subjectHoursTextBox.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Subjects (Name, Hours) VALUES (@Name, @Hours)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", subjectName);
                command.Parameters.AddWithValue("@Hours", subjectHours);

                connection.Open();
                command.ExecuteNonQuery();
            }

            LoadSubjects();
            ClearSubjectFields();
        }

        private void linkButton_Click(object sender, EventArgs e)
        {
            int professorId = Convert.ToInt32(professorsDataGridView.CurrentRow.Cells["ID"].Value);
            int subjectId = Convert.ToInt32(subjectsDataGridView.CurrentRow.Cells["ID"].Value);
            string professorName = professorsDataGridView.CurrentRow.Cells["Name"].Value.ToString();
            string subjectName = subjectsDataGridView.CurrentRow.Cells["Name"].Value.ToString();


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ProfessorSubject (ProfessorID, SubjectID, ProfessorName, SubjectName) VALUES (@ProfessorID, @SubjectID, @ProfessorName, @SubjectName)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProfessorID", professorId);
                command.Parameters.AddWithValue("@SubjectID", subjectId);
                command.Parameters.AddWithValue("@ProfessorName", professorName);
                command.Parameters.AddWithValue("@SubjectName", subjectName);

                connection.Open();
                command.ExecuteNonQuery();

                LoadProfessorsSubject();
            }
        }

        private void ClearProfessorFields()
        {
            professorNameTextBox.Clear();
            professorAgeTextBox.Clear();
            professorSalaryTextBox.Clear();
        }

        private void ClearSubjectFields()
        {
            subjectNameTextBox.Clear();
            subjectHoursTextBox.Clear();
        }

    }
}
