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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAcceptBet = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxBetAmount = new System.Windows.Forms.TextBox();
            this.listBoxBets = new System.Windows.Forms.ListBox();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.numericUpDownGreyhoundForBet = new System.Windows.Forms.NumericUpDown();
            this.labelGreyoundBet = new System.Windows.Forms.Label();
            this.labelBets = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownNumberOfGreyhounds = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfGreyhounds = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreyhoundForBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGreyhounds)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAcceptBet);
            this.groupBox1.Controls.Add(this.labelAmount);
            this.groupBox1.Controls.Add(this.textBoxBetAmount);
            this.groupBox1.Controls.Add(this.listBoxBets);
            this.groupBox1.Controls.Add(this.listBoxPlayers);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.numericUpDownGreyhoundForBet);
            this.groupBox1.Controls.Add(this.labelGreyoundBet);
            this.groupBox1.Controls.Add(this.labelBets);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 116);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dom bukmacherski";
            // 
            // buttonAcceptBet
            // 
            this.buttonAcceptBet.Location = new System.Drawing.Point(133, 82);
            this.buttonAcceptBet.Name = "buttonAcceptBet";
            this.buttonAcceptBet.Size = new System.Drawing.Size(204, 23);
            this.buttonAcceptBet.TabIndex = 18;
            this.buttonAcceptBet.Text = "Zatwierdź zakład";
            this.buttonAcceptBet.UseVisualStyleBackColor = true;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(130, 39);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(37, 13);
            this.labelAmount.TabIndex = 17;
            this.labelAmount.Text = "Kwota";
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
            this.listBoxBets.Location = new System.Drawing.Point(345, 39);
            this.listBoxBets.Name = "listBoxBets";
            this.listBoxBets.Size = new System.Drawing.Size(139, 69);
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
            // numericUpDownGreyhoundForBet
            // 
            this.numericUpDownGreyhoundForBet.Location = new System.Drawing.Point(295, 56);
            this.numericUpDownGreyhoundForBet.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownGreyhoundForBet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGreyhoundForBet.Name = "numericUpDownGreyhoundForBet";
            this.numericUpDownGreyhoundForBet.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownGreyhoundForBet.TabIndex = 12;
            this.numericUpDownGreyhoundForBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelGreyoundBet
            // 
            this.labelGreyoundBet.AutoSize = true;
            this.labelGreyoundBet.Location = new System.Drawing.Point(193, 58);
            this.labelGreyoundBet.Name = "labelGreyoundBet";
            this.labelGreyoundBet.Size = new System.Drawing.Size(96, 13);
            this.labelGreyoundBet.TabIndex = 11;
            this.labelGreyoundBet.Text = "zł na charta numer";
            // 
            // labelBets
            // 
            this.labelBets.AutoSize = true;
            this.labelBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBets.Location = new System.Drawing.Point(377, 16);
            this.labelBets.Name = "labelBets";
            this.labelBets.Size = new System.Drawing.Size(54, 13);
            this.labelBets.TabIndex = 4;
            this.labelBets.Text = "Zakłady";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 60);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDownNumberOfGreyhounds
            // 
            this.numericUpDownNumberOfGreyhounds.Location = new System.Drawing.Point(11, 370);
            this.numericUpDownNumberOfGreyhounds.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownNumberOfGreyhounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfGreyhounds.Name = "numericUpDownNumberOfGreyhounds";
            this.numericUpDownNumberOfGreyhounds.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownNumberOfGreyhounds.TabIndex = 13;
            this.numericUpDownNumberOfGreyhounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfGreyhounds.ValueChanged += new System.EventHandler(this.numericUpDownNumberOfGreyhounds_ValueChanged);
            // 
            // labelNumberOfGreyhounds
            // 
            this.labelNumberOfGreyhounds.AutoSize = true;
            this.labelNumberOfGreyhounds.Location = new System.Drawing.Point(8, 354);
            this.labelNumberOfGreyhounds.Name = "labelNumberOfGreyhounds";
            this.labelNumberOfGreyhounds.Size = new System.Drawing.Size(70, 13);
            this.labelNumberOfGreyhounds.TabIndex = 14;
            this.labelNumberOfGreyhounds.Text = "Ilość chartów";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(613, 430);
            this.Controls.Add(this.labelNumberOfGreyhounds);
            this.Controls.Add(this.numericUpDownNumberOfGreyhounds);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreyhoundForBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGreyhounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown numericUpDownGreyhoundForBet;
        private System.Windows.Forms.Label labelGreyoundBet;
        private System.Windows.Forms.Label labelBets;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.ListBox listBoxBets;
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAcceptBet;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxBetAmount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfGreyhounds;
        private System.Windows.Forms.Label labelNumberOfGreyhounds;
    }
}