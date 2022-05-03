namespace Part_7__Collections_of_Data
{
    partial class Form1
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
            this.lstHeros = new System.Windows.Forms.ListBox();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.btnHerosNewList = new System.Windows.Forms.Button();
            this.btnNumbersSort = new System.Windows.Forms.Button();
            this.btnNumbersNewList = new System.Windows.Forms.Button();
            this.btnHerosSort = new System.Windows.Forms.Button();
            this.btnNumbersRemove = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblHeros = new System.Windows.Forms.Label();
            this.lblHerostext = new System.Windows.Forms.Label();
            this.lblNumbersText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstHeros
            // 
            this.lstHeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHeros.FormattingEnabled = true;
            this.lstHeros.ItemHeight = 16;
            this.lstHeros.Location = new System.Drawing.Point(289, 99);
            this.lstHeros.Name = "lstHeros";
            this.lstHeros.Size = new System.Drawing.Size(156, 132);
            this.lstHeros.TabIndex = 0;
            // 
            // lstNumbers
            // 
            this.lstNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 16;
            this.lstNumbers.Location = new System.Drawing.Point(34, 99);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(156, 132);
            this.lstNumbers.TabIndex = 1;
            // 
            // btnHerosNewList
            // 
            this.btnHerosNewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerosNewList.Location = new System.Drawing.Point(289, 58);
            this.btnHerosNewList.Name = "btnHerosNewList";
            this.btnHerosNewList.Size = new System.Drawing.Size(75, 29);
            this.btnHerosNewList.TabIndex = 2;
            this.btnHerosNewList.Text = "New List";
            this.btnHerosNewList.UseVisualStyleBackColor = true;
            this.btnHerosNewList.Click += new System.EventHandler(this.btnHerosNewList_Click);
            // 
            // btnNumbersSort
            // 
            this.btnNumbersSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumbersSort.Location = new System.Drawing.Point(115, 58);
            this.btnNumbersSort.Name = "btnNumbersSort";
            this.btnNumbersSort.Size = new System.Drawing.Size(75, 29);
            this.btnNumbersSort.TabIndex = 3;
            this.btnNumbersSort.Text = "Sort";
            this.btnNumbersSort.UseVisualStyleBackColor = true;
            this.btnNumbersSort.Click += new System.EventHandler(this.btnNumbersSort_Click);
            // 
            // btnNumbersNewList
            // 
            this.btnNumbersNewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumbersNewList.Location = new System.Drawing.Point(34, 58);
            this.btnNumbersNewList.Name = "btnNumbersNewList";
            this.btnNumbersNewList.Size = new System.Drawing.Size(75, 29);
            this.btnNumbersNewList.TabIndex = 4;
            this.btnNumbersNewList.Text = "New List";
            this.btnNumbersNewList.UseVisualStyleBackColor = true;
            this.btnNumbersNewList.Click += new System.EventHandler(this.btnNumbersNewList_Click);
            // 
            // btnHerosSort
            // 
            this.btnHerosSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerosSort.Location = new System.Drawing.Point(370, 58);
            this.btnHerosSort.Name = "btnHerosSort";
            this.btnHerosSort.Size = new System.Drawing.Size(75, 29);
            this.btnHerosSort.TabIndex = 5;
            this.btnHerosSort.Text = "sort";
            this.btnHerosSort.UseVisualStyleBackColor = true;
            this.btnHerosSort.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnNumbersRemove
            // 
            this.btnNumbersRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumbersRemove.Location = new System.Drawing.Point(34, 270);
            this.btnNumbersRemove.Name = "btnNumbersRemove";
            this.btnNumbersRemove.Size = new System.Drawing.Size(75, 45);
            this.btnNumbersRemove.TabIndex = 7;
            this.btnNumbersRemove.Text = "Remove";
            this.btnNumbersRemove.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(115, 270);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 45);
            this.button6.TabIndex = 6;
            this.button6.Text = "Remove All";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(289, 270);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 31);
            this.button7.TabIndex = 9;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(370, 270);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 31);
            this.button8.TabIndex = 8;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(30, 27);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(88, 24);
            this.lblNumbers.TabIndex = 10;
            this.lblNumbers.Text = "Numbers";
            // 
            // lblHeros
            // 
            this.lblHeros.AutoSize = true;
            this.lblHeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeros.Location = new System.Drawing.Point(285, 27);
            this.lblHeros.Name = "lblHeros";
            this.lblHeros.Size = new System.Drawing.Size(61, 24);
            this.lblHeros.TabIndex = 11;
            this.lblHeros.Text = "Heros";
            // 
            // lblHerostext
            // 
            this.lblHerostext.AutoSize = true;
            this.lblHerostext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerostext.Location = new System.Drawing.Point(286, 243);
            this.lblHerostext.Name = "lblHerostext";
            this.lblHerostext.Size = new System.Drawing.Size(170, 17);
            this.lblHerostext.TabIndex = 12;
            this.lblHerostext.Text = "Enter a hero name to add";
            // 
            // lblNumbersText
            // 
            this.lblNumbersText.AutoSize = true;
            this.lblNumbersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbersText.Location = new System.Drawing.Point(31, 243);
            this.lblNumbersText.Name = "lblNumbersText";
            this.lblNumbersText.Size = new System.Drawing.Size(178, 17);
            this.lblNumbersText.TabIndex = 13;
            this.lblNumbersText.Text = "Select a number to remove";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumbersText);
            this.Controls.Add(this.lblHerostext);
            this.Controls.Add(this.lblHeros);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnNumbersRemove);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnHerosSort);
            this.Controls.Add(this.btnNumbersNewList);
            this.Controls.Add(this.btnNumbersSort);
            this.Controls.Add(this.btnHerosNewList);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.lstHeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHeros;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Button btnHerosNewList;
        private System.Windows.Forms.Button btnNumbersSort;
        private System.Windows.Forms.Button btnNumbersNewList;
        private System.Windows.Forms.Button btnHerosSort;
        private System.Windows.Forms.Button btnNumbersRemove;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblHeros;
        private System.Windows.Forms.Label lblHerostext;
        private System.Windows.Forms.Label lblNumbersText;
    }
}

