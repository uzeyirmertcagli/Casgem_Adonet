using System;
using System.Drawing;
using System.Windows.Forms;

namespace Casgem_Adonet
{
    public partial class FrmLogin : Form
    {
        private Random random = new Random();

        public FrmLogin()
        {
            InitializeComponent();
            ChangeBackgroundColor(); // İlk başlangıçta arka plan rengini değiştir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Burada giriş işlemleri yapılabilir
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            #region
            // Timer ayarları
            Timer timer = new Timer();
            timer.Interval = 100; // Değiştirmek istediğiniz saniye aralığı (1 saniye)
            timer.Tick += Timer_Tick;
            timer.Start();
            #endregion
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Timer tetiklendiğinde arka plan rengini değiştir
            ChangeBackgroundColor();
        }

        private void ChangeBackgroundColor()
        {
            // Rastgele renk oluştur ve formun arka planına ata
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            this.BackColor = randomColor;
        }
    }
}
