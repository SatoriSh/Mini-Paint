using System.Text;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using Microsoft.VisualBasic;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Controls;

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
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.Title = "Save InkCanvas as PNG";
            saveFileDialog.ShowDialog();

            if (string.IsNullOrEmpty(saveFileDialog.FileName)) return;

            // Создаем RenderTargetBitmap для рендеринга InkCanvas
            RenderTargetBitmap rtb = new RenderTargetBitmap(
                (int)canvas.ActualWidth,
                (int)canvas.ActualHeight,
                96, 96, PixelFormats.Pbgra32);

            // Рендерим InkCanvas в растровое изображение
            rtb.Render(canvas);

            // Создаем кодировщик PNG
            PngBitmapEncoder pngEncoder = new PngBitmapEncoder();
            pngEncoder.Frames.Add(BitmapFrame.Create(rtb));

            // Сохраняем изображение в файл
            using (FileStream fs = File.Open(saveFileDialog.FileName, FileMode.Create))
            {
                pngEncoder.Save(fs);
            }
        }

        private void loadButton(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG Image|*.png";
            openFileDialog.Title = "Load PNG Image";
            openFileDialog.ShowDialog();

            if (string.IsNullOrEmpty(openFileDialog.FileName)) return;

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(openFileDialog.FileName);
            bitmap.EndInit();

            // Очистка InkCanvas
            canvas.Strokes.Clear();

            // Отображение PNG как изображения
            Image image = new Image();
            image.Source = bitmap;

            // Добавление изображения на InkCanvas
            canvas.Children.Add(image);
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
    