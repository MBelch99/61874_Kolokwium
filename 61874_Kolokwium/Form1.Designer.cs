
namespace _61874_Kolokwium
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoL = new System.Windows.Forms.RadioButton();
            this.rdoM = new System.Windows.Forms.RadioButton();
            this.rdoS = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbO = new System.Windows.Forms.CheckBox();
            this.chbP2 = new System.Windows.Forms.CheckBox();
            this.chbM = new System.Windows.Forms.CheckBox();
            this.chbS = new System.Windows.Forms.CheckBox();
            this.chbP1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOreder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoL);
            this.groupBox1.Controls.Add(this.rdoM);
            this.groupBox1.Controls.Add(this.rdoS);
            this.groupBox1.Location = new System.Drawing.Point(39, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Size";
            // 
            // rdoL
            // 
            this.rdoL.AutoSize = true;
            this.rdoL.Location = new System.Drawing.Point(13, 76);
            this.rdoL.Name = "rdoL";
            this.rdoL.Size = new System.Drawing.Size(54, 19);
            this.rdoL.TabIndex = 2;
            this.rdoL.TabStop = true;
            this.rdoL.Text = "Large";
            this.rdoL.UseVisualStyleBackColor = true;
            // 
            // rdoM
            // 
            this.rdoM.AutoSize = true;
            this.rdoM.Location = new System.Drawing.Point(13, 51);
            this.rdoM.Name = "rdoM";
            this.rdoM.Size = new System.Drawing.Size(70, 19);
            this.rdoM.TabIndex = 1;
            this.rdoM.TabStop = true;
            this.rdoM.Text = "Medium";
            this.rdoM.UseVisualStyleBackColor = true;
            // 
            // rdoS
            // 
            this.rdoS.AutoSize = true;
            this.rdoS.Checked = true;
            this.rdoS.Location = new System.Drawing.Point(13, 26);
            this.rdoS.Name = "rdoS";
            this.rdoS.Size = new System.Drawing.Size(54, 19);
            this.rdoS.TabIndex = 0;
            this.rdoS.TabStop = true;
            this.rdoS.Text = "Small";
            this.rdoS.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbO);
            this.groupBox2.Controls.Add(this.chbP2);
            this.groupBox2.Controls.Add(this.chbM);
            this.groupBox2.Controls.Add(this.chbS);
            this.groupBox2.Controls.Add(this.chbP1);
            this.groupBox2.Location = new System.Drawing.Point(180, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toppings";
            // 
            // chbO
            // 
            this.chbO.AutoSize = true;
            this.chbO.Location = new System.Drawing.Point(11, 126);
            this.chbO.Name = "chbO";
            this.chbO.Size = new System.Drawing.Size(58, 19);
            this.chbO.TabIndex = 4;
            this.chbO.Text = "Olives";
            this.chbO.UseVisualStyleBackColor = true;
            // 
            // chbP2
            // 
            this.chbP2.AutoSize = true;
            this.chbP2.Location = new System.Drawing.Point(11, 101);
            this.chbP2.Name = "chbP2";
            this.chbP2.Size = new System.Drawing.Size(68, 19);
            this.chbP2.TabIndex = 3;
            this.chbP2.Text = "Peppers";
            this.chbP2.UseVisualStyleBackColor = true;
            // 
            // chbM
            // 
            this.chbM.AutoSize = true;
            this.chbM.Location = new System.Drawing.Point(11, 76);
            this.chbM.Name = "chbM";
            this.chbM.Size = new System.Drawing.Size(90, 19);
            this.chbM.TabIndex = 2;
            this.chbM.Text = "Mushrooms";
            this.chbM.UseVisualStyleBackColor = true;
            // 
            // chbS
            // 
            this.chbS.AutoSize = true;
            this.chbS.Location = new System.Drawing.Point(11, 51);
            this.chbS.Name = "chbS";
            this.chbS.Size = new System.Drawing.Size(69, 19);
            this.chbS.TabIndex = 1;
            this.chbS.Text = "Sausage";
            this.chbS.UseVisualStyleBackColor = true;
            // 
            // chbP1
            // 
            this.chbP1.AutoSize = true;
            this.chbP1.Location = new System.Drawing.Point(11, 26);
            this.chbP1.Name = "chbP1";
            this.chbP1.Size = new System.Drawing.Size(80, 19);
            this.chbP1.TabIndex = 0;
            this.chbP1.Text = "Pepperoni";
            this.chbP1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(321, 64);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(136, 23);
            this.tbName.TabIndex = 3;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(321, 123);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(136, 23);
            this.tbNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Pizzas";
            // 
            // tbOreder
            // 
            this.tbOreder.Location = new System.Drawing.Point(478, 64);
            this.tbOreder.Multiline = true;
            this.tbOreder.Name = "tbOreder";
            this.tbOreder.Size = new System.Drawing.Size(136, 240);
            this.tbOreder.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pizza Order";
            // 
            // btnRec
            // 
            this.btnRec.Location = new System.Drawing.Point(322, 211);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(135, 25);
            this.btnRec.TabIndex = 8;
            this.btnRec.Text = "Record Transaction";
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // btnCom
            // 
            this.btnCom.Location = new System.Drawing.Point(478, 327);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(135, 25);
            this.btnCom.TabIndex = 9;
            this.btnCom.Text = "Complete Transaction";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 503);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.btnRec);
            this.Controls.Add(this.tbOreder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoL;
        private System.Windows.Forms.RadioButton rdoM;
        private System.Windows.Forms.RadioButton rdoS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbO;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox chbM;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOreder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.CheckBox chbS;
        private System.Windows.Forms.CheckBox chbP1;
        private System.Windows.Forms.CheckBox chbP2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btnRec;
    }
}

