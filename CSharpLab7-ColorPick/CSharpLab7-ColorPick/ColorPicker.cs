using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLab7_ColorPick
{
    public partial class ColorPicker : Form
    {
        Size oldSize;
        public ColorPicker()
        {
            InitializeComponent();
            pBoxCanvas.BackColor = Color.FromArgb(125, 125, 125);
            // Всплывающая подсказка
            toolTipColor.SetToolTip(pBoxCanvas, ColorTranslator.ToHtml(pBoxCanvas.BackColor));

            //Сохранение пропорций
            oldSize = this.Size;
        }

        private void pBox_ChangeColor( int? r = null,  int? g = null, int? b = null)//[Optional]
        {
            if (r.HasValue)
            {
                pBoxCanvas.BackColor = Color.FromArgb(r.Value, pBoxCanvas.BackColor.G, pBoxCanvas.BackColor.B);
            }
            else
            if (g.HasValue)
            {
                pBoxCanvas.BackColor = Color.FromArgb(pBoxCanvas.BackColor.R, g.Value, pBoxCanvas.BackColor.B);
            }
            else
            if (b.HasValue)
            {
                pBoxCanvas.BackColor = Color.FromArgb(pBoxCanvas.BackColor.R, pBoxCanvas.BackColor.G, b.Value);
            }

            //добавляем в буфер
            Clipboard.SetText(ColorTranslator.ToHtml(pBoxCanvas.BackColor));
        }
        private void trackRGB_Scroll(object sender, EventArgs e)
        {
            TrackBar trackAny = (TrackBar)sender;
            if(trackAny.Tag.ToString() == "red") 
            { pBox_ChangeColor(r: trackAny.Value);}
            else if (trackAny.Tag.ToString() == "green")
            { pBox_ChangeColor(g: trackAny.Value); }
            else if(trackAny.Tag.ToString() == "blue")
            { pBox_ChangeColor(b: trackAny.Value); }


        }

        private void pBoxCanvas_MouseHover(object sender, EventArgs e)
        {
            System.Drawing.Point mousePosition = Cursor.Position;
                //this.PointToClient(MousePosition) x
            //pBoxCanvas.PointToClient(mousePosition);

            //убрать duration и добавить событие на MouseLeave
            toolTipColor.Show(ColorTranslator.ToHtml(pBoxCanvas.BackColor), 
                pBoxCanvas, pBoxCanvas.PointToClient(mousePosition), 3600);
        }

        private void pBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            //toolTipColor.
            //toolTipColor.Placement = System.Windows.Controls.Primitives.PlacementMode.Relative;
            // двигать подсказку вместе с указателем
            //toolTipColor.HorizontalOffset = e.GetPosition((IInputElement)sender).X + 16;
            //toolTipColor.VerticalOffset = e.GetPosition((IInputElement)sender).Y + 16;
            
        }

        private void ColorPicker_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            // ? добавить сравнение исходных width / height с новыми
            control.Size = new Size(control.Size.Width, (int)control.Size.Height*(oldSize.Width/oldSize.Height));
            // Ensure the Form remains square (Height = Width).
            //if (control.Size.Height != control.Size.Width)
            //{
            //    control.Size = new Size(control.Size.Width, control.Size.Width);
            //}
        }
    }
}
