
namespace FamilyProgramm
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.cardsButton = new System.Windows.Forms.Button();
            this.financeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardsButton
            // 
            this.cardsButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardsButton.Location = new System.Drawing.Point(12, 12);
            this.cardsButton.Name = "cardsButton";
            this.cardsButton.Size = new System.Drawing.Size(180, 62);
            this.cardsButton.TabIndex = 0;
            this.cardsButton.Text = "Карты";
            this.cardsButton.UseVisualStyleBackColor = true;
            this.cardsButton.Click += new System.EventHandler(this.cardsButton_Click);
            // 
            // financeButton
            // 
            this.financeButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.financeButton.Location = new System.Drawing.Point(960, 12);
            this.financeButton.Name = "financeButton";
            this.financeButton.Size = new System.Drawing.Size(212, 79);
            this.financeButton.TabIndex = 1;
            this.financeButton.Text = "Доходы-расходы";
            this.financeButton.UseVisualStyleBackColor = true;
            this.financeButton.Click += new System.EventHandler(this.financeButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.financeButton);
            this.Controls.Add(this.cardsButton);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Семейная программа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cardsButton;
        private System.Windows.Forms.Button financeButton;
    }
}