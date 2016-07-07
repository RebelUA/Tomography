namespace tomography
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabSpeed = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.infADepth = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.infBDepth = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bName = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.bDepth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bY = new System.Windows.Forms.Label();
            this.bX = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.aDepth = new System.Windows.Forms.Label();
            this.aY = new System.Windows.Forms.Label();
            this.aX = new System.Windows.Forms.Label();
            this.aId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.solveBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wellsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hidrohimDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hidrohimDBDataSet = new acoustic.HidrohimDBDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.exactBtn = new System.Windows.Forms.Button();
            this.mapDepthB = new System.Windows.Forms.Label();
            this.mapDepthA = new System.Windows.Forms.Label();
            this.mapDist = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.depthBPanel = new System.Windows.Forms.Panel();
            this.depthAPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.wellsTableAdapter = new acoustic.HidrohimDBDataSetTableAdapters.wellsTableAdapter();
            this.speedsTableAdapter = new acoustic.HidrohimDBDataSetTableAdapters.speedsTableAdapter();
            this.renderer = new nzy3D.Plot3D.Rendering.View.Renderer3D();
            this.renderer3D2 = new nzy3D.Plot3D.Rendering.View.Renderer3D();
            this.tabSpeed.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wellsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidrohimDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidrohimDBDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSpeed
            // 
            this.tabSpeed.Controls.Add(this.tabPage1);
            this.tabSpeed.Controls.Add(this.tabPage2);
            this.tabSpeed.Controls.Add(this.tabPage3);
            this.tabSpeed.Location = new System.Drawing.Point(0, -1);
            this.tabSpeed.Name = "tabSpeed";
            this.tabSpeed.SelectedIndex = 0;
            this.tabSpeed.Size = new System.Drawing.Size(909, 643);
            this.tabSpeed.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.renderer3D2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 617);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(574, 438);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 21);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Optimize";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.infADepth);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.infBDepth);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.distance);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(574, 327);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 104);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Information";
            // 
            // infADepth
            // 
            this.infADepth.AutoSize = true;
            this.infADepth.Location = new System.Drawing.Point(103, 50);
            this.infADepth.Name = "infADepth";
            this.infADepth.Size = new System.Drawing.Size(50, 17);
            this.infADepth.TabIndex = 13;
            this.infADepth.Text = "label10";
            this.infADepth.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "First depth:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Distance:";
            // 
            // infBDepth
            // 
            this.infBDepth.AutoSize = true;
            this.infBDepth.Location = new System.Drawing.Point(103, 75);
            this.infBDepth.Name = "infBDepth";
            this.infBDepth.Size = new System.Drawing.Size(50, 17);
            this.infBDepth.TabIndex = 9;
            this.infBDepth.Text = "label10";
            this.infBDepth.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Second Depth:";
            // 
            // distance
            // 
            this.distance.AutoSize = true;
            this.distance.Location = new System.Drawing.Point(103, 27);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(43, 17);
            this.distance.TabIndex = 8;
            this.distance.Text = "label9";
            this.distance.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bName);
            this.groupBox3.Controls.Add(this.label66);
            this.groupBox3.Controls.Add(this.bDepth);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.bY);
            this.groupBox3.Controls.Add(this.bX);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.bId);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(576, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 154);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Second well";
            // 
            // bName
            // 
            this.bName.AutoSize = true;
            this.bName.Location = new System.Drawing.Point(103, 50);
            this.bName.Name = "bName";
            this.bName.Size = new System.Drawing.Size(50, 17);
            this.bName.TabIndex = 13;
            this.bName.Text = "label10";
            this.bName.Visible = false;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(9, 49);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(46, 17);
            this.label66.TabIndex = 12;
            this.label66.Text = "Name:";
            // 
            // bDepth
            // 
            this.bDepth.AutoSize = true;
            this.bDepth.Location = new System.Drawing.Point(103, 125);
            this.bDepth.Name = "bDepth";
            this.bDepth.Size = new System.Drawing.Size(50, 17);
            this.bDepth.TabIndex = 11;
            this.bDepth.Text = "label12";
            this.bDepth.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID:";
            // 
            // bY
            // 
            this.bY.AutoSize = true;
            this.bY.Location = new System.Drawing.Point(103, 100);
            this.bY.Name = "bY";
            this.bY.Size = new System.Drawing.Size(50, 17);
            this.bY.TabIndex = 10;
            this.bY.Text = "label11";
            this.bY.Visible = false;
            // 
            // bX
            // 
            this.bX.AutoSize = true;
            this.bX.Location = new System.Drawing.Point(103, 75);
            this.bX.Name = "bX";
            this.bX.Size = new System.Drawing.Size(50, 17);
            this.bX.TabIndex = 9;
            this.bX.Text = "label10";
            this.bX.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Coorditane X:";
            // 
            // bId
            // 
            this.bId.AutoSize = true;
            this.bId.Location = new System.Drawing.Point(103, 27);
            this.bId.Name = "bId";
            this.bId.Size = new System.Drawing.Size(43, 17);
            this.bId.TabIndex = 8;
            this.bId.Text = "label9";
            this.bId.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Depth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Coorditane Y:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.aDepth);
            this.groupBox2.Controls.Add(this.aY);
            this.groupBox2.Controls.Add(this.aX);
            this.groupBox2.Controls.Add(this.aId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(576, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 155);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "First well";
            // 
            // aName
            // 
            this.aName.AutoSize = true;
            this.aName.Location = new System.Drawing.Point(101, 47);
            this.aName.Name = "aName";
            this.aName.Size = new System.Drawing.Size(50, 17);
            this.aName.TabIndex = 9;
            this.aName.Text = "label10";
            this.aName.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Name:";
            // 
            // aDepth
            // 
            this.aDepth.AutoSize = true;
            this.aDepth.Location = new System.Drawing.Point(101, 125);
            this.aDepth.Name = "aDepth";
            this.aDepth.Size = new System.Drawing.Size(50, 17);
            this.aDepth.TabIndex = 7;
            this.aDepth.Text = "label12";
            this.aDepth.Visible = false;
            // 
            // aY
            // 
            this.aY.AutoSize = true;
            this.aY.Location = new System.Drawing.Point(101, 98);
            this.aY.Name = "aY";
            this.aY.Size = new System.Drawing.Size(50, 17);
            this.aY.TabIndex = 6;
            this.aY.Text = "label11";
            this.aY.Visible = false;
            // 
            // aX
            // 
            this.aX.AutoSize = true;
            this.aX.Location = new System.Drawing.Point(101, 72);
            this.aX.Name = "aX";
            this.aX.Size = new System.Drawing.Size(50, 17);
            this.aX.TabIndex = 5;
            this.aX.Text = "label10";
            this.aX.Visible = false;
            // 
            // aId
            // 
            this.aId.AutoSize = true;
            this.aId.Location = new System.Drawing.Point(101, 25);
            this.aId.Name = "aId";
            this.aId.Size = new System.Drawing.Size(43, 17);
            this.aId.TabIndex = 4;
            this.aId.Text = "label9";
            this.aId.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Depth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coorditane Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coorditane X:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.drawButton);
            this.groupBox1.Controls.Add(this.solveBtn);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 603);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wells";
            // 
            // drawButton
            // 
            this.drawButton.Enabled = false;
            this.drawButton.Location = new System.Drawing.Point(453, 558);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(101, 36);
            this.drawButton.TabIndex = 5;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // solveBtn
            // 
            this.solveBtn.Enabled = false;
            this.solveBtn.Location = new System.Drawing.Point(346, 558);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(101, 36);
            this.solveBtn.TabIndex = 4;
            this.solveBtn.Text = "Solve";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Select Second";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.selectSecondButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(6, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select First";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.selectFirstButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.charnameDataGridViewTextBoxColumn,
            this.coordXDataGridViewTextBoxColumn,
            this.coordYDataGridViewTextBoxColumn,
            this.depthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wellsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 527);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // charnameDataGridViewTextBoxColumn
            // 
            this.charnameDataGridViewTextBoxColumn.DataPropertyName = "char_name";
            this.charnameDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.charnameDataGridViewTextBoxColumn.Name = "charnameDataGridViewTextBoxColumn";
            this.charnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coordXDataGridViewTextBoxColumn
            // 
            this.coordXDataGridViewTextBoxColumn.DataPropertyName = "coordX";
            this.coordXDataGridViewTextBoxColumn.HeaderText = "X";
            this.coordXDataGridViewTextBoxColumn.Name = "coordXDataGridViewTextBoxColumn";
            this.coordXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coordYDataGridViewTextBoxColumn
            // 
            this.coordYDataGridViewTextBoxColumn.DataPropertyName = "coordY";
            this.coordYDataGridViewTextBoxColumn.HeaderText = "Y";
            this.coordYDataGridViewTextBoxColumn.Name = "coordYDataGridViewTextBoxColumn";
            this.coordYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depthDataGridViewTextBoxColumn
            // 
            this.depthDataGridViewTextBoxColumn.DataPropertyName = "depth";
            this.depthDataGridViewTextBoxColumn.HeaderText = "DEPTH";
            this.depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            this.depthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wellsBindingSource
            // 
            this.wellsBindingSource.DataMember = "wells";
            this.wellsBindingSource.DataSource = this.hidrohimDBDataSetBindingSource;
            // 
            // hidrohimDBDataSetBindingSource
            // 
            this.hidrohimDBDataSetBindingSource.DataSource = this.hidrohimDBDataSet;
            this.hidrohimDBDataSetBindingSource.Position = 0;
            // 
            // hidrohimDBDataSet
            // 
            this.hidrohimDBDataSet.DataSetName = "HidrohimDBDataSet";
            this.hidrohimDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.renderer);
            this.tabPage2.Controls.Add(this.exactBtn);
            this.tabPage2.Controls.Add(this.mapDepthB);
            this.tabPage2.Controls.Add(this.mapDepthA);
            this.tabPage2.Controls.Add(this.mapDist);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.depthBPanel);
            this.tabPage2.Controls.Add(this.depthAPanel);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 617);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Map";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // exactBtn
            // 
            this.exactBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exactBtn.Location = new System.Drawing.Point(765, 6);
            this.exactBtn.Name = "exactBtn";
            this.exactBtn.Size = new System.Drawing.Size(128, 35);
            this.exactBtn.TabIndex = 9;
            this.exactBtn.Text = "Show Exact Data";
            this.exactBtn.UseVisualStyleBackColor = true;
            this.exactBtn.Visible = false;
            this.exactBtn.Click += new System.EventHandler(this.exactBtn_Click);
            // 
            // mapDepthB
            // 
            this.mapDepthB.AutoSize = true;
            this.mapDepthB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mapDepthB.Location = new System.Drawing.Point(767, 329);
            this.mapDepthB.Name = "mapDepthB";
            this.mapDepthB.Size = new System.Drawing.Size(52, 21);
            this.mapDepthB.TabIndex = 8;
            this.mapDepthB.Text = "label9";
            // 
            // mapDepthA
            // 
            this.mapDepthA.AutoSize = true;
            this.mapDepthA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mapDepthA.Location = new System.Drawing.Point(45, 329);
            this.mapDepthA.Name = "mapDepthA";
            this.mapDepthA.Size = new System.Drawing.Size(52, 21);
            this.mapDepthA.TabIndex = 7;
            this.mapDepthA.Text = "label9";
            // 
            // mapDist
            // 
            this.mapDist.AutoSize = true;
            this.mapDist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mapDist.Location = new System.Drawing.Point(395, 59);
            this.mapDist.Name = "mapDist";
            this.mapDist.Size = new System.Drawing.Size(52, 21);
            this.mapDist.TabIndex = 6;
            this.mapDist.Text = "label9";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(225, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 11);
            this.panel4.TabIndex = 5;
            // 
            // depthBPanel
            // 
            this.depthBPanel.BackColor = System.Drawing.Color.DimGray;
            this.depthBPanel.Location = new System.Drawing.Point(721, 151);
            this.depthBPanel.Name = "depthBPanel";
            this.depthBPanel.Size = new System.Drawing.Size(34, 380);
            this.depthBPanel.TabIndex = 5;
            // 
            // depthAPanel
            // 
            this.depthAPanel.BackColor = System.Drawing.Color.DimGray;
            this.depthAPanel.Location = new System.Drawing.Point(103, 151);
            this.depthAPanel.Name = "depthAPanel";
            this.depthAPanel.Size = new System.Drawing.Size(34, 380);
            this.depthAPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(559, 591);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 18);
            this.panel1.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(901, 617);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Glossary";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(8, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Speed of sound in different materials:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.speedDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.speedsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(444, 323);
            this.dataGridView2.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MaxInputLength = 500;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            this.speedDataGridViewTextBoxColumn.HeaderText = "Speed";
            this.speedDataGridViewTextBoxColumn.MaxInputLength = 500;
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            this.speedDataGridViewTextBoxColumn.ReadOnly = true;
            this.speedDataGridViewTextBoxColumn.Width = 200;
            // 
            // speedsBindingSource
            // 
            this.speedsBindingSource.DataMember = "speeds";
            this.speedsBindingSource.DataSource = this.hidrohimDBDataSetBindingSource;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // wellsTableAdapter
            // 
            this.wellsTableAdapter.ClearBeforeFill = true;
            // 
            // speedsTableAdapter
            // 
            this.speedsTableAdapter.ClearBeforeFill = true;
            // 
            // renderer
            // 
            this.renderer.BackColor = System.Drawing.Color.Black;
            this.renderer.Location = new System.Drawing.Point(225, 151);
            this.renderer.Name = "renderer";
            this.renderer.Size = new System.Drawing.Size(409, 380);
            this.renderer.TabIndex = 10;
            this.renderer.VSync = false;
            // 
            // renderer3D2
            // 
            this.renderer3D2.BackColor = System.Drawing.Color.Black;
            this.renderer3D2.Location = new System.Drawing.Point(695, 460);
            this.renderer3D2.Name = "renderer3D2";
            this.renderer3D2.Size = new System.Drawing.Size(150, 128);
            this.renderer3D2.TabIndex = 2;
            this.renderer3D2.VSync = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(909, 642);
            this.Controls.Add(this.tabSpeed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Tomography";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabSpeed.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wellsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidrohimDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidrohimDBDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabSpeed;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource hidrohimDBDataSetBindingSource;
        private acoustic.HidrohimDBDataSet hidrohimDBDataSet;
        private System.Windows.Forms.BindingSource wellsBindingSource;
        private acoustic.HidrohimDBDataSetTableAdapters.wellsTableAdapter wellsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aDepth;
        private System.Windows.Forms.Label aY;
        private System.Windows.Forms.Label aX;
        private System.Windows.Forms.Label aId;
        private System.Windows.Forms.Label bDepth;
        private System.Windows.Forms.Label bY;
        private System.Windows.Forms.Label bX;
        private System.Windows.Forms.Label bId;
        private System.Windows.Forms.Label aName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label bName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label infADepth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label infBDepth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label distance;
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel depthBPanel;
        private System.Windows.Forms.Panel depthAPanel;
        private System.Windows.Forms.Label mapDist;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label mapDepthB;
        private System.Windows.Forms.Label mapDepthA;
        private System.Windows.Forms.Button exactBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.BindingSource speedsBindingSource;
        private acoustic.HidrohimDBDataSetTableAdapters.speedsTableAdapter speedsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private nzy3D.Plot3D.Rendering.View.Renderer3D renderer;
        private nzy3D.Plot3D.Rendering.View.Renderer3D renderer3D2;
    }
}