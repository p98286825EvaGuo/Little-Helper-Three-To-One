namespace Final_Project
{
    partial class Calendar
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
            this.work_panel = new System.Windows.Forms.Panel();
            this.done = new System.Windows.Forms.Button();
            this.add_things = new System.Windows.Forms.RichTextBox();
            this.work_back = new System.Windows.Forms.Button();
            this.important = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.work_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // work_panel
            // 
            this.work_panel.BackColor = System.Drawing.Color.Beige;
            this.work_panel.Controls.Add(this.done);
            this.work_panel.Controls.Add(this.add_things);
            this.work_panel.Controls.Add(this.work_back);
            this.work_panel.Controls.Add(this.important);
            this.work_panel.Controls.Add(this.delete);
            this.work_panel.Controls.Add(this.save);
            this.work_panel.Location = new System.Drawing.Point(-1, -2);
            this.work_panel.Name = "work_panel";
            this.work_panel.Size = new System.Drawing.Size(987, 454);
            this.work_panel.TabIndex = 5;
            // 
            // done
            // 
            this.done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.done.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.done.FlatAppearance.BorderSize = 3;
            this.done.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.done.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.done.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.ForeColor = System.Drawing.Color.Sienna;
            this.done.Location = new System.Drawing.Point(752, 183);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(204, 47);
            this.done.TabIndex = 7;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.Done_Click);
            // 
            // add_things
            // 
            this.add_things.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.add_things.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.add_things.Location = new System.Drawing.Point(47, 24);
            this.add_things.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_things.Name = "add_things";
            this.add_things.Size = new System.Drawing.Size(652, 406);
            this.add_things.TabIndex = 6;
            this.add_things.Text = "asd\nasd\n44\n4\ns";
            this.add_things.MouseClick += new System.Windows.Forms.MouseEventHandler(this.add_things_MouseClick);
            this.add_things.TextChanged += new System.EventHandler(this.add_things_TextChanged);
            this.add_things.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_things_KeyPress);
            this.add_things.KeyUp += new System.Windows.Forms.KeyEventHandler(this.add_things_KeyUp);
            // 
            // work_back
            // 
            this.work_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.work_back.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.work_back.FlatAppearance.BorderSize = 3;
            this.work_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.work_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.work_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.work_back.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work_back.ForeColor = System.Drawing.Color.Sienna;
            this.work_back.Location = new System.Drawing.Point(752, 363);
            this.work_back.Name = "work_back";
            this.work_back.Size = new System.Drawing.Size(204, 47);
            this.work_back.TabIndex = 5;
            this.work_back.Text = "Back";
            this.work_back.UseVisualStyleBackColor = true;
            this.work_back.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // important
            // 
            this.important.Cursor = System.Windows.Forms.Cursors.Hand;
            this.important.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.important.FlatAppearance.BorderSize = 3;
            this.important.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.important.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.important.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.important.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.important.ForeColor = System.Drawing.Color.Sienna;
            this.important.Location = new System.Drawing.Point(752, 130);
            this.important.Name = "important";
            this.important.Size = new System.Drawing.Size(204, 47);
            this.important.TabIndex = 3;
            this.important.Text = "Unimportant";
            this.important.UseVisualStyleBackColor = true;
            this.important.Click += new System.EventHandler(this.important_Click);
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.delete.FlatAppearance.BorderSize = 3;
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Sienna;
            this.delete.Location = new System.Drawing.Point(752, 77);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(204, 47);
            this.delete.TabIndex = 1;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.save.FlatAppearance.BorderSize = 3;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.Sienna;
            this.save.Location = new System.Drawing.Point(752, 24);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(204, 47);
            this.save.TabIndex = 0;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.work_panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calendar_FormClosing);
            this.Shown += new System.EventHandler(this.Calendar_Shown);
            this.work_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel work_panel;
        private System.Windows.Forms.Button important;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button work_back;
        private System.Windows.Forms.RichTextBox add_things;
        private System.Windows.Forms.Button done;
    }
}