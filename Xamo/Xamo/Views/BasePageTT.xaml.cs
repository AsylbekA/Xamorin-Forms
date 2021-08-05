using Xamarin.Forms;
using Xamo.Interface;

namespace Xamo.Views
{

    public partial class BasePageTT : ContentPage
    {
        #region Глава 4. Элементы в Xamarin и их свойства

        //private WebView webView;
        //private Entry urlEntry;
        //private Label actionLabel;

        #endregion

        #region Глава 5. Платформо-зависимый код

        #endregion

        #region Глава 6. Ресурсы и стили

        #endregion
        public BasePageTT()
        {
            InitializeComponent();

            #region Глава 4. Элементы в Xamarin и их свойства

            //Label label1 = new Label() { Text = "Первая метка",TextColor=Color.Red };
            //Label label2 = new Label() { Text = "Вторая метка", TextColor=Color.Blue };
            //Label label3 = new Label() { Text = "Третья метка",TextColor=Color.Green };
            //StackLayout stackLayout = new StackLayout()
            //{
            //    Children = { label1, label2,label3 }
            //};
            //stackLayout.Spacing = 8;
            //this.Content = stackLayout; 


            //StackLayout stackLayout= new StackLayout();
            //for (int i=1;i<=20;i++)
            //{
            //    Label label = new Label()
            //    {
            //        Text = "Metka" + i,
            //        FontSize = 23
            //    };
            //    stackLayout.Children.Add(label);
            //}
            //ScrollView scrollView= new ScrollView();
            //scrollView.Content = stackLayout;
            //this.Content = scrollView;

            //AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            //absoluteLayout.Children.Add(
            //    new BoxView { Color=Color.LightBlue },
            //    new Rectangle(70,70,200,70));
            //absoluteLayout.Children.Add(
            //    new Label { Text= "Xamarin Forms", FontSize=20},
            //    new Rectangle(110,90,150,60));
            //absoluteLayout.Children.Add(
            //    new Label {Text= "Welcome to Xamarin World!", FontSize=16 },
            //    new Point(70,150));
            //Content = absoluteLayout;

            //Label label = new Label
            //{
            //    VerticalTextAlignment = TextAlignment.Center,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    Text = "Welcome to Xamarin Forms!",
            //    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            //};
            //TapGestureRecognizer tapGesture = new TapGestureRecognizer
            //{
            //    NumberOfTapsRequired = 2
            //};

            //int count = 0;
            //tapGesture.Tapped += (s, e) =>
            //{
            //    count++;
            //    if (count % 2 == 0)
            //    {
            //        label.BackgroundColor = Color.Black;
            //        label.TextColor = Color.White;
            //    }
            //    else
            //    {
            //        label.TextColor = Color.Black;
            //        label.BackgroundColor = Color.White;
            //    }
            //    label.Text = $"Вы нажали {count} раз";
            //};
            //label.GestureRecognizers.Add(tapGesture);
            //Content = label;

            //StackLayout stackLayout = new StackLayout();

            //loginEntry = new Entry { Placeholder = "Login" };
            //loginEntry.TextChanged += loginEntry_TextChanged;
            //PasswordEntry = new Entry
            //{
            //    Placeholder = "Password",
            //    IsPassword = true
            //};
            //Textlabel = new Entry { FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) };
            //stackLayout.Children.Add(loginEntry);
            //stackLayout.Children.Add(PasswordEntry);
            //stackLayout.Children.Add(Textlabel);

            //TableView

            //this.Content=new TableView
            //{
            //    Intent = TableIntent.Form,
            //    Root = new TableRoot("Ввод данных")
            //    {
            //        new TableSection("Персональные данные")
            //        {
            //            new EntryCell
            //            {
            //                Label = "Логин",
            //                Placeholder = "введите логин",

            //                Keyboard = Keyboard.Default
            //            },
            //            new SwitchCell{Text = "Сохранить"}
            //        },
            //        new TableSection("Контакты")
            //        {new EntryCell
            //            {
            //                Label = "Телефон:",
            //                Placeholder ="введите телефон",
            //                Keyboard = Keyboard.Telephone
            //            },

            //            new EntryCell
            //            {
            //                Label = "Email:",
            //                Placeholder = "введите email",
            //                Keyboard = Keyboard.Email
            //            }
            //        }
            //    }
            //};


            //WebView

            //urlEntry=new Entry{HorizontalOptions = LayoutOptions.EndAndExpand};
            //Button button=new Button{Text = "Go"};
            //button.Clicked += button_Clicked;
            //StackLayout stack=new StackLayout
            //{
            //    Orientation = StackOrientation.Horizontal,
            //    Children = { button,urlEntry}
            //};

            //webView=new WebView
            //{
            //    Source = new UrlWebViewSource { Url = "https://devblogs.microsoft.com/xamarin/" },
            //    // или так
            //    // Source = "https://devblogs.microsoft.com/xamarin/",
            //    VerticalOptions = LayoutOptions.FillAndExpand
            //};
            //this.Content=new StackLayout{Children = { stack,webView}};

            //Всплывающие окна

            //Button alertButton = new Button
            //{
            //    Text = "Alert",
            //    VerticalOptions = LayoutOptions.Start,
            //    HorizontalOptions = LayoutOptions.Center
            //};
            //alertButton.Clicked += AlertButton_Clicked;
            //Content = alertButton;

            //Button alertButton=new Button{Text = "Alert"};
            //alertButton.Clicked += AlertButton_Clicked;
            //actionLabel=new Label();
            //Content=new StackLayout{Children = { alertButton,actionLabel}};

            #endregion

            #region Глава 5. Платформо-зависимый код

            //Класс Device

            //Label appLabel = new Label { HorizontalTextAlignment = TextAlignment.Center };
            //switch (Device.RuntimePlatform)
            //{
            //    case Device.Android:
            //        appLabel.Text = "Android";
            //        break;
            //    case Device.iOS:
            //        appLabel.Text = "iOS";
            //        break;
            //    case Device.UWP:
            //        appLabel.Text = "UWP";
            //        break;
            //    case Device.WPF:
            //        appLabel.Text = "WPF";
            //        break;
            //    case Device.GTK:
            //        appLabel.Text = "GTK";
            //        break;
            //    default:
            //        appLabel.Text = "Undefined";
            //        break;
            //}

            //Content = appLabel;

            //if (Device.Idiom == TargetIdiom.Phone)
            //{
            //    // код для смартфонов
            //}
            //else if (Device.Idiom == TargetIdiom.Tablet)
            //{
            //    // код для планшетов
            //}
            //else if (Device.Idiom == TargetIdiom.Desktop)
            //{
            //    // код для настольных компьютеров
            //}

            //DependencyService

            //IDeviceInfo deviceInfo = DependencyService.Get<IDeviceInfo>();

            //Label infoLabel=new Label();
            //infoLabel.Text = deviceInfo.GetInfo();
            //infoLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            //Content=new StackLayout
            //{
            //    Children = { infoLabel}
            //};

            #endregion

            #region Глава 6. Ресурсы и стили


            #endregion
        }


