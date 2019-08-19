namespace Cars_Sales
{
    partial class FormRecordCars
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
            this.modelLabel = new System.Windows.Forms.Label();
            this.carNoLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.CarID = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.SaveCarSales = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Make = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.BackColor = System.Drawing.Color.Transparent;
            this.modelLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modelLabel.Location = new System.Drawing.Point(207, 241);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 0;
            this.modelLabel.Text = "Model";
            this.modelLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // carNoLabel
            // 
            this.carNoLabel.AutoSize = true;
            this.carNoLabel.BackColor = System.Drawing.Color.Transparent;
            this.carNoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.carNoLabel.Location = new System.Drawing.Point(207, 131);
            this.carNoLabel.Name = "carNoLabel";
            this.carNoLabel.Size = new System.Drawing.Size(40, 13);
            this.carNoLabel.TabIndex = 0;
            this.carNoLabel.Text = "Car No";
            this.carNoLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.BackColor = System.Drawing.Color.Transparent;
            this.makeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.makeLabel.Location = new System.Drawing.Point(207, 189);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(34, 13);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "Make";
            this.makeLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.priceLabel.Location = new System.Drawing.Point(207, 300);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Price";
            this.priceLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // CarID
            // 
            this.CarID.BackColor = System.Drawing.SystemColors.Window;
            this.CarID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarID.Location = new System.Drawing.Point(210, 147);
            this.CarID.Multiline = true;
            this.CarID.Name = "CarID";
            this.CarID.Size = new System.Drawing.Size(316, 30);
            this.CarID.TabIndex = 1;
            this.CarID.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Price
            // 
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price.Location = new System.Drawing.Point(210, 316);
            this.Price.Multiline = true;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(316, 31);
            this.Price.TabIndex = 1;
            // 
            // Model
            // 
            this.Model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Model.Location = new System.Drawing.Point(210, 257);
            this.Model.Multiline = true;
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(316, 29);
            this.Model.TabIndex = 1;
            this.Model.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // SaveCarSales
            // 
            this.SaveCarSales.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveCarSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveCarSales.Location = new System.Drawing.Point(286, 377);
            this.SaveCarSales.Name = "SaveCarSales";
            this.SaveCarSales.Size = new System.Drawing.Size(107, 34);
            this.SaveCarSales.TabIndex = 2;
            this.SaveCarSales.Text = "Save";
            this.SaveCarSales.UseVisualStyleBackColor = false;
            this.SaveCarSales.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(170, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 40);
            this.label5.TabIndex = 3;
            this.label5.Text = "CARS SALES RECORD FORM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // Make
            // 
            this.Make.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Make.FormattingEnabled = true;
            this.Make.Location = new System.Drawing.Point(210, 206);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(316, 21);
            this.Make.TabIndex = 4;
            // 
            // FormRecordCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Cars_Sales.Properties.Resources.bgimg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 455);
            this.Controls.Add(this.Make);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaveCarSales);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.CarID);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.carNoLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.modelLabel);
            this.Name = "FormRecordCars";
            this.Text = "Add sales data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label carNoLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox CarID;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.Button SaveCarSales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Make;
    }
}

