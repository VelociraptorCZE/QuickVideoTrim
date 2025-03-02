/**
 * QuickVideoTrim
 * Copyright (c) Simon Raichl 2025
 */

namespace QuickVideoTrim
{
    partial class QuickVideoTrimApp
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
            this.importVideoButton = new System.Windows.Forms.Button();
            this.exportVideoButton = new System.Windows.Forms.Button();
            this.trimStart = new System.Windows.Forms.TextBox();
            this.trimEnd = new System.Windows.Forms.TextBox();
            this.SignatureLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.importVideoDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportVideoDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // importVideoButton
            // 
            this.importVideoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importVideoButton.Location = new System.Drawing.Point(13, 13);
            this.importVideoButton.Name = "importVideoButton";
            this.importVideoButton.Size = new System.Drawing.Size(147, 36);
            this.importVideoButton.TabIndex = 0;
            this.importVideoButton.Text = "Import video";
            this.importVideoButton.UseVisualStyleBackColor = true;
            this.importVideoButton.Click += new System.EventHandler(this.ImportVideoButtonOnClick);
            // 
            // exportVideoButton
            // 
            this.exportVideoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportVideoButton.Location = new System.Drawing.Point(165, 12);
            this.exportVideoButton.Name = "exportVideoButton";
            this.exportVideoButton.Size = new System.Drawing.Size(147, 36);
            this.exportVideoButton.TabIndex = 1;
            this.exportVideoButton.Text = "Export video";
            this.exportVideoButton.UseVisualStyleBackColor = true;
            this.exportVideoButton.Click += new System.EventHandler(this.ExportVideoButtonOnClick);
            // 
            // trimStart
            // 
            this.trimStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trimStart.Location = new System.Drawing.Point(13, 93);
            this.trimStart.Name = "trimStart";
            this.trimStart.Size = new System.Drawing.Size(147, 28);
            this.trimStart.TabIndex = 2;
            this.trimStart.Text = "00:00:00";
            // 
            // trimEnd
            // 
            this.trimEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trimEnd.Location = new System.Drawing.Point(165, 93);
            this.trimEnd.Name = "trimEnd";
            this.trimEnd.Size = new System.Drawing.Size(147, 28);
            this.trimEnd.TabIndex = 3;
            this.trimEnd.Text = "00:00:00";
            // 
            // SignatureLabel
            // 
            this.SignatureLabel.AutoSize = true;
            this.SignatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignatureLabel.Location = new System.Drawing.Point(178, 146);
            this.SignatureLabel.Name = "SignatureLabel";
            this.SignatureLabel.Size = new System.Drawing.Size(144, 13);
            this.SignatureLabel.TabIndex = 4;
            this.SignatureLabel.Text = "Made by Šimon Raichl (2025)";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(12, 70);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(45, 20);
            this.startLabel.TabIndex = 5;
            this.startLabel.Text = "Start";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(162, 70);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(38, 20);
            this.endLabel.TabIndex = 6;
            this.endLabel.Text = "End";
            // 
            // importVideoDialog
            // 
            this.importVideoDialog.Title = "Import video to trim";
            // 
            // exportVideoDialog
            // 
            this.exportVideoDialog.Title = "Export video as";
            // 
            // QuickVideoTrimApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 159);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.SignatureLabel);
            this.Controls.Add(this.trimEnd);
            this.Controls.Add(this.trimStart);
            this.Controls.Add(this.exportVideoButton);
            this.Controls.Add(this.importVideoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuickVideoTrimApp";
            this.Text = "QuickVideoTrim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importVideoButton;
        private System.Windows.Forms.Button exportVideoButton;
        private System.Windows.Forms.TextBox trimStart;
        private System.Windows.Forms.TextBox trimEnd;
        private System.Windows.Forms.Label SignatureLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.OpenFileDialog importVideoDialog;
        private System.Windows.Forms.SaveFileDialog exportVideoDialog;
    }
}

