namespace крокодил
{
    partial class Form43
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form43));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnClearCart_Click = new System.Windows.Forms.Button();
            this.btnCheckout_Click = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LavenderBlush;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(497, 483);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 21);
            this.button4.TabIndex = 15;
            this.button4.Text = "Вернуться назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(564, 225);
            this.listBox1.TabIndex = 16;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(12, 388);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 15);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "label1";
            // 
            // tnRemoveFromCart
            // 
            this.tnRemoveFromCart.BackColor = System.Drawing.Color.Pink;
            this.tnRemoveFromCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tnRemoveFromCart.Location = new System.Drawing.Point(15, 340);
            this.tnRemoveFromCart.Name = "tnRemoveFromCart";
            this.tnRemoveFromCart.Size = new System.Drawing.Size(158, 21);
            this.tnRemoveFromCart.TabIndex = 18;
            this.tnRemoveFromCart.Text = "Удалить выбранный товар";
            this.tnRemoveFromCart.UseVisualStyleBackColor = false;
            this.tnRemoveFromCart.Click += new System.EventHandler(this.tnRemoveFromCart_Click);
            // 
            // btnClearCart_Click
            // 
            this.btnClearCart_Click.BackColor = System.Drawing.Color.Pink;
            this.btnClearCart_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCart_Click.Location = new System.Drawing.Point(421, 340);
            this.btnClearCart_Click.Name = "btnClearCart_Click";
            this.btnClearCart_Click.Size = new System.Drawing.Size(158, 21);
            this.btnClearCart_Click.TabIndex = 19;
            this.btnClearCart_Click.Text = "Очистить корзину";
            this.btnClearCart_Click.UseVisualStyleBackColor = false;
            this.btnClearCart_Click.Click += new System.EventHandler(this.btnClearCart_Click_Click);
            // 
            // btnCheckout_Click
            // 
            this.btnCheckout_Click.BackColor = System.Drawing.Color.Pink;
            this.btnCheckout_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout_Click.Location = new System.Drawing.Point(15, 425);
            this.btnCheckout_Click.Name = "btnCheckout_Click";
            this.btnCheckout_Click.Size = new System.Drawing.Size(158, 38);
            this.btnCheckout_Click.TabIndex = 20;
            this.btnCheckout_Click.Text = "Оплатить";
            this.btnCheckout_Click.UseVisualStyleBackColor = false;
            this.btnCheckout_Click.Click += new System.EventHandler(this.btnCheckout_Click_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "В вашей корзине:";
            // 
            // Form43
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(667, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheckout_Click);
            this.Controls.Add(this.btnClearCart_Click);
            this.Controls.Add(this.tnRemoveFromCart);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form43";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корзина";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button tnRemoveFromCart;
        private System.Windows.Forms.Button btnClearCart_Click;
        private System.Windows.Forms.Button btnCheckout_Click;
        private System.Windows.Forms.Label label2;
    }
}