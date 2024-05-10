
/*
int miclave = 3467;
int clave = 1;
try
{
    while (clave > 0)
    {
        Console.WriteLine("Hola ingresa la clave para entrar al sistema \nPresiona 0 para terminar el programa");
        clave = Convert.ToInt32(Console.ReadLine());
        if (clave == 0) { break; }
        if (clave == miclave)
        {
            Console.WriteLine("la clave " + clave + " es correcta");
            Console.WriteLine("Muy bien ahora pon un nombre para identificarte");
            string miNombre = Console.ReadLine();
            Console.WriteLine("Bien ahora pon tu edad");
            int miedad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bien ahora pon tu numero de identificacion");
            int minumid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tu nombre es " + miNombre + "  tu edad es " + miedad + " y tu numero de identificacion es " + minumid);
            Console.WriteLine("Bienvenido al sistema");
            break;
        }
        else
        {
            Console.WriteLine("la clave " + clave + " es incorrecta");
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
}

Console.WriteLine("suma");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Le respuesta de la suma es " + (x + y));
try
{
    Console.WriteLine("Bienvenido comidas rapidas donde alejo,si no quieres pedir nada haz click 6 para salir");
    Console.WriteLine("Haz tu pedido \n 0.hamburguesa \n 1.salchipapas \n 2.perro caliente \n 3.pizza");
    int pedido = Convert.ToInt32(Console.ReadLine());
    while (pedido < 5)
    {

        if (pedido == 0)
        {
            Console.WriteLine("Como quieres tu hamburguesa? \n 0.pequeña \n 1.mediana \n 2.grande");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            if (tamaño == 0 || tamaño == 1 || tamaño == 2)
            {
                Console.WriteLine("Que soda quieres \n 0.coke \n 1.pepsiCO");
                int bebida = Convert.ToInt32(Console.ReadLine());
                if (bebida == 0)
                {
                    Console.WriteLine(" 0.Coca cola \n 1.Sprite \n 2.Del valle \n 3.Premio \n 4. Kola roman");
                    int bebida2 = Convert.ToInt32(Console.ReadLine());


                }
                if (bebida == 1)
                {
                    Console.WriteLine(" 0.Pepsi \n 1.7up m \n 2.Hit \n 3.Tutti fruty \n 4. Mr tea");
                    int bebida2 = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("ingresa tu direccion");
                string direccion = Console.ReadLine();
                Console.WriteLine("ingresa tu numero de celular");
                long numero = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Tu pedido esta en camino \n detalles: " + pedido + " " + bebida + " " + tamaño);
            }

        }

        if (pedido == 1)
        {
            Console.WriteLine("Como quieres tus salchipapas? \n 0.pequeña \n 1.mediana \n 2.grande");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            if (tamaño == 0 || tamaño == 1 || tamaño == 2)
            {
                Console.WriteLine("Que soda quieres \n 0.coke \n 1.pepsiCO");
                int bebida = Convert.ToInt32(Console.ReadLine());
                if (bebida == 0)
                {
                    Console.WriteLine(" 0.Coca cola \n 1.Sprite \n 2.Del valle \n 3.Premio \n 4. Kola roman");
                    int bebida2 = Convert.ToInt32(Console.ReadLine());
                }
                if (bebida == 1)
                {
                    Console.WriteLine(" 0.Pepsi \n 1.7up \n 2.Hit \n 3.Tutti fruty \n 4.Mr tea");
                    int bebida2 = Convert.ToInt32(Console.ReadLine());
                }


                Console.WriteLine("ingresa tu direccion");
                string direccion = Console.ReadLine();
                Console.WriteLine("ingresa tu numero de celular");
                long numero = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Tu pedido esta en camino \n detalles: " + pedido + " " + bebida + " " + tamaño);
            }

        }

        if (pedido == 2)
        {
            Console.WriteLine("Como quieres tu perro caliente? \n 0.pequeña \n 1.mediana \n 2.grande");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            if (tamaño == 0 || tamaño == 1 || tamaño == 2)
            {
                Console.WriteLine("Que soda quieres \n 0.coke \n 1.pepsiCO");
                int bebida = Convert.ToInt32(Console.ReadLine());
                if (bebida == 0)
                {
                    Console.WriteLine(" 0.Coca cola \n 1.Sprite \n 2.Del valle \n 3.Premio \n 4. Kola roman");
                    int bebida2 = Convert.ToInt32(Console.ReadLine());
                }
                if (bebida == 1)
                {
                    Console.WriteLine(" 0.Pepsi \n 1.7up \n 2.Hit \n 3.Tutti fruty \n 4.Mr tea");
                    int bebida2 = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("ingresa tu direccion");
                string direccion = Console.ReadLine();
                Console.WriteLine("ingresa tu numero de celular");
                long numero = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Tu pedido esta en camino \n detalles: " + pedido + " " + bebida + " " + tamaño);
            }

        }

        if (pedido == 3)
        {
            Console.WriteLine("Como quieres tu pizza? \n 0.pequeña \n 1.mediana \n 2.grande");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            if (tamaño == 0 || tamaño == 1 || tamaño == 2)
            {
                Console.WriteLine("Que soda quieres \n 0.coke \n 1.pepsiCO");
                int bebida = Convert.ToInt32(Console.ReadLine());
                if (bebida == 0)
                {
                    Console.WriteLine(" 0.Coca cola \n 1.Sprite \n 2.Del valle \n 3.Premio \n 4. Kola roman");
                    int bebida2 = Convert.ToInt32(Console.ReadLine());
                }
                if (bebida == 1)
                {
                    Console.WriteLine(" 0.Pepsi \n 1.7up \n 2.Hit \n 3.Tutti fruty \n 4.Mr tea");
                    int bebida2 = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("ingresa tu direccion");
                string direccion = Console.ReadLine();
                Console.WriteLine("ingresa tu numero de celular");
                long numero = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Tu pedido es " + pedido + tamaño + bebida );
            }

        }
    }
}
catch (Exception e)
{
    Console.WriteLine( e + " \n El pedido se hace solo con numeros");
}

try
{
    Console.WriteLine("Bienvenido a seguros colsubsidio, ingresa tus datos civiles \nIngresa tu nombre y apellido completos");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingresa tu edad");
    int edad = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingresa tu direccion");
    string direccion = Console.ReadLine();
    Console.WriteLine("Ingresa tu genero ");
    string genero = Console.ReadLine();
    Console.WriteLine("Ingresa tu numero de celular");
    string numero = (Console.ReadLine());
    Console.WriteLine("Ingresa tu numero de cedula");
    string numero2 = Console.ReadLine();
    Console.WriteLine("Ingresa tu correo electronico");
    string correo = Console.ReadLine();
    Random rand = new Random();
    Console.WriteLine("Tu ticket reclamo es sdt" + rand.Next(307));
    Console.WriteLine("Reclama tu medicamento en la taquilla " + rand.Next(12));
    Console.WriteLine("Gracias por tu visita");



}
catch (Exception e)
{
    Console.WriteLine("Un error ha sucedido presiona cualquier boton para salir");
}

Console.WriteLine("calculadora \n0.suma \n1.resta \n2.multplicacion \n3.division");
int ds = Convert.ToInt32(Console.ReadLine());
if (ds == 0 )
{
    Console.WriteLine("pon los numeros que vas a sumar");
    int suma = Convert.ToInt32(Console.ReadLine());
    int suma2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("el resultado de la suma es:" + (suma + suma2));
}
if (ds == 1)
{
    Console.WriteLine("pon los numeros que vas a restar");
    int resta = Convert.ToInt32(Console.ReadLine());
    int resta2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("el resultado de la resta es:" + (resta - resta2));
}
if (ds == 2)
{
    Console.WriteLine("pon los numeros que vas a restar");
    int mult = Convert.ToInt32(Console.ReadLine());
    int mult2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("el resultado de la multiplicacion es:" + (mult * mult2));
}
if (ds == 3)
{
    Console.WriteLine("pon los numeros que vas a dividir");
    int divis = Convert.ToInt32(Console.ReadLine());
    int divis2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("el resultado de la division es:" + (divis / divis2));
}
Console.WriteLine("Hola bienvenido a emergency center ingresa un numero de de emergencias");
int sfd = Convert.ToInt32(Console.ReadLine());
while (sfd == 911)
{
    Console.WriteLine("Has entrado de emergency center ");
    switch (sfd)
    {

        case 911:
            Console.WriteLine("que tipo de emergencia estas ahora \n0.Secuestro \n1.Incendio \n2.Inundamiento \n3.Emergencia medica \n4.Emergencia de hurto \n5.Explosivos \n6.salir");
            int dhu = Convert.ToInt32(Console.ReadLine());
            switch (dhu)
            {
                case 0:
                    Console.WriteLine("danos la  direccion de la casa del secuestrador");
                    string dir0 = Console.ReadLine();
                    Console.WriteLine("escribe el barrio");
                    string barr0 = Console.ReadLine();
                    Console.WriteLine("la policia esta en camino \nSigue estas intrucciones: Espera a que la policia llegue y escondete donde el secuetrador no te encuentre");
                    break;

                case 1:
                    Console.WriteLine("danos tu direccion");
                    string dir1 = Console.ReadLine();
                    Console.WriteLine("escribe el barrio");
                    string barr1 = Console.ReadLine();
                    Console.WriteLine("los bomberos estan camino \nSigue estas instrucciones:Si estas en tu casa sal de ahi inmediata mente no salves nada que alla dentro de la casa y espera que lleguen los bomberos");
                    break;
                case 2:
                    Console.WriteLine("danos tu direccion");
                    string dir2 = Console.ReadLine();
                    Console.WriteLine("escribe el barrio");
                    string barr2 = Console.ReadLine();
                    Console.WriteLine("Si estas intrucciones: en tu casa sal de ahi inmediata mente no salves nada que alla dentro de la casa y espera que lleguen los rescatistas");
                    break;
                case 3:
                    Console.WriteLine("danos tu direccion");
                    string dir3 = Console.ReadLine();
                    Console.WriteLine("escribe el barrio");
                    string barr3 = Console.ReadLine();
                    Console.WriteLine("los paramedicos estan en camino \nSigue  estas intrucciones:No hagas ningun movimiento brusco como levantar pesas quedate lo mas quieto posible y espera que lleguen los paramedicos");
                    break;
                case 4:
                    Console.WriteLine("danos tu direccion");
                    string dir4 = Console.ReadLine();
                    Console.WriteLine("escribe el barrio");
                    string barr4 = Console.ReadLine();
                    Console.WriteLine("los policias estan en camino \nSigue  estas intrucciones Espera a que la policia llegue y escondete donde el ladron no te encuentre");
                    break;
                case 5:
                    Console.WriteLine("danos tu direccion");
                    string dir5 = Console.ReadLine();
                    Console.WriteLine("escribe el barrio");
                    string barr5 = Console.ReadLine();
                    Console.WriteLine("los miltitares estan en camino \nSigue  estas intrucciones: Espera a que los militares lleguen y ten cuidado al pisar una mina o un explosivo");
                    break;
                case 6:
                    sfd = 200; 
                    break;


            }
            break;
    }
}
Console.WriteLine("Has salido de emergency center ");



Console.Write("Ingrese la hora, minutos y segundos para configurar el cronómetro. \nHoras:");
int horas = int.Parse(Console.ReadLine());
Console.Write("Minutos: ");
int minutos = int.Parse(Console.ReadLine());
Console.Write("Segundos: ");
int segundos = int.Parse(Console.ReadLine());
TimeSpan tiempoTotal = new TimeSpan(horas, minutos, segundos);
Console.WriteLine("Cronómetro iniciado...\n");
while (tiempoTotal.TotalSeconds > 0)
{
    Console.WriteLine(tiempoTotal.ToString(@"hh\:mm\:ss")); 
    System.Threading.Thread.Sleep(1000); 
    tiempoTotal = tiempoTotal.Subtract(TimeSpan.FromSeconds(1));
}
Console.WriteLine("\n¡Tiempo agotado! El cronómetro ha finalizado.");
Console.Beep();




    Console.WriteLine("Hola bienvenido al juego : ruleta de numeros \nElige una opcion \n0.solitario \n1.2jugadores");
    int opcion = int.Parse(Console.ReadLine());
    if (opcion == 0)
    {
        Console.WriteLine("Elige un numero del 1 al 30");
        int dfvg = int.Parse(Console.ReadLine());
        Random trs = new Random();
        int neps = trs.Next(1, 30);

    while (dfvg != neps)
    {
        Console.WriteLine($"el numero {dfvg} no es el que se eligio por el sistema");
        dfvg = int.Parse(Console.ReadLine());
        if (dfvg > 30)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"El numero {dfvg} es mayor que 30");
            break;
        }
    }
        Console.WriteLine($"El numero {neps} es el numero que eligio el sistema");
        Console.Beep();
    }
    else if (opcion == 1)
    {
        Console.WriteLine("Nombra el jugador 1");
        string namej1 = Console.ReadLine();
        Console.WriteLine("Nombra el jugador 2");
        string namej2 = Console.ReadLine();
        Console.WriteLine($"Va {namej1} \nElige un numero del 1 al 30");
        int dfvg = int.Parse(Console.ReadLine());
        Random trs = new Random();
        int neps = trs.Next(1, 30);

        while (dfvg != neps) 
        {
            Console.WriteLine($"El numero {dfvg} no es el que se eligio por el sistema \nVa el jugador {namej2}");
            dfvg = int.Parse(Console.ReadLine());
            Console.WriteLine($"El numero {dfvg} no es el que se eligio por el sistema \nVa el jugador {namej1}");
            dfvg = int.Parse(Console.ReadLine());

            if (dfvg > 30)
            {
              Console.ForegroundColor = ConsoleColor.DarkRed;
              Console.WriteLine($"El numero {dfvg} es mayor que 30");
              break;
            }
        }

    }

List<int> primero = new List<int>();
Random randomNUM = new Random();
int NUMR = randomNUM.Next(0, 20);
int[] NUMe = new int[3];
Console.WriteLine("Bienvenido a la rifapuestas \n¿Quieres que te eligamos un numero del 1 al 10 o quieres elegirlo manualmente? \n0. manualmente \n1. elegido por el sistema");
int choice = int.Parse(Console.ReadLine());

for (int i = 0; i < 3; i++)
{
    NUMe[i] = randomNUM.Next(0, 20);
}

if (choice == 0)
{
    Console.WriteLine("Elige uno de estos numeros disponibles {0} {1} {2}", NUMe[0], NUMe[1], NUMe[2]);
    int selectedNumber = int.Parse(Console.ReadLine());

    if (selectedNumber == NUMe[0] || selectedNumber == NUMe[1] || selectedNumber == NUMe[2])
    {
        Console.WriteLine("Has atinado el numero ganador!!!!!");
    }
    else
    {
        Console.WriteLine("No atinaste el numero ganador; más suerte para la próxima");
    }
}
else if (choice == 1)
{
    Console.WriteLine($"El numero que eligió el sistema es {NUMR}");
    Thread.Sleep(5000);

    if (NUMR == NUMe)
    {
        Console.WriteLine("Has atinado el numero ganador!!!!!");
    }
    else
    {
        Console.WriteLine("No atinaste el numero ganador; más suerte para la próxima");
    }
}


int num;
Random rand = new Random();
List<int> numdispo = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
HashSet<int> numerosUtilizados = new HashSet<int>();
for (int i = 10; i >= 1; i--)
{
    disponibles();
    num = int.Parse(Console.ReadLine());
   if(num == 0)
    {
        Console.Write($"Cupos disponibles:{i} \nElige un numero de los que estan disponibles \n");
         num = int.Parse(Console.ReadLine());
        Console.WriteLine($"El numero que elegiste es :{num}");
        if (numdispo.Contains(num))
        {
            MarcarComoReservado(num, numdispo);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"El numero {num} ya fue usado");
            Console.ResetColor();
            i++;
        }
   }
    else if (num == 1)
    {
        int mun = rand.Next(1, 11);
        Console.WriteLine($"El numero que se eligio es :{mun}");
        if (numdispo.Contains(mun))
        {
            MarcarComoReservado(mun, numdispo);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"El numero {num} ya fue usado");
            Console.ResetColor();
            i++;
        }
    }
}
int mun1 = rand.Next(1, 11);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"El numero ganador es: {mun1}, felicitaciones al ganador");
Console.ResetColor();
void disponibles()
{
    Console.WriteLine($"Bienvenido a rifapuestas \n");
    Console.WriteLine("Numeros disponibles:");
    foreach (int elemento in numdispo)
    {
        if (elemento == 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("NND * ");
            Console.ResetColor();
        }
        else
        {
            Console.Write(elemento + " * ");
        }
    }
    Console.WriteLine($"\n¿Quieres elegir un numero de modo manual o de modo automatico? \n0.Manual \n1.Automatico");

}
static void MarcarComoReservado(int num, List<int> numdispo)
{
    int index = numdispo.IndexOf(num);
    if (index != -1)
    {
        numdispo[index] = 0;
    }
}



using Microsoft.Win32;
using System.Net.Sockets;
List<string[]> registros = new List<string[]>();
Console.WriteLine("Ingresa cualquier numero excepto 3");
int elexion = int.Parse(Console.ReadLine());
while (elexion != 3)
{
    Console.WriteLine("Parqueadero La Esquina de Panyo \n Escoja una opcion \n0.Ingreso \n1.Salida \n2.Consultar \n3.salir");
    elexion = int.Parse(Console.ReadLine());
    switch (elexion)
    {
        case 0:
            {
                Console.WriteLine(" \nSeleccione tipo de vehiculo \n0.Carro \n1.Moto ");
                int elexion2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la placa del vehiculo");
                string placa = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del propietario");
                string nombre = Console.ReadLine();
                DateTime fecha = DateTime.Parse("2024-01-23 15:14:00");
                Random randm = new Random();
                string ticket = randm.Next(10000).ToString();
                if (elexion2 == 1)
                {
                    Console.WriteLine("¿Vas ha dejar los cascos? \n0.No \n1.1 Casco \n2.2 Cascos");
                    int cascos = int.Parse(Console.ReadLine());
                    Console.WriteLine("Cliente: {0} \nTipo de vehiculo: Moto \nPlaca: {1} \nFecha: {2}\n# de Ticket  {3} \n# de Cascos {4}", nombre, placa, fecha, ticket, cascos);
                    string[] nuevoRegistro = { nombre, placa, fecha.ToString(), ticket, cascos.ToString(), "Moto", "Guardado" };
                    registros.Add(nuevoRegistro);
                }
                else
                {
                    Console.WriteLine("Cliente: {0} \nTipo de vehiculo: Carro \nPlaca: {1} \nFecha: {2}\n# de Ticket  {3}", nombre, placa, fecha, ticket);
                    string[] nuevoRegistro = { nombre, placa, fecha.ToString(), ticket, "No", "Carro", "Guardado" };
                    registros.Add(nuevoRegistro);
                }
                break;

            };
        case 1:
            {
                Console.WriteLine("Ingresa la placa del vehiculo");
                string placa = Console.ReadLine();

                // Buscar la placa en los registros
                string[] placaEncontrada = null;

                foreach (string[] registro in registros)
                {
                    if (registro[1] == placa)
                    {
                        placaEncontrada = registro;
                        break;
                    }
                }

                if (placaEncontrada != null)
                {
                    // Calcular la diferencia en horas entre la fecha registrada y la fecha actual
                    DateTime fechaRegistrada = DateTime.Parse(placaEncontrada[2]);
                    TimeSpan diferenciaEnHoras = DateTime.Now - fechaRegistrada;
                    double horasTranscurridas = diferenciaEnHoras.TotalHours;

                    // Mostrar información del registro encontrado
                    Console.WriteLine("Registro encontrado:");
                    Console.WriteLine("Cliente: {0} \nTipo de vehiculo: {1} \nPlaca: {2} \nFecha: {3}\n# de Ticket {4} \n# de Cascos {5}",
                        placaEncontrada[0], placaEncontrada[5], placaEncontrada[1], placaEncontrada[2], placaEncontrada[3], placaEncontrada[4]);

                    // Mostrar la diferencia en horas
                    Console.WriteLine("Horas transcurridas desde el registro: {0} horas", horasTranscurridas);

                    // Calcular el monto a pagar multiplicando las horas por 5000
                    double montoAPagar = horasTranscurridas * 2000;

                    // Cambiar el registro a "Pagado" si han pasado ciertas horas (por ejemplo, 2 horas)
                    if (horasTranscurridas >= 2)
                    {
                        placaEncontrada[6] = "Pagado";
                        Console.WriteLine("Registro marcado como Pagado.");
                        Console.WriteLine("Monto a pagar: {0}", montoAPagar);
                    }
                    else
                    {
                        Console.WriteLine("El registro aún no ha alcanzado las 2 horas, no se marcará como Pagado.");
                    }

                    break; // Salir del switch después de encontrar la placa
                }
                else
                {
                    Console.WriteLine("Verifica la placa del vehiculo, no existe en base de datos");
                }

                // Realizar acciones adicionales después de no encontrar la placa
                // ...

                break; // Salir del switch después de no encontrar la placa
            }

        case 2:
            {
                Console.WriteLine("Consulta de registros:");

                if (registros.Count > 0)
                {
                    // Iterar sobre la lista e imprimir cada registro
                    foreach (string[] registro in registros)
                    {
                        Console.WriteLine("Cliente: {0} \nTipo de vehiculo: {1} \nPlaca: {2} \nFecha: {3}\n# de Ticket {4} \n# de Cascos {5} \nEstado: {6}",
                            registro[0], registro[5], registro[1], registro[2], registro[3], registro[4], registro[6]);
                        Console.WriteLine("-------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("No hay registros en la lista.");
                }

                break;
            }


    }

}  
switch (elexion)
{
  case 3:
  {
    Console.WriteLine("Has salido del sistema");
    break;
  }
}

List<int> dinero = new List<int>(){0};
foreach(int d in dinero) { }
int opcion = 4;
while (opcion != 3)
{
    Console.WriteLine("Hola bienvenido al cajero automatico \n0.Sacar dinero \n1.Meter dinero \n2.Consultar \n3.Cerrar seion");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 0:
            {
                Console.WriteLine("Cuanto dinero vas a sacar");
                int cantidad = int.Parse(Console.ReadLine());
                if (cantidad <= dinero[0])
                {
                    dinero[0] -= cantidad;
                    Console.WriteLine($"Has retirado {cantidad} unidades de dinero");
                }
                else
                {
                    Console.WriteLine("No tienes suficiente saldo para retirar esa cantidad");
                }
                break;

            }
        case 1:
            {
                Console.WriteLine("Cuanta cantidad de dinero queres ingresar");
                int cantidadi = int.Parse(Console.ReadLine());
                dinero[0] += cantidadi;
                Console.WriteLine($"Has ingresado {cantidadi} al sistema");
                break;
            }
        case 2:
            {
                Console.WriteLine($"Total de dinero: {dinero[0]}");
                break;
            }
        
    }
}
Console.WriteLine("Has cerrado sesion");




class CarrosMercedes
{
    string tipo;
    string color;
    float precio;

    void myFuncinon()
    {
        Console.WriteLine("Has ejecutado el metodo");
    }

    static void Main(string[] args)
    {
        int i = 4;

        while (i != 1)
        {
            Console.WriteLine("0.Iniciar sesion \n1.salir");
            i = int.Parse(Console.ReadLine());
            CarrosMercedes carros = new CarrosMercedes();
            Console.WriteLine("Escribe el tipo de auto (mercedes)");
            carros.tipo = Console.ReadLine();
            Console.WriteLine("Escribe el tipo de color del auto mercedes");
            carros.color = Console.ReadLine();
            Console.WriteLine("Escribe el precio del auto");
            carros.precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de auto: " + carros.tipo + " \nColor del auto: " + carros.color + " \nPrecio del auto:" + carros.precio);
            carros.myFuncinon();
        }
        Console.WriteLine("¡Has cerrado sesion!");
    }
}



class PS
{
    string tipo = "PlayStation 1";
    string control = "DualShock";
    int fps = 30;
    string resolucion = "340x240";
    string memoria = "1MB";
    class PS2 : PS
    {
        string tipo = "PlayStation 2";
        string control = "DualShock 2";
        int fps = 30;
        string resolucion = "640x480";
        string memoria = "8MB";
        

    }
    class PS3 :PS
    {
        string tipo = "PlayStation 3";
        string control = "DualShock 3";
        int fps = 30;
        string resolucion = "1280×720";
        string memoria = "120GB";

    }
    class PS4 : PS
    {

    }
    class PS5 : PS
    {
        string tipo = "PlayStation 5";
        string control = "DualSense";
        int fps = 120;
        string resolucion = "4K";
        string memoria = "1TB";

    }
    static void Main(string[] args)
    {
        PS myPs = new PS();
        PS2 myPs2 = new PS2();
        PS3 myPs3 = new PS3();
        PS4 myPs4 = new PS4();
        PS5 myPs5 = new PS5();
        Console.WriteLine("Elige una consola \n1.PlayStation 1 \n2.PlayStation 2 \n3.PlayStation 3 \n4.PlayStation 4 \n5.PlayStation 5");
        int inner = int.Parse(Console.ReadLine());
        switch (inner)
        {
            case 1:
                Console.WriteLine("Tipo de PlayStation: " + myPs.tipo + "\nTipo de control: " + myPs.control + "\nFPS: " + myPs.fps + "\nResolucion: " + myPs.resolucion + "\nMemoria: " + myPs.memoria);
                break;
            case 2:
                Console.WriteLine("Tipo de PlayStation: " + myPs2.tipo + "\nTipo de control: " + myPs2.control + "\nFPS: " + myPs2.fps + "\nResolucion: " + myPs2.resolucion + "\nMemoria: " + myPs2.memoria);
                break;
            case 3:
                Console.WriteLine("Tipo de PlayStation: " + myPs3.tipo + "\nTipo de control: " + myPs3.control + "\nFPS: " + myPs3.fps + "\nResolucion: " + myPs3.resolucion + "\nMemoria: " + myPs3.memoria);
                break;
            case 4:
                Console.WriteLine("Tipo de PlayStation: " + myPs4.tipo + "\nTipo de control: " + myPs4.control + "\nFPS: " + myPs4.fps + "\nResolucion: " + myPs4.resolucion + "\nMemoria: " + myPs4.memoria);
                break;
            case 5:
                Console.WriteLine("Tipo de PlayStation: " + myPs5.tipo + "\nTipo de control: " + myPs5.control + "\nFPS: " + myPs5.fps + "\nResolucion: " + myPs5.resolucion + "\nMemoria: " + myPs5.memoria);
                break;
            default:
                Console.WriteLine("La consola no existe");
                break;

        }

    }

}


using System.Linq.Expressions;

class Car
{
    int numeru = 4;
    string color;
    string marca;
    string tipo;
    string placa;
    class moto : Car
    {
        int numeru;    
        string color;  
        string marca;  
        string tipo;  
        string placa;

    }
    class avion : Car
    {
        int numeru;
        string color;
        public string motor;
        string marca;
        string tipo;
    }
    static void Main(string[] args)
    {
        moto myMoto = new moto();
        Car myCar = new Car();
        avion myAvion = new avion();

        myCar.color = "Azul ";
        myCar.marca = "Ford ";
        myCar.tipo = "Carro ";
        myCar.numeru = 4;
        myCar.placa = "FAX*518";


        myMoto.color = "Red ";
        myMoto.marca = "AKT";
        myMoto.tipo = "Moto ";
        myMoto.numeru = 2;
        myMoto.placa = "KFL*77E";


        myAvion.color = "White ";
        myAvion.marca = "Avianca";
        myAvion.tipo = "Avion ";
        myAvion.motor = "Turbinas ";
        myAvion.numeru = 3;

        Console.WriteLine("Elige una opcion \n1.Carro \n2.Moto \n3.Avion");
        int iner = int.Parse(Console.ReadLine());
        switch(iner)
        {
            case 1:
                {
                    Console.WriteLine($"Tipo de vehiculo: {myCar.tipo} \nColor de Carro: {myCar.color} \nMarca de Carro: {myCar.marca} \nNumero de ruedas: {myCar.numeru} \nPlaca: {myCar.placa}");
                    break;
                }
            case 2:
                {
                    Console.WriteLine($"Tipo de vehiculo: {myMoto.tipo} \nColor de Moto: {myMoto.color} \nMarca de Moto: {myMoto.marca} \nNumero de ruedas: {myMoto.numeru} \nPlaca: {myMoto.placa}");
                    break;
                }
            case 3:
                {
                    Console.WriteLine($"Tipo de vehiculo: {myAvion.tipo} \nColor de Avion: {myAvion.color} \nMarca de Avion: {myAvion.marca} \nNumero de ruedas: {myAvion.numeru} \nMotor: {myAvion.motor}");
                    break;
                }
        }

    }
}


using System.Diagnostics;

class cuenta
{
    private double monedero = 0;
    private double retirar;
    private int contraseña;
    private string usuario;
    public static void Main(string[] args)
    {
        cuenta mycuenta = new cuenta();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Elige una opcion:");
        Console.ResetColor();
        Console.WriteLine("0.Ingresar \n1.Salir");
        int innner = int.Parse(Console.ReadLine());
        while (innner != 1)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hola bienvenido al banco. Elige una opcion (Nota:Si no has creado una cuenta aun,creala antes de iniciar sesion):");
            Console.ResetColor();
            Console.WriteLine("0.Crear cuenta \n1.Iniciar sesion \n2.Salir");
            innner = int.Parse(Console.ReadLine());
            switch (innner)
            {
                case 0:
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Crea tu cuenta,ingresa el nombre de la cuenta");
                        Console.ResetColor();
                        string nusuario = Console.ReadLine();
                        mycuenta.usuario = nusuario;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡Perfecto!,ahora ingresa tu contraseña");
                        Console.ResetColor();
                        int ncontraseña = int.Parse(Console.ReadLine());
                        mycuenta.contraseña = ncontraseña;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡Perfecto tu cuenta ya esta creada!");
                        Console.ResetColor();
                        break;
                    }
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ingrese el nombre de la cuenta");
                        Console.ResetColor();
                        string blah = Console.ReadLine();   
                        while (blah != mycuenta.usuario)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"El nombre {blah} no existe. Ingrese otro nombre");
                            Console.ResetColor();
                            blah = Console.ReadLine();
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ingrese la contraseña");
                        Console.ResetColor();
                        int udhs = int.Parse(Console.ReadLine());
                        while (udhs != mycuenta.contraseña)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Contraseña no valida. Ingrese otra...");
                            Console.ResetColor();
                            udhs = int.Parse(Console.ReadLine());
                        }
                        
                        int choice = 2;
                        while (choice != 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"Hola {mycuenta.usuario},¿Que quieres hacer hoy?");
                            Console.ResetColor();
                            Console.WriteLine("0.Ingresar dinero \n1.Chekear monedero \n2.Retirar dinero \n3.Salir");
                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 0:
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("¿Cuanta cantidad de dinero vas ingresar?");
                                        Console.ResetColor();
                                        int cdinero = int.Parse(Console.ReadLine());
                                        mycuenta.monedero += cdinero;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"Total de dinero ingresada: {cdinero}");
                                        Console.ResetColor();
                                        break;
                                    }
                                case 1:
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine($"Total de dinero: {mycuenta.monedero}");
                                        Console.ResetColor();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("¿Cuanta cantidad de dinero vas retirar?");
                                        Console.ResetColor();
                                        int cdinero2 = int.Parse(Console.ReadLine());
                                        mycuenta.monedero -= cdinero2;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"Total de dinero retirada: {cdinero2}");
                                        Console.ResetColor();
                                        break;
                                    }
                                case 3:
                                    {
                                        break;
                                    }
                            }
                            
                        }
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Has cerrado sesion");
                        Console.ResetColor();
                        break;
                    }
                        
                
            }
        }
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Has cerrado sesion");
        Console.ResetColor();
    }

}

*
class empleados
{
    List <string> Agregar = new List <string>();
    string eliminar;
    int elegir;
    public static void Main(string[] args)
    {
        empleados MisEmpleados = new empleados();
        foreach (string agregar in MisEmpleados.Agregar) { }
        while (MisEmpleados.elegir != 3)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hola bienvenido al gestor de empleados,¿Que vas a ser hoy?");
            Console.ResetColor();
            Console.WriteLine("0.Agregar empleados \n1.Eliminar empleados \n2.Chekear empleados \n3.Cerrar sesion");
            MisEmpleados.elegir = int.Parse(Console.ReadLine());
       
            switch (MisEmpleados.elegir)
            {
                case 0:
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("¿Cual es el nombre del empleado?");
                        Console.ResetColor();
                        string nombre = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡El empleado fue agregado a la base de datos!");
                        Console.ResetColor();

                        MisEmpleados.Agregar.Add(nombre);
                        break;
                    }
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ingrese el nombre del empleado para eliminarlo");
                        Console.ResetColor();       
                        MisEmpleados.eliminar = Console.ReadLine();
                        if (!MisEmpleados.Agregar.Contains(MisEmpleados.eliminar))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"El empleado con el nombre: {MisEmpleados.eliminar} no existe");
                            Console.ResetColor();
                        }

                        else
                        {
                            MisEmpleados.Agregar.Remove(MisEmpleados.eliminar);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"El empleado con el nombre: {MisEmpleados.eliminar} ha sido eliminado correctamente");
                            Console.ResetColor();
                        }

                        break;
                    }
                case 2:
                    {
                        if (MisEmpleados.Agregar.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("No hay empleados en la base de datos");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Total de empleados:");
                            foreach (string empleado in MisEmpleados.Agregar)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow; 
                                Console.WriteLine("-" + empleado);
                            }
                            Console.ResetColor();
                        
                    }
                        break;
                    }
                   
            }
            
        }
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Has cerrado sesion");
        Console.ResetColor();
    }
}



class Notas
{
    string Estudiante;
    float nota;
    int Choice;
    public static void Main(string[] args)
    {
        Notas MisNotas = new Notas();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("bienvenido al gestor de notas,ingresa el nombre del estudiante");
        Console.ResetColor();
        MisNotas.Estudiante = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Hola {MisNotas.Estudiante},elige una materia");
        Console.ResetColor();
        Console.WriteLine("0.Matematicas \n1.Lengua castellana \n2.Ciencias sociales \n3.Ciencias naturales \n4.Tecnologia \n5.Artistica \n6.Religion \n7.Ingles \n8.Etica \n9.Salir del sistema");
        MisNotas.Choice = int.Parse(Console.ReadLine());
        if (MisNotas.Choice <= 10 && MisNotas.Choice > 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Opcion no valida");
            Console.ResetColor();
        }
        else if (MisNotas.Choice == 9)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Has cerrado sesion");
            Console.ResetColor();
        }
        else
        {
            int longi = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("¿Cuantas notas vas a ingresar?");
            Console.ResetColor();
            MisNotas.Choice = int.Parse(Console.ReadLine());
            for (longi = 1; longi <= MisNotas.Choice; longi++)
            {
                Console.WriteLine($"Ingresa {longi + "/" + MisNotas.Choice} notas");
                MisNotas.nota += float.Parse(Console.ReadLine());
            }
            float promedieichon = longi / MisNotas.nota;
            if (promedieichon <= 3.0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"El promedio del estudiante {MisNotas.Estudiante} es {MisNotas.nota} (El estudiante pierde la materia)");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"El promedio del estudiante {MisNotas.Estudiante} es {promedieichon} (El estudiante gana la materia)");
                Console.ResetColor();
            }
        }
    }
}

    */

































































































































































































