namespace ResponsiJuniorProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNama = new TextBox();
            richTextBox1 = new RichTextBox();
            listBox1 = new ListBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label4 = new Label();
            dgvData = new DataGridView();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(27, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 43);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "logo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 95);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Nama Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 137);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 3;
            label3.Text = "Dep. Karyawan :";
            label3.Click += label3_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(150, 92);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(158, 23);
            txtNama.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(150, 134);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(158, 24);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "txtDep";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(150, 164);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 19);
            listBox1.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 189);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(181, 23);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(199, 189);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(189, 23);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(394, 189);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(165, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(365, 32);
            label4.Name = "label4";
            label4.Size = new Size(173, 126);
            label4.TabIndex = 10;
            label4.Text = "ID Departemen:\r\nHR : HR\r\nENG : Engineer\r\nDEV : Developer\r\nPM : Project Manager\r\nFIN : Finance\r\n";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 218);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(547, 202);
            dgvData.TabIndex = 11;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(199, 426);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(165, 23);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 450);
            Controls.Add(btnLoad);
            Controls.Add(dgvData);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(listBox1);
            Controls.Add(richTextBox1);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNama;
        private RichTextBox richTextBox1;
        private ListBox listBox1;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private Label label4;
        private DataGridView dgvData;
        private Button btnLoad;
    }
}
