
namespace HotelMs
{
    partial class FormReservationUpdate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grvAvailableRoom = new System.Windows.Forms.DataGridView();
            this.aid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_room_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_floor_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_room_type_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_price_per_night = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_room_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbSearchType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbRoomTypeFilter = new System.Windows.Forms.ComboBox();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPid = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnRoomRemove = new System.Windows.Forms.Button();
            this.btnRoomDetail = new System.Windows.Forms.Button();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.btnCustomerDetail = new System.Windows.Forms.Button();
            this.grvSelectedRoom = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_per_night = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblResId = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pnResStatus = new System.Windows.Forms.Panel();
            this.lblResStatus = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvAvailableRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSelectedRoom)).BeginInit();
            this.pnResStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExit.Location = new System.Drawing.Point(1092, 603);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 32);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(824, 603);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 32);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalTime.Location = new System.Drawing.Point(313, 82);
            this.dtpArrivalTime.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.Size = new System.Drawing.Size(236, 22);
            this.dtpArrivalTime.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(25, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 107;
            this.label2.Text = "First name";
            // 
            // grvAvailableRoom
            // 
            this.grvAvailableRoom.AllowUserToAddRows = false;
            this.grvAvailableRoom.AllowUserToDeleteRows = false;
            this.grvAvailableRoom.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvAvailableRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvAvailableRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvAvailableRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvAvailableRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvAvailableRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aid,
            this.a_room_code,
            this.a_floor_number,
            this.a_room_type_title,
            this.a_price_per_night,
            this.a_room_type_id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvAvailableRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvAvailableRoom.GridColor = System.Drawing.Color.Gainsboro;
            this.grvAvailableRoom.Location = new System.Drawing.Point(816, 164);
            this.grvAvailableRoom.Margin = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.grvAvailableRoom.Name = "grvAvailableRoom";
            this.grvAvailableRoom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvAvailableRoom.RowHeadersWidth = 45;
            this.grvAvailableRoom.RowTemplate.Height = 30;
            this.grvAvailableRoom.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvAvailableRoom.Size = new System.Drawing.Size(536, 379);
            this.grvAvailableRoom.TabIndex = 121;
            // 
            // aid
            // 
            this.aid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aid.DataPropertyName = "id";
            this.aid.HeaderText = "Room ID";
            this.aid.Name = "aid";
            this.aid.Width = 93;
            // 
            // a_room_code
            // 
            this.a_room_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.a_room_code.DataPropertyName = "room_code";
            this.a_room_code.HeaderText = "Code";
            this.a_room_code.Name = "a_room_code";
            this.a_room_code.Width = 73;
            // 
            // a_floor_number
            // 
            this.a_floor_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.a_floor_number.DataPropertyName = "floor_number";
            this.a_floor_number.HeaderText = "Floor ";
            this.a_floor_number.Name = "a_floor_number";
            this.a_floor_number.Width = 74;
            // 
            // a_room_type_title
            // 
            this.a_room_type_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.a_room_type_title.DataPropertyName = "room_type_title";
            this.a_room_type_title.HeaderText = "Type";
            this.a_room_type_title.Name = "a_room_type_title";
            this.a_room_type_title.Width = 72;
            // 
            // a_price_per_night
            // 
            this.a_price_per_night.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.a_price_per_night.DataPropertyName = "price_per_night";
            this.a_price_per_night.HeaderText = "Price";
            this.a_price_per_night.Name = "a_price_per_night";
            this.a_price_per_night.Width = 71;
            // 
            // a_room_type_id
            // 
            this.a_room_type_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.a_room_type_id.DataPropertyName = "room_type_id";
            this.a_room_type_id.HeaderText = "Column1";
            this.a_room_type_id.Name = "a_room_type_id";
            this.a_room_type_id.Visible = false;
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchRoom.FlatAppearance.BorderSize = 0;
            this.btnSearchRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSearchRoom.ForeColor = System.Drawing.Color.White;
            this.btnSearchRoom.Location = new System.Drawing.Point(1258, 112);
            this.btnSearchRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(94, 23);
            this.btnSearchRoom.TabIndex = 162;
            this.btnSearchRoom.Text = "Search";
            this.btnSearchRoom.UseVisualStyleBackColor = false;
            this.btnSearchRoom.Click += new System.EventHandler(this.btnRoomSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Location = new System.Drawing.Point(816, 112);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(444, 22);
            this.txtSearch.TabIndex = 160;
            // 
            // cbbSearchType
            // 
            this.cbbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSearchType.FormattingEnabled = true;
            this.cbbSearchType.Location = new System.Drawing.Point(816, 82);
            this.cbbSearchType.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbbSearchType.Name = "cbbSearchType";
            this.cbbSearchType.Size = new System.Drawing.Size(260, 24);
            this.cbbSearchType.TabIndex = 161;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(813, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 159;
            this.label1.Text = "Search by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(870, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 165;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(1081, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 164;
            this.label4.Text = "Filter room type";
            // 
            // cbbRoomTypeFilter
            // 
            this.cbbRoomTypeFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbRoomTypeFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbRoomTypeFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbRoomTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomTypeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbRoomTypeFilter.FormattingEnabled = true;
            this.cbbRoomTypeFilter.Items.AddRange(new object[] {
            "Book genre",
            "Book author"});
            this.cbbRoomTypeFilter.Location = new System.Drawing.Point(1084, 82);
            this.cbbRoomTypeFilter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbbRoomTypeFilter.Name = "cbbRoomTypeFilter";
            this.cbbRoomTypeFilter.Size = new System.Drawing.Size(268, 24);
            this.cbbRoomTypeFilter.TabIndex = 163;
            this.cbbRoomTypeFilter.SelectionChangeCommitted += new System.EventHandler(this.cbbRoomTypeFilter_SelectionChangeCommitted);
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureTime.Location = new System.Drawing.Point(557, 82);
            this.dtpDepartureTime.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(236, 22);
            this.dtpDepartureTime.TabIndex = 167;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label6.Location = new System.Drawing.Point(24, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 168;
            this.label6.Text = "Last name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(24, 365);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 170;
            this.label7.Text = "Phone ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label8.Location = new System.Drawing.Point(24, 415);
            this.label8.Margin = new System.Windows.Forms.Padding(4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 172;
            this.label8.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label13.Location = new System.Drawing.Point(24, 127);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 19);
            this.label13.TabIndex = 174;
            this.label13.Text = "Customer\'s info";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label11.Location = new System.Drawing.Point(25, 216);
            this.label11.Margin = new System.Windows.Forms.Padding(4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 176;
            this.label11.Text = "Identification Number";
            // 
            // lblPid
            // 
            this.lblPid.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblPid.Location = new System.Drawing.Point(29, 236);
            this.lblPid.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(260, 22);
            this.lblPid.TabIndex = 258;
            this.lblPid.Text = "ex";
            this.lblPid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblFirstName.Location = new System.Drawing.Point(29, 285);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(260, 22);
            this.lblFirstName.TabIndex = 259;
            this.lblFirstName.Text = "ex";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblLastName.Location = new System.Drawing.Point(28, 335);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(260, 22);
            this.lblLastName.TabIndex = 260;
            this.lblLastName.Text = "ex";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblPhone.Location = new System.Drawing.Point(28, 385);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(260, 22);
            this.lblPhone.TabIndex = 261;
            this.lblPhone.Text = "ex";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblEmail.Location = new System.Drawing.Point(29, 435);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(260, 22);
            this.lblEmail.TabIndex = 262;
            this.lblEmail.Text = "ex";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label15.Location = new System.Drawing.Point(812, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 19);
            this.label15.TabIndex = 268;
            this.label15.Text = "Available rooms";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label17.Location = new System.Drawing.Point(309, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 19);
            this.label17.TabIndex = 269;
            this.label17.Text = "Selected rooms";
            // 
            // btnRoomRemove
            // 
            this.btnRoomRemove.BackColor = System.Drawing.Color.IndianRed;
            this.btnRoomRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomRemove.FlatAppearance.BorderSize = 0;
            this.btnRoomRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRoomRemove.ForeColor = System.Drawing.Color.White;
            this.btnRoomRemove.Location = new System.Drawing.Point(573, 558);
            this.btnRoomRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoomRemove.Name = "btnRoomRemove";
            this.btnRoomRemove.Size = new System.Drawing.Size(220, 26);
            this.btnRoomRemove.TabIndex = 273;
            this.btnRoomRemove.Text = "Remove   >>";
            this.btnRoomRemove.UseVisualStyleBackColor = false;
            this.btnRoomRemove.Click += new System.EventHandler(this.btnRoomRemove_Click);
            // 
            // btnRoomDetail
            // 
            this.btnRoomDetail.BackColor = System.Drawing.Color.Silver;
            this.btnRoomDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomDetail.FlatAppearance.BorderSize = 0;
            this.btnRoomDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRoomDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRoomDetail.Location = new System.Drawing.Point(1044, 558);
            this.btnRoomDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoomDetail.Name = "btnRoomDetail";
            this.btnRoomDetail.Size = new System.Drawing.Size(220, 26);
            this.btnRoomDetail.TabIndex = 272;
            this.btnRoomDetail.Text = "More detail";
            this.btnRoomDetail.UseVisualStyleBackColor = false;
            this.btnRoomDetail.Click += new System.EventHandler(this.btnRoomDetail_Click);
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRoomAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomAdd.FlatAppearance.BorderSize = 0;
            this.btnRoomAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRoomAdd.ForeColor = System.Drawing.Color.White;
            this.btnRoomAdd.Location = new System.Drawing.Point(816, 558);
            this.btnRoomAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(220, 26);
            this.btnRoomAdd.TabIndex = 271;
            this.btnRoomAdd.Text = "<<   Add";
            this.btnRoomAdd.UseVisualStyleBackColor = false;
            this.btnRoomAdd.Click += new System.EventHandler(this.btnRoomAdd_Click);
            // 
            // btnCustomerDetail
            // 
            this.btnCustomerDetail.BackColor = System.Drawing.Color.Silver;
            this.btnCustomerDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerDetail.FlatAppearance.BorderSize = 0;
            this.btnCustomerDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCustomerDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCustomerDetail.Location = new System.Drawing.Point(28, 478);
            this.btnCustomerDetail.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnCustomerDetail.Name = "btnCustomerDetail";
            this.btnCustomerDetail.Size = new System.Drawing.Size(260, 26);
            this.btnCustomerDetail.TabIndex = 274;
            this.btnCustomerDetail.Text = "More detail";
            this.btnCustomerDetail.UseVisualStyleBackColor = false;
            this.btnCustomerDetail.Click += new System.EventHandler(this.btnCustomerDetail_Click);
            // 
            // grvSelectedRoom
            // 
            this.grvSelectedRoom.AllowUserToAddRows = false;
            this.grvSelectedRoom.AllowUserToDeleteRows = false;
            this.grvSelectedRoom.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvSelectedRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvSelectedRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvSelectedRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvSelectedRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSelectedRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.room_code,
            this.floor_number,
            this.room_type_title,
            this.price_per_night,
            this.room_type_id});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvSelectedRoom.DefaultCellStyle = dataGridViewCellStyle4;
            this.grvSelectedRoom.GridColor = System.Drawing.Color.Gainsboro;
            this.grvSelectedRoom.Location = new System.Drawing.Point(313, 164);
            this.grvSelectedRoom.Margin = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.grvSelectedRoom.Name = "grvSelectedRoom";
            this.grvSelectedRoom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvSelectedRoom.RowHeadersWidth = 45;
            this.grvSelectedRoom.RowTemplate.Height = 30;
            this.grvSelectedRoom.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvSelectedRoom.Size = new System.Drawing.Size(480, 379);
            this.grvSelectedRoom.TabIndex = 275;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Room ID";
            this.id.Name = "id";
            this.id.Width = 93;
            // 
            // room_code
            // 
            this.room_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.room_code.DataPropertyName = "room_code";
            this.room_code.HeaderText = "Code";
            this.room_code.Name = "room_code";
            this.room_code.Width = 73;
            // 
            // floor_number
            // 
            this.floor_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.floor_number.DataPropertyName = "floor_number";
            this.floor_number.HeaderText = "Floor ";
            this.floor_number.Name = "floor_number";
            this.floor_number.Width = 74;
            // 
            // room_type_title
            // 
            this.room_type_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.room_type_title.DataPropertyName = "room_type_title";
            this.room_type_title.HeaderText = "Type";
            this.room_type_title.Name = "room_type_title";
            this.room_type_title.Width = 72;
            // 
            // price_per_night
            // 
            this.price_per_night.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price_per_night.DataPropertyName = "price_per_night";
            this.price_per_night.HeaderText = "Price";
            this.price_per_night.Name = "price_per_night";
            this.price_per_night.Width = 71;
            // 
            // room_type_id
            // 
            this.room_type_id.DataPropertyName = "room_type_id";
            this.room_type_id.HeaderText = "Column1";
            this.room_type_id.Name = "room_type_id";
            this.room_type_id.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(554, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 277;
            this.label5.Text = "Departure time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label10.Location = new System.Drawing.Point(310, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 278;
            this.label10.Text = "Arrival time";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerId.Location = new System.Drawing.Point(29, 186);
            this.lblCustomerId.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(260, 22);
            this.lblCustomerId.TabIndex = 281;
            this.lblCustomerId.Text = "ex";
            this.lblCustomerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label16.Location = new System.Drawing.Point(25, 166);
            this.label16.Margin = new System.Windows.Forms.Padding(4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 16);
            this.label16.TabIndex = 280;
            this.label16.Text = "Customer ID";
            // 
            // lblResId
            // 
            this.lblResId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblResId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblResId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblResId.Location = new System.Drawing.Point(28, 83);
            this.lblResId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblResId.Name = "lblResId";
            this.lblResId.Size = new System.Drawing.Size(260, 22);
            this.lblResId.TabIndex = 295;
            this.lblResId.Text = "ex";
            this.lblResId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label14.Location = new System.Drawing.Point(25, 63);
            this.label14.Margin = new System.Windows.Forms.Padding(4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 16);
            this.label14.TabIndex = 294;
            this.label14.Text = "Reservation ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label18.Location = new System.Drawing.Point(205, 24);
            this.label18.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 19);
            this.label18.TabIndex = 293;
            this.label18.Text = "Reservation";
            // 
            // pnResStatus
            // 
            this.pnResStatus.Controls.Add(this.lblResStatus);
            this.pnResStatus.Location = new System.Drawing.Point(28, 22);
            this.pnResStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnResStatus.Name = "pnResStatus";
            this.pnResStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnResStatus.Size = new System.Drawing.Size(170, 24);
            this.pnResStatus.TabIndex = 298;
            // 
            // lblResStatus
            // 
            this.lblResStatus.BackColor = System.Drawing.Color.White;
            this.lblResStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResStatus.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblResStatus.Location = new System.Drawing.Point(1, 1);
            this.lblResStatus.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.lblResStatus.Name = "lblResStatus";
            this.lblResStatus.Size = new System.Drawing.Size(168, 22);
            this.lblResStatus.TabIndex = 293;
            this.lblResStatus.Text = "STATUS";
            this.lblResStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(556, 603);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(260, 32);
            this.btnDelete.TabIndex = 299;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormReservationUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnResStatus);
            this.Controls.Add(this.lblResId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grvSelectedRoom);
            this.Controls.Add(this.btnCustomerDetail);
            this.Controls.Add(this.btnRoomRemove);
            this.Controls.Add(this.btnRoomDetail);
            this.Controls.Add(this.btnRoomAdd);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDepartureTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbRoomTypeFilter);
            this.Controls.Add(this.btnSearchRoom);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbbSearchType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvAvailableRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpArrivalTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "FormReservationUpdate";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update reservation";
            this.Load += new System.EventHandler(this.FormReservationCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvAvailableRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSelectedRoom)).EndInit();
            this.pnResStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.DataGridView grvAvailableRoom;
        private System.Windows.Forms.Button btnSearchRoom;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbSearchType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbRoomTypeFilter;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnRoomRemove;
        private System.Windows.Forms.Button btnRoomDetail;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.Button btnCustomerDetail;
        private System.Windows.Forms.DataGridView grvSelectedRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn aid;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_room_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_floor_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_room_type_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_price_per_night;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_room_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_type_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_per_night;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_type_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblResId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnResStatus;
        private System.Windows.Forms.Label lblResStatus;
        private System.Windows.Forms.Button btnDelete;
    }
}