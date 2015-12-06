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
            this.groupBoxBettingParlor = new System.Windows.Forms.GroupBox();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.dataGridViewBets = new System.Windows.Forms.DataGridView();
            this.BetPlayerColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BetGreyhoundColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BetAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.PlayerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerMoneyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAcceptBet = new System.Windows.Forms.Button();
            this.labelBets = new System.Windows.Forms.Label();
            this.labelNumberOfGreyhounds = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfGreyhounds = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.ResultsPositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultsGreyhoundColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultsTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxBettingParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGreyhounds)).BeginInit();
            this.groupBoxResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBettingParlor
            // 
            this.groupBoxBettingParlor.Controls.Add(this.buttonAddPlayer);
            this.groupBoxBettingParlor.Controls.Add(this.dataGridViewBets);
            this.groupBoxBettingParlor.Controls.Add(this.labelPlayers);
            this.groupBoxBettingParlor.Controls.Add(this.dataGridViewPlayers);
            this.groupBoxBettingParlor.Controls.Add(this.buttonAcceptBet);
            this.groupBoxBettingParlor.Controls.Add(this.labelBets);
            this.groupBoxBettingParlor.Location = new System.Drawing.Point(6, 325);
            this.groupBoxBettingParlor.Name = "groupBoxBettingParlor";
            this.groupBoxBettingParlor.Size = new System.Drawing.Size(736, 155);
            this.groupBoxBettingParlor.TabIndex = 6;
            this.groupBoxBettingParlor.TabStop = false;
            this.groupBoxBettingParlor.Text = "Dom bukmacherski";
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Enabled = false;
            this.buttonAddPlayer.Location = new System.Drawing.Point(264, 38);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(75, 105);
            this.buttonAddPlayer.TabIndex = 22;
            this.buttonAddPlayer.Text = "Dodaj gracza/y";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // dataGridViewBets
            // 
            this.dataGridViewBets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BetPlayerColumn,
            this.BetGreyhoundColumn,
            this.BetAmountColumn});
            this.dataGridViewBets.Location = new System.Drawing.Point(359, 38);
            this.dataGridViewBets.Name = "dataGridViewBets";
            this.dataGridViewBets.Size = new System.Drawing.Size(272, 107);
            this.dataGridViewBets.TabIndex = 21;
            // 
            // BetPlayerColumn
            // 
            this.BetPlayerColumn.HeaderText = "Gracz";
            this.BetPlayerColumn.Name = "BetPlayerColumn";
            this.BetPlayerColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BetPlayerColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BetGreyhoundColumn
            // 
            this.BetGreyhoundColumn.HeaderText = "Chart";
            this.BetGreyhoundColumn.Name = "BetGreyhoundColumn";
            this.BetGreyhoundColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BetGreyhoundColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BetGreyhoundColumn.Width = 50;
            // 
            // BetAmountColumn
            // 
            this.BetAmountColumn.HeaderText = "Kasa";
            this.BetAmountColumn.Name = "BetAmountColumn";
            this.BetAmountColumn.Width = 60;
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Location = new System.Drawing.Point(23, 20);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(41, 13);
            this.labelPlayers.TabIndex = 20;
            this.labelPlayers.Text = "Gracze";
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerNameColumn,
            this.PlayerMoneyColumn});
            this.dataGridViewPlayers.Location = new System.Drawing.Point(26, 36);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.Size = new System.Drawing.Size(232, 107);
            this.dataGridViewPlayers.TabIndex = 19;
            this.dataGridViewPlayers.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlayers_RowLeave);
            // 
            // PlayerNameColumn
            // 
            this.PlayerNameColumn.HeaderText = "Imię";
            this.PlayerNameColumn.Name = "PlayerNameColumn";
            // 
            // PlayerMoneyColumn
            // 
            this.PlayerMoneyColumn.HeaderText = "Kasa";
            this.PlayerMoneyColumn.Name = "PlayerMoneyColumn";
            this.PlayerMoneyColumn.Width = 60;
            // 
            // buttonAcceptBet
            // 
            this.buttonAcceptBet.Enabled = false;
            this.buttonAcceptBet.Location = new System.Drawing.Point(637, 38);
            this.buttonAcceptBet.Name = "buttonAcceptBet";
            this.buttonAcceptBet.Size = new System.Drawing.Size(83, 107);
            this.buttonAcceptBet.TabIndex = 18;
            this.buttonAcceptBet.Text = "Zatwierdź zakład";
            this.buttonAcceptBet.UseVisualStyleBackColor = true;
            // 
            // labelBets
            // 
            this.labelBets.AutoSize = true;
            this.labelBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBets.Location = new System.Drawing.Point(356, 16);
            this.labelBets.Name = "labelBets";
            this.labelBets.Size = new System.Drawing.Size(54, 13);
            this.labelBets.TabIndex = 4;
            this.labelBets.Text = "Zakłady";
            // 
            // labelNumberOfGreyhounds
            // 
            this.labelNumberOfGreyhounds.AutoSize = true;
            this.labelNumberOfGreyhounds.Location = new System.Drawing.Point(502, 557);
            this.labelNumberOfGreyhounds.Name = "labelNumberOfGreyhounds";
            this.labelNumberOfGreyhounds.Size = new System.Drawing.Size(70, 13);
            this.labelNumberOfGreyhounds.TabIndex = 14;
            this.labelNumberOfGreyhounds.Text = "Ilość chartów";
            // 
            // numericUpDownNumberOfGreyhounds
            // 
            this.numericUpDownNumberOfGreyhounds.Location = new System.Drawing.Point(515, 573);
            this.numericUpDownNumberOfGreyhounds.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNumberOfGreyhounds.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNumberOfGreyhounds.Name = "numericUpDownNumberOfGreyhounds";
            this.numericUpDownNumberOfGreyhounds.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownNumberOfGreyhounds.TabIndex = 13;
            this.numericUpDownNumberOfGreyhounds.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNumberOfGreyhounds.ValueChanged += new System.EventHandler(this.numericUpDownNumberOfGreyhounds_ValueChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(622, 546);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(104, 69);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.startButton_Click);
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
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.dataGridViewResults);
            this.groupBoxResults.Location = new System.Drawing.Point(6, 486);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(480, 177);
            this.groupBoxResults.TabIndex = 16;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Wyniki";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.AllowUserToOrderColumns = true;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResultsPositionColumn,
            this.ResultsGreyhoundColumn,
            this.ResultsTime});
            this.dataGridViewResults.Location = new System.Drawing.Point(26, 20);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            this.dataGridViewResults.Size = new System.Drawing.Size(355, 138);
            this.dataGridViewResults.TabIndex = 17;
            // 
            // ResultsPositionColumn
            // 
            this.ResultsPositionColumn.HeaderText = "Miejsce";
            this.ResultsPositionColumn.Name = "ResultsPositionColumn";
            this.ResultsPositionColumn.ReadOnly = true;
            // 
            // ResultsGreyhoundColumn
            // 
            this.ResultsGreyhoundColumn.HeaderText = "Chart";
            this.ResultsGreyhoundColumn.Name = "ResultsGreyhoundColumn";
            this.ResultsGreyhoundColumn.ReadOnly = true;
            // 
            // ResultsTime
            // 
            this.ResultsTime.HeaderText = "Czas";
            this.ResultsTime.Name = "ResultsTime";
            this.ResultsTime.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(760, 675);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.groupBoxBettingParlor);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.numericUpDownNumberOfGreyhounds);
            this.Controls.Add(this.labelNumberOfGreyhounds);
            this.Name = "Form2";
            this.Text = "Symulator Wyścigów";
            this.groupBoxBettingParlor.ResumeLayout(false);
            this.groupBoxBettingParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfGreyhounds)).EndInit();
            this.groupBoxResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxBettingParlor;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelBets;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAcceptBet;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfGreyhounds;
        private System.Windows.Forms.Label labelNumberOfGreyhounds;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsPositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsGreyhoundColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsTime;
        private System.Windows.Forms.Label labelPlayers;
        public System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.DataGridView dataGridViewBets;
        public System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.DataGridViewComboBoxColumn BetPlayerColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn BetGreyhoundColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BetAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerMoneyColumn;
    }
}