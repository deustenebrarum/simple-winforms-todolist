namespace TaskList
{
    partial class TaskListForm
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
            _tasksGridView = new DataGridView();
            _actionsMenu = new MenuStrip();
            _addActionMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)_tasksGridView).BeginInit();
            _actionsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // _tasksGridView
            // 
            _tasksGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _tasksGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _tasksGridView.Dock = DockStyle.Fill;
            _tasksGridView.Location = new Point(0, 24);
            _tasksGridView.Name = "_tasksGridView";
            _tasksGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            _tasksGridView.Size = new Size(1093, 605);
            _tasksGridView.TabIndex = 0;
            // 
            // _actionsMenu
            // 
            _actionsMenu.Items.AddRange(new ToolStripItem[] { _addActionMenuItem });
            _actionsMenu.Location = new Point(0, 0);
            _actionsMenu.Name = "_actionsMenu";
            _actionsMenu.Size = new Size(1093, 24);
            _actionsMenu.TabIndex = 1;
            _actionsMenu.Text = "menuStrip1";
            // 
            // _addActionMenuItem
            // 
            _addActionMenuItem.Name = "_addActionMenuItem";
            _addActionMenuItem.Size = new Size(71, 20);
            _addActionMenuItem.Text = "Добавить";
            _addActionMenuItem.Click += OnTaskAdd;
            // 
            // TaskListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 629);
            Controls.Add(_tasksGridView);
            Controls.Add(_actionsMenu);
            MainMenuStrip = _actionsMenu;
            Name = "TaskListForm";
            Text = "TaskListForm";
            ((System.ComponentModel.ISupportInitialize)_tasksGridView).EndInit();
            _actionsMenu.ResumeLayout(false);
            _actionsMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView _tasksGridView;
        private MenuStrip _actionsMenu;
        private ToolStripMenuItem _addActionMenuItem;
    }
}