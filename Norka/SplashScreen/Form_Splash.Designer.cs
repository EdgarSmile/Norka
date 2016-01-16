namespace Norka.SplashScreen
{
    partial class Form_Splash
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Splash));
          this.SuspendLayout();
          // 
          // Form_Splash
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.BackgroundImage = global::Norka.Properties.Resources.Norka_Logo;
          this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
          this.ClientSize = new System.Drawing.Size(487, 111);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
          this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          this.Name = "Form_Splash";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
          this.Text = "Splash";
          this.ResumeLayout(false);

        }

        #endregion

    }
}