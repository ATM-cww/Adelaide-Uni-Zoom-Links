namespace Zoom_上課
{
    partial class Room
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.password = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.GoToRoom = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Controls.Add(this.password, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.id, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.GoToRoom, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1208, 51);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password.Location = new System.Drawing.Point(807, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(398, 51);
            this.password.TabIndex = 2;
            this.password.Text = "xxxxxxxx";
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id.Location = new System.Drawing.Point(405, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(396, 51);
            this.id.TabIndex = 1;
            this.id.Text = "xxx xxx xxxx";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoToRoom
            // 
            this.GoToRoom.BorderRadius = 22;
            this.GoToRoom.CheckedState.Parent = this.GoToRoom;
            this.GoToRoom.CustomImages.Parent = this.GoToRoom;
            this.GoToRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoToRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.GoToRoom.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.GoToRoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GoToRoom.HoverState.Parent = this.GoToRoom;
            this.GoToRoom.Location = new System.Drawing.Point(20, 3);
            this.GoToRoom.Margin = new System.Windows.Forms.Padding(20, 3, 40, 3);
            this.GoToRoom.Name = "GoToRoom";
            this.GoToRoom.ShadowDecoration.Parent = this.GoToRoom;
            this.GoToRoom.Size = new System.Drawing.Size(342, 45);
            this.GoToRoom.TabIndex = 3;
            this.GoToRoom.Text = "Room";
            this.GoToRoom.Click += new System.EventHandler(this.GoToRoom_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Room";
            this.Size = new System.Drawing.Size(1208, 51);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label id;
        public Guna.UI2.WinForms.Guna2Button GoToRoom;
    }
}
