using System;
using System.Drawing;
using System.Windows.Forms;

public class TransparentTextBox : TextBox
{
    public TransparentTextBox()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        BackColor = Color.Transparent;
        BorderStyle = BorderStyle.None; // Optional: Remove border for a cleaner look
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        // Prevent background from being painted
    }
}
