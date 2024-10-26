namespace PersonalDiaryWinforms
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
            panel1 = new Panel();
            searchTextBox = new TextBox();
            recordsListBox = new ListBox();
            panel2 = new Panel();
            tagsTextBox = new TextBox();
            previousButton = new Button();
            nextButton = new Button();
            changeButton = new Button();
            removeButton = new Button();
            addButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            descriptionTextBox = new TextBox();
            titleTextBox = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(recordsListBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 572);
            panel1.TabIndex = 0;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(0, 546);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(490, 23);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // recordsListBox
            // 
            recordsListBox.FormattingEnabled = true;
            recordsListBox.ItemHeight = 15;
            recordsListBox.Location = new Point(3, 3);
            recordsListBox.Name = "recordsListBox";
            recordsListBox.Size = new Size(487, 544);
            recordsListBox.TabIndex = 0;
            recordsListBox.SelectedIndexChanged += recordsListBox_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tagsTextBox);
            panel2.Controls.Add(previousButton);
            panel2.Controls.Add(nextButton);
            panel2.Controls.Add(changeButton);
            panel2.Controls.Add(removeButton);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(descriptionTextBox);
            panel2.Controls.Add(titleTextBox);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(489, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 572);
            panel2.TabIndex = 1;
            // 
            // tagsTextBox
            // 
            tagsTextBox.Location = new Point(0, 440);
            tagsTextBox.Name = "tagsTextBox";
            tagsTextBox.PlaceholderText = "Введите теги";
            tagsTextBox.Size = new Size(383, 23);
            tagsTextBox.TabIndex = 8;
            // 
            // previousButton
            // 
            previousButton.Location = new Point(213, 501);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(170, 59);
            previousButton.TabIndex = 7;
            previousButton.Text = "Следующая";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(7, 501);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(170, 59);
            nextButton.TabIndex = 6;
            nextButton.Text = "Следующая";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // changeButton
            // 
            changeButton.Location = new Point(389, 142);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(136, 59);
            changeButton.TabIndex = 5;
            changeButton.Text = "Изменить";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(389, 77);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(136, 59);
            removeButton.TabIndex = 4;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(389, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(136, 59);
            addButton.TabIndex = 3;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(0, 469);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(383, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(0, 32);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Введите текст заметки";
            descriptionTextBox.Size = new Size(383, 402);
            descriptionTextBox.TabIndex = 1;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(0, 3);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.PlaceholderText = "Введите заголовок";
            titleTextBox.Size = new Size(383, 23);
            titleTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 572);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox searchTextBox;
        private ListBox recordsListBox;
        private Panel panel2;
        private Button removeButton;
        private Button addButton;
        private DateTimePicker dateTimePicker1;
        private TextBox descriptionTextBox;
        private TextBox titleTextBox;
        private Button changeButton;
        private Button previousButton;
        private Button nextButton;
        private TextBox tagsTextBox;
    }
}
