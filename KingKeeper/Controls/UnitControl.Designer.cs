namespace KingKeeper.Controls
{
    partial class UnitControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDexterity = new System.Windows.Forms.TextBox();
            this.txtConstitution = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCharisma = new System.Windows.Forms.TextBox();
            this.txtWisdom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIntelligence = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(73, 3);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(48, 20);
            this.txtStrength.TabIndex = 0;
            this.txtStrength.TextChanged += new System.EventHandler(this.txtStrength_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Strength:";
            // 
            // txtDexterity
            // 
            this.txtDexterity.Location = new System.Drawing.Point(73, 29);
            this.txtDexterity.Name = "txtDexterity";
            this.txtDexterity.Size = new System.Drawing.Size(48, 20);
            this.txtDexterity.TabIndex = 1;
            this.txtDexterity.TextChanged += new System.EventHandler(this.txtDexterity_TextChanged);
            // 
            // txtConstitution
            // 
            this.txtConstitution.Location = new System.Drawing.Point(73, 55);
            this.txtConstitution.Name = "txtConstitution";
            this.txtConstitution.Size = new System.Drawing.Size(48, 20);
            this.txtConstitution.TabIndex = 2;
            this.txtConstitution.TextChanged += new System.EventHandler(this.txtConstitution_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dexterity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Constitution:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Charisma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Wisdom:";
            // 
            // txtCharisma
            // 
            this.txtCharisma.Location = new System.Drawing.Point(73, 133);
            this.txtCharisma.Name = "txtCharisma";
            this.txtCharisma.Size = new System.Drawing.Size(48, 20);
            this.txtCharisma.TabIndex = 5;
            this.txtCharisma.TextChanged += new System.EventHandler(this.txtCharisma_TextChanged);
            // 
            // txtWisdom
            // 
            this.txtWisdom.Location = new System.Drawing.Point(73, 107);
            this.txtWisdom.Name = "txtWisdom";
            this.txtWisdom.Size = new System.Drawing.Size(48, 20);
            this.txtWisdom.TabIndex = 4;
            this.txtWisdom.TextChanged += new System.EventHandler(this.txtWisdom_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Intelligence:";
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.Location = new System.Drawing.Point(73, 81);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.Size = new System.Drawing.Size(48, 20);
            this.txtIntelligence.TabIndex = 3;
            this.txtIntelligence.TextChanged += new System.EventHandler(this.txtIntelligence_TextChanged);
            // 
            // UnitControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCharisma);
            this.Controls.Add(this.txtWisdom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIntelligence);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConstitution);
            this.Controls.Add(this.txtDexterity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStrength);
            this.Name = "UnitControl";
            this.Size = new System.Drawing.Size(563, 354);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDexterity;
        private System.Windows.Forms.TextBox txtConstitution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCharisma;
        private System.Windows.Forms.TextBox txtWisdom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIntelligence;
    }
}
