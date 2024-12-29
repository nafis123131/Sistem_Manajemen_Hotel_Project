namespace Sistem_Manajemen_Hotel.View
{
    partial class usercontrolRoom
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
            this.grbSearchRoom = new System.Windows.Forms.GroupBox();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchRoom = new System.Windows.Forms.TextBox();
            this.lvwRoom = new System.Windows.Forms.ListView();
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.grbSearchRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSearchRoom
            // 
            this.grbSearchRoom.Controls.Add(this.btnDeleteRoom);
            this.grbSearchRoom.Controls.Add(this.btnUpdateRoom);
            this.grbSearchRoom.Controls.Add(this.btnAddRoom);
            this.grbSearchRoom.Controls.Add(this.label3);
            this.grbSearchRoom.Controls.Add(this.txtSearchRoom);
            this.grbSearchRoom.Controls.Add(this.lvwRoom);
            this.grbSearchRoom.Controls.Add(this.btnSearchRoom);
            this.grbSearchRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearchRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.grbSearchRoom.Location = new System.Drawing.Point(3, 3);
            this.grbSearchRoom.Margin = new System.Windows.Forms.Padding(4);
            this.grbSearchRoom.Name = "grbSearchRoom";
            this.grbSearchRoom.Padding = new System.Windows.Forms.Padding(4);
            this.grbSearchRoom.Size = new System.Drawing.Size(987, 434);
            this.grbSearchRoom.TabIndex = 10;
            this.grbSearchRoom.TabStop = false;
            this.grbSearchRoom.Text = "[ Search Room : ]";
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.Red;
            this.btnDeleteRoom.FlatAppearance.BorderSize = 0;
            this.btnDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRoom.Location = new System.Drawing.Point(291, 393);
            this.btnDeleteRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(134, 35);
            this.btnDeleteRoom.TabIndex = 9;
            this.btnDeleteRoom.Text = "Delete Room";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnUpdateRoom.FlatAppearance.BorderSize = 0;
            this.btnUpdateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRoom.Location = new System.Drawing.Point(151, 393);
            this.btnUpdateRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(134, 35);
            this.btnUpdateRoom.TabIndex = 10;
            this.btnUpdateRoom.Text = "Update Room";
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(11, 393);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(134, 35);
            this.btnAddRoom.TabIndex = 11;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search Room :";
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.Location = new System.Drawing.Point(144, 33);
            this.txtSearchRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(337, 27);
            this.txtSearchRoom.TabIndex = 1;
            // 
            // lvwRoom
            // 
            this.lvwRoom.HideSelection = false;
            this.lvwRoom.Location = new System.Drawing.Point(11, 82);
            this.lvwRoom.Margin = new System.Windows.Forms.Padding(4);
            this.lvwRoom.Name = "lvwRoom";
            this.lvwRoom.Size = new System.Drawing.Size(970, 296);
            this.lvwRoom.TabIndex = 0;
            this.lvwRoom.UseCompatibleStateImageBehavior = false;
            this.lvwRoom.View = System.Windows.Forms.View.SmallIcon;
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnSearchRoom.FlatAppearance.BorderSize = 0;
            this.btnSearchRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRoom.ForeColor = System.Drawing.Color.White;
            this.btnSearchRoom.Location = new System.Drawing.Point(487, 33);
            this.btnSearchRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(134, 27);
            this.btnSearchRoom.TabIndex = 5;
            this.btnSearchRoom.Text = "Search";
            this.btnSearchRoom.UseVisualStyleBackColor = false;
            this.btnSearchRoom.Click += new System.EventHandler(this.btnSearchRoom_Click);
            // 
            // usercontrolRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grbSearchRoom);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "usercontrolRoom";
            this.Size = new System.Drawing.Size(993, 449);
            this.grbSearchRoom.ResumeLayout(false);
            this.grbSearchRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSearchRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchRoom;
        private System.Windows.Forms.ListView lvwRoom;
        private System.Windows.Forms.Button btnSearchRoom;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Button btnAddRoom;
    }
}
