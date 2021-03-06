using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace davidsp8.windows.PostSamlAssertion {
    public partial class frmSelectCertificate : Form {
        bool isEncCert = false;
        ConfigurationData configurationData = null;
        public frmSelectCertificate(ConfigurationData config, bool isEncCert) {
            InitializeComponent();
            configurationData = config;
            this.isEncCert = isEncCert;
        }
        public frmSelectCertificate(ConfigurationData config) : this(config, false) {
            
        }
        private void updateFormFromConfigurationFile() {
            if (isEncCert) {
                this.txtCertLocation.Text = configurationData.Configuration.Rows[0]["EncCertFileLocation"].ToString();
                this.cboxFindMethod.Visible = false;
                this.cboxStoreLocation.Visible = false;
                this.cboxStoreName.Visible = false;
                this.txtPassword.Visible = false;
                this.txtFindValue.Visible = false;
                this.lblFindMethod.Visible = false;
                this.lblFindValue.Visible = false;
                this.lblStoreLocation.Visible = false;
                this.lblStoreName.Visible = false;
                this.lblPassword.Visible = false;
            } else {
                this.txtCertLocation.Text = configurationData.Configuration.Rows[0]["CertFileLocation"].ToString();
                this.cboxFindMethod.Text = configurationData.Configuration.Rows[0]["CertFindMethod"].ToString();
                this.cboxStoreLocation.Text = configurationData.Configuration.Rows[0]["CertStoreLocation"].ToString();
                this.cboxStoreName.Text = configurationData.Configuration.Rows[0]["CertStoreName"].ToString();
                this.txtPassword.Text = configurationData.Configuration.Rows[0]["CertPassword"].ToString();
                this.txtFindValue.Text = configurationData.Configuration.Rows[0]["CertFindKey"].ToString();
            }
        }
        private void frmSelectCertificate_Load(object sender, EventArgs e) {
            this.updateFormFromConfigurationFile();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            X509Certificate2 cert = null;
            if ((isEncCert && this.txtCertLocation.Text.Length > 0) || !isEncCert) {
                if (System.IO.File.Exists(this.txtCertLocation.Text)) {
                    cert = new X509Certificate2(this.txtCertLocation.Text, this.txtPassword.Text);
                } else {
                    X509Store store = new X509Store(cboxStoreName.Text,
                        (StoreLocation)Enum.Parse(typeof(StoreLocation), cboxStoreLocation.Text));
                    store.Open(OpenFlags.ReadOnly);
                    X509Certificate2Collection coll = store.Certificates.Find(
                        (X509FindType)Enum.Parse(typeof(X509FindType), cboxFindMethod.Text), txtFindValue.Text, false);
                    if (coll.Count < 1) {
                        throw new ArgumentException("Unable to locate certificate");
                    }
                    cert = coll[0];
                    store.Close();
                }
            }
            if (cert != null || (isEncCert && txtCertLocation.Text.Length == 0)) {
                if (isEncCert) {
                    if (txtCertLocation.Text.Length > 0) {
                        configurationData.Configuration[0].EncCertFileLocation = txtCertLocation.Text;
                        configurationData.Configuration[0].EncFriendlyName = cert.FriendlyName == "" ? cert.Subject : cert.FriendlyName;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    } else {
                        configurationData.Configuration[0].EncCertFileLocation = "";
                        configurationData.Configuration[0].EncFriendlyName = "";
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                } else {
                    configurationData.Configuration[0].CertFileLocation = txtCertLocation.Text;
                    configurationData.Configuration[0].CertPassword = txtPassword.Text;
                    configurationData.Configuration[0].CertStoreLocation = cboxStoreLocation.Text;
                    configurationData.Configuration[0].CertStoreName = cboxStoreName.Text;
                    configurationData.Configuration[0].CertFindKey = txtFindValue.Text;
                    configurationData.Configuration[0].CertFindMethod = cboxFindMethod.Text;
                    configurationData.Configuration[0].CertFriendlyName = cert.FriendlyName == "" ? cert.Subject : cert.FriendlyName;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            } 
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            openFileDialog1.Filter = "P12 files (*.P12)|*.P12|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                this.txtCertLocation.Text = openFileDialog1.FileName;
            }
        }

    }
}
