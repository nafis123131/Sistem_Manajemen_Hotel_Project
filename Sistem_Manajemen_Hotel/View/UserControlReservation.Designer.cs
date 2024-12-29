namespace Sistem_Manajemen_Hotel.View
{
    partial class usercontrolReservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbSearchReservation = new System.Windows.Forms.GroupBox();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.btnUpdateReservation = new System.Windows.Forms.Button();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchReservation = new System.Windows.Forms.TextBox();
            this.lvwReservation = new System.Windows.Forms.ListView();
            this.btnSearchReservation = new System.Windows.Forms.Button();
            this.grbSearchReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSearchReservation
            // 
            this.grbSearchReservation.Controls.Add(this.btnDeleteReservation);
            this.grbSearchReservation.Controls.Add(this.btnUpdateReservation);
            this.grbSearchReservation.Controls.Add(this.btnAddReservation);
            this.grbSearchReservation.Controls.Add(this.label3);
            this.grbSearchReservation.Controls.Add(this.txtSearchReservation);
            this.grbSearchReservation.Controls.Add(this.lvwReservation);
            this.grbSearchReservation.Controls.Add(this.btnSearchReservation);
            this.grbSearchReservation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearchReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.grbSearchReservation.Location = new System.Drawing.Point(3, 3);
            this.grbSearchReservation.Name = "grbSearchReservation";
            this.grbSearchReservation.Size = new System.Drawing.Size(987, 433);
            this.grbSearchReservation.TabIndex = 13;
            this.grbSearchReservation.TabStop = false;
            this.grbSearchReservation.Text = "[ Search Reservation : ]";
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.BackColor = System.Drawing.Color.Red;
            this.btnDeleteReservation.FlatAppearance.BorderSize = 0;
            this.btnDeleteReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteReservation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReservation.ForeColor = System.Drawing.Color.White;
            this.btnDeleteReservation.Location = new System.Drawing.Point(343, 393);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(169, 35);
            this.btnDeleteReservation.TabIndex = 12;
            this.btnDeleteReservation.Text = "Delete Reservation";
            this.btnDeleteReservation.UseVisualStyleBackColor = false;
            // 
            // btnUpdateReservation
            // 
            this.btnUpdateReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnUpdateReservation.FlatAppearance.BorderSize = 0;
            this.btnUpdateReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateReservation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateReservation.ForeColor = System.Drawing.Color.White;
            this.btnUpdateReservation.Location = new System.Drawing.Point(168, 393);
            this.btnUpdateReservation.Name = "btnUpdateReservation";
            this.btnUpdateReservation.Size = new System.Drawing.Size(169, 35);
            this.btnUpdateReservation.TabIndex = 13;
            this.btnUpdateReservation.Text = "Update Reservation";
            this.btnUpdateReservation.UseVisualStyleBackColor = false;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnAddReservation.FlatAppearance.BorderSize = 0;
            this.btnAddReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReservation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.ForeColor = System.Drawing.Color.White;
            this.btnAddReservation.Location = new System.Drawing.Point(11, 393);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(151, 35);
            this.btnAddReservation.TabIndex = 14;
            this.btnAddReservation.Text = "Add Reservation";
            this.btnAddReservation.UseVisualStyleBackColor = false;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search Reservation :";
            // 
            // txtSearchReservation
            // 
            this.txtSearchReservation.Location = new System.Drawing.Point(186, 32);
            this.txtSearchReservation.Name = "txtSearchReservation";
            this.txtSearchReservation.Size = new System.Drawing.Size(337, 27);
            this.txtSearchReservation.TabIndex = 1;
            // 
            // lvwReservation
            // 
            this.lvwReservation.HideSelection = false;
            this.lvwReservation.Location = new System.Drawing.Point(11, 82);
            this.lvwReservation.Name = "lvwReservation";
            this.lvwReservation.Size = new System.Drawing.Size(970, 296);
            this.lvwReservation.TabIndex = 0;
            this.lvwReservation.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearchReservation
            // 
            this.btnSearchReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnSearchReservation.FlatAppearance.BorderSize = 0;
            this.btnSearchReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchReservation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReservation.ForeColor = System.Drawing.Color.White;
            this.btnSearchReservation.Location = new System.Drawing.Point(529, 32);
            this.btnSearchReservation.Name = "btnSearchReservation";
            this.btnSearchReservation.Size = new System.Drawing.Size(134, 27);
            this.btnSearchReservation.TabIndex = 5;
            this.btnSearchReservation.Text = "Search";
            this.btnSearchReservation.UseVisualStyleBackColor = false;
            // 
            // usercontrolReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grbSearchReservation);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usercontrolReservation";
            this.Size = new System.Drawing.Size(993, 449);
            this.grbSearchReservation.ResumeLayout(false);
            this.grbSearchReservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSearchReservation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchReservation;
        private System.Windows.Forms.ListView lvwReservation;
        private System.Windows.Forms.Button btnSearchReservation;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.Button btnUpdateReservation;
        private System.Windows.Forms.Button btnAddReservation;
    }
}
