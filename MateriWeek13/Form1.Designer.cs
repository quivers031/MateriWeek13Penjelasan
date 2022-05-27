namespace MateriWeek13
{
    partial class Form_MateriWeek13
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
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.tBox_PlayerID = new System.Windows.Forms.TextBox();
            this.tBox_PlayerName = new System.Windows.Forms.TextBox();
            this.dtp_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.cBox_Nationality = new System.Windows.Forms.ComboBox();
            this.cBox_Team = new System.Windows.Forms.ComboBox();
            this.nUD_TeamNumber = new System.Windows.Forms.NumericUpDown();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label_Available = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(25, 12);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(75, 23);
            this.btn_First.TabIndex = 0;
            this.btn_First.Text = "<<";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(106, 12);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(75, 23);
            this.btn_Prev.TabIndex = 1;
            this.btn_Prev.Text = "<";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(187, 12);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(268, 12);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(75, 23);
            this.btn_Last.TabIndex = 3;
            this.btn_Last.Text = ">>";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // tBox_PlayerID
            // 
            this.tBox_PlayerID.Location = new System.Drawing.Point(106, 67);
            this.tBox_PlayerID.Name = "tBox_PlayerID";
            this.tBox_PlayerID.Size = new System.Drawing.Size(100, 20);
            this.tBox_PlayerID.TabIndex = 4;
            // 
            // tBox_PlayerName
            // 
            this.tBox_PlayerName.Location = new System.Drawing.Point(106, 93);
            this.tBox_PlayerName.Name = "tBox_PlayerName";
            this.tBox_PlayerName.Size = new System.Drawing.Size(100, 20);
            this.tBox_PlayerName.TabIndex = 5;
            // 
            // dtp_Birthdate
            // 
            this.dtp_Birthdate.Location = new System.Drawing.Point(106, 119);
            this.dtp_Birthdate.Name = "dtp_Birthdate";
            this.dtp_Birthdate.Size = new System.Drawing.Size(200, 20);
            this.dtp_Birthdate.TabIndex = 6;
            // 
            // cBox_Nationality
            // 
            this.cBox_Nationality.FormattingEnabled = true;
            this.cBox_Nationality.Location = new System.Drawing.Point(106, 145);
            this.cBox_Nationality.Name = "cBox_Nationality";
            this.cBox_Nationality.Size = new System.Drawing.Size(121, 21);
            this.cBox_Nationality.TabIndex = 7;
            // 
            // cBox_Team
            // 
            this.cBox_Team.FormattingEnabled = true;
            this.cBox_Team.Location = new System.Drawing.Point(106, 172);
            this.cBox_Team.Name = "cBox_Team";
            this.cBox_Team.Size = new System.Drawing.Size(121, 21);
            this.cBox_Team.TabIndex = 8;
            this.cBox_Team.SelectedIndexChanged += new System.EventHandler(this.cBox_Team_SelectedIndexChanged);
            // 
            // nUD_TeamNumber
            // 
            this.nUD_TeamNumber.Location = new System.Drawing.Point(106, 199);
            this.nUD_TeamNumber.Name = "nUD_TeamNumber";
            this.nUD_TeamNumber.Size = new System.Drawing.Size(120, 20);
            this.nUD_TeamNumber.TabIndex = 9;
            this.nUD_TeamNumber.ValueChanged += new System.EventHandler(this.nUD_TeamNumber_ValueChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(42, 243);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(151, 243);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Close";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label_Available
            // 
            this.label_Available.AutoSize = true;
            this.label_Available.Location = new System.Drawing.Point(244, 201);
            this.label_Available.Name = "label_Available";
            this.label_Available.Size = new System.Drawing.Size(35, 13);
            this.label_Available.TabIndex = 12;
            this.label_Available.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Player ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Birthdate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nationality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Team Number";
            // 
            // Form_MateriWeek13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Available);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.nUD_TeamNumber);
            this.Controls.Add(this.cBox_Team);
            this.Controls.Add(this.cBox_Nationality);
            this.Controls.Add(this.dtp_Birthdate);
            this.Controls.Add(this.tBox_PlayerName);
            this.Controls.Add(this.tBox_PlayerID);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_First);
            this.Name = "Form_MateriWeek13";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Form_MateriWeek13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_TeamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.TextBox tBox_PlayerID;
        private System.Windows.Forms.TextBox tBox_PlayerName;
        private System.Windows.Forms.DateTimePicker dtp_Birthdate;
        private System.Windows.Forms.ComboBox cBox_Nationality;
        private System.Windows.Forms.ComboBox cBox_Team;
        private System.Windows.Forms.NumericUpDown nUD_TeamNumber;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label_Available;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

