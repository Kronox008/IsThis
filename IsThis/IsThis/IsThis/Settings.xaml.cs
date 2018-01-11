using SQLite;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace IsThis
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        private SQLiteAsyncConnection _connection;

        public class Saved_Settings
        {
            [SQLite.PrimaryKey, SQLite.AutoIncrement]
            public int StaticId { get; set; }
            public int Saved_Quantity { get; set; }
            public int Saved_Time { get; set; }
            public int IsTimerOn { get; set; }
        }

        public Settings()
        {
            



            InitializeComponent();
            Intractor();
            EXTRACTSQL();




            Setup_setting_numbers();
            
        }
        protected override async void OnAppearing()
        {
            // _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            //   await _connection.CreateTableAsync<Saved_Settings>();
            // var SavedinDB = new Saved_Settings()
            // { StaticId = 1,
            //      Saved_Quantity = 10,
            //      Saved_Time = 30,
            //      IsTimerOn = 1,                                                         /////Working
            //   };
            //await _connection.InsertOrReplaceAsync(SavedinDB);

            // var testiswork = new Saved_Settings();
            // testiswork = await _connection.GetAsync<Saved_Settings>(1);
            base.OnAppearing();
        }

        public async void Intractor()
        {
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            await _connection.CreateTableAsync<Saved_Settings>();
            var SavedinDB = new Saved_Settings()
            {
                StaticId = 1,
                Saved_Quantity = 10,
                Saved_Time = 30,
                IsTimerOn = 1,
            };
            await _connection.InsertOrReplaceAsync(SavedinDB);
        }




        public async void  EXTRACTSQL()
        {
            

            var testiswork = new Saved_Settings();
            testiswork = await _connection.GetAsync<Saved_Settings>(1);

            testiswork.Saved_Time = Global.CountDownTime;

        }



        private void Setup_setting_numbers()
        {
            
            if (Global.CountDownTimeIsOn == 1)
            {
                TimeSwitch.IsToggled = true;
            }
            else
            {
                TimeSwitch.IsToggled = false;
            }
            TimeStepper.Value = Global.CountDownTime;
            TimeStepperLabel.Text = String.Format("{0} sec", Global.CountDownTime);
            TimeStepperLabel.TextColor = Color.FromHex(Global.ButtonBackColor);

            Questiontepper.Value = Global.QuestionQuantity;
            QuestionStepperLabel.Text = String.Format("{0} klausimų", Global.QuestionQuantity);
            QuestionStepperLabel.TextColor = Color.FromHex(Global.ButtonBackColor);
        }

        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            if(Global.CountDownTimeIsOn == 1)
            {
                Global.CountDownTimeIsOn = 0;
                TimeStepper.IsEnabled = false;
                TimeStepperLabel.Text = "∞ sec";
            }
            else
            {
                Global.CountDownTimeIsOn = 1;
                TimeStepper.IsEnabled = true;
                TimeStepperLabel.Text = TimeStepperLabel.Text = String.Format("{0} sec", Global.CountDownTime);
            }
        }

        private async void TimeStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Global.CountDownTime = Convert.ToInt32(TimeStepper.Value);
            TimeStepperLabel.Text = String.Format("{0} sec", Global.CountDownTime);

            //var Changed_Time = new Saved_Settings
            //{
            //    StaticId = 1,
            //    Saved_Time = Global.CountDownTime,
            //};
            //await _connection.InsertOrReplaceAsync(Changed_Time.Saved_Time);
        }

        private void Questiontepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Global.QuestionQuantity = Convert.ToInt32(Questiontepper.Value);
            QuestionStepperLabel.Text = String.Format("{0} klausimų", Global.QuestionQuantity);
        }
    }
       
}
