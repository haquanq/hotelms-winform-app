
namespace HotelMs
{
    partial class FormReservationCreate
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
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
            this.cbbRoomSearchType = new System.Windows.Forms.ComboBox();
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
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPid = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.btnMoreRoomDetail = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnMoreCustomerDetail = new System.Windows.Forms.Button();
            this.grvSelectedRoom = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_per_night = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChangeCustomer = new System.Windows.Forms.Button();
            this.pnCustomerStatus = new System.Windows.Forms.Panel();
            this.lblCustomerStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvAvailableRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSelectedRoom)).BeginInit();
            this.pnCustomerStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Silver;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cancelBtn.Location = new System.Drawing.Point(1084, 603);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(268, 32);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "Exit";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(816, 603);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(260, 32);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            this.label2.Location = new System.Drawing.Point(28, 214);
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
            this.btnSearchRoom.Click += new System.EventHandler(this.btnSearchRoom_Click);
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
            // cbbRoomSearchType
            // 
            this.cbbRoomSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbRoomSearchType.FormattingEnabled = true;
            this.cbbRoomSearchType.Location = new System.Drawing.Point(816, 82);
            this.cbbRoomSearchType.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbbRoomSearchType.Name = "cbbRoomSearchType";
            this.cbbRoomSearchType.Size = new System.Drawing.Size(260, 24);
            this.cbbRoomSearchType.TabIndex = 161;
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
            this.cbbRoomTypeFilter.SelectionChangeCommitted += new System.EventHandler(this.cbbRoomTypeFitler_SelectionChangeCommitted);
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
            this.label6.Location = new System.Drawing.Point(27, 263);
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
            this.label7.Location = new System.Drawing.Point(27, 313);
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
            this.label8.Location = new System.Drawing.Point(27, 363);
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
            this.label13.Location = new System.Drawing.Point(208, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 19);
            this.label13.TabIndex = 174;
            this.label13.Text = "Customer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label11.Location = new System.Drawing.Point(28, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 176;
            this.label11.Text = "Identification Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label12.Location = new System.Drawing.Point(28, 413);
            this.label12.Margin = new System.Windows.Forms.Padding(4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 178;
            this.label12.Text = "Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label14.Location = new System.Drawing.Point(27, 64);
            this.label14.Margin = new System.Windows.Forms.Padding(4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 16);
            this.label14.TabIndex = 187;
            this.label14.Text = "Customer\'s ID";
            // 
            // lblPid
            // 
            this.lblPid.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblPid.Location = new System.Drawing.Point(32, 184);
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
            this.lblFirstName.Location = new System.Drawing.Point(32, 233);
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
            this.lblLastName.Location = new System.Drawing.Point(31, 283);
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
            this.lblPhone.Location = new System.Drawing.Point(31, 333);
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
            this.lblEmail.Location = new System.Drawing.Point(32, 383);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(260, 22);
            this.lblEmail.TabIndex = 262;
            this.lblEmail.Text = "ex";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblAddress.Location = new System.Drawing.Point(32, 433);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(260, 22);
            this.lblAddress.TabIndex = 263;
            this.lblAddress.Text = "ex";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCustomer.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSearchCustomer.Location = new System.Drawing.Point(165, 112);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(126, 26);
            this.btnSearchCustomer.TabIndex = 265;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerId.Location = new System.Drawing.Point(30, 82);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(262, 22);
            this.txtCustomerId.TabIndex = 264;
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
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoveRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveRoom.FlatAppearance.BorderSize = 0;
            this.btnRemoveRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRemoveRoom.ForeColor = System.Drawing.Color.White;
            this.btnRemoveRoom.Location = new System.Drawing.Point(573, 558);
            this.btnRemoveRoom.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(220, 26);
            this.btnRemoveRoom.TabIndex = 273;
            this.btnRemoveRoom.Text = "Remove   >>";
            this.btnRemoveRoom.UseVisualStyleBackColor = false;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // btnMoreRoomDetail
            // 
            this.btnMoreRoomDetail.BackColor = System.Drawing.Color.Silver;
            this.btnMoreRoomDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoreRoomDetail.FlatAppearance.BorderSize = 0;
            this.btnMoreRoomDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreRoomDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMoreRoomDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMoreRoomDetail.Location = new System.Drawing.Point(1048, 558);
            this.btnMoreRoomDetail.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnMoreRoomDetail.Name = "btnMoreRoomDetail";
            this.btnMoreRoomDetail.Size = new System.Drawing.Size(220, 26);
            this.btnMoreRoomDetail.TabIndex = 272;
            this.btnMoreRoomDetail.Text = "More detail";
            this.btnMoreRoomDetail.UseVisualStyleBackColor = false;
            this.btnMoreRoomDetail.Click += new System.EventHandler(this.btnMoreRoomDetail_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(816, 558);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(220, 26);
            this.btnAddRoom.TabIndex = 271;
            this.btnAddRoom.Text = "<<   Add";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnMoreCustomerDetail
            // 
            this.btnMoreCustomerDetail.BackColor = System.Drawing.Color.Silver;
            this.btnMoreCustomerDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoreCustomerDetail.FlatAppearance.BorderSize = 0;
            this.btnMoreCustomerDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreCustomerDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMoreCustomerDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMoreCustomerDetail.Location = new System.Drawing.Point(31, 476);
            this.btnMoreCustomerDetail.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnMoreCustomerDetail.Name = "btnMoreCustomerDetail";
            this.btnMoreCustomerDetail.Size = new System.Drawing.Size(260, 26);
            this.btnMoreCustomerDetail.TabIndex = 274;
            this.btnMoreCustomerDetail.Text = "More detail";
            this.btnMoreCustomerDetail.UseVisualStyleBackColor = false;
            this.btnMoreCustomerDetail.Click += new System.EventHandler(this.btnMoreCustomerDetail_Click);
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
            this.grvSelectedRoom.Size = new System.Drawing.Size(480, 381);
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
            // btnChangeCustomer
            // 
            this.btnChangeCustomer.BackColor = System.Drawing.Color.Silver;
            this.btnChangeCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeCustomer.FlatAppearance.BorderSize = 0;
            this.btnChangeCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnChangeCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnChangeCustomer.Location = new System.Drawing.Point(30, 112);
            this.btnChangeCustomer.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnChangeCustomer.Name = "btnChangeCustomer";
            this.btnChangeCustomer.Size = new System.Drawing.Size(126, 26);
            this.btnChangeCustomer.TabIndex = 280;
            this.btnChangeCustomer.Text = "Change";
            this.btnChangeCustomer.UseVisualStyleBackColor = false;
            this.btnChangeCustomer.Click += new System.EventHandler(this.btnChangeCustomer_Click);
            // 
            // pnCustomerStatus
            // 
            this.pnCustomerStatus.Controls.Add(this.lblCustomerStatus);
            this.pnCustomerStatus.Location = new System.Drawing.Point(31, 21);
            this.pnCustomerStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnCustomerStatus.Name = "pnCustomerStatus";
            this.pnCustomerStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnCustomerStatus.Size = new System.Drawing.Size(170, 24);
            this.pnCustomerStatus.TabIndex = 299;
            // 
            // lblCustomerStatus
            // 
            this.lblCustomerStatus.BackColor = System.Drawing.Color.White;
            this.lblCustomerStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerStatus.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerStatus.Location = new System.Drawing.Point(1, 1);
            this.lblCustomerStatus.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.lblCustomerStatus.Name = "lblCustomerStatus";
            this.lblCustomerStatus.Size = new System.Drawing.Size(168, 22);
            this.lblCustomerStatus.TabIndex = 293;
            this.lblCustomerStatus.Text = "STATUS";
            this.lblCustomerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label9.Location = new System.Drawing.Point(309, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 279;
            this.label9.Text = "Reservation";
            // 
            // FormReservationCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.pnCustomerStatus);
            this.Controls.Add(this.btnChangeCustomer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grvSelectedRoom);
            this.Controls.Add(this.btnMoreCustomerDetail);
            this.Controls.Add(this.btnRemoveRoom);
            this.Controls.Add(this.btnMoreRoomDetail);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPid);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
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
            this.Controls.Add(this.cbbRoomSearchType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvAvailableRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpArrivalTime);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.btnCreate);
            this.MaximizeBox = false;
            this.Name = "FormReservationCreate";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new reservation";
            this.Load += new System.EventHandler(this.FormReservationCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvAvailableRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSelectedRoom)).EndInit();
            this.pnCustomerStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.DataGridView grvAvailableRoom;
        private System.Windows.Forms.Button btnSearchRoom;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbRoomSearchType;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnRemoveRoom;
        private System.Windows.Forms.Button btnMoreRoomDetail;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnMoreCustomerDetail;
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
        private System.Windows.Forms.Button btnChangeCustomer;
        private System.Windows.Forms.Panel pnCustomerStatus;
        private System.Windows.Forms.Label lblCustomerStatus;
        private System.Windows.Forms.Label label9;
    }
}