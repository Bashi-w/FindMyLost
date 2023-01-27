﻿namespace FindMyLost
{
    partial class ClaimItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaimItem));
            this.radioAnimal = new System.Windows.Forms.RadioButton();
            this.radioOther = new System.Windows.Forms.RadioButton();
            this.radioElec = new System.Windows.Forms.RadioButton();
            this.LostItemInfo = new System.Windows.Forms.GroupBox();
            this.lblAddInfo = new System.Windows.Forms.Label();
            this.txtAddInfo = new System.Windows.Forms.TextBox();
            this.tlpAddInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.tlpLocation = new System.Windows.Forms.TableLayoutPanel();
            this.panelColorPicker = new System.Windows.Forms.Panel();
            this.pbColorPicker = new System.Windows.Forms.PictureBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.tlpBrand = new System.Windows.Forms.TableLayoutPanel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPic = new System.Windows.Forms.Label();
            this.btnEditItemPic = new System.Windows.Forms.Button();
            this.pbItemPic = new System.Windows.Forms.PictureBox();
            this.radioDocuments = new System.Windows.Forms.RadioButton();
            this.btnPublishClaim = new System.Windows.Forms.Button();
            this.radioAccessories = new System.Windows.Forms.RadioButton();
            this.lblClaimItem = new System.Windows.Forms.Label();
            this.ClaimerInfo = new System.Windows.Forms.GroupBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.tlpPhoneNum = new System.Windows.Forms.TableLayoutPanel();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.tlpAddress = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tlpName = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.radioClothing = new System.Windows.Forms.RadioButton();
            this.LostItemCategory = new System.Windows.Forms.GroupBox();
            this.radioBag = new System.Windows.Forms.RadioButton();
            this.LostItemInfo.SuspendLayout();
            this.panelColorPicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemPic)).BeginInit();
            this.ClaimerInfo.SuspendLayout();
            this.LostItemCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioAnimal
            // 
            this.radioAnimal.AutoSize = true;
            this.radioAnimal.ForeColor = System.Drawing.SystemColors.Control;
            this.radioAnimal.Location = new System.Drawing.Point(202, 103);
            this.radioAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioAnimal.Name = "radioAnimal";
            this.radioAnimal.Size = new System.Drawing.Size(138, 25);
            this.radioAnimal.TabIndex = 187;
            this.radioAnimal.Text = "Animals / Pets";
            this.radioAnimal.UseVisualStyleBackColor = true;
            this.radioAnimal.CheckedChanged += new System.EventHandler(this.radioAnimal_CheckedChanged);
            // 
            // radioOther
            // 
            this.radioOther.AutoSize = true;
            this.radioOther.ForeColor = System.Drawing.SystemColors.Control;
            this.radioOther.Location = new System.Drawing.Point(202, 149);
            this.radioOther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioOther.Name = "radioOther";
            this.radioOther.Size = new System.Drawing.Size(75, 25);
            this.radioOther.TabIndex = 190;
            this.radioOther.Text = "Other";
            this.radioOther.UseVisualStyleBackColor = true;
            this.radioOther.CheckedChanged += new System.EventHandler(this.radioOther_CheckedChanged);
            // 
            // radioElec
            // 
            this.radioElec.AutoSize = true;
            this.radioElec.ForeColor = System.Drawing.SystemColors.Control;
            this.radioElec.Location = new System.Drawing.Point(202, 55);
            this.radioElec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioElec.Name = "radioElec";
            this.radioElec.Size = new System.Drawing.Size(112, 25);
            this.radioElec.TabIndex = 186;
            this.radioElec.Text = "Electronics";
            this.radioElec.UseVisualStyleBackColor = true;
            this.radioElec.CheckedChanged += new System.EventHandler(this.radioElec_CheckedChanged);
            // 
            // LostItemInfo
            // 
            this.LostItemInfo.Controls.Add(this.lblAddInfo);
            this.LostItemInfo.Controls.Add(this.txtAddInfo);
            this.LostItemInfo.Controls.Add(this.tlpAddInfo);
            this.LostItemInfo.Controls.Add(this.txtLocation);
            this.LostItemInfo.Controls.Add(this.tlpLocation);
            this.LostItemInfo.Controls.Add(this.panelColorPicker);
            this.LostItemInfo.Controls.Add(this.lblLocation);
            this.LostItemInfo.Controls.Add(this.txtBrand);
            this.LostItemInfo.Controls.Add(this.tlpBrand);
            this.LostItemInfo.Controls.Add(this.lblBrand);
            this.LostItemInfo.Controls.Add(this.pbColor);
            this.LostItemInfo.Controls.Add(this.lblColor);
            this.LostItemInfo.Controls.Add(this.lblPic);
            this.LostItemInfo.Controls.Add(this.btnEditItemPic);
            this.LostItemInfo.Controls.Add(this.pbItemPic);
            this.LostItemInfo.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LostItemInfo.ForeColor = System.Drawing.Color.White;
            this.LostItemInfo.Location = new System.Drawing.Point(655, 140);
            this.LostItemInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LostItemInfo.Name = "LostItemInfo";
            this.LostItemInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LostItemInfo.Size = new System.Drawing.Size(568, 473);
            this.LostItemInfo.TabIndex = 191;
            this.LostItemInfo.TabStop = false;
            this.LostItemInfo.Text = "Lost Item Description";
            // 
            // lblAddInfo
            // 
            this.lblAddInfo.AutoSize = true;
            this.lblAddInfo.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddInfo.ForeColor = System.Drawing.Color.White;
            this.lblAddInfo.Location = new System.Drawing.Point(215, 241);
            this.lblAddInfo.Name = "lblAddInfo";
            this.lblAddInfo.Size = new System.Drawing.Size(180, 21);
            this.lblAddInfo.TabIndex = 170;
            this.lblAddInfo.Text = "Additional Information";
            // 
            // txtAddInfo
            // 
            this.txtAddInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtAddInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddInfo.ForeColor = System.Drawing.Color.White;
            this.txtAddInfo.Location = new System.Drawing.Point(230, 281);
            this.txtAddInfo.Multiline = true;
            this.txtAddInfo.Name = "txtAddInfo";
            this.txtAddInfo.Size = new System.Drawing.Size(297, 134);
            this.txtAddInfo.TabIndex = 168;
            // 
            // tlpAddInfo
            // 
            this.tlpAddInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tlpAddInfo.ColumnCount = 1;
            this.tlpAddInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddInfo.ForeColor = System.Drawing.Color.White;
            this.tlpAddInfo.Location = new System.Drawing.Point(215, 264);
            this.tlpAddInfo.Name = "tlpAddInfo";
            this.tlpAddInfo.RowCount = 3;
            this.tlpAddInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpAddInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpAddInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpAddInfo.Size = new System.Drawing.Size(326, 170);
            this.tlpAddInfo.TabIndex = 169;
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLocation.ForeColor = System.Drawing.Color.White;
            this.txtLocation.Location = new System.Drawing.Point(35, 185);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(494, 16);
            this.txtLocation.TabIndex = 65;
            // 
            // tlpLocation
            // 
            this.tlpLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tlpLocation.ColumnCount = 1;
            this.tlpLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLocation.Location = new System.Drawing.Point(24, 168);
            this.tlpLocation.Name = "tlpLocation";
            this.tlpLocation.RowCount = 3;
            this.tlpLocation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLocation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLocation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLocation.Size = new System.Drawing.Size(517, 52);
            this.tlpLocation.TabIndex = 64;
            // 
            // panelColorPicker
            // 
            this.panelColorPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelColorPicker.Controls.Add(this.pbColorPicker);
            this.panelColorPicker.Location = new System.Drawing.Point(215, 73);
            this.panelColorPicker.Name = "panelColorPicker";
            this.panelColorPicker.Size = new System.Drawing.Size(58, 52);
            this.panelColorPicker.TabIndex = 154;
            // 
            // pbColorPicker
            // 
            this.pbColorPicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pbColorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbColorPicker.Image = ((System.Drawing.Image)(resources.GetObject("pbColorPicker.Image")));
            this.pbColorPicker.Location = new System.Drawing.Point(12, 11);
            this.pbColorPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbColorPicker.Name = "pbColorPicker";
            this.pbColorPicker.Size = new System.Drawing.Size(30, 30);
            this.pbColorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbColorPicker.TabIndex = 150;
            this.pbColorPicker.TabStop = false;
            this.pbColorPicker.Click += new System.EventHandler(this.pbColorPicker_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(24, 148);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(150, 21);
            this.lblLocation.TabIndex = 63;
            this.lblLocation.Text = "Last Seen Location";
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrand.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBrand.ForeColor = System.Drawing.Color.White;
            this.txtBrand.Location = new System.Drawing.Point(304, 90);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(225, 16);
            this.txtBrand.TabIndex = 153;
            // 
            // tlpBrand
            // 
            this.tlpBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tlpBrand.ColumnCount = 1;
            this.tlpBrand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBrand.Location = new System.Drawing.Point(293, 73);
            this.tlpBrand.Name = "tlpBrand";
            this.tlpBrand.RowCount = 3;
            this.tlpBrand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBrand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBrand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpBrand.Size = new System.Drawing.Size(248, 52);
            this.tlpBrand.TabIndex = 152;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(293, 53);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 21);
            this.lblBrand.TabIndex = 151;
            this.lblBrand.Text = "Brand";
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Transparent;
            this.pbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbColor.Location = new System.Drawing.Point(25, 73);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(184, 52);
            this.pbColor.TabIndex = 149;
            this.pbColor.TabStop = false;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(25, 53);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(59, 21);
            this.lblColor.TabIndex = 148;
            this.lblColor.Text = "Color *";
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPic.ForeColor = System.Drawing.Color.White;
            this.lblPic.Location = new System.Drawing.Point(25, 243);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(122, 21);
            this.lblPic.TabIndex = 147;
            this.lblPic.Text = "Upload Picture";
            // 
            // btnEditItemPic
            // 
            this.btnEditItemPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEditItemPic.FlatAppearance.BorderSize = 0;
            this.btnEditItemPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditItemPic.ForeColor = System.Drawing.Color.White;
            this.btnEditItemPic.Location = new System.Drawing.Point(153, 400);
            this.btnEditItemPic.Name = "btnEditItemPic";
            this.btnEditItemPic.Size = new System.Drawing.Size(34, 34);
            this.btnEditItemPic.TabIndex = 146;
            this.btnEditItemPic.Text = "✏️";
            this.btnEditItemPic.UseVisualStyleBackColor = false;
            this.btnEditItemPic.Click += new System.EventHandler(this.btnEditItemPic_Click);
            this.btnEditItemPic.MouseEnter += new System.EventHandler(this.btnEditItemPic_MouseEnter);
            this.btnEditItemPic.MouseLeave += new System.EventHandler(this.btnEditItemPic_MouseLeave);
            // 
            // pbItemPic
            // 
            this.pbItemPic.Image = ((System.Drawing.Image)(resources.GetObject("pbItemPic.Image")));
            this.pbItemPic.Location = new System.Drawing.Point(25, 264);
            this.pbItemPic.Name = "pbItemPic";
            this.pbItemPic.Size = new System.Drawing.Size(162, 170);
            this.pbItemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemPic.TabIndex = 145;
            this.pbItemPic.TabStop = false;
            // 
            // radioDocuments
            // 
            this.radioDocuments.AutoSize = true;
            this.radioDocuments.ForeColor = System.Drawing.SystemColors.Control;
            this.radioDocuments.Location = new System.Drawing.Point(384, 103);
            this.radioDocuments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioDocuments.Name = "radioDocuments";
            this.radioDocuments.Size = new System.Drawing.Size(118, 25);
            this.radioDocuments.TabIndex = 189;
            this.radioDocuments.Text = "Documents";
            this.radioDocuments.UseVisualStyleBackColor = true;
            this.radioDocuments.CheckedChanged += new System.EventHandler(this.radioDocuments_CheckedChanged);
            // 
            // btnPublishClaim
            // 
            this.btnPublishClaim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(45)))));
            this.btnPublishClaim.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPublishClaim.FlatAppearance.BorderSize = 0;
            this.btnPublishClaim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublishClaim.Font = new System.Drawing.Font("Exo 2", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPublishClaim.ForeColor = System.Drawing.Color.White;
            this.btnPublishClaim.Location = new System.Drawing.Point(655, 639);
            this.btnPublishClaim.Name = "btnPublishClaim";
            this.btnPublishClaim.Size = new System.Drawing.Size(568, 52);
            this.btnPublishClaim.TabIndex = 193;
            this.btnPublishClaim.Text = "PUBLISH CLAIM";
            this.btnPublishClaim.UseVisualStyleBackColor = false;
            this.btnPublishClaim.Click += new System.EventHandler(this.btnPublishClaim_Click);
            // 
            // radioAccessories
            // 
            this.radioAccessories.AutoSize = true;
            this.radioAccessories.ForeColor = System.Drawing.SystemColors.Control;
            this.radioAccessories.Location = new System.Drawing.Point(34, 103);
            this.radioAccessories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioAccessories.Name = "radioAccessories";
            this.radioAccessories.Size = new System.Drawing.Size(116, 25);
            this.radioAccessories.TabIndex = 185;
            this.radioAccessories.Text = "Accessories";
            this.radioAccessories.UseVisualStyleBackColor = true;
            this.radioAccessories.CheckedChanged += new System.EventHandler(this.radioAccessories_CheckedChanged);
            // 
            // lblClaimItem
            // 
            this.lblClaimItem.AutoSize = true;
            this.lblClaimItem.Font = new System.Drawing.Font("Exo 2", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClaimItem.ForeColor = System.Drawing.Color.White;
            this.lblClaimItem.Location = new System.Drawing.Point(64, 76);
            this.lblClaimItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClaimItem.Name = "lblClaimItem";
            this.lblClaimItem.Size = new System.Drawing.Size(209, 28);
            this.lblClaimItem.TabIndex = 189;
            this.lblClaimItem.Text = "Claim a Lost Item";
            // 
            // ClaimerInfo
            // 
            this.ClaimerInfo.Controls.Add(this.txtPhoneNum);
            this.ClaimerInfo.Controls.Add(this.tlpPhoneNum);
            this.ClaimerInfo.Controls.Add(this.lblPhoneNum);
            this.ClaimerInfo.Controls.Add(this.txtAddress);
            this.ClaimerInfo.Controls.Add(this.tlpAddress);
            this.ClaimerInfo.Controls.Add(this.lblAddress);
            this.ClaimerInfo.Controls.Add(this.txtName);
            this.ClaimerInfo.Controls.Add(this.tlpName);
            this.ClaimerInfo.Controls.Add(this.lblName);
            this.ClaimerInfo.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClaimerInfo.ForeColor = System.Drawing.Color.White;
            this.ClaimerInfo.Location = new System.Drawing.Point(64, 140);
            this.ClaimerInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClaimerInfo.Name = "ClaimerInfo";
            this.ClaimerInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClaimerInfo.Size = new System.Drawing.Size(568, 334);
            this.ClaimerInfo.TabIndex = 190;
            this.ClaimerInfo.TabStop = false;
            this.ClaimerInfo.Text = "Claimer Information*";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNum.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNum.ForeColor = System.Drawing.Color.White;
            this.txtPhoneNum.Location = new System.Drawing.Point(34, 262);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(494, 16);
            this.txtPhoneNum.TabIndex = 62;
            // 
            // tlpPhoneNum
            // 
            this.tlpPhoneNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tlpPhoneNum.ColumnCount = 1;
            this.tlpPhoneNum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPhoneNum.Location = new System.Drawing.Point(23, 245);
            this.tlpPhoneNum.Name = "tlpPhoneNum";
            this.tlpPhoneNum.RowCount = 3;
            this.tlpPhoneNum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPhoneNum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPhoneNum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPhoneNum.Size = new System.Drawing.Size(517, 52);
            this.tlpPhoneNum.TabIndex = 61;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNum.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNum.Location = new System.Drawing.Point(23, 225);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(126, 21);
            this.lblPhoneNum.TabIndex = 60;
            this.lblPhoneNum.Text = "Phone Number";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(34, 176);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(494, 16);
            this.txtAddress.TabIndex = 59;
            // 
            // tlpAddress
            // 
            this.tlpAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tlpAddress.ColumnCount = 1;
            this.tlpAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddress.Location = new System.Drawing.Point(23, 159);
            this.tlpAddress.Name = "tlpAddress";
            this.tlpAddress.RowCount = 3;
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAddress.Size = new System.Drawing.Size(517, 52);
            this.tlpAddress.TabIndex = 58;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(23, 139);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 21);
            this.lblAddress.TabIndex = 57;
            this.lblAddress.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(34, 90);
            this.txtName.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(494, 16);
            this.txtName.TabIndex = 56;
            // 
            // tlpName
            // 
            this.tlpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tlpName.ColumnCount = 1;
            this.tlpName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpName.Location = new System.Drawing.Point(23, 73);
            this.tlpName.Name = "tlpName";
            this.tlpName.RowCount = 3;
            this.tlpName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpName.Size = new System.Drawing.Size(517, 52);
            this.tlpName.TabIndex = 55;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(23, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 21);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "Name";
            // 
            // radioClothing
            // 
            this.radioClothing.ForeColor = System.Drawing.SystemColors.Control;
            this.radioClothing.Location = new System.Drawing.Point(34, 54);
            this.radioClothing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioClothing.Name = "radioClothing";
            this.radioClothing.Size = new System.Drawing.Size(99, 24);
            this.radioClothing.TabIndex = 184;
            this.radioClothing.Text = "Clothing";
            this.radioClothing.UseVisualStyleBackColor = true;
            this.radioClothing.CheckedChanged += new System.EventHandler(this.radioClothing_CheckedChanged);
            // 
            // LostItemCategory
            // 
            this.LostItemCategory.Controls.Add(this.radioAnimal);
            this.LostItemCategory.Controls.Add(this.radioOther);
            this.LostItemCategory.Controls.Add(this.radioElec);
            this.LostItemCategory.Controls.Add(this.radioDocuments);
            this.LostItemCategory.Controls.Add(this.radioAccessories);
            this.LostItemCategory.Controls.Add(this.radioClothing);
            this.LostItemCategory.Controls.Add(this.radioBag);
            this.LostItemCategory.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LostItemCategory.ForeColor = System.Drawing.Color.White;
            this.LostItemCategory.Location = new System.Drawing.Point(64, 491);
            this.LostItemCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LostItemCategory.Name = "LostItemCategory";
            this.LostItemCategory.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LostItemCategory.Size = new System.Drawing.Size(568, 212);
            this.LostItemCategory.TabIndex = 192;
            this.LostItemCategory.TabStop = false;
            this.LostItemCategory.Text = "Lost Item Category*";
            // 
            // radioBag
            // 
            this.radioBag.AutoSize = true;
            this.radioBag.ForeColor = System.Drawing.SystemColors.Control;
            this.radioBag.Location = new System.Drawing.Point(384, 55);
            this.radioBag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBag.Name = "radioBag";
            this.radioBag.Size = new System.Drawing.Size(148, 25);
            this.radioBag.TabIndex = 188;
            this.radioBag.Text = "Bags / Luggage";
            this.radioBag.UseVisualStyleBackColor = true;
            this.radioBag.CheckedChanged += new System.EventHandler(this.radioBag_CheckedChanged);
            // 
            // ClaimItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1285, 774);
            this.Controls.Add(this.LostItemInfo);
            this.Controls.Add(this.btnPublishClaim);
            this.Controls.Add(this.lblClaimItem);
            this.Controls.Add(this.ClaimerInfo);
            this.Controls.Add(this.LostItemCategory);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ClaimItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Claima Lost Item";
            this.LostItemInfo.ResumeLayout(false);
            this.LostItemInfo.PerformLayout();
            this.panelColorPicker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbColorPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemPic)).EndInit();
            this.ClaimerInfo.ResumeLayout(false);
            this.ClaimerInfo.PerformLayout();
            this.LostItemCategory.ResumeLayout(false);
            this.LostItemCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioAnimal;
        private System.Windows.Forms.RadioButton radioOther;
        private System.Windows.Forms.RadioButton radioElec;
        private System.Windows.Forms.GroupBox LostItemInfo;
        private System.Windows.Forms.Label lblAddInfo;
        private System.Windows.Forms.TextBox txtAddInfo;
        private System.Windows.Forms.TableLayoutPanel tlpAddInfo;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TableLayoutPanel tlpLocation;
        private System.Windows.Forms.Panel panelColorPicker;
        private System.Windows.Forms.PictureBox pbColorPicker;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TableLayoutPanel tlpBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.Button btnEditItemPic;
        private System.Windows.Forms.PictureBox pbItemPic;
        private System.Windows.Forms.RadioButton radioDocuments;
        private System.Windows.Forms.Button btnPublishClaim;
        private System.Windows.Forms.RadioButton radioAccessories;
        private System.Windows.Forms.Label lblClaimItem;
        private System.Windows.Forms.GroupBox ClaimerInfo;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TableLayoutPanel tlpPhoneNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TableLayoutPanel tlpAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TableLayoutPanel tlpName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton radioClothing;
        private System.Windows.Forms.GroupBox LostItemCategory;
        private System.Windows.Forms.RadioButton radioBag;
    }
}