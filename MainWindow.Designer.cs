namespace CSV_Export_Testdatei
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBladeSpeedMax = new System.Windows.Forms.TextBox();
            this.textBoxBladeSpeedMin = new System.Windows.Forms.TextBox();
            this.textBoxBladePowerMax = new System.Windows.Forms.TextBox();
            this.textBoxBladePowerMin = new System.Windows.Forms.TextBox();
            this.textBoxBladeCurrentMax = new System.Windows.Forms.TextBox();
            this.textBoxBladeCurrentMin = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chBoxBladeSpeed = new System.Windows.Forms.CheckBox();
            this.chBxBladeCurrent = new System.Windows.Forms.CheckBox();
            this.chBxBladePower = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxMachine = new System.Windows.Forms.TextBox();
            this.txtBoxCommission = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.groupBoxFolder = new System.Windows.Forms.GroupBox();
            this.MainMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.hilfeToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1660, 33);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.toolStripSeparator1,
            this.beendenToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 29);
            this.toolStripMenuItem1.Text = "Datei";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.testToolStripMenuItem.Text = "Speichern";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hilfeToolStripMenuItem1,
            this.überToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // hilfeToolStripMenuItem1
            // 
            this.hilfeToolStripMenuItem1.Name = "hilfeToolStripMenuItem1";
            this.hilfeToolStripMenuItem1.Size = new System.Drawing.Size(152, 34);
            this.hilfeToolStripMenuItem1.Text = "Hilfe";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(152, 34);
            this.überToolStripMenuItem.Text = "Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxBladeSpeedMax);
            this.groupBox1.Controls.Add(this.textBoxBladeSpeedMin);
            this.groupBox1.Controls.Add(this.textBoxBladePowerMax);
            this.groupBox1.Controls.Add(this.textBoxBladePowerMin);
            this.groupBox1.Controls.Add(this.textBoxBladeCurrentMax);
            this.groupBox1.Controls.Add(this.textBoxBladeCurrentMin);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chBoxBladeSpeed);
            this.groupBox1.Controls.Add(this.chBxBladeCurrent);
            this.groupBox1.Controls.Add(this.chBxBladePower);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(10, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flügel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "1/min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "kW";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "A";
            // 
            // textBoxBladeSpeedMax
            // 
            this.textBoxBladeSpeedMax.Location = new System.Drawing.Point(304, 212);
            this.textBoxBladeSpeedMax.Name = "textBoxBladeSpeedMax";
            this.textBoxBladeSpeedMax.Size = new System.Drawing.Size(81, 30);
            this.textBoxBladeSpeedMax.TabIndex = 16;
            // 
            // textBoxBladeSpeedMin
            // 
            this.textBoxBladeSpeedMin.Location = new System.Drawing.Point(204, 212);
            this.textBoxBladeSpeedMin.Name = "textBoxBladeSpeedMin";
            this.textBoxBladeSpeedMin.Size = new System.Drawing.Size(81, 30);
            this.textBoxBladeSpeedMin.TabIndex = 15;
            // 
            // textBoxBladePowerMax
            // 
            this.textBoxBladePowerMax.Location = new System.Drawing.Point(304, 176);
            this.textBoxBladePowerMax.Name = "textBoxBladePowerMax";
            this.textBoxBladePowerMax.Size = new System.Drawing.Size(81, 30);
            this.textBoxBladePowerMax.TabIndex = 14;
            // 
            // textBoxBladePowerMin
            // 
            this.textBoxBladePowerMin.Location = new System.Drawing.Point(204, 176);
            this.textBoxBladePowerMin.Name = "textBoxBladePowerMin";
            this.textBoxBladePowerMin.Size = new System.Drawing.Size(81, 30);
            this.textBoxBladePowerMin.TabIndex = 13;
            // 
            // textBoxBladeCurrentMax
            // 
            this.textBoxBladeCurrentMax.Location = new System.Drawing.Point(304, 140);
            this.textBoxBladeCurrentMax.Name = "textBoxBladeCurrentMax";
            this.textBoxBladeCurrentMax.Size = new System.Drawing.Size(81, 30);
            this.textBoxBladeCurrentMax.TabIndex = 12;
            // 
            // textBoxBladeCurrentMin
            // 
            this.textBoxBladeCurrentMin.Location = new System.Drawing.Point(204, 140);
            this.textBoxBladeCurrentMin.Name = "textBoxBladeCurrentMin";
            this.textBoxBladeCurrentMin.Size = new System.Drawing.Size(81, 30);
            this.textBoxBladeCurrentMin.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Eine Drehzahl",
            "Polumschaltbar",
            "FU gesteuert"});
            this.comboBox1.Location = new System.Drawing.Point(11, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 33);
            this.comboBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Max.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min.";
            // 
            // chBoxBladeSpeed
            // 
            this.chBoxBladeSpeed.AutoSize = true;
            this.chBoxBladeSpeed.Location = new System.Drawing.Point(11, 211);
            this.chBoxBladeSpeed.Name = "chBoxBladeSpeed";
            this.chBoxBladeSpeed.Size = new System.Drawing.Size(116, 29);
            this.chBoxBladeSpeed.TabIndex = 3;
            this.chBoxBladeSpeed.Text = "Drehzahl";
            this.chBoxBladeSpeed.UseVisualStyleBackColor = true;
            // 
            // chBxBladeCurrent
            // 
            this.chBxBladeCurrent.AutoSize = true;
            this.chBxBladeCurrent.Location = new System.Drawing.Point(11, 175);
            this.chBxBladeCurrent.Name = "chBxBladeCurrent";
            this.chBxBladeCurrent.Size = new System.Drawing.Size(112, 29);
            this.chBxBladeCurrent.TabIndex = 2;
            this.chBxBladeCurrent.Text = "Leistung";
            this.chBxBladeCurrent.UseVisualStyleBackColor = true;
            // 
            // chBxBladePower
            // 
            this.chBxBladePower.AutoSize = true;
            this.chBxBladePower.Location = new System.Drawing.Point(11, 139);
            this.chBxBladePower.Name = "chBxBladePower";
            this.chBxBladePower.Size = new System.Drawing.Size(90, 29);
            this.chBxBladePower.TabIndex = 1;
            this.chBxBladePower.Text = "Strom";
            this.chBxBladePower.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1084, 642);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(232, 70);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxMachine);
            this.groupBox2.Controls.Add(this.txtBoxCommission);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(10, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 122);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Maschine";
            // 
            // txtBoxMachine
            // 
            this.txtBoxMachine.Location = new System.Drawing.Point(149, 69);
            this.txtBoxMachine.Name = "txtBoxMachine";
            this.txtBoxMachine.Size = new System.Drawing.Size(200, 30);
            this.txtBoxMachine.TabIndex = 3;
            // 
            // txtBoxCommission
            // 
            this.txtBoxCommission.Location = new System.Drawing.Point(149, 28);
            this.txtBoxCommission.Name = "txtBoxCommission";
            this.txtBoxCommission.Size = new System.Drawing.Size(200, 30);
            this.txtBoxCommission.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maschinentyp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kommission";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(484, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(360, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(1046, 396);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(351, 26);
            this.textBoxDate.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1337, 642);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(221, 70);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxPath.Location = new System.Drawing.Point(11, 46);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(338, 30);
            this.txtBoxPath.TabIndex = 7;
            // 
            // btnPath
            // 
            this.btnPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPath.Location = new System.Drawing.Point(218, 87);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(131, 38);
            this.btnPath.TabIndex = 8;
            this.btnPath.Text = "Ordner";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // groupBoxFolder
            // 
            this.groupBoxFolder.Controls.Add(this.txtBoxPath);
            this.groupBoxFolder.Controls.Add(this.btnPath);
            this.groupBoxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFolder.Location = new System.Drawing.Point(10, 197);
            this.groupBoxFolder.Name = "groupBoxFolder";
            this.groupBoxFolder.Size = new System.Drawing.Size(400, 137);
            this.groupBoxFolder.TabIndex = 9;
            this.groupBoxFolder.TabStop = false;
            this.groupBoxFolder.Text = "Ordnerauswahl";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 757);
            this.Controls.Add(this.groupBoxFolder);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV Test Export";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxFolder.ResumeLayout(false);
            this.groupBoxFolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chBxBladeCurrent;
        private System.Windows.Forms.CheckBox chBxBladePower;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxMachine;
        private System.Windows.Forms.TextBox txtBoxCommission;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chBoxBladeSpeed;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.GroupBox groupBoxFolder;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBladeSpeedMax;
        private System.Windows.Forms.TextBox textBoxBladeSpeedMin;
        private System.Windows.Forms.TextBox textBoxBladePowerMax;
        private System.Windows.Forms.TextBox textBoxBladePowerMin;
        private System.Windows.Forms.TextBox textBoxBladeCurrentMax;
        private System.Windows.Forms.TextBox textBoxBladeCurrentMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
    
    
}

