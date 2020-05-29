namespace CSharpLab7_ColorPick
{
    partial class ColorPicker
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutControls = new System.Windows.Forms.TableLayoutPanel();
            this.tblLabelsGreen = new System.Windows.Forms.TableLayoutPanel();
            this.lblGreen255 = new System.Windows.Forms.Label();
            this.lblGreen0 = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.trackGreen = new System.Windows.Forms.TrackBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.trackRed = new System.Windows.Forms.TrackBar();
            this.tblLabelsBlue = new System.Windows.Forms.TableLayoutPanel();
            this.lblBlue255 = new System.Windows.Forms.Label();
            this.lblBlue0 = new System.Windows.Forms.Label();
            this.tblLabelsRed = new System.Windows.Forms.TableLayoutPanel();
            this.lblRed255 = new System.Windows.Forms.Label();
            this.lblRed0 = new System.Windows.Forms.Label();
            this.trackBlue = new System.Windows.Forms.TrackBar();
            this.pBoxCanvas = new System.Windows.Forms.PictureBox();
            this.toolTipColor = new System.Windows.Forms.ToolTip(this.components);
            this.tblMainLayout.SuspendLayout();
            this.tblLayoutControls.SuspendLayout();
            this.tblLabelsGreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
            this.tblLabelsBlue.SuspendLayout();
            this.tblLabelsRed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMainLayout
            // 
            this.tblMainLayout.ColumnCount = 2;
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.09164F));
            this.tblMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.90836F));
            this.tblMainLayout.Controls.Add(this.tblLayoutControls, 1, 0);
            this.tblMainLayout.Controls.Add(this.pBoxCanvas, 0, 0);
            this.tblMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainLayout.Location = new System.Drawing.Point(0, 0);
            this.tblMainLayout.Name = "tblMainLayout";
            this.tblMainLayout.RowCount = 1;
            this.tblMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainLayout.Size = new System.Drawing.Size(523, 233);
            this.tblMainLayout.TabIndex = 0;
            // 
            // tblLayoutControls
            // 
            this.tblLayoutControls.ColumnCount = 2;
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.17293F));
            this.tblLayoutControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.82706F));
            this.tblLayoutControls.Controls.Add(this.tblLabelsGreen, 1, 3);
            this.tblLayoutControls.Controls.Add(this.lblBlue, 0, 4);
            this.tblLayoutControls.Controls.Add(this.lblGreen, 0, 2);
            this.tblLayoutControls.Controls.Add(this.trackGreen, 1, 2);
            this.tblLayoutControls.Controls.Add(this.lblRed, 0, 0);
            this.tblLayoutControls.Controls.Add(this.trackRed, 1, 0);
            this.tblLayoutControls.Controls.Add(this.tblLabelsBlue, 1, 5);
            this.tblLayoutControls.Controls.Add(this.tblLabelsRed, 1, 1);
            this.tblLayoutControls.Controls.Add(this.trackBlue, 1, 4);
            this.tblLayoutControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutControls.Location = new System.Drawing.Point(241, 10);
            this.tblLayoutControls.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.tblLayoutControls.Name = "tblLayoutControls";
            this.tblLayoutControls.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tblLayoutControls.RowCount = 6;
            this.tblLayoutControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayoutControls.Size = new System.Drawing.Size(272, 213);
            this.tblLayoutControls.TabIndex = 0;
            // 
            // tblLabelsGreen
            // 
            this.tblLabelsGreen.AutoSize = true;
            this.tblLabelsGreen.ColumnCount = 2;
            this.tblLabelsGreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLabelsGreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLabelsGreen.Controls.Add(this.lblGreen255, 0, 0);
            this.tblLabelsGreen.Controls.Add(this.lblGreen0, 0, 0);
            this.tblLabelsGreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLabelsGreen.Location = new System.Drawing.Point(57, 116);
            this.tblLabelsGreen.Name = "tblLabelsGreen";
            this.tblLabelsGreen.RowCount = 1;
            this.tblLabelsGreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLabelsGreen.Size = new System.Drawing.Size(209, 19);
            this.tblLabelsGreen.TabIndex = 4;
            // 
            // lblGreen255
            // 
            this.lblGreen255.AutoSize = true;
            this.lblGreen255.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGreen255.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGreen255.Location = new System.Drawing.Point(107, 0);
            this.lblGreen255.Name = "lblGreen255";
            this.lblGreen255.Size = new System.Drawing.Size(99, 19);
            this.lblGreen255.TabIndex = 2;
            this.lblGreen255.Text = "255";
            this.lblGreen255.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGreen0
            // 
            this.lblGreen0.AutoSize = true;
            this.lblGreen0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGreen0.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGreen0.Location = new System.Drawing.Point(3, 0);
            this.lblGreen0.Name = "lblGreen0";
            this.lblGreen0.Size = new System.Drawing.Size(98, 19);
            this.lblGreen0.TabIndex = 1;
            this.lblGreen0.Text = "0";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBlue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBlue.Location = new System.Drawing.Point(3, 143);
            this.lblBlue.Margin = new System.Windows.Forms.Padding(0);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(51, 40);
            this.lblBlue.TabIndex = 6;
            this.lblBlue.Text = "Blue:";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGreen.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGreen.Location = new System.Drawing.Point(3, 73);
            this.lblGreen.Margin = new System.Windows.Forms.Padding(0);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(51, 40);
            this.lblGreen.TabIndex = 5;
            this.lblGreen.Text = "Green:";
            // 
            // trackGreen
            // 
            this.trackGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackGreen.Location = new System.Drawing.Point(57, 76);
            this.trackGreen.Maximum = 255;
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Size = new System.Drawing.Size(209, 34);
            this.trackGreen.TabIndex = 4;
            this.trackGreen.Tag = "green";
            this.trackGreen.TickFrequency = 17;
            this.trackGreen.Value = 125;
            this.trackGreen.Scroll += new System.EventHandler(this.trackRGB_Scroll);
            this.trackGreen.ValueChanged += new System.EventHandler(this.trackRGB_Scroll);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRed.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRed.Location = new System.Drawing.Point(3, 3);
            this.lblRed.Margin = new System.Windows.Forms.Padding(0);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(51, 40);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "Red:";
            // 
            // trackRed
            // 
            this.trackRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackRed.LargeChange = 1;
            this.trackRed.Location = new System.Drawing.Point(57, 6);
            this.trackRed.Maximum = 255;
            this.trackRed.Name = "trackRed";
            this.trackRed.Size = new System.Drawing.Size(209, 34);
            this.trackRed.TabIndex = 2;
            this.trackRed.Tag = "red";
            this.trackRed.TickFrequency = 17;
            this.trackRed.Value = 125;
            this.trackRed.Scroll += new System.EventHandler(this.trackRGB_Scroll);
            this.trackRed.ValueChanged += new System.EventHandler(this.trackRGB_Scroll);
            // 
            // tblLabelsBlue
            // 
            this.tblLabelsBlue.AutoSize = true;
            this.tblLabelsBlue.ColumnCount = 2;
            this.tblLabelsBlue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLabelsBlue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLabelsBlue.Controls.Add(this.lblBlue255, 0, 0);
            this.tblLabelsBlue.Controls.Add(this.lblBlue0, 0, 0);
            this.tblLabelsBlue.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLabelsBlue.Location = new System.Drawing.Point(57, 186);
            this.tblLabelsBlue.Name = "tblLabelsBlue";
            this.tblLabelsBlue.RowCount = 1;
            this.tblLabelsBlue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLabelsBlue.Size = new System.Drawing.Size(209, 19);
            this.tblLabelsBlue.TabIndex = 4;
            // 
            // lblBlue255
            // 
            this.lblBlue255.AutoSize = true;
            this.lblBlue255.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBlue255.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBlue255.Location = new System.Drawing.Point(107, 0);
            this.lblBlue255.Name = "lblBlue255";
            this.lblBlue255.Size = new System.Drawing.Size(99, 19);
            this.lblBlue255.TabIndex = 2;
            this.lblBlue255.Text = "255";
            this.lblBlue255.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBlue0
            // 
            this.lblBlue0.AutoSize = true;
            this.lblBlue0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBlue0.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBlue0.Location = new System.Drawing.Point(3, 0);
            this.lblBlue0.Name = "lblBlue0";
            this.lblBlue0.Size = new System.Drawing.Size(98, 19);
            this.lblBlue0.TabIndex = 1;
            this.lblBlue0.Text = "0";
            // 
            // tblLabelsRed
            // 
            this.tblLabelsRed.AutoSize = true;
            this.tblLabelsRed.ColumnCount = 2;
            this.tblLabelsRed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLabelsRed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLabelsRed.Controls.Add(this.lblRed255, 0, 0);
            this.tblLabelsRed.Controls.Add(this.lblRed0, 0, 0);
            this.tblLabelsRed.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLabelsRed.Location = new System.Drawing.Point(57, 46);
            this.tblLabelsRed.Name = "tblLabelsRed";
            this.tblLabelsRed.RowCount = 1;
            this.tblLabelsRed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLabelsRed.Size = new System.Drawing.Size(209, 19);
            this.tblLabelsRed.TabIndex = 3;
            // 
            // lblRed255
            // 
            this.lblRed255.AutoSize = true;
            this.lblRed255.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRed255.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRed255.Location = new System.Drawing.Point(107, 0);
            this.lblRed255.Name = "lblRed255";
            this.lblRed255.Size = new System.Drawing.Size(99, 19);
            this.lblRed255.TabIndex = 2;
            this.lblRed255.Text = "255";
            this.lblRed255.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRed0
            // 
            this.lblRed0.AutoSize = true;
            this.lblRed0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRed0.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRed0.Location = new System.Drawing.Point(3, 0);
            this.lblRed0.Name = "lblRed0";
            this.lblRed0.Size = new System.Drawing.Size(98, 19);
            this.lblRed0.TabIndex = 1;
            this.lblRed0.Text = "0";
            // 
            // trackBlue
            // 
            this.trackBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBlue.LargeChange = 1;
            this.trackBlue.Location = new System.Drawing.Point(57, 146);
            this.trackBlue.Maximum = 255;
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Size = new System.Drawing.Size(209, 34);
            this.trackBlue.TabIndex = 7;
            this.trackBlue.Tag = "blue";
            this.trackBlue.TickFrequency = 17;
            this.trackBlue.Value = 125;
            this.trackBlue.Scroll += new System.EventHandler(this.trackRGB_Scroll);
            this.trackBlue.ValueChanged += new System.EventHandler(this.trackRGB_Scroll);
            // 
            // pBoxCanvas
            // 
            this.pBoxCanvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pBoxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxCanvas.Location = new System.Drawing.Point(10, 10);
            this.pBoxCanvas.Margin = new System.Windows.Forms.Padding(10);
            this.pBoxCanvas.Name = "pBoxCanvas";
            this.pBoxCanvas.Size = new System.Drawing.Size(221, 213);
            this.pBoxCanvas.TabIndex = 1;
            this.pBoxCanvas.TabStop = false;
            this.pBoxCanvas.MouseHover += new System.EventHandler(this.pBoxCanvas_MouseHover);
            this.pBoxCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBoxCanvas_MouseMove);
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 233);
            this.Controls.Add(this.tblMainLayout);
            this.MinimumSize = new System.Drawing.Size(541, 280);
            this.Name = "ColorPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            this.Resize += new System.EventHandler(this.ColorPicker_Resize);
            this.tblMainLayout.ResumeLayout(false);
            this.tblLayoutControls.ResumeLayout(false);
            this.tblLayoutControls.PerformLayout();
            this.tblLabelsGreen.ResumeLayout(false);
            this.tblLabelsGreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
            this.tblLabelsBlue.ResumeLayout(false);
            this.tblLabelsBlue.PerformLayout();
            this.tblLabelsRed.ResumeLayout(false);
            this.tblLabelsRed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMainLayout;
        private System.Windows.Forms.TableLayoutPanel tblLayoutControls;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.TrackBar trackRed;
        private System.Windows.Forms.PictureBox pBoxCanvas;
        private System.Windows.Forms.TableLayoutPanel tblLabelsRed;
        private System.Windows.Forms.Label lblRed255;
        private System.Windows.Forms.Label lblRed0;
        private System.Windows.Forms.TrackBar trackGreen;
        private System.Windows.Forms.TableLayoutPanel tblLabelsGreen;
        private System.Windows.Forms.Label lblGreen255;
        private System.Windows.Forms.Label lblGreen0;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.TableLayoutPanel tblLabelsBlue;
        private System.Windows.Forms.Label lblBlue255;
        private System.Windows.Forms.Label lblBlue0;
        private System.Windows.Forms.TrackBar trackBlue;
        private System.Windows.Forms.ToolTip toolTipColor;
    }
}

