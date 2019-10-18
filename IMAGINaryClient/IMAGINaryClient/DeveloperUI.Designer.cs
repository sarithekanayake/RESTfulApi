namespace IMAGINaryClient
{
    partial class DeveloperUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpWorkDate = new System.Windows.Forms.DateTimePicker();
            this.txtWorkingHours = new System.Windows.Forms.TextBox();
            this.txtOverTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClearAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTasksView = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDeleteTask = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.btnClearTaskUp = new System.Windows.Forms.Button();
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.txtHoursUpdate = new System.Windows.Forms.TextBox();
            this.txtSearchTaskID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.epProject = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDesc = new System.Windows.Forms.ErrorProvider(this.components);
            this.epHours = new System.Windows.Forms.ErrorProvider(this.components);
            this.epOver = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTaskIDUp = new System.Windows.Forms.ErrorProvider(this.components);
            this.epHrsUp = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTaskIDDlt = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTaskIDUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHrsUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTaskIDDlt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTask
            // 
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Nexa Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(684, 509);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "Submit";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // txtProject
            // 
            this.txtProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProject.Location = new System.Drawing.Point(684, 56);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(100, 22);
            this.txtProject.TabIndex = 2;
            this.txtProject.Leave += new System.EventHandler(this.txtProject_Leave);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(684, 119);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(241, 70);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // dtpWorkDate
            // 
            this.dtpWorkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWorkDate.Location = new System.Drawing.Point(684, 232);
            this.dtpWorkDate.Name = "dtpWorkDate";
            this.dtpWorkDate.Size = new System.Drawing.Size(241, 22);
            this.dtpWorkDate.TabIndex = 4;
            // 
            // txtWorkingHours
            // 
            this.txtWorkingHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkingHours.Location = new System.Drawing.Point(684, 308);
            this.txtWorkingHours.Name = "txtWorkingHours";
            this.txtWorkingHours.Size = new System.Drawing.Size(100, 22);
            this.txtWorkingHours.TabIndex = 5;
            this.txtWorkingHours.Leave += new System.EventHandler(this.txtWorkingHours_Leave);
            // 
            // txtOverTime
            // 
            this.txtOverTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverTime.Location = new System.Drawing.Point(684, 383);
            this.txtOverTime.Name = "txtOverTime";
            this.txtOverTime.Size = new System.Drawing.Size(100, 22);
            this.txtOverTime.TabIndex = 6;
            this.txtOverTime.Leave += new System.EventHandler(this.txtOverTime_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Project No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(346, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Over Time";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(41, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1285, 599);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClearAdd);
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnAddTask);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtProject);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dtpWorkDate);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtWorkingHours);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtOverTime);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1277, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Task";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClearAdd
            // 
            this.btnClearAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAdd.Font = new System.Drawing.Font("Nexa Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAdd.Location = new System.Drawing.Point(795, 509);
            this.btnClearAdd.Name = "btnClearAdd";
            this.btnClearAdd.Size = new System.Drawing.Size(75, 23);
            this.btnClearAdd.TabIndex = 13;
            this.btnClearAdd.Text = "Clear";
            this.btnClearAdd.UseVisualStyleBackColor = true;
            this.btnClearAdd.Click += new System.EventHandler(this.btnClearAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTasksView);
            this.tabPage2.Controls.Add(this.dgvTasks);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1277, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Tasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTasksView
            // 
            this.btnTasksView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasksView.Font = new System.Drawing.Font("Nexa Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasksView.Location = new System.Drawing.Point(1159, 111);
            this.btnTasksView.Name = "btnTasksView";
            this.btnTasksView.Size = new System.Drawing.Size(75, 23);
            this.btnTasksView.TabIndex = 2;
            this.btnTasksView.Text = "View";
            this.btnTasksView.UseVisualStyleBackColor = true;
            this.btnTasksView.Click += new System.EventHandler(this.btnTasksView_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(44, 167);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.Size = new System.Drawing.Size(1190, 369);
            this.dgvTasks.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1277, 566);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit Task";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtDeleteTask);
            this.groupBox2.Location = new System.Drawing.Point(696, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 492);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Task";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Nexa Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(193, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(89, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Task ID";
            // 
            // txtDeleteTask
            // 
            this.txtDeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteTask.Location = new System.Drawing.Point(277, 117);
            this.txtDeleteTask.Name = "txtDeleteTask";
            this.txtDeleteTask.Size = new System.Drawing.Size(77, 22);
            this.txtDeleteTask.TabIndex = 26;
            this.txtDeleteTask.Leave += new System.EventHandler(this.txtDeleteTask_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDateUpdate);
            this.groupBox1.Controls.Add(this.btnClearTaskUp);
            this.groupBox1.Controls.Add(this.btnUpdateTask);
            this.groupBox1.Controls.Add(this.txtHoursUpdate);
            this.groupBox1.Controls.Add(this.txtSearchTaskID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(145, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 492);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Task";
            // 
            // dtpDateUpdate
            // 
            this.dtpDateUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateUpdate.Location = new System.Drawing.Point(208, 191);
            this.dtpDateUpdate.Name = "dtpDateUpdate";
            this.dtpDateUpdate.Size = new System.Drawing.Size(241, 22);
            this.dtpDateUpdate.TabIndex = 30;
            // 
            // btnClearTaskUp
            // 
            this.btnClearTaskUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTaskUp.Font = new System.Drawing.Font("Nexa Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTaskUp.Location = new System.Drawing.Point(309, 414);
            this.btnClearTaskUp.Name = "btnClearTaskUp";
            this.btnClearTaskUp.Size = new System.Drawing.Size(75, 23);
            this.btnClearTaskUp.TabIndex = 29;
            this.btnClearTaskUp.Text = "Clear";
            this.btnClearTaskUp.UseVisualStyleBackColor = true;
            this.btnClearTaskUp.Click += new System.EventHandler(this.btnClearTaskUp_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTask.Font = new System.Drawing.Font("Nexa Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTask.Location = new System.Drawing.Point(208, 414);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateTask.TabIndex = 28;
            this.btnUpdateTask.Text = "Update";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // txtHoursUpdate
            // 
            this.txtHoursUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursUpdate.Location = new System.Drawing.Point(208, 265);
            this.txtHoursUpdate.Name = "txtHoursUpdate";
            this.txtHoursUpdate.Size = new System.Drawing.Size(77, 22);
            this.txtHoursUpdate.TabIndex = 27;
            this.txtHoursUpdate.Leave += new System.EventHandler(this.txtHoursUpdate_Leave);
            // 
            // txtSearchTaskID
            // 
            this.txtSearchTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTaskID.Location = new System.Drawing.Point(208, 117);
            this.txtSearchTaskID.Name = "txtSearchTaskID";
            this.txtSearchTaskID.Size = new System.Drawing.Size(77, 22);
            this.txtSearchTaskID.TabIndex = 24;
            this.txtSearchTaskID.Leave += new System.EventHandler(this.txtSearchTaskID_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Task ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Date";
            // 
            // epProject
            // 
            this.epProject.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epProject.ContainerControl = this;
            // 
            // epDesc
            // 
            this.epDesc.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epDesc.ContainerControl = this;
            // 
            // epHours
            // 
            this.epHours.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epHours.ContainerControl = this;
            // 
            // epOver
            // 
            this.epOver.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epOver.ContainerControl = this;
            // 
            // epTaskIDUp
            // 
            this.epTaskIDUp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epTaskIDUp.ContainerControl = this;
            // 
            // epHrsUp
            // 
            this.epHrsUp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epHrsUp.ContainerControl = this;
            // 
            // epTaskIDDlt
            // 
            this.epTaskIDDlt.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epTaskIDDlt.ContainerControl = this;
            // 
            // DeveloperUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DeveloperUI";
            this.Text = "IMAGINary Inc.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTaskIDUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHrsUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTaskIDDlt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpWorkDate;
        private System.Windows.Forms.TextBox txtWorkingHours;
        private System.Windows.Forms.TextBox txtOverTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnClearAdd;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button btnTasksView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearchTaskID;
        private System.Windows.Forms.TextBox txtDeleteTask;
        private System.Windows.Forms.TextBox txtHoursUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpDateUpdate;
        private System.Windows.Forms.Button btnClearTaskUp;
        private System.Windows.Forms.Button btnUpdateTask;
        private System.Windows.Forms.ErrorProvider epProject;
        private System.Windows.Forms.ErrorProvider epDesc;
        private System.Windows.Forms.ErrorProvider epHours;
        private System.Windows.Forms.ErrorProvider epOver;
        private System.Windows.Forms.ErrorProvider epTaskIDUp;
        private System.Windows.Forms.ErrorProvider epHrsUp;
        private System.Windows.Forms.ErrorProvider epTaskIDDlt;
    }
}