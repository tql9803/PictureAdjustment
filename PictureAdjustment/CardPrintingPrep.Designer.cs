namespace PictureAdjustment
{
    partial class CardPrintingPrep
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
            this.tClientName = new System.Windows.Forms.TextBox();
            this.lClientName = new System.Windows.Forms.Label();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.pBMainCanvas = new System.Windows.Forms.PictureBox();
            this.tClientNum = new System.Windows.Forms.TextBox();
            this.bReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBMainCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // tClientName
            // 
            this.tClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tClientName.Location = new System.Drawing.Point(92, 525);
            this.tClientName.Name = "tClientName";
            this.tClientName.Size = new System.Drawing.Size(410, 29);
            this.tClientName.TabIndex = 0;
            // 
            // lClientName
            // 
            this.lClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lClientName.AutoSize = true;
            this.lClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClientName.Location = new System.Drawing.Point(25, 530);
            this.lClientName.Name = "lClientName";
            this.lClientName.Size = new System.Drawing.Size(61, 24);
            this.lClientName.TabIndex = 2;
            this.lClientName.Text = "Name";
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Location = new System.Drawing.Point(326, 494);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(147, 27);
            this.bUpdate.TabIndex = 2;
            this.bUpdate.Text = "Update Picture";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Location = new System.Drawing.Point(798, 204);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 60);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Save ";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // pBMainCanvas
            // 
            this.pBMainCanvas.Location = new System.Drawing.Point(29, 14);
            this.pBMainCanvas.Name = "pBMainCanvas";
            this.pBMainCanvas.Size = new System.Drawing.Size(750, 474);
            this.pBMainCanvas.TabIndex = 5;
            this.pBMainCanvas.TabStop = false;
            // 
            // tClientNum
            // 
            this.tClientNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tClientNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tClientNum.Location = new System.Drawing.Point(508, 525);
            this.tClientNum.Name = "tClientNum";
            this.tClientNum.Size = new System.Drawing.Size(271, 29);
            this.tClientNum.TabIndex = 1;
            // 
            // bReset
            // 
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.Location = new System.Drawing.Point(798, 376);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 60);
            this.bReset.TabIndex = 3;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // CardPrintingPrep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.pBMainCanvas);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.lClientName);
            this.Controls.Add(this.tClientNum);
            this.Controls.Add(this.tClientName);
            this.Name = "CardPrintingPrep";
            this.Text = "Card Imaging Preparation";
            this.Load += new System.EventHandler(this.CardPrintingPrep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBMainCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tClientName;
        private System.Windows.Forms.Label lClientName;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.PictureBox pBMainCanvas;
        private System.Windows.Forms.TextBox tClientNum;
        private System.Windows.Forms.Button bReset;
    }
}

