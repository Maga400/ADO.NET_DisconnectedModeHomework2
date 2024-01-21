namespace DisConnectedMode
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
            searchTextBox = new TextBox();
            dataGridView = new DataGridView();
            btn_update = new Button();
            btn_fill = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(14, 16);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(1171, 47);
            searchTextBox.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(14, 140);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(1171, 667);
            dataGridView.TabIndex = 2;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.Location = new Point(666, 76);
            btn_update.Margin = new Padding(3, 4, 3, 4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(150, 56);
            btn_update.TabIndex = 3;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_fill
            // 
            btn_fill.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fill.Location = new Point(494, 76);
            btn_fill.Margin = new Padding(3, 4, 3, 4);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(103, 56);
            btn_fill.TabIndex = 4;
            btn_fill.Text = "Fill";
            btn_fill.UseVisualStyleBackColor = true;
            btn_fill.Click += btn_fill_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 823);
            Controls.Add(btn_fill);
            Controls.Add(btn_update);
            Controls.Add(dataGridView);
            Controls.Add(searchTextBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private DataGridView dataGridView;
        private Button btn_update;
        private Button btn_fill;
    }
}