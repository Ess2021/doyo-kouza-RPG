
namespace doyo_kouza_RPG {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.EnsPic = new System.Windows.Forms.PictureBox();
            this.EnsHP = new System.Windows.Forms.Label();
            this.Console = new System.Windows.Forms.TextBox();
            this.MyHP = new System.Windows.Forms.Label();
            this.Sword = new System.Windows.Forms.Button();
            this.Magic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EnsPic)).BeginInit();
            this.SuspendLayout();
            // 
            // EnsPic
            // 
            this.EnsPic.Location = new System.Drawing.Point(13, 13);
            this.EnsPic.Name = "EnsPic";
            this.EnsPic.Size = new System.Drawing.Size(259, 148);
            this.EnsPic.TabIndex = 0;
            this.EnsPic.TabStop = false;
            // 
            // EnsHP
            // 
            this.EnsHP.AutoSize = true;
            this.EnsHP.Location = new System.Drawing.Point(12, 193);
            this.EnsHP.Name = "EnsHP";
            this.EnsHP.Size = new System.Drawing.Size(38, 15);
            this.EnsHP.TabIndex = 1;
            this.EnsHP.Text = "label1";
            // 
            // Console
            // 
            this.Console.Location = new System.Drawing.Point(13, 167);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(259, 23);
            this.Console.TabIndex = 2;
            // 
            // MyHP
            // 
            this.MyHP.AutoSize = true;
            this.MyHP.Location = new System.Drawing.Point(146, 193);
            this.MyHP.Name = "MyHP";
            this.MyHP.Size = new System.Drawing.Size(38, 15);
            this.MyHP.TabIndex = 1;
            this.MyHP.Text = "label1";
            // 
            // Sword
            // 
            this.Sword.Location = new System.Drawing.Point(13, 212);
            this.Sword.Name = "Sword";
            this.Sword.Size = new System.Drawing.Size(126, 37);
            this.Sword.TabIndex = 3;
            this.Sword.Text = "剣";
            this.Sword.UseVisualStyleBackColor = true;
            this.Sword.Click += new System.EventHandler(this.Sword_Click);
            // 
            // Magic
            // 
            this.Magic.Location = new System.Drawing.Point(146, 212);
            this.Magic.Name = "Magic";
            this.Magic.Size = new System.Drawing.Size(126, 37);
            this.Magic.TabIndex = 3;
            this.Magic.Text = "魔法";
            this.Magic.UseVisualStyleBackColor = true;
            this.Magic.Click += new System.EventHandler(this.Magic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Magic);
            this.Controls.Add(this.Sword);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.MyHP);
            this.Controls.Add(this.EnsHP);
            this.Controls.Add(this.EnsPic);
            this.Name = "Form1";
            this.Text = "土曜講座 - RPG";
            ((System.ComponentModel.ISupportInitialize)(this.EnsPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EnsPic;
        private System.Windows.Forms.Label EnsHP;
        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.Label MyHP;
        private System.Windows.Forms.Button Sword;
        private System.Windows.Forms.Button Magic;
    }
}

