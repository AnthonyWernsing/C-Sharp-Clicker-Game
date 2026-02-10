
namespace Clicker_Game
{
    partial class ClickerGame
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
            this.lblCoinsAmount = new System.Windows.Forms.Label();
            this.btnClickForCash = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCoinsAmount
            // 
            this.lblCoinsAmount.AutoSize = true;
            this.lblCoinsAmount.BackColor = System.Drawing.Color.Yellow;
            this.lblCoinsAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoinsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoinsAmount.Location = new System.Drawing.Point(354, 39);
            this.lblCoinsAmount.Name = "lblCoinsAmount";
            this.lblCoinsAmount.Size = new System.Drawing.Size(116, 33);
            this.lblCoinsAmount.TabIndex = 0;
            this.lblCoinsAmount.Text = "Coins: 0";
            this.lblCoinsAmount.Click += new System.EventHandler(this.lblCoinsAmount_Click);
            // 
            // btnClickForCash
            // 
            this.btnClickForCash.AutoSize = true;
            this.btnClickForCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClickForCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickForCash.Location = new System.Drawing.Point(220, 129);
            this.btnClickForCash.Name = "btnClickForCash";
            this.btnClickForCash.Size = new System.Drawing.Size(387, 133);
            this.btnClickForCash.TabIndex = 1;
            this.btnClickForCash.Text = "Coins Per Click: 1";
            this.btnClickForCash.UseVisualStyleBackColor = false;
            this.btnClickForCash.Click += new System.EventHandler(this.btnClickForCash_Click);
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.AutoSize = true;
            this.btnUpgrade.BackColor = System.Drawing.Color.Red;
            this.btnUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpgrade.Location = new System.Drawing.Point(291, 348);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(222, 51);
            this.btnUpgrade.TabIndex = 2;
            this.btnUpgrade.Text = "Upgrade Cost: 5";
            this.btnUpgrade.UseVisualStyleBackColor = false;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // ClickerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.btnClickForCash);
            this.Controls.Add(this.lblCoinsAmount);
            this.Name = "ClickerGame";
            this.Text = "Clicker Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoinsAmount;
        private System.Windows.Forms.Button btnClickForCash;
        private System.Windows.Forms.Button btnUpgrade;
    }
}

