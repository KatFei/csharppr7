namespace CSharpLab6_RunBut
{
    partial class RunBut
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
            this.butPushMe = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMX = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMXval = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMY = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMYval = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBX = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBXval = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBY = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBYval = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDistance = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDistval = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNewX = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNewXval = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNewY = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNewYval = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butPushMe
            // 
            this.butPushMe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butPushMe.Location = new System.Drawing.Point(348, 203);
            this.butPushMe.MaximumSize = new System.Drawing.Size(75, 23);
            this.butPushMe.MinimumSize = new System.Drawing.Size(75, 23);
            this.butPushMe.Name = "butPushMe";
            this.butPushMe.Size = new System.Drawing.Size(75, 23);
            this.butPushMe.TabIndex = 2;
            this.butPushMe.TabStop = false;
            this.butPushMe.Text = "Push Me";
            this.butPushMe.UseVisualStyleBackColor = true;
            this.butPushMe.Click += new System.EventHandler(this.butPushMe_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMX,
            this.lblMXval,
            this.lblMY,
            this.lblMYval,
            this.lblBX,
            this.lblBXval,
            this.lblBY,
            this.lblBYval,
            this.lblDistance,
            this.lblDistval,
            this.lblNewX,
            this.lblNewXval,
            this.lblNewY,
            this.lblNewYval,
            this.lblMousePosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMX
            // 
            this.lblMX.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblMX.Name = "lblMX";
            this.lblMX.Size = new System.Drawing.Size(56, 20);
            this.lblMX.Text = "Mouse X:";
            // 
            // lblMXval
            // 
            this.lblMXval.AutoSize = false;
            this.lblMXval.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblMXval.Name = "lblMXval";
            this.lblMXval.Size = new System.Drawing.Size(30, 20);
            // 
            // lblMY
            // 
            this.lblMY.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblMY.Name = "lblMY";
            this.lblMY.Size = new System.Drawing.Size(17, 20);
            this.lblMY.Text = "Y:";
            // 
            // lblMYval
            // 
            this.lblMYval.AutoSize = false;
            this.lblMYval.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblMYval.Name = "lblMYval";
            this.lblMYval.Size = new System.Drawing.Size(30, 20);
            // 
            // lblBX
            // 
            this.lblBX.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblBX.Margin = new System.Windows.Forms.Padding(20, 4, 0, 2);
            this.lblBX.Name = "lblBX";
            this.lblBX.Size = new System.Drawing.Size(56, 20);
            this.lblBX.Text = "Button X:";
            // 
            // lblBXval
            // 
            this.lblBXval.AutoSize = false;
            this.lblBXval.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblBXval.Name = "lblBXval";
            this.lblBXval.Size = new System.Drawing.Size(30, 20);
            // 
            // lblBY
            // 
            this.lblBY.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblBY.Name = "lblBY";
            this.lblBY.Size = new System.Drawing.Size(17, 20);
            this.lblBY.Text = "Y:";
            // 
            // lblBYval
            // 
            this.lblBYval.AutoSize = false;
            this.lblBYval.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblBYval.Name = "lblBYval";
            this.lblBYval.Size = new System.Drawing.Size(30, 20);
            // 
            // lblDistance
            // 
            this.lblDistance.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(20, 4, 0, 2);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(55, 20);
            this.lblDistance.Text = "Distance:";
            // 
            // lblDistval
            // 
            this.lblDistval.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblDistval.Name = "lblDistval";
            this.lblDistval.Size = new System.Drawing.Size(13, 20);
            this.lblDistval.Text = "0";
            // 
            // lblNewX
            // 
            this.lblNewX.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblNewX.Margin = new System.Windows.Forms.Padding(20, 4, 0, 2);
            this.lblNewX.Name = "lblNewX";
            this.lblNewX.Size = new System.Drawing.Size(39, 20);
            this.lblNewX.Text = "newX:";
            // 
            // lblNewXval
            // 
            this.lblNewXval.AutoSize = false;
            this.lblNewXval.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblNewXval.Name = "lblNewXval";
            this.lblNewXval.Size = new System.Drawing.Size(30, 20);
            this.lblNewXval.Text = "0";
            // 
            // lblNewY
            // 
            this.lblNewY.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblNewY.Margin = new System.Windows.Forms.Padding(20, 4, 0, 2);
            this.lblNewY.Name = "lblNewY";
            this.lblNewY.Size = new System.Drawing.Size(39, 20);
            this.lblNewY.Text = "newY:";
            // 
            // lblNewYval
            // 
            this.lblNewYval.AutoSize = false;
            this.lblNewYval.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblNewYval.Name = "lblNewYval";
            this.lblNewYval.Size = new System.Drawing.Size(30, 20);
            this.lblNewYval.Text = "0";
            // 
            // lblMousePosition
            // 
            this.lblMousePosition.AutoSize = false;
            this.lblMousePosition.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblMousePosition.Margin = new System.Windows.Forms.Padding(20, 4, 0, 2);
            this.lblMousePosition.Name = "lblMousePosition";
            this.lblMousePosition.Size = new System.Drawing.Size(61, 20);
            this.lblMousePosition.Text = "   :    ";
            // 
            // RunBut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.butPushMe);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "RunBut";
            this.Text = "Runaway Button";
            this.ResizeEnd += new System.EventHandler(this.RunBut_ResizeEnd);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.butPushMe_MouseMove);
            this.Resize += new System.EventHandler(this.RunBut_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butPushMe;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMX;
        private System.Windows.Forms.ToolStripStatusLabel lblMXval;
        private System.Windows.Forms.ToolStripStatusLabel lblMY;
        private System.Windows.Forms.ToolStripStatusLabel lblMYval;
        private System.Windows.Forms.ToolStripStatusLabel lblBX;
        private System.Windows.Forms.ToolStripStatusLabel lblBXval;
        private System.Windows.Forms.ToolStripStatusLabel lblBY;
        private System.Windows.Forms.ToolStripStatusLabel lblBYval;
        private System.Windows.Forms.ToolStripStatusLabel lblDistance;
        private System.Windows.Forms.ToolStripStatusLabel lblDistval;
        private System.Windows.Forms.ToolStripStatusLabel lblNewX;
        private System.Windows.Forms.ToolStripStatusLabel lblNewXval;
        private System.Windows.Forms.ToolStripStatusLabel lblNewY;
        private System.Windows.Forms.ToolStripStatusLabel lblNewYval;
        private System.Windows.Forms.ToolStripStatusLabel lblMousePosition;
    }
}

