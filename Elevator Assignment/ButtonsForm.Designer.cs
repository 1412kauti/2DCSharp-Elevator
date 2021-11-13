
namespace Elevator_Assignment
{
    partial class ButtonsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCloseDoor = new System.Windows.Forms.Button();
            this.btnOpenDoor = new System.Windows.Forms.Button();
            this.pBoxupArrow = new System.Windows.Forms.PictureBox();
            this.pBoxdownArrow = new System.Windows.Forms.PictureBox();
            this.lblNumFloors = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.upArrowAnim = new System.Windows.Forms.Timer(this.components);
            this.downArrowAnim = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxupArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxdownArrow)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.flpButtons);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 450);
            this.panel1.TabIndex = 0;
            // 
            // flpButtons
            // 
            this.flpButtons.AutoScroll = true;
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.Location = new System.Drawing.Point(0, 108);
            this.flpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(348, 342);
            this.flpButtons.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 108);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.btnCloseDoor);
            this.groupBox1.Controls.Add(this.btnOpenDoor);
            this.groupBox1.Controls.Add(this.pBoxupArrow);
            this.groupBox1.Controls.Add(this.pBoxdownArrow);
            this.groupBox1.Controls.Add(this.lblNumFloors);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(348, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnCloseDoor
            // 
            this.btnCloseDoor.Location = new System.Drawing.Point(118, 82);
            this.btnCloseDoor.Name = "btnCloseDoor";
            this.btnCloseDoor.Size = new System.Drawing.Size(100, 23);
            this.btnCloseDoor.TabIndex = 5;
            this.btnCloseDoor.Text = "Close";
            this.btnCloseDoor.UseVisualStyleBackColor = true;
            this.btnCloseDoor.Click += new System.EventHandler(this.btnCloseDoor_Click);
            // 
            // btnOpenDoor
            // 
            this.btnOpenDoor.Location = new System.Drawing.Point(118, 58);
            this.btnOpenDoor.Name = "btnOpenDoor";
            this.btnOpenDoor.Size = new System.Drawing.Size(100, 23);
            this.btnOpenDoor.TabIndex = 4;
            this.btnOpenDoor.Text = "Open";
            this.btnOpenDoor.UseVisualStyleBackColor = true;
            this.btnOpenDoor.Click += new System.EventHandler(this.btnOpenDoor_Click);
            // 
            // pBoxupArrow
            // 
            this.pBoxupArrow.BackColor = System.Drawing.Color.White;
            this.pBoxupArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxupArrow.Image = global::Elevator_Assignment.Properties.Resources.up_arrow_gif;
            this.pBoxupArrow.Location = new System.Drawing.Point(12, 13);
            this.pBoxupArrow.Name = "pBoxupArrow";
            this.pBoxupArrow.Size = new System.Drawing.Size(100, 92);
            this.pBoxupArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxupArrow.TabIndex = 2;
            this.pBoxupArrow.TabStop = false;
            this.pBoxupArrow.Visible = false;
            // 
            // pBoxdownArrow
            // 
            this.pBoxdownArrow.BackColor = System.Drawing.Color.White;
            this.pBoxdownArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxdownArrow.Image = global::Elevator_Assignment.Properties.Resources.down_arrow_gif;
            this.pBoxdownArrow.Location = new System.Drawing.Point(236, 12);
            this.pBoxdownArrow.Name = "pBoxdownArrow";
            this.pBoxdownArrow.Size = new System.Drawing.Size(100, 93);
            this.pBoxdownArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxdownArrow.TabIndex = 3;
            this.pBoxdownArrow.TabStop = false;
            this.pBoxdownArrow.Visible = false;
            // 
            // lblNumFloors
            // 
            this.lblNumFloors.AutoSize = true;
            this.lblNumFloors.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumFloors.Location = new System.Drawing.Point(143, 16);
            this.lblNumFloors.Name = "lblNumFloors";
            this.lblNumFloors.Size = new System.Drawing.Size(0, 40);
            this.lblNumFloors.TabIndex = 1;
            // 
            // upArrowAnim
            // 
            this.upArrowAnim.Enabled = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeApplicationToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elevatorToolStripMenuItem,
            this.buttonsToolStripMenuItem,
            this.logToolStripMenuItem});
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.closeApplicationToolStripMenuItem.Text = "view";
            // 
            // elevatorToolStripMenuItem
            // 
            this.elevatorToolStripMenuItem.Checked = true;
            this.elevatorToolStripMenuItem.CheckOnClick = true;
            this.elevatorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.elevatorToolStripMenuItem.Name = "elevatorToolStripMenuItem";
            this.elevatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.elevatorToolStripMenuItem.Text = "Elevator";
            this.elevatorToolStripMenuItem.Click += new System.EventHandler(this.elevatorToolStripMenuItem_Click);
            // 
            // buttonsToolStripMenuItem
            // 
            this.buttonsToolStripMenuItem.Checked = true;
            this.buttonsToolStripMenuItem.CheckOnClick = true;
            this.buttonsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buttonsToolStripMenuItem.Name = "buttonsToolStripMenuItem";
            this.buttonsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buttonsToolStripMenuItem.Text = "ButtonsForm";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Checked = true;
            this.logToolStripMenuItem.CheckOnClick = true;
            this.logToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logToolStripMenuItem.Text = "Logs";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.settingsToolStripMenuItem.Text = "settings";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // ButtonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ButtonsForm";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxupArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxdownArrow)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumFloors;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pBoxupArrow;
        private System.Windows.Forms.PictureBox pBoxdownArrow;
        private System.Windows.Forms.Button btnCloseDoor;
        private System.Windows.Forms.Button btnOpenDoor;
        private System.Windows.Forms.Timer upArrowAnim;
        private System.Windows.Forms.Timer downArrowAnim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elevatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}