namespace Final_Project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar_panel = new System.Windows.Forms.Panel();
            this.loading_label = new System.Windows.Forms.Label();
            this.percentage_label = new System.Windows.Forms.Label();
            this.Bar_panel = new System.Windows.Forms.Panel();
            this.Bar4 = new System.Windows.Forms.Label();
            this.Bar3 = new System.Windows.Forms.Label();
            this.Bar2 = new System.Windows.Forms.Label();
            this.Bar1 = new System.Windows.Forms.Label();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.mydiaryBtn = new System.Windows.Forms.Button();
            this.calenderBtn = new System.Windows.Forms.Button();
            this.moneybookBtn = new System.Windows.Forms.Button();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.progressBar_panel.SuspendLayout();
            this.Bar_panel.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar_panel
            // 
            this.progressBar_panel.BackgroundImage = global::Final_Project.Properties.Resources.Loading_Page;
            this.progressBar_panel.Controls.Add(this.loading_label);
            this.progressBar_panel.Controls.Add(this.percentage_label);
            this.progressBar_panel.Controls.Add(this.Bar_panel);
            this.progressBar_panel.Location = new System.Drawing.Point(0, -6);
            this.progressBar_panel.Name = "progressBar_panel";
            this.progressBar_panel.Size = new System.Drawing.Size(1034, 495);
            this.progressBar_panel.TabIndex = 0;
            // 
            // loading_label
            // 
            this.loading_label.AutoSize = true;
            this.loading_label.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.loading_label.Location = new System.Drawing.Point(419, 160);
            this.loading_label.Name = "loading_label";
            this.loading_label.Size = new System.Drawing.Size(263, 64);
            this.loading_label.TabIndex = 3;
            this.loading_label.Text = "Loading...";
            // 
            // percentage_label
            // 
            this.percentage_label.AutoSize = true;
            this.percentage_label.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage_label.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.percentage_label.Location = new System.Drawing.Point(802, 232);
            this.percentage_label.Name = "percentage_label";
            this.percentage_label.Size = new System.Drawing.Size(102, 64);
            this.percentage_label.TabIndex = 2;
            this.percentage_label.Text = "0%";
            // 
            // Bar_panel
            // 
            this.Bar_panel.BackColor = System.Drawing.Color.Silver;
            this.Bar_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bar_panel.Controls.Add(this.Bar4);
            this.Bar_panel.Controls.Add(this.Bar3);
            this.Bar_panel.Controls.Add(this.Bar2);
            this.Bar_panel.Controls.Add(this.Bar1);
            this.Bar_panel.Location = new System.Drawing.Point(286, 241);
            this.Bar_panel.Name = "Bar_panel";
            this.Bar_panel.Size = new System.Drawing.Size(500, 40);
            this.Bar_panel.TabIndex = 1;
            // 
            // Bar4
            // 
            this.Bar4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Bar4.Location = new System.Drawing.Point(-4, -2);
            this.Bar4.Name = "Bar4";
            this.Bar4.Size = new System.Drawing.Size(500, 40);
            this.Bar4.TabIndex = 3;
            this.Bar4.Visible = false;
            // 
            // Bar3
            // 
            this.Bar3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Bar3.Location = new System.Drawing.Point(-4, 0);
            this.Bar3.Name = "Bar3";
            this.Bar3.Size = new System.Drawing.Size(375, 40);
            this.Bar3.TabIndex = 2;
            this.Bar3.Visible = false;
            // 
            // Bar2
            // 
            this.Bar2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Bar2.Location = new System.Drawing.Point(-4, 0);
            this.Bar2.Name = "Bar2";
            this.Bar2.Size = new System.Drawing.Size(250, 40);
            this.Bar2.TabIndex = 1;
            this.Bar2.Visible = false;
            // 
            // Bar1
            // 
            this.Bar1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Bar1.Location = new System.Drawing.Point(-4, 0);
            this.Bar1.Name = "Bar1";
            this.Bar1.Size = new System.Drawing.Size(125, 40);
            this.Bar1.TabIndex = 0;
            this.Bar1.Visible = false;
            // 
            // menu_panel
            // 
            this.menu_panel.Controls.Add(this.mydiaryBtn);
            this.menu_panel.Controls.Add(this.calenderBtn);
            this.menu_panel.Controls.Add(this.moneybookBtn);
            this.menu_panel.Location = new System.Drawing.Point(2, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(1031, 491);
            this.menu_panel.TabIndex = 1;
            // 
            // mydiaryBtn
            // 
            this.mydiaryBtn.BackColor = System.Drawing.Color.White;
            this.mydiaryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mydiaryBtn.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mydiaryBtn.Location = new System.Drawing.Point(811, 142);
            this.mydiaryBtn.Name = "mydiaryBtn";
            this.mydiaryBtn.Size = new System.Drawing.Size(200, 60);
            this.mydiaryBtn.TabIndex = 2;
            this.mydiaryBtn.Text = "MyDiary";
            this.mydiaryBtn.UseVisualStyleBackColor = false;
            this.mydiaryBtn.Click += new System.EventHandler(this.mydiaryBtn_Click);
            // 
            // calenderBtn
            // 
            this.calenderBtn.BackColor = System.Drawing.Color.White;
            this.calenderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calenderBtn.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenderBtn.Location = new System.Drawing.Point(811, 10);
            this.calenderBtn.Name = "calenderBtn";
            this.calenderBtn.Size = new System.Drawing.Size(200, 60);
            this.calenderBtn.TabIndex = 1;
            this.calenderBtn.Text = "Calender";
            this.calenderBtn.UseVisualStyleBackColor = false;
            this.calenderBtn.Click += new System.EventHandler(this.calenderBtn_Click);
            // 
            // moneybookBtn
            // 
            this.moneybookBtn.BackColor = System.Drawing.Color.White;
            this.moneybookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moneybookBtn.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneybookBtn.Location = new System.Drawing.Point(811, 76);
            this.moneybookBtn.Name = "moneybookBtn";
            this.moneybookBtn.Size = new System.Drawing.Size(200, 60);
            this.moneybookBtn.TabIndex = 0;
            this.moneybookBtn.Text = "MoneyBook";
            this.moneybookBtn.UseVisualStyleBackColor = false;
            this.moneybookBtn.Click += new System.EventHandler(this.moneybookBtn_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 486);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.progressBar_panel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.progressBar_panel.ResumeLayout(false);
            this.progressBar_panel.PerformLayout();
            this.Bar_panel.ResumeLayout(false);
            this.menu_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel progressBar_panel;
        private System.Windows.Forms.Panel Bar_panel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Bar1;
        private System.Windows.Forms.Label Bar4;
        private System.Windows.Forms.Label Bar3;
        private System.Windows.Forms.Label Bar2;
        private System.Windows.Forms.Label percentage_label;
        private System.Windows.Forms.Label loading_label;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button moneybookBtn;
        private System.Windows.Forms.Button mydiaryBtn;
        private System.Windows.Forms.Button calenderBtn;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
    }
}

