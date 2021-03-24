
namespace EasyTravelRolling
{
    partial class TravelRoller
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxRollWierdness = new System.Windows.Forms.CheckBox();
            this.uxOptionsGroup = new System.Windows.Forms.GroupBox();
            this.uxRollStuff = new System.Windows.Forms.Button();
            this.uxButtonPanel = new System.Windows.Forms.GroupBox();
            this.uxOutputGroup = new System.Windows.Forms.GroupBox();
            this.uxRollOutput = new System.Windows.Forms.TextBox();
            this.uxOptionsGroup.SuspendLayout();
            this.uxButtonPanel.SuspendLayout();
            this.uxOutputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxRollWierdness
            // 
            this.uxRollWierdness.AutoSize = true;
            this.uxRollWierdness.BackColor = System.Drawing.Color.DimGray;
            this.uxRollWierdness.Location = new System.Drawing.Point(14, 30);
            this.uxRollWierdness.Name = "uxRollWierdness";
            this.uxRollWierdness.Size = new System.Drawing.Size(204, 24);
            this.uxRollWierdness.TabIndex = 0;
            this.uxRollWierdness.Text = "Roll For Spatial Wierdness";
            this.uxRollWierdness.UseVisualStyleBackColor = false;
            // 
            // uxOptionsGroup
            // 
            this.uxOptionsGroup.Controls.Add(this.uxRollWierdness);
            this.uxOptionsGroup.Location = new System.Drawing.Point(12, 19);
            this.uxOptionsGroup.Name = "uxOptionsGroup";
            this.uxOptionsGroup.Size = new System.Drawing.Size(401, 72);
            this.uxOptionsGroup.TabIndex = 1;
            this.uxOptionsGroup.TabStop = false;
            // 
            // uxRollStuff
            // 
            this.uxRollStuff.BackColor = System.Drawing.Color.DimGray;
            this.uxRollStuff.Location = new System.Drawing.Point(15, 32);
            this.uxRollStuff.Name = "uxRollStuff";
            this.uxRollStuff.Size = new System.Drawing.Size(94, 29);
            this.uxRollStuff.TabIndex = 1;
            this.uxRollStuff.Text = "Roll Stuff";
            this.uxRollStuff.UseVisualStyleBackColor = false;
            this.uxRollStuff.Click += new System.EventHandler(this.RollStuff);
            // 
            // uxButtonPanel
            // 
            this.uxButtonPanel.Controls.Add(this.uxRollStuff);
            this.uxButtonPanel.Location = new System.Drawing.Point(419, 19);
            this.uxButtonPanel.Name = "uxButtonPanel";
            this.uxButtonPanel.Size = new System.Drawing.Size(369, 72);
            this.uxButtonPanel.TabIndex = 2;
            this.uxButtonPanel.TabStop = false;
            // 
            // uxOutputGroup
            // 
            this.uxOutputGroup.Controls.Add(this.uxRollOutput);
            this.uxOutputGroup.Location = new System.Drawing.Point(12, 97);
            this.uxOutputGroup.Name = "uxOutputGroup";
            this.uxOutputGroup.Size = new System.Drawing.Size(776, 341);
            this.uxOutputGroup.TabIndex = 3;
            this.uxOutputGroup.TabStop = false;
            // 
            // uxRollOutput
            // 
            this.uxRollOutput.BackColor = System.Drawing.Color.DimGray;
            this.uxRollOutput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uxRollOutput.Location = new System.Drawing.Point(6, 26);
            this.uxRollOutput.Multiline = true;
            this.uxRollOutput.Name = "uxRollOutput";
            this.uxRollOutput.Size = new System.Drawing.Size(764, 309);
            this.uxRollOutput.TabIndex = 0;
            // 
            // TravelRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxOutputGroup);
            this.Controls.Add(this.uxButtonPanel);
            this.Controls.Add(this.uxOptionsGroup);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TravelRoller";
            this.Text = "Easy Travel Roller";
            this.uxOptionsGroup.ResumeLayout(false);
            this.uxOptionsGroup.PerformLayout();
            this.uxButtonPanel.ResumeLayout(false);
            this.uxOutputGroup.ResumeLayout(false);
            this.uxOutputGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox uxRollWierdness;
        private System.Windows.Forms.GroupBox uxOptionsGroup;
        private System.Windows.Forms.Button uxRollStuff;
        private System.Windows.Forms.GroupBox uxButtonPanel;
        private System.Windows.Forms.GroupBox uxOutputGroup;
        private System.Windows.Forms.TextBox uxRollOutput;
    }
}

