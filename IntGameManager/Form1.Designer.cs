﻿namespace IntGameManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddTopic = new System.Windows.Forms.Button();
            this.AddQuestion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сomplexity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTopic
            // 
            this.AddTopic.Location = new System.Drawing.Point(32, 31);
            this.AddTopic.Name = "AddTopic";
            this.AddTopic.Size = new System.Drawing.Size(136, 33);
            this.AddTopic.TabIndex = 0;
            this.AddTopic.Text = "Добавить тему";
            this.AddTopic.UseVisualStyleBackColor = true;
            this.AddTopic.Click += new System.EventHandler(this.AddTopic_Click);
            // 
            // AddQuestion
            // 
            this.AddQuestion.Location = new System.Drawing.Point(195, 33);
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.Size = new System.Drawing.Size(138, 31);
            this.AddQuestion.TabIndex = 1;
            this.AddQuestion.Text = "Добавить вопрос";
            this.AddQuestion.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Topic,
            this.Сomplexity,
            this.Question});
            this.dataGridView1.Location = new System.Drawing.Point(32, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(397, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Topic
            // 
            this.Topic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Topic.FillWeight = 40F;
            this.Topic.HeaderText = "Тема";
            this.Topic.MinimumWidth = 6;
            this.Topic.Name = "Topic";
            // 
            // Сomplexity
            // 
            this.Сomplexity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Сomplexity.HeaderText = "Сложность";
            this.Сomplexity.MinimumWidth = 6;
            this.Сomplexity.Name = "Сomplexity";
            this.Сomplexity.Width = 108;
            // 
            // Question
            // 
            this.Question.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Question.DefaultCellStyle = dataGridViewCellStyle2;
            this.Question.FillWeight = 60F;
            this.Question.HeaderText = "Вопрос";
            this.Question.MinimumWidth = 6;
            this.Question.Name = "Question";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 297);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddQuestion);
            this.Controls.Add(this.AddTopic);
            this.Name = "Form1";
            this.Text = "Редактор вопросов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddTopic;
        private System.Windows.Forms.Button AddQuestion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сomplexity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
    }
}

