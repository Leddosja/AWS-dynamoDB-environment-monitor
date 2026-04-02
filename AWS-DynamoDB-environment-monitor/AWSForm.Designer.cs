namespace AWS_DynamoDB___Monitoraggio_ambientale
{
    partial class AWSForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInsertTable = new System.Windows.Forms.Button();
            this.buttonInsertData = new System.Windows.Forms.Button();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.textBoxHumidity = new System.Windows.Forms.TextBox();
            this.comboTableNames = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSensore = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLuogo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboSortType = new System.Windows.Forms.ComboBox();
            this.comboPartitionType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSortKey = new System.Windows.Forms.TextBox();
            this.txtPartitionKey = new System.Windows.Forms.TextBox();
            this.txtNomeTabella = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnStampaTutto = new System.Windows.Forms.Button();
            this.dataGridInfo = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIntervalloSensore = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboSensoreScelto = new System.Windows.Forms.ComboBox();
            this.datePickerFine = new System.Windows.Forms.DateTimePicker();
            this.datePickerInizio = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.datePickerDelete = new System.Windows.Forms.DateTimePicker();
            this.comboSensoreDelete = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.comboLuogoDelete = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInsertTable
            // 
            this.buttonInsertTable.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonInsertTable.Location = new System.Drawing.Point(44, 286);
            this.buttonInsertTable.Name = "buttonInsertTable";
            this.buttonInsertTable.Size = new System.Drawing.Size(485, 67);
            this.buttonInsertTable.TabIndex = 0;
            this.buttonInsertTable.Text = "INSERT TABLE";
            this.buttonInsertTable.UseVisualStyleBackColor = true;
            this.buttonInsertTable.Click += new System.EventHandler(this.buttonInsertTable_Click);
            // 
            // buttonInsertData
            // 
            this.buttonInsertData.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonInsertData.Location = new System.Drawing.Point(42, 293);
            this.buttonInsertData.Name = "buttonInsertData";
            this.buttonInsertData.Size = new System.Drawing.Size(485, 67);
            this.buttonInsertData.TabIndex = 2;
            this.buttonInsertData.Text = "INSERT DATA";
            this.buttonInsertData.UseVisualStyleBackColor = true;
            this.buttonInsertData.Click += new System.EventHandler(this.buttonInsertData_Click);
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTemperature.Location = new System.Drawing.Point(343, 50);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.Size = new System.Drawing.Size(122, 23);
            this.textBoxTemperature.TabIndex = 4;
            // 
            // textBoxHumidity
            // 
            this.textBoxHumidity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHumidity.Location = new System.Drawing.Point(343, 129);
            this.textBoxHumidity.Name = "textBoxHumidity";
            this.textBoxHumidity.Size = new System.Drawing.Size(122, 23);
            this.textBoxHumidity.TabIndex = 5;
            // 
            // comboTableNames
            // 
            this.comboTableNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTableNames.FormattingEnabled = true;
            this.comboTableNames.Location = new System.Drawing.Point(42, 54);
            this.comboTableNames.Name = "comboTableNames";
            this.comboTableNames.Size = new System.Drawing.Size(122, 23);
            this.comboTableNames.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 407);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboTableNames);
            this.tabPage1.Controls.Add(this.buttonInsertData);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "INSERT DATA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSensore);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxLuogo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxHumidity);
            this.groupBox1.Controls.Add(this.textBoxTemperature);
            this.groupBox1.Location = new System.Drawing.Point(42, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 183);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Datas (solo per tabella Monitoraggio)";
            // 
            // comboBoxSensore
            // 
            this.comboBoxSensore.FormattingEnabled = true;
            this.comboBoxSensore.Location = new System.Drawing.Point(179, 50);
            this.comboBoxSensore.Name = "comboBoxSensore";
            this.comboBoxSensore.Size = new System.Drawing.Size(122, 23);
            this.comboBoxSensore.TabIndex = 15;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(19, 129);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(282, 23);
            this.dateTimePicker.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sensore";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data";
            // 
            // textBoxLuogo
            // 
            this.textBoxLuogo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLuogo.Location = new System.Drawing.Point(19, 50);
            this.textBoxLuogo.Name = "textBoxLuogo";
            this.textBoxLuogo.Size = new System.Drawing.Size(122, 23);
            this.textBoxLuogo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Umidità (in %)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Luogo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Temperatura (in °C)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "AWS Table";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.buttonInsertTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INSERT TABLE (opzionale)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboSortType);
            this.groupBox2.Controls.Add(this.comboPartitionType);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSortKey);
            this.groupBox2.Controls.Add(this.txtPartitionKey);
            this.groupBox2.Controls.Add(this.txtNomeTabella);
            this.groupBox2.Location = new System.Drawing.Point(44, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add table";
            // 
            // comboSortType
            // 
            this.comboSortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSortType.FormattingEnabled = true;
            this.comboSortType.Items.AddRange(new object[] {
            "String",
            "Number",
            "Binary"});
            this.comboSortType.Location = new System.Drawing.Point(321, 132);
            this.comboSortType.Name = "comboSortType";
            this.comboSortType.Size = new System.Drawing.Size(119, 23);
            this.comboSortType.TabIndex = 7;
            // 
            // comboPartitionType
            // 
            this.comboPartitionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPartitionType.FormattingEnabled = true;
            this.comboPartitionType.Items.AddRange(new object[] {
            "String",
            "Number",
            "Binary"});
            this.comboPartitionType.Location = new System.Drawing.Point(177, 132);
            this.comboPartitionType.Name = "comboPartitionType";
            this.comboPartitionType.Size = new System.Drawing.Size(119, 23);
            this.comboPartitionType.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sort Key (optional)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Partition Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome tabella";
            // 
            // txtSortKey
            // 
            this.txtSortKey.Location = new System.Drawing.Point(321, 88);
            this.txtSortKey.Name = "txtSortKey";
            this.txtSortKey.Size = new System.Drawing.Size(119, 23);
            this.txtSortKey.TabIndex = 2;
            // 
            // txtPartitionKey
            // 
            this.txtPartitionKey.Location = new System.Drawing.Point(177, 88);
            this.txtPartitionKey.Name = "txtPartitionKey";
            this.txtPartitionKey.Size = new System.Drawing.Size(119, 23);
            this.txtPartitionKey.TabIndex = 1;
            // 
            // txtNomeTabella
            // 
            this.txtNomeTabella.Location = new System.Drawing.Point(32, 88);
            this.txtNomeTabella.Name = "txtNomeTabella";
            this.txtNomeTabella.Size = new System.Drawing.Size(119, 23);
            this.txtNomeTabella.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnStampaTutto);
            this.tabPage3.Controls.Add(this.dataGridInfo);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(568, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SCAN QUERY ITEMS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnStampaTutto
            // 
            this.btnStampaTutto.Location = new System.Drawing.Point(242, 316);
            this.btnStampaTutto.Name = "btnStampaTutto";
            this.btnStampaTutto.Size = new System.Drawing.Size(309, 34);
            this.btnStampaTutto.TabIndex = 3;
            this.btnStampaTutto.Text = "STAMPA TUTTI I DATI";
            this.btnStampaTutto.UseVisualStyleBackColor = true;
            this.btnStampaTutto.Click += new System.EventHandler(this.btnStampaTutto_Click);
            // 
            // dataGridInfo
            // 
            this.dataGridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfo.Location = new System.Drawing.Point(242, 31);
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.RowTemplate.Height = 25;
            this.dataGridInfo.Size = new System.Drawing.Size(309, 279);
            this.dataGridInfo.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIntervalloSensore);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboSensoreScelto);
            this.groupBox3.Controls.Add(this.datePickerFine);
            this.groupBox3.Controls.Add(this.datePickerInizio);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(26, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 319);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATI DI UN SENSORE IN UN INTERVALLO DI TEMPO";
            // 
            // btnIntervalloSensore
            // 
            this.btnIntervalloSensore.Location = new System.Drawing.Point(32, 220);
            this.btnIntervalloSensore.Name = "btnIntervalloSensore";
            this.btnIntervalloSensore.Size = new System.Drawing.Size(121, 76);
            this.btnIntervalloSensore.TabIndex = 7;
            this.btnIntervalloSensore.Text = "STAMPA";
            this.btnIntervalloSensore.UseVisualStyleBackColor = true;
            this.btnIntervalloSensore.Click += new System.EventHandler(this.btnIntervalloSensore_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(75, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "Sensore";
            // 
            // comboSensoreScelto
            // 
            this.comboSensoreScelto.FormattingEnabled = true;
            this.comboSensoreScelto.Location = new System.Drawing.Point(32, 170);
            this.comboSensoreScelto.Name = "comboSensoreScelto";
            this.comboSensoreScelto.Size = new System.Drawing.Size(121, 23);
            this.comboSensoreScelto.TabIndex = 5;
            // 
            // datePickerFine
            // 
            this.datePickerFine.Location = new System.Drawing.Point(110, 101);
            this.datePickerFine.Name = "datePickerFine";
            this.datePickerFine.Size = new System.Drawing.Size(64, 23);
            this.datePickerFine.TabIndex = 4;
            // 
            // datePickerInizio
            // 
            this.datePickerInizio.Location = new System.Drawing.Point(17, 101);
            this.datePickerInizio.Name = "datePickerInizio";
            this.datePickerInizio.Size = new System.Drawing.Size(64, 23);
            this.datePickerInizio.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(133, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Fine";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(32, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Inizio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Seleziona intervallo di tempo";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(568, 379);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "DELETE DATA";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboLuogoDelete);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.btnDeleteData);
            this.groupBox4.Controls.Add(this.datePickerDelete);
            this.groupBox4.Controls.Add(this.comboSensoreDelete);
            this.groupBox4.Location = new System.Drawing.Point(65, 59);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 270);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Datas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(253, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "Data di misurazione";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(81, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Sensore";
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnDeleteData.Location = new System.Drawing.Point(34, 183);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(358, 54);
            this.btnDeleteData.TabIndex = 2;
            this.btnDeleteData.Text = "DELETE DATA";
            this.btnDeleteData.UseVisualStyleBackColor = true;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // datePickerDelete
            // 
            this.datePickerDelete.Location = new System.Drawing.Point(208, 69);
            this.datePickerDelete.Name = "datePickerDelete";
            this.datePickerDelete.Size = new System.Drawing.Size(200, 23);
            this.datePickerDelete.TabIndex = 1;
            // 
            // comboSensoreDelete
            // 
            this.comboSensoreDelete.FormattingEnabled = true;
            this.comboSensoreDelete.Location = new System.Drawing.Point(50, 69);
            this.comboSensoreDelete.Name = "comboSensoreDelete";
            this.comboSensoreDelete.Size = new System.Drawing.Size(121, 23);
            this.comboSensoreDelete.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonExit.Location = new System.Drawing.Point(546, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(38, 37);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "❌";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(159, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 15);
            this.label16.TabIndex = 5;
            this.label16.Text = "Luogo dell\'analisi";
            // 
            // comboLuogoDelete
            // 
            this.comboLuogoDelete.FormattingEnabled = true;
            this.comboLuogoDelete.Location = new System.Drawing.Point(136, 137);
            this.comboLuogoDelete.Name = "comboLuogoDelete";
            this.comboLuogoDelete.Size = new System.Drawing.Size(140, 23);
            this.comboLuogoDelete.TabIndex = 6;
            // 
            // AWSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AWSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonInsertTable;
        private Button buttonInsertData;
        private TextBox textBoxTemperature;
        private TextBox textBoxHumidity;
        private ComboBox comboTableNames;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button buttonExit;
        private Label label2;
        private TextBox textBoxLuogo;
        private DateTimePicker dateTimePicker;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxSensore;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label1;
        private TextBox txtSortKey;
        private TextBox txtPartitionKey;
        private TextBox txtNomeTabella;
        private ComboBox comboSortType;
        private ComboBox comboPartitionType;
        private TabPage tabPage3;
        private GroupBox groupBox3;
        private DateTimePicker datePickerFine;
        private DateTimePicker datePickerInizio;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label13;
        private ComboBox comboSensoreScelto;
        private Button btnIntervalloSensore;
        private DataGridView dataGridInfo;
        private Button btnStampaTutto;
        private TabPage tabPage4;
        private GroupBox groupBox4;
        private Label label15;
        private Label label14;
        private Button btnDeleteData;
        private DateTimePicker datePickerDelete;
        private ComboBox comboSensoreDelete;
        private ComboBox comboLuogoDelete;
        private Label label16;
    }
}