using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.IO;

namespace Mod12_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ////Async with await
        private async void btnWriteFile_Click(object sender, RoutedEventArgs e)
        {

            await WriteFileAsync();

        }

        ////Async with await
        private async void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            await ReadFileAsync();
        }

        //Async with await
        public async Task WriteFileAsync()
        {
            string filePath = @"SampleFile.txt";
            string text = txtContents.Text;

            await WriteTextAsync(filePath, text);

        }

        //1.	include Async in its name
        //2.	Return a Task
        //3.	Make the method asynchronous with the correct method modifer
        private async Task WriteTextAsync(string filePath, string text)
        {
            byte[] encodedText = Encoding.Unicode.GetBytes(text);

            //5.	Modify the using (FileStream sourceStream.... ) in the WriteText method so that the sourceStream will use async. HINT: Type a comma after bufferSize: 4096 and look at the overloads available for this statement. Identify the correct addition and add it.
            using (FileStream sourceStream = new FileStream(filePath,
            FileMode.Append, FileAccess.Write, FileShare.None,
            bufferSize: 4096, useAsync: true))
            {
                //4.	The FileStream class includes an asynchronous version of Write. Research the class, find the method, and make the necessary changes to sourceStream.Write to make it asynchronous.
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
            };

        }

        ////Async with await
        public async Task ReadFileAsync()
        {
            string filePath = @"SampleFile.txt";

            if (File.Exists(filePath) == false)
            {
                MessageBox.Show(filePath + " not found", "File Error", MessageBoxButton.OK);
            }
            else
            {
                try
                {
                    string text = await ReadTextAsync(filePath);
                    txtContents.Text = text;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        //1.	Include Async in the name
        //2.	Return a Generic Task of type string
        //3.	Make the method asynchronous with the correct method modifier
        private async Task<String> ReadTextAsync(string filePath)
        {
            //5.	Modify the using (FileStream sourceStream.... ) in the ReadText method so that the sourceStream will use async. HINT: Type a comma after bufferSize: 4096 and look at the overloads available for this statement. Identify the correct addition and add it.
            using (FileStream sourceStream = new FileStream(filePath,
            FileMode.Open, FileAccess.Read, FileShare.Read,
            bufferSize: 4096, useAsync: true))
            {
                StringBuilder sb = new StringBuilder();

                byte[] buffer = new byte[0x1000];
                int numRead;
                //4.	Like the Write method, the Read method also comes in an asynchronous version. Research it and modify the sourceStream.Read method in the while loop to be asynchronous
                while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string text = Encoding.Unicode.GetString(buffer, 0, numRead);
                    sb.Append(text);
                }

                return sb.ToString();
            }
        }
    }
}