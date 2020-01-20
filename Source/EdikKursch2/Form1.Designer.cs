namespace EdikKursch2
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.labelForw = new System.Windows.Forms.Label();
            this.PanelFirst = new System.Windows.Forms.Panel();
            this.PanelSecond = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBox2P = new System.Windows.Forms.TextBox();
            this.label2Forw = new System.Windows.Forms.Label();
            this.Button_2_Next = new System.Windows.Forms.Button();
            this.PanelFirst.SuspendLayout();
            this.PanelSecond.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(72, 93);
            this.maskedTextBox1.Mask = "+380000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(157, 29);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(201, 147);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(97, 49);
            this.ButtonNext.TabIndex = 1;
            this.ButtonNext.Text = "Далее";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LabelInfo
            // 
            this.LabelInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInfo.Location = new System.Drawing.Point(12, 9);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(283, 118);
            this.LabelInfo.TabIndex = 2;
            // 
            // labelForw
            // 
            this.labelForw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForw.Location = new System.Drawing.Point(38, 35);
            this.labelForw.Name = "labelForw";
            this.labelForw.Size = new System.Drawing.Size(229, 55);
            this.labelForw.TabIndex = 3;
            this.labelForw.Text = "Введите номер телефона";
            this.labelForw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelFirst
            // 
            this.PanelFirst.Controls.Add(this.labelForw);
            this.PanelFirst.Controls.Add(this.ButtonNext);
            this.PanelFirst.Controls.Add(this.maskedTextBox1);
            this.PanelFirst.Location = new System.Drawing.Point(15, 105);
            this.PanelFirst.Name = "PanelFirst";
            this.PanelFirst.Size = new System.Drawing.Size(323, 210);
            this.PanelFirst.TabIndex = 4;
            // 
            // PanelSecond
            // 
            this.PanelSecond.Controls.Add(this.buttonCancel);
            this.PanelSecond.Controls.Add(this.textBox2P);
            this.PanelSecond.Controls.Add(this.label2Forw);
            this.PanelSecond.Controls.Add(this.Button_2_Next);
            this.PanelSecond.Location = new System.Drawing.Point(15, 109);
            this.PanelSecond.Name = "PanelSecond";
            this.PanelSecond.Size = new System.Drawing.Size(323, 210);
            this.PanelSecond.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(16, 146);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 49);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // textBox2P
            // 
            this.textBox2P.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2P.Location = new System.Drawing.Point(112, 102);
            this.textBox2P.MaxLength = 4;
            this.textBox2P.Name = "textBox2P";
            this.textBox2P.Size = new System.Drawing.Size(100, 29);
            this.textBox2P.TabIndex = 4;
            this.textBox2P.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label2Forw
            // 
            this.label2Forw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2Forw.Location = new System.Drawing.Point(12, 9);
            this.label2Forw.Name = "label2Forw";
            this.label2Forw.Size = new System.Drawing.Size(289, 90);
            this.label2Forw.TabIndex = 3;
            this.label2Forw.Text = "Введите сумму пополнения (Не больше 1000 гривен за раз, комиссия 1%)";
            this.label2Forw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_2_Next
            // 
            this.Button_2_Next.Location = new System.Drawing.Point(204, 146);
            this.Button_2_Next.Name = "Button_2_Next";
            this.Button_2_Next.Size = new System.Drawing.Size(97, 49);
            this.Button_2_Next.TabIndex = 1;
            this.Button_2_Next.Text = "Далее";
            this.Button_2_Next.UseVisualStyleBackColor = true;
            this.Button_2_Next.Click += new System.EventHandler(this.Button_2_Next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(350, 331);
            this.Controls.Add(this.PanelSecond);
            this.Controls.Add(this.PanelFirst);
            this.Controls.Add(this.LabelInfo);
            this.Name = "Form1";
            this.Text = "Терминал пополнения счета";
            this.PanelFirst.ResumeLayout(false);
            this.PanelFirst.PerformLayout();
            this.PanelSecond.ResumeLayout(false);
            this.PanelSecond.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.Label labelForw;
        private System.Windows.Forms.Panel PanelFirst;
        private System.Windows.Forms.Panel PanelSecond;
        private System.Windows.Forms.Label label2Forw;
        private System.Windows.Forms.Button Button_2_Next;
        private System.Windows.Forms.TextBox textBox2P;
        private System.Windows.Forms.Button buttonCancel;
    }
}

