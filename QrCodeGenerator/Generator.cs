using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;

namespace QrCodeGenerator
{
    public partial class Generator : Form
    {
        public Generator()
        {
            InitializeComponent();

            // Подписываемся на событие TextChanged для textBox1
            textBox1.TextChanged += TextBox1_TextChanged;
        }

        // Метод для генерации QR-кода
        private void GenerateQRCode()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // Если текстовое поле пустое, очищаем PictureBox
                pictureBoxQRCode.Image = null;
                return;
            }

            QRCoder.QRCodeGenerator QRgen = new QRCoder.QRCodeGenerator();
            var QRdata = QRgen.CreateQrCode(textBox1.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var QRcode = new QRCoder.QRCode(QRdata);

            pictureBoxQRCode.Image = QRcode.GetGraphic(50);
        }

        // Обработчик события TextChanged для textBox1
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            GenerateQRCode();
        }

        //Generate QR-CODE  Generate QR-CODE  Generate QR-CODE  Generate QR-CODE  Generate QR-CODE  Generate QR-CODE  
        private void button1_Click(object sender, EventArgs e)
        {
            GenerateQRCode();
        }
        //Generate QR-CODE  Generate QR-CODE  Generate QR-CODE  Generate QR-CODE  Generate QR-CODE  Generate QR-CODE  

        //SAVE QR-CODE SAVE QR-CODE SAVE QR-CODE SAVE QR-CODE SAVE QR-CODE SAVE QR-CODE SAVE QR-CODE SAVE QR-CODE 
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли изображение в PictureBox
            if (pictureBoxQRCode.Image == null)
            {
                MessageBox.Show("There is no image to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Настройка диалога сохранения файла
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Настройки диалога
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|BMP Image|*.bmp"; // Фильтр форматов
                saveFileDialog.Title = "Save QR code"; // Заголовок диалога
                saveFileDialog.FileName = "QRCode"; // Имя файла по умолчанию

                // Если пользователь выбрал файл и нажал "Сохранить"
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Сохраняем изображение в выбранный файл
                        pictureBoxQRCode.Image.Save(saveFileDialog.FileName);
                        MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while saving: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //SAVE QR-CODE SAVE QR-CODE SAVE QR-CODE SAVE QR-CODE SAVE QR-CODE SAVE QR-CODE SAVE QR-CODE SAVE QR-CODE 

        //Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit 
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit Quit 

        //White White White White White White White White White White White White White White White White White 
        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }
        //White White White White White White White White White White White White White White White White White 

        //Black Black Black Black Black Black Black Black Black Black Black Black Black Black Black Black Black 
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }
        //Black Black Black Black Black Black Black Black Black Black Black Black Black Black Black Black Black 

        //ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.1", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT ABOUT 
    }
}