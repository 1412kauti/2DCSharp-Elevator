using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Elevator_Assignment
{
    public partial class Elevator : Form
    {
        public static Elevator ElevatorInstance;
        public PictureBox pBox1;
        public Timer tmr1,tmr2,tmr3,tmr4;
        public FlowLayoutPanel flp1;
        public PictureBox elevBox,elevDoor;
        public bool isboxMoving, isboxdoorOpen;
        string connector;

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        public string connectionstring;

        public int current_floor,current_position;
        public int target_floor, new_position;
        public bool isElevatorMoving = false;
        public bool isdoorOpen = false;
        int initialDoorPosOpen = 65;
        int initialDoorPosClose = 196;
        

        string numFloors;
        public Elevator()
        {
            InitializeComponent();

            ElevatorInstance = this;
            current_position = 104;
            pBox1 = elevatorDoor;
            tmr1 = tmrDoorOpen;
            tmr2 = tmrDoorClose;
            tmr3 = tmrElevatorUp;
            tmr4 = tmrElevatorDown;
            isboxMoving = isElevatorMoving;
            isboxdoorOpen = isdoorOpen;
            elevBox = elevatorYellow;
            elevDoor = elevatorDoor; 
            tmr1.Stop();
            tmr2.Stop();
            tmr3.Stop();
            tmr4.Stop();
        }


        
        

        public void SetConnection(string s)
        {
            connector = s;
            //MessageBox.Show(@"Data Source=" + connector);
            sql_con = new SQLiteConnection(@"Data Source=" + s);

        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection(connector);
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        private void LoadData()
        {
            SetConnection(connector);
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "SELECT * FROM elevator_log";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Logs.LogsInstance.data.DataSource = DT;
            sql_con.Close();
        }
        public void numberofFloorArts(string floornumber)
        {
            /*elevatorYellowBox.Visible = true*/;
            
            numFloors = floornumber;
            for (int i = 1; i < Int32.Parse(numFloors) + 1; i++)
            {

                Label floornum = new Label();
                floornum.Location = new Point(64, 26+i*260);
                floornum.Size = new Size(131, 45);
                floornum.Font = new Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                floornum.Padding = new System.Windows.Forms.Padding(0);
                floornum.Margin = new System.Windows.Forms.Padding(0);
                floornum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                floornum.ForeColor = System.Drawing.SystemColors.Control;
                floornum.AutoSize = false;
                floornum.TextAlign = ContentAlignment.MiddleCenter;
                floornum.Text = i.ToString();

                Button btnCall = new Button();
                btnCall.Location = new Point(12, 150+i*260);
                btnCall.Height = 23;
                btnCall.Width = 35;
                btnCall.BackColor = System.Drawing.Color.Maroon;
                btnCall.ForeColor = System.Drawing.Color.Maroon;
                btnCall.Text = i.ToString();
                btnCall.Click += new EventHandler(floorCall);

                PictureBox floorbg = new PictureBox();
                floorbg.Height = 260;
                floorbg.Width = 260;
                floorbg.Image = Properties.Resources.elevator_front;
                floorbg.Margin = new System.Windows.Forms.Padding(0);
                floorbg.Padding = new System.Windows.Forms.Padding(0);
                floorbg.SizeMode = PictureBoxSizeMode.StretchImage;
                floorbg.Location = new Point(0, i*260);

                PictureBox elevatordoor = new PictureBox();
                elevatordoor.Height = 156;
                elevatordoor.Width = 131;
                elevatorDoor.Margin = new System.Windows.Forms.Padding(0);
                elevatorDoor.Padding = new System.Windows.Forms.Padding(0);
                elevatordoor.Location = new Point(64, 104+(i*260));
                elevatordoor.SizeMode = PictureBoxSizeMode.StretchImage;
                elevatordoor.Image = Properties.Resources.elevator_left_door;

                scrollingPanel.Controls.Add(btnCall);
                scrollingPanel.Controls.Add(floornum);
                scrollingPanel.Controls.Add(floorbg);              
            }
        }
        int i = 65;




        private void btngroundFloorCall_Click(object sender, EventArgs e)
        {
            btngroundFloorCall.Click += new EventHandler(floorCall);
        }

        int j = 196;

        private void Elevator_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void scrollingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Startscreen startscreen = new Startscreen();
            startscreen.Show();
            Elevator.ElevatorInstance.Close();
            ButtonsForm.ButtonsFormInstance.Close();
            Logs.LogsInstance.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void elevatorDoor_Click(object sender, EventArgs e)
        {

        }

        private void elevatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(elevatorToolStripMenuItem.Checked == true) 
            {
                Elevator.ElevatorInstance.Show();
            }
            else if (elevatorToolStripMenuItem.Checked == false)
            {
                Elevator.ElevatorInstance.Hide();
            }
        }
        public void doorOpenAnimation(object sender, EventArgs e)
        {
            if (isboxdoorOpen == false)
            {
                i++;
                Elevator.ElevatorInstance.pBox1.Location = new Point(i, Elevator.ElevatorInstance.pBox1.Location.Y);
                if (Elevator.ElevatorInstance.pBox1.Location.X == initialDoorPosClose)
                {
                    Elevator.ElevatorInstance.tmr1.Stop();
                    i = initialDoorPosOpen;
                    ButtonsForm.ButtonsFormInstance.closeButton.Enabled = true;
                    ButtonsForm.ButtonsFormInstance.openButton.Enabled = true;
                    ButtonsForm.ButtonsFormInstance.flower.Enabled = true;
                    isboxdoorOpen = true;
                }
            }
            else
            {
                Elevator.ElevatorInstance.tmr1.Stop();
                MessageBox.Show("The Door is Already CLOSED\n OPEN the Door");
            }
        }

        public void doorCloseAnimation(object sender, EventArgs e)
        {
            if (isboxdoorOpen == true)
            {
                j--;
                Elevator.ElevatorInstance.pBox1.Location = new Point(j, Elevator.ElevatorInstance.pBox1.Location.Y);
                if (Elevator.ElevatorInstance.pBox1.Location.X == initialDoorPosOpen)
                {
                    Elevator.ElevatorInstance.tmr2.Stop();
                    j = initialDoorPosClose;
                    ButtonsForm.ButtonsFormInstance.closeButton.Enabled = true;
                    ButtonsForm.ButtonsFormInstance.openButton.Enabled = true;
                    ButtonsForm.ButtonsFormInstance.flower.Enabled = true;
                    isboxdoorOpen = false;
                    
                }
            }
            else
            {
                Elevator.ElevatorInstance.tmr2.Stop();
                MessageBox.Show("The Door is already Open\n CLOSE the door first");
                
            }
        }
        public int dummy;
        public void floorCall(object sender, EventArgs e)
        {
            if(isboxdoorOpen == false)
            {
                if (isboxMoving == false)
                {
                    Button btn = sender as Button;
                    isboxMoving = true;
                    target_floor = int.Parse(btn.Text);
                    new_position = 104 + (target_floor * 260);
                    current_position = Elevator.ElevatorInstance.elevBox.Location.Y;
                    current_floor = (current_position - 104) / 260;
                    dummy = current_position;
                    var timeString = DateTime.Now.ToString("t");
                    string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
                    ButtonsForm.ButtonsFormInstance.floor_indicator.Text = btn.Text;
                    ButtonsForm.ButtonsFormInstance.openButton.Enabled = true;
                    ButtonsForm.ButtonsFormInstance.closeButton.Enabled = true;
                    string txtQuery = "INSERT INTO elevator_log (Date,Time,CurrentFloor, TargetFloor, IsDoorOpen, CurrentFloorPosition, TargetFloorPosition) VALUES ('" + date + "','" + timeString + "','" + current_floor + "','" + target_floor + "','" + isboxdoorOpen + "','" + current_position + "','" + new_position + "')";
                    ExecuteQuery(txtQuery);
                    LoadData();

                    //string query = "INSERT INTO"
                    if ((new_position - current_position) > 0)
                    {
                        SpeechSynthesizer say = new SpeechSynthesizer();
                        say.Volume = 100;
                        say.Rate = 2;
                        say.Speak("Going Down");
                        ButtonsForm.ButtonsFormInstance.down.Visible = true;
                        ButtonsForm.ButtonsFormInstance.up.Visible = false;
                        ButtonsForm.ButtonsFormInstance.openButton.Enabled = false;
                        ButtonsForm.ButtonsFormInstance.closeButton.Enabled = false;
                        Elevator.ElevatorInstance.tmr3.Start();

                    }
                    else if ((new_position - current_position) < 0)
                    {
                        SpeechSynthesizer say = new SpeechSynthesizer();
                        say.Volume = 100;
                        say.Rate = 2;
                        say.Speak("Going Up");
                        ButtonsForm.ButtonsFormInstance.down.Visible = false;
                        ButtonsForm.ButtonsFormInstance.up.Visible = true;
                        ButtonsForm.ButtonsFormInstance.openButton.Enabled = false;
                        ButtonsForm.ButtonsFormInstance.closeButton.Enabled = false;
                        Elevator.ElevatorInstance.tmr4.Start();
                    }
                    else
                    {
                        MessageBox.Show("Already at destination");
                    }
                    current_position = new_position;
                }
                else
                {
                    MessageBox.Show("Please wait for the elevator to reach destination");
                }
            }
            else
            {
                ButtonsForm.ButtonsFormInstance.openButton.Enabled = true;
                ButtonsForm.ButtonsFormInstance.closeButton.Enabled = true;
                MessageBox.Show("This is Health Hazard\nPlease Close the door");
            }
            
            
            
        }
        private void tmrElevatorUp_Tick(object sender, EventArgs e)
        {
            Elevator.ElevatorInstance.elevBox.Location = new Point(Elevator.ElevatorInstance.elevBox.Location.X, dummy++);
            
            //System.Diagnostics.Debug.WriteLine(Elevator.ElevatorInstance.elevBox.Location);
            if (Elevator.ElevatorInstance.elevBox.Location.Y >= new_position)
            {
                Elevator.ElevatorInstance.tmr3.Stop();
                Elevator.ElevatorInstance.elevBox.Location = new Point(Elevator.ElevatorInstance.elevBox.Location.X, new_position);
                Elevator.ElevatorInstance.elevDoor.Location = new Point(Elevator.ElevatorInstance.elevDoor.Location.X, new_position);
                ButtonsForm.ButtonsFormInstance.openButton.Enabled = true;
                ButtonsForm.ButtonsFormInstance.closeButton.Enabled = true;
                ButtonsForm.ButtonsFormInstance.down.Visible = false;
                ButtonsForm.ButtonsFormInstance.up.Visible = false;
                isboxMoving = false;
            }
        }
        private void tmrElevatorDown_Tick(object sender, EventArgs e)
        {
            Elevator.ElevatorInstance.elevBox.Location = new Point(Elevator.ElevatorInstance.elevBox.Location.X, dummy--);
            
            //System.Diagnostics.Debug.WriteLine(Elevator.ElevatorInstance.elevBox.Location);
            if (Elevator.ElevatorInstance.elevBox.Location.Y <= new_position)
            {
                Elevator.ElevatorInstance.tmr4.Stop();
                Elevator.ElevatorInstance.elevBox.Location = new Point(Elevator.ElevatorInstance.elevBox.Location.X, new_position);
                Elevator.ElevatorInstance.elevDoor.Location = new Point(Elevator.ElevatorInstance.elevDoor.Location.X, new_position);
                ButtonsForm.ButtonsFormInstance.openButton.Enabled = true;
                ButtonsForm.ButtonsFormInstance.closeButton.Enabled = true;
                ButtonsForm.ButtonsFormInstance.down.Visible = false;
                ButtonsForm.ButtonsFormInstance.up.Visible = false;
                isboxMoving = false;
            }
        }
    }

}
