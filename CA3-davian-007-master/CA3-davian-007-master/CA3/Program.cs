using System;

namespace CA3
{
    class Program
    {
        static int option = 0;
        static int i = 0;
        static int size = 2;
        [Flags]
        enum BookPrice
        {
            Bajo = 500,
            MedioBajo = 2500,
            Medio = 5000,
            MedioAlto = 7500,
            Alto = 10000,
        };
        struct Book
        {
            
            public int bookid;
            public string bookname;
            public string author;
            public double bookprice;
        };

        static Book[] Books;

        static void AddBooks()
        {
            int r = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < Books.Length)
                {
                    Console.WriteLine("-* Librería el Buen Lector  *-*");
                    Console.WriteLine("Ingreso de libros.             ");
                    Console.Write("Digite el ID:                  ");
                    Books[i].bookid = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del libro:    ");
                    Books[i].bookname = Console.ReadLine();
                    Console.Write("Digite el autor del libro:     ");
                    Books[i].author = Console.ReadLine();
                    Console.WriteLine("Seleccione el precio del libro:");
                    Console.Write(BookPrice.Bajo + ":" + (int)BookPrice.Bajo + "\n" +
                                  BookPrice.MedioBajo + ":" + (int)BookPrice.MedioBajo + "\n" +
                                  BookPrice.Medio + ":" + (int)BookPrice.Medio + "\n" +
                                  BookPrice.MedioAlto + ":" + (int)BookPrice.MedioAlto + "\n" +
                                  BookPrice.Alto + ":" + (int)BookPrice.Alto + "\n");
                    Books[i].bookprice = double.Parse(Console.ReadLine());
                    Console.WriteLine("Desea agregar otro libro 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de libros lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }

        static void ShowBooks()
        {
            int reg = 0;
            Console.Clear();
            Console.WriteLine("-* Librería el Buen Lector  *-*");
            Console.WriteLine("Listado de libros.             ");
            for (i = 0; i < Books.Length; i++)
            {
                reg = i + 1;
                Console.WriteLine("Registro: " + reg);
                Console.WriteLine("ID:       " + Books[i].bookid);
                Console.WriteLine("Nombre:   " + Books[i].bookname);
                Console.WriteLine("Auto:     " + Books[i].author);
                Console.WriteLine("Precio:   " + Books[i].bookprice);
            }
            Console.ReadKey();
        }

        static void SeekBooks()
        {
            //Buscar por registro
            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Librería el Buen Lector  *-*");
                Console.WriteLine("Búsquedad de libros.           ");
                Console.WriteLine("Digite el ID del libro a buscar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < Books.Length; i++)
                {
                    if (ID == Books[i].bookid)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("ID:       " + Books[i].bookid);
                        Console.WriteLine("Nombre:   " + Books[i].bookname);
                        Console.WriteLine("Auto:     " + Books[i].author);
                        Console.WriteLine("Precio:   " + Books[i].bookprice);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro libro 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }
        static void modificar_Libros()
        {
            int reg = 0;
            int option = 0;
            int user = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Librería el Buen Lector  *-*");
                Console.WriteLine("Modificación de libros");
                Console.WriteLine("Digite el ID del libro que desea buscar");
                user = int.Parse(Console.ReadLine());
                for (i = 0; i < Books.Length; i++)
                {
                    if (user == Books[i].bookid)
                    {
                        reg = i + 1;


                        Console.WriteLine("Ingrese el ID:       " + Books[i].bookid);
                        Console.WriteLine("Ingrese el Nombre del libro:   " + Books[i].bookname);
                        Console.WriteLine("Ingrese el nombre del Autor:     " + Books[i].author);
                        Console.WriteLine("Ingrese el precioPrecio:   " + Books[i].bookprice);
                        found = true;
                   
                
                
                    {
                        while (option != 5)
                        {
                            Console.Clear();

                            Console.WriteLine("Ingrese la opcion que desea cambiar");
                                Console.WriteLine("Ingrese la opcion que desea cambiar");
                                Console.WriteLine("1.Nombre");
                            Console.WriteLine("2.Autor");
                            Console.WriteLine("3.Precio");
                            Console.WriteLine("4.Ver cambios");
                            Console.WriteLine("5.Salir");

                            option = int.Parse(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Digite el nuevo nombre del Libro");
                                    Books[i].bookname = Console.ReadLine();

                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Digite el nuevo nombre del Autor");
                                    Books[i].author = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Digite el nuevo precio del libro");
                                    Console.Write(BookPrice.Bajo + ":" + (int)BookPrice.Bajo + "\n" +
                                  BookPrice.MedioBajo + ":" + (int)BookPrice.MedioBajo + "\n" +
                                  BookPrice.Medio + ":" + (int)BookPrice.Medio + "\n" +
                                  BookPrice.MedioAlto + ":" + (int)BookPrice.MedioAlto + "\n" +
                                  BookPrice.Alto + ":" + (int)BookPrice.Alto + "\n");
                                    Books[i].bookprice = double.Parse(Console.ReadLine());
                                    break;
                                case 4:
                                        {
                                            ShowBooks();
                                            if (user.Equals(Books[i].bookname) ) {
                                            }
                                            else {
                                                Console.Clear();
                                                Console.WriteLine("Modificaciones Actuales");


                                                Console.WriteLine("Digite Nombre del Libro:   " + Books[i].bookname.Length);
                                                Console.WriteLine("Digite Autor del libro:     " + Books[i].author.Length);
                                                Console.WriteLine("Digite Precio del libro:   " + (int)Books[i].bookprice);
                                                found = true; }ShowBooks();
                                        }
                                    break;
                                case 5:
                                    break;
                            }

                        




                    
                }
                if (!found)
                    {
                        Console.WriteLine("No se encontro ese ID");
                        found = false;
                    }
                    Console.WriteLine("Desea buscar otro libro 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                }
                         } } } }
        


                 

        static void Main()
        {
            Books = new Book[size];
            do
            {
                Console.Clear();
                Console.WriteLine("-* Librería el Buen Lector  *-*");
                Console.WriteLine("1. Ingreso de libros.");
                Console.WriteLine("2. Modificación de libros.");
                Console.WriteLine("3. Eliminación de libros.");
                Console.WriteLine("4. Búsquedad de libros.");
                Console.WriteLine("5. Listado de libros.");
                Console.WriteLine("6. Venta de libros.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            AddBooks();
                            break;
                        }
                    case 2:
                        {
                            modificar_Libros();
                            break;
                        }
                    case 3:
                        {
                            //Dejar campos en 0 y vacío
                            break;
                        }
                    case 4:
                        {
                            SeekBooks();
                            break;
                        }
                    case 5:
                        {
                            ShowBooks();
                            break;
                        }
                    case 6:
                        {
                            //Venta similar a tarea1
                            break;
                        }
                    case 7:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }
    }
}
