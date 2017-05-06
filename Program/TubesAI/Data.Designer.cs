namespace TubesAI
{
    partial class Data
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Jenis_Beasiswa");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("IPK");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Prestasi");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Financial");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Aktif Anggota");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Gain", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("BBM");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("PPA");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("JenisBeasiswa", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("A");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("B");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("C");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("D");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("E");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("IPK", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Ketua");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Pengurus");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Anggota");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("AktifOrganisasi", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49,
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("A");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("B");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("C");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("D");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("E");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Financial", new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55,
            treeNode56});
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Internasional");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Nasional");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Regional");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Lokal");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Prestasi", new System.Windows.Forms.TreeNode[] {
            treeNode58,
            treeNode59,
            treeNode60,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Semesta");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Entropy", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode47,
            treeNode51,
            treeNode57,
            treeNode62,
            treeNode63});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            this.sqlScript = new System.Windows.Forms.RichTextBox();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.InputData = new System.Windows.Forms.DataGridView();
            this.NPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jenis_Beasiswa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktif_Organisasi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Financial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prestasi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Diterima = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Algoritm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExecuteQuery = new System.Windows.Forms.ToolTip(this.components);
            this.Import = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.Newcmd = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.ClearData = new System.Windows.Forms.Button();
            this.AddData = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ExecuteSQL = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SaveSQL = new System.Windows.Forms.SaveFileDialog();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MusicLabel = new System.Windows.Forms.Label();
            this.AddDataLabel = new System.Windows.Forms.Label();
            this.SQLScriptLabel = new System.Windows.Forms.Label();
            this.Judul_lagu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlScript
            // 
            this.sqlScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.sqlScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sqlScript.DetectUrls = false;
            this.sqlScript.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlScript.ForeColor = System.Drawing.SystemColors.Menu;
            this.sqlScript.Location = new System.Drawing.Point(506, 44);
            this.sqlScript.MinimumSize = new System.Drawing.Size(0, 187);
            this.sqlScript.Name = "sqlScript";
            this.sqlScript.Size = new System.Drawing.Size(433, 187);
            this.sqlScript.TabIndex = 1;
            this.sqlScript.Text = "";
            this.sqlScript.WordWrap = false;
            this.sqlScript.TextChanged += new System.EventHandler(this.sqlScript_TextChanged);
            // 
            // DataView
            // 
            this.DataView.AllowUserToOrderColumns = true;
            this.DataView.AllowUserToResizeRows = false;
            this.DataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.DataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataView.ColumnHeadersHeight = 27;
            this.DataView.EnableHeadersVisualStyles = false;
            this.DataView.Location = new System.Drawing.Point(506, 232);
            this.DataView.Name = "DataView";
            this.DataView.ReadOnly = true;
            this.DataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataView.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.DataView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataView.Size = new System.Drawing.Size(433, 443);
            this.DataView.TabIndex = 11;
            this.DataView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataView_MouseClick);
            // 
            // InputData
            // 
            this.InputData.AllowUserToResizeRows = false;
            this.InputData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InputData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InputData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.InputData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InputData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.NullValue = "-";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InputData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.InputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NPM,
            this.Nama,
            this.Jenis_Beasiswa,
            this.IPK,
            this.Aktif_Organisasi,
            this.Financial,
            this.Prestasi,
            this.Diterima});
            this.InputData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.InputData.EnableHeadersVisualStyles = false;
            this.InputData.Location = new System.Drawing.Point(0, 44);
            this.InputData.Name = "InputData";
            this.InputData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InputData.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InputData.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.InputData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InputData.Size = new System.Drawing.Size(505, 631);
            this.InputData.TabIndex = 11;
            this.InputData.DataSourceChanged += new System.EventHandler(this.InputData_DataSourceChanged);
            this.InputData.Click += new System.EventHandler(this.InputData_Click);
            // 
            // NPM
            // 
            this.NPM.DataPropertyName = "NPM";
            this.NPM.HeaderText = "NPM";
            this.NPM.MaxInputLength = 9;
            this.NPM.Name = "NPM";
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.MaxInputLength = 50;
            this.Nama.Name = "Nama";
            // 
            // Jenis_Beasiswa
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.Jenis_Beasiswa.DefaultCellStyle = dataGridViewCellStyle10;
            this.Jenis_Beasiswa.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Jenis_Beasiswa.DisplayStyleForCurrentCellOnly = true;
            this.Jenis_Beasiswa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Jenis_Beasiswa.HeaderText = "Jenis Beasiswa";
            this.Jenis_Beasiswa.Items.AddRange(new object[] {
            " ",
            "BBM",
            "PPA"});
            this.Jenis_Beasiswa.Name = "Jenis_Beasiswa";
            this.Jenis_Beasiswa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Jenis_Beasiswa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IPK
            // 
            this.IPK.HeaderText = "IPK";
            this.IPK.MaxInputLength = 4;
            this.IPK.Name = "IPK";
            // 
            // Aktif_Organisasi
            // 
            this.Aktif_Organisasi.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Aktif_Organisasi.DisplayStyleForCurrentCellOnly = true;
            this.Aktif_Organisasi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Aktif_Organisasi.HeaderText = "Aktif Organisasi";
            this.Aktif_Organisasi.Items.AddRange(new object[] {
            "  ",
            "Ketua",
            "Anggota",
            "Pengurus"});
            this.Aktif_Organisasi.Name = "Aktif_Organisasi";
            this.Aktif_Organisasi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Financial
            // 
            this.Financial.HeaderText = "Financial";
            this.Financial.MaxInputLength = 10;
            this.Financial.Name = "Financial";
            // 
            // Prestasi
            // 
            this.Prestasi.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Prestasi.DisplayStyleForCurrentCellOnly = true;
            this.Prestasi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Prestasi.HeaderText = "Prestasi";
            this.Prestasi.Items.AddRange(new object[] {
            "-",
            "Internasional",
            "Nasional",
            "Regional",
            "Lokal"});
            this.Prestasi.Name = "Prestasi";
            this.Prestasi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Diterima
            // 
            this.Diterima.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Diterima.DisplayStyleForCurrentCellOnly = true;
            this.Diterima.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Diterima.HeaderText = "Diterima";
            this.Diterima.Items.AddRange(new object[] {
            "-",
            "Ya",
            "Tidak"});
            this.Diterima.Name = "Diterima";
            this.Diterima.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Diterima.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Algoritm
            // 
            this.Algoritm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Algoritm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Algoritm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Algoritm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Algoritm.ForeColor = System.Drawing.Color.White;
            this.Algoritm.FormattingEnabled = true;
            this.Algoritm.Items.AddRange(new object[] {
            "Insert To Database",
            "Decision Tree -> Insert To Database"});
            this.Algoritm.Location = new System.Drawing.Point(71, 14);
            this.Algoritm.Name = "Algoritm";
            this.Algoritm.Size = new System.Drawing.Size(199, 23);
            this.Algoritm.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Algoritm";
            // 
            // ExecuteQuery
            // 
            this.ExecuteQuery.BackColor = System.Drawing.SystemColors.GrayText;
            this.ExecuteQuery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExecuteQuery.IsBalloon = true;
            // 
            // Import
            // 
            this.Import.FlatAppearance.BorderSize = 0;
            this.Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Import.Image = global::TubesAI.Properties.Resources.import;
            this.Import.Location = new System.Drawing.Point(609, 16);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(22, 22);
            this.Import.TabIndex = 26;
            this.ExecuteQuery.SetToolTip(this.Import, "Import Sql File");
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Export
            // 
            this.Export.FlatAppearance.BorderSize = 0;
            this.Export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Export.Image = global::TubesAI.Properties.Resources.export;
            this.Export.Location = new System.Drawing.Point(584, 16);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(22, 22);
            this.Export.TabIndex = 25;
            this.ExecuteQuery.SetToolTip(this.Export, "ExportDatabases");
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Log.FlatAppearance.BorderSize = 0;
            this.Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log.Image = global::TubesAI.Properties.Resources.log;
            this.Log.Location = new System.Drawing.Point(392, 13);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(21, 23);
            this.Log.TabIndex = 21;
            this.ExecuteQuery.SetToolTip(this.Log, "Log View");
            this.Log.UseVisualStyleBackColor = false;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // Newcmd
            // 
            this.Newcmd.FlatAppearance.BorderSize = 0;
            this.Newcmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Newcmd.Image = global::TubesAI.Properties.Resources.cmd;
            this.Newcmd.Location = new System.Drawing.Point(358, 14);
            this.Newcmd.Name = "Newcmd";
            this.Newcmd.Size = new System.Drawing.Size(24, 23);
            this.Newcmd.TabIndex = 20;
            this.ExecuteQuery.SetToolTip(this.Newcmd, "SQL Command");
            this.Newcmd.UseVisualStyleBackColor = true;
            this.Newcmd.Click += new System.EventHandler(this.Newcmd_Click);
            // 
            // Refresh
            // 
            this.Refresh.FlatAppearance.BorderSize = 0;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Image = global::TubesAI.Properties.Resources.icon_refresh_128;
            this.Refresh.Location = new System.Drawing.Point(560, 16);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(22, 22);
            this.Refresh.TabIndex = 18;
            this.ExecuteQuery.SetToolTip(this.Refresh, "Refresh Table Beasiswa");
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ClearData
            // 
            this.ClearData.FlatAppearance.BorderSize = 0;
            this.ClearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearData.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearData.ForeColor = System.Drawing.Color.White;
            this.ClearData.Image = global::TubesAI.Properties.Resources.clear;
            this.ClearData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearData.Location = new System.Drawing.Point(313, 14);
            this.ClearData.Name = "ClearData";
            this.ClearData.Size = new System.Drawing.Size(42, 23);
            this.ClearData.TabIndex = 17;
            this.ExecuteQuery.SetToolTip(this.ClearData, "Clear Input Data");
            this.ClearData.UseVisualStyleBackColor = true;
            this.ClearData.Click += new System.EventHandler(this.ClearData_Click);
            // 
            // AddData
            // 
            this.AddData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddData.FlatAppearance.BorderSize = 0;
            this.AddData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddData.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddData.ForeColor = System.Drawing.Color.White;
            this.AddData.Image = global::TubesAI.Properties.Resources.add;
            this.AddData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddData.Location = new System.Drawing.Point(282, 14);
            this.AddData.Name = "AddData";
            this.AddData.Size = new System.Drawing.Size(28, 23);
            this.AddData.TabIndex = 13;
            this.ExecuteQuery.SetToolTip(this.AddData, "Run");
            this.AddData.UseVisualStyleBackColor = false;
            this.AddData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Image = global::TubesAI.Properties.Resources.Delete;
            this.Clear.Location = new System.Drawing.Point(532, 16);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(22, 22);
            this.Clear.TabIndex = 6;
            this.ExecuteQuery.SetToolTip(this.Clear, "Clear SQL Script");
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ExecuteSQL
            // 
            this.ExecuteSQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExecuteSQL.FlatAppearance.BorderSize = 0;
            this.ExecuteSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteSQL.Image = global::TubesAI.Properties.Resources.execute;
            this.ExecuteSQL.Location = new System.Drawing.Point(505, 16);
            this.ExecuteSQL.Name = "ExecuteSQL";
            this.ExecuteSQL.Size = new System.Drawing.Size(22, 22);
            this.ExecuteSQL.TabIndex = 2;
            this.ExecuteQuery.SetToolTip(this.ExecuteSQL, "Execute SQL Script");
            this.ExecuteSQL.UseVisualStyleBackColor = false;
            this.ExecuteSQL.Click += new System.EventHandler(this.ExecuteSQL_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.contextMenuStrip1.DropShadowEnabled = false;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditMenu,
            this.DeleteMenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // EditMenu
            // 
            this.EditMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EditMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditMenu.Image = global::TubesAI.Properties.Resources.edit;
            this.EditMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(107, 22);
            this.EditMenu.Text = "Edit";
            this.EditMenu.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.EditMenu.Click += new System.EventHandler(this.EditMenu_Click);
            // 
            // DeleteMenu
            // 
            this.DeleteMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DeleteMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteMenu.Image = global::TubesAI.Properties.Resources.Delete;
            this.DeleteMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteMenu.Name = "DeleteMenu";
            this.DeleteMenu.Size = new System.Drawing.Size(107, 22);
            this.DeleteMenu.Text = "Delete";
            this.DeleteMenu.Click += new System.EventHandler(this.DeleteMenu_Click);
            // 
            // tree
            // 
            this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tree.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tree.ImageIndex = 0;
            this.tree.ImageList = this.imageList1;
            this.tree.Indent = 20;
            this.tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tree.Location = new System.Drawing.Point(940, 76);
            this.tree.Name = "tree";
            treeNode33.Name = "Gain_1";
            treeNode33.Text = "Jenis_Beasiswa";
            treeNode34.Name = "gain_2";
            treeNode34.Text = "IPK";
            treeNode35.Name = "gain_3";
            treeNode35.Text = "Prestasi";
            treeNode36.Name = "gain_4";
            treeNode36.Text = "Financial";
            treeNode37.Name = "gain_5";
            treeNode37.Text = "Aktif Anggota";
            treeNode38.Name = "Gain";
            treeNode38.Text = "Gain";
            treeNode39.Name = "BBM";
            treeNode39.Text = "BBM";
            treeNode40.Name = "PPA";
            treeNode40.Text = "PPA";
            treeNode41.Name = "JenisBeasiswa";
            treeNode41.Text = "JenisBeasiswa";
            treeNode42.Name = "A";
            treeNode42.Text = "A";
            treeNode43.Name = "B";
            treeNode43.Text = "B";
            treeNode44.Name = "C";
            treeNode44.Text = "C";
            treeNode45.Name = "D";
            treeNode45.Text = "D";
            treeNode46.Name = "E";
            treeNode46.Text = "E";
            treeNode47.Name = "IPK";
            treeNode47.Text = "IPK";
            treeNode48.Name = "Ketua";
            treeNode48.Text = "Ketua";
            treeNode49.Name = "Pengurus";
            treeNode49.Text = "Pengurus";
            treeNode50.Name = "Anggota";
            treeNode50.Text = "Anggota";
            treeNode51.Name = "AktifOrganisasi";
            treeNode51.Text = "AktifOrganisasi";
            treeNode52.Name = "A";
            treeNode52.Text = "A";
            treeNode53.Name = "B";
            treeNode53.Text = "B";
            treeNode54.Name = "C";
            treeNode54.Text = "C";
            treeNode55.Name = "D";
            treeNode55.Text = "D";
            treeNode56.Name = "E";
            treeNode56.Text = "E";
            treeNode57.Name = "Financial";
            treeNode57.Text = "Financial";
            treeNode58.Name = "Internasional";
            treeNode58.Text = "Internasional";
            treeNode59.Name = "Nasional";
            treeNode59.Text = "Nasional";
            treeNode60.Name = "Regional";
            treeNode60.Text = "Regional";
            treeNode61.Name = "Lokal";
            treeNode61.Text = "Lokal";
            treeNode62.Name = "Prestasi";
            treeNode62.Text = "Prestasi";
            treeNode63.Name = "Semesta";
            treeNode63.Text = "Semesta";
            treeNode64.Name = "Entropy";
            treeNode64.Text = "Entropy";
            this.tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode64});
            this.tree.SelectedImageIndex = 0;
            this.tree.Size = new System.Drawing.Size(264, 599);
            this.tree.TabIndex = 23;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "variabel.png");
            // 
            // SaveSQL
            // 
            this.SaveSQL.FileName = "Data";
            this.SaveSQL.Filter = ".sql|*.sql|All files|*.*";
            // 
            // OpenFile
            // 
            this.OpenFile.Filter = ".sql|*.sql|All files|*.*";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(833, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 31;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Previous
            // 
            this.Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Previous.FlatAppearance.BorderSize = 0;
            this.Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous.Image = global::TubesAI.Properties.Resources.previous;
            this.Previous.Location = new System.Drawing.Point(789, 9);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(35, 23);
            this.Previous.TabIndex = 30;
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Image = global::TubesAI.Properties.Resources.next;
            this.Next.Location = new System.Drawing.Point(900, 9);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(32, 23);
            this.Next.TabIndex = 29;
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Image = global::TubesAI.Properties.Resources.stop;
            this.Stop.Location = new System.Drawing.Point(860, 9);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(33, 23);
            this.Stop.TabIndex = 28;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::TubesAI.Properties.Resources.icon_refresh_128;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(940, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "Variabel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MusicLabel
            // 
            this.MusicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicLabel.AutoSize = true;
            this.MusicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MusicLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MusicLabel.Image = global::TubesAI.Properties.Resources.Music;
            this.MusicLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MusicLabel.Location = new System.Drawing.Point(1168, 8);
            this.MusicLabel.MinimumSize = new System.Drawing.Size(0, 30);
            this.MusicLabel.Name = "MusicLabel";
            this.MusicLabel.Size = new System.Drawing.Size(28, 30);
            this.MusicLabel.TabIndex = 19;
            this.MusicLabel.Text = "       ";
            this.MusicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MusicLabel.Click += new System.EventHandler(this.MusicLabel_Click);
            // 
            // AddDataLabel
            // 
            this.AddDataLabel.AutoSize = true;
            this.AddDataLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.AddDataLabel.Font = new System.Drawing.Font("Microsoft JhengHei Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDataLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.AddDataLabel.Image = global::TubesAI.Properties.Resources.edit;
            this.AddDataLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDataLabel.Location = new System.Drawing.Point(117, 333);
            this.AddDataLabel.MinimumSize = new System.Drawing.Size(277, 100);
            this.AddDataLabel.Name = "AddDataLabel";
            this.AddDataLabel.Size = new System.Drawing.Size(277, 100);
            this.AddDataLabel.TabIndex = 16;
            this.AddDataLabel.Text = "       Add Data";
            this.AddDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SQLScriptLabel
            // 
            this.SQLScriptLabel.AutoSize = true;
            this.SQLScriptLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SQLScriptLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQLScriptLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.SQLScriptLabel.Image = global::TubesAI.Properties.Resources.mysql;
            this.SQLScriptLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SQLScriptLabel.Location = new System.Drawing.Point(617, 90);
            this.SQLScriptLabel.MinimumSize = new System.Drawing.Size(230, 90);
            this.SQLScriptLabel.Name = "SQLScriptLabel";
            this.SQLScriptLabel.Size = new System.Drawing.Size(230, 90);
            this.SQLScriptLabel.TabIndex = 8;
            this.SQLScriptLabel.Text = "MySQL Script";
            this.SQLScriptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Judul_lagu
            // 
            this.Judul_lagu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Judul_lagu.AutoSize = true;
            this.Judul_lagu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Judul_lagu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judul_lagu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Judul_lagu.Location = new System.Drawing.Point(941, 14);
            this.Judul_lagu.MaximumSize = new System.Drawing.Size(220, 18);
            this.Judul_lagu.Name = "Judul_lagu";
            this.Judul_lagu.Size = new System.Drawing.Size(217, 18);
            this.Judul_lagu.TabIndex = 32;
            this.Judul_lagu.Text = "weweqwssssssssssssssssssssssssssssssssssssssssssssss";
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1205, 675);
            this.Controls.Add(this.Judul_lagu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Newcmd);
            this.Controls.Add(this.MusicLabel);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.ClearData);
            this.Controls.Add(this.AddDataLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Algoritm);
            this.Controls.Add(this.AddData);
            this.Controls.Add(this.InputData);
            this.Controls.Add(this.SQLScriptLabel);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.ExecuteSQL);
            this.Controls.Add(this.sqlScript);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1221, 714);
            this.Name = "Data";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBW 1.0.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Data_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Data_FormClosed);
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox sqlScript;
        private System.Windows.Forms.Button ExecuteSQL;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label SQLScriptLabel;
        private System.Windows.Forms.Button AddData;
        public System.Windows.Forms.DataGridView InputData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AddDataLabel;
        public System.Windows.Forms.ComboBox Algoritm;
        private System.Windows.Forms.ToolTip ExecuteQuery;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenu;
        public System.Windows.Forms.DataGridView DataView;
        public System.Windows.Forms.Button Refresh;
        public System.Windows.Forms.Button ClearData;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label MusicLabel;
        private System.Windows.Forms.Button Newcmd;
        public System.Windows.Forms.Button Log;
        public System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Export;
        public System.Windows.Forms.SaveFileDialog SaveSQL;
        public System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewComboBoxColumn Jenis_Beasiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPK;
        private System.Windows.Forms.DataGridViewComboBoxColumn Aktif_Organisasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Financial;
        private System.Windows.Forms.DataGridViewComboBoxColumn Prestasi;
        private System.Windows.Forms.DataGridViewComboBoxColumn Diterima;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label Judul_lagu;
    }
}