﻿using System.Windows;


namespace Wpflab_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ButtonsField bf = new ButtonsField(textBox2);
            bf.drawField(gridForButtons);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != "")
            {
                comboBox.Items.Add(textBox.Text);
                textBox.Text = "";
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (comboBox.Items.Count != 0)
                comboBox.Items.RemoveAt(comboBox.Items.Count - 1);
            else
                MessageBox.Show("Що видаляти?", "Комбо Бокс пустий");
        }
    }
}