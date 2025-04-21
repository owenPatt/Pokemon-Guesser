namespace PokemonGuesser
{
    partial class frmPractice
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.cmbPokemon = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSpAttack = new System.Windows.Forms.Label();
            this.lblDefense = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSpDefense = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblTyping = new System.Windows.Forms.Label();
            this.picBoxPokemon = new System.Windows.Forms.PictureBox();
            this.lblEvoSet = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.rtxtInfo = new System.Windows.Forms.RichTextBox();
            this.btnViewReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(407, 517);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(358, 47);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Get Random Pokemon";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // cmbPokemon
            // 
            this.cmbPokemon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPokemon.FormattingEnabled = true;
            this.cmbPokemon.Location = new System.Drawing.Point(12, 12);
            this.cmbPokemon.Name = "cmbPokemon";
            this.cmbPokemon.Size = new System.Drawing.Size(356, 28);
            this.cmbPokemon.TabIndex = 2;
            this.cmbPokemon.SelectedIndexChanged += new System.EventHandler(this.cmbPokemon_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(8, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weight:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(74, 95);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(18, 20);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "0";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(74, 125);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(18, 20);
            this.lblWeight.TabIndex = 7;
            this.lblWeight.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Combat Stats";
            // 
            // lblAttack
            // 
            this.lblAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack.Location = new System.Drawing.Point(516, 125);
            this.lblAttack.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAttack.Size = new System.Drawing.Size(161, 20);
            this.lblAttack.TabIndex = 12;
            this.lblAttack.Text = "0";
            // 
            // lblHP
            // 
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(516, 95);
            this.lblHP.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHP.Name = "lblHP";
            this.lblHP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHP.Size = new System.Drawing.Size(161, 20);
            this.lblHP.TabIndex = 11;
            this.lblHP.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(403, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Attack:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "HP:";
            // 
            // lblSpAttack
            // 
            this.lblSpAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpAttack.Location = new System.Drawing.Point(516, 185);
            this.lblSpAttack.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSpAttack.Name = "lblSpAttack";
            this.lblSpAttack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSpAttack.Size = new System.Drawing.Size(161, 20);
            this.lblSpAttack.TabIndex = 16;
            this.lblSpAttack.Text = "0";
            // 
            // lblDefense
            // 
            this.lblDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefense.Location = new System.Drawing.Point(516, 155);
            this.lblDefense.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDefense.Size = new System.Drawing.Size(161, 20);
            this.lblDefense.TabIndex = 15;
            this.lblDefense.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(403, 185);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Sp. Attack:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(403, 155);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Defense:";
            // 
            // lblSpDefense
            // 
            this.lblSpDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpDefense.Location = new System.Drawing.Point(516, 215);
            this.lblSpDefense.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSpDefense.Name = "lblSpDefense";
            this.lblSpDefense.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSpDefense.Size = new System.Drawing.Size(161, 20);
            this.lblSpDefense.TabIndex = 18;
            this.lblSpDefense.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(403, 215);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Sp. Defense:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Speed:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(516, 245);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSpeed.Size = new System.Drawing.Size(161, 20);
            this.lblSpeed.TabIndex = 20;
            this.lblSpeed.Text = "0";
            // 
            // lblTyping
            // 
            this.lblTyping.AutoSize = true;
            this.lblTyping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTyping.Location = new System.Drawing.Point(166, 65);
            this.lblTyping.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTyping.Name = "lblTyping";
            this.lblTyping.Size = new System.Drawing.Size(55, 20);
            this.lblTyping.TabIndex = 21;
            this.lblTyping.Text = "Typing";
            // 
            // picBoxPokemon
            // 
            this.picBoxPokemon.Location = new System.Drawing.Point(12, 178);
            this.picBoxPokemon.Name = "picBoxPokemon";
            this.picBoxPokemon.Size = new System.Drawing.Size(385, 333);
            this.picBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPokemon.TabIndex = 22;
            this.picBoxPokemon.TabStop = false;
            // 
            // lblEvoSet
            // 
            this.lblEvoSet.AutoSize = true;
            this.lblEvoSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvoSet.Location = new System.Drawing.Point(74, 155);
            this.lblEvoSet.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblEvoSet.Name = "lblEvoSet";
            this.lblEvoSet.Size = new System.Drawing.Size(18, 20);
            this.lblEvoSet.TabIndex = 24;
            this.lblEvoSet.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Evo Set:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(403, 275);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(94, 20);
            this.lblInfo.TabIndex = 25;
            this.lblInfo.Text = "Information:";
            // 
            // rtxtInfo
            // 
            this.rtxtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtInfo.Location = new System.Drawing.Point(407, 298);
            this.rtxtInfo.Name = "rtxtInfo";
            this.rtxtInfo.ReadOnly = true;
            this.rtxtInfo.Size = new System.Drawing.Size(358, 213);
            this.rtxtInfo.TabIndex = 26;
            this.rtxtInfo.Text = "";
            // 
            // btnViewReport
            // 
            this.btnViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(12, 517);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(358, 47);
            this.btnViewReport.TabIndex = 27;
            this.btnViewReport.Text = "View Pokemon Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // frmPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 576);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.rtxtInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblEvoSet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picBoxPokemon);
            this.Controls.Add(this.lblTyping);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSpDefense);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblSpAttack);
            this.Controls.Add(this.lblDefense);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbPokemon);
            this.Controls.Add(this.btnRandom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPractice";
            this.Text = "Practice Tool";
            this.Load += new System.EventHandler(this.frmPractice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ComboBox cmbPokemon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSpAttack;
        private System.Windows.Forms.Label lblDefense;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSpDefense;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblTyping;
        private System.Windows.Forms.PictureBox picBoxPokemon;
        private System.Windows.Forms.Label lblEvoSet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RichTextBox rtxtInfo;
        private System.Windows.Forms.Button btnViewReport;
    }
}