namespace IntGameManager
{
    partial class TopicForm
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
            this.Topic = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Topic
            // 
            this.Topic.Location = new System.Drawing.Point(12, 22);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(402, 22);
            this.Topic.TabIndex = 0;
            this.Topic.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(438, 18);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(96, 30);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Готово";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 68);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Topic);
            this.Name = "Form2";
            this.Text = "Добавление темы";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Topic;
        private System.Windows.Forms.Button Ok;
    }
}