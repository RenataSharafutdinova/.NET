Operation op1 = Add;
Console.WriteLine(op1(5, 1));

Operation op2 = Subtract;
Console.WriteLine(op2(5, 1));

Operation op3 = Multiply;
Console.WriteLine(op3(5, 1));

int Add(int a, int b) => a + b;
int Subtract(int a, int b) => a - b;
int Multiply(int a, int b) => a * b;

delegate int Operation(int a, int b);
