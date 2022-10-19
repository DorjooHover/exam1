using System.Drawing;

namespace exam1
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list = new System.Windows.Forms.ListBox();
            this.delete = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.remove);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.product);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.unit);
            this.groupBox1.Controls.Add(this.Label);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(173, 123);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(120, 95);
            this.list.TabIndex = 7;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Cyan;
            this.delete.Location = new System.Drawing.Point(23, 181);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 6;
            this.delete.Text = "Устгах";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.Red;
            this.remove.Location = new System.Drawing.Point(23, 152);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 5;
            this.remove.Text = "Хасах";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Yellow;
            this.add.Location = new System.Drawing.Point(23, 123);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 4;
            this.add.Text = "Нэмэх";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(173, 81);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(112, 20);
            this.product.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Бүтээгдэхүүн";
            // 
            // unit
            // 
            this.unit.Location = new System.Drawing.Point(244, 36);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(41, 20);
            this.unit.TabIndex = 1;
            this.unit.Text = "6";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(20, 36);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(218, 13);
            this.Label.TabIndex = 0;
            this.Label.Text = "Сагсанд байх бүтээгдэхүүний тоо хэмжээ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(378, 294);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unit;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button add;
    }
}