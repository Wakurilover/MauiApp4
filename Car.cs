namespace MauiApp4;



	public class Car
    {
      public string Name { get; set; }
      public double Speed { get; set; }

      public string Color { get; set; }

      public double TotalMile { get; set; }

      public Car(string name, double speed)
      {
       


        this.Name = name;
        this.Speed = speed;
      }

      public uint RunForDistance(double distance)  // return time use
      {
          this.TotalMile += distance;
          return Convert.ToUInt16(distance / this.Speed);
      }

      public string GetCarInfo()
      {
        var carinfo = $"Car name : {this.Name}\nCar speed : {this.Speed}\nTotal Mile : {this.TotalMile}";
        return carinfo;
      }

    }