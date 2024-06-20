
namespace HotelMs
{
    partial class FormCoupon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCouponCreate = new System.Windows.Forms.Button();
            this.grvCoupon = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coupon_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.require_min_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usage_limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expired_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCouponUpdate = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.btnCouponSearch = new System.Windows.Forms.Button();
            this.txtCouponSearch = new System.Windows.Forms.TextBox();
            this.cbbCouponSearchType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbCouponStatusFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvCoupon)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCouponCreate
            // 
            this.btnCouponCreate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCouponCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCouponCreate.FlatAppearance.BorderSize = 0;
            this.btnCouponCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCouponCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCouponCreate.ForeColor = System.Drawing.Color.White;
            this.btnCouponCreate.Location = new System.Drawing.Point(943, 607);
            this.btnCouponCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCouponCreate.Name = "btnCouponCreate";
            this.btnCouponCreate.Size = new System.Drawing.Size(160, 30);
            this.btnCouponCreate.TabIndex = 14;
            this.btnCouponCreate.Text = "Create coupon";
            this.btnCouponCreate.UseVisualStyleBackColor = false;
            this.btnCouponCreate.Click += new System.EventHandler(this.btnCouponCreate_Click);
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
            this.require_min_balance,
            this.usage_limit,
            this.expired_at,
            this.created_at,
            this.updated_at,
            this.status,
            this.detail});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCoupon.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvCoupon.GridColor = System.Drawing.Color.Gainsboro;
            this.grvCoupon.Location = new System.Drawing.Point(24, 142);
            this.grvCoupon.Margin = new System.Windows.Forms.Padding(0, 24, 0, 24);
            this.grvCoupon.Name = "grvCoupon";
            this.grvCoupon.ReadOnly = true;
            this.grvCoupon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grvCoupon.RowHeadersWidth = 45;
            this.grvCoupon.RowTemplate.Height = 30;
            this.grvCoupon.RowTemplate.ReadOnly = true;
            this.grvCoupon.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCoupon.Size = new System.Drawing.Size(1079, 441);
            this.grvCoupon.TabIndex = 114;
            this.grvCoupon.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grvCoupon_CellPainting);
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
            // require_min_balance
            // 
            this.require_min_balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.require_min_balance.DataPropertyName = "require_min_balance";
            this.require_min_balance.HeaderText = "Min balance";
            this.require_min_balance.Name = "require_min_balance";
            this.require_min_balance.ReadOnly = true;
            this.require_min_balance.Width = 113;
            // 
            // usage_limit
            // 
            this.usage_limit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usage_limit.DataPropertyName = "usage_limit";
            this.usage_limit.HeaderText = "Usage Count";
            this.usage_limit.Name = "usage_limit";
            this.usage_limit.ReadOnly = true;
            this.usage_limit.Width = 118;
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
            // status
            // 
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.status.DefaultCellStyle = dataGridViewCellStyle2;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // detail
            // 
            this.detail.DataPropertyName = "detail";
            this.detail.HeaderText = "Column1";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Visible = false;
            // 
            // btnCouponUpdate
            // 
            this.btnCouponUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnCouponUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCouponUpdate.FlatAppearance.BorderSize = 0;
            this.btnCouponUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCouponUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCouponUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCouponUpdate.Location = new System.Drawing.Point(775, 607);
            this.btnCouponUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCouponUpdate.Name = "btnCouponUpdate";
            this.btnCouponUpdate.Size = new System.Drawing.Size(160, 30);
            this.btnCouponUpdate.TabIndex = 127;
            this.btnCouponUpdate.Text = "Update";
            this.btnCouponUpdate.UseVisualStyleBackColor = false;
            this.btnCouponUpdate.Click += new System.EventHandler(this.btnCouponUpdate_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SteelBlue;
            this.panel12.Controls.Add(this.label16);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(24, 24);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1079, 35);
            this.panel12.TabIndex = 129;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(10, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 21);
            this.label16.TabIndex = 43;
            this.label16.Text = "Coupons";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Silver;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnNext.Location = new System.Drawing.Point(134, 605);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnNext.Size = new System.Drawing.Size(47, 30);
            this.btnNext.TabIndex = 132;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Silver;
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFirst.Location = new System.Drawing.Point(24, 605);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnFirst.Size = new System.Drawing.Size(47, 30);
            this.btnFirst.TabIndex = 130;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Silver;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnPrevious.Location = new System.Drawing.Point(79, 605);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnPrevious.Size = new System.Drawing.Size(47, 30);
            this.btnPrevious.TabIndex = 131;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Silver;
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnLast.Location = new System.Drawing.Point(189, 605);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnLast.Size = new System.Drawing.Size(47, 30);
            this.btnLast.TabIndex = 133;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblRowCount);
            this.panel6.Location = new System.Drawing.Point(244, 605);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(219, 30);
            this.panel6.TabIndex = 138;
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRowCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRowCount.Location = new System.Drawing.Point(5, 8);
            this.lblRowCount.Margin = new System.Windows.Forms.Padding(4);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(41, 16);
            this.lblRowCount.TabIndex = 48;
            this.lblRowCount.Text = "Total:";
            // 
            // btnCouponSearch
            // 
            this.btnCouponSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCouponSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCouponSearch.FlatAppearance.BorderSize = 0;
            this.btnCouponSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCouponSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCouponSearch.ForeColor = System.Drawing.Color.White;
            this.btnCouponSearch.Location = new System.Drawing.Point(1009, 90);
            this.btnCouponSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnCouponSearch.Name = "btnCouponSearch";
            this.btnCouponSearch.Size = new System.Drawing.Size(94, 24);
            this.btnCouponSearch.TabIndex = 143;
            this.btnCouponSearch.Text = "Search";
            this.btnCouponSearch.UseVisualStyleBackColor = false;
            this.btnCouponSearch.Click += new System.EventHandler(this.btnCouponSearch_Click);
            // 
            // txtCouponSearch
            // 
            this.txtCouponSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCouponSearch.Location = new System.Drawing.Point(743, 91);
            this.txtCouponSearch.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.txtCouponSearch.Name = "txtCouponSearch";
            this.txtCouponSearch.Size = new System.Drawing.Size(266, 22);
            this.txtCouponSearch.TabIndex = 141;
            // 
            // cbbCouponSearchType
            // 
            this.cbbCouponSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCouponSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbCouponSearchType.FormattingEnabled = true;
            this.cbbCouponSearchType.Location = new System.Drawing.Point(590, 90);
            this.cbbCouponSearchType.Name = "cbbCouponSearchType";
            this.cbbCouponSearchType.Size = new System.Drawing.Size(153, 24);
            this.cbbCouponSearchType.TabIndex = 142;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label14.Location = new System.Drawing.Point(587, 71);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 140;
            this.label14.Text = "Search by";
            // 
            // cbbCouponStatusFilter
            // 
            this.cbbCouponStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCouponStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbbCouponStatusFilter.FormattingEnabled = true;
            this.cbbCouponStatusFilter.Location = new System.Drawing.Point(24, 90);
            this.cbbCouponStatusFilter.Name = "cbbCouponStatusFilter";
            this.cbbCouponStatusFilter.Size = new System.Drawing.Size(153, 24);
            this.cbbCouponStatusFilter.TabIndex = 145;
            this.cbbCouponStatusFilter.SelectionChangeCommitted += new System.EventHandler(this.cbbCouponStatusFilter_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 144;
            this.label1.Text = "Status filter";
            // 
            // FormCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 661);
            this.Controls.Add(this.cbbCouponStatusFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCouponSearch);
            this.Controls.Add(this.txtCouponSearch);
            this.Controls.Add(this.cbbCouponSearchType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.btnCouponUpdate);
            this.Controls.Add(this.grvCoupon);
            this.Controls.Add(this.btnCouponCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1127, 661);
            this.MinimumSize = new System.Drawing.Size(1127, 661);
            this.Name = "FormCoupon";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đề xuất";
            this.Load += new System.EventHandler(this.FormCoupon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCoupon)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCouponCreate;
        private System.Windows.Forms.DataGridView grvCoupon;
        private System.Windows.Forms.Button btnCouponUpdate;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Button btnCouponSearch;
        private System.Windows.Forms.TextBox txtCouponSearch;
        private System.Windows.Forms.ComboBox cbbCouponSearchType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbCouponStatusFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coupon_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn require_min_balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn usage_limit;
        private System.Windows.Forms.DataGridViewTextBoxColumn expired_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
    }
}