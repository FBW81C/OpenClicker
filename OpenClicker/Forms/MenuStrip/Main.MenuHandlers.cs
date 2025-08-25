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
            MessageBox.Show($"Current pattern can't be saved because it's invaid:\n\n" +
                $"{ex.Message}",
                "Failed to save profile",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        LoadPatternFromFile();
    }

    private void LoadPatternFromFile(string? filepath = null)
    {
        ClickPattern pattern;

        try
        {
            pattern = FileReader.FromFile(filepath);
        }
        catch (OCInvalidFile ex)
        {
            MessageBox.Show(ex.Message, "Failed to load profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        catch (OCOperationCanceledException)
        {
            return;
        }

        try
        {
            Clicker.AssertValidClickPattern(pattern);
            _pattern = pattern;
        }
        catch (InvalidClickPatternException ex)
        {
            var result = MessageBox.Show(
                "The selected file does not appear to be a valid Open Clicker profile.\n" +
                "Loading it may cause errors or unexpected behavior.\n" +
                "Do you want to try loading it anyway?\n\n" +
                $"{ex.Message}",
                "Invalid Profile File",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
                _pattern = pattern;
            else
                return;
        }

        // TODO:
        //UpdateUI();

        LoadedFromFile = true;
        MessageBox.Show("Successfully loaded profile", "Profile loaded", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    private void setAsDefaultToolStripMenuItem1_Click(object sender, EventArgs e)
    {

    }

    private void resetDefaultToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
}

