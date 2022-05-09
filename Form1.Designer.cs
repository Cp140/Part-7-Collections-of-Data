namespace Part_7__Collections_of_Data
{
    partial class frm
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
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnHerosAdd = new System.Windows.Forms.Button();
            this.btnHerosRemove = new System.Windows.Forms.Button();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblHeros = new System.Windows.Forms.Label();
            this.lblHerosText = new System.Windows.Forms.Label();
            this.lblNumbersText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblHeroestext = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstHeros
            // 
            this.lstHeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHeros.FormattingEnabled = true;
            this.lstHeros.ItemHeight = 20;
            this.lstHeros.Location = new System.Drawing.Point(280, 99);
            this.lstHeros.Name = "lstHeros";
            this.lstHeros.Size = new System.Drawing.Size(196, 164);
            this.lstHeros.TabIndex = 0;
            // 
            // lstNumbers
            // 
            this.lstNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 20;
            this.lstNumbers.Location = new System.Drawing.Point(34, 99);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(196, 164);
            this.lstNumbers.TabIndex = 1;
            // 
            // btnHerosNewList
            // 
            this.btnHerosNewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerosNewList.Location = new System.Drawing.Point(280, 54);
            this.btnHerosNewList.Name = "btnHerosNewList";
            this.btnHerosNewList.Size = new System.Drawing.Size(88, 29);
            this.btnHerosNewList.TabIndex = 2;
            this.btnHerosNewList.Text = "New List";
            this.btnHerosNewList.UseVisualStyleBackColor = true;
            // 
            // btnNumbersSort
            // 
            this.btnNumbersSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumbersSort.Location = new System.Drawing.Point(142, 58);
            this.btnNumbersSort.Name = "btnNumbersSort";
            this.btnNumbersSort.Size = new System.Drawing.Size(88, 29);
            this.btnNumbersSort.TabIndex = 3;
            this.btnNumbersSort.Text = "Sort";
            this.btnNumbersSort.UseVisualStyleBackColor = true;
            this.btnNumbersSort.Click += new System.EventHandler(this.btnNumbersSort_Click);
            // 
            // btnNumbersNewList
            // 
            this.btnNumbersNewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumbersNewList.Location = new System.Drawing.Point(34, 58);
            this.btnNumbersNewList.Name = "btnNumbersNewList";
            this.btnNumbersNewList.Size = new System.Drawing.Size(88, 29);
            this.btnNumbersNewList.TabIndex = 4;
            this.btnNumbersNewList.Text = "New List";
            this.btnNumbersNewList.UseVisualStyleBackColor = true;
            this.btnNumbersNewList.Click += new System.EventHandler(this.btnNumbersNewList_Click);
            // 
            // btnHerosSort
            // 
            this.btnHerosSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerosSort.Location = new System.Drawing.Point(388, 54);
            this.btnHerosSort.Name = "btnHerosSort";
            this.btnHerosSort.Size = new System.Drawing.Size(88, 29);
            this.btnHerosSort.TabIndex = 5;
            this.btnHerosSort.Text = "sort";
            this.btnHerosSort.UseVisualStyleBackColor = true;
            // 
            // btnNumbersRemove
            // 
            this.btnNumbersRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumbersRemove.Location = new System.Drawing.Point(34, 296);
            this.btnNumbersRemove.Name = "btnNumbersRemove";
            this.btnNumbersRemove.Size = new System.Drawing.Size(83, 57);
            this.btnNumbersRemove.TabIndex = 7;
            this.btnNumbersRemove.Text = "Remove";
            this.btnNumbersRemove.UseVisualStyleBackColor = true;
            this.btnNumbersRemove.Click += new System.EventHandler(this.btnNumbersRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.Location = new System.Drawing.Point(123, 296);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(83, 57);
            this.btnRemoveAll.TabIndex = 6;
            this.btnRemoveAll.Text = "Remove\r\nAll";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnHerosAdd
            // 
            this.btnHerosAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerosAdd.Location = new System.Drawing.Point(381, 296);
            this.btnHerosAdd.Name = "btnHerosAdd";
            this.btnHerosAdd.Size = new System.Drawing.Size(75, 29);
            this.btnHerosAdd.TabIndex = 9;
            this.btnHerosAdd.Text = "Add";
            this.btnHerosAdd.UseVisualStyleBackColor = true;
            // 
            // btnHerosRemove
            // 
            this.btnHerosRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerosRemove.Location = new System.Drawing.Point(381, 358);
            this.btnHerosRemove.Name = "btnHerosRemove";
            this.btnHerosRemove.Size = new System.Drawing.Size(84, 29);
            this.btnHerosRemove.TabIndex = 8;
            this.btnHerosRemove.Text = "Remove";
            this.btnHerosRemove.UseVisualStyleBackColor = true;
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(31, 27);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(88, 24);
            this.lblNumbers.TabIndex = 10;
            this.lblNumbers.Text = "Numbers";
            // 
            // lblHeros
            // 
            this.lblHeros.AutoSize = true;
            this.lblHeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeros.Location = new System.Drawing.Point(286, 27);
            this.lblHeros.Name = "lblHeros";
            this.lblHeros.Size = new System.Drawing.Size(61, 24);
            this.lblHeros.TabIndex = 11;
            this.lblHeros.Text = "Heros";
            // 
            // lblHerosText
            // 
            this.lblHerosText.AutoSize = true;
            this.lblHerosText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerosText.Location = new System.Drawing.Point(286, 269);
            this.lblHerosText.Name = "lblHerosText";
            this.lblHerosText.Size = new System.Drawing.Size(190, 20);
            this.lblHerosText.TabIndex = 12;
            this.lblHerosText.Text = "Enter a hero name to add";
            // 
            // lblNumbersText
            // 
            this.lblNumbersText.AutoSize = true;
            this.lblNumbersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbersText.Location = new System.Drawing.Point(31, 269);
            this.lblNumbersText.Name = "lblNumbersText";
            this.lblNumbersText.Size = new System.Drawing.Size(199, 20);
            this.lblNumbersText.TabIndex = 13;
            this.lblNumbersText.Text = "Select a number to remove";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(275, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(275, 358);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 15;
            // 
            // lblHeroestext
            // 
            this.lblHeroestext.AutoSize = true;
            this.lblHeroestext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroestext.Location = new System.Drawing.Point(272, 333);
            this.lblHeroestext.Name = "lblHeroestext";
            this.lblHeroestext.Size = new System.Drawing.Size(215, 20);
            this.lblHeroestext.TabIndex = 16;
            this.lblHeroestext.Text = "Enter a hero name to remove";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(30, 382);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(381, 409);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 29);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHeroestext);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNumbersText);
            this.Controls.Add(this.lblHerosText);
            this.Controls.Add(this.lblHeros);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.btnHerosAdd);
            this.Controls.Add(this.btnHerosRemove);
            this.Controls.Add(this.btnNumbersRemove);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnHerosSort);
            this.Controls.Add(this.btnNumbersNewList);
            this.Controls.Add(this.btnNumbersSort);
            this.Controls.Add(this.btnHerosNewList);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.lstHeros);
            this.Name = "frm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Load);
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
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnHerosAdd;
        private System.Windows.Forms.Button btnHerosRemove;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblHeros;
        private System.Windows.Forms.Label lblHerosText;
        private System.Windows.Forms.Label lblNumbersText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblHeroestext;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnReset;
    }
}

