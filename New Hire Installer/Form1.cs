using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using New_Hire_Installer.Common;
using New_Hire_Installer.Custom_Controls;
using New_Hire_Installer.Properties;

namespace New_Hire_Installer;

public partial class Form1 : Form
{
    private static readonly Color ErrorColor = Color.FromArgb(250, 0, 0);
    private static readonly Color NormalColor = Color.FromArgb(186, 40, 255);

    private Worker? _bw;

    public Form1()
    {
        InitializeComponent();
        Region = Region.FromHrgn(Window.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        WindowState = FormWindowState.Normal;
        errorProvider.SetIconPadding(msiTB, -5);
        errorProvider.SetIconPadding(folderTB, -5);
    }

    private void CloseBT_Click(object sender, EventArgs e) => Close();

    private void MinimizeBT_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

    private void MsiPB_Click(object sender, EventArgs e) => FolderSelector(msiTB);

    private void FolderPB_Click(object sender, EventArgs e) => FolderSelector(folderTB);

    private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e) => infoLB.Text = e.UserState?.ToString();

    private void MsiTB_Validating(object sender, CancelEventArgs e) => e.Cancel = msiTB.MsiValidator();

    private void FolderTB_Validating(object sender, CancelEventArgs e) => e.Cancel = folderTB.FolderValidator();

    private void FolderTB_TextChanged(object sender, EventArgs e) => folderTB.FolderValidator();

    private void MsiTB_TextChanged(object sender, EventArgs e) => msiTB.MsiValidator();

    private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        loadingPB.SendToBack();
        infoLB.Text = @"New Hire Installer Complete!";
        _bw = null;
    }

    private void TitleBarPN_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;

        Window.ReleaseCapture();
        _ = Window.SendMessage(Handle, Window.WM_NCLBUTTONDOWN, Window.HT_CAPTION, 0);
    }

    private static void FolderSelector(Control textBox)
    {
        using var folderSelect = new FolderBrowserDialog();

        if (folderSelect.ShowDialog() == DialogResult.OK)
            textBox.Text = folderSelect.SelectedPath;
    }

    private void SubmitBT_Click(object sender, EventArgs e)
    {
        if (!ValidateChildren()) return;

        loadingPB.BringToFront();

        _bw = new Worker(msiTB.Text, folderTB.Text);

        _bw.ProgressChanged += BackgroundWorker_ProgressChanged;
        _bw.WorkComplete += BackgroundWorker_RunWorkerCompleted;
        _bw.Run();
    }

    public static void MsiStyle(bool isValid)
    {
        msiTB.ForeColor = isValid ? NormalColor : ErrorColor;
        msiPN.BackColor = isValid ? NormalColor : ErrorColor;
        msiPB.Image = isValid ? Resources.software_gradient_35 : Resources.software_red_35;
    }

    public static void FolderStyle(bool isValid)
    {
        folderTB.ForeColor = isValid ? NormalColor : ErrorColor;
        folderPN.BackColor = isValid ? NormalColor : ErrorColor;
        folderPB.Image = isValid ? Resources.add_folder_gradient_35 : Resources.add_folder_red_35;
    }

}