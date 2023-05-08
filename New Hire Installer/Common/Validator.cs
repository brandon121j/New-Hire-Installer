using New_Hire_Installer.Custom_Controls;

namespace New_Hire_Installer.Common;

public static class Validator
{
    private static bool ValidPath(string path) => Directory.Exists(path);

    private static bool HasSubdirectories(string path) => Directory.GetDirectories(path, "*", SearchOption.AllDirectories).Length > 0;

    private static bool HasMsi(string path) => Directory.GetFiles(path, "*.msi").Length > 0;

    public static bool MsiValidator(this CustomTextBox tb)
    {
        var isValid = !(tb.Text.Equals(tb.PlaceholderText) || !ValidPath(tb.Text) || !HasMsi(tb.Text));

        Form1.errorProvider.SetError(tb, isValid ? "" : "Invalid Directory Path or doesn't contain .msi files");

        Form1.MsiStyle(isValid);

        return !isValid;
    }

    public static bool FolderValidator(this CustomTextBox tb)
    {
        var isValid = !(tb.Text.Equals(tb.PlaceholderText) || !ValidPath(tb.Text) || !HasSubdirectories(tb.Text));

        Form1.errorProvider.SetError(tb, isValid ? "" : "Invalid Directory Path or doesn't contain sub folders");

        Form1.FolderStyle(isValid);

        return !isValid;
    }
}