// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//declaración de variables
bool valor1 = true;
bool valor2 = true;    
bool valor3 = false;

//declaración implícita var (valor1, valor2, valor3) = (true, true, false);

// AND lógico
bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

// OR lógico
bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);

// AND + OR combinado
bool resultAndOr = (valor1 && valor2) || valor3;
Console.WriteLine(resultAndOr);

// NOT lógico
bool resultNot = !valor1;
Console.WriteLine(resultNot);

// XOR lógico
bool resultXor = (valor1 ^ valor2) ^ valor3;
Console.WriteLine(resultXor);

