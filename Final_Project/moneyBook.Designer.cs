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
            this.button_icons = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addBackBtn = new System.Windows.Forms.Button();
            this.HomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.addPanel.SuspendLayout();
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
            this.addPanel.Location = new System.Drawing.Point(0, 1);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(986, 453);
            this.addPanel.TabIndex = 1;
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
            // addBackBtn
            // 
            this.addBackBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addBackBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addBackBtn.FlatAppearance.BorderSize = 2;
            this.addBackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood;
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
            // moneyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.HomePanel);
            this.Name = "moneyBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyBook";
            this.Load += new System.EventHandler(this.moneyBook_Load);
            this.HomePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.addPanel.ResumeLayout(false);
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button addBackBtn;
    }
}