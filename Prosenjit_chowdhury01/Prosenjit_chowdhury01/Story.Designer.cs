namespace Prosenjit_chowdhury01
{
    partial class Story
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Story));
            this.lblmodule = new System.Windows.Forms.Label();
            this.cmbshow = new System.Windows.Forms.ComboBox();
            this.lblstorytitle = new System.Windows.Forms.Label();
            this.lblshowstory = new System.Windows.Forms.Label();
            this.btnshowquestion = new System.Windows.Forms.Button();
            this.grpmain = new System.Windows.Forms.GroupBox();
            this.btnshowans = new System.Windows.Forms.Button();
            this.lstshow = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.grpmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmodule
            // 
            this.lblmodule.BackColor = System.Drawing.Color.Transparent;
            this.lblmodule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodule.ForeColor = System.Drawing.Color.Yellow;
            this.lblmodule.Location = new System.Drawing.Point(20, 13);
            this.lblmodule.Name = "lblmodule";
            this.lblmodule.Size = new System.Drawing.Size(218, 20);
            this.lblmodule.TabIndex = 0;
            this.lblmodule.Text = "Select Like Module";
            // 
            // cmbshow
            // 
            this.cmbshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbshow.FormattingEnabled = true;
            this.cmbshow.Location = new System.Drawing.Point(25, 43);
            this.cmbshow.Name = "cmbshow";
            this.cmbshow.Size = new System.Drawing.Size(147, 21);
            this.cmbshow.TabIndex = 1;
            this.cmbshow.SelectedIndexChanged += new System.EventHandler(this.cmbshow_SelectedIndexChanged);
            // 
            // lblstorytitle
            // 
            this.lblstorytitle.BackColor = System.Drawing.Color.Transparent;
            this.lblstorytitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstorytitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblstorytitle.Location = new System.Drawing.Point(20, 69);
            this.lblstorytitle.Name = "lblstorytitle";
            this.lblstorytitle.Size = new System.Drawing.Size(89, 25);
            this.lblstorytitle.TabIndex = 2;
            this.lblstorytitle.Text = "Story";
            // 
            // lblshowstory
            // 
            this.lblshowstory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblshowstory.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowstory.Location = new System.Drawing.Point(22, 105);
            this.lblshowstory.Name = "lblshowstory";
            this.lblshowstory.Size = new System.Drawing.Size(342, 304);
            this.lblshowstory.TabIndex = 3;
            this.lblshowstory.Click += new System.EventHandler(this.lblshowstory_Click);
            // 
            // btnshowquestion
            // 
            this.btnshowquestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnshowquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowquestion.Location = new System.Drawing.Point(88, 419);
            this.btnshowquestion.Name = "btnshowquestion";
            this.btnshowquestion.Size = new System.Drawing.Size(210, 45);
            this.btnshowquestion.TabIndex = 4;
            this.btnshowquestion.Text = "Show Related Question";
            this.btnshowquestion.UseVisualStyleBackColor = false;
            this.btnshowquestion.Click += new System.EventHandler(this.btnshowquestion_Click);
            // 
            // grpmain
            // 
            this.grpmain.BackColor = System.Drawing.Color.Transparent;
            this.grpmain.Controls.Add(this.btnshowans);
            this.grpmain.Controls.Add(this.lstshow);
            this.grpmain.Controls.Add(this.label4);
            this.grpmain.Location = new System.Drawing.Point(388, 12);
            this.grpmain.Name = "grpmain";
            this.grpmain.Size = new System.Drawing.Size(241, 369);
            this.grpmain.TabIndex = 5;
            this.grpmain.TabStop = false;
            // 
            // btnshowans
            // 
            this.btnshowans.BackColor = System.Drawing.Color.Yellow;
            this.btnshowans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnshowans.Location = new System.Drawing.Point(52, 310);
            this.btnshowans.Name = "btnshowans";
            this.btnshowans.Size = new System.Drawing.Size(116, 36);
            this.btnshowans.TabIndex = 2;
            this.btnshowans.Text = "Show Ans";
            this.btnshowans.UseVisualStyleBackColor = false;
            this.btnshowans.Click += new System.EventHandler(this.btnshowans_Click);
            // 
            // lstshow
            // 
            this.lstshow.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstshow.FormattingEnabled = true;
            this.lstshow.ItemHeight = 15;
            this.lstshow.Location = new System.Drawing.Point(8, 35);
            this.lstshow.Name = "lstshow";
            this.lstshow.Size = new System.Drawing.Size(218, 259);
            this.lstshow.TabIndex = 1;
            this.lstshow.SelectedIndexChanged += new System.EventHandler(this.lstshow_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = " Your Options";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Cyan;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(440, 397);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(126, 40);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save Game";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Story
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.grpmain);
            this.Controls.Add(this.btnshowquestion);
            this.Controls.Add(this.lblshowstory);
            this.Controls.Add(this.lblstorytitle);
            this.Controls.Add(this.cmbshow);
            this.Controls.Add(this.lblmodule);
            this.Name = "Story";
            this.Text = "StoryCollection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Story_FormClosing);
            this.Load += new System.EventHandler(this.Story_Load);
            this.grpmain.ResumeLayout(false);
            this.grpmain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblmodule;
        private System.Windows.Forms.ComboBox cmbshow;
        private System.Windows.Forms.Label lblstorytitle;
        private System.Windows.Forms.Label lblshowstory;
        private System.Windows.Forms.Button btnshowquestion;
        private System.Windows.Forms.GroupBox grpmain;
        private System.Windows.Forms.Button btnshowans;
        private System.Windows.Forms.ListBox lstshow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsave;
    }
}

