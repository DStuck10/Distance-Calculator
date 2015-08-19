namespace Distance_Calculator
{
    partial class DistanceCalclator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DistanceCalclator));
            this.instructions = new System.Windows.Forms.Label();
            this.milesTB = new System.Windows.Forms.TextBox();
            this.gasMileageInstruct = new System.Windows.Forms.Label();
            this.AverageMpgTB = new System.Windows.Forms.TextBox();
            this.gasPriceInstruct = new System.Windows.Forms.Label();
            this.ppgTB = new System.Windows.Forms.TextBox();
            this.gasTankInstruct = new System.Windows.Forms.Label();
            this.gallonsTB = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.lblTotalGas = new System.Windows.Forms.Label();
            this.lblGasStops = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.errorMiles = new System.Windows.Forms.Label();
            this.errorMPG = new System.Windows.Forms.Label();
            this.errorPPG = new System.Windows.Forms.Label();
            this.errorGallons = new System.Windows.Forms.Label();
            this.txtBreaks = new System.Windows.Forms.TextBox();
            this.lblBreaks = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBreaksError = new System.Windows.Forms.Label();
            this.lblAverageSpeed = new System.Windows.Forms.Label();
            this.txtAverageSpeed = new System.Windows.Forms.TextBox();
            this.lblSpeedError = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.Location = new System.Drawing.Point(13, 13);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(213, 13);
            this.instructions.TabIndex = 0;
            this.instructions.Text = "Type the distance you are traveling in miles.";
            // 
            // milesTB
            // 
            this.milesTB.Location = new System.Drawing.Point(17, 30);
            this.milesTB.Name = "milesTB";
            this.milesTB.Size = new System.Drawing.Size(50, 20);
            this.milesTB.TabIndex = 1;
            this.milesTB.Text = "0";
            // 
            // gasMileageInstruct
            // 
            this.gasMileageInstruct.AutoSize = true;
            this.gasMileageInstruct.Location = new System.Drawing.Point(13, 57);
            this.gasMileageInstruct.Name = "gasMileageInstruct";
            this.gasMileageInstruct.Size = new System.Drawing.Size(179, 13);
            this.gasMileageInstruct.TabIndex = 0;
            this.gasMileageInstruct.Text = "What is your vehicles average mpg?";
            // 
            // AverageMpgTB
            // 
            this.AverageMpgTB.Location = new System.Drawing.Point(17, 74);
            this.AverageMpgTB.Name = "AverageMpgTB";
            this.AverageMpgTB.Size = new System.Drawing.Size(50, 20);
            this.AverageMpgTB.TabIndex = 2;
            this.AverageMpgTB.Text = "0";
            // 
            // gasPriceInstruct
            // 
            this.gasPriceInstruct.AutoSize = true;
            this.gasPriceInstruct.Location = new System.Drawing.Point(13, 101);
            this.gasPriceInstruct.Name = "gasPriceInstruct";
            this.gasPriceInstruct.Size = new System.Drawing.Size(189, 13);
            this.gasPriceInstruct.TabIndex = 0;
            this.gasPriceInstruct.Text = "What is the price per gas in your area?";
            // 
            // ppgTB
            // 
            this.ppgTB.Location = new System.Drawing.Point(17, 118);
            this.ppgTB.Name = "ppgTB";
            this.ppgTB.Size = new System.Drawing.Size(50, 20);
            this.ppgTB.TabIndex = 3;
            this.ppgTB.Text = "0";
            // 
            // gasTankInstruct
            // 
            this.gasTankInstruct.AutoSize = true;
            this.gasTankInstruct.Location = new System.Drawing.Point(13, 145);
            this.gasTankInstruct.Name = "gasTankInstruct";
            this.gasTankInstruct.Size = new System.Drawing.Size(215, 13);
            this.gasTankInstruct.TabIndex = 0;
            this.gasTankInstruct.Text = "How many gallons does your gas tank hold?";
            // 
            // gallonsTB
            // 
            this.gallonsTB.Location = new System.Drawing.Point(16, 162);
            this.gallonsTB.Name = "gallonsTB";
            this.gallonsTB.Size = new System.Drawing.Size(50, 20);
            this.gallonsTB.TabIndex = 4;
            this.gallonsTB.Text = "0";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.Location = new System.Drawing.Point(336, 327);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "&Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateBtn.Location = new System.Drawing.Point(255, 327);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 7;
            this.calculateBtn.Text = "&Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // lblTotalGas
            // 
            this.lblTotalGas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalGas.AutoSize = true;
            this.lblTotalGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGas.Location = new System.Drawing.Point(249, 13);
            this.lblTotalGas.Name = "lblTotalGas";
            this.lblTotalGas.Size = new System.Drawing.Size(81, 13);
            this.lblTotalGas.TabIndex = 0;
            this.lblTotalGas.Text = "Total Gas Used";
            // 
            // lblGasStops
            // 
            this.lblGasStops.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGasStops.AutoSize = true;
            this.lblGasStops.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasStops.Location = new System.Drawing.Point(249, 43);
            this.lblGasStops.Name = "lblGasStops";
            this.lblGasStops.Size = new System.Drawing.Size(196, 13);
            this.lblGasStops.TabIndex = 0;
            this.lblGasStops.Text = "Times your going to have to stop for gas";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(249, 73);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(104, 13);
            this.lblTotalCost.TabIndex = 0;
            this.lblTotalCost.Text = "Total cost for the trip";
            // 
            // errorMiles
            // 
            this.errorMiles.AutoSize = true;
            this.errorMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMiles.ForeColor = System.Drawing.Color.Red;
            this.errorMiles.Location = new System.Drawing.Point(75, 36);
            this.errorMiles.Name = "errorMiles";
            this.errorMiles.Size = new System.Drawing.Size(75, 13);
            this.errorMiles.TabIndex = 0;
            this.errorMiles.Text = "Error Message";
            // 
            // errorMPG
            // 
            this.errorMPG.AutoSize = true;
            this.errorMPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMPG.ForeColor = System.Drawing.Color.Red;
            this.errorMPG.Location = new System.Drawing.Point(75, 81);
            this.errorMPG.Name = "errorMPG";
            this.errorMPG.Size = new System.Drawing.Size(75, 13);
            this.errorMPG.TabIndex = 0;
            this.errorMPG.Text = "Error Message";
            // 
            // errorPPG
            // 
            this.errorPPG.AutoSize = true;
            this.errorPPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorPPG.ForeColor = System.Drawing.Color.Red;
            this.errorPPG.Location = new System.Drawing.Point(75, 125);
            this.errorPPG.Name = "errorPPG";
            this.errorPPG.Size = new System.Drawing.Size(75, 13);
            this.errorPPG.TabIndex = 0;
            this.errorPPG.Text = "Error Message";
            // 
            // errorGallons
            // 
            this.errorGallons.AutoSize = true;
            this.errorGallons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorGallons.ForeColor = System.Drawing.Color.Red;
            this.errorGallons.Location = new System.Drawing.Point(75, 169);
            this.errorGallons.Name = "errorGallons";
            this.errorGallons.Size = new System.Drawing.Size(75, 13);
            this.errorGallons.TabIndex = 0;
            this.errorGallons.Text = "Error Message";
            // 
            // txtBreaks
            // 
            this.txtBreaks.Location = new System.Drawing.Point(17, 204);
            this.txtBreaks.Name = "txtBreaks";
            this.txtBreaks.Size = new System.Drawing.Size(50, 20);
            this.txtBreaks.TabIndex = 5;
            this.txtBreaks.Text = "0";
            // 
            // lblBreaks
            // 
            this.lblBreaks.AutoSize = true;
            this.lblBreaks.Location = new System.Drawing.Point(14, 187);
            this.lblBreaks.Name = "lblBreaks";
            this.lblBreaks.Size = new System.Drawing.Size(243, 13);
            this.lblBreaks.TabIndex = 0;
            this.lblBreaks.Text = "How many times will you stop, excluding gas stops";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(249, 98);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(94, 13);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time For Your Trip";
            // 
            // lblBreaksError
            // 
            this.lblBreaksError.AutoSize = true;
            this.lblBreaksError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreaksError.ForeColor = System.Drawing.Color.Red;
            this.lblBreaksError.Location = new System.Drawing.Point(75, 211);
            this.lblBreaksError.Name = "lblBreaksError";
            this.lblBreaksError.Size = new System.Drawing.Size(75, 13);
            this.lblBreaksError.TabIndex = 0;
            this.lblBreaksError.Text = "Error Message";
            // 
            // lblAverageSpeed
            // 
            this.lblAverageSpeed.AutoSize = true;
            this.lblAverageSpeed.Location = new System.Drawing.Point(17, 232);
            this.lblAverageSpeed.Name = "lblAverageSpeed";
            this.lblAverageSpeed.Size = new System.Drawing.Size(175, 13);
            this.lblAverageSpeed.TabIndex = 0;
            this.lblAverageSpeed.Text = "What is your average travel speed?";
            // 
            // txtAverageSpeed
            // 
            this.txtAverageSpeed.Location = new System.Drawing.Point(17, 248);
            this.txtAverageSpeed.Name = "txtAverageSpeed";
            this.txtAverageSpeed.Size = new System.Drawing.Size(50, 20);
            this.txtAverageSpeed.TabIndex = 6;
            this.txtAverageSpeed.Text = "0";
            // 
            // lblSpeedError
            // 
            this.lblSpeedError.AutoSize = true;
            this.lblSpeedError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedError.ForeColor = System.Drawing.Color.Red;
            this.lblSpeedError.Location = new System.Drawing.Point(75, 255);
            this.lblSpeedError.Name = "lblSpeedError";
            this.lblSpeedError.Size = new System.Drawing.Size(75, 13);
            this.lblSpeedError.TabIndex = 0;
            this.lblSpeedError.Text = "Error Message";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(417, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DistanceCalclator
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(504, 362);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSpeedError);
            this.Controls.Add(this.txtAverageSpeed);
            this.Controls.Add(this.lblAverageSpeed);
            this.Controls.Add(this.lblBreaksError);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtBreaks);
            this.Controls.Add(this.lblBreaks);
            this.Controls.Add(this.errorGallons);
            this.Controls.Add(this.errorPPG);
            this.Controls.Add(this.errorMPG);
            this.Controls.Add(this.errorMiles);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblGasStops);
            this.Controls.Add(this.lblTotalGas);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.gallonsTB);
            this.Controls.Add(this.gasTankInstruct);
            this.Controls.Add(this.ppgTB);
            this.Controls.Add(this.gasPriceInstruct);
            this.Controls.Add(this.AverageMpgTB);
            this.Controls.Add(this.gasMileageInstruct);
            this.Controls.Add(this.milesTB);
            this.Controls.Add(this.instructions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DistanceCalclator";
            this.Text = "Distance Calulator";
            this.Load += new System.EventHandler(this.DistanceCalclator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.TextBox milesTB;
        private System.Windows.Forms.Label gasMileageInstruct;
        private System.Windows.Forms.TextBox AverageMpgTB;
        private System.Windows.Forms.Label gasPriceInstruct;
        private System.Windows.Forms.TextBox ppgTB;
        private System.Windows.Forms.Label gasTankInstruct;
        private System.Windows.Forms.TextBox gallonsTB;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label lblTotalGas;
        private System.Windows.Forms.Label lblGasStops;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label errorMiles;
        private System.Windows.Forms.Label errorMPG;
        private System.Windows.Forms.Label errorPPG;
        private System.Windows.Forms.Label errorGallons;
        private System.Windows.Forms.TextBox txtBreaks;
        private System.Windows.Forms.Label lblBreaks;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBreaksError;
        private System.Windows.Forms.Label lblAverageSpeed;
        private System.Windows.Forms.TextBox txtAverageSpeed;
        private System.Windows.Forms.Label lblSpeedError;
        private System.Windows.Forms.Button btnClear;
    }
}

