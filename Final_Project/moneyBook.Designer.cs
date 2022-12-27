namespace Final_Project
{
    partial class moneyBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(moneyBook));
            this.HomePanel = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addBackBtn = new System.Windows.Forms.Button();
            this.button_icons = new System.Windows.Forms.ImageList(this.components);
            this.inputMoneyPanel = new System.Windows.Forms.Panel();
            this.moneyAmounttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.incomeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NotetextBox = new System.Windows.Forms.TextBox();
            this.expenseBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.backIconBtn = new System.Windows.Forms.Button();
            this.HomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.addPanel.SuspendLayout();
            this.inputMoneyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.PowderBlue;
            this.HomePanel.Controls.Add(this.backBtn);
            this.HomePanel.Controls.Add(this.pictureBox1);
            this.HomePanel.Controls.Add(this.CheckBtn);
            this.HomePanel.Controls.Add(this.AddBtn);
            this.HomePanel.Location = new System.Drawing.Point(0, 1);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(986, 454);
            this.HomePanel.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.backBtn.FlatAppearance.BorderSize = 3;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(302, 357);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(346, 57);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.pig;
            this.pictureBox1.Location = new System.Drawing.Point(412, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.CheckBtn.FlatAppearance.BorderSize = 3;
            this.CheckBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.CheckBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.CheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBtn.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBtn.Location = new System.Drawing.Point(302, 280);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(346, 57);
            this.CheckBtn.TabIndex = 1;
            this.CheckBtn.Text = "Check stats";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.AddBtn.FlatAppearance.BorderSize = 3;
            this.AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(302, 204);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(346, 57);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add income/outcome";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addPanel.Controls.Add(this.addBackBtn);
            this.addPanel.Location = new System.Drawing.Point(0, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(986, 454);
            this.addPanel.TabIndex = 1;
            // 
            // addBackBtn
            // 
            this.addBackBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addBackBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addBackBtn.FlatAppearance.BorderSize = 2;
            this.addBackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.addBackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.addBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBackBtn.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBackBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.addBackBtn.Location = new System.Drawing.Point(889, 390);
            this.addBackBtn.Name = "addBackBtn";
            this.addBackBtn.Size = new System.Drawing.Size(83, 47);
            this.addBackBtn.TabIndex = 0;
            this.addBackBtn.Text = "Back";
            this.addBackBtn.UseVisualStyleBackColor = false;
            this.addBackBtn.Click += new System.EventHandler(this.addBackBtn_Click);
            // 
            // button_icons
            // 
            this.button_icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("button_icons.ImageStream")));
            this.button_icons.TransparentColor = System.Drawing.Color.Transparent;
            this.button_icons.Images.SetKeyName(0, "0.png");
            this.button_icons.Images.SetKeyName(1, "1.png");
            this.button_icons.Images.SetKeyName(2, "2.png");
            this.button_icons.Images.SetKeyName(3, "3.png");
            this.button_icons.Images.SetKeyName(4, "4.png");
            this.button_icons.Images.SetKeyName(5, "5.png");
            this.button_icons.Images.SetKeyName(6, "6.png");
            this.button_icons.Images.SetKeyName(7, "7.png");
            this.button_icons.Images.SetKeyName(8, "8.png");
            this.button_icons.Images.SetKeyName(9, "9.png");
            this.button_icons.Images.SetKeyName(10, "10.png");
            this.button_icons.Images.SetKeyName(11, "11.png");
            this.button_icons.Images.SetKeyName(12, "12.png");
            this.button_icons.Images.SetKeyName(13, "13.png");
            this.button_icons.Images.SetKeyName(14, "14.png");
            // 
            // inputMoneyPanel
            // 
            this.inputMoneyPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.inputMoneyPanel.Controls.Add(this.backIconBtn);
            this.inputMoneyPanel.Controls.Add(this.saveBtn);
            this.inputMoneyPanel.Controls.Add(this.expenseBtn);
            this.inputMoneyPanel.Controls.Add(this.NotetextBox);
            this.inputMoneyPanel.Controls.Add(this.label2);
            this.inputMoneyPanel.Controls.Add(this.incomeBtn);
            this.inputMoneyPanel.Controls.Add(this.label1);
            this.inputMoneyPanel.Controls.Add(this.moneyAmounttextBox);
            this.inputMoneyPanel.Location = new System.Drawing.Point(0, 0);
            this.inputMoneyPanel.Name = "inputMoneyPanel";
            this.inputMoneyPanel.Size = new System.Drawing.Size(985, 455);
            this.inputMoneyPanel.TabIndex = 2;
            // 
            // moneyAmounttextBox
            // 
            this.moneyAmounttextBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyAmounttextBox.Location = new System.Drawing.Point(318, 68);
            this.moneyAmounttextBox.Name = "moneyAmounttextBox";
            this.moneyAmounttextBox.Size = new System.Drawing.Size(414, 44);
            this.moneyAmounttextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount";
            // 
            // incomeBtn
            // 
            this.incomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.incomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.incomeBtn.FlatAppearance.BorderSize = 3;
            this.incomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.incomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.incomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeBtn.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.incomeBtn.Location = new System.Drawing.Point(207, 260);
            this.incomeBtn.Name = "incomeBtn";
            this.incomeBtn.Size = new System.Drawing.Size(245, 46);
            this.incomeBtn.TabIndex = 4;
            this.incomeBtn.Text = "Income";
            this.incomeBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Note";
            // 
            // NotetextBox
            // 
            this.NotetextBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotetextBox.Location = new System.Drawing.Point(318, 142);
            this.NotetextBox.Multiline = true;
            this.NotetextBox.Name = "NotetextBox";
            this.NotetextBox.Size = new System.Drawing.Size(414, 99);
            this.NotetextBox.TabIndex = 7;
            // 
            // expenseBtn
            // 
            this.expenseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expenseBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.expenseBtn.FlatAppearance.BorderSize = 3;
            this.expenseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.expenseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.expenseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenseBtn.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.expenseBtn.Location = new System.Drawing.Point(487, 260);
            this.expenseBtn.Name = "expenseBtn";
            this.expenseBtn.Size = new System.Drawing.Size(245, 46);
            this.expenseBtn.TabIndex = 8;
            this.expenseBtn.Text = "Expense";
            this.expenseBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveBtn.FlatAppearance.BorderSize = 3;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.saveBtn.Location = new System.Drawing.Point(207, 335);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(525, 46);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // backIconBtn
            // 
            this.backIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backIconBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backIconBtn.FlatAppearance.BorderSize = 3;
            this.backIconBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.backIconBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.backIconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backIconBtn.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backIconBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.backIconBtn.Location = new System.Drawing.Point(786, 21);
            this.backIconBtn.Name = "backIconBtn";
            this.backIconBtn.Size = new System.Drawing.Size(174, 46);
            this.backIconBtn.TabIndex = 10;
            this.backIconBtn.Text = "Back";
            this.backIconBtn.UseVisualStyleBackColor = true;
            this.backIconBtn.Click += new System.EventHandler(this.backIconBtn_Click);
            // 
            // moneyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.inputMoneyPanel);
            this.Name = "moneyBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyBook";
            this.Load += new System.EventHandler(this.moneyBook_Load);
            this.HomePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.addPanel.ResumeLayout(false);
            this.inputMoneyPanel.ResumeLayout(false);
            this.inputMoneyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.ImageList button_icons;
        private System.Windows.Forms.Button addBackBtn;
        private System.Windows.Forms.Panel inputMoneyPanel;
        private System.Windows.Forms.TextBox NotetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button incomeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox moneyAmounttextBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button expenseBtn;
        private System.Windows.Forms.Button backIconBtn;
    }
}