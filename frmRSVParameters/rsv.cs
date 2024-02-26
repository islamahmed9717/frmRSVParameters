
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace frmRSVParameters
{
    public partial class rsv : UserControl
    {
        private List<ProfileSettings> profileSettingsList = new List<ProfileSettings>();
        private string xmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles.xml");
        private bool isEditMode = false;
        public rsv()
        {
            InitializeComponent();
            LoadProfilesFromXml();
            LoadProfilesToComboBox(); // Load profile names to the combo box when the form initializes
        }

        public class ProfileSettings
        {
            public string ProfileName { get; set; }
            public string FuelLevel { get; set; }
            public string Ballast1 { get; set; }
            public string Ballast2 { get; set; }
            public string Mass { get; set; }
            public string CGX { get; set; }
            public string CGY { get; set; }
            public string CGZ { get; set; }
            public string CBX { get; set; }
            public string CBY { get; set; }
            public string CBZ { get; set; }
            public string Draft { get; set; }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProfileName.Text))
            {
                MessageBox.Show("Please enter a profile name.");
                return;
            }

            if (isEditMode)
            {
                // Update existing profile
                ProfileSettings existingProfile = profileSettingsList.FirstOrDefault(profile => profile.ProfileName == cmbProfiles.SelectedItem.ToString());
                if (existingProfile != null)
                {
                    string newProfileName = txtProfileName.Text;
                    // Check if the new profile name is different from the existing one
                    if (existingProfile.ProfileName != newProfileName)
                    {
                        // Check if the new profile name is already in use
                        if (profileSettingsList.Any(profile => profile.ProfileName == newProfileName))
                        {
                            MessageBox.Show("Profile name already exists. Please enter a different profile name.");
                            return;
                        }

                        // Update profile name
                        existingProfile.ProfileName = newProfileName;
                    }

                    // Update other profile properties with new values
                    existingProfile.FuelLevel = txtFuelLevel.Text;
                    existingProfile.Ballast1 = txtBallast1.Text;
                    existingProfile.Ballast2 = txtBallast2.Text;
                    existingProfile.Mass = txtMass.Text;
                    existingProfile.CGX = txtCGX.Text;
                    existingProfile.CGY = txtCGY.Text;
                    existingProfile.CGZ = txtCGZ.Text;
                    existingProfile.CBX = txtCBX.Text;
                    existingProfile.CBY = txtCBY.Text;
                    existingProfile.CBZ = txtCBZ.Text;
                    existingProfile.Draft = txtDraft.Text;

                    // Save changes to XML
                    SaveProfilesToXml();

                    // Display success message
                    MessageBox.Show("Profile updated successfully!");

                    foreach (Control control in Controls)
                    {
                        if (!(control is Button))
                        {
                            control.Enabled = false;
                        }
                    }

                    // Enable the buttons
                    cmbProfiles.Enabled = true;
                    btnNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = true;

                    // Reset edit mode flag
                    isEditMode = false;
                }
                else
                {
                    MessageBox.Show("Profile not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                // Check if the profile name already exists
                if (profileSettingsList.Any(profile => profile.ProfileName == txtProfileName.Text))
                {
                    MessageBox.Show("Profile name already exists. Please enter a different profile name.");
                    return;
                }

                // Save new profile
                ProfileSettings newProfile = new ProfileSettings
                {
                    ProfileName = txtProfileName.Text,
                    FuelLevel = txtFuelLevel.Text,
                    Ballast1 = txtBallast1.Text,
                    Ballast2 = txtBallast2.Text,
                    Mass = txtMass.Text,
                    CGX = txtCGX.Text,
                    CGY = txtCGY.Text,
                    CGZ = txtCGZ.Text,
                    CBX = txtCBX.Text,
                    CBY = txtCBY.Text,
                    CBZ = txtCBZ.Text,
                    Draft = txtDraft.Text
                };

                // Add the new profile to the list
                profileSettingsList.Add(newProfile);

                // Display success message
                MessageBox.Show("New profile saved successfully!");

                // Save changes to XML and reload profiles in combobox
                SaveProfilesToXml();
                LoadProfilesToComboBox();
            }

            // Reset the form state
            cmbProfiles.Enabled = true;
        }


        private void LoadProfilesFromXml()
        {
            if (!File.Exists(xmlFilePath))
                return;

            XDocument doc = XDocument.Load(xmlFilePath);
            profileSettingsList = doc.Root.Elements("Profile")
                .Select(p => new ProfileSettings
                {
                    ProfileName = p.Element("ProfileName")?.Value,
                    FuelLevel = p.Element("FuelLevel")?.Value,
                    Ballast1 = p.Element("Ballast1")?.Value,
                    Ballast2 = p.Element("Ballast2")?.Value,
                    Mass = p.Element("Mass")?.Value,
                    CGX = p.Element("CGX")?.Value,
                    CGY = p.Element("CGY")?.Value,
                    CGZ = p.Element("CGZ")?.Value,
                    CBX = p.Element("CBX")?.Value,
                    CBY = p.Element("CBY")?.Value,
                    CBZ = p.Element("CBZ")?.Value,
                    Draft = p.Element("Draft")?.Value
                })
                .ToList();
        }

        private void SaveProfilesToXml()
        {
            XElement profilesXml = new XElement("Profiles",
                profileSettingsList.Select(profile => new XElement("Profile",
                    new XElement("ProfileName", profile.ProfileName),
                    new XElement("FuelLevel", profile.FuelLevel),
                    new XElement("Ballast1", profile.Ballast1),
                    new XElement("Ballast2", profile.Ballast2),
                    new XElement("Mass", profile.Mass),
                    new XElement("CGX", profile.CGX),
                    new XElement("CGY", profile.CGY),
                    new XElement("CGZ", profile.CGZ),
                    new XElement("CBX", profile.CBX),
                    new XElement("CBY", profile.CBY),
                    new XElement("CBZ", profile.CBZ),
                    new XElement("Draft", profile.Draft)
                ))
            );
            profilesXml.Save(xmlFilePath);
        }

        private void LoadProfilesToComboBox()
        {
            cmbProfiles.Items.Clear();
            cmbProfiles.Items.AddRange(profileSettingsList.Select(profile => profile.ProfileName).ToArray());
        }

        private void cmbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProfileName = cmbProfiles.SelectedItem?.ToString();
            ProfileSettings selectedProfile = profileSettingsList.FirstOrDefault(profile => profile.ProfileName == selectedProfileName);
            if (selectedProfile != null)
            {
                txtProfileName.Text = selectedProfile.ProfileName;
                txtFuelLevel.Text = selectedProfile.FuelLevel;
                txtBallast1.Text = selectedProfile.Ballast1;
                txtBallast2.Text = selectedProfile.Ballast2;
                txtMass.Text = selectedProfile.Mass;
                txtCGX.Text = selectedProfile.CGX;
                txtCGY.Text = selectedProfile.CGY;
                txtCGZ.Text = selectedProfile.CGZ;
                txtCBX.Text = selectedProfile.CBX;
                txtCBY.Text = selectedProfile.CBY;
                txtCBZ.Text = selectedProfile.CBZ;
                txtDraft.Text = selectedProfile.Draft;
            }

            foreach (Control control in Controls)
            {
                if (!(control is Button))
                {
                    control.Enabled = false;
                }
            }

            // Enable the buttons
            cmbProfiles.Enabled = true;
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = true;
        }


        private void ClearText()
        {
            txtProfileName.Clear();
            txtFuelLevel.Clear();
            txtBallast1.Clear();
            txtBallast2.Clear();
            txtMass.Clear();
            txtCGX.Clear();
            txtCGY.Clear();
            txtCGZ.Clear();
            txtCBX.Clear();
            txtCBY.Clear();
            txtCBZ.Clear();
            txtDraft.Clear();

            // Clear the text of the ComboBox
            cmbProfiles.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            ClearText();

            // Enable the controls
            foreach (Control control in Controls)
            {
                // Skip the combobox
                if (control != cmbProfiles)
                {
                    // Enable the control
                    control.Enabled = true;
                }
            }

            // Disable the combobox
            cmbProfiles.Enabled = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
            cmbProfiles.Enabled = false; // Disable the combobox
            btnSave.Enabled = true; // Enable the save button
            btnEdit.Enabled = false; // Disable the edit button
            isEditMode = true; // Set edit mode flag to true
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            // Check if a profile is selected
            if (cmbProfiles.SelectedItem != null)
            {
                // Get the selected profile name
                string selectedProfileName = cmbProfiles.SelectedItem.ToString();

                // Find the profile node in the XML document
                XElement profileToDelete = null;
                XDocument doc = XDocument.Load(xmlFilePath);
                foreach (XElement profile in doc.Root.Elements("Profile"))
                {
                    if (profile.Element("ProfileName")?.Value == selectedProfileName)
                    {
                        profileToDelete = profile;
                        break;
                    }
                }

                if (profileToDelete != null)
                {
                    // Remove the profile node from the XML document
                    profileToDelete.Remove();
                    doc.Save(xmlFilePath);

                    // Remove the profile name from the combobox
                    cmbProfiles.Items.Remove(selectedProfileName);

                    // Clear the textboxes
                    ClearText();

                    // Display success message
                    MessageBox.Show("Profile deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Display error message if the profile is not found
                    MessageBox.Show("Profile not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Display warning if no profile is selected
                MessageBox.Show("Please select a profile to delete first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rsv_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (!(control is Button))
                {
                    control.Enabled = false;
                }
            }

            // Enable the buttons
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
        }
    }
}




