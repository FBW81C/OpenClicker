using System.Diagnostics;
using OpenClicker.Exceptions;
using OpenClicker.Forms.Hotkeys;
using OpenClicker.Lib.File;

namespace OpenClicker.Forms.Main;
public partial class Main
{
    private void aboutOpenClickerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        string path = Path.Combine(Constants.TEXTS_PATH, "about.txt");

        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            MessageBox.Show(content, "About OpenClicker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("About-File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start("explorer", Constants.LINK_GITHUB);
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            var pattern = ParseClicksFromUI();
            var path = FileReader.SaveProfile(pattern);
            MessageBox.Show($"Successfully saved profile to: {path}", "Profile saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        catch (OCInvalidFile ex)
        {
            MessageBox.Show(ex.Message, "Failed to save profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 
        catch (OCOperationCanceledException)
        {
            return;
        } 
        catch (InvalidClickPatternException ex)
        {
            MessageBox.Show($"Current pattern can't be saved because it's invalid:\n\n" +
                $"{ex.Message}",
                "Failed to save profile",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LoadProfile(null, true);
    }

    private void LoadProfile(string? path = null, bool showSuccessMessage = false)
    {
        try
        {
            var profile = FileReader.GetProfile(path);
            PraseClicksToUI(profile);

            if (showSuccessMessage)
            {
                MessageBox.Show("Successfully loaded profile", "Profile loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (OCInvalidFile ex)
        {
            MessageBox.Show(ex.Message, "Failed to load profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (OCOperationCanceledException)
        {
            return;
        }

        LoadedFromFile = true;
    }

    private void setAsDefaultToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        try
        {
            var pattern = ParseClicksFromUI();
            Program.CreateSettingsFolderIfNotExist();
            FileReader.SaveProfile(pattern, Constants.DEFAULTPROFILE_PATH); ;
            MessageBox.Show($"Successfully saved default Profile!", "Default Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (OCInvalidFile ex)
        {
            MessageBox.Show(ex.Message, "Failed to save profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (OCOperationCanceledException)
        {
            return;
        }
        catch (InvalidClickPatternException ex)
        {
            MessageBox.Show($"Current pattern can't be saved because it's invalid:\n\n" +
                $"{ex.Message}",
                "Failed to save profile",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private void resetDefaultToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Program.CreateSettingsFolderIfNotExist();

        if (File.Exists(Constants.DEFAULTPROFILE_PATH))
        {
            File.Delete(Constants.DEFAULTPROFILE_PATH);
        }
        MessageBox.Show("Successfully reset default Profile!", "Default Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }



    private void hotkeysToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var form = new HotkeyEditor(_hotkeyManager);
        var result = form.ShowDialog();

        if (result == DialogResult.OK)
        {
            UpdateHotkeyButtonLabeling();
        }
    }
}

