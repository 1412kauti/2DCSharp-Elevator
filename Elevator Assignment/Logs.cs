using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator_Assignment
{
    public partial class Logs : Form
    {
        public static Logs LogsInstance;
        public DataGridView data;

        public Logs()
        {
            InitializeComponent();
            LogsInstance = this;
            data = dataGridView1;
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
    }
}
