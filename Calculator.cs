using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Opening Calculator.");
    Calculator calc=new Calculator();
    bool temp=true;
    while(temp){
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");
    Console.WriteLine("Choose any Option");
    int choice=Convert.ToInt32(Console.ReadLine());
    if(choice==5){
        break;
    }
    Console.WriteLine("Enter two numbers:");
    int num1=Convert.ToInt32(Console.ReadLine());
    int num2=Convert.ToInt32(Console.ReadLine());
    switch(choice){
        case 1:
        {
            Console.WriteLine("Result:"+calc.add(num1,num2));
            break;
        }
        case 2:
        {
            Console.WriteLine("Result:"+calc.sub(num1,num2));
            break;
        }
        case 3:
        {
            Console.WriteLine("Result:"+calc.multiply(num1,num2));
            break;
        }
        case 4:
        {
            Console.WriteLine("Result:"+calc.div(num1,num2));
            break;
        }
        default:{
            Console.WriteLine("Choose valid option.");
            break;
        }
    }
    }
  }
}
class Calculator{
    public int add(int num1, int num2){
        return num1+num2;
    }
    public int sub(int num1,int num2){
        return num1-num2;
    }
    public int multiply(int num1, int num2){
        return num1*num2;
    }
    public double div(int num1,int num2){
        return num1/num2;
    }
}
