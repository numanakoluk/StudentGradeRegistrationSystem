
namespace StudentGradeRegistrationSystem
{
    partial class FrmTeacherDetail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.MskNo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtExam3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtExam2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtExam1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblAvarage = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTEX1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTEX2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTEX3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVARAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tBLLESSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNoteRecordDataSet = new StudentGradeRegistrationSystem.DbNoteRecordDataSet();
            this.tBLLESSONTableAdapter = new StudentGradeRegistrationSystem.DbNoteRecordDataSetTableAdapters.TBLLESSONTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLLESSONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNoteRecordDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.MskNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "StudentAdd";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "STUDENT SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(113, 173);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(132, 30);
            this.TxtSurname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAME:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(113, 121);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(132, 30);
            this.TxtName.TabIndex = 2;
            // 
            // MskNo
            // 
            this.MskNo.Location = new System.Drawing.Point(113, 74);
            this.MskNo.Mask = "0000";
            this.MskNo.Name = "MskNo";
            this.MskNo.Size = new System.Drawing.Size(132, 30);
            this.MskNo.TabIndex = 1;
            this.MskNo.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtExam3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.TxtExam2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtExam1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(322, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 290);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Notes";
            // 
            // TxtExam3
            // 
            this.TxtExam3.Location = new System.Drawing.Point(113, 167);
            this.TxtExam3.Name = "TxtExam3";
            this.TxtExam3.Size = new System.Drawing.Size(132, 30);
            this.TxtExam3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtExam2
            // 
            this.TxtExam2.Location = new System.Drawing.Point(113, 117);
            this.TxtExam2.Name = "TxtExam2";
            this.TxtExam2.Size = new System.Drawing.Size(132, 30);
            this.TxtExam2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "EXAM 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "EXAM 2:";
            // 
            // TxtExam1
            // 
            this.TxtExam1.Location = new System.Drawing.Point(113, 72);
            this.TxtExam1.Name = "TxtExam1";
            this.TxtExam1.Size = new System.Drawing.Size(132, 30);
            this.TxtExam1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "EXAM 1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblAvarage);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(614, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 290);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Notes";
            // 
            // LblAvarage
            // 
            this.LblAvarage.AutoSize = true;
            this.LblAvarage.Location = new System.Drawing.Point(137, 75);
            this.LblAvarage.Name = "LblAvarage";
            this.LblAvarage.Size = new System.Drawing.Size(34, 24);
            this.LblAvarage.TabIndex = 7;
            this.LblAvarage.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "AVARAGE:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1118, 260);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.sTUDENTNODataGridViewTextBoxColumn,
            this.sTUDENTNAMEDataGridViewTextBoxColumn,
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn,
            this.sTUDENTEX1DataGridViewTextBoxColumn,
            this.sTUDENTEX2DataGridViewTextBoxColumn,
            this.sTUDENTEX3DataGridViewTextBoxColumn,
            this.aVARAGEDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLLESSONBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTUDENTNODataGridViewTextBoxColumn
            // 
            this.sTUDENTNODataGridViewTextBoxColumn.DataPropertyName = "STUDENTNO";
            this.sTUDENTNODataGridViewTextBoxColumn.HeaderText = "STUDENTNO";
            this.sTUDENTNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDENTNODataGridViewTextBoxColumn.Name = "sTUDENTNODataGridViewTextBoxColumn";
            // 
            // sTUDENTNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENTNAME";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENTNAME";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDENTNAMEDataGridViewTextBoxColumn.Name = "sTUDENTNAMEDataGridViewTextBoxColumn";
            // 
            // sTUDENTSURNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENTSURNAME";
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENTSURNAME";
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.Name = "sTUDENTSURNAMEDataGridViewTextBoxColumn";
            // 
            // sTUDENTEX1DataGridViewTextBoxColumn
            // 
            this.sTUDENTEX1DataGridViewTextBoxColumn.DataPropertyName = "STUDENTEX1";
            this.sTUDENTEX1DataGridViewTextBoxColumn.HeaderText = "STUDENTEX1";
            this.sTUDENTEX1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDENTEX1DataGridViewTextBoxColumn.Name = "sTUDENTEX1DataGridViewTextBoxColumn";
            // 
            // sTUDENTEX2DataGridViewTextBoxColumn
            // 
            this.sTUDENTEX2DataGridViewTextBoxColumn.DataPropertyName = "STUDENTEX2";
            this.sTUDENTEX2DataGridViewTextBoxColumn.HeaderText = "STUDENTEX2";
            this.sTUDENTEX2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDENTEX2DataGridViewTextBoxColumn.Name = "sTUDENTEX2DataGridViewTextBoxColumn";
            // 
            // sTUDENTEX3DataGridViewTextBoxColumn
            // 
            this.sTUDENTEX3DataGridViewTextBoxColumn.DataPropertyName = "STUDENTEX3";
            this.sTUDENTEX3DataGridViewTextBoxColumn.HeaderText = "STUDENTEX3";
            this.sTUDENTEX3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDENTEX3DataGridViewTextBoxColumn.Name = "sTUDENTEX3DataGridViewTextBoxColumn";
            // 
            // aVARAGEDataGridViewTextBoxColumn
            // 
            this.aVARAGEDataGridViewTextBoxColumn.DataPropertyName = "AVARAGE";
            this.aVARAGEDataGridViewTextBoxColumn.HeaderText = "AVARAGE";
            this.aVARAGEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aVARAGEDataGridViewTextBoxColumn.Name = "aVARAGEDataGridViewTextBoxColumn";
            // 
            // sTATUSDataGridViewCheckBoxColumn
            // 
            this.sTATUSDataGridViewCheckBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewCheckBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.sTATUSDataGridViewCheckBoxColumn.Name = "sTATUSDataGridViewCheckBoxColumn";
            // 
            // tBLLESSONBindingSource
            // 
            this.tBLLESSONBindingSource.DataMember = "TBLLESSON";
            this.tBLLESSONBindingSource.DataSource = this.dbNoteRecordDataSet;
            // 
            // dbNoteRecordDataSet
            // 
            this.dbNoteRecordDataSet.DataSetName = "DbNoteRecordDataSet";
            this.dbNoteRecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLLESSONTableAdapter
            // 
            this.tBLLESSONTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTeacherDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1127, 568);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTeacherDetail";
            this.Text = "FrmTeacherDetail";
            this.Load += new System.EventHandler(this.FrmTeacherDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLLESSONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNoteRecordDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.MaskedTextBox MskNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtExam3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtExam2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtExam1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblAvarage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbNoteRecordDataSet dbNoteRecordDataSet;
        private System.Windows.Forms.BindingSource tBLLESSONBindingSource;
        private DbNoteRecordDataSetTableAdapters.TBLLESSONTableAdapter tBLLESSONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTEX1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTEX2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTEX3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVARAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sTATUSDataGridViewCheckBoxColumn;
    }
}