using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using OpenClicker.Exceptions;
using OpenClicker.Lib;
using OpenClicker.Models;

namespace OpenClicker;
public partial class Main
{
    private void aboutOpenClickerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        string path = Path.Combine(Application.StartupPath, "assets", "texts", "about.txt");

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
        var url = "https://github.com/FBW81C/OpenClicker";
        Process.Start("explorer", url);
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            var pattern = ParseClicks();
            var path = FileReader.SaveProfile(pattern); ;
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
        LoadProfile();
        // TODO: Update UI
    }

    private void LoadProfile(string? path = null)
    {
        try
        {
            var profile = FileReader.GetProfile(path);
            _pattern = profile;
            MessageBox.Show("Successfully loaded profile", "Profile loaded", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

    }

    private void resetDefaultToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
}

