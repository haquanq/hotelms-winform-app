namespace HotelMs
{
    partial class FormDashboard

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreateReaservation = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalRoomLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DirtyVacantLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CleanVacantLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ReadyLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BookedLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OccupiedLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grvExpectedArrival = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrival_time1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure_time1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvExpectedDeaprture = new System.Windows.Forms.DataGridView();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rooms2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure_time2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrival_time2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.cbbSearchType1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.cbbSearchType2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDirtyVacantRoom = new System.Windows.Forms.Button();
            this.btnCleanVacantRoom = new System.Windows.Forms.Button();
            this.btnBookedRoom = new System.Windows.Forms.Button();
            this.btnTotalRoom = new System.Windows.Forms.Button();
            this.lblExpectedArrival = new System.Windows.Forms.Label();
            this.lblExpectedDeparture = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOccupiedRoom = new System.Windows.Forms.Button();
            this.btnReadyRoom = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvExpectedArrival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvExpectedDeaprture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateReaservation
            // 
            this.btnCreateReaservation.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCreateReaservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateReaservation.FlatAppearance.BorderSize = 0;
            this.btnCreateReaservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateReaservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCreateReaservation.ForeColor = System.Drawing.Color.White;
            this.btnCreateReaservation.Location = new System.Drawing.Point(612, 160);
            this.btnCreateReaservation.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnCreateReaservation.Name = "btnCreateReaservation";
            this.btnCreateReaservation.Size = new System.Drawing.Size(180, 30);
            this.btnCreateReaservation.TabIndex = 48;
            this.btnCreateReaservation.Text = "Create reservation";
            this.btnCreateReaservation.UseVisualStyleBackColor = true;
            this.btnCreateReaservation.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.TotalRoomLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(24, 77);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 83);
            this.panel2.TabIndex = 146;
            // 
            // TotalRoomLabel
            // 
            this.TotalRoomLabel.AutoSize = true;
            this.TotalRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRoomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TotalRoomLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TotalRoomLabel.Location = new System.Drawing.Point(7, 6);
            this.TotalRoomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalRoomLabel.Name = "TotalRoomLabel";
            this.TotalRoomLabel.Size = new System.Drawing.Size(66, 46);
            this.TotalRoomLabel.TabIndex = 149;
            this.TotalRoomLabel.Text = "37";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(11, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 142;
            this.label3.Text = "TOTAL ROOMS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.DirtyVacantLabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(220, 77);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 83);
            this.panel3.TabIndex = 146;
            // 
            // DirtyVacantLabel
            // 
            this.DirtyVacantLabel.AutoSize = true;
            this.DirtyVacantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirtyVacantLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DirtyVacantLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DirtyVacantLabel.Location = new System.Drawing.Point(8, 6);
            this.DirtyVacantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DirtyVacantLabel.Name = "DirtyVacantLabel";
            this.DirtyVacantLabel.Size = new System.Drawing.Size(43, 46);
            this.DirtyVacantLabel.TabIndex = 150;
            this.DirtyVacantLabel.Text = "7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 145;
            this.label6.Text = "DIRTY VACANT";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.CleanVacantLabel);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(416, 77);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 83);
            this.panel4.TabIndex = 147;
            // 
            // CleanVacantLabel
            // 
            this.CleanVacantLabel.AutoSize = true;
            this.CleanVacantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanVacantLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CleanVacantLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CleanVacantLabel.Location = new System.Drawing.Point(11, 6);
            this.CleanVacantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CleanVacantLabel.Name = "CleanVacantLabel";
            this.CleanVacantLabel.Size = new System.Drawing.Size(43, 46);
            this.CleanVacantLabel.TabIndex = 150;
            this.CleanVacantLabel.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(15, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 144;
            this.label5.Text = "CLEAN VACANT";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.ReadyLabel);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(612, 77);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 83);
            this.panel5.TabIndex = 147;
            // 
            // ReadyLabel
            // 
            this.ReadyLabel.AutoSize = true;
            this.ReadyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ReadyLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ReadyLabel.Location = new System.Drawing.Point(2, 6);
            this.ReadyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReadyLabel.Name = "ReadyLabel";
            this.ReadyLabel.Size = new System.Drawing.Size(66, 46);
            this.ReadyLabel.TabIndex = 150;
            this.ReadyLabel.Text = "12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(13, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 143;
            this.label4.Text = "READY";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.BookedLabel);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.OccupiedLabel);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(808, 77);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 83);
            this.panel6.TabIndex = 148;
            // 
            // BookedLabel
            // 
            this.BookedLabel.AutoSize = true;
            this.BookedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BookedLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BookedLabel.Location = new System.Drawing.Point(4, 6);
            this.BookedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookedLabel.Name = "BookedLabel";
            this.BookedLabel.Size = new System.Drawing.Size(66, 46);
            this.BookedLabel.TabIndex = 153;
            this.BookedLabel.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(11, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 152;
            this.label9.Text = "BOOKED";
            // 
            // OccupiedLabel
            // 
            this.OccupiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OccupiedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.OccupiedLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OccupiedLabel.Location = new System.Drawing.Point(183, 6);
            this.OccupiedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OccupiedLabel.Name = "OccupiedLabel";
            this.OccupiedLabel.Size = new System.Drawing.Size(105, 46);
            this.OccupiedLabel.TabIndex = 151;
            this.OccupiedLabel.Text = "2";
            this.OccupiedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(179, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 143;
            this.label7.Text = "OCCUPIED";
            // 
            // grvExpectedArrival
            // 
            this.grvExpectedArrival.AllowUserToAddRows = false;
            this.grvExpectedArrival.AllowUserToDeleteRows = false;
            this.grvExpectedArrival.AllowUserToResizeColumns = false;
            this.grvExpectedArrival.AllowUserToResizeRows = false;
            this.grvExpectedArrival.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvExpectedArrival.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvExpectedArrival.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvExpectedArrival.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvExpectedArrival.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvExpectedArrival.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvExpectedArrival.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.customer_name,
            this.rooms,
            this.arrival_time1,
            this.departure_time1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvExpectedArrival.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvExpectedArrival.GridColor = System.Drawing.Color.Gainsboro;
            this.grvExpectedArrival.Location = new System.Drawing.Point(24, 316);
            this.grvExpectedArrival.Margin = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.grvExpectedArrival.Name = "grvExpectedArrival";
            this.grvExpectedArrival.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grvExpectedArrival.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grvExpectedArrival.RowHeadersWidth = 36;
            this.grvExpectedArrival.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvExpectedArrival.RowTemplate.Height = 30;
            this.grvExpectedArrival.RowTemplate.ReadOnly = true;
            this.grvExpectedArrival.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvExpectedArrival.Size = new System.Drawing.Size(532, 318);
            this.grvExpectedArrival.TabIndex = 149;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 53;
            // 
            // customer_name
            // 
            this.customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "Customer Name";
            this.customer_name.Name = "customer_name";
            this.customer_name.Width = 137;
            // 
            // rooms
            // 
            this.rooms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rooms.DataPropertyName = "rooms";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rooms.DefaultCellStyle = dataGridViewCellStyle2;
            this.rooms.HeaderText = "Rooms";
            this.rooms.Name = "rooms";
            this.rooms.Width = 84;
            // 
            // arrival_time1
            // 
            this.arrival_time1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.arrival_time1.DataPropertyName = "arrival_time";
            this.arrival_time1.HeaderText = "Arrival TIme";
            this.arrival_time1.Name = "arrival_time1";
            this.arrival_time1.Width = 112;
            // 
            // departure_time1
            // 
            this.departure_time1.DataPropertyName = "departure_time";
            this.departure_time1.HeaderText = "Column1";
            this.departure_time1.Name = "departure_time1";
            this.departure_time1.Visible = false;
            // 
            // grvExpectedDeaprture
            // 
            this.grvExpectedDeaprture.AllowUserToAddRows = false;
            this.grvExpectedDeaprture.AllowUserToDeleteRows = false;
            this.grvExpectedDeaprture.AllowUserToResizeColumns = false;
            this.grvExpectedDeaprture.AllowUserToResizeRows = false;
            this.grvExpectedDeaprture.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvExpectedDeaprture.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvExpectedDeaprture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvExpectedDeaprture.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvExpectedDeaprture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grvExpectedDeaprture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvExpectedDeaprture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.dataGridViewTextBoxColumn1,
            this.rooms2,
            this.departure_time2,
            this.arrival_time2});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvExpectedDeaprture.DefaultCellStyle = dataGridViewCellStyle7;
            this.grvExpectedDeaprture.GridColor = System.Drawing.Color.Gainsboro;
            this.grvExpectedDeaprture.Location = new System.Drawing.Point(571, 316);
            this.grvExpectedDeaprture.Margin = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.grvExpectedDeaprture.Name = "grvExpectedDeaprture";
            this.grvExpectedDeaprture.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvExpectedDeaprture.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grvExpectedDeaprture.RowHeadersWidth = 36;
            this.grvExpectedDeaprture.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvExpectedDeaprture.RowTemplate.Height = 30;
            this.grvExpectedDeaprture.RowTemplate.ReadOnly = true;
            this.grvExpectedDeaprture.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvExpectedDeaprture.Size = new System.Drawing.Size(532, 318);
            this.grvExpectedDeaprture.TabIndex = 150;
            // 
            // id2
            // 
            this.id2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id2.DataPropertyName = "id";
            this.id2.HeaderText = "ID";
            this.id2.Name = "id2";
            this.id2.Width = 53;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "customer_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 137;
            // 
            // rooms2
            // 
            this.rooms2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rooms2.DataPropertyName = "rooms";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rooms2.DefaultCellStyle = dataGridViewCellStyle6;
            this.rooms2.HeaderText = "Rooms";
            this.rooms2.Name = "rooms2";
            this.rooms2.Width = 84;
            // 
            // departure_time2
            // 
            this.departure_time2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.departure_time2.DataPropertyName = "departure_time";
            this.departure_time2.HeaderText = "Departue Time";
            this.departure_time2.Name = "departure_time2";
            this.departure_time2.Width = 130;
            // 
            // arrival_time2
            // 
            this.arrival_time2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.arrival_time2.DataPropertyName = "arrival_time";
            this.arrival_time2.HeaderText = "Arrival Time";
            this.arrival_time2.Name = "arrival_time2";
            this.arrival_time2.Visible = false;
            // 
            // btnSearch1
            // 
            this.btnSearch1.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch1.FlatAppearance.BorderSize = 0;
            this.btnSearch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSearch1.ForeColor = System.Drawing.Color.White;
            this.btnSearch1.Location = new System.Drawing.Point(462, 272);
            this.btnSearch1.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(94, 24);
            this.btnSearch1.TabIndex = 154;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = false;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // txtSearch1
            // 
            this.txtSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch1.Location = new System.Drawing.Point(177, 273);
            this.txtSearch1.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(285, 22);
            this.txtSearch1.TabIndex = 152;
            // 
            // cbbSearchType1
            // 
            this.cbbSearchType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSearchType1.FormattingEnabled = true;
            this.cbbSearchType1.Location = new System.Drawing.Point(24, 272);
            this.cbbSearchType1.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSearchType1.Name = "cbbSearchType1";
            this.cbbSearchType1.Size = new System.Drawing.Size(153, 24);
            this.cbbSearchType1.TabIndex = 153;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label14.Location = new System.Drawing.Point(21, 253);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 151;
            this.label14.Text = "Search by";
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch2.FlatAppearance.BorderSize = 0;
            this.btnSearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSearch2.ForeColor = System.Drawing.Color.White;
            this.btnSearch2.Location = new System.Drawing.Point(1009, 273);
            this.btnSearch2.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(94, 24);
            this.btnSearch2.TabIndex = 158;
            this.btnSearch2.Text = "Search";
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // txtSearch2
            // 
            this.txtSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch2.Location = new System.Drawing.Point(724, 273);
            this.txtSearch2.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(285, 22);
            this.txtSearch2.TabIndex = 156;
            // 
            // cbbSearchType2
            // 
            this.cbbSearchType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSearchType2.FormattingEnabled = true;
            this.cbbSearchType2.Location = new System.Drawing.Point(571, 272);
            this.cbbSearchType2.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSearchType2.Name = "cbbSearchType2";
            this.cbbSearchType2.Size = new System.Drawing.Size(153, 24);
            this.cbbSearchType2.TabIndex = 157;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(568, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 155;
            this.label2.Text = "Search by";
            // 
            // btnDirtyVacantRoom
            // 
            this.btnDirtyVacantRoom.BackColor = System.Drawing.Color.Silver;
            this.btnDirtyVacantRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDirtyVacantRoom.FlatAppearance.BorderSize = 0;
            this.btnDirtyVacantRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirtyVacantRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnDirtyVacantRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDirtyVacantRoom.Location = new System.Drawing.Point(220, 160);
            this.btnDirtyVacantRoom.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnDirtyVacantRoom.Name = "btnDirtyVacantRoom";
            this.btnDirtyVacantRoom.Size = new System.Drawing.Size(180, 30);
            this.btnDirtyVacantRoom.TabIndex = 159;
            this.btnDirtyVacantRoom.Text = "More detail";
            this.btnDirtyVacantRoom.UseVisualStyleBackColor = false;
            this.btnDirtyVacantRoom.Click += new System.EventHandler(this.btnDirtyVacantRoom_Click);
            // 
            // btnCleanVacantRoom
            // 
            this.btnCleanVacantRoom.BackColor = System.Drawing.Color.Silver;
            this.btnCleanVacantRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleanVacantRoom.FlatAppearance.BorderSize = 0;
            this.btnCleanVacantRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanVacantRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCleanVacantRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCleanVacantRoom.Location = new System.Drawing.Point(416, 160);
            this.btnCleanVacantRoom.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnCleanVacantRoom.Name = "btnCleanVacantRoom";
            this.btnCleanVacantRoom.Size = new System.Drawing.Size(180, 30);
            this.btnCleanVacantRoom.TabIndex = 160;
            this.btnCleanVacantRoom.Text = "More detail";
            this.btnCleanVacantRoom.UseVisualStyleBackColor = false;
            this.btnCleanVacantRoom.Click += new System.EventHandler(this.btnCleanVacantRoom_Click);
            // 
            // btnBookedRoom
            // 
            this.btnBookedRoom.BackColor = System.Drawing.Color.Silver;
            this.btnBookedRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookedRoom.FlatAppearance.BorderSize = 0;
            this.btnBookedRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookedRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnBookedRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnBookedRoom.Location = new System.Drawing.Point(808, 160);
            this.btnBookedRoom.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnBookedRoom.Name = "btnBookedRoom";
            this.btnBookedRoom.Size = new System.Drawing.Size(145, 30);
            this.btnBookedRoom.TabIndex = 161;
            this.btnBookedRoom.Text = "More detail";
            this.btnBookedRoom.UseVisualStyleBackColor = false;
            this.btnBookedRoom.Click += new System.EventHandler(this.btnBookedRoom_Click);
            // 
            // btnTotalRoom
            // 
            this.btnTotalRoom.BackColor = System.Drawing.Color.Silver;
            this.btnTotalRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotalRoom.FlatAppearance.BorderSize = 0;
            this.btnTotalRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnTotalRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnTotalRoom.Location = new System.Drawing.Point(24, 160);
            this.btnTotalRoom.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnTotalRoom.Name = "btnTotalRoom";
            this.btnTotalRoom.Size = new System.Drawing.Size(180, 30);
            this.btnTotalRoom.TabIndex = 162;
            this.btnTotalRoom.Text = "More detail";
            this.btnTotalRoom.UseVisualStyleBackColor = false;
            this.btnTotalRoom.Click += new System.EventHandler(this.btnTotalRoom_Click);
            // 
            // lblExpectedArrival
            // 
            this.lblExpectedArrival.AutoSize = true;
            this.lblExpectedArrival.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.lblExpectedArrival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblExpectedArrival.Location = new System.Drawing.Point(19, 215);
            this.lblExpectedArrival.Name = "lblExpectedArrival";
            this.lblExpectedArrival.Size = new System.Drawing.Size(143, 19);
            this.lblExpectedArrival.TabIndex = 163;
            this.lblExpectedArrival.Text = "Expected Arrival ";
            // 
            // lblExpectedDeparture
            // 
            this.lblExpectedDeparture.AutoSize = true;
            this.lblExpectedDeparture.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.lblExpectedDeparture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblExpectedDeparture.Location = new System.Drawing.Point(567, 215);
            this.lblExpectedDeparture.Name = "lblExpectedDeparture";
            this.lblExpectedDeparture.Size = new System.Drawing.Size(168, 19);
            this.lblExpectedDeparture.TabIndex = 164;
            this.lblExpectedDeparture.Text = "Expected Departure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(24, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 35);
            this.panel1.TabIndex = 46;
            // 
            // btnOccupiedRoom
            // 
            this.btnOccupiedRoom.BackColor = System.Drawing.Color.Silver;
            this.btnOccupiedRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOccupiedRoom.FlatAppearance.BorderSize = 0;
            this.btnOccupiedRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOccupiedRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnOccupiedRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnOccupiedRoom.Location = new System.Drawing.Point(958, 160);
            this.btnOccupiedRoom.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnOccupiedRoom.Name = "btnOccupiedRoom";
            this.btnOccupiedRoom.Size = new System.Drawing.Size(145, 30);
            this.btnOccupiedRoom.TabIndex = 165;
            this.btnOccupiedRoom.Text = "More detail";
            this.btnOccupiedRoom.UseVisualStyleBackColor = false;
            this.btnOccupiedRoom.Click += new System.EventHandler(this.btnOccupiedRoom_Click);
            // 
            // btnReadyRoom
            // 
            this.btnReadyRoom.BackColor = System.Drawing.Color.Silver;
            this.btnReadyRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadyRoom.FlatAppearance.BorderSize = 0;
            this.btnReadyRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadyRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnReadyRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnReadyRoom.Location = new System.Drawing.Point(612, 160);
            this.btnReadyRoom.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnReadyRoom.Name = "btnReadyRoom";
            this.btnReadyRoom.Size = new System.Drawing.Size(180, 30);
            this.btnReadyRoom.TabIndex = 166;
            this.btnReadyRoom.Text = "More detail";
            this.btnReadyRoom.UseVisualStyleBackColor = false;
            this.btnReadyRoom.Click += new System.EventHandler(this.btnReadyRoom_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 661);
            this.Controls.Add(this.btnReadyRoom);
            this.Controls.Add(this.btnOccupiedRoom);
            this.Controls.Add(this.lblExpectedDeparture);
            this.Controls.Add(this.lblExpectedArrival);
            this.Controls.Add(this.btnTotalRoom);
            this.Controls.Add(this.btnBookedRoom);
            this.Controls.Add(this.btnCleanVacantRoom);
            this.Controls.Add(this.btnDirtyVacantRoom);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.txtSearch2);
            this.Controls.Add(this.cbbSearchType2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.txtSearch1);
            this.Controls.Add(this.cbbSearchType1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.grvExpectedDeaprture);
            this.Controls.Add(this.grvExpectedArrival);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCreateReaservation);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1127, 661);
            this.MinimumSize = new System.Drawing.Size(1127, 661);
            this.Name = "FormDashboard";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Text = "nhan vien";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvExpectedArrival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvExpectedDeaprture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateReaservation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TotalRoomLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DirtyVacantLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label CleanVacantLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label ReadyLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label OccupiedLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grvExpectedArrival;
        private System.Windows.Forms.DataGridView grvExpectedDeaprture;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.ComboBox cbbSearchType1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.ComboBox cbbSearchType2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDirtyVacantRoom;
        private System.Windows.Forms.Button btnCleanVacantRoom;
        private System.Windows.Forms.Button btnBookedRoom;
        private System.Windows.Forms.Button btnTotalRoom;
        private System.Windows.Forms.Label lblExpectedArrival;
        private System.Windows.Forms.Label lblExpectedDeparture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BookedLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rooms2;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure_time2;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrival_time2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn rooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrival_time1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure_time1;
        private System.Windows.Forms.Button btnOccupiedRoom;
        private System.Windows.Forms.Button btnReadyRoom;
    }
}