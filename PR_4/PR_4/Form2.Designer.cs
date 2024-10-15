namespace PR_4
{
    partial class Form2
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
            this.MainText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkST = new System.Windows.Forms.LinkLabel();
            this.back = new System.Windows.Forms.Button();
            this.pictureBobobo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBobobo)).BeginInit();
            this.SuspendLayout();
            // 
            // MainText
            // 
            this.MainText.AutoSize = true;
            this.MainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainText.Location = new System.Drawing.Point(37, 9);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(288, 31);
            this.MainText.TabIndex = 24;
            this.MainText.Text = "Справка программы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Разработал: Филиппов А.С.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Специальность: Информационные системы и программирование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Контакт:";
            // 
            // linkST
            // 
            this.linkST.AutoSize = true;
            this.linkST.Location = new System.Drawing.Point(61, 119);
            this.linkST.Name = "linkST";
            this.linkST.Size = new System.Drawing.Size(294, 13);
            this.linkST.TabIndex = 28;
            this.linkST.TabStop = true;
            this.linkST.Text = "https://steamcommunity.com/profiles/76561198802886757/";
            this.linkST.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkST_LinkClicked);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(138, 185);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(98, 32);
            this.back.TabIndex = 29;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBobobo
            // 
            this.pictureBobobo.Image = global::PR_4.Properties.Resources.e10badda3991460a8dcde354a71e22c3_6979984572906176809;
            this.pictureBobobo.Location = new System.Drawing.Point(255, 154);
            this.pictureBobobo.Name = "pictureBobobo";
            this.pictureBobobo.Size = new System.Drawing.Size(100, 101);
            this.pictureBobobo.TabIndex = 30;
            this.pictureBobobo.TabStop = false;
            this.pictureBobobo.Click += new System.EventHandler(this.pictureBobobo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(367, 267);
            this.Controls.Add(this.pictureBobobo);
            this.Controls.Add(this.back);
            this.Controls.Add(this.linkST);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MainText);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBobobo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkST;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox pictureBobobo;
    }
}