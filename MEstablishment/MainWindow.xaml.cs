using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Threading;
using System.Threading;

namespace MEstablishment
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

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rec1.Visibility = Visibility.Hidden;
            textbox1.Visibility = Visibility.Hidden;
            rungb.Visibility = Visibility.Hidden;
            moitruongb.Visibility = Visibility.Hidden;
            nguonnuocb.Visibility = Visibility.Hidden;
            sinhhocb.Visibility = Visibility.Hidden;
            moitruong.Visibility = Visibility.Visible;
            backhome.Visibility = Visibility.Visible;
            hoachat.Visibility = Visibility.Hidden;
            giaothong.Visibility = Visibility.Hidden;
            khongngo.Visibility = Visibility.Hidden;
			moitruong_Copy.Visibility=Visibility.Hidden;
			moitruong_Copy1.Visibility=Visibility.Hidden;
			tainguyenb.Visibility=Visibility.Hidden;
        }

        private void backhome_Click(object sender, RoutedEventArgs e)
        {
            rec1.Visibility = Visibility.Visible;
            textbox1.Visibility = Visibility.Visible;
            rungb.Visibility = Visibility.Visible;
            moitruongb.Visibility = Visibility.Visible;
            sinhhocb.Visibility = Visibility.Visible;
            nguonnuocb.Visibility = Visibility.Visible;
            khongngo.Visibility = Visibility.Hidden;
            hoachat.Visibility = Visibility.Hidden;
            giaothong.Visibility = Visibility.Hidden;
            backhome.Visibility = Visibility.Hidden;
			moitruong.Visibility=Visibility.Hidden;
			moitruong_Copy.Visibility=Visibility.Hidden;
			moitruong_Copy1.Visibility=Visibility.Hidden;
			tainguyenb.Visibility=Visibility.Visible;
        }

        private void hcnl_Click(object sender, RoutedEventArgs e)
        {
            rec1.Visibility = Visibility.Hidden;
            textbox1.Visibility = Visibility.Hidden;
            rungb.Visibility = Visibility.Hidden;
            moitruongb.Visibility = Visibility.Hidden;
            nguonnuocb.Visibility = Visibility.Hidden;
			tainguyenb.Visibility=Visibility.Hidden;
            sinhhocb.Visibility = Visibility.Hidden;
            backhome.Visibility = Visibility.Visible;
            hoachat.Visibility = Visibility.Visible;
            khongngo.Visibility = Visibility.Hidden;
            giaothong.Visibility = Visibility.Hidden;
			moitruong.Visibility=Visibility.Hidden;
			moitruong_Copy.Visibility=Visibility.Hidden;
			moitruong_Copy1.Visibility=Visibility.Hidden;
        }

        private void gt_Click(object sender, RoutedEventArgs e)
        {
            rec1.Visibility = Visibility.Hidden;
            textbox1.Visibility = Visibility.Hidden;
            rungb.Visibility = Visibility.Hidden;
            moitruongb.Visibility = Visibility.Hidden;
            nguonnuocb.Visibility = Visibility.Hidden;
			tainguyenb.Visibility=Visibility.Hidden;
            sinhhocb.Visibility = Visibility.Hidden;
            backhome.Visibility = Visibility.Visible;
            hoachat.Visibility = Visibility.Hidden;
            khongngo.Visibility = Visibility.Hidden;
            giaothong.Visibility = Visibility.Visible;
			moitruong.Visibility=Visibility.Hidden;
			moitruong_Copy.Visibility=Visibility.Hidden;
			moitruong_Copy1.Visibility=Visibility.Hidden;
        }

        private void kongo_Click(object sender, RoutedEventArgs e)
        {
            rec1.Visibility = Visibility.Hidden;
            textbox1.Visibility = Visibility.Hidden;
            rungb.Visibility = Visibility.Hidden;
            moitruongb.Visibility = Visibility.Hidden;
            nguonnuocb.Visibility = Visibility.Hidden;
			tainguyenb.Visibility=Visibility.Hidden;
            sinhhocb.Visibility = Visibility.Hidden;
            backhome.Visibility = Visibility.Visible;
            hoachat.Visibility = Visibility.Hidden;
            khongngo.Visibility = Visibility.Visible;
            giaothong.Visibility = Visibility.Hidden;
			moitruong.Visibility=Visibility.Hidden;
			moitruong_Copy.Visibility=Visibility.Hidden;
			moitruong_Copy1.Visibility=Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AboutTVD about = new AboutTVD();
            about.Show();
        }

        private void Materials_Click(object sender, RoutedEventArgs e)
        {
            top1.Visibility = Visibility.Visible;
            top2.Visibility = Visibility.Visible;
            top3.Visibility = Visibility.Visible;
            rec2.Visibility = Visibility.Visible;
            Materials_Hide.Visibility = Visibility.Visible;
            Materials.Visibility = Visibility.Hidden;
        }

        private void Materials_Hide_Click(object sender, RoutedEventArgs e)
        {
            top1.Visibility = Visibility.Hidden;
            top2.Visibility = Visibility.Hidden;
            top3.Visibility = Visibility.Hidden;
            rec2.Visibility = Visibility.Hidden;
            Materials_Hide.Visibility = Visibility.Hidden;
            Materials.Visibility = Visibility.Visible;
        }
        private void rotate(object sender, RoutedEventArgs e)
        {
            loading.Visibility = Visibility.Hidden;
            tvd.Visibility = Visibility.Hidden;
            DoubleAnimation rt = new DoubleAnimation();
            rt.From = 0;
            rt.To = 180;
            rt.Duration = new Duration(TimeSpan.FromSeconds(1.5));
            RotateTransform rtani = new RotateTransform();
            loadimg.RenderTransform = rtani;
            rtani.BeginAnimation(RotateTransform.AngleProperty, rt);

        }

        private void loadimg_MouseEnter(object sender, MouseEventArgs e)
        {
            loadtitle.Visibility = Visibility.Hidden;
            loading.Visibility = Visibility.Hidden;
            tvd.Visibility = Visibility.Hidden;
            DoubleAnimation rt = new DoubleAnimation();
            rt.From = 0;
            rt.To = 180;
            rt.Duration = new Duration(TimeSpan.FromSeconds(1.5));
            RotateTransform rtani = new RotateTransform();
            loadimg.RenderTransform = rtani;
            rtani.BeginAnimation(RotateTransform.AngleProperty, rt);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Các dự án khác của TVD Studio: \nMaterial Key - Bộ gõ tiếng Việt \nMaterial QLNT - Phần mềm quản lí nhà trường","Các dự án khác");
        }

        private void abouttvds_Click(object sender, RoutedEventArgs e)
        {
            AboutTVD tvdstudiogt = new AboutTVD();
            tvdstudiogt.Show();
        }
    }
}
