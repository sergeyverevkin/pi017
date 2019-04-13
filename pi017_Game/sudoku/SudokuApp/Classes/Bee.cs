namespace SudokuApp.Classes
{
  class Bee
  {
    public double SpeedX;
    public double AccelerationX;
    public double SpeedY;
    public double AccelerationY;
    public double X;
    public double Y;

    private readonly double _width;
    private readonly double _height;

    public Bee(double dW, double dH)
    {
      _width = dW;
      _height = dH;
    }

    public void MoveUp()
    {
      SpeedY = 10;
      AccelerationY = 5;
    }

    public void Timer()
    {
      if (SpeedX != 0) {
        X = X - SpeedX;
        SpeedX -= AccelerationX;
        if (X > _width || X < 0) {
          AccelerationX -= AccelerationX;
          SpeedX -= SpeedX;
        }

        if (AccelerationX > 0) {
          AccelerationX -= 1;
          if (AccelerationX < 0) AccelerationX = 0;
        }
        else
        {
          AccelerationX += 1;
          if (AccelerationX > 0) AccelerationX = 0;
        }
      }

      if (SpeedY != 0) {
        Y = Y - SpeedY;
        SpeedY -= AccelerationY;
        if (Y > _width || Y < 0) {
          AccelerationY -= AccelerationY;
          SpeedY -= SpeedY;
        }

        if (AccelerationY > 0) {
          AccelerationY -= 1;
          if (AccelerationY < 0) AccelerationY = 0;
        }
        else
        {
          AccelerationY += 1;
          if (AccelerationY > 0) AccelerationY = 0;
        }
      }
    }

    public void MoveDown()
    {
      SpeedY = -10;
      AccelerationY = -5;
    }
  }
}
