using System;

class Car
{
    public string Name = null;
    public int Velocity = 0;

    public Car(string name)
    {
        Name = name;
        Console.WriteLine("자동차의 이름은 " + Name + "입니다.");
    }

    public void MoveForward()
    {
        Console.WriteLine("자동차가 전진합니다.");
    }

    public void MoveBackward()
    {
        Console.WriteLine("자동차가 후진합니다.");
    }

    public void TurnRight()
    {
        Console.WriteLine("자동차가 우회전합니다.");
    }

    public void TurnLeft()
    {
        Console.WriteLine("자동차가 좌회전합니다.");
    }

    public void Stop()
    {
        Console.WriteLine("자동차가 멈춥니다.");
    }

    public void ChangeVelocity(int InputVelocity)
    {
        Velocity = InputVelocity;
        Console.WriteLine("자동차의 속도는 시속" + Velocity + "km 입니다.");
    } 
}

class MainClass
{
    public static void Main(string[] args)
    {
        Car sonata = new Car("소나타");
        sonata.MoveForward();
        sonata.ChangeVelocity(80);
        sonata.MoveBackward();
        sonata.Stop();
    }

}

