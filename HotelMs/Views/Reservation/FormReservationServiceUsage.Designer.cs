
namespace HotelMs
{
    partial class FormReservationServiceUsage
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
            this.btnHotelServiceUsageCreate = new System.Windows.Forms.Button();
            this.grvHotelServiceUsage = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.started_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ended_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHotelServiceUsageUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbSearchType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbStatusFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnCustomerStatus = new System.Windows.Forms.Panel();
            this.lblCustomerStatus = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReservationId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.lblCheckedOut = new System.Windows.Forms.Label();
            this.lblCheckedIn = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pnReservationStatus = new System.Windows.Forms.Panel();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvHotelServiceUsage)).BeginInit();
            this.pnCustomerStatus.SuspendLayout();
            this.pnReservationStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHotelServiceUsageCreate
            // 
            this.btnHotelServiceUsageCreate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHotelServiceUsageCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelServiceUsageCreate.FlatAppearance.BorderSize = 0;
            this.btnHotelServiceUsageCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotelServiceUsageCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnHotelServiceUsageCreate.ForeColor = System.Drawing.Color.White;
            this.btnHotelServiceUsageCreate.Location = new System.Drawing.Point(976, 554);
            this.btnHotelServiceUsageCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnHotelServiceUsageCreate.Name = "btnHotelServiceUsageCreate";
            this.btnHotelServiceUsageCreate.Size = new System.Drawing.Size(180, 26);
            this.btnHotelServiceUsageCreate.TabIndex = 14;
            this.btnHotelServiceUsageCreate.Text = "Create service usage";
            this.btnHotelServiceUsageCreate.UseVisualStyleBackColor = false;
            this.btnHotelServiceUsageCreate.Click += new System.EventHandler(this.btnCreateHotelServiceUsage_Click);
            // 
            // grvHotelServiceUsage
            // 
            this.grvHotelServiceUsage.AllowUserToAddRows = false;
            this.grvHotelServiceUsage.AllowUserToDeleteRows = false;
            this.grvHotelServiceUsage.AllowUserToResizeColumns = false;
            this.grvHotelServiceUsage.AllowUserToResizeRows = false;
            this.grvHotelServiceUsage.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvHotelServiceUsage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvHotelServiceUsage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvHotelServiceUsage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvHotelServiceUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvHotelServiceUsage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.service_title,
            this.started_at,
            this.ended_at,
            this.created_at,
            this.updated_at,
            this.price,
            this.status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvHotelServiceUsage.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvHotelServiceUsage.GridColor = System.Drawing.Color.Gainsboro;
            this.grvHotelServiceUsage.Location = new System.Drawing.Point(308, 228);
            this.grvHotelServiceUsage.Margin = new System.Windows.Forms.Padding(0, 24, 0, 8);
            this.grvHotelServiceUsage.Name = "grvHotelServiceUsage";
            this.grvHotelServiceUsage.ReadOnly = true;
            this.grvHotelServiceUsage.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvHotelServiceUsage.RowHeadersWidth = 45;
            this.grvHotelServiceUsage.RowTemplate.Height = 30;
            this.grvHotelServiceUsage.RowTemplate.ReadOnly = true;
            this.grvHotelServiceUsage.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvHotelServiceUsage.Size = new System.Drawing.Size(848, 314);
            this.grvHotelServiceUsage.TabIndex = 114;
            this.grvHotelServiceUsage.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grvHotelServiceUsage_CellPainting);
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
            // service_title
            // 
            this.service_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.service_title.DataPropertyName = "service_title";
            this.service_title.HeaderText = "Service Title";
            this.service_title.Name = "service_title";
            this.service_title.ReadOnly = true;
            this.service_title.Width = 115;
            // 
            // started_at
            // 
            this.started_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.started_at.DataPropertyName = "started_at";
            this.started_at.HeaderText = "Started At";
            this.started_at.Name = "started_at";
            this.started_at.ReadOnly = true;
            this.started_at.Width = 98;
            // 
            // ended_at
            // 
            this.ended_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ended_at.DataPropertyName = "ended_at";
            this.ended_at.HeaderText = "Ended At";
            this.ended_at.Name = "ended_at";
            this.ended_at.ReadOnly = true;
            this.ended_at.Width = 95;
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
            this.updated_at.Width = 108;
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
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 77;
            // 
            // btnHotelServiceUsageUpdate
            // 
            this.btnHotelServiceUsageUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnHotelServiceUsageUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelServiceUsageUpdate.FlatAppearance.BorderSize = 0;
            this.btnHotelServiceUsageUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotelServiceUsageUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnHotelServiceUsageUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnHotelServiceUsageUpdate.Location = new System.Drawing.Point(788, 554);
            this.btnHotelServiceUsageUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnHotelServiceUsageUpdate.Name = "btnHotelServiceUsageUpdate";
            this.btnHotelServiceUsageUpdate.Size = new System.Drawing.Size(180, 26);
            this.btnHotelServiceUsageUpdate.TabIndex = 127;
            this.btnHotelServiceUsageUpdate.Text = "Update";
            this.btnHotelServiceUsageUpdate.UseVisualStyleBackColor = false;
            this.btnHotelServiceUsageUpdate.Click += new System.EventHandler(this.btnUpdateHotelServiceUsage_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1062, 183);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 24);
            this.btnSearch.TabIndex = 143;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Location = new System.Drawing.Point(796, 184);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(266, 22);
            this.txtSearch.TabIndex = 141;
            // 
            // cbbSearchType
            // 
            this.cbbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSearchType.FormattingEnabled = true;
            this.cbbSearchType.Location = new System.Drawing.Point(643, 183);
            this.cbbSearchType.Name = "cbbSearchType";
            this.cbbSearchType.Size = new System.Drawing.Size(153, 24);
            this.cbbSearchType.TabIndex = 142;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label14.Location = new System.Drawing.Point(640, 164);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 140;
            this.label14.Text = "Search by";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(305, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 147;
            this.label4.Text = "Status filter";
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
            this.cbbStatusFilter.Location = new System.Drawing.Point(308, 184);
            this.cbbStatusFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbbStatusFilter.Name = "cbbStatusFilter";
            this.cbbStatusFilter.Size = new System.Drawing.Size(167, 24);
            this.cbbStatusFilter.TabIndex = 146;
            this.cbbStatusFilter.SelectionChangeCommitted += new System.EventHandler(this.cbbStatusFilter_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(304, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 19);
            this.label5.TabIndex = 314;
            this.label5.Text = "Hotel service usages";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExit.Location = new System.Drawing.Point(896, 601);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 32);
            this.btnExit.TabIndex = 315;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnCustomerStatus
            // 
            this.pnCustomerStatus.Controls.Add(this.lblCustomerStatus);
            this.pnCustomerStatus.Location = new System.Drawing.Point(24, 128);
            this.pnCustomerStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnCustomerStatus.Name = "pnCustomerStatus";
            this.pnCustomerStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnCustomerStatus.Size = new System.Drawing.Size(170, 24);
            this.pnCustomerStatus.TabIndex = 325;
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
            this.label13.Location = new System.Drawing.Point(201, 131);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 19);
            this.label13.TabIndex = 324;
            this.label13.Text = "Customer";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerId.Location = new System.Drawing.Point(24, 185);
            this.lblCustomerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(260, 22);
            this.lblCustomerId.TabIndex = 323;
            this.lblCustomerId.Text = "ex";
            this.lblCustomerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerEmail.Location = new System.Drawing.Point(24, 334);
            this.lblCustomerEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(260, 22);
            this.lblCustomerEmail.TabIndex = 322;
            this.lblCustomerEmail.Text = "ex";
            this.lblCustomerEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerPhone.Location = new System.Drawing.Point(24, 284);
            this.lblCustomerPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(260, 22);
            this.lblCustomerPhone.TabIndex = 321;
            this.lblCustomerPhone.Text = "ex";
            this.lblCustomerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerName.Location = new System.Drawing.Point(24, 234);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(260, 22);
            this.lblCustomerName.TabIndex = 320;
            this.lblCustomerName.Text = "ex";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(21, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 319;
            this.label1.Text = "Customer ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label8.Location = new System.Drawing.Point(21, 314);
            this.label8.Margin = new System.Windows.Forms.Padding(4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 318;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(21, 264);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 317;
            this.label7.Text = "Phone ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(21, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 316;
            this.label2.Text = "Full name";
            // 
            // lblReservationId
            // 
            this.lblReservationId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblReservationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReservationId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblReservationId.Location = new System.Drawing.Point(27, 82);
            this.lblReservationId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblReservationId.Name = "lblReservationId";
            this.lblReservationId.Size = new System.Drawing.Size(160, 22);
            this.lblReservationId.TabIndex = 328;
            this.lblReservationId.Text = "ex";
            this.lblReservationId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(24, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 327;
            this.label3.Text = "Reservation ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label9.Location = new System.Drawing.Point(201, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 326;
            this.label9.Text = "Reservation";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.BackColor = System.Drawing.Color.White;
            this.lblTotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTotalBalance.Location = new System.Drawing.Point(308, 554);
            this.lblTotalBalance.Margin = new System.Windows.Forms.Padding(4);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Padding = new System.Windows.Forms.Padding(4);
            this.lblTotalBalance.Size = new System.Drawing.Size(472, 26);
            this.lblTotalBalance.TabIndex = 329;
            this.lblTotalBalance.Text = "Total Balance: 6.750.000 vnd";
            this.lblTotalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCheckedOut
            // 
            this.lblCheckedOut.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCheckedOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCheckedOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCheckedOut.Location = new System.Drawing.Point(699, 82);
            this.lblCheckedOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCheckedOut.Name = "lblCheckedOut";
            this.lblCheckedOut.Size = new System.Drawing.Size(160, 22);
            this.lblCheckedOut.TabIndex = 336;
            this.lblCheckedOut.Text = "ex";
            this.lblCheckedOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCheckedIn
            // 
            this.lblCheckedIn.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCheckedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCheckedIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCheckedIn.Location = new System.Drawing.Point(531, 82);
            this.lblCheckedIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCheckedIn.Name = "lblCheckedIn";
            this.lblCheckedIn.Size = new System.Drawing.Size(160, 22);
            this.lblCheckedIn.TabIndex = 335;
            this.lblCheckedIn.Text = "ex";
            this.lblCheckedIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label15.Location = new System.Drawing.Point(695, 62);
            this.label15.Margin = new System.Windows.Forms.Padding(4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 16);
            this.label15.TabIndex = 334;
            this.label15.Text = "Checked out at";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label16.Location = new System.Drawing.Point(528, 62);
            this.label16.Margin = new System.Windows.Forms.Padding(4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 333;
            this.label16.Text = "Checked in at";
            // 
            // lblDeparture
            // 
            this.lblDeparture.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeparture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblDeparture.Location = new System.Drawing.Point(363, 82);
            this.lblDeparture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(160, 22);
            this.lblDeparture.TabIndex = 340;
            this.lblDeparture.Text = "ex";
            this.lblDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArrival
            // 
            this.lblArrival.BackColor = System.Drawing.Color.Gainsboro;
            this.lblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblArrival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblArrival.Location = new System.Drawing.Point(195, 82);
            this.lblArrival.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(160, 22);
            this.lblArrival.TabIndex = 339;
            this.lblArrival.Text = "ex";
            this.lblArrival.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label18.Location = new System.Drawing.Point(359, 62);
            this.label18.Margin = new System.Windows.Forms.Padding(4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 16);
            this.label18.TabIndex = 338;
            this.label18.Text = "Departure time";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label19.Location = new System.Drawing.Point(192, 62);
            this.label19.Margin = new System.Windows.Forms.Padding(4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 16);
            this.label19.TabIndex = 337;
            this.label19.Text = "Arrival time";
            // 
            // pnReservationStatus
            // 
            this.pnReservationStatus.Controls.Add(this.lblReservationStatus);
            this.pnReservationStatus.Location = new System.Drawing.Point(24, 24);
            this.pnReservationStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnReservationStatus.Name = "pnReservationStatus";
            this.pnReservationStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnReservationStatus.Size = new System.Drawing.Size(170, 24);
            this.pnReservationStatus.TabIndex = 341;
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
            // FormReservationServiceUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pnReservationStatus);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblArrival);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblCheckedOut);
            this.Controls.Add(this.lblCheckedIn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblTotalBalance);
            this.Controls.Add(this.lblReservationId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnCustomerStatus);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbStatusFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbbSearchType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnHotelServiceUsageUpdate);
            this.Controls.Add(this.grvHotelServiceUsage);
            this.Controls.Add(this.btnHotelServiceUsageCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormReservationServiceUsage";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation hotel service usage";
            this.Load += new System.EventHandler(this.FormHotelService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvHotelServiceUsage)).EndInit();
            this.pnCustomerStatus.ResumeLayout(false);
            this.pnReservationStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHotelServiceUsageCreate;
        private System.Windows.Forms.DataGridView grvHotelServiceUsage;
        private System.Windows.Forms.Button btnHotelServiceUsageUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbSearchType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbStatusFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnCustomerStatus;
        private System.Windows.Forms.Label lblCustomerStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReservationId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn started_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn ended_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label lblCheckedOut;
        private System.Windows.Forms.Label lblCheckedIn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel pnReservationStatus;
        private System.Windows.Forms.Label lblReservationStatus;
    }
}