using com.FunctionModels; 
using Demo.Properties;
using FunctionDAL;
using Sunny.UI.Properties;
using System;
using System.ComponentModel;

namespace Sunny.UI
{
    [DefaultProperty("Text")]
    [DefaultEvent("OnLogin")]
    public partial class LoginForm : UIForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public string SubText
        {
            get => lblSubText.Text;
            set => lblSubText.Text = value;
        }

        private UILoginImage loginImage;

        [DefaultValue(UILoginImage.Login1)]
        public UILoginImage LoginImage
        {
            get => loginImage;
            set
            {
                if (loginImage != value)
                {
                    loginImage = value;

                     if (loginImage == UILoginImage.Login1) BackgroundImage = Resources.Login1;
                     if (loginImage == UILoginImage.Login2) BackgroundImage =  Resources.Login2;
                     if (loginImage == UILoginImage.Login3) BackgroundImage = Resources.Login3;
                     if (loginImage == UILoginImage.Login4) BackgroundImage = Resources.Login4;
                     if (loginImage == UILoginImage.Login5) BackgroundImage = Resources.Login5;
                     if (loginImage == UILoginImage.Login6) BackgroundImage = Resources.Login6;
 }
            }
        }

        public enum UILoginImage
        {
            Login1,
            Login2,
            Login3,
            Login4,
            Login5,
            Login6
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ButtonCancelClick != null)
                ButtonCancelClick?.Invoke(sender, e);
            else
                Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ButtonLoginClick != null)
            {
                ButtonLoginClick?.Invoke(sender, e);
            }
            else
            {
                UserInfo user = new UserInfo();
                user.UserName = txtUser.Text;
                user.Password = txtPassword.Text;
              

                 if (UserService.Instance.Login(user))
                 {
                    UIMessageBox.Show("登录成功！");
                 }

                IsLogin = OnLogin != null && OnLogin(txtUser.Text, txtPassword.Text) ; 
                if (IsLogin) this.Close(); 
             
              
                
            }
        }

        public event EventHandler ButtonLoginClick;

        public event EventHandler ButtonCancelClick;

        [DefaultValue(false), Browsable(false)]
        public bool IsLogin { get; protected set; }

        public delegate bool OnLoginHandle(string userName, string password);

        public event OnLoginHandle OnLogin;

        private void UILoginForm_Enter(object sender, EventArgs e)
        {
            //btnLogin.PerformClick();
        }

        public string UserName
        {
            get => txtUser.Text;
            set => txtUser.Text = value;
        }

        public string Password
        {
            get => txtPassword.Text;
            set => txtPassword.Text = value;
        }
    }
} 