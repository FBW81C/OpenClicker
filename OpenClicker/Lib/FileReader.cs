using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using OpenClicker.Exceptions;
using OpenClicker.Models;

namespace OpenClicker.Lib;
public static class FileReader
{
    public static ClickPattern GetProfile(string? filepath = null)
    {
        ClickPattern pattern = FromFile(filepath);

        try
        {
            Clicker.AssertValidClickPattern(pattern);
            return pattern;
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
            {
                return pattern;
            } 
            throw new OCOperationCanceledException();
        }
    }

    private static ClickPattern FromFile(string? path = null)
    {
        string filePath;
        if (string.IsNullOrWhiteSpace(path))
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "OpenClicker Profile (*.ocp)|*.ocp|All files (*.*)|*.*",
                RestoreDirectory = true,
                Multiselect = false,
                CheckPathExists = true,
                CheckFileExists = true
            };

            var result = openFileDialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                throw new OCOperationCanceledException();
            }

            filePath = openFileDialog.FileName;
        }
        else
        {
            filePath = path;
        }

        try
        {
            string content = File.ReadAllText(filePath);
            var pattern = JsonSerializer.Deserialize<ClickPattern>(content);

            return pattern ?? throw new OCInvalidFile("file corrupted");
        }
        catch (Exception ex)
        {
            throw new OCInvalidFile($"File couldn't be read:\n{ex.Message}");
        }
    }

    public static string SaveProfile(ClickPattern pattern, string? filepath = null)
    {
        string json;
        try
        {
            json = JsonSerializer.Serialize(pattern);
        }
        catch (Exception ex)
        {
            throw new OCInvalidFile($"Failed to save file:\n{ex.Message}");
        }

        if (string.IsNullOrEmpty(filepath))
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "OpenClicker Profile (*.ocp)|*.ocp|All files (*.*)|*.*",
                DefaultExt = "ocp",
                AddExtension = true,
                OverwritePrompt = true,
                RestoreDirectory = true,
                CheckPathExists = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFileDialog.FileName;
            } 
            else
            {
                throw new OCOperationCanceledException();
            }
        }
            
        try
        {
            File.WriteAllText(filepath, json);
            return filepath;
        } 
        catch (Exception ex)
        {
            throw new OCInvalidFile(ex.Message);
        }
    }
}
