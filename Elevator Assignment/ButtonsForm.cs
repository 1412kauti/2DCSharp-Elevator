using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Speech.Synthesis;

namespace Elevator_Assignment
{
    public partial class ButtonsForm : Form
    {
        public static ButtonsForm ButtonsFormInstance;
        string numFloors;
        public Label floor_indicator;
        public PictureBox up, down;
        public Button openButton, closeButton;
        public FlowLayoutPanel flower;
        public string connector;

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        public ButtonsForm()
        {
            InitializeComponent();
            ButtonsFormInstance = this;
            up = pBoxupArrow;
            down = pBoxdownArrow;
            openButton = btnOpenDoor;
            closeButton = btnCloseDoor;
            flower = flpButtons;
            floor_indicator = lblNumFloors;
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
        public void numberOfFloors(string floorNumber)
        {
            numFloors = floorNumber;
            //lblNumFloors.Text = numFloors.ToString();
            for (int i=0;i<int.Parse(numFloors)+1;i++)
            {
                
                Button btn= new Button();
                btn.Click += new EventHandler(button_click);
                btn.Text = i.ToString();           
                flpButtons.Controls.Add(btn);
            }
        }
        void button_click(object sender,EventArgs e)
        {
            if (Elevator.ElevatorInstance.isboxdoorOpen == false)
            {
                if (Elevator.ElevatorInstance.isboxMoving == false)
                {
                    Button btn = sender as Button;
                    Elevator.ElevatorInstance.isboxMoving = true;
                    Elevator.ElevatorInstance.target_floor = int.Parse(btn.Text);
                    ButtonsForm.ButtonsFormInstance.floor_indicator.Text = btn.Text;
                    Elevator.ElevatorInstance.new_position = 104 + (Elevator.ElevatorInstance.target_floor * 260);
                    Elevator.ElevatorInstance.current_position = Elevator.ElevatorInstance.elevBox.Location.Y;
                    Elevator.ElevatorInstance.current_floor = (Elevator.ElevatorInstance.current_position - 104) / 260;
                    Elevator.ElevatorInstance.dummy = Elevator.ElevatorInstance.current_position;
                    var timeString = DateTime.Now.ToString("t");
                    string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
                    ButtonsForm.ButtonsFormInstance.openButton.Enabled = true;
                    ButtonsForm.ButtonsFormInstance.closeButton.Enabled = true;
                    string txtQuery = "INSERT INTO elevator_log (Date,Time,CurrentFloor, TargetFloor, IsDoorOpen, CurrentFloorPosition, TargetFloorPosition) VALUES ('" + date + "','" + timeString + "','" + Elevator.ElevatorInstance.current_floor + "','" + Elevator.ElevatorInstance.target_floor + "','" + Elevator.ElevatorInstance.isboxdoorOpen + "','" + Elevator.ElevatorInstance.current_position + "','" + Elevator.ElevatorInstance.new_position + "')";
                    ExecuteQuery(txtQuery);
                    LoadData();
                    if ((Elevator.ElevatorInstance.new_position - Elevator.ElevatorInstance.current_position) > 0)
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
                    else if ((Elevator.ElevatorInstance.new_position - Elevator.ElevatorInstance.current_position) < 0)
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

                    Elevator.ElevatorInstance.current_position = Elevator.ElevatorInstance.new_position;

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

        private void elevatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (elevatorToolStripMenuItem.Checked == true)
            {
                Elevator.ElevatorInstance.Show();
            }
            else if (elevatorToolStripMenuItem.Checked == false)
            {
                Elevator.ElevatorInstance.Hide();
            }
        }

        private void btnCloseDoor_Click(object sender, EventArgs e)
        {
            if (Elevator.ElevatorInstance.isboxMoving == false)
            {
                SpeechSynthesizer say = new SpeechSynthesizer();
                say.Volume = 100;
                say.Rate = 2;
                say.Speak("Closing The Door");
                ButtonsForm.ButtonsFormInstance.closeButton.Enabled = false;
                ButtonsForm.ButtonsFormInstance.openButton.Enabled = false;
                ButtonsForm.ButtonsFormInstance.flower.Enabled = false;
                var timeString = DateTime.Now.ToString("t");
                string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
                string txtQuery = "INSERT INTO elevator_log (Date,Time,CurrentFloor, TargetFloor, IsDoorOpen, CurrentFloorPosition, TargetFloorPosition) VALUES ('" + date + "','" + timeString + "','" + Elevator.ElevatorInstance.current_floor + "','" + Elevator.ElevatorInstance.target_floor + "','" + !Elevator.ElevatorInstance.isboxdoorOpen + "','" + Elevator.ElevatorInstance.current_position + "','" + Elevator.ElevatorInstance.new_position + "')";
                ExecuteQuery(txtQuery);
                LoadData();
                Elevator.ElevatorInstance.tmr2.Start();
            }
            else
            {
                MessageBox.Show("Cannot Open the Doors While Operation\nHealth Hazard\nPlease Wait for the Elevator to reach destination");
            }
        }

        private void btnOpenDoor_Click(object sender, EventArgs e)
        {
            if (Elevator.ElevatorInstance.isboxMoving == false)
            {
                SpeechSynthesizer say = new SpeechSynthesizer();
                say.Volume = 100;
                say.Rate = 2;
                say.Speak("Opening The Door");
                ButtonsForm.ButtonsFormInstance.closeButton.Enabled = false;
                ButtonsForm.ButtonsFormInstance.openButton.Enabled = false;
                ButtonsForm.ButtonsFormInstance.flower.Enabled = false;
                var timeString = DateTime.Now.ToString("t");
                string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
                string txtQuery = "INSERT INTO elevator_log (Date,Time,CurrentFloor, TargetFloor, IsDoorOpen, CurrentFloorPosition, TargetFloorPosition) VALUES ('" + date + "','" + timeString + "','" + Elevator.ElevatorInstance.current_floor + "','" + Elevator.ElevatorInstance.target_floor + "','" + !Elevator.ElevatorInstance.isboxdoorOpen + "','" + Elevator.ElevatorInstance.current_position + "','" + Elevator.ElevatorInstance.new_position + "')";
                ExecuteQuery(txtQuery);
                LoadData();
                Elevator.ElevatorInstance.tmr1.Start();
            }
            else
            {
                MessageBox.Show("Cannot Open the Doors While Operation\nHealth Hazard\nPlease Wait for the Elevator to reach destination");
            }
        }

    }
}
