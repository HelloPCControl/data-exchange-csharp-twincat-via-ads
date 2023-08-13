
namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIntVar = new System.Windows.Forms.TextBox();
            this.textBoxArrayVar = new System.Windows.Forms.TextBox();
            this.textBoxStrVar = new System.Windows.Forms.TextBox();
            this.VariableGroup = new System.Windows.Forms.GroupBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.VariableGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Integer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Array";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "String";
            // 
            // textBoxIntVar
            // 
            this.textBoxIntVar.Location = new System.Drawing.Point(85, 25);
            this.textBoxIntVar.Name = "textBoxIntVar";
            this.textBoxIntVar.Size = new System.Drawing.Size(190, 20);
            this.textBoxIntVar.TabIndex = 3;
            // 
            // textBoxArrayVar
            // 
            this.textBoxArrayVar.Location = new System.Drawing.Point(85, 62);
            this.textBoxArrayVar.Name = "textBoxArrayVar";
            this.textBoxArrayVar.Size = new System.Drawing.Size(190, 20);
            this.textBoxArrayVar.TabIndex = 4;
            // 
            // textBoxStrVar
            // 
            this.textBoxStrVar.Location = new System.Drawing.Point(85, 97);
            this.textBoxStrVar.Name = "textBoxStrVar";
            this.textBoxStrVar.Size = new System.Drawing.Size(190, 20);
            this.textBoxStrVar.TabIndex = 5;
            // 
            // VariableGroup
            // 
            this.VariableGroup.Controls.Add(this.textBoxStrVar);
            this.VariableGroup.Controls.Add(this.textBoxArrayVar);
            this.VariableGroup.Controls.Add(this.textBoxIntVar);
            this.VariableGroup.Controls.Add(this.label3);
            this.VariableGroup.Controls.Add(this.label2);
            this.VariableGroup.Controls.Add(this.label1);
            this.VariableGroup.Location = new System.Drawing.Point(62, 40);
            this.VariableGroup.Name = "VariableGroup";
            this.VariableGroup.Size = new System.Drawing.Size(308, 136);
            this.VariableGroup.TabIndex = 6;
            this.VariableGroup.TabStop = false;
            this.VariableGroup.Text = "Variable";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(125, 208);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(71, 22);
            this.buttonRead.TabIndex = 7;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(238, 208);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(71, 22);
            this.buttonWrite.TabIndex = 8;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 273);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.VariableGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VariableGroup.ResumeLayout(false);
            this.VariableGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIntVar;
        private System.Windows.Forms.TextBox textBoxArrayVar;
        private System.Windows.Forms.TextBox textBoxStrVar;
        private System.Windows.Forms.GroupBox VariableGroup;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonWrite;
    }
}

