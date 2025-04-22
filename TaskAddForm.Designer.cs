namespace TaskList
{
    partial class TaskAddForm
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
            _descriptionBox = new TextBox();
            _endTimePicker = new DateTimePicker();
            _createButton = new Button();
            _cancelButton = new Button();
            SuspendLayout();
            // 
            // _descriptionBox
            // 
            _descriptionBox.Location = new Point(12, 12);
            _descriptionBox.Multiline = true;
            _descriptionBox.Name = "_descriptionBox";
            _descriptionBox.Size = new Size(234, 67);
            _descriptionBox.TabIndex = 0;
            // 
            // _endTimePicker
            // 
            _endTimePicker.CustomFormat = "dd:MM:yyyy hh:mm:ss";
            _endTimePicker.Format = DateTimePickerFormat.Custom;
            _endTimePicker.Location = new Point(12, 85);
            _endTimePicker.Name = "_endTimePicker";
            _endTimePicker.Size = new Size(234, 23);
            _endTimePicker.TabIndex = 1;
            // 
            // _createButton
            // 
            _createButton.Location = new Point(12, 114);
            _createButton.Name = "_createButton";
            _createButton.Size = new Size(116, 23);
            _createButton.TabIndex = 2;
            _createButton.Text = "Добавить";
            _createButton.UseVisualStyleBackColor = true;
            _createButton.Click += OnCreate;
            // 
            // _cancelButton
            // 
            _cancelButton.Location = new Point(134, 114);
            _cancelButton.Name = "_cancelButton";
            _cancelButton.Size = new Size(112, 23);
            _cancelButton.TabIndex = 3;
            _cancelButton.Text = "Отмена";
            _cancelButton.UseVisualStyleBackColor = true;
            _cancelButton.Click += OnCancel;
            // 
            // TaskAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 152);
            Controls.Add(_cancelButton);
            Controls.Add(_createButton);
            Controls.Add(_endTimePicker);
            Controls.Add(_descriptionBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TaskAddForm";
            Text = "Добавить задачу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox _descriptionBox;
        private DateTimePicker _endTimePicker;
        private Button _createButton;
        private Button _cancelButton;
    }
}