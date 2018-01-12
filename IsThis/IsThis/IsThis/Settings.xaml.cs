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

        //public class Saved_Settings
        //{
        //    [SQLite.PrimaryKey, SQLite.AutoIncrement]
        //    public int StaticId { get; set; }
        //    public int Saved_Quantity { get; set; }
        //    public int Saved_Time { get; set; }
        //}


        public Settings()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            SetFields();
        }



        private void SetFields()
        {
            LanguagePickerLabel.Text = Global.LanguagePickerLabel;
            LanguagePicker.TextColor = Color.FromHex((Global.ButtonBackColor));
            LanguagePicker.Title = Global.LanguagePickerTitle;
            LanguagePicker.TextColor = Color.FromHex((Global.ButtonBackColor));
        }





        protected override void OnAppearing()
        {

            TimeStepperLabel.TextColor = Color.FromHex(Global.ButtonBackColor);
            TimeStepper.Value = Global.CountDownTime;

            if (Global.CountDownTime <= 180)
            {
                TimeStepperLabel.Text = String.Format("{0} sec", Global.CountDownTime);
            }
            else
            {
                TimeStepperLabel.Text = "∞ sec";
            }
         
            

            Questiontepper.Value = Global.QuestionQuantity;
            QuestionStepperLabel.Text = String.Format("{0} {1}", Global.QuestionQuantity, Global.QuestionslabelText);
            QuestionStepperLabel.TextColor = Color.FromHex(Global.ButtonBackColor);

            base.OnAppearing();
        }


        //Time stepper---------------------------------------------------------------------------
        private async void TimeStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Global.CountDownTime = Convert.ToInt32(TimeStepper.Value);
            if (Global.CountDownTime <= 180)
            { 
            TimeStepperLabel.Text = String.Format("{0} sec", Global.CountDownTime);
            }
            else
            {
                TimeStepperLabel.Text = "∞ sec";
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////Saving to DB
            var Save_TO_DB = new GameSelectionPage.Saved_Settings()
            {
                StaticId = 1,
                Saved_Quantity = Global.QuestionQuantity,
                Saved_Time = Global.CountDownTime,
                LanguageId = Global.LanguageSelectedID,
                

            };

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            await _connection.InsertOrReplaceAsync(Save_TO_DB);
            
        }
        //Question stepper--------------------------------------------------------------------------
        private async void Questiontepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Global.QuestionQuantity = Convert.ToInt32(Questiontepper.Value);
            QuestionStepperLabel.Text = String.Format("{0} {1}", Global.QuestionQuantity, Global.QuestionslabelText);

            ///////////////////////////////////////////////////////////////////////////////////////////////Saving to DB
            var Save_TO_DB = new GameSelectionPage.Saved_Settings()
            {
                StaticId = 1,
                Saved_Quantity = Global.QuestionQuantity,
                Saved_Time = Global.CountDownTime,
                LanguageId = Global.LanguageSelectedID,

            };
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            await _connection.InsertOrReplaceAsync(Save_TO_DB);
        }

        private void LanguagePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedLanguage = LanguagePicker.Items[LanguagePicker.SelectedIndex];
            DisplayAlert("test", selectedLanguage, LanguagePicker.SelectedIndex.ToString());
        }
    }
       
}
