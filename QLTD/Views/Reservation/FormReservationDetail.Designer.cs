
namespace HotelMs
{
    partial class FormReservationDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grvRoom = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_per_night = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblResId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblCheckedOut = new System.Windows.Forms.Label();
            this.lblCheckedIn = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblUpdatedAt = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.btnMoreCustomerDetail = new System.Windows.Forms.Button();
            this.grvAmenityUasge = new System.Windows.Forms.DataGridView();
            this.a_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_chargable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddAmenityUsage = new System.Windows.Forms.Button();
            this.btnUpdateAmenityUsage = new System.Windows.Forms.Button();
            this.pnReservationStatus = new System.Windows.Forms.Panel();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.btnExportInvoice = new System.Windows.Forms.Button();
            this.btnManageServiceUsage = new System.Windows.Forms.Button();
            this.pnCustomerStatus = new System.Windows.Forms.Panel();
            this.lblCustomerStatus = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblUsingDisscount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAmenityUasge)).BeginInit();
            this.pnReservationStatus.SuspendLayout();
            this.pnCustomerStatus.SuspendLayout();
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
            this.btnExit.Location = new System.Drawing.Point(1100, 601);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 32);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(854, 601);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(238, 32);
            this.btnCheckIn.TabIndex = 14;
            this.btnCheckIn.Text = "Process check in";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label10.Location = new System.Drawing.Point(481, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 103;
            this.label10.Text = "Arrival time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(28, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 107;
            this.label2.Text = "Full name";
            // 
            // grvRoom
            // 
            this.grvRoom.AllowUserToAddRows = false;
            this.grvRoom.AllowUserToDeleteRows = false;
            this.grvRoom.AllowUserToResizeColumns = false;
            this.grvRoom.AllowUserToResizeRows = false;
            this.grvRoom.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.room_code,
            this.floor_number,
            this.room_type_title,
            this.price_per_night,
            this.room_type_id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvRoom.GridColor = System.Drawing.Color.Gainsboro;
            this.grvRoom.Location = new System.Drawing.Point(316, 163);
            this.grvRoom.Margin = new System.Windows.Forms.Padding(0, 24, 4, 24);
            this.grvRoom.Name = "grvRoom";
            this.grvRoom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvRoom.RowHeadersWidth = 45;
            this.grvRoom.RowTemplate.Height = 30;
            this.grvRoom.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvRoom.Size = new System.Drawing.Size(513, 375);
            this.grvRoom.TabIndex = 121;
            this.grvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvRoom_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "Room ID";
            this.ID.Name = "ID";
            this.ID.Width = 93;
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
            this.room_type_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            this.label5.Location = new System.Drawing.Point(648, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 166;
            this.label5.Text = "Departure time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(28, 160);
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
            this.label8.Location = new System.Drawing.Point(28, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 172;
            this.label8.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label14.Location = new System.Drawing.Point(28, 61);
            this.label14.Margin = new System.Windows.Forms.Padding(4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 16);
            this.label14.TabIndex = 187;
            this.label14.Text = "Customer ID";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerName.Location = new System.Drawing.Point(31, 130);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(260, 22);
            this.lblCustomerName.TabIndex = 259;
            this.lblCustomerName.Text = "ex";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerPhone.Location = new System.Drawing.Point(31, 180);
            this.lblCustomerPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(260, 22);
            this.lblCustomerPhone.TabIndex = 261;
            this.lblCustomerPhone.Text = "ex";
            this.lblCustomerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerEmail.Location = new System.Drawing.Point(31, 230);
            this.lblCustomerEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(260, 22);
            this.lblCustomerEmail.TabIndex = 262;
            this.lblCustomerEmail.Text = "ex";
            this.lblCustomerEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerId.Location = new System.Drawing.Point(31, 81);
            this.lblCustomerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(260, 22);
            this.lblCustomerId.TabIndex = 264;
            this.lblCustomerId.Text = "ex";
            this.lblCustomerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResId
            // 
            this.lblResId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblResId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblResId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblResId.Location = new System.Drawing.Point(316, 83);
            this.lblResId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblResId.Name = "lblResId";
            this.lblResId.Size = new System.Drawing.Size(160, 22);
            this.lblResId.TabIndex = 266;
            this.lblResId.Text = "ex";
            this.lblResId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(313, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 265;
            this.label3.Text = "Reservation ID";
            // 
            // lblArrival
            // 
            this.lblArrival.BackColor = System.Drawing.Color.Gainsboro;
            this.lblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblArrival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblArrival.Location = new System.Drawing.Point(484, 83);
            this.lblArrival.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(160, 22);
            this.lblArrival.TabIndex = 267;
            this.lblArrival.Text = "ex";
            this.lblArrival.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDeparture
            // 
            this.lblDeparture.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeparture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDeparture.Location = new System.Drawing.Point(652, 83);
            this.lblDeparture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(160, 22);
            this.lblDeparture.TabIndex = 268;
            this.lblDeparture.Text = "ex";
            this.lblDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCheckedOut
            // 
            this.lblCheckedOut.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCheckedOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCheckedOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCheckedOut.Location = new System.Drawing.Point(988, 83);
            this.lblCheckedOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCheckedOut.Name = "lblCheckedOut";
            this.lblCheckedOut.Size = new System.Drawing.Size(160, 22);
            this.lblCheckedOut.TabIndex = 272;
            this.lblCheckedOut.Text = "ex";
            this.lblCheckedOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCheckedIn
            // 
            this.lblCheckedIn.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCheckedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCheckedIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCheckedIn.Location = new System.Drawing.Point(820, 83);
            this.lblCheckedIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCheckedIn.Name = "lblCheckedIn";
            this.lblCheckedIn.Size = new System.Drawing.Size(160, 22);
            this.lblCheckedIn.TabIndex = 271;
            this.lblCheckedIn.Text = "ex";
            this.lblCheckedIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label15.Location = new System.Drawing.Point(984, 63);
            this.label15.Margin = new System.Windows.Forms.Padding(4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 16);
            this.label15.TabIndex = 270;
            this.label15.Text = "Checked out at";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label16.Location = new System.Drawing.Point(817, 63);
            this.label16.Margin = new System.Windows.Forms.Padding(4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 269;
            this.label16.Text = "Checked in at";
            // 
            // lblUpdatedAt
            // 
            this.lblUpdatedAt.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUpdatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUpdatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblUpdatedAt.Location = new System.Drawing.Point(31, 451);
            this.lblUpdatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblUpdatedAt.Name = "lblUpdatedAt";
            this.lblUpdatedAt.Size = new System.Drawing.Size(260, 22);
            this.lblUpdatedAt.TabIndex = 278;
            this.lblUpdatedAt.Text = "ex";
            this.lblUpdatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label20.Location = new System.Drawing.Point(31, 431);
            this.label20.Margin = new System.Windows.Forms.Padding(4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 16);
            this.label20.TabIndex = 277;
            this.label20.Text = "Updated at";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCreatedAt.Location = new System.Drawing.Point(31, 402);
            this.lblCreatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(260, 22);
            this.lblCreatedAt.TabIndex = 276;
            this.lblCreatedAt.Text = "ex";
            this.lblCreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label22.Location = new System.Drawing.Point(28, 382);
            this.label22.Margin = new System.Windows.Forms.Padding(4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 16);
            this.label22.TabIndex = 275;
            this.label22.Text = "Created at";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(27, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 280;
            this.label1.Text = "Created by";
            // 
            // lblStaffName
            // 
            this.lblStaffName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStaffName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblStaffName.Location = new System.Drawing.Point(31, 352);
            this.lblStaffName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(260, 22);
            this.lblStaffName.TabIndex = 283;
            this.lblStaffName.Text = "ex";
            this.lblStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMoreCustomerDetail
            // 
            this.btnMoreCustomerDetail.BackColor = System.Drawing.Color.Silver;
            this.btnMoreCustomerDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoreCustomerDetail.FlatAppearance.BorderSize = 0;
            this.btnMoreCustomerDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreCustomerDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMoreCustomerDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMoreCustomerDetail.Location = new System.Drawing.Point(31, 270);
            this.btnMoreCustomerDetail.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnMoreCustomerDetail.Name = "btnMoreCustomerDetail";
            this.btnMoreCustomerDetail.Size = new System.Drawing.Size(260, 26);
            this.btnMoreCustomerDetail.TabIndex = 285;
            this.btnMoreCustomerDetail.Text = "More detail";
            this.btnMoreCustomerDetail.UseVisualStyleBackColor = false;
            this.btnMoreCustomerDetail.Click += new System.EventHandler(this.btnMoreCustomerDetail_Click);
            // 
            // grvAmenityUasge
            // 
            this.grvAmenityUasge.AllowUserToAddRows = false;
            this.grvAmenityUasge.AllowUserToDeleteRows = false;
            this.grvAmenityUasge.AllowUserToResizeColumns = false;
            this.grvAmenityUasge.AllowUserToResizeRows = false;
            this.grvAmenityUasge.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvAmenityUasge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvAmenityUasge.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvAmenityUasge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvAmenityUasge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvAmenityUasge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a_id,
            this.title,
            this.price,
            this.is_chargable,
            this.status});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvAmenityUasge.DefaultCellStyle = dataGridViewCellStyle5;
            this.grvAmenityUasge.GridColor = System.Drawing.Color.Gainsboro;
            this.grvAmenityUasge.Location = new System.Drawing.Point(854, 163);
            this.grvAmenityUasge.Margin = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.grvAmenityUasge.Name = "grvAmenityUasge";
            this.grvAmenityUasge.ReadOnly = true;
            this.grvAmenityUasge.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvAmenityUasge.RowHeadersWidth = 45;
            this.grvAmenityUasge.RowTemplate.Height = 30;
            this.grvAmenityUasge.RowTemplate.ReadOnly = true;
            this.grvAmenityUasge.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvAmenityUasge.Size = new System.Drawing.Size(506, 375);
            this.grvAmenityUasge.TabIndex = 288;
            this.grvAmenityUasge.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grvAmenityUasge_CellPainting);
            // 
            // a_id
            // 
            this.a_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.a_id.DataPropertyName = "id";
            this.a_id.HeaderText = "ID";
            this.a_id.Name = "a_id";
            this.a_id.ReadOnly = true;
            this.a_id.Width = 53;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 66;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 71;
            // 
            // is_chargable
            // 
            this.is_chargable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.is_chargable.DataPropertyName = "is_chargable";
            this.is_chargable.HeaderText = "Chargable";
            this.is_chargable.Name = "is_chargable";
            this.is_chargable.ReadOnly = true;
            this.is_chargable.Width = 103;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8);
            this.status.DefaultCellStyle = dataGridViewCellStyle4;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(312, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 289;
            this.label4.Text = "Rooms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label6.Location = new System.Drawing.Point(850, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 290;
            this.label6.Text = "Amenity usages";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.BackColor = System.Drawing.Color.White;
            this.lblTotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTotalBalance.Location = new System.Drawing.Point(28, 561);
            this.lblTotalBalance.Margin = new System.Windows.Forms.Padding(4);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Padding = new System.Windows.Forms.Padding(4);
            this.lblTotalBalance.Size = new System.Drawing.Size(263, 32);
            this.lblTotalBalance.TabIndex = 291;
            this.lblTotalBalance.Text = "Total Balance: 6.750.000 vnd";
            this.lblTotalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label9.Location = new System.Drawing.Point(493, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 175;
            this.label9.Text = "Reservation";
            // 
            // btnAddAmenityUsage
            // 
            this.btnAddAmenityUsage.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddAmenityUsage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAmenityUsage.FlatAppearance.BorderSize = 0;
            this.btnAddAmenityUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAmenityUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddAmenityUsage.ForeColor = System.Drawing.Color.White;
            this.btnAddAmenityUsage.Location = new System.Drawing.Point(1082, 550);
            this.btnAddAmenityUsage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAmenityUsage.Name = "btnAddAmenityUsage";
            this.btnAddAmenityUsage.Size = new System.Drawing.Size(220, 26);
            this.btnAddAmenityUsage.TabIndex = 294;
            this.btnAddAmenityUsage.Text = "Add usage";
            this.btnAddAmenityUsage.UseVisualStyleBackColor = false;
            this.btnAddAmenityUsage.Click += new System.EventHandler(this.btnAddAmenityUsage_Click);
            // 
            // btnUpdateAmenityUsage
            // 
            this.btnUpdateAmenityUsage.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateAmenityUsage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAmenityUsage.FlatAppearance.BorderSize = 0;
            this.btnUpdateAmenityUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAmenityUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnUpdateAmenityUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnUpdateAmenityUsage.Location = new System.Drawing.Point(854, 550);
            this.btnUpdateAmenityUsage.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateAmenityUsage.Name = "btnUpdateAmenityUsage";
            this.btnUpdateAmenityUsage.Size = new System.Drawing.Size(220, 26);
            this.btnUpdateAmenityUsage.TabIndex = 295;
            this.btnUpdateAmenityUsage.Text = "Update usage";
            this.btnUpdateAmenityUsage.UseVisualStyleBackColor = false;
            this.btnUpdateAmenityUsage.Click += new System.EventHandler(this.btnUpdateAmenityUsage_Click);
            // 
            // pnReservationStatus
            // 
            this.pnReservationStatus.Controls.Add(this.lblReservationStatus);
            this.pnReservationStatus.Location = new System.Drawing.Point(316, 24);
            this.pnReservationStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnReservationStatus.Name = "pnReservationStatus";
            this.pnReservationStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnReservationStatus.Size = new System.Drawing.Size(170, 24);
            this.pnReservationStatus.TabIndex = 297;
            // 
            // lblReservationStatus
            // 
            this.lblReservationStatus.BackColor = System.Drawing.Color.White;
            this.lblReservationStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReservationStatus.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblReservationStatus.Location = new System.Drawing.Point(1, 1);
            this.lblReservationStatus.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.lblReservationStatus.Name = "lblReservationStatus";
            this.lblReservationStatus.Size = new System.Drawing.Size(168, 22);
            this.lblReservationStatus.TabIndex = 293;
            this.lblReservationStatus.Text = "STATUS";
            this.lblReservationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(608, 601);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(238, 32);
            this.btnCheckOut.TabIndex = 298;
            this.btnCheckOut.Text = "Process check out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelReservation.FlatAppearance.BorderSize = 0;
            this.btnCancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancelReservation.ForeColor = System.Drawing.Color.White;
            this.btnCancelReservation.Location = new System.Drawing.Point(608, 601);
            this.btnCancelReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(238, 32);
            this.btnCancelReservation.TabIndex = 299;
            this.btnCancelReservation.Text = "Cancel reservation";
            this.btnCancelReservation.UseVisualStyleBackColor = false;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // btnExportInvoice
            // 
            this.btnExportInvoice.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExportInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportInvoice.FlatAppearance.BorderSize = 0;
            this.btnExportInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExportInvoice.ForeColor = System.Drawing.Color.White;
            this.btnExportInvoice.Location = new System.Drawing.Point(608, 601);
            this.btnExportInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportInvoice.Name = "btnExportInvoice";
            this.btnExportInvoice.Size = new System.Drawing.Size(238, 32);
            this.btnExportInvoice.TabIndex = 300;
            this.btnExportInvoice.Text = "Export invoice";
            this.btnExportInvoice.UseVisualStyleBackColor = false;
            this.btnExportInvoice.Click += new System.EventHandler(this.btnExportInvoice_Click);
            // 
            // btnManageServiceUsage
            // 
            this.btnManageServiceUsage.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManageServiceUsage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageServiceUsage.FlatAppearance.BorderSize = 0;
            this.btnManageServiceUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageServiceUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnManageServiceUsage.ForeColor = System.Drawing.Color.White;
            this.btnManageServiceUsage.Location = new System.Drawing.Point(854, 601);
            this.btnManageServiceUsage.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageServiceUsage.Name = "btnManageServiceUsage";
            this.btnManageServiceUsage.Size = new System.Drawing.Size(238, 32);
            this.btnManageServiceUsage.TabIndex = 302;
            this.btnManageServiceUsage.Text = "Manage service usages";
            this.btnManageServiceUsage.UseVisualStyleBackColor = false;
            this.btnManageServiceUsage.Click += new System.EventHandler(this.btnManageServiceUsage_Click);
            // 
            // pnCustomerStatus
            // 
            this.pnCustomerStatus.Controls.Add(this.lblCustomerStatus);
            this.pnCustomerStatus.Location = new System.Drawing.Point(31, 24);
            this.pnCustomerStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnCustomerStatus.Name = "pnCustomerStatus";
            this.pnCustomerStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnCustomerStatus.Size = new System.Drawing.Size(170, 24);
            this.pnCustomerStatus.TabIndex = 304;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label13.Location = new System.Drawing.Point(208, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 19);
            this.label13.TabIndex = 303;
            this.label13.Text = "Customer";
            // 
            // lblUsingDisscount
            // 
            this.lblUsingDisscount.BackColor = System.Drawing.Color.White;
            this.lblUsingDisscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsingDisscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblUsingDisscount.Location = new System.Drawing.Point(28, 601);
            this.lblUsingDisscount.Margin = new System.Windows.Forms.Padding(4);
            this.lblUsingDisscount.Name = "lblUsingDisscount";
            this.lblUsingDisscount.Padding = new System.Windows.Forms.Padding(4);
            this.lblUsingDisscount.Size = new System.Drawing.Size(427, 32);
            this.lblUsingDisscount.TabIndex = 305;
            this.lblUsingDisscount.Text = "Using discount: None";
            this.lblUsingDisscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormReservationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.lblUsingDisscount);
            this.Controls.Add(this.pnCustomerStatus);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnManageServiceUsage);
            this.Controls.Add(this.btnExportInvoice);
            this.Controls.Add(this.btnCancelReservation);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.pnReservationStatus);
            this.Controls.Add(this.btnUpdateAmenityUsage);
            this.Controls.Add(this.btnAddAmenityUsage);
            this.Controls.Add(this.lblTotalBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grvAmenityUasge);
            this.Controls.Add(this.btnMoreCustomerDetail);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUpdatedAt);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblCheckedOut);
            this.Controls.Add(this.lblCheckedIn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblArrival);
            this.Controls.Add(this.lblResId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grvRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckIn);
            this.MaximizeBox = false;
            this.Name = "FormReservationDetail";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation detail";
            this.Load += new System.EventHandler(this.FormReservationCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAmenityUasge)).EndInit();
            this.pnReservationStatus.ResumeLayout(false);
            this.pnCustomerStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grvRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblResId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblCheckedOut;
        private System.Windows.Forms.Label lblCheckedIn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblUpdatedAt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Button btnMoreCustomerDetail;
        private System.Windows.Forms.DataGridView grvAmenityUasge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_type_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_per_night;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_type_id;
        private System.Windows.Forms.Button btnAddAmenityUsage;
        private System.Windows.Forms.Button btnUpdateAmenityUsage;
        private System.Windows.Forms.Panel pnReservationStatus;
        private System.Windows.Forms.Label lblReservationStatus;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Button btnExportInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_chargable;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button btnManageServiceUsage;
        private System.Windows.Forms.Panel pnCustomerStatus;
        private System.Windows.Forms.Label lblCustomerStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblUsingDisscount;
    }
}