        #region Глава 4. Элементы в Xamarin и их свойства

        //private async void AlertButton_Clicked(object sender, EventArgs e)
        //{
        //    //bool result = await DisplayAlert("Подтвердить действие", "Вы хотите удалить элемент?", "Да", "Нет");
        //    //await DisplayAlert("Уведомление", "Вы выбрали: "+(result? "Удалить": "Отменить"), "ОK");
        //    var action = await DisplayActionSheet("Поделиться", "Отмена", "Удалить", "Вконтакте", "Твиттер", "Фейсбук");
        //    actionLabel.Text = action;
        //}


        //private void loginEntry_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    textLabel.Text = loginEntry.Text;
        //}
        //private void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
        //{
        //    if (label != null)
        //    {
        //        label.Text= "Вы выбрали " + e.NewDate.ToString("dd/MM/yyyy");
        //    }
        //}

        //private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
        //{
        //    header.Text = "Вы выбрали: " + picker.Items[picker.SelectedIndex];
        //}

        //private void Stepper_OnValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    if (header != null)
        //    {
        //        header.Text=String.Format("Выбрано: {0:F1}", e.NewValue);
        //    }
        //}

        //private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    if (headers != null)
        //    {
        //        headers.Text = $"Выбрано: {e.NewValue:F1}";
        //    }
        //}

        //private void Switch_OnToggled(object sender, ToggledEventArgs e)
        //{
        //   label.Text =  $"Значение {e.Value}";
        //}
        //private void LoginEntry_OnCompleted(object sender, EventArgs e)
        //{
        //    Loginlbl.Text = LoginEntry.Text;
        //}

        //private void SaveSwitch_OnOnChanged(object sender, ToggledEventArgs e)
        //{
        //    savelbl.Text = saveSwitch.On.ToString();
        //}

        //void button_Clicked(object sender, EventArgs e)
        //{
        //    webView.Source = new UrlWebViewSource { Url = urlEntry.Text };
        //    // или так
        //    // webView.Source = urlEntry.Text;
        //}

        #endregion

        #region Глава 5. Платформо-зависимый код

        #endregion

        #region Глава 6. Ресурсы и стили

        #endregion
    }
}