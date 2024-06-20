namespace HotelMs
{
    partial class FormReservationServiceUsageCreate
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnReservationStatus = new System.Windows.Forms.Panel();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvHotelSerivce)).BeginInit();
            this.pnReservationStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label13.Location = new System.Drawing.Point(24, 123);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 19);
            this.label13.TabIndex = 276;
            this.label13.Text = "Service usage";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExit.Location = new System.Drawing.Point(571, 553);
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
            this.label10.Location = new System.Drawing.Point(25, 212);
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
            this.label5.Location = new System.Drawing.Point(25, 258);
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
            this.dtpEndedAt.Location = new System.Drawing.Point(28, 276);
            this.dtpEndedAt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpEndedAt.Name = "dtpEndedAt";
            this.dtpEndedAt.Size = new System.Drawing.Size(200, 22);
            this.dtpEndedAt.TabIndex = 300;
            // 
            // dtpStartedAt
            // 
            this.dtpStartedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpStartedAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartedAt.Location = new System.Drawing.Point(28, 230);
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvHotelSerivce.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvHotelSerivce.GridColor = System.Drawing.Color.Gainsboro;
            this.grvHotelSerivce.Location = new System.Drawing.Point(255, 228);
            this.grvHotelSerivce.Margin = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.grvHotelSerivce.Name = "grvHotelSerivce";
            this.grvHotelSerivce.ReadOnly = true;
            this.grvHotelSerivce.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvHotelSerivce.RowHeadersWidth = 45;
            this.grvHotelSerivce.RowTemplate.Height = 30;
            this.grvHotelSerivce.RowTemplate.ReadOnly = true;
            this.grvHotelSerivce.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvHotelSerivce.Size = new System.Drawing.Size(576, 297);
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
            this.label1.Location = new System.Drawing.Point(251, 123);
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
            this.lblServiceId.Location = new System.Drawing.Point(29, 182);
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
            this.label11.Location = new System.Drawing.Point(25, 162);
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
            this.btnSearchService.Location = new System.Drawing.Point(737, 178);
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
            this.txtSearchService.Location = new System.Drawing.Point(407, 179);
            this.txtSearchService.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.txtSearchService.Name = "txtSearchService";
            this.txtSearchService.Size = new System.Drawing.Size(330, 22);
            this.txtSearchService.TabIndex = 310;
            // 
            // cbbSearchTypeService
            // 
            this.cbbSearchTypeService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchTypeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSearchTypeService.FormattingEnabled = true;
            this.cbbSearchTypeService.Location = new System.Drawing.Point(255, 178);
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
            this.label4.Location = new System.Drawing.Point(252, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 309;
            this.label4.Text = "Search by";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.Location = new System.Drawing.Point(28, 322);
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
            this.label6.Location = new System.Drawing.Point(25, 304);
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
            this.btnCreate.Location = new System.Drawing.Point(303, 552);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(260, 32);
            this.btnCreate.TabIndex = 315;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerName.Location = new System.Drawing.Point(237, 83);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(200, 22);
            this.lblCustomerName.TabIndex = 319;
            this.lblCustomerName.Text = "ex";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(233, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 318;
            this.label7.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(205, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 320;
            this.label2.Text = "Reservation";
            // 
            // pnReservationStatus
            // 
            this.pnReservationStatus.Controls.Add(this.lblReservationStatus);
            this.pnReservationStatus.Location = new System.Drawing.Point(28, 24);
            this.pnReservationStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnReservationStatus.Name = "pnReservationStatus";
            this.pnReservationStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnReservationStatus.Size = new System.Drawing.Size(170, 24);
            this.pnReservationStatus.TabIndex = 321;
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
            // FormReservationServiceUsageCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 611);
            this.Controls.Add(this.pnReservationStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label7);
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
            this.Name = "FormReservationServiceUsageCreate";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create hotel service usage";
            this.Load += new System.EventHandler(this.FormReservationServiceUsageCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvHotelSerivce)).EndInit();
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
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnReservationStatus;
        private System.Windows.Forms.Label lblReservationStatus;
    }
}