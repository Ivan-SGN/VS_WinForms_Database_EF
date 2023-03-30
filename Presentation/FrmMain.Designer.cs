namespace Presentation
{
    partial class FrmMain
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
            this.btnDbCheck = new System.Windows.Forms.Button();
            this.cbSpecializations = new System.Windows.Forms.ComboBox();
            this.lblDbState = new System.Windows.Forms.Label();
            this.btnNewSpec = new System.Windows.Forms.Button();
            this.btnDelSpec = new System.Windows.Forms.Button();
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.cbDoctors = new System.Windows.Forms.ComboBox();
            this.btnNewDoc = new System.Windows.Forms.Button();
            this.btnDelDoc = new System.Windows.Forms.Button();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.cbCertificates = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewCert = new System.Windows.Forms.Button();
            this.btnDelSert = new System.Windows.Forms.Button();
            this.txtCert = new System.Windows.Forms.TextBox();
            this.grCerts = new System.Windows.Forms.DataGridView();
            this.btnEditSpec = new System.Windows.Forms.Button();
            this.btnEditDoc = new System.Windows.Forms.Button();
            this.btnEditCert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKdps = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLatestCert = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grCerts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDbCheck
            // 
            this.btnDbCheck.Location = new System.Drawing.Point(32, 30);
            this.btnDbCheck.Name = "btnDbCheck";
            this.btnDbCheck.Size = new System.Drawing.Size(141, 32);
            this.btnDbCheck.TabIndex = 0;
            this.btnDbCheck.Text = "Check db Connection";
            this.btnDbCheck.UseVisualStyleBackColor = true;
            this.btnDbCheck.Click += new System.EventHandler(this.btnDbCheck_Click);
            // 
            // cbSpecializations
            // 
            this.cbSpecializations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecializations.FormattingEnabled = true;
            this.cbSpecializations.Location = new System.Drawing.Point(35, 109);
            this.cbSpecializations.Name = "cbSpecializations";
            this.cbSpecializations.Size = new System.Drawing.Size(138, 23);
            this.cbSpecializations.TabIndex = 1;
            this.cbSpecializations.SelectedIndexChanged += new System.EventHandler(this.cbSpecializations_SelectedIndexChanged);
            // 
            // lblDbState
            // 
            this.lblDbState.AutoSize = true;
            this.lblDbState.Location = new System.Drawing.Point(185, 40);
            this.lblDbState.Name = "lblDbState";
            this.lblDbState.Size = new System.Drawing.Size(0, 15);
            this.lblDbState.TabIndex = 2;
            // 
            // btnNewSpec
            // 
            this.btnNewSpec.Location = new System.Drawing.Point(185, 109);
            this.btnNewSpec.Name = "btnNewSpec";
            this.btnNewSpec.Size = new System.Drawing.Size(41, 23);
            this.btnNewSpec.TabIndex = 3;
            this.btnNewSpec.Text = "New";
            this.btnNewSpec.UseVisualStyleBackColor = true;
            this.btnNewSpec.Click += new System.EventHandler(this.btnNewSpec_Click);
            // 
            // btnDelSpec
            // 
            this.btnDelSpec.Location = new System.Drawing.Point(232, 109);
            this.btnDelSpec.Name = "btnDelSpec";
            this.btnDelSpec.Size = new System.Drawing.Size(41, 23);
            this.btnDelSpec.TabIndex = 3;
            this.btnDelSpec.Text = "Del";
            this.btnDelSpec.UseVisualStyleBackColor = true;
            this.btnDelSpec.Click += new System.EventHandler(this.btnDelSpec_Click);
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(35, 129);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.PlaceholderText = "Type new spec name here";
            this.txtSpec.Size = new System.Drawing.Size(138, 23);
            this.txtSpec.TabIndex = 4;
            this.txtSpec.Visible = false;
            // 
            // cbDoctors
            // 
            this.cbDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbDoctors.FormattingEnabled = true;
            this.cbDoctors.Location = new System.Drawing.Point(35, 201);
            this.cbDoctors.Name = "cbDoctors";
            this.cbDoctors.Size = new System.Drawing.Size(138, 218);
            this.cbDoctors.TabIndex = 5;
            this.cbDoctors.SelectedIndexChanged += new System.EventHandler(this.cbDoctors_SelectedIndexChanged);
            // 
            // btnNewDoc
            // 
            this.btnNewDoc.Location = new System.Drawing.Point(185, 203);
            this.btnNewDoc.Name = "btnNewDoc";
            this.btnNewDoc.Size = new System.Drawing.Size(41, 23);
            this.btnNewDoc.TabIndex = 6;
            this.btnNewDoc.Text = "New";
            this.btnNewDoc.UseVisualStyleBackColor = true;
            this.btnNewDoc.Click += new System.EventHandler(this.btnNewDoc_Click);
            // 
            // btnDelDoc
            // 
            this.btnDelDoc.Location = new System.Drawing.Point(232, 202);
            this.btnDelDoc.Name = "btnDelDoc";
            this.btnDelDoc.Size = new System.Drawing.Size(41, 23);
            this.btnDelDoc.TabIndex = 6;
            this.btnDelDoc.Text = "Del";
            this.btnDelDoc.UseVisualStyleBackColor = true;
            this.btnDelDoc.Click += new System.EventHandler(this.btnDelDoc_Click);
            // 
            // txtDoctor
            // 
            this.txtDoctor.Enabled = false;
            this.txtDoctor.Location = new System.Drawing.Point(37, 204);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.PlaceholderText = "Press new to add doc";
            this.txtDoctor.Size = new System.Drawing.Size(135, 23);
            this.txtDoctor.TabIndex = 7;
            this.txtDoctor.TextChanged += new System.EventHandler(this.txtDoctor_TextChanged);
            // 
            // cbCertificates
            // 
            this.cbCertificates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbCertificates.FormattingEnabled = true;
            this.cbCertificates.Location = new System.Drawing.Point(185, 259);
            this.cbCertificates.Name = "cbCertificates";
            this.cbCertificates.Size = new System.Drawing.Size(146, 150);
            this.cbCertificates.TabIndex = 8;
            this.cbCertificates.SelectedIndexChanged += new System.EventHandler(this.cbCerts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Specializations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Doctors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Certificates";
            // 
            // btnNewCert
            // 
            this.btnNewCert.Location = new System.Drawing.Point(349, 258);
            this.btnNewCert.Name = "btnNewCert";
            this.btnNewCert.Size = new System.Drawing.Size(41, 23);
            this.btnNewCert.TabIndex = 10;
            this.btnNewCert.Text = "New";
            this.btnNewCert.UseVisualStyleBackColor = true;
            this.btnNewCert.Click += new System.EventHandler(this.btnNewSert_Click);
            // 
            // btnDelSert
            // 
            this.btnDelSert.Location = new System.Drawing.Point(349, 287);
            this.btnDelSert.Name = "btnDelSert";
            this.btnDelSert.Size = new System.Drawing.Size(41, 23);
            this.btnDelSert.TabIndex = 10;
            this.btnDelSert.Text = "Del";
            this.btnDelSert.UseVisualStyleBackColor = true;
            this.btnDelSert.Click += new System.EventHandler(this.btnDelSert_Click);
            // 
            // txtCert
            // 
            this.txtCert.Enabled = false;
            this.txtCert.Location = new System.Drawing.Point(187, 261);
            this.txtCert.Name = "txtCert";
            this.txtCert.PlaceholderText = "Press new to add Cert";
            this.txtCert.Size = new System.Drawing.Size(144, 23);
            this.txtCert.TabIndex = 11;
            this.txtCert.TextChanged += new System.EventHandler(this.txtCert_TextChanged);
            // 
            // grCerts
            // 
            this.grCerts.AllowUserToAddRows = false;
            this.grCerts.AllowUserToDeleteRows = false;
            this.grCerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grCerts.Location = new System.Drawing.Point(490, 30);
            this.grCerts.Name = "grCerts";
            this.grCerts.ReadOnly = true;
            this.grCerts.RowTemplate.Height = 25;
            this.grCerts.Size = new System.Drawing.Size(501, 407);
            this.grCerts.TabIndex = 12;
            // 
            // btnEditSpec
            // 
            this.btnEditSpec.Location = new System.Drawing.Point(279, 108);
            this.btnEditSpec.Name = "btnEditSpec";
            this.btnEditSpec.Size = new System.Drawing.Size(41, 23);
            this.btnEditSpec.TabIndex = 13;
            this.btnEditSpec.Text = "Edit";
            this.btnEditSpec.UseVisualStyleBackColor = true;
            this.btnEditSpec.Click += new System.EventHandler(this.btnEditSpec_Click);
            // 
            // btnEditDoc
            // 
            this.btnEditDoc.Location = new System.Drawing.Point(279, 202);
            this.btnEditDoc.Name = "btnEditDoc";
            this.btnEditDoc.Size = new System.Drawing.Size(41, 23);
            this.btnEditDoc.TabIndex = 13;
            this.btnEditDoc.Text = "Edit";
            this.btnEditDoc.UseVisualStyleBackColor = true;
            this.btnEditDoc.Click += new System.EventHandler(this.btnEditDoc_Click);
            // 
            // btnEditCert
            // 
            this.btnEditCert.Location = new System.Drawing.Point(349, 316);
            this.btnEditCert.Name = "btnEditCert";
            this.btnEditCert.Size = new System.Drawing.Size(41, 23);
            this.btnEditCert.TabIndex = 13;
            this.btnEditCert.Text = "Edit";
            this.btnEditCert.UseVisualStyleBackColor = true;
            this.btnEditCert.Click += new System.EventHandler(this.btnEditCert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(331, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Statistics:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Doc count:";
            // 
            // lblKdps
            // 
            this.lblKdps.AutoSize = true;
            this.lblKdps.Location = new System.Drawing.Point(418, 63);
            this.lblKdps.Name = "lblKdps";
            this.lblKdps.Size = new System.Drawing.Size(0, 15);
            this.lblKdps.TabIndex = 15;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(311, 261);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(18, 23);
            this.dateTimePicker.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Latest cert:";
            // 
            // lblLatestCert
            // 
            this.lblLatestCert.AutoSize = true;
            this.lblLatestCert.Location = new System.Drawing.Point(403, 81);
            this.lblLatestCert.Name = "lblLatestCert";
            this.lblLatestCert.Size = new System.Drawing.Size(0, 15);
            this.lblLatestCert.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Specialization:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Location = new System.Drawing.Point(418, 102);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(0, 15);
            this.lblSpec.TabIndex = 21;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 467);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblLatestCert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblKdps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditCert);
            this.Controls.Add(this.btnEditDoc);
            this.Controls.Add(this.btnEditSpec);
            this.Controls.Add(this.grCerts);
            this.Controls.Add(this.txtCert);
            this.Controls.Add(this.btnDelSert);
            this.Controls.Add(this.btnNewCert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCertificates);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.btnDelDoc);
            this.Controls.Add(this.btnNewDoc);
            this.Controls.Add(this.cbDoctors);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.btnDelSpec);
            this.Controls.Add(this.btnNewSpec);
            this.Controls.Add(this.lblDbState);
            this.Controls.Add(this.cbSpecializations);
            this.Controls.Add(this.btnDbCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grCerts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDbCheck;
        private ComboBox cbSpecializations;
        private Label lblDbState;
        private Button btnNewSpec;
        private Button btnDelSpec;
        private TextBox txtSpec;
        private ComboBox cbDoctors;
        private Button btnNewDoc;
        private Button btnDelDoc;
        private TextBox txtDoctor;
        private ComboBox cbCertificates;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnNewCert;
        private Button btnDelSert;
        private TextBox txtCert;
        private DataGridView grCerts;
        private Button btnEditSpec;
        private Button btnEditDoc;
        private Button btnEditCert;
        private Label label5;
        private Label label6;
        private Label lblKdps;
        private DateTimePicker dateTimePicker;
        private Label label1;
        private Label lblLatestCert;
        private Label label7;
        internal Label label8;
        internal Label lblSpec;
    }
}