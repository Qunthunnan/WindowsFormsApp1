
namespace WindowsFormsApp1
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
            this.CoordsLabel = new System.Windows.Forms.Label();
            this.rectangle = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CoordsLabel
            // 
            this.CoordsLabel.AutoSize = true;
            this.CoordsLabel.Location = new System.Drawing.Point(13, 13);
            this.CoordsLabel.Name = "CoordsLabel";
            this.CoordsLabel.Size = new System.Drawing.Size(0, 13);
            this.CoordsLabel.TabIndex = 0;
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(12, 12);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(388, 341);
            this.rectangle.TabIndex = 1;
            this.rectangle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rectangle_MouseClick);
            this.rectangle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rectangle_MouseMove);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(412, 365);
            this.Controls.Add(this.rectangle);
            this.Controls.Add(this.CoordsLabel);
            this.Name = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label CoordsLabel;
        private System.Windows.Forms.Panel rectangle;

        #endregion

        //private System.Windows.Forms.Button helpButton;
        //private System.Windows.Forms.Label resultLabel;
    }
}

