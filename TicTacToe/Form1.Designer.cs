namespace TicTacToe
{
    partial class TicTacToe
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
            this.Top1 = new System.Windows.Forms.Button();
            this.Top2 = new System.Windows.Forms.Button();
            this.Top3 = new System.Windows.Forms.Button();
            this.Mid1 = new System.Windows.Forms.Button();
            this.Mid2 = new System.Windows.Forms.Button();
            this.Mid3 = new System.Windows.Forms.Button();
            this.Bot1 = new System.Windows.Forms.Button();
            this.Bot2 = new System.Windows.Forms.Button();
            this.Bot3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Top1
            // 
            this.Top1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top1.Location = new System.Drawing.Point(12, 12);
            this.Top1.Name = "Top1";
            this.Top1.Size = new System.Drawing.Size(100, 100);
            this.Top1.TabIndex = 0;
            this.Top1.UseVisualStyleBackColor = true;
            this.Top1.Click += new System.EventHandler(this.Top1_Click);
            // 
            // Top2
            // 
            this.Top2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top2.Location = new System.Drawing.Point(118, 12);
            this.Top2.Name = "Top2";
            this.Top2.Size = new System.Drawing.Size(100, 100);
            this.Top2.TabIndex = 1;
            this.Top2.UseVisualStyleBackColor = true;
            this.Top2.Click += new System.EventHandler(this.Top2_Click);
            // 
            // Top3
            // 
            this.Top3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top3.Location = new System.Drawing.Point(224, 12);
            this.Top3.Name = "Top3";
            this.Top3.Size = new System.Drawing.Size(100, 100);
            this.Top3.TabIndex = 2;
            this.Top3.UseVisualStyleBackColor = true;
            this.Top3.Click += new System.EventHandler(this.Top3_Click);
            // 
            // Mid1
            // 
            this.Mid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mid1.Location = new System.Drawing.Point(12, 118);
            this.Mid1.Name = "Mid1";
            this.Mid1.Size = new System.Drawing.Size(100, 100);
            this.Mid1.TabIndex = 3;
            this.Mid1.UseVisualStyleBackColor = true;
            this.Mid1.Click += new System.EventHandler(this.Mid1_Click);
            // 
            // Mid2
            // 
            this.Mid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mid2.Location = new System.Drawing.Point(118, 118);
            this.Mid2.Name = "Mid2";
            this.Mid2.Size = new System.Drawing.Size(100, 100);
            this.Mid2.TabIndex = 4;
            this.Mid2.UseVisualStyleBackColor = true;
            this.Mid2.Click += new System.EventHandler(this.Mid2_Click);
            // 
            // Mid3
            // 
            this.Mid3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mid3.Location = new System.Drawing.Point(224, 118);
            this.Mid3.Name = "Mid3";
            this.Mid3.Size = new System.Drawing.Size(100, 100);
            this.Mid3.TabIndex = 5;
            this.Mid3.UseVisualStyleBackColor = true;
            this.Mid3.Click += new System.EventHandler(this.Mid3_Click);
            // 
            // Bot1
            // 
            this.Bot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bot1.Location = new System.Drawing.Point(12, 224);
            this.Bot1.Name = "Bot1";
            this.Bot1.Size = new System.Drawing.Size(100, 100);
            this.Bot1.TabIndex = 6;
            this.Bot1.UseVisualStyleBackColor = true;
            this.Bot1.Click += new System.EventHandler(this.Bot1_Click);
            // 
            // Bot2
            // 
            this.Bot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bot2.Location = new System.Drawing.Point(118, 224);
            this.Bot2.Name = "Bot2";
            this.Bot2.Size = new System.Drawing.Size(100, 100);
            this.Bot2.TabIndex = 7;
            this.Bot2.UseVisualStyleBackColor = true;
            this.Bot2.Click += new System.EventHandler(this.Bot2_Click);
            // 
            // Bot3
            // 
            this.Bot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bot3.Location = new System.Drawing.Point(224, 224);
            this.Bot3.Name = "Bot3";
            this.Bot3.Size = new System.Drawing.Size(100, 100);
            this.Bot3.TabIndex = 8;
            this.Bot3.UseVisualStyleBackColor = true;
            this.Bot3.Click += new System.EventHandler(this.Bot3_Click_1);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 338);
            this.Controls.Add(this.Bot3);
            this.Controls.Add(this.Bot2);
            this.Controls.Add(this.Bot1);
            this.Controls.Add(this.Mid3);
            this.Controls.Add(this.Mid2);
            this.Controls.Add(this.Mid1);
            this.Controls.Add(this.Top3);
            this.Controls.Add(this.Top2);
            this.Controls.Add(this.Top1);
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Top1;
        private System.Windows.Forms.Button Top2;
        private System.Windows.Forms.Button Top3;
        private System.Windows.Forms.Button Mid1;
        private System.Windows.Forms.Button Mid2;
        private System.Windows.Forms.Button Mid3;
        private System.Windows.Forms.Button Bot1;
        private System.Windows.Forms.Button Bot2;
        private System.Windows.Forms.Button Bot3;
    }
}

