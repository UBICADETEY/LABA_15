
namespace LabRab15
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
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.btnChooseFont = new System.Windows.Forms.Button();
            this.panelChooseColor = new System.Windows.Forms.Panel();
            this.btnChooseFC = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtTerms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseColor.Location = new System.Drawing.Point(35, 40);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(157, 26);
            this.btnChooseColor.TabIndex = 0;
            this.btnChooseColor.Text = "Choose Color";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // btnChooseFont
            // 
            this.btnChooseFont.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseFont.Location = new System.Drawing.Point(35, 72);
            this.btnChooseFont.Name = "btnChooseFont";
            this.btnChooseFont.Size = new System.Drawing.Size(157, 27);
            this.btnChooseFont.TabIndex = 1;
            this.btnChooseFont.Text = "Choose Font";
            this.btnChooseFont.UseVisualStyleBackColor = true;
            this.btnChooseFont.Click += new System.EventHandler(this.btnChooseFont_Click);
            // 
            // panelChooseColor
            // 
            this.panelChooseColor.Location = new System.Drawing.Point(230, 40);
            this.panelChooseColor.Name = "panelChooseColor";
            this.panelChooseColor.Size = new System.Drawing.Size(190, 26);
            this.panelChooseColor.TabIndex = 2;
            // 
            // btnChooseFC
            // 
            this.btnChooseFC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseFC.Location = new System.Drawing.Point(35, 105);
            this.btnChooseFC.Name = "btnChooseFC";
            this.btnChooseFC.Size = new System.Drawing.Size(157, 28);
            this.btnChooseFC.TabIndex = 4;
            this.btnChooseFC.Text = "Choose Font Color";
            this.btnChooseFC.UseVisualStyleBackColor = true;
            this.btnChooseFC.Click += new System.EventHandler(this.btnChooseFC_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalc.Location = new System.Drawing.Point(230, 218);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(190, 79);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtTerms
            // 
            this.txtTerms.Location = new System.Drawing.Point(230, 149);
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.Size = new System.Drawing.Size(190, 20);
            this.txtTerms.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter the number of terms";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(230, 192);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(190, 20);
            this.txtAnswer.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Answer";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(92, 248);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 309);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTerms);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnChooseFC);
            this.Controls.Add(this.panelChooseColor);
            this.Controls.Add(this.btnChooseFont);
            this.Controls.Add(this.btnChooseColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Button btnChooseFont;
        private System.Windows.Forms.Panel panelChooseColor;
        private System.Windows.Forms.Button btnChooseFC;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtTerms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label3;
    }
}

