![Octocat Logo](http://2.bp.blogspot.com/-z9YlNMIX5NE/Vdj07d3qPGI/AAAAAAAAAls/N8LFN6pPze0/s1600/github_128.png)
# CA3

## Programación 2
*Prof. Jorge Davián Aguilar Oviedo*

**Ejercicio 03**
>Ejemplo de markdown

## Propósito
Ejemplo de los siguientes temas
- **Variables compuestas**
- *Enumeraciones*
```C#
enum DayofWeek
{
    sunday,
    monday,
    tuesday,
    wednesday,
    thursday,
    friday,
    saturday,
};

enum BookPrice
{
    Low = 500,
    MediumLow = 2500,
    Medium = 5000,
    MediumHigh = 7500,
    High = 10000,
};
```
- *Estructuras*
```C#
struct Book
{
    int bookid;
    string bookname;
    string author;
    double bookprice;
};

struct Game
{
    int id;
    string name;
    int rating;
};
```
- *Arreglos*
```C#
//unidimencionales - vectores
int[] vector1 = new int[4];
int[] vector2 = new int[] { 1, 3, 9, 12, 15 };
int[] vector3 = { 1, 2, 3, 4, 5, 6 };
char[] array1 = { 'J', 'o', 's', 'e'};

//multidimencionales - matrices
int[,] matrix1 = new int[2, 3];
int[,] matrix2 = { { 1, 2, 3 }, { 4, 5, 6 } };
string[,] names = new string[5,5];
byte[][] scores = new byte[5][5];
```
- **Ciclos**
- *For*
```C#
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(vector2[i]);
}
```
- *Foreach*
```C#
int[] numarray = new int[] { 0, 1, 2, 3, 4};
foreach (int num in numarray)
{
    System.Console.WriteLine(num);
}
```

- **Uso de librerias - bibliotecas**
 - Namespaces
 - Directiva Using
La directiva using tiene tres usos:
 - Para permitir el uso de tipos en un espacio de nombres de manera que no tenga que calificar el uso de un tipo en dicho espacio de nombres. using System.Text;
 - Para permitirle acceder a los miembros estáticos de un tipo sin tener que calificar el acceso con el nombre del tipo: using static System.Math;
 - Para crear un alias para un espacio de nombre o un tipo. Esto se denomina una directiva de alias using. using Project = PC.MyCompany.Project;

```C#
//Librerías Comunes
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
//Entre otras
```


- **Sistemas de numeración**
¿Qué es un sistema de numeración?
Un sistema de numeración es un conjunto de símbolos y reglas de generación que permiten construir todos los números válidos. Un sistema de numeración puede representarse como N=(S,R), donde:
 - N es el sistema de numeración considerado (p.ej. decimal, binario,hexadecimal, etc.).
 - S es el conjunto de símbolos permitidos en el sistema.
 - R son las reglas que nos indican qué números y qué operaciones son válidos en el sistema, y cuáles no. En un sistema de numeración posicional las reglas son bastante simples, mientras que la numeración romana requiere reglas algo más elaboradas.
- *Binario - (0,1)* 11010101
- *Octal - (0,7)*  325
- *Decimal - (0,9)*  213
- *Hexadecimal - (0,F)*  D5


- **Pendientes**
- [ ] Asignación en clase
- [ ] Tarea 03

Enlace a repositorio | Enlace de Invitacion
------------ | -------------
davian-007/CA3 | https://classroom.github.com/assignment-invitations/53c60f4cfc49e23e0abd2d98e1c85068

Github - davian-007
[CA3](https://github.com/Programacion-II/CA3)

@davian-007 :thumbsup:
