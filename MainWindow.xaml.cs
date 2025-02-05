using System.Text;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using Microsoft.VisualBasic;
using System.Windows.Ink;
using System.Windows.Media;

namespace Mini_Paint
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void languageSettingsSelectedEn(object sender, RoutedEventArgs e)
        {
            tabItem1.Header = "Canvas";
            tabItem2.Header = "Settings";
            language.Header = "Language";
            bcBlue.Header = "Blue";
            bcYellow.Header = "Yellow";
            bcGreen.Header = "Green";
            bcRed.Header = "Red";
            bcWhite.Header = "White";
            saveProj.FontSize = 20;
            loadProj.FontSize = 20;
            clearProj.FontSize = 20;
            saveProj.Content = "Save";
            loadProj.Content = "Load";
            clearProj.Content = "Clear";
            
        }

        private void languageSettingsSelectedRu(object sender, RoutedEventArgs e)
        {
            tabItem1.Header = "Холст";
            tabItem2.Header = "Настройки";
            language.Header = "Язык";
            bcBlue.Header = "Синий";
            bcYellow.Header = "Жёлтый";
            bcGreen.Header = "Зелёный";
            bcRed.Header = "Красный";
            bcWhite.Header = "Белый";
            saveProj.FontSize = 11;
            loadProj.FontSize = 12;
            clearProj.FontSize = 12;
            saveProj.Content = "Сохранить";
            loadProj.Content = "Загрузить";
            clearProj.Content = "Очистить";
        }

        private void saveButton(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "InkCnavas Format|*.sandy";
            saveFileDialog.Title = "Save InkCanvas File";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName == "") return;
            FileStream fs = File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate);
            canvas.Strokes.Save(fs);
            fs.Close();
        }
        private void loadButton(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Load InkCanvas File";
            openFileDialog.DefaultExt = "sandy";
            openFileDialog.Filter = "InkCanvas Format(.sandy)|*.sandy";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName == "") return;
            FileStream fs = File.Open(openFileDialog.FileName, FileMode.Open);
            StrokeCollection myStrk = new StrokeCollection(fs);
            canvas.Strokes = myStrk;
            fs.Close();
        }

        private void clearButton(object sender, RoutedEventArgs e)
        {
            canvas.Strokes.Clear();
        }

        private void colorSelectedYellow(object sender, RoutedEventArgs e)
        {
            canvas.Background = Brushes.Yellow;
        }

        private void colorSelectedWhite(object sender, RoutedEventArgs e)
        {
            canvas.Background = Brushes.White;
        }

        private void colorSelectedGreen(object sender, RoutedEventArgs e)
        {
            canvas.Background = Brushes.Green;
        }

        private void colorSelectedBlue(object sender, RoutedEventArgs e)
        {
            canvas.Background = Brushes.Blue;
        }

        private void colorSelectedRed(object sender, RoutedEventArgs e)
        {
            canvas.Background = Brushes.Red;
        }
    }
}
    