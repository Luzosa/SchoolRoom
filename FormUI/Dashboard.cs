using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Room> rooms = new List<Room>();

        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            RoomListBox.DataSource = rooms;
            RoomListBox.DisplayMember = "FullInfo";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            rooms = db.GetRooms(RoomNumb.Text);

            UpdateBinding();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertRoom(RoomText.Text, Temp.Text, humText.Text);
        }
    }
}
