using System;
using System.Windows.Forms;
using DXFReaderNET;
using DXFReaderNET.Entities;

namespace ShowPalette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private AciColor newColor;
        private void Form1_Load(object sender, EventArgs e)
        {
            dxfReaderNETControl1.NewDrawing();
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
            dxfReaderNETControl1.ReadDXF(@"..\..\drawing.dxf");
            newColor = dxfReaderNETControl1.DXF.CurrentColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPalette();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ColorPaletteDialogText = "选择颜色";
            dxfReaderNETControl1.ColorPaletteDialogButtoOkText = "好";
            dxfReaderNETControl1.ColorPaletteDialogButtonCancelText = "取消";
            dxfReaderNETControl1.ColorPaletteDialogLabelIndexColor = "索引色";
            dxfReaderNETControl1.ColorPaletteDialogLabelRGB = "红，绿，蓝";
            dxfReaderNETControl1.ColorPaletteDialogLabelColor = "颜色";
            ShowPalette();
        }

        private void ShowPalette()
        {
            newColor = dxfReaderNETControl1.ShowPalette(newColor);
            if (newColor != dxfReaderNETControl1.DXF.CurrentColor)
            {
                foreach (EntityObject entity in dxfReaderNETControl1.DXF.Entities)
                {
                    entity.Color = newColor;
                }
                dxfReaderNETControl1.Refresh();
            }
        }
    }
}
