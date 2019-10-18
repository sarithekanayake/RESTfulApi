namespace IMAGINaryClient
{
    partial class ManagerUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnProjects = new System.Windows.Forms.Button();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtDevID = new System.Windows.Forms.TextBox();
            this.btnDevelopers = new System.Windows.Forms.Button();
            this.dgvDevelopers = new System.Windows.Forms.DataGridView();
            this.epDev = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevelopers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDev)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Nexa Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(41, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1285, 599);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnProjects);
            this.tabPage1.Controls.Add(this.dgvProjects);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1277, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Projects";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnProjects
            // 
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.Font = new System.Drawing.Font("Nexa Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjects.Location = new System.Drawing.Point(1159, 111);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(75, 23);
            this.btnProjects.TabIndex = 1;
            this.btnProjects.Text = "View";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Location = new System.Drawing.Point(44, 167);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.Size = new System.Drawing.Size(1190, 369);
            this.dgvProjects.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtDevID);
            this.tabPage2.Controls.Add(this.btnDevelopers);
            this.tabPage2.Controls.Add(this.dgvDevelopers);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1277, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Developers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtDevID
            // 
            this.txtDevID.Location = new System.Drawing.Point(944, 112);
            this.txtDevID.Name = "txtDevID";
            this.txtDevID.Size = new System.Drawing.Size(172, 22);
            this.txtDevID.TabIndex = 2;
            this.txtDevID.Leave += new System.EventHandler(this.txtDevID_Leave);
            // 
            // btnDevelopers
            // 
            this.btnDevelopers.Font = new System.Drawing.Font("Nexa Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevelopers.Location = new System.Drawing.Point(1159, 111);
            this.btnDevelopers.Name = "btnDevelopers";
            this.btnDevelopers.Size = new System.Drawing.Size(75, 23);
            this.btnDevelopers.TabIndex = 1;
            this.btnDevelopers.Text = "View";
            this.btnDevelopers.UseVisualStyleBackColor = true;
            this.btnDevelopers.Click += new System.EventHandler(this.btnDevelopers_Click);
            // 
            // dgvDevelopers
            // 
            this.dgvDevelopers.AllowUserToAddRows = false;
            this.dgvDevelopers.AllowUserToDeleteRows = false;
            this.dgvDevelopers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevelopers.Location = new System.Drawing.Point(44, 167);
            this.dgvDevelopers.Name = "dgvDevelopers";
            this.dgvDevelopers.ReadOnly = true;
            this.dgvDevelopers.Size = new System.Drawing.Size(1190, 369);
            this.dgvDevelopers.TabIndex = 0;
            // 
            // epDev
            // 
            this.epDev.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epDev.ContainerControl = this;
            // 
            // ManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ManagerUI";
            this.Text = "IMAGINary Inc.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevelopers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.DataGridView dgvDevelopers;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.TextBox txtDevID;
        private System.Windows.Forms.Button btnDevelopers;
        private System.Windows.Forms.ErrorProvider epDev;
    }
}