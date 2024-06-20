
namespace HotelMs
{
    partial class FormReservationCheckOut
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
            this.CreateBtn = new System.Windows.Forms.Button();
            this.grvCoupon = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coupon_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usage_limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.require_min_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expired_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbSearchType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pnReservationStatus = new System.Windows.Forms.Panel();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblReservationId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnCouponStatus = new System.Windows.Forms.Panel();
            this.lblCouponStatus = new System.Windows.Forms.Label();
            this.lblCheckedOut = new System.Windows.Forms.Label();
            this.lblCheckedIn = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblCouponId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCouponCode = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCouponTitle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblMinBalance = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblUsageLimit = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblCouponDetail = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.ckbUseCoupon = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvCoupon)).BeginInit();
            this.pnReservationStatus.SuspendLayout();
            this.pnCouponStatus.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.CreateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBtn.FlatAppearance.BorderSize = 0;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CreateBtn.ForeColor = System.Drawing.Color.White;
            this.CreateBtn.Location = new System.Drawing.Point(992, 554);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(160, 26);
            this.CreateBtn.TabIndex = 14;
            this.CreateBtn.Text = "Create coupon";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // grvCoupon
            // 
            this.grvCoupon.AllowUserToAddRows = false;
            this.grvCoupon.AllowUserToDeleteRows = false;
            this.grvCoupon.AllowUserToResizeColumns = false;
            this.grvCoupon.AllowUserToResizeRows = false;
            this.grvCoupon.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grvCoupon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvCoupon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCoupon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCoupon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.coupon_code,
            this.title,
            this.rate_percent,
            this.usage_limit,
            this.require_min_balance,
            this.expired_at,
            this.created_at,
            this.updated_at,
            this.detail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCoupon.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvCoupon.GridColor = System.Drawing.Color.Gainsboro;
            this.grvCoupon.Location = new System.Drawing.Point(317, 240);
            this.grvCoupon.Margin = new System.Windows.Forms.Padding(0, 16, 0, 8);
            this.grvCoupon.Name = "grvCoupon";
            this.grvCoupon.ReadOnly = true;
            this.grvCoupon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvCoupon.RowHeadersWidth = 45;
            this.grvCoupon.RowTemplate.Height = 30;
            this.grvCoupon.RowTemplate.ReadOnly = true;
            this.grvCoupon.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCoupon.Size = new System.Drawing.Size(835, 302);
            this.grvCoupon.TabIndex = 114;
            this.grvCoupon.SelectionChanged += new System.EventHandler(this.grvCoupon_SelectionChanged);
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
            // coupon_code
            // 
            this.coupon_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coupon_code.DataPropertyName = "coupon_code";
            this.coupon_code.HeaderText = "Code";
            this.coupon_code.Name = "coupon_code";
            this.coupon_code.ReadOnly = true;
            this.coupon_code.Width = 73;
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
            // rate_percent
            // 
            this.rate_percent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rate_percent.DataPropertyName = "rate_percent";
            this.rate_percent.HeaderText = "Rate (%)";
            this.rate_percent.Name = "rate_percent";
            this.rate_percent.ReadOnly = true;
            this.rate_percent.Width = 92;
            // 
            // usage_limit
            // 
            this.usage_limit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usage_limit.DataPropertyName = "usage_limit";
            this.usage_limit.HeaderText = "Usage Limit";
            this.usage_limit.Name = "usage_limit";
            this.usage_limit.ReadOnly = true;
            this.usage_limit.Width = 111;
            // 
            // require_min_balance
            // 
            this.require_min_balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.require_min_balance.DataPropertyName = "require_min_balance";
            this.require_min_balance.HeaderText = "Min balance";
            this.require_min_balance.Name = "require_min_balance";
            this.require_min_balance.ReadOnly = true;
            this.require_min_balance.Width = 113;
            // 
            // expired_at
            // 
            this.expired_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.expired_at.DataPropertyName = "expired_at";
            this.expired_at.HeaderText = "Expired At";
            this.expired_at.Name = "expired_at";
            this.expired_at.ReadOnly = true;
            this.expired_at.Width = 101;
            // 
            // created_at
            // 
            this.created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "Created At";
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            this.created_at.Width = 103;
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
            // detail
            // 
            this.detail.DataPropertyName = "detail";
            this.detail.HeaderText = "Column1";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Visible = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Silver;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UpdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.UpdateBtn.Location = new System.Drawing.Point(824, 554);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(160, 26);
            this.UpdateBtn.TabIndex = 127;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.btnUpdateCoupon_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(923, 196);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
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
            this.txtSearch.Location = new System.Drawing.Point(470, 198);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(453, 22);
            this.txtSearch.TabIndex = 141;
            // 
            // cbbSearchType
            // 
            this.cbbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSearchType.FormattingEnabled = true;
            this.cbbSearchType.Location = new System.Drawing.Point(317, 197);
            this.cbbSearchType.Name = "cbbSearchType";
            this.cbbSearchType.Size = new System.Drawing.Size(153, 24);
            this.cbbSearchType.TabIndex = 142;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label14.Location = new System.Drawing.Point(314, 178);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 140;
            this.label14.Text = "Search by";
            // 
            // pnReservationStatus
            // 
            this.pnReservationStatus.Controls.Add(this.lblReservationStatus);
            this.pnReservationStatus.Location = new System.Drawing.Point(27, 24);
            this.pnReservationStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnReservationStatus.Name = "pnReservationStatus";
            this.pnReservationStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnReservationStatus.Size = new System.Drawing.Size(170, 24);
            this.pnReservationStatus.TabIndex = 333;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(204, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 332;
            this.label2.Text = "Reservation";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCustomerName.Location = new System.Drawing.Point(235, 89);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(200, 22);
            this.lblCustomerName.TabIndex = 331;
            this.lblCustomerName.Text = "ex";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(232, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 330;
            this.label7.Text = "Customer Name";
            // 
            // lblReservationId
            // 
            this.lblReservationId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblReservationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReservationId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblReservationId.Location = new System.Drawing.Point(27, 89);
            this.lblReservationId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblReservationId.Name = "lblReservationId";
            this.lblReservationId.Size = new System.Drawing.Size(200, 22);
            this.lblReservationId.TabIndex = 329;
            this.lblReservationId.Text = "ex";
            this.lblReservationId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(24, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 328;
            this.label3.Text = "Reservation ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(494, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 334;
            this.label1.Text = "Coupons";
            // 
            // pnCouponStatus
            // 
            this.pnCouponStatus.Controls.Add(this.lblCouponStatus);
            this.pnCouponStatus.Location = new System.Drawing.Point(317, 135);
            this.pnCouponStatus.Margin = new System.Windows.Forms.Padding(0);
            this.pnCouponStatus.Name = "pnCouponStatus";
            this.pnCouponStatus.Padding = new System.Windows.Forms.Padding(1);
            this.pnCouponStatus.Size = new System.Drawing.Size(170, 24);
            this.pnCouponStatus.TabIndex = 335;
            // 
            // lblCouponStatus
            // 
            this.lblCouponStatus.BackColor = System.Drawing.Color.White;
            this.lblCouponStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCouponStatus.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouponStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCouponStatus.Location = new System.Drawing.Point(1, 1);
            this.lblCouponStatus.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.lblCouponStatus.Name = "lblCouponStatus";
            this.lblCouponStatus.Size = new System.Drawing.Size(168, 22);
            this.lblCouponStatus.TabIndex = 293;
            this.lblCouponStatus.Text = "STATUS";
            this.lblCouponStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCheckedOut
            // 
            this.lblCheckedOut.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCheckedOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCheckedOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCheckedOut.Location = new System.Drawing.Point(611, 89);
            this.lblCheckedOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCheckedOut.Name = "lblCheckedOut";
            this.lblCheckedOut.Size = new System.Drawing.Size(160, 22);
            this.lblCheckedOut.TabIndex = 339;
            this.lblCheckedOut.Text = "ex";
            this.lblCheckedOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCheckedIn
            // 
            this.lblCheckedIn.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCheckedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCheckedIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCheckedIn.Location = new System.Drawing.Point(443, 89);
            this.lblCheckedIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCheckedIn.Name = "lblCheckedIn";
            this.lblCheckedIn.Size = new System.Drawing.Size(160, 22);
            this.lblCheckedIn.TabIndex = 338;
            this.lblCheckedIn.Text = "ex";
            this.lblCheckedIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label15.Location = new System.Drawing.Point(608, 69);
            this.label15.Margin = new System.Windows.Forms.Padding(4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 16);
            this.label15.TabIndex = 337;
            this.label15.Text = "Checked out at";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label16.Location = new System.Drawing.Point(441, 69);
            this.label16.Margin = new System.Windows.Forms.Padding(4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 336;
            this.label16.Text = "Checked in at";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExit.Location = new System.Drawing.Point(884, 603);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(268, 32);
            this.btnExit.TabIndex = 341;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Location = new System.Drawing.Point(616, 603);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(260, 32);
            this.btnComplete.TabIndex = 340;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lblCouponId
            // 
            this.lblCouponId.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCouponId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCouponId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCouponId.Location = new System.Drawing.Point(27, 198);
            this.lblCouponId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCouponId.Name = "lblCouponId";
            this.lblCouponId.Size = new System.Drawing.Size(200, 22);
            this.lblCouponId.TabIndex = 344;
            this.lblCouponId.Text = "ex";
            this.lblCouponId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label6.Location = new System.Drawing.Point(24, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 343;
            this.label6.Text = "Selected coupon ID";
            // 
            // lblCouponCode
            // 
            this.lblCouponCode.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCouponCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCouponCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCouponCode.Location = new System.Drawing.Point(27, 248);
            this.lblCouponCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCouponCode.Name = "lblCouponCode";
            this.lblCouponCode.Size = new System.Drawing.Size(200, 22);
            this.lblCouponCode.TabIndex = 346;
            this.lblCouponCode.Text = "ex";
            this.lblCouponCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label9.Location = new System.Drawing.Point(24, 228);
            this.label9.Margin = new System.Windows.Forms.Padding(4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 345;
            this.label9.Text = "Coupon code";
            // 
            // lblCouponTitle
            // 
            this.lblCouponTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCouponTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCouponTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCouponTitle.Location = new System.Drawing.Point(27, 298);
            this.lblCouponTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCouponTitle.Name = "lblCouponTitle";
            this.lblCouponTitle.Size = new System.Drawing.Size(260, 22);
            this.lblCouponTitle.TabIndex = 348;
            this.lblCouponTitle.Text = "ex";
            this.lblCouponTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label11.Location = new System.Drawing.Point(24, 278);
            this.label11.Margin = new System.Windows.Forms.Padding(4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 347;
            this.label11.Text = "Coupon title";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTotalBalance.Location = new System.Drawing.Point(780, 89);
            this.lblTotalBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(200, 22);
            this.lblTotalBalance.TabIndex = 350;
            this.lblTotalBalance.Text = "ex";
            this.lblTotalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label13.Location = new System.Drawing.Point(776, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 16);
            this.label13.TabIndex = 349;
            this.label13.Text = "Total balance";
            // 
            // lblRate
            // 
            this.lblRate.BackColor = System.Drawing.Color.Gainsboro;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblRate.Location = new System.Drawing.Point(27, 348);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(80, 22);
            this.lblRate.TabIndex = 352;
            this.lblRate.Text = "ex";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label18.Location = new System.Drawing.Point(24, 328);
            this.label18.Margin = new System.Windows.Forms.Padding(4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 16);
            this.label18.TabIndex = 351;
            this.label18.Text = "Rate (%)";
            // 
            // lblMinBalance
            // 
            this.lblMinBalance.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMinBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMinBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblMinBalance.Location = new System.Drawing.Point(115, 348);
            this.lblMinBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblMinBalance.Name = "lblMinBalance";
            this.lblMinBalance.Size = new System.Drawing.Size(172, 22);
            this.lblMinBalance.TabIndex = 354;
            this.lblMinBalance.Text = "ex";
            this.lblMinBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label20.Location = new System.Drawing.Point(112, 328);
            this.label20.Margin = new System.Windows.Forms.Padding(4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(137, 16);
            this.label20.TabIndex = 353;
            this.label20.Text = "Min balance requirerd";
            // 
            // lblUsageLimit
            // 
            this.lblUsageLimit.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUsageLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsageLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblUsageLimit.Location = new System.Drawing.Point(27, 398);
            this.lblUsageLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblUsageLimit.Name = "lblUsageLimit";
            this.lblUsageLimit.Size = new System.Drawing.Size(200, 22);
            this.lblUsageLimit.TabIndex = 356;
            this.lblUsageLimit.Text = "ex";
            this.lblUsageLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label22.Location = new System.Drawing.Point(24, 378);
            this.label22.Margin = new System.Windows.Forms.Padding(4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 16);
            this.label22.TabIndex = 355;
            this.label22.Text = "Usage left";
            // 
            // lblCouponDetail
            // 
            this.lblCouponDetail.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCouponDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCouponDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCouponDetail.Location = new System.Drawing.Point(27, 448);
            this.lblCouponDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblCouponDetail.Name = "lblCouponDetail";
            this.lblCouponDetail.Size = new System.Drawing.Size(260, 94);
            this.lblCouponDetail.TabIndex = 358;
            this.lblCouponDetail.Text = "ex";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label24.Location = new System.Drawing.Point(24, 428);
            this.label24.Margin = new System.Windows.Forms.Padding(4);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 16);
            this.label24.TabIndex = 357;
            this.label24.Text = "Coupon detail";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblRowCount);
            this.panel6.Location = new System.Drawing.Point(317, 554);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(260, 26);
            this.panel6.TabIndex = 359;
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
            // ckbUseCoupon
            // 
            this.ckbUseCoupon.AutoSize = true;
            this.ckbUseCoupon.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.ckbUseCoupon.Location = new System.Drawing.Point(27, 138);
            this.ckbUseCoupon.Name = "ckbUseCoupon";
            this.ckbUseCoupon.Size = new System.Drawing.Size(135, 23);
            this.ckbUseCoupon.TabIndex = 360;
            this.ckbUseCoupon.Text = "Use coupon ?";
            this.ckbUseCoupon.UseVisualStyleBackColor = true;
            // 
            // FormReservationCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.ckbUseCoupon);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblCouponDetail);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lblUsageLimit);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblMinBalance);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblTotalBalance);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblCouponTitle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCouponCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCouponId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblCheckedOut);
            this.Controls.Add(this.lblCheckedIn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pnCouponStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnReservationStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblReservationId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbbSearchType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.grvCoupon);
            this.Controls.Add(this.CreateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormReservationCheckOut";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check out reservation";
            this.Load += new System.EventHandler(this.FormHotelService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCoupon)).EndInit();
            this.pnReservationStatus.ResumeLayout(false);
            this.pnCouponStatus.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.DataGridView grvCoupon;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbSearchType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnReservationStatus;
        private System.Windows.Forms.Label lblReservationStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblReservationId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnCouponStatus;
        private System.Windows.Forms.Label lblCouponStatus;
        private System.Windows.Forms.Label lblCheckedOut;
        private System.Windows.Forms.Label lblCheckedIn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lblCouponId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCouponCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCouponTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblMinBalance;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblUsageLimit;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblCouponDetail;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.CheckBox ckbUseCoupon;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coupon_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn usage_limit;
        private System.Windows.Forms.DataGridViewTextBoxColumn require_min_balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn expired_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
    }
}