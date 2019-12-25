using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Windows;
using UIHelper;

namespace TextViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _Model = new Model();
            this.DataContext = _Model;
        }

        private Model _Model;

        private void OnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnOpen_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            OpenTextFileDialog aDlg = new OpenTextFileDialog();
            if (aDlg.ShowDialog() != true) return;
            try
            {
                _Model.Load(aDlg.FileName, aDlg.CurrentEncoding);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnOpenPicture_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            OpenTextFileDialog aDlg = new OpenTextFileDialog();
            if (aDlg.ShowDialog() != true) return;
            try
            {
                _Model.Load(aDlg.FileName, aDlg.CurrentEncoding);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnStartFilte_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            try
            {
                _Model.StartFilte();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnStartFilte_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _Model != null && _Model.CanStartFilte;
        }
        /*
        public string FileName => _Model.FileName;
        private void OnStartPicture_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            OpenFileDialog aDlg = new OpenFileDialog()
            {
                Title = "选择文件",
                Filter = "JPG文件(*.jpg) | *.jpg | PNG文件(*.png) | *.png | 所有文件(*.*) | *.* ",
            };
            if (aDlg.ShowDialog() != true) return;
            _Model.FileName = aDlg.FileName;
        }
        */
        private void OnChangeEmail(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            string str_email = email.Text.Trim();
            if (!Regex.IsMatch(str_email, @"^[1-9]\d{7,10}@qq\.com$"))
            {
                MessageBox.Show("邮箱格式不正确，请正确输入");
                email.Text = "";
            }
            else
            {
                MessageBox.Show("正在发送，请等待......");
                this.Close();
            }
        }

        private void OnStartPicture_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {

        }

        private void OnStartPicture_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {

        }

        private void OnPicture(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {

        }
    }
   
}
