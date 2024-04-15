using System;

// Создаем абстрактный класс "Транспорт"
public abstract class Transport
{
    public abstract int Скорость { get; }
    public abstract int Грузоподъемность { get; }
    public abstract int ДальностьРасстояния { get; }

    public abstract string ПолучитьОписание();
}

// Создаем абстрактный класс "Автомобиль"
public abstract class Автомобиль : Transport
{
}

// Создаем абстрактный класс "Самолет"
public abstract class Самолет : Transport
{
}

// Создаем абстрактный класс "Корабль"
public abstract class Корабль : Transport
{
}

// Создаем класс, наследующийся от "Автомобиль"
public class МаршруткаАвтомобиль : Автомобиль
{
    public override int Скорость => 60;
    public override int Грузоподъемность => 500;
    public override int ДальностьРасстояния => 500;

    public override string ПолучитьОписание()
    {
        return "Маршрутка с грузоподъемностью в 500 может проехать 500";
    }
}

// Создаем класс, наследующийся от "Самолет"
public class Ан124Самолет : Самолет
{
    public override int Скорость => 800;
    public override int Грузоподъемность => 100000;
    public override int ДальностьРасстояния => 10000;

    public override string ПолучитьОписание()
    {
        return "Ан-124 с грузоподъемностью в 100000 может пролететь 10000";
    }
}

// Создаем класс, наследующийся от "Корабль"
public class ЛайнерКорабль : Корабль
{
    public override int Скорость => 30;
    public override int Грузоподъемность => 200000;
    public override int ДальностьРасстояния => 2000;

    public override string ПолучитьОписание()
    {
        return "Лайнер с грузоподъемностью в 200000 может проплыть 2000";
    }
}

class Program
{
    static void Main()
    {
        МаршруткаАвтомобиль маршрутка = new МаршруткаАвтомобиль();
        Console.WriteLine(маршрутка.ПолучитьОписание());

        Ан124Самолет самолет = new Ан124Самолет();
        Console.WriteLine(самолет.ПолучитьОписание());

        ЛайнерКорабль корабль = new ЛайнерКорабль();
        Console.WriteLine(корабль.ПолучитьОписание());
    }
}