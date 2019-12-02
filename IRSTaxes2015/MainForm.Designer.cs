namespace IRSTaxes2015
{
    partial class MainForm
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
            this.calculate = new System.Windows.Forms.Button();
            this.userSalary = new System.Windows.Forms.TextBox();
            this.taxOwed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taxedSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SSN = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.searchSSN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.White;
            this.calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate.ForeColor = System.Drawing.Color.Black;
            this.calculate.Location = new System.Drawing.Point(90, 354);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(84, 29);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // userSalary
            // 
            this.userSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userSalary.Location = new System.Drawing.Point(194, 157);
            this.userSalary.Name = "userSalary";
            this.userSalary.Size = new System.Drawing.Size(100, 15);
            this.userSalary.TabIndex = 7;
            this.userSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userSalary_KeyPress);
            // 
            // taxOwed
            // 
            this.taxOwed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taxOwed.Location = new System.Drawing.Point(194, 221);
            this.taxOwed.Name = "taxOwed";
            this.taxOwed.ReadOnly = true;
            this.taxOwed.Size = new System.Drawing.Size(100, 15);
            this.taxOwed.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yearly Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tax Owed";
            // 
            // taxedSalary
            // 
            this.taxedSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taxedSalary.Location = new System.Drawing.Point(194, 292);
            this.taxedSalary.Name = "taxedSalary";
            this.taxedSalary.ReadOnly = true;
            this.taxedSalary.Size = new System.Drawing.Size(100, 15);
            this.taxedSalary.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Taxed Salary";
            // 
            // SSN
            // 
            this.SSN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SSN.Location = new System.Drawing.Point(194, 37);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(100, 15);
            this.SSN.TabIndex = 5;
            this.SSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SSN_KeyPress);
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Location = new System.Drawing.Point(194, 97);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 15);
            this.name.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "SSN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // update
            // 
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update.Location = new System.Drawing.Point(338, 354);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 29);
            this.update.TabIndex = 10;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // submit
            // 
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Location = new System.Drawing.Point(219, 354);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 29);
            this.submit.TabIndex = 9;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // search
            // 
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(605, 87);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 27);
            this.search.TabIndex = 15;
            this.search.Text = "Enter";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchSSN
            // 
            this.searchSSN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchSSN.Location = new System.Drawing.Point(591, 62);
            this.searchSSN.Name = "searchSSN";
            this.searchSSN.Size = new System.Drawing.Size(100, 15);
            this.searchSSN.TabIndex = 14;
            this.searchSSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchSSN_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(487, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Search";
            // 
            // Clear
            // 
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Location = new System.Drawing.Point(99, 389);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 29);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // delete
            // 
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Location = new System.Drawing.Point(219, 389);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 29);
            this.delete.TabIndex = 12;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::IRSTaxes2015.Properties.Resources.darknavy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.searchSSN);
            this.Controls.Add(this.search);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taxedSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taxOwed);
            this.Controls.Add(this.userSalary);
            this.Controls.Add(this.calculate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox userSalary;
        private System.Windows.Forms.TextBox taxOwed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taxedSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SSN;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchSSN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button delete;
    }
}

