
namespace Application_.Park_.Exercise_.Test_ {
    partial class Garage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Garage));
            this.ButtonX = new System.Windows.Forms.Button();
            this.ButtonY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonX
            // 
            this.ButtonX.BackColor = System.Drawing.Color.Blue;
            this.ButtonX.ForeColor = System.Drawing.Color.White;
            this.ButtonX.Location = new System.Drawing.Point(181, 113);
            this.ButtonX.Name = "ButtonX";
            this.ButtonX.Size = new System.Drawing.Size(75, 23);
            this.ButtonX.TabIndex = 0;
            this.ButtonX.Text = "Enter";
            this.ButtonX.UseVisualStyleBackColor = false;
            this.ButtonX.Click += new System.EventHandler(this.ButtonX_Click);
            // 
            // ButtonY
            // 
            this.ButtonY.BackColor = System.Drawing.Color.Blue;
            this.ButtonY.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonY.ForeColor = System.Drawing.Color.White;
            this.ButtonY.Location = new System.Drawing.Point(346, 113);
            this.ButtonY.Name = "ButtonY";
            this.ButtonY.Size = new System.Drawing.Size(75, 23);
            this.ButtonY.TabIndex = 1;
            this.ButtonY.Text = "ESC";
            this.ButtonY.UseVisualStyleBackColor = false;
            this.ButtonY.Click += new System.EventHandler(this.ButtonY_Click);
            // 
            // Garage
            // 
            this.AcceptButton = this.ButtonX;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.ButtonY;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonY);
            this.Controls.Add(this.ButtonX);
            this.Name = "Garage";
            this.Text = "Garage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Garage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonX;
        private System.Windows.Forms.Button ButtonY;
    }
}