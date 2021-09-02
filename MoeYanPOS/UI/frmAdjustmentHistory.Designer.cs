﻿namespace MoeYanPOS.UI
{
    partial class frmAdjustmentHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdjustmentHistory));
            this.label14 = new System.Windows.Forms.Label();
            this.cboHeader = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.dgvItemCode = new System.Windows.Forms.DataGridView();
            this.colStkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameInEng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameInMM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvAdjustment = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblAdjustmentHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.dgvAdjDetail = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClose1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdjustmentReport = new System.Windows.Forms.Button();
            this.btnAdjustmentDetailReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjustment)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjDetail)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 16);
            this.label14.TabIndex = 58;
            this.label14.Text = "Adjustment Header";
            // 
            // cboHeader
            // 
            this.cboHeader.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHeader.FormattingEnabled = true;
            this.cboHeader.Location = new System.Drawing.Point(149, 17);
            this.cboHeader.Name = "cboHeader";
            this.cboHeader.Size = new System.Drawing.Size(161, 29);
            this.cboHeader.TabIndex = 57;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(149, 58);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(161, 25);
            this.txtStock.TabIndex = 59;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            this.txtStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStock_KeyDown);
            // 
            // dgvItemCode
            // 
            this.dgvItemCode.AllowUserToAddRows = false;
            this.dgvItemCode.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItemCode.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemCode.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvItemCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemCode.ColumnHeadersVisible = false;
            this.dgvItemCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStkID,
            this.colStkItemCode,
            this.colNameInEng,
            this.colNameInMM,
            this.colPrice});
            this.dgvItemCode.Location = new System.Drawing.Point(345, -6);
            this.dgvItemCode.Name = "dgvItemCode";
            this.dgvItemCode.RowHeadersVisible = false;
            this.dgvItemCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemCode.Size = new System.Drawing.Size(405, 131);
            this.dgvItemCode.TabIndex = 60;
            this.dgvItemCode.Visible = false;
            this.dgvItemCode.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemCode_CellClick);
            this.dgvItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItemCode_KeyDown);
            // 
            // colStkID
            // 
            this.colStkID.HeaderText = "ID";
            this.colStkID.Name = "colStkID";
            this.colStkID.ReadOnly = true;
            this.colStkID.Visible = false;
            // 
            // colStkItemCode
            // 
            this.colStkItemCode.HeaderText = "ItemCode";
            this.colStkItemCode.Name = "colStkItemCode";
            this.colStkItemCode.ReadOnly = true;
            // 
            // colNameInEng
            // 
            this.colNameInEng.HeaderText = "NameInEng";
            this.colNameInEng.Name = "colNameInEng";
            this.colNameInEng.ReadOnly = true;
            // 
            // colNameInMM
            // 
            this.colNameInMM.HeaderText = "NameInMM";
            this.colNameInMM.Name = "colNameInMM";
            this.colNameInMM.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "Item Code";
            // 
            // dgvAdjustment
            // 
            this.dgvAdjustment.AllowUserToAddRows = false;
            this.dgvAdjustment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAdjustment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdjustment.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvAdjustment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdjustment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDate,
            this.colHeader,
            this.colUser,
            this.colEdit,
            this.colDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdjustment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdjustment.Location = new System.Drawing.Point(1, 3);
            this.dgvAdjustment.Name = "dgvAdjustment";
            this.dgvAdjustment.ReadOnly = true;
            this.dgvAdjustment.RowHeadersVisible = false;
            this.dgvAdjustment.Size = new System.Drawing.Size(951, 189);
            this.dgvAdjustment.TabIndex = 62;
            this.dgvAdjustment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdjustment_CellClick);
            this.dgvAdjustment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdjustment_CellContentClick);
            this.dgvAdjustment.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdjustment_CellEnter);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 150;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colHeader
            // 
            this.colHeader.HeaderText = "Adjustment Header";
            this.colHeader.Name = "colHeader";
            this.colHeader.ReadOnly = true;
            this.colHeader.Width = 300;
            // 
            // colUser
            // 
            this.colUser.HeaderText = "User";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(473, 54);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(16, 16);
            this.lblItemCode.TabIndex = 67;
            this.lblItemCode.Text = "0";
            this.lblItemCode.Visible = false;
            // 
            // lblAdjustmentHeader
            // 
            this.lblAdjustmentHeader.AutoSize = true;
            this.lblAdjustmentHeader.Location = new System.Drawing.Point(473, 32);
            this.lblAdjustmentHeader.Name = "lblAdjustmentHeader";
            this.lblAdjustmentHeader.Size = new System.Drawing.Size(16, 16);
            this.lblAdjustmentHeader.TabIndex = 68;
            this.lblAdjustmentHeader.Text = "0";
            this.lblAdjustmentHeader.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "To";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(73, 100);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(96, 20);
            this.dtpToDate.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "From";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(73, 74);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(96, 20);
            this.dtpFromDate.TabIndex = 69;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.cboHeader);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cboLocation);
            this.groupBox1.Controls.Add(this.lblAdjustmentHeader);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblItemCode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(196, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 89);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(352, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 21);
            this.label20.TabIndex = 70;
            this.label20.Text = "Location";
            // 
            // cboLocation
            // 
            this.cboLocation.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cboLocation.Location = new System.Drawing.Point(437, 17);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(147, 29);
            this.cboLocation.TabIndex = 69;
            // 
            // dgvAdjDetail
            // 
            this.dgvAdjDetail.AllowUserToAddRows = false;
            this.dgvAdjDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAdjDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAdjDetail.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvAdjDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdjDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colItemCode,
            this.colSalePrice,
            this.colQty,
            this.colAmount,
            this.colFOC});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdjDetail.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAdjDetail.Location = new System.Drawing.Point(1, 353);
            this.dgvAdjDetail.Name = "dgvAdjDetail";
            this.dgvAdjDetail.ReadOnly = true;
            this.dgvAdjDetail.RowHeadersVisible = false;
            this.dgvAdjDetail.Size = new System.Drawing.Size(951, 227);
            this.dgvAdjDetail.TabIndex = 74;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // colItemCode
            // 
            this.colItemCode.HeaderText = "Item / Code";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.ReadOnly = true;
            this.colItemCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colItemCode.Width = 150;
            // 
            // colSalePrice
            // 
            this.colSalePrice.HeaderText = "Price";
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.ReadOnly = true;
            this.colSalePrice.Width = 150;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 50;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 150;
            // 
            // colFOC
            // 
            this.colFOC.HeaderText = "Remark";
            this.colFOC.Name = "colFOC";
            this.colFOC.ReadOnly = true;
            this.colFOC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFOC.Width = 170;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MoeYanPOS.Properties.Resources.titlebar;
            this.panel1.Controls.Add(this.picClose1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 38);
            this.panel1.TabIndex = 75;
            // 
            // picClose1
            // 
            this.picClose1.BackColor = System.Drawing.Color.Transparent;
            this.picClose1.BackgroundImage = global::MoeYanPOS.Properties.Resources.test3;
            this.picClose1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picClose1.Image = global::MoeYanPOS.Properties.Resources.close3;
            this.picClose1.Location = new System.Drawing.Point(921, 0);
            this.picClose1.Name = "picClose1";
            this.picClose1.Size = new System.Drawing.Size(34, 34);
            this.picClose1.TabIndex = 2;
            this.picClose1.TabStop = false;
            this.picClose1.Click += new System.EventHandler(this.picClose1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stock Adjustment History";
            // 
            // btnAdjustmentReport
            // 
            this.btnAdjustmentReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdjustmentReport.BackgroundImage")));
            this.btnAdjustmentReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdjustmentReport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdjustmentReport.ForeColor = System.Drawing.Color.White;
            this.btnAdjustmentReport.Location = new System.Drawing.Point(851, 79);
            this.btnAdjustmentReport.Name = "btnAdjustmentReport";
            this.btnAdjustmentReport.Size = new System.Drawing.Size(100, 32);
            this.btnAdjustmentReport.TabIndex = 64;
            this.btnAdjustmentReport.Text = "&Report";
            this.btnAdjustmentReport.UseVisualStyleBackColor = true;
            this.btnAdjustmentReport.Click += new System.EventHandler(this.btnAdjustmentReport_Click);
            // 
            // btnAdjustmentDetailReport
            // 
            this.btnAdjustmentDetailReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdjustmentDetailReport.BackgroundImage")));
            this.btnAdjustmentDetailReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdjustmentDetailReport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdjustmentDetailReport.ForeColor = System.Drawing.Color.White;
            this.btnAdjustmentDetailReport.Location = new System.Drawing.Point(851, 114);
            this.btnAdjustmentDetailReport.Name = "btnAdjustmentDetailReport";
            this.btnAdjustmentDetailReport.Size = new System.Drawing.Size(100, 30);
            this.btnAdjustmentDetailReport.TabIndex = 65;
            this.btnAdjustmentDetailReport.Text = "&Detail ";
            this.btnAdjustmentDetailReport.UseVisualStyleBackColor = true;
            this.btnAdjustmentDetailReport.Click += new System.EventHandler(this.btnAdjustmentDetailReport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(851, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dgvItemCode);
            this.panel3.Controls.Add(this.dgvAdjustment);
            this.panel3.Location = new System.Drawing.Point(0, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 427);
            this.panel3.TabIndex = 80;
            // 
            // frmAdjustmentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAdjDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.btnAdjustmentReport);
            this.Controls.Add(this.btnAdjustmentDetailReport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdjustmentHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdjustmentHistory";
            this.Load += new System.EventHandler(this.frmAdjustmentHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjustment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboHeader;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.DataGridView dgvItemCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvAdjustment;
        private System.Windows.Forms.Button btnAdjustmentReport;
        private System.Windows.Forms.Button btnAdjustmentDetailReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblAdjustmentHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAdjDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameInEng;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameInMM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.PictureBox picClose1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFOC;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboLocation;
    }
}