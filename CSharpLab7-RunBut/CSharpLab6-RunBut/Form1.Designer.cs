namespace CSharpLab6_RunBut
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // butPushMe
            // 
            this.butPushMe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butPushMe.Location = new System.Drawing.Point(348, 203);
            this.butPushMe.Name = "butPushMe";
            this.butPushMe.Size = new System.Drawing.Size(75, 23);
            this.butPushMe.TabIndex = 2;
            this.butPushMe.TabStop = false;
            this.butPushMe.Text = "Push Me";
            this.butPushMe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butPushMe);
            this.Name = "Form1";
            this.Text = "Runaway Button";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.butPushMe_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butPushMe;
    }
}

