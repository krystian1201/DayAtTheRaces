namespace Dzień_na_wyścigach
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBoxGreyhound = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAcceptBet = new System.Windows.Forms.Button();
            this.Kwota = new System.Windows.Forms.Label();
            this.textBoxBetAmount = new System.Windows.Forms.TextBox();
            this.listBoxBets = new System.Windows.Forms.ListBox();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.pictureBoxRaceTrackLane = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreyhound)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaceTrackLane)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGreyhound
            // 
            this.pictureBoxGreyhound.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGreyhound.Image")));
            this.pictureBoxGreyhound.Location = new System.Drawing.Point(6, 100);
            this.pictureBoxGreyhound.Name = "pictureBoxGreyhound";
            this.pictureBoxGreyhound.Size = new System.Drawing.Size(74, 21);
            this.pictureBoxGreyhound.TabIndex = 8;
            this.pictureBoxGreyhound.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAcceptBet);
            this.groupBox1.Controls.Add(this.Kwota);
            this.groupBox1.Controls.Add(this.textBoxBetAmount);
            this.groupBox1.Controls.Add(this.listBoxBets);
            this.groupBox1.Controls.Add(this.listBoxPlayers);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dom bukmacherski";
            // 
            // buttonAcceptBet
            // 
            this.buttonAcceptBet.Location = new System.Drawing.Point(133, 82);
            this.buttonAcceptBet.Name = "buttonAcceptBet";
            this.buttonAcceptBet.Size = new System.Drawing.Size(215, 23);
            this.buttonAcceptBet.TabIndex = 18;
            this.buttonAcceptBet.Text = "Zatwierdź zakład";
            this.buttonAcceptBet.UseVisualStyleBackColor = true;
            // 
            // Kwota
            // 
            this.Kwota.AutoSize = true;
            this.Kwota.Location = new System.Drawing.Point(141, 39);
            this.Kwota.Name = "Kwota";
            this.Kwota.Size = new System.Drawing.Size(37, 13);
            this.Kwota.TabIndex = 17;
            this.Kwota.Text = "Kwota";
            // 
            // textBoxBetAmount
            // 
            this.textBoxBetAmount.Location = new System.Drawing.Point(133, 55);
            this.textBoxBetAmount.Name = "textBoxBetAmount";
            this.textBoxBetAmount.Size = new System.Drawing.Size(54, 20);
            this.textBoxBetAmount.TabIndex = 16;
            // 
            // listBoxBets
            // 
            this.listBoxBets.FormattingEnabled = true;
            this.listBoxBets.Location = new System.Drawing.Point(378, 37);
            this.listBoxBets.Name = "listBoxBets";
            this.listBoxBets.Size = new System.Drawing.Size(106, 69);
            this.listBoxBets.TabIndex = 15;
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.Location = new System.Drawing.Point(12, 37);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(106, 69);
            this.listBoxPlayers.TabIndex = 14;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(490, 37);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(104, 69);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(306, 56);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "zł na charta numer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(397, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zakłady";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimumBetLabel.Location = new System.Drawing.Point(9, 20);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(135, 13);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimalny zakład: 5 zł";
            // 
            // pictureBoxRaceTrackLane
            // 
            this.pictureBoxRaceTrackLane.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRaceTrackLane.Image")));
            this.pictureBoxRaceTrackLane.Location = new System.Drawing.Point(7, 79);
            this.pictureBoxRaceTrackLane.Name = "pictureBoxRaceTrackLane";
            this.pictureBoxRaceTrackLane.Size = new System.Drawing.Size(594, 55);
            this.pictureBoxRaceTrackLane.TabIndex = 9;
            this.pictureBoxRaceTrackLane.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 61);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 373);
            this.Controls.Add(this.pictureBoxGreyhound);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBoxRaceTrackLane);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreyhound)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaceTrackLane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox pictureBoxGreyhound;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.PictureBox pictureBoxRaceTrackLane;
        private System.Windows.Forms.ListBox listBoxBets;
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAcceptBet;
        private System.Windows.Forms.Label Kwota;
        private System.Windows.Forms.TextBox textBoxBetAmount;
        private System.Windows.Forms.Timer timer1;
    }
}