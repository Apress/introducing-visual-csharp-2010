using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace AnimationDemo {
    
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e) {

            DoubleAnimation myWidthAnimation = new DoubleAnimation();
            myWidthAnimation.From = button1.Width;
            myWidthAnimation.To = button1.Width + 50;
            myWidthAnimation.Duration = TimeSpan.FromSeconds(1);

            DoubleAnimation myHeightAnimation = new DoubleAnimation();
            myHeightAnimation.From = button1.Height;
            myHeightAnimation.To = button1.Height + 20;
            myHeightAnimation.Duration = TimeSpan.FromSeconds(2);

            button1.BeginAnimation(Button.WidthProperty, myWidthAnimation);
            button1.BeginAnimation(Button.HeightProperty, myHeightAnimation);
        }
    }
}
