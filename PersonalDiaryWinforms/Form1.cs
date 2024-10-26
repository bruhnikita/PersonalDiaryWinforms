using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PersonalDiaryWinforms
{
    public partial class Form1 : Form
    {
        private List<Record> records;
        private const string FilePath = "records.json";
        private int currentIndex = -1;

        public Form1()
        {
            InitializeComponent();
            records = new List<Record>();
            LoadDataFromFile();
            UpdateListBox(records);
            DisplayCurrentRecord();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleTextBox.Text) || string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                MessageBox.Show("Поля не должны быть пустыми.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var record = new Record
            {
                Title = titleTextBox.Text,
                Description = descriptionTextBox.Text,
                Date = dateTimePicker1.Value,
                Tags = ParseTags(tagsTextBox.Text)
            };

            records.Add(record);
            SaveAllData();
            ClearInputs();
            searchTextBox.Clear();
            UpdateListBox(records); 
            currentIndex = records.Count - 1; 
            DisplayCurrentRecord(); 
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < records.Count)
            {
                Console.WriteLine($"Удаление записи: {records[currentIndex].Title}");
                records.RemoveAt(currentIndex);
                SaveAllData();
                ClearInputs();
                UpdateListBox(records);

                if (records.Count > 0)
                {
                    currentIndex = Math.Max(currentIndex - 1, 0);
                }
                else
                {
                    currentIndex = -1;
                }

                DisplayCurrentRecord();
            }
            else
            {
                MessageBox.Show("Невозможно удалить. Убедитесь, что запись выбрана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < records.Count)
            {
                records[currentIndex].Title = titleTextBox.Text;
                records[currentIndex].Description = descriptionTextBox.Text;
                records[currentIndex].Tags = ParseTags(tagsTextBox.Text);

                SaveAllData();
                UpdateListBox(records);
                DisplayCurrentRecord();
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayCurrentRecord();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentIndex < records.Count - 1)
            {
                currentIndex++;
                DisplayCurrentRecord();
            }
        }

        private void ClearInputs()
        {
            titleTextBox.Clear();
            descriptionTextBox.Clear();
            tagsTextBox.Clear();
        }

        private void SaveAllData()
        {
            var json = JsonConvert.SerializeObject(records, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }
        private void LoadDataFromFile()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                records = JsonConvert.DeserializeObject<List<Record>>(json) ?? new List<Record>();
            }
        }

        private List<string> ParseTags(string input)
        {
            var matches = Regex.Matches(input, @"#\w+");
            List<string> tags = new List<string>();

            foreach (Match match in matches)
            {
                tags.Add(match.Value);
            }

            return tags;
        }

        private void DisplayCurrentRecord()
        {
            if (currentIndex >= 0 && currentIndex < records.Count)
            {
                var record = records[currentIndex];
                titleTextBox.Text = record.Title;
                descriptionTextBox.Text = record.Description;
                tagsTextBox.Text = string.Join(" ", record.Tags);
            }
            else
            {
                ClearInputs();
            }
        }

        private void recordsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIndex = recordsListBox.SelectedIndex;
            DisplayCurrentRecord();
        }

        private void UpdateListBox(List<Record> filteredRecords)
        {
            recordsListBox.Items.Clear(); 

            foreach (var record in filteredRecords)
            {
                recordsListBox.Items.Add(record.Title); 
            }

            if (filteredRecords.Count > 0)
            {
                recordsListBox.SelectedIndex = 0;
            }
            else
            {
                recordsListBox.SelectedIndex = -1; 
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string item = searchTextBox.Text.ToLower();

            var results = records
                .Where(record => record.Title.ToLower().Contains(item) ||
                                 record.Description.ToLower().Contains(item) ||
                                 record.Tags.Any(tag => tag.ToLower().Contains(item)))
                .ToList();

            UpdateListBox(results);
        }
    }
}