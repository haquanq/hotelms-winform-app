
namespace HotelMs
{
    partial class FormRoomCreate
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtRoomCode = new System.Windows.Forms.TextBox();
            this.cbbRoomType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grvRoomAmenity = new System.Windows.Forms.DataGridView();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_chargable1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.grvAvailableAmenity = new System.Windows.Forms.DataGridView();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_chargable2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddAmenity = new System.Windows.Forms.Button();
            this.btnMoreDetail = new System.Windows.Forms.Button();
            this.btnRemoveAmenity = new System.Windows.Forms.Button();
            this.txtFloorNumber = new System.Windows.Forms.NumericUpDown();
            this.searchBtn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbSearchType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvRoomAmenity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAvailableAmenity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFloorNumber)).BeginInit();
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
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(628, 601);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(260, 32);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtRoomCode
            // 
            this.txtRoomCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRoomCode.ForeColor = System.Drawing.Color.Black;
            this.txtRoomCode.Location = new System.Drawing.Point(28, 86);
            this.txtRoomCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomCode.Name = "txtRoomCode";
            this.txtRoomCode.Size = new System.Drawing.Size(260, 22);
            this.txtRoomCode.TabIndex = 163;
            // 
            // cbbRoomType
            // 
            this.cbbRoomType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbRoomType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbRoomType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbRoomType.FormattingEnabled = true;
            this.cbbRoomType.Items.AddRange(new object[] {
            "Book genre",
            "Book author"});
            this.cbbRoomType.Location = new System.Drawing.Point(564, 85);
            this.cbbRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbRoomType.Name = "cbbRoomType";
            this.cbbRoomType.Size = new System.Drawing.Size(260, 24);
            this.cbbRoomType.TabIndex = 172;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(561, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 174;
            this.label3.Text = "Room type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 175;
            this.label1.Text = "Room code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(293, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 176;
            this.label2.Text = "Floor number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label13.Location = new System.Drawing.Point(24, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 19);
            this.label13.TabIndex = 177;
            this.label13.Text = "Room information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(24, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 178;
            this.label4.Text = "Room amenities";
            // 
            // grvRoomAmenity
            // 
            this.grvRoomAmenity.AllowUserToAddRows = false;
            this.grvRoomAmenity.AllowUserToDeleteRows = false;
            this.grvRoomAmenity.AllowUserToResizeColumns = false;
            this.grvRoomAmenity.AllowUserToResizeRows = false;
            this.grvRoomAmenity.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvRoomAmenity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvRoomAmenity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvRoomAmenity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvRoomAmenity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRoomAmenity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1,
            this.title1,
            this.price1,
            this.is_chargable1,
            this.detail1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvRoomAmenity.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvRoomAmenity.GridColor = System.Drawing.Color.Gainsboro;
            this.grvRoomAmenity.Location = new System.Drawing.Point(28, 171);
            this.grvRoomAmenity.Margin = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.grvRoomAmenity.Name = "grvRoomAmenity";
            this.grvRoomAmenity.ReadOnly = true;
            this.grvRoomAmenity.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvRoomAmenity.RowHeadersWidth = 45;
            this.grvRoomAmenity.RowTemplate.Height = 30;
            this.grvRoomAmenity.RowTemplate.ReadOnly = true;
            this.grvRoomAmenity.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvRoomAmenity.Size = new System.Drawing.Size(488, 375);
            this.grvRoomAmenity.TabIndex = 179;
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
            // price1
            // 
            this.price1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price1.DataPropertyName = "price";
            this.price1.HeaderText = "Price";
            this.price1.Name = "price1";
            this.price1.ReadOnly = true;
            this.price1.Width = 71;
            // 
            // is_chargable1
            // 
            this.is_chargable1.DataPropertyName = "is_chargable";
            this.is_chargable1.HeaderText = "Chargable";
            this.is_chargable1.Name = "is_chargable1";
            this.is_chargable1.ReadOnly = true;
            // 
            // detail1
            // 
            this.detail1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detail1.DataPropertyName = "detail";
            this.detail1.HeaderText = "Detail";
            this.detail1.Name = "detail1";
            this.detail1.ReadOnly = true;
            this.detail1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(534, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 19);
            this.label5.TabIndex = 180;
            this.label5.Text = "Available amenities";
            // 
            // grvAvailableAmenity
            // 
            this.grvAvailableAmenity.AllowUserToAddRows = false;
            this.grvAvailableAmenity.AllowUserToDeleteRows = false;
            this.grvAvailableAmenity.AllowUserToResizeColumns = false;
            this.grvAvailableAmenity.AllowUserToResizeRows = false;
            this.grvAvailableAmenity.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvAvailableAmenity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvAvailableAmenity.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvAvailableAmenity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvAvailableAmenity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvAvailableAmenity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.title2,
            this.price2,
            this.is_chargable2,
            this.detail2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvAvailableAmenity.DefaultCellStyle = dataGridViewCellStyle4;
            this.grvAvailableAmenity.GridColor = System.Drawing.Color.Gainsboro;
            this.grvAvailableAmenity.Location = new System.Drawing.Point(539, 237);
            this.grvAvailableAmenity.Margin = new System.Windows.Forms.Padding(0, 24, 0, 8);
            this.grvAvailableAmenity.Name = "grvAvailableAmenity";
            this.grvAvailableAmenity.ReadOnly = true;
            this.grvAvailableAmenity.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvAvailableAmenity.RowHeadersWidth = 45;
            this.grvAvailableAmenity.RowTemplate.Height = 30;
            this.grvAvailableAmenity.RowTemplate.ReadOnly = true;
            this.grvAvailableAmenity.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvAvailableAmenity.Size = new System.Drawing.Size(621, 309);
            this.grvAvailableAmenity.TabIndex = 181;
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
            // title2
            // 
            this.title2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.title2.DataPropertyName = "title";
            this.title2.HeaderText = "Title";
            this.title2.Name = "title2";
            this.title2.ReadOnly = true;
            this.title2.Width = 66;
            // 
            // price2
            // 
            this.price2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price2.DataPropertyName = "price";
            this.price2.HeaderText = "Price";
            this.price2.Name = "price2";
            this.price2.ReadOnly = true;
            this.price2.Width = 71;
            // 
            // is_chargable2
            // 
            this.is_chargable2.DataPropertyName = "is_chargable";
            this.is_chargable2.HeaderText = "Chargable";
            this.is_chargable2.Name = "is_chargable2";
            this.is_chargable2.ReadOnly = true;
            // 
            // detail2
            // 
            this.detail2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detail2.DataPropertyName = "detail";
            this.detail2.HeaderText = "Detail";
            this.detail2.Name = "detail2";
            this.detail2.ReadOnly = true;
            this.detail2.Visible = false;
            // 
            // btnAddAmenity
            // 
            this.btnAddAmenity.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddAmenity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAmenity.FlatAppearance.BorderSize = 0;
            this.btnAddAmenity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAmenity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddAmenity.ForeColor = System.Drawing.Color.White;
            this.btnAddAmenity.Location = new System.Drawing.Point(539, 558);
            this.btnAddAmenity.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAmenity.Name = "btnAddAmenity";
            this.btnAddAmenity.Size = new System.Drawing.Size(220, 26);
            this.btnAddAmenity.TabIndex = 182;
            this.btnAddAmenity.Text = "<<   Add";
            this.btnAddAmenity.UseVisualStyleBackColor = false;
            this.btnAddAmenity.Click += new System.EventHandler(this.btnAddAmenity_Click);
            // 
            // btnMoreDetail
            // 
            this.btnMoreDetail.BackColor = System.Drawing.Color.Silver;
            this.btnMoreDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoreDetail.FlatAppearance.BorderSize = 0;
            this.btnMoreDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoreDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMoreDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMoreDetail.Location = new System.Drawing.Point(768, 558);
            this.btnMoreDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoreDetail.Name = "btnMoreDetail";
            this.btnMoreDetail.Size = new System.Drawing.Size(220, 26);
            this.btnMoreDetail.TabIndex = 183;
            this.btnMoreDetail.Text = "More detail";
            this.btnMoreDetail.UseVisualStyleBackColor = false;
            this.btnMoreDetail.Click += new System.EventHandler(this.btnUpdateAmenity_Click);
            // 
            // btnRemoveAmenity
            // 
            this.btnRemoveAmenity.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoveAmenity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAmenity.FlatAppearance.BorderSize = 0;
            this.btnRemoveAmenity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAmenity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRemoveAmenity.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAmenity.Location = new System.Drawing.Point(296, 558);
            this.btnRemoveAmenity.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveAmenity.Name = "btnRemoveAmenity";
            this.btnRemoveAmenity.Size = new System.Drawing.Size(220, 26);
            this.btnRemoveAmenity.TabIndex = 184;
            this.btnRemoveAmenity.Text = "Remove   >>";
            this.btnRemoveAmenity.UseVisualStyleBackColor = false;
            this.btnRemoveAmenity.Click += new System.EventHandler(this.btnRemoveAmenity_Click);
            // 
            // txtFloorNumber
            // 
            this.txtFloorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFloorNumber.Location = new System.Drawing.Point(296, 87);
            this.txtFloorNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtFloorNumber.Name = "txtFloorNumber";
            this.txtFloorNumber.Size = new System.Drawing.Size(260, 22);
            this.txtFloorNumber.TabIndex = 185;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(1066, 189);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(94, 24);
            this.searchBtn.TabIndex = 272;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Location = new System.Drawing.Point(692, 190);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(374, 22);
            this.txtSearch.TabIndex = 270;
            // 
            // cbbSearchType
            // 
            this.cbbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSearchType.FormattingEnabled = true;
            this.cbbSearchType.Location = new System.Drawing.Point(539, 189);
            this.cbbSearchType.Name = "cbbSearchType";
            this.cbbSearchType.Size = new System.Drawing.Size(153, 24);
            this.cbbSearchType.TabIndex = 271;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label14.Location = new System.Drawing.Point(536, 170);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 269;
            this.label14.Text = "Search by";
            // 
            // FormRoomCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbbSearchType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtFloorNumber);
            this.Controls.Add(this.btnRemoveAmenity);
            this.Controls.Add(this.btnMoreDetail);
            this.Controls.Add(this.btnAddAmenity);
            this.Controls.Add(this.grvAvailableAmenity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grvRoomAmenity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbRoomType);
            this.Controls.Add(this.txtRoomCode);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreate);
            this.MaximizeBox = false;
            this.Name = "FormRoomCreate";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new room";
            this.Load += new System.EventHandler(this.FormRoomCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvRoomAmenity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvAvailableAmenity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFloorNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtRoomCode;
        private System.Windows.Forms.ComboBox cbbRoomType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grvRoomAmenity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grvAvailableAmenity;
        private System.Windows.Forms.Button btnAddAmenity;
        private System.Windows.Forms.Button btnMoreDetail;
        private System.Windows.Forms.Button btnRemoveAmenity;
        private System.Windows.Forms.NumericUpDown txtFloorNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title1;
        private System.Windows.Forms.DataGridViewTextBoxColumn price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_chargable1;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn title2;
        private System.Windows.Forms.DataGridViewTextBoxColumn price2;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_chargable2;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbSearchType;
        private System.Windows.Forms.Label label14;
    }
}