namespace labirint
{
    partial class FormGame
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
            this.dataGridViewLabirint = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabirint)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLabirint
            // 
            this.dataGridViewLabirint.AllowUserToAddRows = false;
            this.dataGridViewLabirint.AllowUserToDeleteRows = false;
            this.dataGridViewLabirint.AllowUserToResizeColumns = false;
            this.dataGridViewLabirint.AllowUserToResizeRows = false;
            this.dataGridViewLabirint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLabirint.ColumnHeadersVisible = false;
            this.dataGridViewLabirint.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLabirint.Name = "dataGridViewLabirint";
            this.dataGridViewLabirint.RowHeadersVisible = false;
            this.dataGridViewLabirint.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewLabirint.TabIndex = 0;
            this.dataGridViewLabirint.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLabirint_CellClick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewLabirint);
            this.Name = "FormGame";
            this.Text = "Лабиринт уровень 1";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabirint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLabirint;
    }
}

