namespace SupermarketHorta_mvp.Views
{
    partial class PayModeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayModeView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePayModeList = new System.Windows.Forms.TabPage();
            this.tabPagePayModeDetail = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgPayMode = new System.Windows.Forms.DataGridView();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPayModeId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPayModeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPayModeObservation = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPagePayModeList.SuspendLayout();
            this.tabPagePayModeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayMode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 172);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(252, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pay Mode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SupermarketHorta_mvp.Properties.Resources.buy;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePayModeList);
            this.tabControl1.Controls.Add(this.tabPagePayModeDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 172);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1286, 500);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            this.tabPagePayModeList.Controls.Add(this.BtnClose);
            this.tabPagePayModeList.Controls.Add(this.BtnDelete);
            this.tabPagePayModeList.Controls.Add(this.BtnEdit);
            this.tabPagePayModeList.Controls.Add(this.BtnNew);
            this.tabPagePayModeList.Controls.Add(this.DgPayMode);
            this.tabPagePayModeList.Controls.Add(this.BtnSearch);
            this.tabPagePayModeList.Controls.Add(this.TxtSearch);
            this.tabPagePayModeList.Controls.Add(this.label2);
            this.tabPagePayModeList.Location = new System.Drawing.Point(4, 34);
            this.tabPagePayModeList.Name = "tabPagePayModeList";
            this.tabPagePayModeList.Size = new System.Drawing.Size(1278, 462);
            this.tabPagePayModeList.TabIndex = 0;
            this.tabPagePayModeList.Text = "Pay Mode List";
            this.tabPagePayModeList.UseVisualStyleBackColor = true;
            this.tabPagePayModeList.Click += new System.EventHandler(this.tabPagePayModeList_Click);
            // 
            // tabPagePayModeDetail
            // 
            this.tabPagePayModeDetail.Controls.Add(this.BtnCancel);
            this.tabPagePayModeDetail.Controls.Add(this.BtnSave);
            this.tabPagePayModeDetail.Controls.Add(this.TxtPayModeObservation);
            this.tabPagePayModeDetail.Controls.Add(this.label5);
            this.tabPagePayModeDetail.Controls.Add(this.TxtPayModeName);
            this.tabPagePayModeDetail.Controls.Add(this.label4);
            this.tabPagePayModeDetail.Controls.Add(this.TxtPayModeId);
            this.tabPagePayModeDetail.Controls.Add(this.label3);
            this.tabPagePayModeDetail.Location = new System.Drawing.Point(4, 34);
            this.tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            this.tabPagePayModeDetail.Size = new System.Drawing.Size(1278, 462);
            this.tabPagePayModeDetail.TabIndex = 1;
            this.tabPagePayModeDetail.Text = "Pay Mode Detail";
            this.tabPagePayModeDetail.UseVisualStyleBackColor = true;
            this.tabPagePayModeDetail.Click += new System.EventHandler(this.tabPagePayModeDetail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Pay Mode";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(8, 46);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "Data to Search";
            this.TxtSearch.Size = new System.Drawing.Size(785, 31);
            this.TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(799, 38);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(54, 55);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            this.DgPayMode.AllowUserToAddRows = false;
            this.DgPayMode.AllowUserToDeleteRows = false;
            this.DgPayMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPayMode.Location = new System.Drawing.Point(8, 99);
            this.DgPayMode.Name = "DgPayMode";
            this.DgPayMode.ReadOnly = true;
            this.DgPayMode.RowHeadersWidth = 62;
            this.DgPayMode.RowTemplate.Height = 33;
            this.DgPayMode.Size = new System.Drawing.Size(892, 355);
            this.DgPayMode.TabIndex = 3;
            // 
            // BtnNew
            // 
            this.BtnNew.BackColor = System.Drawing.Color.Gray;
            this.BtnNew.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnNew.Image = global::SupermarketHorta_mvp.Properties.Resources._new;
            this.BtnNew.Location = new System.Drawing.Point(906, 99);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(353, 83);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Gray;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(906, 188);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(353, 83);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Gray;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(906, 277);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(353, 83);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Gray;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(906, 366);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(353, 83);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pay Mode Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtPayModeId
            // 
            this.TxtPayModeId.BackColor = System.Drawing.SystemColors.Window;
            this.TxtPayModeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPayModeId.Location = new System.Drawing.Point(29, 51);
            this.TxtPayModeId.Name = "TxtPayModeId";
            this.TxtPayModeId.Size = new System.Drawing.Size(209, 31);
            this.TxtPayModeId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pay Mode Name";
            // 
            // TxtPayModeName
            // 
            this.TxtPayModeName.BackColor = System.Drawing.SystemColors.Window;
            this.TxtPayModeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPayModeName.Location = new System.Drawing.Point(29, 143);
            this.TxtPayModeName.Name = "TxtPayModeName";
            this.TxtPayModeName.PlaceholderText = "Pay Mode Name";
            this.TxtPayModeName.Size = new System.Drawing.Size(320, 31);
            this.TxtPayModeName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pay Mode Observation";
            // 
            // TxtPayModeObservation
            // 
            this.TxtPayModeObservation.BackColor = System.Drawing.SystemColors.Window;
            this.TxtPayModeObservation.Location = new System.Drawing.Point(29, 237);
            this.TxtPayModeObservation.Multiline = true;
            this.TxtPayModeObservation.Name = "TxtPayModeObservation";
            this.TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            this.TxtPayModeObservation.Size = new System.Drawing.Size(410, 106);
            this.TxtPayModeObservation.TabIndex = 5;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Gray;
            this.BtnSave.Image = global::SupermarketHorta_mvp.Properties.Resources.save;
            this.BtnSave.Location = new System.Drawing.Point(29, 372);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 73);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Gray;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(175, 372);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(112, 73);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // PayModeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 672);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "PayModeView";
            this.Text = "Pay Mode Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePayModeList.ResumeLayout(false);
            this.tabPagePayModeList.PerformLayout();
            this.tabPagePayModeDetail.ResumeLayout(false);
            this.tabPagePayModeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayMode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private DataGridView DgPayMode;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label label3;
        private TextBox TxtPayModeId;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private TextBox TxtPayModeName;
        private Label label4;
    }
}