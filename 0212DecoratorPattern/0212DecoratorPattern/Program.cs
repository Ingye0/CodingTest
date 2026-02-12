using System;



// 모든 커피가 반드시 가져야 할 기능 정의
// - 설명을 제공해야 하고
// - 가격을 계산할 수 있어야 한다
public interface ICoffee
{
    // 커피 설명
    string Description { get; }

    // 커피 가격 계산
    int Cost();
}

// 아무 옵션도 없는 기본 커피
// → 데코레이터가 감싸기 시작하는 출발점
public class BasicCoffee : ICoffee
{
    // 기본 커피 설명
    public string Description => "Basic Coffee";

    // 기본 커피 가격
    public int Cost()
    {
        return 3000;
    }
}


// 데코레이터
// ICoffee를 구현한다 (그래서 커피처럼 행동함)
// ICoffee를 내부에 가진다 (다른 커피를 감싼다)
public abstract class CoffeeDecorator : ICoffee
{
    // 감싸고 있는 커피 객체
    protected ICoffee _coffee;

    // 생성자로 감쌀 대상을 받는다
    protected CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    // 설명과 가격은
    // 기존 커피 + 추가 기능 형태로 동작해야 하므로
    // 자식 클래스에서 구현하도록 강제
    public abstract string Description { get; }
    public abstract int Cost();
}

// 우유 옵션 데코레이터
public class Milk : CoffeeDecorator
{
    // 생성자에서 어떤 커피를 감쌀지 전달받음
    public Milk(ICoffee coffee) : base(coffee) { }

    // 기존 커피 설명 뒤에 Milk를 추가
    public override string Description
        => _coffee.Description + ", Milk";

    // 기존 커피 가격에 우유 가격 추가
    public override int Cost()
    {
        return _coffee.Cost() + 500;
    }
}

// 설탕 옵션 데코레이터
public class Sugar : CoffeeDecorator
{
    public Sugar(ICoffee coffee) : base(coffee) { }

    // 기존 설명 뒤에 Sugar 추가
    public override string Description
        => _coffee.Description + ", Sugar";

    // 기존 가격에 설탕 가격 추가
    public override int Cost()
    {
        return _coffee.Cost() + 300;
    }
}


class Program
{
    static void Main()
    {
        // 옵션 없는 기본 커피 생성
        ICoffee coffee = new BasicCoffee();
        Console.WriteLine($"{coffee.Description} = {coffee.Cost()}원");

        // 기본 커피를 우유 데코레이터로 감싼다
        // 커피 객체는 여전히 ICoffee 타입
        coffee = new Milk(coffee);
        Console.WriteLine($"{coffee.Description} = {coffee.Cost()}원");

        // 우유 커피를 다시 설탕 데코레이터로 감싼다
        coffee = new Sugar(coffee);
        Console.WriteLine($"{coffee.Description} = {coffee.Cost()}원");
    }
}