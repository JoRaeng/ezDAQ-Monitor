namespace YG
{
    partial class Form2
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
            this.file_name = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selected_file_path = new System.Windows.Forms.TextBox();
            this.find_file_path = new System.Windows.Forms.Button();
            this.file_name_default = new System.Windows.Forms.CheckBox();
            this.file_path_default = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // file_name
            // 
            this.file_name.Location = new System.Drawing.Point(12, 85);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(109, 21);
            this.file_name.TabIndex = 0;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(343, 116);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(90, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(439, 116);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(81, 23);
            this.close.TabIndex = 2;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "File Path";
            // 
            // selected_file_path
            // 
            this.selected_file_path.Location = new System.Drawing.Point(12, 26);
            this.selected_file_path.Name = "selected_file_path";
            this.selected_file_path.Size = new System.Drawing.Size(402, 21);
            this.selected_file_path.TabIndex = 4;
            // 
            // find_file_path
            // 
            this.find_file_path.Location = new System.Drawing.Point(420, 26);
            this.find_file_path.Name = "find_file_path";
            this.find_file_path.Size = new System.Drawing.Size(32, 23);
            this.find_file_path.TabIndex = 6;
            this.find_file_path.Text = "...";
            this.find_file_path.UseVisualStyleBackColor = true;
            // 
            // file_name_default
            // 
            this.file_name_default.AutoSize = true;
            this.file_name_default.Checked = true;
            this.file_name_default.CheckState = System.Windows.Forms.CheckState.Checked;
            this.file_name_default.Location = new System.Drawing.Point(127, 87);
            this.file_name_default.Name = "file_name_default";
            this.file_name_default.Size = new System.Drawing.Size(62, 16);
            this.file_name_default.TabIndex = 7;
            this.file_name_default.Text = "Default";
            this.file_name_default.UseVisualStyleBackColor = true;
            // 
            // file_path_default
            // 
            this.file_path_default.AutoSize = true;
            this.file_path_default.Checked = true;
            this.file_path_default.CheckState = System.Windows.Forms.CheckState.Checked;
            this.file_path_default.Location = new System.Drawing.Point(458, 28);
            this.file_path_default.Name = "file_path_default";
            this.file_path_default.Size = new System.Drawing.Size(62, 16);
            this.file_path_default.TabIndex = 8;
            this.file_path_default.Text = "Default";
            this.file_path_default.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 151);
            this.Controls.Add(this.file_path_default);
            this.Controls.Add(this.file_name_default);
            this.Controls.Add(this.find_file_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selected_file_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.save);
            this.Controls.Add(this.file_name);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox file_name;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox selected_file_path;
        private System.Windows.Forms.Button find_file_path;
        private System.Windows.Forms.CheckBox file_name_default;
        private System.Windows.Forms.CheckBox file_path_default;
    }
}