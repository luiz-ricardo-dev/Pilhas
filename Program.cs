﻿
Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(7);
pilha.Push(8);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

pilha.Pop();

Console.WriteLine("Removendo Elemento--------");

foreach(int item in pilha)
{
    Console.WriteLine(item);
}