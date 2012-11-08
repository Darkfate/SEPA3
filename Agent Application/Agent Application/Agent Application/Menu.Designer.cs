namespace Agent_Application
{
    partial class Menu
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
            this.tabWindow = new System.Windows.Forms.TabControl();
            this.PropertyManagement = new System.Windows.Forms.TabPage();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.assetBox = new System.Windows.Forms.ListBox();
            this.agentIdText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.costText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.propertyTypeText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.countryText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stateText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.postCodeText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.suburbText = new System.Windows.Forms.TextBox();
            this.streetNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.streetNoText = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.propertyBox = new System.Windows.Forms.ListBox();
            this.AssetsManagement = new System.Windows.Forms.TabPage();
            this.tabWindow.SuspendLayout();
            this.PropertyManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabWindow
            // 
            this.tabWindow.Controls.Add(this.PropertyManagement);
            this.tabWindow.Controls.Add(this.AssetsManagement);
            this.tabWindow.Location = new System.Drawing.Point(12, 12);
            this.tabWindow.Name = "tabWindow";
            this.tabWindow.SelectedIndex = 0;
            this.tabWindow.Size = new System.Drawing.Size(696, 546);
            this.tabWindow.TabIndex = 0;
            // 
            // PropertyManagement
            // 
            this.PropertyManagement.Controls.Add(this.cancelButton);
            this.PropertyManagement.Controls.Add(this.saveButton);
            this.PropertyManagement.Controls.Add(this.label11);
            this.PropertyManagement.Controls.Add(this.assetBox);
            this.PropertyManagement.Controls.Add(this.agentIdText);
            this.PropertyManagement.Controls.Add(this.label10);
            this.PropertyManagement.Controls.Add(this.costText);
            this.PropertyManagement.Controls.Add(this.label9);
            this.PropertyManagement.Controls.Add(this.propertyTypeText);
            this.PropertyManagement.Controls.Add(this.label8);
            this.PropertyManagement.Controls.Add(this.countryText);
            this.PropertyManagement.Controls.Add(this.label7);
            this.PropertyManagement.Controls.Add(this.stateText);
            this.PropertyManagement.Controls.Add(this.label6);
            this.PropertyManagement.Controls.Add(this.postCodeText);
            this.PropertyManagement.Controls.Add(this.label5);
            this.PropertyManagement.Controls.Add(this.label4);
            this.PropertyManagement.Controls.Add(this.suburbText);
            this.PropertyManagement.Controls.Add(this.streetNameText);
            this.PropertyManagement.Controls.Add(this.label3);
            this.PropertyManagement.Controls.Add(this.label2);
            this.PropertyManagement.Controls.Add(this.streetNoText);
            this.PropertyManagement.Controls.Add(this.deleteButton);
            this.PropertyManagement.Controls.Add(this.addButton);
            this.PropertyManagement.Controls.Add(this.label1);
            this.PropertyManagement.Controls.Add(this.propertyBox);
            this.PropertyManagement.Location = new System.Drawing.Point(4, 22);
            this.PropertyManagement.Name = "PropertyManagement";
            this.PropertyManagement.Padding = new System.Windows.Forms.Padding(3);
            this.PropertyManagement.Size = new System.Drawing.Size(688, 520);
            this.PropertyManagement.TabIndex = 0;
            this.PropertyManagement.Text = "Property Management";
            this.PropertyManagement.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(338, 455);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(237, 455);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(504, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Property Assets";
            // 
            // assetBox
            // 
            this.assetBox.FormattingEnabled = true;
            this.assetBox.Location = new System.Drawing.Point(507, 274);
            this.assetBox.Name = "assetBox";
            this.assetBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.assetBox.Size = new System.Drawing.Size(165, 225);
            this.assetBox.TabIndex = 23;
            // 
            // agentIdText
            // 
            this.agentIdText.Location = new System.Drawing.Point(237, 394);
            this.agentIdText.Name = "agentIdText";
            this.agentIdText.Size = new System.Drawing.Size(72, 20);
            this.agentIdText.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Agent ID";
            // 
            // costText
            // 
            this.costText.Location = new System.Drawing.Point(237, 343);
            this.costText.Name = "costText";
            this.costText.Size = new System.Drawing.Size(164, 20);
            this.costText.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cost";
            // 
            // propertyTypeText
            // 
            this.propertyTypeText.Location = new System.Drawing.Point(237, 290);
            this.propertyTypeText.Name = "propertyTypeText";
            this.propertyTypeText.Size = new System.Drawing.Size(164, 20);
            this.propertyTypeText.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Property Type";
            // 
            // countryText
            // 
            this.countryText.Location = new System.Drawing.Point(237, 181);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(113, 20);
            this.countryText.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Country";
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(582, 130);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(49, 20);
            this.stateText.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "State";
            // 
            // postCodeText
            // 
            this.postCodeText.Location = new System.Drawing.Point(507, 130);
            this.postCodeText.Name = "postCodeText";
            this.postCodeText.Size = new System.Drawing.Size(49, 20);
            this.postCodeText.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Post Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Suburb";
            // 
            // suburbText
            // 
            this.suburbText.Location = new System.Drawing.Point(237, 130);
            this.suburbText.Name = "suburbText";
            this.suburbText.Size = new System.Drawing.Size(243, 20);
            this.suburbText.TabIndex = 8;
            // 
            // streetNameText
            // 
            this.streetNameText.Location = new System.Drawing.Point(338, 74);
            this.streetNameText.Name = "streetNameText";
            this.streetNameText.Size = new System.Drawing.Size(293, 20);
            this.streetNameText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Street Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Street Number";
            // 
            // streetNoText
            // 
            this.streetNoText.Location = new System.Drawing.Point(237, 74);
            this.streetNoText.Name = "streetNoText";
            this.streetNoText.Size = new System.Drawing.Size(72, 20);
            this.streetNoText.TabIndex = 4;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(108, 491);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 491);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Properties";
            // 
            // propertyBox
            // 
            this.propertyBox.FormattingEnabled = true;
            this.propertyBox.Location = new System.Drawing.Point(6, 39);
            this.propertyBox.Name = "propertyBox";
            this.propertyBox.Size = new System.Drawing.Size(210, 446);
            this.propertyBox.TabIndex = 0;
            this.propertyBox.SelectedIndexChanged += new System.EventHandler(this.propertyBox_SelectedIndexChanged);
            // 
            // AssetsManagement
            // 
            this.AssetsManagement.Location = new System.Drawing.Point(4, 22);
            this.AssetsManagement.Name = "AssetsManagement";
            this.AssetsManagement.Padding = new System.Windows.Forms.Padding(3);
            this.AssetsManagement.Size = new System.Drawing.Size(688, 520);
            this.AssetsManagement.TabIndex = 1;
            this.AssetsManagement.Text = "Assets Management";
            this.AssetsManagement.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 570);
            this.Controls.Add(this.tabWindow);
            this.Name = "Menu";
            this.Text = "aDREAM Agent";
            this.tabWindow.ResumeLayout(false);
            this.PropertyManagement.ResumeLayout(false);
            this.PropertyManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabWindow;
        private System.Windows.Forms.TabPage PropertyManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox propertyBox;
        private System.Windows.Forms.TabPage AssetsManagement;
        private System.Windows.Forms.TextBox agentIdText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox costText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox propertyTypeText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox postCodeText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox suburbText;
        private System.Windows.Forms.TextBox streetNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox streetNoText;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox assetBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

