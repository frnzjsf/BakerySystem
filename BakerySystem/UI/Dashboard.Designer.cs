using System.Windows.Forms.DataVisualization.Charting;

namespace BakerySystem.Properties.Form
{
    partial class Dashboard : System.Windows.Forms.Form
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
            panel1 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            label2 = new Label();
            panel9 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Items = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 730);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.Location = new Point(239, 99);
            panel5.Name = "panel5";
            panel5.Size = new Size(450, 273);
            panel5.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Location = new Point(239, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 150);
            panel3.TabIndex = 2;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(0, 519);
            button6.Name = "button6";
            button6.Size = new Size(233, 67);
            button6.TabIndex = 5;
            button6.Text = "Settings";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(2, 446);
            button5.Name = "button5";
            button5.Size = new Size(233, 67);
            button5.TabIndex = 4;
            button5.Text = "Reports";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(4, 373);
            button4.Name = "button4";
            button4.Size = new Size(233, 67);
            button4.TabIndex = 3;
            button4.Text = "Customers";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(3, 300);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(233, 67);
            button3.TabIndex = 2;
            button3.Text = "Orders";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(3, 227);
            button2.Name = "button2";
            button2.Size = new Size(233, 67);
            button2.TabIndex = 1;
            button2.Text = "Inventory";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 154);
            button1.Name = "button1";
            button1.Size = new Size(233, 67);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(238, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 98);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel6
            // 
            panel6.Location = new Point(490, 99);
            panel6.Name = "panel6";
            panel6.Size = new Size(450, 273);
            panel6.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Location = new Point(3, 99);
            panel4.Name = "panel4";
            panel4.Size = new Size(450, 273);
            panel4.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.Location = new Point(239, 97);
            panel7.Name = "panel7";
            panel7.Size = new Size(456, 300);
            panel7.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.AntiqueWhite;
            panel8.Controls.Add(label2);
            panel8.Location = new Point(722, 97);
            panel8.Name = "panel8";
            panel8.Size = new Size(456, 300);
            panel8.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(101, 27);
            label2.TabIndex = 0;
            label2.Text = "Low Stock";
            // 
            // panel9
            // 
            panel9.BackColor = Color.AntiqueWhite;
            panel9.Controls.Add(label1);
            panel9.Location = new Point(722, 429);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(15);
            panel9.Size = new Size(456, 300);
            panel9.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 6);
            label1.Name = "label1";
            label1.Size = new Size(132, 27);
            label1.TabIndex = 0;
            label1.Text = "Popular Items";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Items, Column3, Status });
            dataGridView1.GridColor = Color.Wheat;
            dataGridView1.Location = new Point(241, 429);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(456, 300);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Order #";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Customer";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Items
            // 
            Items.HeaderText = "Items";
            Items.MinimumWidth = 8;
            Items.Name = "Items";
            Items.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Total";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // Dashboard
            // 
            BackColor = Color.Linen;
            ClientSize = new Size(1178, 724);
            Controls.Add(dataGridView1);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1900, 1080);
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bakery";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Items;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Status;
        private Label label1;
        private Label label2;
    }
}