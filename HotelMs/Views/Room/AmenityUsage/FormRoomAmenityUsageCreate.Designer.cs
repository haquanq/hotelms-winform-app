
namespace HotelMs
{
    partial class FormRoomAmenityUsageCreate
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRoomCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRoomFloor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbSearchType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grvAmenity = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_chargable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAmenityId = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblAmenityTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChargable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnRoomStatus = new System.Windows.Forms.Panel();
            this.lblRoomStatus = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblReservationId = new System.Windows.Forms.Label();
            this.label2141 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvAmenity)).BeginInit();
            this.pnRoomStatus.SuspendLayout();
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
            this.btnExit.Location = new System.Drawing.Point(700, 601);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 32);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(432, 601);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 32);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Create";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblRoomId
            // 
            this.lblRoomId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRoomId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRoomId.Location = new System.Drawing.Point(261, 83);
            this.lblRoomId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(200, 22);
            this.lblRoomId.TabIndex = 265;
            this.lblRoomId.Text = "ex";
            this.lblRoomId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(258, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 264;
            this.label2.Text = "Room ID";
            // 
            // lblRoomCode
            // 
            this.lblRoomCode.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRoomCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRoomCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRoomCode.Location = new System.Drawing.Point(469, 83);
            this.lblRoomCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblRoomCode.Name = "lblRoomCode";
            this.lblRoomCode.Size = new System.Drawing.Size(200, 22);
            this.lblRoomCode.TabIndex = 267;
            this.lblRoomCode.Text = "ex";
            this.lblRoomCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(466, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 266;
            this.label4.Text = "Room code";
            // 
            // lblRoomFloor
            // 
            this.lblRoomFloor.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRoomFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRoomFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRoomFloor.Location = new System.Drawing.Point(677, 83);
            this.lblRoomFloor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblRoomFloor.Name = "lblRoomFloor";
            this.lblRoomFloor.Size = new System.Drawing.Size(200, 22);
            this.lblRoomFloor.TabIndex = 269;
            this.lblRoomFloor.Text = "ex";
            this.lblRoomFloor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(674, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 268;
            this.label7.Text = "Room floor";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(762, 191);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 24);
            this.btnSearch.TabIndex = 276;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Location = new System.Drawing.Point(410, 192);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(352, 22);
            this.txtSearch.TabIndex = 274;
            // 
            // cbbSearchType
            // 
            this.cbbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSearchType.FormattingEnabled = true;
            this.cbbSearchType.Location = new System.Drawing.Point(261, 192);
            this.cbbSearchType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.cbbSearchType.Name = "cbbSearchType";
            this.cbbSearchType.Size = new System.Drawing.Size(150, 24);
            this.cbbSearchType.TabIndex = 275;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label14.Location = new System.Drawing.Point(258, 173);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 273;
            this.label14.Text = "Search by";
            // 
            // grvAmenity
            // 
            this.grvAmenity.AllowUserToAddRows = false;
            this.grvAmenity.AllowUserToDeleteRows = false;
            this.grvAmenity.AllowUserToResizeColumns = false;
            this.grvAmenity.AllowUserToResizeRows = false;
            this.grvAmenity.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvAmenity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvAmenity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvAmenity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvAmenity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvAmenity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.price,
            this.is_chargable,
            this.detail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvAmenity.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvAmenity.GridColor = System.Drawing.Color.Gainsboro;
            this.grvAmenity.Location = new System.Drawing.Point(261, 239);
            this.grvAmenity.Margin = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.grvAmenity.Name = "grvAmenity";
            this.grvAmenity.ReadOnly = true;
            this.grvAmenity.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvAmenity.RowHeadersWidth = 45;
            this.grvAmenity.RowTemplate.Height = 30;
            this.grvAmenity.RowTemplate.ReadOnly = true;
            this.grvAmenity.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvAmenity.Size = new System.Drawing.Size(699, 334);
            this.grvAmenity.TabIndex = 272;
            this.grvAmenity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvAmenity_CellClick);
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
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Name";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 77;
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
            this.is_chargable.DataPropertyName = "is_chargable";
            this.is_chargable.HeaderText = "Chargable";
            this.is_chargable.Name = "is_chargable";
            this.is_chargable.ReadOnly = true;
            // 
            // detail
            // 
            this.detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detail.DataPropertyName = "detail";
            this.detail.HeaderText = "Detail";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label10.Location = new System.Drawing.Point(27, 134);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 19);
            this.label10.TabIndex = 291;
            this.label10.Text = "Selected amenity";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPrice.Location = new System.Drawing.Point(31, 340);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(201, 22);
            this.txtPrice.TabIndex = 294;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label12.Location = new System.Drawing.Point(28, 323);
            this.label12.Margin = new System.Windows.Forms.Padding(4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 16);
            this.label12.TabIndex = 293;
            this.label12.Text = "Price ";
            // 
            // lblAmenityId
            // 
            this.lblAmenityId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAmenityId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAmenityId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblAmenityId.Location = new System.Drawing.Point(32, 193);
            this.lblAmenityId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblAmenityId.Name = "lblAmenityId";
            this.lblAmenityId.Size = new System.Drawing.Size(200, 22);
            this.lblAmenityId.TabIndex = 297;
            this.lblAmenityId.Text = "ex";
            this.lblAmenityId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label16.Location = new System.Drawing.Point(28, 173);
            this.label16.Margin = new System.Windows.Forms.Padding(4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 16);
            this.label16.TabIndex = 296;
            this.label16.Text = "Amenity ID";
            // 
            // lblAmenityTitle
            // 
            this.lblAmenityTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAmenityTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAmenityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblAmenityTitle.Location = new System.Drawing.Point(32, 243);
            this.lblAmenityTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblAmenityTitle.Name = "lblAmenityTitle";
            this.lblAmenityTitle.Size = new System.Drawing.Size(200, 22);
            this.lblAmenityTitle.TabIndex = 301;
            this.lblAmenityTitle.Text = "ex";
            this.lblAmenityTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(28, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 300;
            this.label3.Text = "Amenity name";
            // 
            // lblChargable
            // 
            this.lblChargable.BackColor = System.Drawing.Color.Gainsboro;
            this.lblChargable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblChargable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblChargable.Location = new System.Drawing.Point(32, 293);
            this.lblChargable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblChargable.Name = "lblChargable";
            this.lblChargable.Size = new System.Drawing.Size(200, 22);
            this.lblChargable.TabIndex = 303;
            this.lblChargable.Text = "ex";
            this.lblChargable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(28, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 302;
            this.label5.Text = "Pay per usage ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(257, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 304;
            this.label1.Text = "Available amenities";
            // 
            // pnRoomStatus
            // 
            this.pnRoomStatus.Controls.Add(this.lblRoomStatus);
            this.pnRoomStatus.Location = new System.Drawing.Point(261, 24);
            this.pnRoomStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnRoomStatus.Name = "pnRoomStatus";
            this.pnRoomStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnRoomStatus.Size = new System.Drawing.Size(170, 24);
            this.pnRoomStatus.TabIndex = 306;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label13.Location = new System.Drawing.Point(438, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 19);
            this.label13.TabIndex = 305;
            this.label13.Text = "Room";
            // 
            // lblReservationId
            // 
            this.lblReservationId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblReservationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReservationId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblReservationId.Location = new System.Drawing.Point(31, 83);
            this.lblReservationId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblReservationId.Name = "lblReservationId";
            this.lblReservationId.Size = new System.Drawing.Size(200, 22);
            this.lblReservationId.TabIndex = 312;
            this.lblReservationId.Text = "ex";
            this.lblReservationId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2141
            // 
            this.label2141.AutoSize = true;
            this.label2141.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2141.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2141.Location = new System.Drawing.Point(28, 63);
            this.label2141.Margin = new System.Windows.Forms.Padding(4);
            this.label2141.Name = "label2141";
            this.label2141.Size = new System.Drawing.Size(96, 16);
            this.label2141.TabIndex = 311;
            this.label2141.Text = "Reservation ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label6.Location = new System.Drawing.Point(27, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 313;
            this.label6.Text = "Reservation";
            // 
            // FormRoomAmenityUsageCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblReservationId);
            this.Controls.Add(this.label2141);
            this.Controls.Add(this.pnRoomStatus);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChargable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAmenityTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAmenityId);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbbSearchType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.grvAmenity);
            this.Controls.Add(this.lblRoomFloor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRoomCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRoomId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "FormRoomAmenityUsageCreate";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create room amenity usage";
            this.Load += new System.EventHandler(this.FormAmenityUsageCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvAmenity)).EndInit();
            this.pnRoomStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRoomCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRoomFloor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbSearchType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView grvAmenity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAmenityId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblAmenityTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_chargable;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
        private System.Windows.Forms.Label lblChargable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnRoomStatus;
        private System.Windows.Forms.Label lblRoomStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblReservationId;
        private System.Windows.Forms.Label label2141;
        private System.Windows.Forms.Label label6;
    }
}