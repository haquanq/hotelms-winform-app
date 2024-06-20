namespace HotelMs
{
    partial class FormHotelServiceUsageUpdate
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEndedAt = new System.Windows.Forms.DateTimePicker();
            this.dtpStartedAt = new System.Windows.Forms.DateTimePicker();
            this.grvHotelSerivce = new System.Windows.Forms.DataGridView();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServiceId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblReservationId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchService = new System.Windows.Forms.Button();
            this.txtSearchService = new System.Windows.Forms.TextBox();
            this.cbbSearchTypeService = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblUpdatedAt = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblServiceUsageId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnReservationStatus = new System.Windows.Forms.Panel();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnHotelServiceUsageStatus = new System.Windows.Forms.Panel();
            this.lblHotelServiceUsageStatus = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvHotelSerivce)).BeginInit();
            this.pnReservationStatus.SuspendLayout();
            this.pnHotelServiceUsageStatus.SuspendLayout();
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
            this.btnExit.Location = new System.Drawing.Point(896, 601);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 32);
            this.btnExit.TabIndex = 280;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label10.Location = new System.Drawing.Point(28, 275);
            this.label10.Margin = new System.Windows.Forms.Padding(4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 302;
            this.label10.Text = "Started at";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(236, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 301;
            this.label5.Text = "Ended at";
            // 
            // dtpEndedAt
            // 
            this.dtpEndedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpEndedAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndedAt.Location = new System.Drawing.Point(239, 293);
            this.dtpEndedAt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpEndedAt.Name = "dtpEndedAt";
            this.dtpEndedAt.Size = new System.Drawing.Size(200, 22);
            this.dtpEndedAt.TabIndex = 300;
            // 
            // dtpStartedAt
            // 
            this.dtpStartedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpStartedAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartedAt.Location = new System.Drawing.Point(31, 293);
            this.dtpStartedAt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpStartedAt.Name = "dtpStartedAt";
            this.dtpStartedAt.Size = new System.Drawing.Size(200, 22);
            this.dtpStartedAt.TabIndex = 299;
            // 
            // grvHotelSerivce
            // 
            this.grvHotelSerivce.AllowUserToAddRows = false;
            this.grvHotelSerivce.AllowUserToDeleteRows = false;
            this.grvHotelSerivce.AllowUserToResizeColumns = false;
            this.grvHotelSerivce.AllowUserToResizeRows = false;
            this.grvHotelSerivce.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvHotelSerivce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvHotelSerivce.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvHotelSerivce.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvHotelSerivce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvHotelSerivce.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1,
            this.title1,
            this.detail1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvHotelSerivce.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvHotelSerivce.GridColor = System.Drawing.Color.Gainsboro;
            this.grvHotelSerivce.Location = new System.Drawing.Point(471, 239);
            this.grvHotelSerivce.Margin = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.grvHotelSerivce.Name = "grvHotelSerivce";
            this.grvHotelSerivce.ReadOnly = true;
            this.grvHotelSerivce.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvHotelSerivce.RowHeadersWidth = 45;
            this.grvHotelSerivce.RowTemplate.Height = 30;
            this.grvHotelSerivce.RowTemplate.ReadOnly = true;
            this.grvHotelSerivce.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvHotelSerivce.Size = new System.Drawing.Size(685, 333);
            this.grvHotelSerivce.TabIndex = 303;
            this.grvHotelSerivce.SelectionChanged += new System.EventHandler(this.grvHotelSerivce_SelectionChanged);
            // 
            // id1
            // 
            this.id1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id1.DataPropertyName = "id";
            this.id1.HeaderText = "ID";
            this.id1.Name = "id1";
            this.id1.ReadOnly = true;
            this.id1.Width = 53;
            // 
            // title1
            // 
            this.title1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.title1.DataPropertyName = "title";
            this.title1.HeaderText = "Title";
            this.title1.Name = "title1";
            this.title1.ReadOnly = true;
            this.title1.Width = 66;
            // 
            // detail1
            // 
            this.detail1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detail1.DataPropertyName = "detail";
            this.detail1.HeaderText = "Detail";
            this.detail1.Name = "detail1";
            this.detail1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(467, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 304;
            this.label1.Text = "Available services";
            // 
            // lblServiceId
            // 
            this.lblServiceId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblServiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblServiceId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblServiceId.Location = new System.Drawing.Point(32, 195);
            this.lblServiceId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblServiceId.Name = "lblServiceId";
            this.lblServiceId.Size = new System.Drawing.Size(135, 22);
            this.lblServiceId.TabIndex = 306;
            this.lblServiceId.Text = "ex";
            this.lblServiceId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label11.Location = new System.Drawing.Point(28, 175);
            this.label11.Margin = new System.Windows.Forms.Padding(4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 305;
            this.label11.Text = "Service ID";
            // 
            // lblReservationId
            // 
            this.lblReservationId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblReservationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReservationId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblReservationId.Location = new System.Drawing.Point(472, 91);
            this.lblReservationId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblReservationId.Name = "lblReservationId";
            this.lblReservationId.Size = new System.Drawing.Size(200, 22);
            this.lblReservationId.TabIndex = 308;
            this.lblReservationId.Text = "ex";
            this.lblReservationId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(468, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 307;
            this.label3.Text = "Reservation ID";
            // 
            // btnSearchService
            // 
            this.btnSearchService.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchService.FlatAppearance.BorderSize = 0;
            this.btnSearchService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSearchService.ForeColor = System.Drawing.Color.White;
            this.btnSearchService.Location = new System.Drawing.Point(1062, 191);
            this.btnSearchService.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchService.Name = "btnSearchService";
            this.btnSearchService.Size = new System.Drawing.Size(94, 24);
            this.btnSearchService.TabIndex = 312;
            this.btnSearchService.Text = "Search";
            this.btnSearchService.UseVisualStyleBackColor = false;
            this.btnSearchService.Click += new System.EventHandler(this.btnSearchService_Click);
            // 
            // txtSearchService
            // 
            this.txtSearchService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchService.Location = new System.Drawing.Point(623, 191);
            this.txtSearchService.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.txtSearchService.Name = "txtSearchService";
            this.txtSearchService.Size = new System.Drawing.Size(439, 22);
            this.txtSearchService.TabIndex = 310;
            // 
            // cbbSearchTypeService
            // 
            this.cbbSearchTypeService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchTypeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSearchTypeService.FormattingEnabled = true;
            this.cbbSearchTypeService.Location = new System.Drawing.Point(471, 190);
            this.cbbSearchTypeService.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSearchTypeService.Name = "cbbSearchTypeService";
            this.cbbSearchTypeService.Size = new System.Drawing.Size(153, 24);
            this.cbbSearchTypeService.TabIndex = 311;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(468, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 309;
            this.label4.Text = "Search by";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.Location = new System.Drawing.Point(31, 339);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(409, 22);
            this.txtPrice.TabIndex = 314;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label6.Location = new System.Drawing.Point(28, 321);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 313;
            this.label6.Text = "Price";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(628, 600);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 32);
            this.btnSave.TabIndex = 315;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerName.Location = new System.Drawing.Point(680, 91);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(200, 22);
            this.lblCustomerName.TabIndex = 317;
            this.lblCustomerName.Text = "ex";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(676, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 316;
            this.label7.Text = "Customer Name";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(360, 600);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(260, 32);
            this.btnDelete.TabIndex = 318;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblUpdatedAt
            // 
            this.lblUpdatedAt.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUpdatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUpdatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblUpdatedAt.Location = new System.Drawing.Point(239, 245);
            this.lblUpdatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblUpdatedAt.Name = "lblUpdatedAt";
            this.lblUpdatedAt.Size = new System.Drawing.Size(200, 22);
            this.lblUpdatedAt.TabIndex = 322;
            this.lblUpdatedAt.Text = "ex";
            this.lblUpdatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label20.Location = new System.Drawing.Point(236, 225);
            this.label20.Margin = new System.Windows.Forms.Padding(4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 16);
            this.label20.TabIndex = 321;
            this.label20.Text = "Updated at";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCreatedAt.Location = new System.Drawing.Point(31, 245);
            this.lblCreatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(200, 22);
            this.lblCreatedAt.TabIndex = 320;
            this.lblCreatedAt.Text = "ex";
            this.lblCreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label22.Location = new System.Drawing.Point(28, 225);
            this.label22.Margin = new System.Windows.Forms.Padding(4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 16);
            this.label22.TabIndex = 319;
            this.label22.Text = "Created at";
            // 
            // lblServiceUsageId
            // 
            this.lblServiceUsageId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblServiceUsageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblServiceUsageId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblServiceUsageId.Location = new System.Drawing.Point(32, 88);
            this.lblServiceUsageId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblServiceUsageId.Name = "lblServiceUsageId";
            this.lblServiceUsageId.Size = new System.Drawing.Size(200, 22);
            this.lblServiceUsageId.TabIndex = 324;
            this.lblServiceUsageId.Text = "ex";
            this.lblServiceUsageId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label9.Location = new System.Drawing.Point(28, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 323;
            this.label9.Text = "Service Usage ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label12.Location = new System.Drawing.Point(208, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 19);
            this.label12.TabIndex = 325;
            this.label12.Text = "Service usage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(648, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 326;
            this.label2.Text = "Reservation";
            // 
            // pnReservationStatus
            // 
            this.pnReservationStatus.Controls.Add(this.lblReservationStatus);
            this.pnReservationStatus.Location = new System.Drawing.Point(471, 26);
            this.pnReservationStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnReservationStatus.Name = "pnReservationStatus";
            this.pnReservationStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnReservationStatus.Size = new System.Drawing.Size(170, 24);
            this.pnReservationStatus.TabIndex = 327;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label8.Location = new System.Drawing.Point(27, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 328;
            this.label8.Text = "Selected service";
            // 
            // pnHotelServiceUsageStatus
            // 
            this.pnHotelServiceUsageStatus.Controls.Add(this.lblHotelServiceUsageStatus);
            this.pnHotelServiceUsageStatus.Location = new System.Drawing.Point(31, 26);
            this.pnHotelServiceUsageStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnHotelServiceUsageStatus.Name = "pnHotelServiceUsageStatus";
            this.pnHotelServiceUsageStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnHotelServiceUsageStatus.Size = new System.Drawing.Size(170, 24);
            this.pnHotelServiceUsageStatus.TabIndex = 329;
            // 
            // lblHotelServiceUsageStatus
            // 
            this.lblHotelServiceUsageStatus.BackColor = System.Drawing.Color.White;
            this.lblHotelServiceUsageStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHotelServiceUsageStatus.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelServiceUsageStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblHotelServiceUsageStatus.Location = new System.Drawing.Point(1, 1);
            this.lblHotelServiceUsageStatus.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.lblHotelServiceUsageStatus.Name = "lblHotelServiceUsageStatus";
            this.lblHotelServiceUsageStatus.Size = new System.Drawing.Size(168, 22);
            this.lblHotelServiceUsageStatus.TabIndex = 293;
            this.lblHotelServiceUsageStatus.Text = "STATUS";
            this.lblHotelServiceUsageStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(239, 86);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(200, 24);
            this.cbbStatus.TabIndex = 331;
            this.cbbStatus.SelectionChangeCommitted += new System.EventHandler(this.cbbStatus_SelectionChangeCommitted);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label14.Location = new System.Drawing.Point(236, 67);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 330;
            this.label14.Text = "Status";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Gainsboro;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label15.Location = new System.Drawing.Point(175, 195);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(265, 22);
            this.label15.TabIndex = 333;
            this.label15.Text = "ex";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label16.Location = new System.Drawing.Point(172, 175);
            this.label16.Margin = new System.Windows.Forms.Padding(4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 16);
            this.label16.TabIndex = 332;
            this.label16.Text = "Service title";
            // 
            // FormHotelServiceUsageUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pnHotelServiceUsageStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnReservationStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblServiceUsageId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblUpdatedAt);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearchService);
            this.Controls.Add(this.txtSearchService);
            this.Controls.Add(this.cbbSearchTypeService);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblReservationId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblServiceId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvHotelSerivce);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpEndedAt);
            this.Controls.Add(this.dtpStartedAt);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormHotelServiceUsageUpdate";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update hotel service usage";
            this.Load += new System.EventHandler(this.FormRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvHotelSerivce)).EndInit();
            this.pnReservationStatus.ResumeLayout(false);
            this.pnHotelServiceUsageStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEndedAt;
        private System.Windows.Forms.DateTimePicker dtpStartedAt;
        private System.Windows.Forms.DataGridView grvHotelSerivce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServiceId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblReservationId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchService;
        private System.Windows.Forms.TextBox txtSearchService;
        private System.Windows.Forms.ComboBox cbbSearchTypeService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title1;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail1;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblUpdatedAt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblServiceUsageId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnReservationStatus;
        private System.Windows.Forms.Label lblReservationStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnHotelServiceUsageStatus;
        private System.Windows.Forms.Label lblHotelServiceUsageStatus;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}