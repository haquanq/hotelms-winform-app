namespace HotelMs
{
    partial class FormRoomDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grvReservation = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrival_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checked_in_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checked_out_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMoreDetail = new System.Windows.Forms.Button();
            this.cbbStatusFilter = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbSearchType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblFloorNumber = new System.Windows.Forms.Label();
            this.lblRoomCode = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUpdatedAt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRoomStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAmenity = new System.Windows.Forms.Label();
            this.pnRoomStatus = new System.Windows.Forms.Panel();
            this.btnMakeClean = new System.Windows.Forms.Button();
            this.btnMakeReady = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvReservation)).BeginInit();
            this.panel6.SuspendLayout();
            this.pnRoomStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvReservation
            // 
            this.grvReservation.AllowUserToAddRows = false;
            this.grvReservation.AllowUserToDeleteRows = false;
            this.grvReservation.AllowUserToResizeColumns = false;
            this.grvReservation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvReservation.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvReservation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.customer_name,
            this.arrival_time,
            this.departure_time,
            this.checked_in_at,
            this.checked_out_at,
            this.created_at,
            this.updated_at,
            this.total_price,
            this.status});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvReservation.DefaultCellStyle = dataGridViewCellStyle4;
            this.grvReservation.GridColor = System.Drawing.Color.Gainsboro;
            this.grvReservation.Location = new System.Drawing.Point(325, 129);
            this.grvReservation.Margin = new System.Windows.Forms.Padding(0, 24, 0, 8);
            this.grvReservation.Name = "grvReservation";
            this.grvReservation.ReadOnly = true;
            this.grvReservation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvReservation.RowHeadersWidth = 45;
            this.grvReservation.RowTemplate.Height = 30;
            this.grvReservation.RowTemplate.ReadOnly = true;
            this.grvReservation.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvReservation.Size = new System.Drawing.Size(1031, 408);
            this.grvReservation.TabIndex = 2;
            this.grvReservation.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grvReservation_CellPainting);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 53;
            // 
            // customer_name
            // 
            this.customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customer_name.DataPropertyName = "customer_name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.customer_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.customer_name.HeaderText = "Customer Name";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            this.customer_name.Width = 137;
            // 
            // arrival_time
            // 
            this.arrival_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.arrival_time.DataPropertyName = "arrival_time";
            this.arrival_time.HeaderText = "Arrival Time";
            this.arrival_time.Name = "arrival_time";
            this.arrival_time.ReadOnly = true;
            this.arrival_time.Width = 112;
            // 
            // departure_time
            // 
            this.departure_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.departure_time.DataPropertyName = "departure_time";
            this.departure_time.HeaderText = "Departure Time";
            this.departure_time.Name = "departure_time";
            this.departure_time.ReadOnly = true;
            this.departure_time.Width = 134;
            // 
            // checked_in_at
            // 
            this.checked_in_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checked_in_at.DataPropertyName = "checked_in_at";
            this.checked_in_at.HeaderText = "Checked In At";
            this.checked_in_at.Name = "checked_in_at";
            this.checked_in_at.ReadOnly = true;
            this.checked_in_at.Width = 122;
            // 
            // checked_out_at
            // 
            this.checked_out_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checked_out_at.DataPropertyName = "checked_out_at";
            this.checked_out_at.HeaderText = "Checked Out At";
            this.checked_out_at.Name = "checked_out_at";
            this.checked_out_at.ReadOnly = true;
            this.checked_out_at.Width = 132;
            // 
            // created_at
            // 
            this.created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "Created At";
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            this.created_at.Visible = false;
            // 
            // updated_at
            // 
            this.updated_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.updated_at.DataPropertyName = "updated_at";
            this.updated_at.HeaderText = "Updated At";
            this.updated_at.Name = "updated_at";
            this.updated_at.ReadOnly = true;
            this.updated_at.Visible = false;
            // 
            // total_price
            // 
            this.total_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.total_price.DataPropertyName = "total_price";
            this.total_price.HeaderText = "Balance";
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            this.total_price.Width = 90;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8);
            this.status.DefaultCellStyle = dataGridViewCellStyle3;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 77;
            // 
            // btnMoreDetail
            // 
            this.btnMoreDetail.BackColor = System.Drawing.Color.Silver;
            this.btnMoreDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoreDetail.FlatAppearance.BorderSize = 0;
            this.btnMoreDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMoreDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMoreDetail.Location = new System.Drawing.Point(1156, 549);
            this.btnMoreDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoreDetail.Name = "btnMoreDetail";
            this.btnMoreDetail.Size = new System.Drawing.Size(200, 26);
            this.btnMoreDetail.TabIndex = 37;
            this.btnMoreDetail.Text = "Mode detail";
            this.btnMoreDetail.UseVisualStyleBackColor = false;
            this.btnMoreDetail.Click += new System.EventHandler(this.btnMoreDetail_Click);
            // 
            // cbbStatusFilter
            // 
            this.cbbStatusFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbStatusFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbStatusFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbStatusFilter.FormattingEnabled = true;
            this.cbbStatusFilter.Items.AddRange(new object[] {
            "Book genre",
            "Book author"});
            this.cbbStatusFilter.Location = new System.Drawing.Point(325, 81);
            this.cbbStatusFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbbStatusFilter.Name = "cbbStatusFilter";
            this.cbbStatusFilter.Size = new System.Drawing.Size(167, 24);
            this.cbbStatusFilter.TabIndex = 117;
            this.cbbStatusFilter.SelectionChangeCommitted += new System.EventHandler(this.cbbStatusFilter_SelectionChangeCommitted);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblRowCount);
            this.panel6.Location = new System.Drawing.Point(325, 549);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(275, 26);
            this.panel6.TabIndex = 119;
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRowCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRowCount.Location = new System.Drawing.Point(5, 5);
            this.lblRowCount.Margin = new System.Windows.Forms.Padding(4);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(37, 15);
            this.lblRowCount.TabIndex = 48;
            this.lblRowCount.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(322, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 120;
            this.label4.Text = "Status filter";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1262, 82);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 24);
            this.btnSearch.TabIndex = 128;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Location = new System.Drawing.Point(957, 83);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(305, 22);
            this.txtSearch.TabIndex = 126;
            // 
            // cbbSearchType
            // 
            this.cbbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSearchType.FormattingEnabled = true;
            this.cbbSearchType.Location = new System.Drawing.Point(804, 82);
            this.cbbSearchType.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSearchType.Name = "cbbSearchType";
            this.cbbSearchType.Size = new System.Drawing.Size(153, 24);
            this.cbbSearchType.TabIndex = 127;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label14.Location = new System.Drawing.Point(801, 63);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 125;
            this.label14.Text = "Search by";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblPrice.Location = new System.Drawing.Point(24, 232);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new System.Windows.Forms.Padding(2);
            this.lblPrice.Size = new System.Drawing.Size(269, 22);
            this.lblPrice.TabIndex = 273;
            this.lblPrice.Text = "ex";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoomType
            // 
            this.lblRoomType.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRoomType.Location = new System.Drawing.Point(25, 182);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Padding = new System.Windows.Forms.Padding(2);
            this.lblRoomType.Size = new System.Drawing.Size(268, 22);
            this.lblRoomType.TabIndex = 272;
            this.lblRoomType.Text = "ex";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFloorNumber
            // 
            this.lblFloorNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.lblFloorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFloorNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblFloorNumber.Location = new System.Drawing.Point(163, 131);
            this.lblFloorNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblFloorNumber.Name = "lblFloorNumber";
            this.lblFloorNumber.Padding = new System.Windows.Forms.Padding(2);
            this.lblFloorNumber.Size = new System.Drawing.Size(130, 22);
            this.lblFloorNumber.TabIndex = 271;
            this.lblFloorNumber.Text = "ex";
            this.lblFloorNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoomCode
            // 
            this.lblRoomCode.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRoomCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRoomCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRoomCode.Location = new System.Drawing.Point(25, 132);
            this.lblRoomCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblRoomCode.Name = "lblRoomCode";
            this.lblRoomCode.Padding = new System.Windows.Forms.Padding(2);
            this.lblRoomCode.Size = new System.Drawing.Size(130, 22);
            this.lblRoomCode.TabIndex = 270;
            this.lblRoomCode.Text = "ex";
            this.lblRoomCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label11.Location = new System.Drawing.Point(21, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 268;
            this.label11.Text = "Room Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(20, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 266;
            this.label7.Text = "Price (Nightly)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label6.Location = new System.Drawing.Point(21, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 265;
            this.label6.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(159, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 264;
            this.label2.Text = "Floor Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label13.Location = new System.Drawing.Point(201, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 19);
            this.label13.TabIndex = 276;
            this.label13.Text = "Room";
            // 
            // lblRoomId
            // 
            this.lblRoomId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRoomId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRoomId.Location = new System.Drawing.Point(25, 82);
            this.lblRoomId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Padding = new System.Windows.Forms.Padding(2);
            this.lblRoomId.Size = new System.Drawing.Size(268, 22);
            this.lblRoomId.TabIndex = 278;
            this.lblRoomId.Text = "ex";
            this.lblRoomId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 277;
            this.label3.Text = "Room ID";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExit.Location = new System.Drawing.Point(1096, 601);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 32);
            this.btnExit.TabIndex = 280;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label9.Location = new System.Drawing.Point(321, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 19);
            this.label9.TabIndex = 281;
            this.label9.Text = "Reservation history";
            // 
            // lblUpdatedAt
            // 
            this.lblUpdatedAt.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUpdatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUpdatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblUpdatedAt.Location = new System.Drawing.Point(24, 332);
            this.lblUpdatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblUpdatedAt.Name = "lblUpdatedAt";
            this.lblUpdatedAt.Padding = new System.Windows.Forms.Padding(2);
            this.lblUpdatedAt.Size = new System.Drawing.Size(269, 22);
            this.lblUpdatedAt.TabIndex = 285;
            this.lblUpdatedAt.Text = "ex";
            this.lblUpdatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(21, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 284;
            this.label1.Text = "Updated at";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCreatedAt.Location = new System.Drawing.Point(23, 282);
            this.lblCreatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Padding = new System.Windows.Forms.Padding(2);
            this.lblCreatedAt.Size = new System.Drawing.Size(270, 22);
            this.lblCreatedAt.TabIndex = 283;
            this.lblCreatedAt.Text = "ex";
            this.lblCreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(21, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 282;
            this.label5.Text = "Created at";
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.BackColor = System.Drawing.Color.White;
            this.lblRoomStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRoomStatus.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRoomStatus.Location = new System.Drawing.Point(1, 1);
            this.lblRoomStatus.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(168, 22);
            this.lblRoomStatus.TabIndex = 293;
            this.lblRoomStatus.Text = "STATUS";
            this.lblRoomStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label8.Location = new System.Drawing.Point(19, 378);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 294;
            this.label8.Text = "Amenities";
            // 
            // lblAmenity
            // 
            this.lblAmenity.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAmenity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAmenity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblAmenity.Location = new System.Drawing.Point(23, 413);
            this.lblAmenity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblAmenity.Name = "lblAmenity";
            this.lblAmenity.Padding = new System.Windows.Forms.Padding(2);
            this.lblAmenity.Size = new System.Drawing.Size(269, 162);
            this.lblAmenity.TabIndex = 295;
            this.lblAmenity.Text = "ex";
            // 
            // pnRoomStatus
            // 
            this.pnRoomStatus.Controls.Add(this.lblRoomStatus);
            this.pnRoomStatus.Location = new System.Drawing.Point(24, 24);
            this.pnRoomStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnRoomStatus.Name = "pnRoomStatus";
            this.pnRoomStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnRoomStatus.Size = new System.Drawing.Size(170, 24);
            this.pnRoomStatus.TabIndex = 296;
            // 
            // btnMakeClean
            // 
            this.btnMakeClean.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMakeClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeClean.FlatAppearance.BorderSize = 0;
            this.btnMakeClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMakeClean.ForeColor = System.Drawing.Color.White;
            this.btnMakeClean.Location = new System.Drawing.Point(819, 601);
            this.btnMakeClean.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeClean.Name = "btnMakeClean";
            this.btnMakeClean.Size = new System.Drawing.Size(269, 32);
            this.btnMakeClean.TabIndex = 297;
            this.btnMakeClean.Text = "Make clean";
            this.btnMakeClean.UseVisualStyleBackColor = false;
            this.btnMakeClean.Click += new System.EventHandler(this.btnMakeClean_Click);
            // 
            // btnMakeReady
            // 
            this.btnMakeReady.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMakeReady.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeReady.FlatAppearance.BorderSize = 0;
            this.btnMakeReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMakeReady.ForeColor = System.Drawing.Color.White;
            this.btnMakeReady.Location = new System.Drawing.Point(819, 601);
            this.btnMakeReady.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeReady.Name = "btnMakeReady";
            this.btnMakeReady.Size = new System.Drawing.Size(269, 32);
            this.btnMakeReady.TabIndex = 298;
            this.btnMakeReady.Text = "Make ready";
            this.btnMakeReady.UseVisualStyleBackColor = false;
            this.btnMakeReady.Click += new System.EventHandler(this.btnMakeReady_Click);
            // 
            // FormRoomDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.btnMakeReady);
            this.Controls.Add(this.btnMakeClean);
            this.Controls.Add(this.pnRoomStatus);
            this.Controls.Add(this.lblAmenity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblUpdatedAt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblRoomId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblFloorNumber);
            this.Controls.Add(this.lblRoomCode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbbSearchType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.cbbStatusFilter);
            this.Controls.Add(this.btnMoreDetail);
            this.Controls.Add(this.grvReservation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1400, 700);
            this.Name = "FormRoomDetail";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room detail";
            this.Load += new System.EventHandler(this.FormRoomDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvReservation)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnRoomStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grvReservation;
        private System.Windows.Forms.Button btnMoreDetail;
        private System.Windows.Forms.ComboBox cbbStatusFilter;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbSearchType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblFloorNumber;
        private System.Windows.Forms.Label lblRoomCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUpdatedAt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRoomStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAmenity;
        private System.Windows.Forms.Panel pnRoomStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrival_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn checked_in_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn checked_out_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button btnMakeClean;
        private System.Windows.Forms.Button btnMakeReady;
    }
}