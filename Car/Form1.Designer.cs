namespace Car
{
    partial class Form1
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
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtTopSpeed = new System.Windows.Forms.TextBox();
            this.txtTurbo = new System.Windows.Forms.TextBox();
            this.txtHorsePower = new System.Windows.Forms.TextBox();
            this.txtTransmission = new System.Windows.Forms.TextBox();
            this.txtEngineDisplacement = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.testDataSet = new Car.TestDataSet();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new Car.TestDataSetTableAdapters.CarTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ddMenuManufacturer = new System.Windows.Forms.ComboBox();
            this.carBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbYesNo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCarName
            // 
            this.txtCarName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCarName.Location = new System.Drawing.Point(68, 22);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(168, 25);
            this.txtCarName.TabIndex = 0;
            // 
            // txtTopSpeed
            // 
            this.txtTopSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTopSpeed.Location = new System.Drawing.Point(68, 400);
            this.txtTopSpeed.Name = "txtTopSpeed";
            this.txtTopSpeed.Size = new System.Drawing.Size(168, 25);
            this.txtTopSpeed.TabIndex = 7;
            // 
            // txtTurbo
            // 
            this.txtTurbo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTurbo.Location = new System.Drawing.Point(68, 347);
            this.txtTurbo.Name = "txtTurbo";
            this.txtTurbo.Size = new System.Drawing.Size(168, 25);
            this.txtTurbo.TabIndex = 6;
            // 
            // txtHorsePower
            // 
            this.txtHorsePower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHorsePower.Location = new System.Drawing.Point(68, 295);
            this.txtHorsePower.Name = "txtHorsePower";
            this.txtHorsePower.Size = new System.Drawing.Size(168, 25);
            this.txtHorsePower.TabIndex = 5;
            // 
            // txtTransmission
            // 
            this.txtTransmission.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTransmission.Location = new System.Drawing.Point(68, 242);
            this.txtTransmission.Name = "txtTransmission";
            this.txtTransmission.Size = new System.Drawing.Size(168, 25);
            this.txtTransmission.TabIndex = 4;
            // 
            // txtEngineDisplacement
            // 
            this.txtEngineDisplacement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEngineDisplacement.Location = new System.Drawing.Point(68, 185);
            this.txtEngineDisplacement.Name = "txtEngineDisplacement";
            this.txtEngineDisplacement.Size = new System.Drawing.Size(168, 25);
            this.txtEngineDisplacement.TabIndex = 3;
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCountry.Location = new System.Drawing.Point(68, 131);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(168, 25);
            this.txtCountry.TabIndex = 2;
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSeatNumber.Location = new System.Drawing.Point(68, 451);
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.Size = new System.Drawing.Size(168, 25);
            this.txtSeatNumber.TabIndex = 8;
            // 
            // dgvCar
            // 
            this.dgvCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar.Location = new System.Drawing.Point(303, 76);
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.ReadOnly = true;
            this.dgvCar.RowTemplate.Height = 27;
            this.dgvCar.Size = new System.Drawing.Size(1018, 349);
            this.dgvCar.TabIndex = 9;
            this.dgvCar.DoubleClick += new System.EventHandler(this.dgvCar_DoubleClick);
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.testDataSet;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(325, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Location = new System.Drawing.Point(676, 453);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(501, 453);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.Location = new System.Drawing.Point(303, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(520, 25);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(861, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "車名";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "廠商";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "原產國";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "排氣量";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "排檔";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "馬力";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "渦輪";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "載客數";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "極速";
            // 
            // ddMenuManufacturer
            // 
            this.ddMenuManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ddMenuManufacturer.FormattingEnabled = true;
            this.ddMenuManufacturer.Location = new System.Drawing.Point(68, 76);
            this.ddMenuManufacturer.Name = "ddMenuManufacturer";
            this.ddMenuManufacturer.Size = new System.Drawing.Size(168, 23);
            this.ddMenuManufacturer.TabIndex = 1;
            // 
            // carBindingSource1
            // 
            this.carBindingSource1.DataMember = "Car";
            this.carBindingSource1.DataSource = this.testDataSet;
            // 
            // cbYesNo
            // 
            this.cbYesNo.FormattingEnabled = true;
            this.cbYesNo.Location = new System.Drawing.Point(1029, 22);
            this.cbYesNo.Name = "cbYesNo";
            this.cbYesNo.Size = new System.Drawing.Size(163, 23);
            this.cbYesNo.TabIndex = 24;
            this.cbYesNo.SelectedIndexChanged += new System.EventHandler(this.cbYesNo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(250, 500);
            this.ClientSize = new System.Drawing.Size(1390, 508);
            this.Controls.Add(this.cbYesNo);
            this.Controls.Add(this.ddMenuManufacturer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvCar);
            this.Controls.Add(this.txtSeatNumber);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtEngineDisplacement);
            this.Controls.Add(this.txtTransmission);
            this.Controls.Add(this.txtHorsePower);
            this.Controls.Add(this.txtTurbo);
            this.Controls.Add(this.txtTopSpeed);
            this.Controls.Add(this.txtCarName);
            this.Name = "Form1";
            this.Text = "Car data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtTopSpeed;
        private System.Windows.Forms.TextBox txtTurbo;
        private System.Windows.Forms.TextBox txtHorsePower;
        private System.Windows.Forms.TextBox txtTransmission;
        private System.Windows.Forms.TextBox txtEngineDisplacement;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.DataGridView dgvCar;
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private TestDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ddMenuManufacturer;
        private System.Windows.Forms.BindingSource carBindingSource1;
        private System.Windows.Forms.ComboBox cbYesNo;
    }
}

