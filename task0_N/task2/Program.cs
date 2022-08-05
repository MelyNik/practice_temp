/*
Напиште программу, которая будет выдавать название дня недели по задонному номеру
*/


int a = 1, b = 2,
    c = 3, d = 4,
    e = 5, f = 6,
    g = 7;

int what = new int();
Console.WriteLine("Введите номер дня недели");
what = Convert.ToInt32(Console.ReadLine());

if ( what == a )
{
    Console.WriteLine("Название первого дня недели - понедельник");
} 
if ( what == b )
{
    Console.WriteLine("Название второго дня недели - вторник");
} 
if ( what == c )
{
    Console.WriteLine("Название третьего дня недели - среда");
} 
if ( what == d )
{
    Console.WriteLine("Название четвёртого дня недели - четверг");
} 
if ( what == e )
{
    Console.WriteLine("Название пятого дня недели - пятница");
} 
if ( what == f )
{
    Console.WriteLine("Название шестого дня недели - суббота");
} 
if ( what == g )
{
    Console.WriteLine("Название седьмого дня недели - воскресение");
} 