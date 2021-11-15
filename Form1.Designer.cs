namespace ShowPalette
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DXFReaderNET.DxfDocument dxfDocument1 = new DXFReaderNET.DxfDocument();
            DXFReaderNET.AciColor aciColor1 = new DXFReaderNET.AciColor();
            DXFReaderNET.Objects.RasterVariables rasterVariables1 = new DXFReaderNET.Objects.RasterVariables();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dxfReaderNETControl1 = new DXFReaderNET.DXFReaderNETControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dxfReaderNETControl1
            // 
            this.dxfReaderNETControl1.AutoSize = true;
            this.dxfReaderNETControl1.ContinuousHighlight = false;
            this.dxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None;
            this.dxfReaderNETControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            dxfDocument1.ActiveLayout = "Model";
            dxfDocument1.Comments = null;
            aciColor1.Index = ((short)(256));
            aciColor1.IsByBlock = false;
            aciColor1.IsByLayer = true;
            aciColor1.UseTrueColor = false;
            dxfDocument1.CurrentColor = aciColor1;
            dxfDocument1.CurrentElevation = 0D;
            dxfDocument1.CurrentLayer = "0";
            dxfDocument1.CurrentLineTypeName = "ByLayer";
            dxfDocument1.CurrentLineTypeScale = 1D;
            dxfDocument1.CurrentTextSize = 2.5D;
            dxfDocument1.CurrentTextStyle = "STANDARD";
            dxfDocument1.CurrentThickness = 0D;
            dxfDocument1.DateCreated = new System.DateTime(2020, 2, 7, 10, 17, 22, 163);
            dxfDocument1.DateLastEdited = new System.DateTime(2020, 2, 7, 10, 17, 22, 163);
            dxfDocument1.Handle = "0";
            dxfDocument1.IsBinary = false;
            dxfDocument1.Modified = false;
            dxfDocument1.Name = null;
            dxfDocument1.Owner = null;
            rasterVariables1.DisplayFrame = true;
            rasterVariables1.DisplayQuality = DXFReaderNET.Objects.ImageDisplayQuality.High;
            rasterVariables1.Handle = "2D";
            rasterVariables1.Owner = null;
            rasterVariables1.Units = DXFReaderNET.ImageUnits.Unitless;
            dxfDocument1.RasterVariables = rasterVariables1;
            dxfDocument1.ThumbnailImage = null;
            dxfDocument1.TotalEditTime = new System.DateTime(2020, 2, 7, 0, 0, 0, 0);
            dxfDocument1.TotalEditTimeDays = 0;
            dxfDocument1.UserTimer = new System.DateTime(2020, 2, 7, 0, 0, 0, 0);
            dxfDocument1.UserTimerDays = 0;
            this.dxfReaderNETControl1.DXF = dxfDocument1;
            this.dxfReaderNETControl1.FileName = null;
            this.dxfReaderNETControl1.HighlightMarkerColor2 = System.Drawing.Color.Magenta;
            this.dxfReaderNETControl1.Location = new System.Drawing.Point(0, 0);
            this.dxfReaderNETControl1.Name = "dxfReaderNETControl1";
            this.dxfReaderNETControl1.ShowAxes = false;
            this.dxfReaderNETControl1.ShowGrid = true;
            this.dxfReaderNETControl1.ShowGridRuler = false;
            this.dxfReaderNETControl1.Size = new System.Drawing.Size(790, 442);
            this.dxfReaderNETControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "换颜色";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 442);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dxfReaderNETControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DXFReader.NET Component - ShowPalette Sample ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DXFReaderNET.DXFReaderNETControl dxfReaderNETControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

