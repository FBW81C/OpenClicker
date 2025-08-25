using System;
using System.Collections.Generic;
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
    public static ClickPattern FromFile(string? path = null)
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
    public static string SaveProfile(ClickPattern pattern)
    {
        try
        {
            var json = JsonSerializer.Serialize(pattern);

            SaveFileDialog saveFileDialog = new SaveFileDialog
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
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, json);
                return filePath;
            }
            throw new OCOperationCanceledException();
        } 
        catch (OCOperationCanceledException)
        {
            throw new OCOperationCanceledException();
        }
        catch (Exception ex)
        {
            throw new OCInvalidFile($"Failed to save file:\n{ex.Message}");
        }
    }
}
