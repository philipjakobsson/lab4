namespace WordDisctionary_Lab4
{
    partial class AddNewList
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.tbLanguages = new System.Windows.Forms.TextBox();
            this.labelLanguages = new System.Windows.Forms.Label();
            this.labelListName = new System.Windows.Forms.Label();
            this.tbListName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(404, 194);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(79, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.Location = new System.Drawing.Point(265, 194);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(103, 23);
            this.buttonConfirm.TabIndex = 11;
            this.buttonConfirm.Text = "&Add New List";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // tbLanguages
            // 
            this.tbLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLanguages.Location = new System.Drawing.Point(139, 78);
            this.tbLanguages.Multiline = true;
            this.tbLanguages.Name = "tbLanguages";
            this.tbLanguages.Size = new System.Drawing.Size(344, 94);
            this.tbLanguages.TabIndex = 10;
            // 
            // labelLanguages
            // 
            this.labelLanguages.AutoSize = true;
            this.labelLanguages.Location = new System.Drawing.Point(51, 78);
            this.labelLanguages.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelLanguages.Name = "labelLanguages";
            this.labelLanguages.Size = new System.Drawing.Size(63, 13);
            this.labelLanguages.TabIndex = 9;
            this.labelLanguages.Text = "Languages:";
            // 
            // labelListName
            // 
            this.labelListName.AutoSize = true;
            this.labelListName.Location = new System.Drawing.Point(59, 38);
            this.labelListName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.labelListName.Name = "labelListName";
            this.labelListName.Size = new System.Drawing.Size(55, 13);
            this.labelListName.TabIndex = 8;
            this.labelListName.Text = "List name:";
            // 
            // tbListName
            // 
            this.tbListName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbListName.Location = new System.Drawing.Point(139, 36);
            this.tbListName.Name = "tbListName";
            this.tbListName.Size = new System.Drawing.Size(344, 20);
            this.tbListName.TabIndex = 7;
            // 
            // AddNewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 287);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.tbLanguages);
            this.Controls.Add(this.labelLanguages);
            this.Controls.Add(this.labelListName);
            this.Controls.Add(this.tbListName);
            this.Name = "AddNewList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox tbLanguages;
        private System.Windows.Forms.Label labelLanguages;
        private System.Windows.Forms.Label labelListName;
        private System.Windows.Forms.TextBox tbListName;
    }
}