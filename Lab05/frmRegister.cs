using Lab05.BUS;
using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab05
{
    public partial class frmRegister : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();

        public frmRegister()
        {
            InitializeComponent();
        }

        // Filling the Faculty ComboBox with default "Select Faculty"
        public void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            listFacultys.Insert(0, new Faculty { FacultyID = 0, FacultyName = "Select Faculty" });
            this.cmbKhoaRegist.DataSource = listFacultys;
            this.cmbKhoaRegist.DisplayMember = "FacultyName";
            this.cmbKhoaRegist.ValueMember = "FacultyID";
        }

        // Filling the Major ComboBox with default "Select Major"
        public void FillMajorCombobox(List<Major> listMajor)
        {
            listMajor.Insert(0, new Major { MajorID = 0, Name = "Select Major" });
            this.cmbChuyenNganhRegist.DataSource = listMajor;
            this.cmbChuyenNganhRegist.DisplayMember = "Name";
            this.cmbChuyenNganhRegist.ValueMember = "MajorID";
        }

        // Loading faculties on form load
        private void frmRegister_Load(object sender, EventArgs e)
        {
            try
            {
                var listFacultys = facultyService.GetAll();
                FillFalcultyCombobox(listFacultys);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Event when Faculty ComboBox is changed
        private void cmbKhoaRegist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Faculty selectedFaculty = cmbKhoaRegist.SelectedItem as Faculty;
            if (selectedFaculty != null && selectedFaculty.FacultyID != 0) // Check if a valid faculty is selected
            {
                var listMajor = majorService.GetAllByFaculty(selectedFaculty.FacultyID);
                FillMajorCombobox(listMajor);

                var listStudents = studentService.GetAllHasNoMajor(selectedFaculty.FacultyID);
                BindGrid(listStudents);
            } else if (selectedFaculty.FacultyID == 0)
            {
                var listStudents = studentService.GetAllHasNoMajor();
                BindGrid(listStudents);
            }
            else
            {
                dgvSinhVienDangKY.Rows.Clear(); // Clear grid if "Select Faculty" is chosen
            }
        }

        // Binding students to DataGridView
        private void BindGrid(List<Student> listStudent)
        {
            dgvSinhVienDangKY.Rows.Clear();
            dgvSinhVienDangKY.Columns.Clear();

            // Define columns
            dgvSinhVienDangKY.Columns.Add("Index", "No."); // Row number
            dgvSinhVienDangKY.Columns.Add("StudentID", "Student ID");
            dgvSinhVienDangKY.Columns.Add("FullName", "Full Name");
            dgvSinhVienDangKY.Columns.Add("FacultyName", "Faculty");
            dgvSinhVienDangKY.Columns.Add("AverageScore", "Average Score");

            // Add a DataGridViewComboBoxColumn for Major
            DataGridViewComboBoxColumn majorComboBoxColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Major",
                Name = "MajorColumn",
                DisplayMember = "Name",
                ValueMember = "MajorID"
            };
            dgvSinhVienDangKY.Columns.Add(majorComboBoxColumn);

            // Add rows
            foreach (var item in listStudent)
            {
                int index = dgvSinhVienDangKY.Rows.Add();
                dgvSinhVienDangKY.Rows[index].Cells[0].Value = index + 1; // Row number
                dgvSinhVienDangKY.Rows[index].Cells[1].Value = item.StudentID;
                dgvSinhVienDangKY.Rows[index].Cells[2].Value = item.FullName;
                dgvSinhVienDangKY.Rows[index].Cells[3].Value = item.Faculty?.FacultyName ?? "No Faculty";
                dgvSinhVienDangKY.Rows[index].Cells[4].Value = item.AverageScore.ToString("F2");

                // Get the list of majors for the student's faculty
                List<Major> listMajor = new List<Major>();
                if (item.Faculty != null)
                {
                    listMajor = majorService.GetAllByFaculty(item.Faculty.FacultyID);
                }

                // Add "No Major" option to the list of majors
                listMajor.Insert(0, new Major { MajorID = -1, Name = "No Major" });

                // Replace the default cell in the Major column with a ComboBoxCell for the current row
                DataGridViewComboBoxCell majorComboBoxCell = (DataGridViewComboBoxCell)dgvSinhVienDangKY.Rows[index].Cells["MajorColumn"];
                majorComboBoxCell.DataSource = listMajor;
                majorComboBoxCell.DisplayMember = "Name";
                majorComboBoxCell.ValueMember = "MajorID";
                majorComboBoxCell.Value = item.MajorID ?? -1;  // Set the selected major ID (or "No Major" if none)
            }
        }




        private void dgvSinhVienDangKY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSinhVienDangKY.Columns["MajorColumn"].Index && e.RowIndex >= 0)
            {
                // Get the selected student ID
                string studentID = dgvSinhVienDangKY.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Get the selected Major ID from the ComboBox
                int selectedMajorID = (int)dgvSinhVienDangKY.Rows[e.RowIndex].Cells["MajorColumn"].Value;

                // Find the student and update their major
                var student = studentService.FindById(studentID);
                if (student != null)
                {
                    student.MajorID = selectedMajorID;
                    studentService.InsertUpdate(student); // Update the student's major in the database

                    MessageBox.Show($"Major updated successfully for student {student.FullName}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
