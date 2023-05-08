using System.Drawing.Drawing2D;
using New_Hire_Installer.Properties;

namespace New_Hire_Installer.Custom_Controls;

public class MinimizeButton : Button
{
    public MinimizeButton()
    {
        Image = Resources.minimize;
        Size = new Size(32, 32);
        FlatStyle = FlatStyle.Flat;
        ImageAlign = ContentAlignment.MiddleCenter;
        FlatAppearance.MouseDownBackColor = Color.Transparent;
        FlatAppearance.MouseOverBackColor = Color.Transparent;
        FlatAppearance.BorderSize = 0;
        base.BackColor = Color.Transparent;
        base.Text = "";
        base.Cursor = Cursors.Hand;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        using (var gp = new GraphicsPath())
        {
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new Region(gp);
        }

        base.OnPaint(pevent);
    }

    protected override void OnMouseEnter(EventArgs e) => Image = Resources.minimize_filled;

    protected override void OnMouseLeave(EventArgs e) => Image = Resources.minimize;
}