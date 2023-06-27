using BusinessLogicLayer.BLL;
using BusinessLogicLayer.InterfacesBLL;
using DataAccessLayer.DAL;
using DataTransferClasses.Classes;
using System.Text.RegularExpressions;

namespace PresentationLayer.Views
{
    public partial class Rooms : Form
    {
        private IRoomTypeBLL roomTypeBLL;
        private IRoomBLL roomBLL;

        public Rooms(IRoomTypeBLL roomTypeBLL, IRoomBLL roomBLL)
        {
            InitializeComponent();
            this.roomTypeBLL = roomTypeBLL;
            this.roomBLL = roomBLL;
        }

        private void btnAddRoomType_Click(object sender, EventArgs e)
        {
            if (IsFormValidRoomType())
            {
                RoomType roomType = new RoomType(tbName.Text, float.Parse(tbCost.Text), tbDescription.Text);
                try
                {
                    bool roomTypeSuccess = roomTypeBLL.AddRoomType(roomType);
                    if (roomTypeSuccess)
                    {
                        MessageBox.Show("Room Type added Successfully!", "Message", MessageBoxButtons.OK);
                    }
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
                btnClearRoomType_Click(null, null);
                DisplayAllRoomTypes(dgvRoomType);
            }
        }

        private bool IsFormValidRoomType()
        {
            if (string.IsNullOrEmpty(tbName.Text) ||
                string.IsNullOrEmpty(tbDescription.Text) ||
                string.IsNullOrEmpty(tbCost.Text))
            {
                MessageBox.Show("Please fill all information", "Error", MessageBoxButtons.OK);
                return false;
            }
            if (!Regex.IsMatch(tbName.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Invalid name. Only alphabetic characters and spaces are allowed.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (!Regex.IsMatch(tbDescription.Text, @"^[A-Za-z0-9\s\.,!?\-]+$"))
            {
                MessageBox.Show("Invalid description. Only alphanumeric characters, spaces, and punctuation marks (.,!-?) are allowed.", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (!float.TryParse(tbCost.Text, out _))
            {
                MessageBox.Show("Invalid cost value", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (!Regex.IsMatch(tbCost.Text, @"^\d+(\.\d{1,2})?$"))
            {
                MessageBox.Show("Invalid cost value. Please enter a valid numeric amount.", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }


        private void btnUpdateRoomType_Click(object sender, EventArgs e)
        {
            RoomType roomType = new RoomType(tbName.Text, float.Parse(tbCost.Text), tbDescription.Text);
            try
            {
                bool updateSuccesss = roomTypeBLL.UpdateRoomType(roomType, Convert.ToInt32(tbRoomTypeId.Text));
                if (updateSuccesss)
                {
                    MessageBox.Show("Room Type updated Successfully!", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Update Room Type Failed!", "Message", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            btnClearRoomType_Click(null, null);
            DisplayAllRoomTypes(dgvRoomType);

          
        }



        private void btnDeleteRoomType_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bool deleteSuccess = roomTypeBLL.DeleteRoomType(tbRoomTypeId.Text);
                    if (deleteSuccess)
                    {
                        MessageBox.Show("Room Type deleted Successfully!", "Message", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Delete Room Type Failed!", "Message", MessageBoxButtons.OK);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                btnClearRoomType_Click(null, null);
                DisplayAllRoomTypes(dgvRoomType);

            }
            
        }


        private void DisplayAllRoomTypes(DataGridView data)
        {
            try
            {
                data.DataSource = roomTypeBLL.GetAllRoomTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            
        }






        private void Rooms_Load(object sender, EventArgs e)
        {
            DisplayAllRoomTypes(dgvRoomType);
            DisplayAllRoom(dgvRoom);

            List<string> roomTypes = roomBLL.GetRoomTypeName();

            foreach (string roomType in roomTypes)
            {
                cbRoomType.Items.Add(roomType);
            }
           


        }



        private void btnClearRoomType_Click(object sender, EventArgs e)
        {
            tbRoomTypeId.Clear();
            tbName.Clear();

            tbCost.Clear();
            tbDescription.Clear();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsFormValidRoom())
            {
                Room roomObj = this.FillEntity();
                try
                {
                    bool success = roomBLL.AddRoom(roomObj);
                    if (success)
                    {
                        MessageBox.Show("Room added Successfully!", "Message", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Adding Room Failed!", "Message", MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }

                btnClear_Click(null, null);
                DisplayAllRoom(dgvRoom);
            }

        }

        private bool IsFormValidRoom()
        {
            if (string.IsNullOrEmpty(tbRoomNo.Text) ||
                string.IsNullOrEmpty(cbRoomType.Text) ||
                string.IsNullOrEmpty(cbAvailability.Text))
            {
                MessageBox.Show("Please provide all information", "Error", MessageBoxButtons.OK);
                return false;
            }

            if (!Regex.IsMatch(tbRoomNo.Text, @"^[A-Za-z0-9]+$"))
            {
                MessageBox.Show("Invalid room number. Only alphanumeric characters are allowed.", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private Room FillEntity()
        {
            var room = new Room();

            room.RoomNumber = this.tbRoomNo.Text;
            room.Status = this.cbAvailability.Text;
            room.TypeId = roomTypeBLL.GetRoomTypeIdByName(cbRoomType.Text);

            return room;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            tbRoomId.Clear();
            tbRoomNo.Clear();
            cbRoomType.Text = String.Empty;
            cbAvailability.Text = String.Empty;
        }

        private void DisplayAllRoom(DataGridView data)
        {
            try
            {
                data.DataSource = roomBLL.GetAllRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool deletionSuccess = roomBLL.DeleteRoom(Convert.ToInt32(tbRoomId.Text));
                if (deletionSuccess)
                {
                    MessageBox.Show("Room deleted Successfully!", "Message", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            btnClear_Click(null, null);
            DisplayAllRoom(dgvRoom);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsFormValidRoom())
            {
                Room roomObj = this.FillEntity();
                try
                {
                    bool updateSuccess = roomBLL.UpdateRoom(roomObj, Convert.ToInt32(tbRoomId.Text));
                    if (updateSuccess)
                    {
                        MessageBox.Show("Room updated Successfully!", "Message", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Update Room Failed!", "Message", MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }

                btnClear_Click(null, null);
                DisplayAllRoom(dgvRoom);
            }
        }

        private void dgvRoomType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbRoomTypeId.Text = dgvRoomType.CurrentRow.Cells[0].Value.ToString();
            tbName.Text = dgvRoomType.CurrentRow.Cells[1].Value.ToString();
            tbCost.Text = dgvRoomType.CurrentRow.Cells[2].Value.ToString();
            tbDescription.Text = dgvRoomType.CurrentRow.Cells[3].Value.ToString();
          
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbRoomId.Text = dgvRoom.CurrentRow.Cells[0].Value.ToString();
            tbRoomNo.Text = dgvRoom.CurrentRow.Cells[1].Value.ToString();
            cbRoomType.Text = dgvRoom.CurrentRow.Cells[2].Value.ToString();
            cbAvailability.Text = dgvRoom.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
