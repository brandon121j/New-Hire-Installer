using System.Runtime.InteropServices.Marshalling;

namespace New_Hire_Installer.Custom_Controls;

public class CustomTextBox : RichTextBox
{
    public string PlaceholderText { get; set; } = "";
    
    public CustomTextBox()
    {
        BorderStyle = BorderStyle.None;
    }

    protected override void OnEnter(EventArgs e)
    {
        if (Text != PlaceholderText) return;
        Text = "";
    }

    protected override void OnLeave(EventArgs e)
    {
        if (Text != "") return;
        Text = PlaceholderText;
    }

}