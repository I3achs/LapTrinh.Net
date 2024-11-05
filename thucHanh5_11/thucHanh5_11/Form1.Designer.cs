namespace thucHanh5_11
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
            dtKH = new DataGridView();
            txtThongTinHoaDon = new TextBox();
            btnAdd = new Button();
            btnHdd = new Button();
            btnChange = new Button();
            btnDel = new Button();
            label1 = new Label();
            txtTen = new TextBox();
            txtSDT = new TextBox();
            txtDC = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtKH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dtKH
            // 
            dtKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtKH.Location = new Point(44, 48);
            dtKH.Name = "dtKH";
            dtKH.RowHeadersWidth = 51;
            dtKH.Size = new Size(412, 188);
            dtKH.TabIndex = 1;
            dtKH.CellClick += dtKH_CellContentClick;
            // 
            // txtThongTinHoaDon
            // 
            txtThongTinHoaDon.Location = new Point(528, 314);
            txtThongTinHoaDon.Multiline = true;
            txtThongTinHoaDon.Name = "txtThongTinHoaDon";
            txtThongTinHoaDon.Size = new Size(412, 348);
            txtThongTinHoaDon.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(563, 207);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnHdd
            // 
            btnHdd.Location = new Point(44, 681);
            btnHdd.Name = "btnHdd";
            btnHdd.Size = new Size(103, 29);
            btnHdd.TabIndex = 4;
            btnHdd.Text = "Tạo hóa đơn";
            btnHdd.UseVisualStyleBackColor = true;
            btnHdd.Click += btnHdd_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(698, 207);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(103, 29);
            btnChange.TabIndex = 5;
            btnChange.Text = "Sửa";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(837, 207);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(103, 29);
            btnDel.TabIndex = 6;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(44, 14);
            label1.Name = "label1";
            label1.Size = new Size(254, 31);
            label1.TabIndex = 7;
            label1.Text = "Danh sách khách hàng";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(623, 65);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(259, 27);
            txtTen.TabIndex = 8;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(623, 98);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(259, 27);
            txtSDT.TabIndex = 9;
            // 
            // txtDC
            // 
            txtDC.Location = new Point(623, 131);
            txtDC.Multiline = true;
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(259, 55);
            txtDC.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(541, 69);
            label2.Name = "label2";
            label2.Size = new Size(40, 23);
            label2.TabIndex = 11;
            label2.Text = "Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(541, 102);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 12;
            label3.Text = "SĐT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(541, 132);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 13;
            label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(44, 280);
            label5.Name = "label5";
            label5.Size = new Size(214, 31);
            label5.TabIndex = 14;
            label5.Text = "Danh sách dịch vụ:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(44, 495);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(404, 114);
            checkedListBox1.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(175, 634);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(273, 28);
            comboBox1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 637);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 17;
            label6.Text = "Chọn khách hàng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(528, 280);
            label7.Name = "label7";
            label7.Size = new Size(113, 31);
            label7.TabIndex = 18;
            label7.Text = "Hóa đơn:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 314);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(404, 158);
            dataGridView1.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 721);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDC);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Controls.Add(btnDel);
            Controls.Add(btnChange);
            Controls.Add(btnHdd);
            Controls.Add(btnAdd);
            Controls.Add(txtThongTinHoaDon);
            Controls.Add(dtKH);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtKH).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtKH;
        private TextBox txtThongTinHoaDon;
        private Button btnAdd;
        private Button btnHdd;
        private Button btnChange;
        private Button btnDel;
        private Label label1;
        private TextBox txtTen;
        private TextBox txtSDT;
        private TextBox txtDC;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
    }
}
