using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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

namespace Encrypt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AesEncryptDecrypt _aes;
        private readonly DesEncryptDecrypt _des;
        private readonly TripleDesEncryptDecrypt _tripleDes;
        private readonly RandomNumber _randomNumber;
        private byte[] _key;
        private byte[] _iv;
        private byte[] _encryptedText;
        private string _decryptedText;
        private Stopwatch _stopwatch;

        public MainWindow()
        {
            InitializeComponent();
            // instantiates the 3 classes
            _aes = new AesEncryptDecrypt();
            _des = new DesEncryptDecrypt();
            _tripleDes = new TripleDesEncryptDecrypt();
            _randomNumber = new RandomNumber();
            _stopwatch = Stopwatch.StartNew();
        }

        private void GenerateKeyAndIv_Click(object sender, RoutedEventArgs e)
        {
            SelectKeySize();
            KeyText.Text = Convert.ToBase64String(_key);
            IvText.Text = Convert.ToBase64String(_iv);
        }

        /// <summary>
        /// This method is called when Encrypt button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Encrypt_Click(object sender, RoutedEventArgs e)
        {
            //EncryptSelector();
            if (SelectEncryptionCombobox.SelectedIndex == 0)
            {
                _stopwatch.Reset();
                _stopwatch.Start();
                _encryptedText = _aes.EncryptStringToBytes_Aes(MessageText.Text, _key, _iv);
                _stopwatch.Stop();
                EncryptTimeLabel.Content = _stopwatch.Elapsed;
            }
            else if (SelectEncryptionCombobox.SelectedIndex == 1)
            {
                _stopwatch.Reset();
                _stopwatch.Start();
                _encryptedText = _des.EncryptTextToMemory(MessageText.Text, _key, _iv);
                EncryptTimeLabel.Content = _stopwatch.Elapsed;
            }
            else
            {
                _stopwatch.Reset();
                _stopwatch.Start();
                _encryptedText = _tripleDes.EncryptTextToMemory(MessageText.Text, _key, _iv);
                EncryptTimeLabel.Content = _stopwatch.Elapsed;
            }


            EncryptedAsciiText.Text = Convert.ToBase64String(_encryptedText);
            EncryptedHexText.Text = BitConverter.ToString(_encryptedText).Replace("-", String.Empty);
        }

        private void Decrypt_Click(object sender, RoutedEventArgs e)
        {
            if (SelectEncryptionCombobox.SelectedIndex == 0)
            {
                _stopwatch.Reset();
                _stopwatch.Start();
                _decryptedText = _aes.DecryptStringFromBytes_Aes(_encryptedText, _key, _iv);
                _stopwatch.Stop();
                DecryptTimeLabel.Content = _stopwatch.Elapsed;
                DecryptedText.Text = _decryptedText;
            }
            else if (SelectEncryptionCombobox.SelectedIndex == 1)
            {
                _stopwatch.Reset();
                _stopwatch.Start();
                _decryptedText = _des.DecryptTextFromMemory(_encryptedText, _key, _iv);
                _stopwatch.Stop();
                DecryptTimeLabel.Content = _stopwatch.Elapsed;
                DecryptedText.Text = _decryptedText;
            }
            else
            {
                _stopwatch.Reset();
                _stopwatch.Start();
                _decryptedText = _tripleDes.DecryptTextFromMemory(_encryptedText, _key, _iv);
                _stopwatch.Stop();
                DecryptTimeLabel.Content = _stopwatch.Elapsed;
                DecryptedText.Text = _decryptedText;
            }
        }

        /// <summary>
        /// Sets the key Size after 
        /// </summary>
        private void SelectKeySize()
        {
            if (SelectEncryptionCombobox.SelectedIndex == 0)
            {
                _key = _randomNumber.GenerateRandomNumber(32);
                _iv = _randomNumber.GenerateRandomNumber(16);
            }
            else if (SelectEncryptionCombobox.SelectedIndex == 1)
            {
                _key = _randomNumber.GenerateRandomNumber(8);
                _iv = _randomNumber.GenerateRandomNumber(8);
            }
            else
            {
                _key = _randomNumber.GenerateRandomNumber(16);
                _iv = _randomNumber.GenerateRandomNumber(8);
            }
        }
    }
}