using Core;
using DatabaseModels;


namespace Presentation
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtSpec.Top = cbSpecializations.Top;
            btnDbCheck_Click(sender, e);
        }

        private void btnDbCheck_Click(object sender, EventArgs e)
        {
            try
            {
                lblDbState.Text = AppLogic.CheckDb();

                cbDoctors.DataSource = Docs.List();
                cbSpecializations.DataSource = Spec.List();
                cbCertificates.DataSource = Cert.List(((Doctor)cbDoctors.SelectedItem).Id);

                grCerts.DataSource = Cert.ListAll();
                grCerts.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewSpec_Click(object sender, EventArgs e)
        {
            if (btnNewSpec.Text == "New")
            {
                txtSpec.Text = "";
                txtSpec.Visible = true;
                btnNewSpec.Text = "Add";
                txtSpec.Select();
            }
            else
            {
                txtSpec.Visible = false;
                btnNewSpec.Text = "New";

                Spec.Add(txtSpec.Text);
            
                cbSpecializations.DataSource = Spec.List();

            }
        }

        private void btnEditSpec_Click(object sender, EventArgs e)
        {
            Specialization spec = (Specialization)cbSpecializations.SelectedItem;
            if (btnEditSpec.Text == "Edit")
            {
                txtSpec.Text = spec.Name;
                txtSpec.Visible = true;
                btnEditSpec.Text = "Save";
                txtSpec.Select();
            }
            else
            {
                txtSpec.Visible = false;
                btnEditSpec.Text = "Edit";

                Spec.Edit(spec.Id, txtSpec.Text);

                int idx = cbSpecializations.SelectedIndex;
                cbSpecializations.DataSource = Spec.List();
                cbSpecializations.SelectedIndex = idx;
            }
        }

        private void btnDelSpec_Click(object sender, EventArgs e)
        {
            int id = ((Specialization)cbSpecializations.SelectedItem).Id;
            Spec.Del(id);

            cbSpecializations.DataSource = AppLogic.GetSpecializations(); 

        }

        private void btnNewDoc_Click(object sender, EventArgs e)
        {
            if (btnNewDoc.Text == "New")
            {
                btnNewDoc.Text = "Add";
                txtDoctor.Enabled = true;
                txtDoctor.Select();
            }
            else
            {
                btnNewDoc.Text = "New";
                txtDoctor.Enabled = false;

                Docs.Add(txtDoctor.Text, ((Specialization)cbSpecializations.SelectedItem).Id);

                cbDoctors.DataSource = AppLogic.GetDoctors(); 

            }

            txtDoctor.Text = "";

        }

        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Specialization s in cbSpecializations.Items)
            {
                if(s.Id == ((Doctor)cbDoctors.SelectedItem).SpecializationId)
                {
                    cbSpecializations.SelectedItem = s;
                    break;
                }
            }
            if (AppLogic.GetDocCertificates(((Doctor)cbDoctors.SelectedItem).Id).Count == 0)
                lblLatestCert.Text = "0";
            else
            {
                int docId = ((Doctor)cbDoctors.SelectedItem).Id;
                lblLatestCert.Text = AppLogic.GetLatestCertDate(docId).ToString();
            }
            cbCertificates.DataSource = AppLogic.GetDocCertificates(((Doctor)cbDoctors.SelectedItem).Id);

        }

        private void btnEditDoc_Click(object sender, EventArgs e)
        {
            Doctor doc = (Doctor)cbDoctors.SelectedItem;
            Specialization spe = (Specialization)cbSpecializations.SelectedItem;

            if (btnEditDoc.Text == "Edit")
            {
                txtDoctor.Text = doc.Name;
                txtDoctor.Enabled = true;
                btnEditDoc.Text = "Save";
                txtDoctor.Select();
            }
            else
            {
                txtDoctor.Enabled = false;
                btnEditDoc.Text = "Edit";

                Docs.Edit(doc.Id, txtDoctor.Text, spe.Id);

                int idx = cbDoctors.SelectedIndex;
                cbDoctors.DataSource = Docs.List();
                cbDoctors.SelectedIndex = idx;
            }
        }

        private void btnDelDoc_Click(object sender, EventArgs e)
        {
            int id = ((Doctor)cbDoctors.SelectedItem).Id;
            Docs.Del(id);

            cbDoctors.DataSource = Docs.List();

        }

        private void btnNewSert_Click(object sender, EventArgs e)
        {
            if (btnNewCert.Text == "New")
            {
                btnNewCert.Text = "Add";
                txtCert.Enabled = true;
                dateTimePicker.Enabled = true;
                txtCert.Select();
                dateTimePicker.Select();
            }
            else
            {
                btnNewCert.Text = "New";
                txtCert.Enabled = false;
                dateTimePicker.Enabled = false;

                try
                {
                    int docId = ((Doctor)cbDoctors.SelectedItem).Id;
                    Cert.Add(docId, txtCert.Text, dateTimePicker.Value);
                    cbCertificates.DataSource = Cert.List(docId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            txtCert.Text = "";
        }

        private void btnEditCert_Click(object sender, EventArgs e)
        {
            Certificate cert = (Certificate)cbCertificates.SelectedItem;
            if (btnEditCert.Text == "Edit")
            {
                txtCert.Text = cert.Description;
                txtCert.Enabled = true;
                dateTimePicker.Enabled = true;
                btnEditCert.Text = "Save";
                txtCert.Select();
            }
            else
            {
                txtCert.Enabled = false;
                dateTimePicker.Enabled = false;
                btnEditCert.Text = "Edit";
                try
                {
                    Cert.Edit(cert.Id, txtCert.Text, dateTimePicker.Value);
                    cbCertificates.DataSource = Cert.List(cert.DoctorId);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDelSert_Click(object sender, EventArgs e)
        {
            int id = ((Certificate)cbCertificates.SelectedItem).Id;
            Cert.Del(id);

            int docId = ((Doctor)cbDoctors.SelectedItem).Id;
            cbCertificates.DataSource = Cert.List(docId);

        }

        private void cbSpecializations_SelectedIndexChanged(object sender, EventArgs e)
        {
            int specId = ((Specialization)cbSpecializations.SelectedItem).Id;
            lblKdps.Text = AppLogic.GetDocCount(specId).ToString();
        }

        private void cbCerts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int certId = ((Certificate)cbCertificates.SelectedItem).Id;
            lblSpec.Text = AppLogic.GetSpecializationToCert(certId);
        }


        private void txtCert_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDoctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}
