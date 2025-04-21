namespace PokemonGuesser
{
    partial class frmGuess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuess));
            this.rtxtInfo = new System.Windows.Forms.RichTextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblEvoSet = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picBoxPokemon = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSpDefense = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSpAttack = new System.Windows.Forms.Label();
            this.lblDefense = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTyping = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.cmbPokemon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtInfo
            // 
            this.rtxtInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtxtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtInfo.Location = new System.Drawing.Point(406, 365);
            this.rtxtInfo.Name = "rtxtInfo";
            this.rtxtInfo.ReadOnly = true;
            this.rtxtInfo.Size = new System.Drawing.Size(358, 266);
            this.rtxtInfo.TabIndex = 52;
            this.rtxtInfo.Tag = "400|Info";
            this.rtxtInfo.Text = "400p";
            this.rtxtInfo.DoubleClick += new System.EventHandler(this.hintClicked);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(402, 342);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(94, 20);
            this.lblInfo.TabIndex = 51;
            this.lblInfo.Text = "Information:";
            // 
            // lblEvoSet
            // 
            this.lblEvoSet.AutoSize = true;
            this.lblEvoSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEvoSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvoSet.Location = new System.Drawing.Point(73, 222);
            this.lblEvoSet.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblEvoSet.Name = "lblEvoSet";
            this.lblEvoSet.Size = new System.Drawing.Size(45, 20);
            this.lblEvoSet.TabIndex = 50;
            this.lblEvoSet.Tag = "200|EvoSet";
            this.lblEvoSet.Text = "200p";
            this.lblEvoSet.DoubleClick += new System.EventHandler(this.hintClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Evo Set:";
            // 
            // picBoxPokemon
            // 
            this.picBoxPokemon.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxPokemon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxPokemon.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPokemon.Image")));
            this.picBoxPokemon.Location = new System.Drawing.Point(11, 298);
            this.picBoxPokemon.Name = "picBoxPokemon";
            this.picBoxPokemon.Size = new System.Drawing.Size(385, 333);
            this.picBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPokemon.TabIndex = 48;
            this.picBoxPokemon.TabStop = false;
            this.picBoxPokemon.Tag = "950|ImageURL";
            this.picBoxPokemon.DoubleClick += new System.EventHandler(this.hintClicked);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(201, 132);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 20);
            this.label20.TabIndex = 47;
            this.label20.Text = "Typing:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(515, 312);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSpeed.Size = new System.Drawing.Size(161, 20);
            this.lblSpeed.TabIndex = 46;
            this.lblSpeed.Tag = "50|Speed";
            this.lblSpeed.Text = "50p";
            this.lblSpeed.DoubleClick += new System.EventHandler(this.hintClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 312);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Speed:";
            // 
            // lblSpDefense
            // 
            this.lblSpDefense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSpDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpDefense.Location = new System.Drawing.Point(515, 282);
            this.lblSpDefense.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSpDefense.Name = "lblSpDefense";
            this.lblSpDefense.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSpDefense.Size = new System.Drawing.Size(161, 20);
            this.lblSpDefense.TabIndex = 44;
            this.lblSpDefense.Tag = "50|SpecialDefense";
            this.lblSpDefense.Text = "50p";
            this.lblSpDefense.DoubleClick += new System.EventHandler(this.hintClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(402, 282);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 43;
            this.label13.Text = "Sp. Defense:";
            // 
            // lblSpAttack
            // 
            this.lblSpAttack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSpAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpAttack.Location = new System.Drawing.Point(515, 252);
            this.lblSpAttack.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSpAttack.Name = "lblSpAttack";
            this.lblSpAttack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSpAttack.Size = new System.Drawing.Size(161, 20);
            this.lblSpAttack.TabIndex = 42;
            this.lblSpAttack.Tag = "50|SpecialAttack";
            this.lblSpAttack.Text = "50p";
            this.lblSpAttack.DoubleClick += new System.EventHandler(this.hintClicked);
            // 
            // lblDefense
            // 
            this.lblDefense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefense.Location = new System.Drawing.Point(515, 222);
            this.lblDefense.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDefense.Size = new System.Drawing.Size(161, 20);
            this.lblDefense.TabIndex = 41;
            this.lblDefense.Tag = "50|Defense";
            this.lblDefense.Text = "50p";
            this.lblDefense.DoubleClick += new System.EventHandler(this.hintClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(402, 252);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Sp. Attack:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(402, 222);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Defense:";
            // 
            // lblAttack
            // 
            this.lblAttack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack.Location = new System.Drawing.Point(515, 192);
            this.lblAttack.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAttack.Size = new System.Drawing.Size(161, 20);
            this.lblAttack.TabIndex = 38;
            this.lblAttack.Tag = "50|Attack";
            this.lblAttack.Text = "50p";
            this.lblAttack.DoubleClick += new System.EventHandler(this.hintClicked);
            // 
            // lblHP
            // 
            this.lblHP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(515, 162);
            this.lblHP.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHP.Name = "lblHP";
            this.lblHP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHP.Size = new System.Drawing.Size(161, 20);
            this.lblHP.TabIndex = 37;
            this.lblHP.Tag = "50|HP";
            this.lblHP.Text = "50p";
            this.lblHP.DoubleClick += new System.EventHandler(this.hintClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Attack:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(402, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "HP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Combat Stats";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(73, 192);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(36, 20);
            this.lblWeight.TabIndex = 33;
            this.lblWeight.Tag = "50|Weight";
            this.lblWeight.Text = "50p";
            this.lblWeight.DoubleClick += new System.EventHandler(this.hintClicked);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(73, 162);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(36, 20);
            this.lblHeight.TabIndex = 32;
            this.lblHeight.Tag = "50|Height";
            this.lblHeight.Text = "50p";
            this.lblHeight.DoubleClick += new System.EventHandler(this.hintClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Weight:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Height:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(7, 132);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 20);
            this.label.TabIndex = 29;
            this.label.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(73, 132);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(122, 20);
            this.lblName.TabIndex = 53;
            this.lblName.Tag = "1000|Name";
            this.lblName.Text = "1000p (Give up)";
            this.lblName.DoubleClick += new System.EventHandler(this.hintClicked);
            // 
            // lblTyping
            // 
            this.lblTyping.AutoSize = true;
            this.lblTyping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTyping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTyping.Location = new System.Drawing.Point(266, 132);
            this.lblTyping.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTyping.Name = "lblTyping";
            this.lblTyping.Size = new System.Drawing.Size(45, 20);
            this.lblTyping.TabIndex = 54;
            this.lblTyping.Tag = "200|Type";
            this.lblTyping.Text = "200p";
            this.lblTyping.DoubleClick += new System.EventHandler(this.hintClicked);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(678, 13);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(74, 31);
            this.lblPoints.TabIndex = 55;
            this.lblPoints.Text = "1000";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(574, 13);
            this.label21.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 31);
            this.label21.TabIndex = 56;
            this.label21.Text = "Points:";
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(455, 16);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(103, 31);
            this.btnGuess.TabIndex = 58;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(11, 14);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(56, 31);
            this.btnHelp.TabIndex = 59;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // cmbPokemon
            // 
            this.cmbPokemon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPokemon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPokemon.FormattingEnabled = true;
            this.cmbPokemon.Location = new System.Drawing.Point(93, 16);
            this.cmbPokemon.Name = "cmbPokemon";
            this.cmbPokemon.Size = new System.Drawing.Size(356, 28);
            this.cmbPokemon.TabIndex = 60;
            // 
            // frmGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 642);
            this.Controls.Add(this.cmbPokemon);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblTyping);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.rtxtInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblEvoSet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picBoxPokemon);
            this.Controls.Add(this.label20);
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
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGuess";
            this.Text = "Pokemon Guesser";
            this.Load += new System.EventHandler(this.frmAnalytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblEvoSet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picBoxPokemon;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSpDefense;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSpAttack;
        private System.Windows.Forms.Label lblDefense;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTyping;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ComboBox cmbPokemon;
    }
}