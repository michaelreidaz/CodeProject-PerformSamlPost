namespace davidsp8.windows.PostSamlAssertion {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnPostAssertion = new System.Windows.Forms.Button();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblCertificate = new System.Windows.Forms.Label();
            this.lblCertificateFriendlyName = new System.Windows.Forms.Label();
            this.btnSelectCertficate = new System.Windows.Forms.Button();
            this.lblAttributes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.configIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttrPostSaml = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.attributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attributesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.configurationDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configurationData = new davidsp8.windows.PostSamlAssertion.ConfigurationData();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblIssuer = new System.Windows.Forms.Label();
            this.txtIssuer = new System.Windows.Forms.TextBox();
            this.lblNameQualifier = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.rb_v2 = new System.Windows.Forms.RadioButton();
            this.rb_v1 = new System.Windows.Forms.RadioButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnShowBrowser = new System.Windows.Forms.Button();
            this.rbSignResponse = new System.Windows.Forms.RadioButton();
            this.rbSignAssertion = new System.Windows.Forms.RadioButton();
            this.gbSigningOptions = new System.Windows.Forms.GroupBox();
            this.btnShowSaml = new System.Windows.Forms.Button();
            this.samlBrowser = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.lblEncryptionCertificate = new System.Windows.Forms.Label();
            this.lblEncryptionCertificateFriendlyName = new System.Windows.Forms.Label();
            this.btnSelectEncryptionCertificate = new System.Windows.Forms.Button();
            this.tpBrower = new System.Windows.Forms.TabPage();
            this.tpSaml = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationData)).BeginInit();
            this.gbSigningOptions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.tpBrower.SuspendLayout();
            this.tpSaml.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPostAssertion
            // 
            this.btnPostAssertion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPostAssertion.Location = new System.Drawing.Point(634, 664);
            this.btnPostAssertion.Name = "btnPostAssertion";
            this.btnPostAssertion.Size = new System.Drawing.Size(102, 23);
            this.btnPostAssertion.TabIndex = 4;
            this.btnPostAssertion.Text = "Post Assertion";
            this.btnPostAssertion.UseVisualStyleBackColor = true;
            this.btnPostAssertion.Click += new System.EventHandler(this.btnPostAssertion_Click);
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(118, 66);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(362, 20);
            this.txtRecipient.TabIndex = 3;
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(63, 70);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(52, 13);
            this.lblRecipient.TabIndex = 3;
            this.lblRecipient.Text = "Recipient";
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(118, 94);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(362, 20);
            this.txtTarget.TabIndex = 4;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(77, 98);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(38, 13);
            this.lblTarget.TabIndex = 5;
            this.lblTarget.Text = "Target";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(118, 150);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(362, 20);
            this.txtSubject.TabIndex = 6;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(72, 154);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Subject";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(5, 664);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save Config";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpen.Location = new System.Drawing.Point(89, 664);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "&Open Config";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblCertificate
            // 
            this.lblCertificate.AutoSize = true;
            this.lblCertificate.Location = new System.Drawing.Point(13, 178);
            this.lblCertificate.Name = "lblCertificate";
            this.lblCertificate.Size = new System.Drawing.Size(102, 13);
            this.lblCertificate.TabIndex = 10;
            this.lblCertificate.Text = "Signature Certificate";
            this.lblCertificate.Click += new System.EventHandler(this.lblCertificate_Click);
            // 
            // lblCertificateFriendlyName
            // 
            this.lblCertificateFriendlyName.AutoSize = true;
            this.lblCertificateFriendlyName.Location = new System.Drawing.Point(118, 178);
            this.lblCertificateFriendlyName.Name = "lblCertificateFriendlyName";
            this.lblCertificateFriendlyName.Size = new System.Drawing.Size(39, 13);
            this.lblCertificateFriendlyName.TabIndex = 7;
            this.lblCertificateFriendlyName.Text = "[None]";
            // 
            // btnSelectCertficate
            // 
            this.btnSelectCertficate.Location = new System.Drawing.Point(484, 173);
            this.btnSelectCertficate.Name = "btnSelectCertficate";
            this.btnSelectCertficate.Size = new System.Drawing.Size(24, 22);
            this.btnSelectCertficate.TabIndex = 12;
            this.btnSelectCertficate.Text = "...";
            this.btnSelectCertficate.UseVisualStyleBackColor = true;
            this.btnSelectCertficate.Click += new System.EventHandler(this.btnSelectCertficate_Click);
            // 
            // lblAttributes
            // 
            this.lblAttributes.AutoSize = true;
            this.lblAttributes.Location = new System.Drawing.Point(63, 220);
            this.lblAttributes.Name = "lblAttributes";
            this.lblAttributes.Size = new System.Drawing.Size(51, 13);
            this.lblAttributes.TabIndex = 13;
            this.lblAttributes.Text = "Attributes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.configIDDataGridViewTextBoxColumn,
            this.sequenceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.AttrPostSaml});
            this.dataGridView1.DataSource = this.attributesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(118, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(359, 258);
            this.dataGridView1.TabIndex = 9;
            // 
            // configIDDataGridViewTextBoxColumn
            // 
            this.configIDDataGridViewTextBoxColumn.DataPropertyName = "ConfigID";
            this.configIDDataGridViewTextBoxColumn.HeaderText = "ConfigID";
            this.configIDDataGridViewTextBoxColumn.Name = "configIDDataGridViewTextBoxColumn";
            this.configIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sequenceDataGridViewTextBoxColumn
            // 
            this.sequenceDataGridViewTextBoxColumn.DataPropertyName = "Sequence";
            this.sequenceDataGridViewTextBoxColumn.HeaderText = "Sequence";
            this.sequenceDataGridViewTextBoxColumn.Name = "sequenceDataGridViewTextBoxColumn";
            this.sequenceDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // AttrPostSaml
            // 
            this.AttrPostSaml.DataPropertyName = "AttrPostSaml";
            this.AttrPostSaml.HeaderText = "Parameter Type";
            this.AttrPostSaml.Items.AddRange(new object[] {
            "Attribute",
            "Post",
            "Saml"});
            this.AttrPostSaml.Name = "AttrPostSaml";
            // 
            // attributesBindingSource
            // 
            this.attributesBindingSource.DataSource = this.attributesBindingSource1;
            this.attributesBindingSource.CurrentChanged += new System.EventHandler(this.attributesBindingSource_CurrentChanged);
            // 
            // attributesBindingSource1
            // 
            this.attributesBindingSource1.DataMember = "Attributes";
            this.attributesBindingSource1.DataSource = this.configurationDataBindingSource;
            // 
            // configurationDataBindingSource
            // 
            this.configurationDataBindingSource.DataSource = this.configurationData;
            this.configurationDataBindingSource.Position = 0;
            // 
            // configurationData
            // 
            this.configurationData.DataSetName = "ConfigurationData";
            this.configurationData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblIssuer
            // 
            this.lblIssuer.AutoSize = true;
            this.lblIssuer.Location = new System.Drawing.Point(78, 42);
            this.lblIssuer.Name = "lblIssuer";
            this.lblIssuer.Size = new System.Drawing.Size(35, 13);
            this.lblIssuer.TabIndex = 15;
            this.lblIssuer.Text = "Issuer";
            // 
            // txtIssuer
            // 
            this.txtIssuer.Location = new System.Drawing.Point(118, 38);
            this.txtIssuer.Name = "txtIssuer";
            this.txtIssuer.Size = new System.Drawing.Size(362, 20);
            this.txtIssuer.TabIndex = 2;
            // 
            // lblNameQualifier
            // 
            this.lblNameQualifier.AutoSize = true;
            this.lblNameQualifier.Location = new System.Drawing.Point(70, 126);
            this.lblNameQualifier.Name = "lblNameQualifier";
            this.lblNameQualifier.Size = new System.Drawing.Size(43, 13);
            this.lblNameQualifier.TabIndex = 17;
            this.lblNameQualifier.Text = "Domain";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(118, 122);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(362, 20);
            this.txtDomain.TabIndex = 5;
            // 
            // rb_v2
            // 
            this.rb_v2.AutoSize = true;
            this.rb_v2.Location = new System.Drawing.Point(203, 15);
            this.rb_v2.Name = "rb_v2";
            this.rb_v2.Size = new System.Drawing.Size(78, 17);
            this.rb_v2.TabIndex = 1;
            this.rb_v2.Text = "Version 2.0";
            this.rb_v2.UseVisualStyleBackColor = true;
            // 
            // rb_v1
            // 
            this.rb_v1.AutoSize = true;
            this.rb_v1.Location = new System.Drawing.Point(119, 15);
            this.rb_v1.Name = "rb_v1";
            this.rb_v1.Size = new System.Drawing.Size(78, 17);
            this.rb_v1.TabIndex = 0;
            this.rb_v1.Text = "Version 1.1";
            this.rb_v1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(719, 607);
            this.webBrowser1.TabIndex = 22;
            this.webBrowser1.Visible = false;
            // 
            // btnShowBrowser
            // 
            this.btnShowBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowBrowser.Location = new System.Drawing.Point(525, 664);
            this.btnShowBrowser.Name = "btnShowBrowser";
            this.btnShowBrowser.Size = new System.Drawing.Size(96, 23);
            this.btnShowBrowser.TabIndex = 3;
            this.btnShowBrowser.Text = "Show Browser";
            this.btnShowBrowser.UseVisualStyleBackColor = true;
            this.btnShowBrowser.Visible = false;
            this.btnShowBrowser.Click += new System.EventHandler(this.btnShowBrowser_Click);
            // 
            // rbSignResponse
            // 
            this.rbSignResponse.AutoSize = true;
            this.rbSignResponse.Checked = true;
            this.rbSignResponse.Location = new System.Drawing.Point(6, 18);
            this.rbSignResponse.Name = "rbSignResponse";
            this.rbSignResponse.Size = new System.Drawing.Size(97, 17);
            this.rbSignResponse.TabIndex = 0;
            this.rbSignResponse.TabStop = true;
            this.rbSignResponse.Text = "Sign Response";
            this.rbSignResponse.UseVisualStyleBackColor = true;
            // 
            // rbSignAssertion
            // 
            this.rbSignAssertion.AutoSize = true;
            this.rbSignAssertion.Location = new System.Drawing.Point(118, 18);
            this.rbSignAssertion.Name = "rbSignAssertion";
            this.rbSignAssertion.Size = new System.Drawing.Size(92, 17);
            this.rbSignAssertion.TabIndex = 1;
            this.rbSignAssertion.Text = "Sign Assertion";
            this.rbSignAssertion.UseVisualStyleBackColor = true;
            // 
            // gbSigningOptions
            // 
            this.gbSigningOptions.Controls.Add(this.rbSignResponse);
            this.gbSigningOptions.Controls.Add(this.rbSignAssertion);
            this.gbSigningOptions.Location = new System.Drawing.Point(118, 484);
            this.gbSigningOptions.Name = "gbSigningOptions";
            this.gbSigningOptions.Size = new System.Drawing.Size(358, 47);
            this.gbSigningOptions.TabIndex = 26;
            this.gbSigningOptions.TabStop = false;
            this.gbSigningOptions.Text = "Signing Options";
            // 
            // btnShowSaml
            // 
            this.btnShowSaml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowSaml.Enabled = false;
            this.btnShowSaml.Location = new System.Drawing.Point(423, 664);
            this.btnShowSaml.Name = "btnShowSaml";
            this.btnShowSaml.Size = new System.Drawing.Size(96, 23);
            this.btnShowSaml.TabIndex = 2;
            this.btnShowSaml.Text = "Show Saml";
            this.btnShowSaml.UseVisualStyleBackColor = true;
            this.btnShowSaml.Visible = false;
            this.btnShowSaml.Click += new System.EventHandler(this.btnShowSaml_Click);
            // 
            // samlBrowser
            // 
            this.samlBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.samlBrowser.Location = new System.Drawing.Point(3, 3);
            this.samlBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.samlBrowser.Name = "samlBrowser";
            this.samlBrowser.Size = new System.Drawing.Size(719, 607);
            this.samlBrowser.TabIndex = 28;
            this.samlBrowser.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageConfig);
            this.tabControl1.Controls.Add(this.tpBrower);
            this.tabControl1.Controls.Add(this.tpSaml);
            this.tabControl1.Location = new System.Drawing.Point(3, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(733, 639);
            this.tabControl1.TabIndex = 29;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.lblEncryptionCertificate);
            this.tabPageConfig.Controls.Add(this.lblEncryptionCertificateFriendlyName);
            this.tabPageConfig.Controls.Add(this.btnSelectEncryptionCertificate);
            this.tabPageConfig.Controls.Add(this.rb_v1);
            this.tabPageConfig.Controls.Add(this.txtRecipient);
            this.tabPageConfig.Controls.Add(this.gbSigningOptions);
            this.tabPageConfig.Controls.Add(this.lblRecipient);
            this.tabPageConfig.Controls.Add(this.txtTarget);
            this.tabPageConfig.Controls.Add(this.rb_v2);
            this.tabPageConfig.Controls.Add(this.lblTarget);
            this.tabPageConfig.Controls.Add(this.txtSubject);
            this.tabPageConfig.Controls.Add(this.txtDomain);
            this.tabPageConfig.Controls.Add(this.lblSubject);
            this.tabPageConfig.Controls.Add(this.lblNameQualifier);
            this.tabPageConfig.Controls.Add(this.lblCertificate);
            this.tabPageConfig.Controls.Add(this.txtIssuer);
            this.tabPageConfig.Controls.Add(this.lblCertificateFriendlyName);
            this.tabPageConfig.Controls.Add(this.lblIssuer);
            this.tabPageConfig.Controls.Add(this.btnSelectCertficate);
            this.tabPageConfig.Controls.Add(this.dataGridView1);
            this.tabPageConfig.Controls.Add(this.lblAttributes);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(725, 613);
            this.tabPageConfig.TabIndex = 0;
            this.tabPageConfig.Text = "Parameters";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // lblEncryptionCertificate
            // 
            this.lblEncryptionCertificate.AutoSize = true;
            this.lblEncryptionCertificate.Location = new System.Drawing.Point(7, 199);
            this.lblEncryptionCertificate.Name = "lblEncryptionCertificate";
            this.lblEncryptionCertificate.Size = new System.Drawing.Size(107, 13);
            this.lblEncryptionCertificate.TabIndex = 27;
            this.lblEncryptionCertificate.Text = "Encryption Certificate";
            // 
            // lblEncryptionCertificateFriendlyName
            // 
            this.lblEncryptionCertificateFriendlyName.AutoSize = true;
            this.lblEncryptionCertificateFriendlyName.Location = new System.Drawing.Point(118, 199);
            this.lblEncryptionCertificateFriendlyName.Name = "lblEncryptionCertificateFriendlyName";
            this.lblEncryptionCertificateFriendlyName.Size = new System.Drawing.Size(39, 13);
            this.lblEncryptionCertificateFriendlyName.TabIndex = 8;
            this.lblEncryptionCertificateFriendlyName.Text = "[None]";
            // 
            // btnSelectEncryptionCertificate
            // 
            this.btnSelectEncryptionCertificate.Location = new System.Drawing.Point(484, 194);
            this.btnSelectEncryptionCertificate.Name = "btnSelectEncryptionCertificate";
            this.btnSelectEncryptionCertificate.Size = new System.Drawing.Size(24, 22);
            this.btnSelectEncryptionCertificate.TabIndex = 29;
            this.btnSelectEncryptionCertificate.Text = "...";
            this.btnSelectEncryptionCertificate.UseVisualStyleBackColor = true;
            this.btnSelectEncryptionCertificate.Click += new System.EventHandler(this.btnSelectEncryptionCertificate_Click);
            // 
            // tpBrower
            // 
            this.tpBrower.Controls.Add(this.webBrowser2);
            this.tpBrower.Controls.Add(this.webBrowser1);
            this.tpBrower.Location = new System.Drawing.Point(4, 22);
            this.tpBrower.Name = "tpBrower";
            this.tpBrower.Padding = new System.Windows.Forms.Padding(3);
            this.tpBrower.Size = new System.Drawing.Size(725, 613);
            this.tpBrower.TabIndex = 1;
            this.tpBrower.Text = "Browser";
            this.tpBrower.UseVisualStyleBackColor = true;
            // 
            // tpSaml
            // 
            this.tpSaml.Controls.Add(this.samlBrowser);
            this.tpSaml.Location = new System.Drawing.Point(4, 22);
            this.tpSaml.Name = "tpSaml";
            this.tpSaml.Padding = new System.Windows.Forms.Padding(3);
            this.tpSaml.Size = new System.Drawing.Size(725, 613);
            this.tpSaml.TabIndex = 2;
            this.tpSaml.Text = "SAML";
            this.tpSaml.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(719, 607);
            this.webBrowser2.TabIndex = 23;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 709);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnShowSaml);
            this.Controls.Add(this.btnShowBrowser);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPostAssertion);
            this.Name = "frmMain";
            this.Text = "Post Saml Assertion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationData)).EndInit();
            this.gbSigningOptions.ResumeLayout(false);
            this.gbSigningOptions.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            this.tpBrower.ResumeLayout(false);
            this.tpSaml.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPostAssertion;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblCertificate;
        private System.Windows.Forms.Label lblCertificateFriendlyName;
        private System.Windows.Forms.Button btnSelectCertficate;
        private System.Windows.Forms.Label lblAttributes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource attributesBindingSource;
        private System.Windows.Forms.BindingSource configurationDataBindingSource;
        private ConfigurationData configurationData;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblIssuer;
        private System.Windows.Forms.TextBox txtIssuer;
        private System.Windows.Forms.Label lblNameQualifier;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.RadioButton rb_v2;
        private System.Windows.Forms.RadioButton rb_v1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnShowBrowser;
        private System.Windows.Forms.RadioButton rbSignResponse;
        private System.Windows.Forms.RadioButton rbSignAssertion;
        private System.Windows.Forms.GroupBox gbSigningOptions;
        private System.Windows.Forms.Button btnShowSaml;
        private System.Windows.Forms.WebBrowser samlBrowser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.TabPage tpBrower;
        private System.Windows.Forms.TabPage tpSaml;
        private System.Windows.Forms.Label lblEncryptionCertificate;
        private System.Windows.Forms.Label lblEncryptionCertificateFriendlyName;
        private System.Windows.Forms.Button btnSelectEncryptionCertificate;
        private System.Windows.Forms.BindingSource attributesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn configIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AttrPostSaml;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}

