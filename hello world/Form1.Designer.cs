
namespace hello_world
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
            this.mtCbx = new MaterialSkin.Controls.MaterialComboBox();
            this.scanBtn = new MaterialSkin.Controls.MaterialButton();
            this.eraseBtn = new MaterialSkin.Controls.MaterialButton();
            this.recoveryBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // mtCbx
            // 
            this.mtCbx.AutoResize = false;
            this.mtCbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtCbx.Depth = 0;
            this.mtCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mtCbx.DropDownHeight = 118;
            this.mtCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mtCbx.DropDownWidth = 121;
            this.mtCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mtCbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtCbx.FormattingEnabled = true;
            this.mtCbx.IntegralHeight = false;
            this.mtCbx.ItemHeight = 29;
            this.mtCbx.Location = new System.Drawing.Point(12, 75);
            this.mtCbx.MaxDropDownItems = 4;
            this.mtCbx.MouseState = MaterialSkin.MouseState.OUT;
            this.mtCbx.Name = "mtCbx";
            this.mtCbx.Size = new System.Drawing.Size(180, 35);
            this.mtCbx.TabIndex = 14;
            this.mtCbx.UseTallSize = false;
            // 
            // scanBtn
            // 
            this.scanBtn.AutoSize = false;
            this.scanBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scanBtn.Depth = 0;
            this.scanBtn.DrawShadows = true;
            this.scanBtn.HighEmphasis = true;
            this.scanBtn.Icon = null;
            this.scanBtn.Location = new System.Drawing.Point(228, 75);
            this.scanBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.scanBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(68, 35);
            this.scanBtn.TabIndex = 17;
            this.scanBtn.Text = "Scan";
            this.scanBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.scanBtn.UseAccentColor = false;
            this.scanBtn.UseVisualStyleBackColor = true;
            // 
            // eraseBtn
            // 
            this.eraseBtn.AutoSize = false;
            this.eraseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eraseBtn.Depth = 0;
            this.eraseBtn.DrawShadows = true;
            this.eraseBtn.HighEmphasis = true;
            this.eraseBtn.Icon = null;
            this.eraseBtn.Location = new System.Drawing.Point(319, 75);
            this.eraseBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eraseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(69, 35);
            this.eraseBtn.TabIndex = 13;
            this.eraseBtn.Text = "Erase";
            this.eraseBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eraseBtn.UseAccentColor = false;
            this.eraseBtn.UseVisualStyleBackColor = true;
            this.eraseBtn.Click += new System.EventHandler(this.eraseBtn_Click);
            // 
            // recoveryBtn
            // 
            this.recoveryBtn.AutoSize = false;
            this.recoveryBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.recoveryBtn.Depth = 0;
            this.recoveryBtn.DrawShadows = true;
            this.recoveryBtn.HighEmphasis = true;
            this.recoveryBtn.Icon = null;
            this.recoveryBtn.Location = new System.Drawing.Point(640, 409);
            this.recoveryBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.recoveryBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.recoveryBtn.Name = "recoveryBtn";
            this.recoveryBtn.Size = new System.Drawing.Size(118, 35);
            this.recoveryBtn.TabIndex = 15;
            this.recoveryBtn.Text = "Recovery";
            this.recoveryBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.recoveryBtn.UseAccentColor = false;
            this.recoveryBtn.UseVisualStyleBackColor = true;
            this.recoveryBtn.Click += new System.EventHandler(this.recoveryBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 459);
            this.Controls.Add(this.mtCbx);
            this.Controls.Add(this.recoveryBtn);
            this.Controls.Add(this.eraseBtn);
            this.Controls.Add(this.scanBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Just Recovery";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox mtCbx;
        private MaterialSkin.Controls.MaterialButton eraseBtn;
        private MaterialSkin.Controls.MaterialButton scanBtn;
        private MaterialSkin.Controls.MaterialButton recoveryBtn;
    }
}

