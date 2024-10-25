using System.Dynamic;

namespace MauiApp4
{


    public partial class Carrace : ContentPage
    {
        Car car1;
        Car car2;

        bool finish = false;

        public Carrace()
        {
            InitializeComponent();

            this.car1 = new Car("Audi", 20);
            this.car2 = new Car("Nissan", 5);
            car1Info.Text = car1.GetCarInfo();
            car2Info.Text = car2.GetCarInfo();
        }



        private void Button_Clicked(object sender, EventArgs e)
        {
            //double distance = 2000;
            var distance = Application.Current.MainPage.Width; // Get the screen width as distance

            if (!finish)
            {
                var timeUseCar1 = this.car1.RunForDistance(distance);
                ImageCar1.TranslateTo(distance - 100, 0, timeUseCar1 * 10, Easing.Linear);
                car1Info.Text = car1.GetCarInfo();
                timeUsecar1Info.Text = $"{this.car1.Name}  time use : {timeUseCar1}";

                var timeUseCar2 = this.car2.RunForDistance(distance);
                ImageCar2.TranslateTo(distance - 100, 0, timeUseCar2 * 10, Easing.Linear);
                car2Info.Text = car2.GetCarInfo();
                timeUsecar2Info.Text = $"{this.car2.Name}  time use : {timeUseCar2}";
                finish = true;
            }
            else
            {
                ImageCar1.TranslateTo(0, 0, 0, Easing.Linear);
                ImageCar2.TranslateTo(0, 0, 0, Easing.Linear);
                finish = false;
            }

        }
    }
}
