using Lab05.BUS;
using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form1 : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly MajorService majorService = new MajorService();
        private readonly FacultyService facultyService = new FacultyService();
        public Form1()
        {
            InitializeComponent();

        }
        private string avatarFilePath = string.Empty;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Select an Avatar Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        avatarFilePath = openFileDialog.FileName;
                        picAnhDaiDien.Image = Image.FromFile(avatarFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void LoadAvatar(string studentID)
        {
            var student = studentService.FindById(studentID);
            if (student != null && !string.IsNullOrEmpty(student.Avatar))
            {
                ShowAvatar(student.Avatar); // Use the ShowAvatar method
            }
            else
            {
                picAnhDaiDien.Image = null; // Clear image if no avatar is available
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvStudents);
                var listFacultys = facultyService.GetAll();
                var listStudents = studentService.GetAll();
                FillFalcultyCombobox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dgview.CellBorderStyle =
            DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            listFacultys.Insert(0, new Faculty { FacultyID = 0, FacultyName = "Select Faculty" });
            cmbKhoaSV.DataSource = listFacultys;
            cmbKhoaSV.DisplayMember = "FacultyName";
            cmbKhoaSV.ValueMember = "FacultyID";
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudents.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudents.Rows.Add();
                dgvStudents.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudents.Rows[index].Cells[1].Value = item.FullName;
                dgvStudents.Rows[index].Cells[2].Value = item.Faculty != null ? item.Faculty.FacultyName : "Không khoa";
                dgvStudents.Rows[index].Cells[3].Value = item.AverageScore.ToString();
                dgvStudents.Rows[index].Cells[4].Value = item.Major != null ? item.Major.Name : "Không chuyên ngành";

                // Show avatar using ShowAvatar method
                ShowAvatar(item.Avatar);
            }
        }
        private void ShowAvatar(string imageName)
        {
            if (string.IsNullOrEmpty(imageName))
            {
                picAnhDaiDien.Image = null; // Clear the image if no avatar is available
                return;
            }

            string folderPath = Path.Combine(Application.StartupPath, "Images");
            string imagePath = Path.Combine(folderPath, imageName);

            if (File.Exists(imagePath))
            {
                picAnhDaiDien.Image = Image.FromFile(imagePath);
                picAnhDaiDien.Refresh();
            }
            else
            {
                picAnhDaiDien.Image = null; // Clear the image if file doesn't exist
            }
        }

        private void chkKhongChuyenNganh_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = new List<Student>();
            if (this.chkKhongChuyenNganh.Checked)
                listStudents = studentService.GetAllHasNoMajor();
            else
                listStudents = studentService.GetAll();
            BindGrid(listStudents);
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather information from the form inputs
                string studentID = txtMSSV.Text.Trim();
                string studentName = txtHotenSV.Text.Trim();
                double averageScore;
                if (!double.TryParse(txtDTBSV.Text.Trim(), out averageScore))
                {
                    MessageBox.Show("Please enter a valid average score.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int facultyID = (int)cmbKhoaSV.SelectedValue;

                // Check if the student already exists
                var existingStudent = studentService.FindById(studentID);

                if (existingStudent == null)
                {
                    // If the student doesn't exist, add a new one
                    var newStudent = new Student
                    {
                        StudentID = studentID,
                        FullName = studentName,
                        AverageScore = averageScore,
                        FacultyID = facultyID,
                        Avatar = Path.GetFileName(avatarFilePath) // Save the avatar filename
                    };

                    studentService.InsertUpdate(newStudent);
                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // If the student exists, update their information
                    existingStudent.FullName = studentName;
                    existingStudent.AverageScore = averageScore;
                    existingStudent.FacultyID = facultyID;

                    if (!string.IsNullOrEmpty(avatarFilePath))
                    {
                        existingStudent.Avatar = Path.GetFileName(avatarFilePath); // Update avatar if changed
                    }

                    studentService.InsertUpdate(existingStudent);
                    MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Reload the data in the grid view after adding/updating
                BindGrid(studentService.GetAll());

                // Load the avatar for the current student
                //LoadAvatar(studentID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = txtMSSV.Text.Trim();

                if (string.IsNullOrEmpty(studentID))
                {
                    MessageBox.Show("Please enter a valid student ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var existingStudent = studentService.FindById(studentID);
                if (existingStudent != null)
                {
                    studentService.Delete(existingStudent); // Ensure this method exists in StudentService
                    MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload the data in the grid view after deletion
                    BindGrid(studentService.GetAll());

                    // Clear the form and avatar
                    ClearForm();
                    picAnhDaiDien.Image = null;
                }
                else
                {
                    MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            txtMSSV.Clear();
            txtHotenSV.Clear();
            txtDTBSV.Clear();
            cmbKhoaSV.SelectedIndex = 0;
            avatarFilePath = string.Empty;
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                // Fetch data from the selected row and display it in the input fields
                string studentID = row.Cells[0].Value.ToString(); // Student ID
                string fullName = row.Cells[1].Value.ToString();  // Full Name
                string facultyName = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : ""; // Faculty (can be null)
                string averageScore = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : "0"; // Average Score (can be null)


                // Load the fetched data into your input controls
                txtMSSV.Text = studentID; // MSSV TextBox (Student ID)
                txtHotenSV.Text = fullName; // Full Name TextBox
                txtDTBSV.Text = averageScore; // Average Score TextBox

                // Set the selected faculty in the ComboBox
                Faculty selectedFaculty = facultyService.GetAll().FirstOrDefault(f => f.FacultyName == facultyName);
                if (selectedFaculty != null)
                {
                    cmbKhoaSV.SelectedValue = selectedFaculty.FacultyID; // Use SelectedValue, not SelectedItem
                }

                // Load the student's avatar (if applicable)
                LoadAvatar(row.Cells[0].Value.ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Instantiate the frmRegister form
            frmRegister registerForm = new frmRegister();

            // Show the form
            registerForm.Show(); // or use registerForm.ShowDialog() if you want it to be a modal dialog
        }

    }
}
