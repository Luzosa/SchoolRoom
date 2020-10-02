namespace FormUI
{
    partial class Dashboard
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
            this.RoomListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomNumb = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.RoomText = new System.Windows.Forms.TextBox();
            this.room = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.TextBox();
            this.Temperature = new System.Windows.Forms.Label();
            this.humText = new System.Windows.Forms.TextBox();
            this.Humidity = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoomListBox
            // 
            this.RoomListBox.FormattingEnabled = true;
            this.RoomListBox.ItemHeight = 31;
            this.RoomListBox.Location = new System.Drawing.Point(29, 190);
            this.RoomListBox.Name = "RoomListBox";
            this.RoomListBox.Size = new System.Drawing.Size(564, 159);
            this.RoomListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Number:";
            // 
            // RoomNumb
            // 
            this.RoomNumb.Location = new System.Drawing.Point(251, 77);
            this.RoomNumb.Name = "RoomNumb";
            this.RoomNumb.Size = new System.Drawing.Size(163, 38);
            this.RoomNumb.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(103, 135);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(140, 38);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // RoomText
            // 
            this.RoomText.Location = new System.Drawing.Point(266, 391);
            this.RoomText.Name = "RoomText";
            this.RoomText.Size = new System.Drawing.Size(163, 38);
            this.RoomText.TabIndex = 5;
            // 
            // room
            // 
            this.room.AutoSize = true;
            this.room.Location = new System.Drawing.Point(38, 397);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(205, 32);
            this.room.TabIndex = 4;
            this.room.Text = "Room Number:";
            // 
            // Temp
            // 
            this.Temp.Location = new System.Drawing.Point(266, 444);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(163, 38);
            this.Temp.TabIndex = 7;
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Location = new System.Drawing.Point(38, 450);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(185, 32);
            this.Temperature.TabIndex = 6;
            this.Temperature.Text = "Temperature:";
            // 
            // humText
            // 
            this.humText.Location = new System.Drawing.Point(266, 500);
            this.humText.Name = "humText";
            this.humText.Size = new System.Drawing.Size(163, 38);
            this.humText.TabIndex = 9;
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.Location = new System.Drawing.Point(38, 506);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(134, 32);
            this.Humidity.TabIndex = 8;
            this.Humidity.Text = "Humidity:";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(164, 580);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(140, 38);
            this.Insert.TabIndex = 10;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 716);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.humText);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.RoomText);
            this.Controls.Add(this.room);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.RoomNumb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoomListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RoomListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RoomNumb;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox RoomText;
        private System.Windows.Forms.Label room;
        private System.Windows.Forms.TextBox Temp;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.TextBox humText;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.Button Insert;
    }
}

