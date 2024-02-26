namespace frmRSVParameters
{
    partial class rsv
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            txtProfileName = new TextBox();
            label1 = new Label();
            txtDraft = new TextBox();
            txtCBZ = new TextBox();
            txtCBY = new TextBox();
            txtCBX = new TextBox();
            txtCGZ = new TextBox();
            txtCGY = new TextBox();
            txtCGX = new TextBox();
            lblDraft = new Label();
            lblCBshift = new Label();
            lblCGshift = new Label();
            groupBox3 = new GroupBox();
            lblProfile = new Label();
            groupBox2 = new GroupBox();
            lblZ = new Label();
            lblY = new Label();
            lblX = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            txtMass = new TextBox();
            txtBallast2 = new TextBox();
            txtBallast1 = new TextBox();
            txtFuelLevel = new TextBox();
            lblMass = new Label();
            lblBallast2 = new Label();
            lblBallast1 = new Label();
            lblFuelLevel = new Label();
            btnEdit = new Button();
            btnNew = new Button();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            cmbProfiles = new ComboBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(702, 455);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 27);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtProfileName
            // 
            txtProfileName.Location = new Point(110, 31);
            txtProfileName.Name = "txtProfileName";
            txtProfileName.Size = new Size(312, 23);
            txtProfileName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Profile Name";
            // 
            // txtDraft
            // 
            txtDraft.Location = new Point(88, 294);
            txtDraft.Name = "txtDraft";
            txtDraft.Size = new Size(213, 23);
            txtDraft.TabIndex = 24;
            // 
            // txtCBZ
            // 
            txtCBZ.Location = new Point(234, 254);
            txtCBZ.Name = "txtCBZ";
            txtCBZ.Size = new Size(67, 23);
            txtCBZ.TabIndex = 23;
            // 
            // txtCBY
            // 
            txtCBY.Location = new Point(161, 254);
            txtCBY.Name = "txtCBY";
            txtCBY.Size = new Size(67, 23);
            txtCBY.TabIndex = 22;
            // 
            // txtCBX
            // 
            txtCBX.Location = new Point(88, 254);
            txtCBX.Name = "txtCBX";
            txtCBX.Size = new Size(67, 23);
            txtCBX.TabIndex = 21;
            // 
            // txtCGZ
            // 
            txtCGZ.Location = new Point(234, 215);
            txtCGZ.Name = "txtCGZ";
            txtCGZ.Size = new Size(67, 23);
            txtCGZ.TabIndex = 20;
            // 
            // txtCGY
            // 
            txtCGY.Location = new Point(161, 215);
            txtCGY.Name = "txtCGY";
            txtCGY.Size = new Size(67, 23);
            txtCGY.TabIndex = 19;
            // 
            // txtCGX
            // 
            txtCGX.Location = new Point(88, 215);
            txtCGX.Name = "txtCGX";
            txtCGX.Size = new Size(67, 23);
            txtCGX.TabIndex = 18;
            // 
            // lblDraft
            // 
            lblDraft.AutoSize = true;
            lblDraft.Location = new Point(9, 297);
            lblDraft.Name = "lblDraft";
            lblDraft.Size = new Size(33, 15);
            lblDraft.TabIndex = 17;
            lblDraft.Text = "Draft";
            // 
            // lblCBshift
            // 
            lblCBshift.AutoSize = true;
            lblCBshift.Location = new Point(9, 257);
            lblCBshift.Name = "lblCBshift";
            lblCBshift.Size = new Size(48, 15);
            lblCBshift.TabIndex = 16;
            lblCBshift.Text = "CB shift";
            // 
            // lblCGshift
            // 
            lblCGshift.AutoSize = true;
            lblCGshift.Location = new Point(9, 215);
            lblCGshift.Name = "lblCGshift";
            lblCGshift.Size = new Size(49, 15);
            lblCGshift.TabIndex = 15;
            lblCGshift.Text = "CG shift";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(397, 60);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(368, 333);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Extrinsic Parameters";
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Location = new Point(41, 12);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(41, 15);
            lblProfile.TabIndex = 7;
            lblProfile.Text = "Profile";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDraft);
            groupBox2.Controls.Add(txtCBZ);
            groupBox2.Controls.Add(txtCBY);
            groupBox2.Controls.Add(txtCBX);
            groupBox2.Controls.Add(txtCGZ);
            groupBox2.Controls.Add(txtCGY);
            groupBox2.Controls.Add(txtCGX);
            groupBox2.Controls.Add(lblDraft);
            groupBox2.Controls.Add(lblCBshift);
            groupBox2.Controls.Add(lblCGshift);
            groupBox2.Controls.Add(lblZ);
            groupBox2.Controls.Add(lblY);
            groupBox2.Controls.Add(lblX);
            groupBox2.Controls.Add(lbl4);
            groupBox2.Controls.Add(lbl3);
            groupBox2.Controls.Add(lbl2);
            groupBox2.Controls.Add(lbl1);
            groupBox2.Controls.Add(txtMass);
            groupBox2.Controls.Add(txtBallast2);
            groupBox2.Controls.Add(txtBallast1);
            groupBox2.Controls.Add(txtFuelLevel);
            groupBox2.Controls.Add(lblMass);
            groupBox2.Controls.Add(lblBallast2);
            groupBox2.Controls.Add(lblBallast1);
            groupBox2.Controls.Add(lblFuelLevel);
            groupBox2.Location = new Point(6, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(368, 333);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Intrinsic Parameters";
            // 
            // lblZ
            // 
            lblZ.AutoSize = true;
            lblZ.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblZ.Location = new Point(260, 183);
            lblZ.Name = "lblZ";
            lblZ.Size = new Size(16, 17);
            lblZ.TabIndex = 14;
            lblZ.Text = "Z";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblY.Location = new Point(187, 183);
            lblY.Name = "lblY";
            lblY.Size = new Size(16, 17);
            lblY.TabIndex = 13;
            lblY.Text = "Y";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblX.Location = new Point(114, 183);
            lblX.Name = "lblX";
            lblX.Size = new Size(17, 17);
            lblX.TabIndex = 12;
            lblX.Text = "X";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(315, 151);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(21, 15);
            lbl4.TabIndex = 11;
            lbl4.Text = "Kg";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(315, 113);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(17, 15);
            lbl3.TabIndex = 10;
            lbl3.Text = "%";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(315, 70);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(17, 15);
            lbl2.TabIndex = 9;
            lbl2.Text = "%";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(315, 33);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(17, 15);
            lbl1.TabIndex = 8;
            lbl1.Text = "%";
            // 
            // txtMass
            // 
            txtMass.Location = new Point(88, 147);
            txtMass.Name = "txtMass";
            txtMass.Size = new Size(221, 23);
            txtMass.TabIndex = 7;
            // 
            // txtBallast2
            // 
            txtBallast2.Location = new Point(88, 109);
            txtBallast2.Name = "txtBallast2";
            txtBallast2.Size = new Size(221, 23);
            txtBallast2.TabIndex = 6;
            // 
            // txtBallast1
            // 
            txtBallast1.Location = new Point(88, 66);
            txtBallast1.Name = "txtBallast1";
            txtBallast1.Size = new Size(221, 23);
            txtBallast1.TabIndex = 5;
            // 
            // txtFuelLevel
            // 
            txtFuelLevel.Location = new Point(88, 29);
            txtFuelLevel.Name = "txtFuelLevel";
            txtFuelLevel.Size = new Size(221, 23);
            txtFuelLevel.TabIndex = 4;
            // 
            // lblMass
            // 
            lblMass.AutoSize = true;
            lblMass.Location = new Point(9, 151);
            lblMass.Name = "lblMass";
            lblMass.Size = new Size(34, 15);
            lblMass.TabIndex = 3;
            lblMass.Text = "Mass";
            // 
            // lblBallast2
            // 
            lblBallast2.AutoSize = true;
            lblBallast2.Location = new Point(9, 113);
            lblBallast2.Name = "lblBallast2";
            lblBallast2.Size = new Size(63, 15);
            lblBallast2.TabIndex = 2;
            lblBallast2.Text = "Ballast(aft)";
            // 
            // lblBallast1
            // 
            lblBallast1.AutoSize = true;
            lblBallast1.Location = new Point(9, 70);
            lblBallast1.Name = "lblBallast1";
            lblBallast1.Size = new Size(73, 15);
            lblBallast1.TabIndex = 1;
            lblBallast1.Text = "Ballast (fore)";
            // 
            // lblFuelLevel
            // 
            lblFuelLevel.AutoSize = true;
            lblFuelLevel.Location = new Point(9, 33);
            lblFuelLevel.Name = "lblFuelLevel";
            lblFuelLevel.Size = new Size(59, 15);
            lblFuelLevel.TabIndex = 0;
            lblFuelLevel.Text = "Fuel Level";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(600, 9);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 24);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(491, 9);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(86, 24);
            btnNew.TabIndex = 9;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtProfileName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 399);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profile Settings";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(698, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 24);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbProfiles
            // 
            cmbProfiles.FormattingEnabled = true;
            cmbProfiles.Location = new Point(109, 9);
            cmbProfiles.Name = "cmbProfiles";
            cmbProfiles.Size = new Size(328, 23);
            cmbProfiles.TabIndex = 8;
            cmbProfiles.SelectedIndexChanged += cmbProfiles_SelectedIndexChanged;
            // 
            // rsv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSave);
            Controls.Add(lblProfile);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(groupBox1);
            Controls.Add(btnDelete);
            Controls.Add(cmbProfiles);
            Name = "rsv";
            Size = new Size(955, 490);
            Load += rsv_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtProfileName;
        private Label label1;
        private TextBox txtDraft;
        private TextBox txtCBZ;
        private TextBox txtCBY;
        private TextBox txtCBX;
        private TextBox txtCGZ;
        private TextBox txtCGY;
        private TextBox txtCGX;
        private Label lblDraft;
        private Label lblCBshift;
        private Label lblCGshift;
        private GroupBox groupBox3;
        private Label lblProfile;
        private GroupBox groupBox2;
        private Label lblZ;
        private Label lblY;
        private Label lblX;
        private Label lbl4;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
        private TextBox txtMass;
        private TextBox txtBallast2;
        private TextBox txtBallast1;
        private TextBox txtFuelLevel;
        private Label lblMass;
        private Label lblBallast2;
        private Label lblBallast1;
        private Label lblFuelLevel;
        private Button btnEdit;
        private Button btnNew;
        private GroupBox groupBox1;
        private Button btnDelete;
        private ComboBox cmbProfiles;
    }
}
