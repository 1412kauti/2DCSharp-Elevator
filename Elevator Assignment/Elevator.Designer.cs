
namespace Elevator_Assignment
{
    partial class Elevator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elevator));
            this.tmrDoorOpen = new System.Windows.Forms.Timer(this.components);
            this.tmrDoorClose = new System.Windows.Forms.Timer(this.components);
            this.scrollingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btngroundFloorCall = new System.Windows.Forms.Button();
            this.elevatorDoor = new System.Windows.Forms.PictureBox();
            this.elevatorYellow = new System.Windows.Forms.PictureBox();
            this.elevatorFrame = new System.Windows.Forms.PictureBox();
            this.tmrElevatorUp = new System.Windows.Forms.Timer(this.components);
            this.tmrElevatorDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.elevatorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrollingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorFrame)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrDoorOpen
            // 
            this.tmrDoorOpen.Enabled = true;
            this.tmrDoorOpen.Interval = 10;
            this.tmrDoorOpen.Tick += new System.EventHandler(this.doorOpenAnimation);
            // 
            // tmrDoorClose
            // 
            this.tmrDoorClose.Enabled = true;
            this.tmrDoorClose.Interval = 10;
            this.tmrDoorClose.Tick += new System.EventHandler(this.doorCloseAnimation);
            // 
            // scrollingPanel
            // 
            this.scrollingPanel.AutoScroll = true;
            this.scrollingPanel.AutoSize = true;
            this.scrollingPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scrollingPanel.BackgroundImage")));
            this.scrollingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scrollingPanel.Controls.Add(this.label1);
            this.scrollingPanel.Controls.Add(this.btngroundFloorCall);
            this.scrollingPanel.Controls.Add(this.elevatorDoor);
            this.scrollingPanel.Controls.Add(this.elevatorYellow);
            this.scrollingPanel.Controls.Add(this.elevatorFrame);
            this.scrollingPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.scrollingPanel.Name = "scrollingPanel";
            this.scrollingPanel.Size = new System.Drawing.Size(279, 404);
            this.scrollingPanel.TabIndex = 1;
            this.scrollingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.scrollingPanel_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(64, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btngroundFloorCall
            // 
            this.btngroundFloorCall.BackColor = System.Drawing.Color.Maroon;
            this.btngroundFloorCall.ForeColor = System.Drawing.Color.Maroon;
            this.btngroundFloorCall.Location = new System.Drawing.Point(12, 150);
            this.btngroundFloorCall.Name = "btngroundFloorCall";
            this.btngroundFloorCall.Size = new System.Drawing.Size(35, 23);
            this.btngroundFloorCall.TabIndex = 3;
            this.btngroundFloorCall.Text = "0";
            this.btngroundFloorCall.UseVisualStyleBackColor = false;
            this.btngroundFloorCall.Click += new System.EventHandler(this.btngroundFloorCall_Click);
            // 
            // elevatorDoor
            // 
            this.elevatorDoor.BackgroundImage = global::Elevator_Assignment.Properties.Resources.elevator_left_door;
            this.elevatorDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elevatorDoor.Location = new System.Drawing.Point(64, 104);
            this.elevatorDoor.Margin = new System.Windows.Forms.Padding(0);
            this.elevatorDoor.Name = "elevatorDoor";
            this.elevatorDoor.Size = new System.Drawing.Size(131, 156);
            this.elevatorDoor.TabIndex = 2;
            this.elevatorDoor.TabStop = false;
            this.elevatorDoor.Click += new System.EventHandler(this.elevatorDoor_Click);
            // 
            // elevatorYellow
            // 
            this.elevatorYellow.BackColor = System.Drawing.Color.Yellow;
            this.elevatorYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elevatorYellow.Location = new System.Drawing.Point(64, 104);
            this.elevatorYellow.Margin = new System.Windows.Forms.Padding(0);
            this.elevatorYellow.Name = "elevatorYellow";
            this.elevatorYellow.Size = new System.Drawing.Size(131, 156);
            this.elevatorYellow.TabIndex = 1;
            this.elevatorYellow.TabStop = false;
            // 
            // elevatorFrame
            // 
            this.elevatorFrame.BackColor = System.Drawing.Color.Transparent;
            this.elevatorFrame.BackgroundImage = global::Elevator_Assignment.Properties.Resources.elevator_front;
            this.elevatorFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elevatorFrame.Location = new System.Drawing.Point(0, 0);
            this.elevatorFrame.Margin = new System.Windows.Forms.Padding(0);
            this.elevatorFrame.Name = "elevatorFrame";
            this.elevatorFrame.Size = new System.Drawing.Size(260, 260);
            this.elevatorFrame.TabIndex = 0;
            this.elevatorFrame.TabStop = false;
            // 
            // tmrElevatorUp
            // 
            this.tmrElevatorUp.Enabled = true;
            this.tmrElevatorUp.Interval = 10;
            this.tmrElevatorUp.Tick += new System.EventHandler(this.tmrElevatorUp_Tick);
            // 
            // tmrElevatorDown
            // 
            this.tmrElevatorDown.Enabled = true;
            this.tmrElevatorDown.Interval = 10;
            this.tmrElevatorDown.Tick += new System.EventHandler(this.tmrElevatorDown_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elevatorToolStripMenuItem,
            this.elevatorToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.elevatorToolStripMenuItem2});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // elevatorToolStripMenuItem
            // 
            this.elevatorToolStripMenuItem.Checked = true;
            this.elevatorToolStripMenuItem.CheckOnClick = true;
            this.elevatorToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.elevatorToolStripMenuItem.Name = "elevatorToolStripMenuItem";
            this.elevatorToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.elevatorToolStripMenuItem.Text = "Elevator";
            this.elevatorToolStripMenuItem.Click += new System.EventHandler(this.elevatorToolStripMenuItem_Click);
            // 
            // elevatorToolStripMenuItem1
            // 
            this.elevatorToolStripMenuItem1.Checked = true;
            this.elevatorToolStripMenuItem1.CheckOnClick = true;
            this.elevatorToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.elevatorToolStripMenuItem1.Name = "elevatorToolStripMenuItem1";
            this.elevatorToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.elevatorToolStripMenuItem1.Text = "ButtonsForm";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Checked = true;
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem3.Text = "Logs";
            // 
            // elevatorToolStripMenuItem2
            // 
            this.elevatorToolStripMenuItem2.Name = "elevatorToolStripMenuItem2";
            this.elevatorToolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            this.elevatorToolStripMenuItem2.Text = "Elevator";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(276, 412);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.scrollingPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Elevator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Elevator";
            this.Load += new System.EventHandler(this.Elevator_Load);
            this.scrollingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elevatorDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevatorFrame)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrDoorOpen;
        private System.Windows.Forms.Timer tmrDoorClose;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel scrollingPanel;
        private System.Windows.Forms.PictureBox elevatorFrame;
        private System.Windows.Forms.PictureBox elevatorYellow;
        private System.Windows.Forms.Button btngroundFloorCall;
        private System.Windows.Forms.PictureBox elevatorDoor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrElevatorUp;
        private System.Windows.Forms.Timer tmrElevatorDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elevatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elevatorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elevatorToolStripMenuItem2;
    }
}