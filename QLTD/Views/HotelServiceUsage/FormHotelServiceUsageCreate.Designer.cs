namespace HotelMs
{
    partial class FormHotelServiceUsageCreate
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
            this.label13 = new System.Windows.Forms.Label();
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchReservation = new System.Windows.Forms.Button();
            this.txtSearchReservation = new System.Windows.Forms.TextBox();
            this.cbbSearchTypeReservation = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grvReservation = new System.Windows.Forms.DataGridView();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrival_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checked_in_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnReservationStatus = new System.Windows.Forms.Panel();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvHotelSerivce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReservation)).BeginInit();
            this.pnReservationStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label13.Location = new System.Drawing.Point(24, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(260, 19);
            this.label13.TabIndex = 276;
            this.label13.Text = "Hotel service usage information";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExit.Location = new System.Drawing.Point(1096, 603);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 30);
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
            this.label10.Location = new System.Drawing.Point(442, 65);
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
            this.label5.Location = new System.Drawing.Point(650, 65);
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
            this.dtpEndedAt.Location = new System.Drawing.Point(653, 83);
            this.dtpEndedAt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpEndedAt.Name = "dtpEndedAt";
            this.dtpEndedAt.Size = new System.Drawing.Size(200, 22);
            this.dtpEndedAt.TabIndex = 300;
            // 
            // dtpStartedAt
            // 
            this.dtpStartedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpStartedAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartedAt.Location = new System.Drawing.Point(445, 83);
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
            this.grvHotelSerivce.Location = new System.Drawing.Point(828, 242);
            this.grvHotelSerivce.Margin = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.grvHotelSerivce.Name = "grvHotelSerivce";
            this.grvHotelSerivce.ReadOnly = true;
            this.grvHotelSerivce.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvHotelSerivce.RowHeadersWidth = 45;
            this.grvHotelSerivce.RowTemplate.Height = 30;
            this.grvHotelSerivce.RowTemplate.ReadOnly = true;
            this.grvHotelSerivce.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvHotelSerivce.Size = new System.Drawing.Size(528, 333);
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
            this.label1.Location = new System.Drawing.Point(824, 137);
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
            this.lblServiceId.Location = new System.Drawing.Point(237, 83);
            this.lblServiceId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblServiceId.Name = "lblServiceId";
            this.lblServiceId.Size = new System.Drawing.Size(200, 22);
            this.lblServiceId.TabIndex = 306;
            this.lblServiceId.Text = "ex";
            this.lblServiceId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label11.Location = new System.Drawing.Point(233, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 305;
            this.label11.Text = "Selected Service ID";
            // 
            // lblReservationId
            // 
            this.lblReservationId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblReservationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReservationId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblReservationId.Location = new System.Drawing.Point(29, 83);
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
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 307;
            this.label3.Text = "Selected Reservation ID";
            // 
            // btnSearchService
            // 
            this.btnSearchService.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchService.FlatAppearance.BorderSize = 0;
            this.btnSearchService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSearchService.ForeColor = System.Drawing.Color.White;
            this.btnSearchService.Location = new System.Drawing.Point(1262, 193);
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
            this.txtSearchService.Location = new System.Drawing.Point(980, 193);
            this.txtSearchService.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.txtSearchService.Name = "txtSearchService";
            this.txtSearchService.Size = new System.Drawing.Size(282, 22);
            this.txtSearchService.TabIndex = 310;
            // 
            // cbbSearchTypeService
            // 
            this.cbbSearchTypeService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchTypeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSearchTypeService.FormattingEnabled = true;
            this.cbbSearchTypeService.Location = new System.Drawing.Point(828, 192);
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
            this.label4.Location = new System.Drawing.Point(825, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 309;
            this.label4.Text = "Search by";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.Location = new System.Drawing.Point(861, 83);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 314;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label6.Location = new System.Drawing.Point(858, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 313;
            this.label6.Text = "Price";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(828, 602);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(260, 32);
            this.btnCreate.TabIndex = 315;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label9.Location = new System.Drawing.Point(205, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 19);
            this.label9.TabIndex = 323;
            this.label9.Text = "Reservations";
            // 
            // btnSearchReservation
            // 
            this.btnSearchReservation.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchReservation.FlatAppearance.BorderSize = 0;
            this.btnSearchReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSearchReservation.ForeColor = System.Drawing.Color.White;
            this.btnSearchReservation.Location = new System.Drawing.Point(486, 192);
            this.btnSearchReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchReservation.Name = "btnSearchReservation";
            this.btnSearchReservation.Size = new System.Drawing.Size(94, 24);
            this.btnSearchReservation.TabIndex = 322;
            this.btnSearchReservation.Text = "Search";
            this.btnSearchReservation.UseVisualStyleBackColor = false;
            // 
            // txtSearchReservation
            // 
            this.txtSearchReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchReservation.Location = new System.Drawing.Point(181, 193);
            this.txtSearchReservation.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.txtSearchReservation.Name = "txtSearchReservation";
            this.txtSearchReservation.Size = new System.Drawing.Size(305, 22);
            this.txtSearchReservation.TabIndex = 320;
            // 
            // cbbSearchTypeReservation
            // 
            this.cbbSearchTypeReservation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchTypeReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSearchTypeReservation.FormattingEnabled = true;
            this.cbbSearchTypeReservation.Location = new System.Drawing.Point(28, 192);
            this.cbbSearchTypeReservation.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSearchTypeReservation.Name = "cbbSearchTypeReservation";
            this.cbbSearchTypeReservation.Size = new System.Drawing.Size(153, 24);
            this.cbbSearchTypeReservation.TabIndex = 321;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label14.Location = new System.Drawing.Point(25, 173);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 319;
            this.label14.Text = "Search by";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.rooms,
            this.customer_name,
            this.arrival_time,
            this.departure_time,
            this.checked_in_at,
            this.created_at,
            this.updated_at});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvReservation.DefaultCellStyle = dataGridViewCellStyle5;
            this.grvReservation.GridColor = System.Drawing.Color.Gainsboro;
            this.grvReservation.Location = new System.Drawing.Point(28, 242);
            this.grvReservation.Margin = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.grvReservation.Name = "grvReservation";
            this.grvReservation.ReadOnly = true;
            this.grvReservation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvReservation.RowHeadersWidth = 45;
            this.grvReservation.RowTemplate.Height = 30;
            this.grvReservation.RowTemplate.ReadOnly = true;
            this.grvReservation.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvReservation.Size = new System.Drawing.Size(777, 333);
            this.grvReservation.TabIndex = 316;
            // 
            // id2
            // 
            this.id2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id2.DataPropertyName = "id";
            this.id2.HeaderText = "ID";
            this.id2.Name = "id2";
            this.id2.ReadOnly = true;
            this.id2.Width = 53;
            // 
            // rooms
            // 
            this.rooms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rooms.DataPropertyName = "rooms";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rooms.DefaultCellStyle = dataGridViewCellStyle4;
            this.rooms.HeaderText = "Rooms";
            this.rooms.Name = "rooms";
            this.rooms.ReadOnly = true;
            this.rooms.Width = 84;
            // 
            // customer_name
            // 
            this.customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customer_name.DataPropertyName = "customer_name";
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
            // pnReservationStatus
            // 
            this.pnReservationStatus.Controls.Add(this.lblReservationStatus);
            this.pnReservationStatus.Location = new System.Drawing.Point(28, 132);
            this.pnReservationStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnReservationStatus.Name = "pnReservationStatus";
            this.pnReservationStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnReservationStatus.Size = new System.Drawing.Size(170, 24);
            this.pnReservationStatus.TabIndex = 324;
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
            // FormHotelServiceUsageCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.pnReservationStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSearchReservation);
            this.Controls.Add(this.txtSearchReservation);
            this.Controls.Add(this.cbbSearchTypeReservation);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.grvReservation);
            this.Controls.Add(this.btnCreate);
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
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormHotelServiceUsageCreate";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create hotel service usage";
            this.Load += new System.EventHandler(this.FormRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvHotelSerivce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvReservation)).EndInit();
            this.pnReservationStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
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
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title1;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearchReservation;
        private System.Windows.Forms.TextBox txtSearchReservation;
        private System.Windows.Forms.ComboBox cbbSearchTypeReservation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView grvReservation;
        private System.Windows.Forms.Panel pnReservationStatus;
        private System.Windows.Forms.Label lblReservationStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrival_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn checked_in_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
    }
}