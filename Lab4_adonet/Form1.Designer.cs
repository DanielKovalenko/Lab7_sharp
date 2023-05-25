
namespace Lab4_adonet
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.professorsDataGridView = new System.Windows.Forms.DataGridView();
            this.subjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.professorNameTextBox = new System.Windows.Forms.TextBox();
            this.professorAgeTextBox = new System.Windows.Forms.TextBox();
            this.professorSalaryTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.subjectNameTextBox = new System.Windows.Forms.TextBox();
            this.subjectHoursTextBox = new System.Windows.Forms.TextBox();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.ProfSubjDTG = new System.Windows.Forms.DataGridView();
            this.linkButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.professorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfSubjDTG)).BeginInit();
            this.SuspendLayout();
            // 
            // professorsDataGridView
            // 
            this.professorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professorsDataGridView.Location = new System.Drawing.Point(12, 48);
            this.professorsDataGridView.Name = "professorsDataGridView";
            this.professorsDataGridView.Size = new System.Drawing.Size(485, 167);
            this.professorsDataGridView.TabIndex = 0;
            // 
            // subjectsDataGridView
            // 
            this.subjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsDataGridView.Location = new System.Drawing.Point(20, 285);
            this.subjectsDataGridView.Name = "subjectsDataGridView";
            this.subjectsDataGridView.Size = new System.Drawing.Size(477, 194);
            this.subjectsDataGridView.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(671, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Додавання професора:";
            // 
            // professorNameTextBox
            // 
            this.professorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.professorNameTextBox.Location = new System.Drawing.Point(713, 78);
            this.professorNameTextBox.Name = "professorNameTextBox";
            this.professorNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.professorNameTextBox.TabIndex = 3;
            // 
            // professorAgeTextBox
            // 
            this.professorAgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.professorAgeTextBox.Location = new System.Drawing.Point(713, 129);
            this.professorAgeTextBox.Name = "professorAgeTextBox";
            this.professorAgeTextBox.Size = new System.Drawing.Size(100, 26);
            this.professorAgeTextBox.TabIndex = 4;
            // 
            // professorSalaryTextBox
            // 
            this.professorSalaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.professorSalaryTextBox.Location = new System.Drawing.Point(713, 177);
            this.professorSalaryTextBox.Name = "professorSalaryTextBox";
            this.professorSalaryTextBox.Size = new System.Drawing.Size(100, 26);
            this.professorSalaryTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addButton.Location = new System.Drawing.Point(912, 78);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(116, 72);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Додати професора";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editButton.Location = new System.Drawing.Point(912, 177);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(116, 72);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Оновити професора";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(671, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Додавання предмету:";
            // 
            // subjectNameTextBox
            // 
            this.subjectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subjectNameTextBox.Location = new System.Drawing.Point(713, 340);
            this.subjectNameTextBox.Name = "subjectNameTextBox";
            this.subjectNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.subjectNameTextBox.TabIndex = 9;
            // 
            // subjectHoursTextBox
            // 
            this.subjectHoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subjectHoursTextBox.Location = new System.Drawing.Point(713, 416);
            this.subjectHoursTextBox.Name = "subjectHoursTextBox";
            this.subjectHoursTextBox.Size = new System.Drawing.Size(100, 26);
            this.subjectHoursTextBox.TabIndex = 10;
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addSubjectButton.Location = new System.Drawing.Point(912, 343);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(116, 72);
            this.addSubjectButton.TabIndex = 11;
            this.addSubjectButton.Text = "Додати предмет";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // ProfSubjDTG
            // 
            this.ProfSubjDTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfSubjDTG.Location = new System.Drawing.Point(20, 559);
            this.ProfSubjDTG.Name = "ProfSubjDTG";
            this.ProfSubjDTG.Size = new System.Drawing.Size(477, 194);
            this.ProfSubjDTG.TabIndex = 12;
            // 
            // linkButton
            // 
            this.linkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.linkButton.Location = new System.Drawing.Point(762, 543);
            this.linkButton.Name = "linkButton";
            this.linkButton.Size = new System.Drawing.Size(251, 144);
            this.linkButton.TabIndex = 13;
            this.linkButton.Text = "Зв\'язати професора з предметов";
            this.linkButton.UseVisualStyleBackColor = true;
            this.linkButton.Click += new System.EventHandler(this.linkButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(218, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Professors:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(218, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Subjects:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(185, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Professors and Subjects:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(622, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(621, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Hours:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(622, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(622, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Age:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(622, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Salary:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1125, 788);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkButton);
            this.Controls.Add(this.ProfSubjDTG);
            this.Controls.Add(this.addSubjectButton);
            this.Controls.Add(this.subjectHoursTextBox);
            this.Controls.Add(this.subjectNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.professorSalaryTextBox);
            this.Controls.Add(this.professorAgeTextBox);
            this.Controls.Add(this.professorNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subjectsDataGridView);
            this.Controls.Add(this.professorsDataGridView);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.professorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfSubjDTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbAuthorSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.ComboBox cmbPublishing;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tbPublication;
        private System.Windows.Forms.DataGridView professorsDataGridView;
        private System.Windows.Forms.DataGridView subjectsDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox professorNameTextBox;
        private System.Windows.Forms.TextBox professorAgeTextBox;
        private System.Windows.Forms.TextBox professorSalaryTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox subjectNameTextBox;
        private System.Windows.Forms.TextBox subjectHoursTextBox;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.DataGridView ProfSubjDTG;
        private System.Windows.Forms.Button linkButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

