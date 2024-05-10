/*

//Desarrollar un algoritmo que imprima los números de 1 al 100.

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}

//Desarrollar un algoritmo que sume los cinco primeros números naturales.

Console.WriteLine(1+2+3+4+5);

//Desarrollar un algoritmo que calcule el promedio de un alumno que tiene 7 calificaciones en la materia de química.

float notazs = 0;
for(int i = 1; i <= 7; i++)
{
    Console.WriteLine("Por Favor Ingrese la Calificacion Numero: " + i);
    notazs += float.Parse(Console.ReadLine());
}
Console.WriteLine(notazs / 7 > 3.4 ? "Has Ganado la Materia, \nSu Nota Final es: " + notazs / 7 : "Has Perdido la Materia, \nSu Nota Final es: " + notazs / 7);

Console.WriteLine("Ingrese las siete calificaciones de quimica");
float nota1 = float.Parse(Console.ReadLine());
float nota2 = float.Parse(Console.ReadLine());
float nota3 = float.Parse(Console.ReadLine());
float nota4 = float.Parse(Console.ReadLine());
float nota5 = float.Parse(Console.ReadLine());
float nota6 = float.Parse(Console.ReadLine());
float nota7 = float.Parse(Console.ReadLine());
float notaf = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6 + nota7) / 7;
if (notaf < 3.5)
{
    Console.WriteLine("Su nota es: " + notaf + " Perdiste la materia");
}else 
{
    Console.WriteLine("Su nota es: " + notaf + " Ganaste la materia");
}





// Desarrollar un algoritmo que lea 10 números e imprimir solamente los números positivos. (se imprime dentro del ciclo, si el usuario ingresa un número positivo se imprime, sino ingresa un número negativo, no se imprime nada y se pide el número siguiente)

int pos = 0;
int neg = 0; 
int cr = 0; 
int nume = 0;

Console.WriteLine("Ingrese 10 números");

for (int i = 1; i < 11; i++)
{
    Console.Write($"Número: {i}: ");
     nume= int.Parse(Console.ReadLine());

    if (nume > 0)
    {
        Console.WriteLine($"Número positivo: {nume}");
        pos++;
    }else if (nume < 0)
    {
        neg++;
    }
    else
    {
        cr++;
    }

}
Console.WriteLine($"Cantidad positivos: {pos}, \nCantidad negativos: {neg}, \nCantidad de ceros: {cr}.");






//Desarrollar un algoritmo que calcule e imprima la tabla de multiplicar de un número ingresado por el usuario e imprimir el multiplicando, el multiplicador (va de 1 hasta 10) y el producto. 


int num = 0;
Console.WriteLine("Ingresa un numero");
num = int.Parse(Console.ReadLine());

for (int i = 1; i < 11; i++)
{
    Console.WriteLine(num * i);
}
   


//Se tiene el nombre y la edad de 3 personas y se desea saber si dentro de ellas hay por lo menos una que sea menor de edad e imprimir Un mensaje que diga “si se encontró un menor de edad” y su nombre. Sino “no hay ningún menor de edad” NOTA, DEBE ROMPER EL CICLO AL ENCONTRAR UN MENOR DE EDAD.

int[] edades = { 18, 13, 35};
string[] nombres = { "sam", "juan", "jose"};
int pos = 0 ;
for (int i = 0; i < edades.Length; i++)
{
    if (edades[i] < 18)
    {
        Console.WriteLine($"Si se encontró un menor de edad, nombre: {nombres[i]}");
        pos = 1;
        break;
    }
}
if (pos == 0)
{
    Console.WriteLine("No hay ningún menor de edad");
}



// Ingresar dos números enteros A y B, e imprimir los números que se encuentran entre A y B, tener en cuenta que A > B.

Console.WriteLine("Ingresa un numero");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa otro numero");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Los numeros medios son: ");
for (int i = a-1; i >= b+1; i--)
{
    Console.WriteLine(i);
}



// Ingresar números enteros, hasta que se ingrese un número negativo y decir cuántos de los números ingresados son pares y cuántos son impares.

int pares = 0;
int impares = 0;
Console.WriteLine("Ingresa un numero");
int num = int.Parse(Console.ReadLine());
while(num > 0)
{
    if(num % 2 == 0)
    {
        pares++;
    }else
    {
        impares++;
    }
    Console.WriteLine("Ingresa nuevamente un numero");
    num = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Cantidad de numeros pares: {pares},\nCantidad de numeros impares: {impares}");



//	Escribir un algoritmo que permita escribir en pantalla la frase ¿Desea continuar? S/N, hasta que la respuesta sea N




int[] valores = new int[7];
for(int i = 0; i < 7; i++)
{
    Console.WriteLine("Ingresa el valor de un producto de mecato");
    valores[i] = int.Parse(Console.ReadLine());

}
Console.WriteLine($"Valor maximo es: {valores.Max()} \nValor minimo es: {valores.Min()} \nEl valor promedio es:  {valores.Sum() / 7}");



// Escribir un algoritmo que permita escribir en pantalla la frase ¿Desea continuar? S/N, hasta que la respuesta sea N

Console.WriteLine("¿Quieres continuar?");
string resp = Console.ReadLine();
while (resp[0].ToString().ToLower() != "n")
{
    Console.WriteLine("¿Quieres continuar?");
    resp = Console.ReadLine();
}

// Diseñar un Algoritmo que escriba de 2 en 2 los números comprendidos del 100 al 200



for (int i = 100; i <= 200; i+=2)
{
    Console.WriteLine(i);
}


//


int men = 0;
int mayo = 0;
Console.WriteLine("Ingresa un numero ");
int nums = int.Parse(Console.ReadLine());
for (int i = 0;i <= 10;i++)
{
    if (nums < 15)
    {
       men++;
    }
    else if(nums > 50)
    {
        mayo++;
    }
    Console.WriteLine("Ingresa nuevamente un numero ");
    nums = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Mayores: {mayo} \nMenores: {men}");



// Elaborar un algoritmo que permita ingresar 20 números y muestre todos los números menores o iguales a 25


Console.WriteLine("Ingresa un numero ");
int nums = int.Parse(Console.ReadLine());
string total = "";
for (int i = 1; i <= 19; i++)
{
    if (nums <= 25)
    {
        total += $" {nums},";
    }

    Console.WriteLine("Ingresa nuevamente un numero ");
    nums = int.Parse(Console.ReadLine());
}
Console.WriteLine(total);


//Una tienda se dedica a la venta de computadoras, cuenta con 10 vendedores. Cada uno de ellos tiene un sueldo mensual pero además de su sueldo ganan una comisión por venta 

//Si el monto de venta es mayor de 1000 la comisión será del 15%
//Si el monto de venta es mayor ó igual a 500 y menor de 1000 la comisión es del 5%
//Si el monto de la venta es menor que 500 no tiene comisión


int salario = 100000;
double comision = 0;
Console.WriteLine("Ingrese el valor de la venta ");
float venta = float.Parse(Console.ReadLine());
if (venta >= 1000)
{
  comision = venta * 0.15;
}
else if(venta >= 500 &&  venta < 1000)
{
    comision = venta * 0.05;
}
Console.WriteLine($"Su salario es: {salario}, \nSu comision es: {comision}, \nLa venta fue: {venta}");




// Elaborar un algoritmo que permita averiguar si una persona debe sacar su cedula (mayor de 17 años), sabiendo su año de nacimiento.

Console.WriteLine("Hola por favor ingresa tu año de nacimiento");
int agen = int.Parse(Console.ReadLine());

int añoActual = DateTime.Now.Year;
int edad = añoActual - agen;
string name ="";
int numc= 0;
if (edad < 17)
{
    Console.WriteLine($"Tu edad no esta en el presupuesto para sacar la cedula, por que tu edad es: {edad}");
}
else
{
    Console.WriteLine("Ingresa tu nombre");
    name = Console.ReadLine();
    Console.WriteLine("Ahora ingresa tu numero de regitro civil");
    numc = int.Parse(Console.ReadLine());
    Console.WriteLine($"Tu nombre es:{name} \nTu edad es: {edad} \n Reclama tu cedula en esta ubicacion: cra 75a#27f92");
    Console.Beep();
}



//Elaborar un algoritmo que pida un número y diga si es positivo o negativo.

Console.WriteLine("Ingresa un numero");
int jff = int.Parse(Console.ReadLine());
Console.WriteLine(jff < 0? $"El numero {jff} es negativo" : $"El numero {jff} es positivo");

// Elaborar un algoritmo que pida un número y diga si es mayor de 100.
Console.WriteLine("Ingresa un numero");
int hfdy = int.Parse(Console.ReadLine());
Console.WriteLine(hfdy > 100 ? $"El numero {hfdy} es mayor que 100" : $"El numero {hfdy} es menor que 100");




// Elaborar un algoritmo para un trabajador que necesita calcular su salario semanal, el cual se obtiene de la siguiente manera: 


int time = 0;
int pagoPorHora = 300;
int tiempoextra;
int pago;
Console.WriteLine("Ingresa el tiempo que trabaja el empleado");
time = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el tiempo extra");
tiempoextra = int.Parse(Console.ReadLine());
pago = tiempoextra * pagoPorHora;
Console.WriteLine($"El pago del empleado es:{pago}");


// Elaborar un algoritmo que pida un número del 1 al 7 y entregue como resultado el nombre del día correspondiente a la semana


Console.WriteLine("Ingresa un numero del 1 al 7 para elegir un dia de la semana");
int days = int.Parse(Console.ReadLine());   
switch(days)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miercoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sabado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
}
    


//Elaborar un algoritmo que permita el login (inicio de sesión) en una red social. 
int clave = 2039;
Console.WriteLine("Ingresa el pin,El pin contiene al menos 4 digitos");
int dew = int.Parse(Console.ReadLine());
if (dew > 2039)
{
   for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Se reprodujo un pin incorrecto");
        dew = int.Parse(Console.ReadLine());
        Console.BackgroundColor = ConsoleColor.DarkRed;
    }
}
else
{
   Console.WriteLine("Sonara un beep en la consola al ingresarse un pin correcto");
   Console.Beep();
}




// Elaborar un algoritmo que pida el número final de la placa de un vehículo y permita determinar que día tiene pico y placa.

using System.Net.Sockets;
using System.Xml.Schema;

int placa = 0;
Console.WriteLine("Ingresa el numero de la placa");
placa = int.Parse(Console.ReadLine());
if (placa == 0 || placa == 1)
{
    Console.WriteLine("Tienes pico y placa el lunes");
}
if (placa == 2||placa == 7)
{
    Console.WriteLine("Tienes pico y placa el martes");
}
if (placa == 9 || placa == 4)
{
    Console.WriteLine("Tienes pico y placa el miercoles");
}
if (placa == 5 || placa == 3)
{
    Console.WriteLine("Tienes pico y placa el jueves");
}
if (placa ==  6 || placa == 8)
{
    Console.WriteLine("Tienes pico y placa el viernes");
}



// Elaborar un algoritmo que pida una letra y detecte si es una vocal.


Console.WriteLine("Escribe cualquier cosa");
string write = Console.ReadLine();
if(write != "")
{
    Console.WriteLine($"La {write} es numero");
}
else
{
    Console.WriteLine($"El {write} es numero");
}

// Elaborar un algoritmo que muestre un menú que contemple las opciones “Archivo”, “Buscar” y “Salir”, en caso de que no se introduzca una opción correcta se notificará por pantalla

Console.WriteLine("Elige una opcion \n0.Archivo \n1.Buscar \n2.Salir");
int erf = int.Parse(Console.ReadLine());
switch(erf)
{
       //Codigo que quieres colocar
      case 0:
       Console.WriteLine();
       break;
      case 1:
        Console.WriteLine();
        break;
      case 2:
        Console.WriteLine();
         break;
}


//

int NUM, AUX, DEC, UNI;
 string linea;
 Console.WriteLine ("INGRESE NÚMERO DE DOS CIFRAS :"); 
 linea = Console.ReadLine();
 NUM = int.Parse(linea);
 DEC = NUM/10;
 UNI = NUM % 10;
 AUX = (UNI * 10) + DEC;
 Console.WriteLine($"NÚMERO INVERTIDO ES: {AUX}" );


int NUM, AUX, DEC, UNI, CEN;
string linea;
Console.WriteLine("INGRESE NÚMERO DE TRES CIFRAS :");
linea = Console.ReadLine();
NUM = int.Parse(linea);
CEN = NUM / 100;
NUM = NUM % 100;
Console.WriteLine($"NÚMERO INVERTIDO ES: {NUM}");
*

Console.WriteLine("calculadora elige  una opcion\n0.suma \n1.resta \n2.multplicacion \n3.division");
int ds = Convert.ToInt32(Console.ReadLine());
if (ds == 0)
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




byte CANB, CANH, CANP;
double APAGAR;
string linea;
const double PRECIOB = 0.8;
const double PRECIOH = 2;
const double PRECIOP = 1.2;
Console.Write("CANTIDAD DE HAMBURGUESAS :"); linea = Console.ReadLine();
CANH = byte.Parse(linea);
Console.Write("CANTIDAD DE PAPAS :"); linea = Console.ReadLine();
CANP = byte.Parse(linea);
Console.Write("CANTIDAD DE BEBIDAS :"); linea = Console.ReadLine();
CANB = byte.Parse(linea);
Console.WriteLine();
APAGAR = (CANH * PRECIOH) + (CANP * PRECIOP) + (CANB * PRECIOB);
Console.WriteLine("VALOR A PAGAR: " + APAGAR);


int NUM1;
 string linea;
 long RESUL;
 Console.Write("DIGITE UN NÚMERO :"); 
 linea = Console.ReadLine();
 NUM1 = int.Parse(linea);
 RESUL = Math.Abs(NUM1);
 Console.WriteLine("VALOR ABSOLUTO : " + RESUL);




double BASE, ALTURA, RESUL;
string linea;
Console.Write("DIGITE LA BASE :"); linea = Console.ReadLine();
BASE = double.Parse(linea);
Console.Write("DIGITE LA ALTURA:"); linea = Console.ReadLine();
ALTURA = double.Parse(linea);
RESUL = (BASE * ALTURA) / 2;
Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:####.00}", RESUL));
Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:c}", RESUL));
Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:f}", RESUL));
Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:g}", RESUL));
Console.WriteLine();
Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:F}", DateTime.Now));
Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:dddd}{0:dd/MM/yyy}", DateTime.Now));



int NUM1, NUM2;
double RESUL;
string linea;
Console.Write("NÚMERO 1 :"); linea = Console.ReadLine();
NUM1 = int.Parse(linea);
Console.Write("NÚMERO 2 :"); linea = Console.ReadLine();
NUM2 = int.Parse(linea);
RESUL = (NUM1 + NUM2) * (NUM1 - NUM2);
Console.WriteLine("El resultado es : " + RESUL);



Console.WriteLine("Hola,ingresa 2 numeros");
int NUm = int.Parse(Console.ReadLine());
int NUm2 = int.Parse(Console.ReadLine());
if (NUm > NUm2)
{
    Console.WriteLine($"El numero {NUm} es mayor que {NUm2}");
}
if (NUm < NUm2)
{
    Console.WriteLine($"El numero {NUm} es menor que {NUm2}");
}
if (NUm == NUm2)
{
    Console.WriteLine($"El numero {NUm} es igual que {NUm2}");
}




byte MAY, MEN, NUM1, NUM2, NUM3;
string linea;
Console.Write("NÚMERO 1 :"); linea = Console.ReadLine();
NUM1 = byte.Parse(linea);
Console.Write("NÚMERO 2 :"); linea = Console.ReadLine();
NUM2 = byte.Parse(linea);
Console.Write("NÚMERO 3 :"); linea = Console.ReadLine();
NUM3 = byte.Parse(linea);
MAY = NUM1; MEN = NUM1;
if ((NUM2 > MAY)) MAY = NUM2;
if ((NUM3 > MAY)) MAY = NUM3;
if ((NUM2 > MEN)) MEN = NUM2;
if ((NUM3 < MEN)) MEN = NUM3;
Console.WriteLine("MAYOR ES:" + MAY);
Console.WriteLine("MENOR ES:" + MEN);




using System.Net.NetworkInformation;

int CAN, C100, C50, C20, C10, C5;
C100 = 0;
C50 = 0;
C20 = 0;
C10 = 0;
14


 C5 = 0;
string linea;
Console.Write("DIGITE UNA CANTIDAD :"); linea = Console.ReadLine();
CAN = int.Parse(linea);
if ((CAN >= 100))
{
    C100 = (CAN / 100);
    CAN = CAN - (C100 * 100);
}
if ((CAN >= 50))
{
    C50 = (CAN / 50);
    CAN = CAN - (C50 * 50);
}
if ((CAN >= 20))
{
    C20 = (CAN / 20);
    CAN = CAN - (C20 * 20);
}
if ((CAN >= 10))
{
    C10 = (CAN / 10);
    CAN = CAN - (C10 * 10);
}
if ((CAN >= 5))
{
    C5 = (CAN / 5);
    CAN = CAN - (C5 * 5);
}
Console.WriteLine("BILLETES DE A 100: " + C100);
Console.WriteLine("BILLETES DE A 50 : " + C50);
Console.WriteLine("BILLETES DE A 20 : " + C20);
Console.WriteLine("BILLETES DE A 10 : " + C10);
Console.WriteLine("BILLETES DE A 5 : " + C5);
Console.WriteLine("BILLETES DE A 1 : " + CAN);




double SUELDO, ARECIBIR;
int NHIJO, BONO;
string NOM, linea;
Console.Write("NOMBRE EMPLEADO :"); NOM = Console.ReadLine();
Console.Write("SUELDO EMPLEADO :"); linea = Console.ReadLine();
SUELDO = double.Parse(linea);
Console.Write("NÚMERO DE HIJOS :"); linea = Console.ReadLine();
NHIJO = int.Parse(linea);
if (NHIJO >= 3) { BONO = NHIJO * 10; } else { BONO = NHIJO * 20; }
ARECIBIR = SUELDO + BONO;
Console.WriteLine("RECIBE :" + String.Format("{0:c}", ARECIBIR));




int CANKV;
double TOT, COSKV;
COSKV = 0;
string linea;
Console.Write("Cantidad de Kilovatios :"); linea = Console.ReadLine();
CANKV = int.Parse(linea);
if ((CANKV <= 1000)) COSKV = 0.14;
if (((CANKV > 1000) & (CANKV <= 1800))) COSKV = 0.12;
if ((CANKV > 1800)) COSKV = 0.8;
TOT = CANKV * COSKV;
Console.WriteLine("A PAGAR: " + TOT);





int LADO1, LADO2, LADO3;
string linea;
Console.Write("DIGITE LADO 1 :"); linea = Console.ReadLine();
LADO1 = int.Parse(linea);
Console.Write("DIGITE LADO 2 :"); linea = Console.ReadLine();
LADO2 = int.Parse(linea);
Console.Write("DIGITE LADO 3 :"); linea = Console.ReadLine();
LADO3 = int.Parse(linea);

if ((LADO1 == LADO2) & (LADO2 == LADO3))
{
    Console.WriteLine("TRIÁNGULO EQUILÁTERO. TODOS IGUALES");
}
else
{
    if ((LADO1 != LADO2) & (LADO1 != LADO3) & (LADO2 != LADO3))
    {
        Console.WriteLine("TRIÁNGULO ESCALENO. NINGUNO IGUAL");
    }
    else
    {
        Console.WriteLine("TRIÁNGULO ISÓSCELES. DOS IGUALES");
    }
}



Console.Write("Ingresa un nombre");
string NOMbre = Console.ReadLine();
if (NOMbre == "David")
{
    Console.WriteLine("Hola David bienvenido");
}
else
{
    Console.WriteLine("Nombre de usuario incorrecto");
}



Console.WriteLine("Ingresa un numero del 1 al 7 para elegir un dia de la semana");
int days = int.Parse(Console.ReadLine());
switch (days)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miercoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sabado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
}


char ECIVIL;
string linea;
Console.Write("DIGITE C,S,V,D :"); linea = Console.ReadLine();
ECIVIL = char.Parse(linea);
switch (ECIVIL)
{
    case 'C':
        ; Console.WriteLine("CASADO");
        break;
    case 'S':
        ; Console.WriteLine("SOLTERO");

        break;
    case 'V':
        ; Console.WriteLine("VIUDO");
        break;
    case 'D':
        ; Console.WriteLine("DIVORCIADO");
        break;
    default:
        Console.WriteLine("NO EXISTE");
        break;
}



int NOTA;
string linea;
Console.Write("DIGITE CALIFICACIÓN:"); linea = Console.ReadLine();
NOTA = byte.Parse(linea);
switch (NOTA)
{
    case 19:
    case 20:
        ; Console.WriteLine("SOBRESALIENTE");
        break;
    case 16:
    case 17:
    case 18:
        ; Console.WriteLine("MUY BUENA");
        break;
    case 14:
    case 15:
        ; Console.WriteLine("BUENA");
        break;
    case 12:
    case 13:
        ; Console.WriteLine("REGULAR");
        break;
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    case 6:
    case 7:
    case 8:
    case 9:
    case 10:
    case 11:
        Console.WriteLine("INSUFICIENTE");
        break;
    default:
        Console.WriteLine("FUERA DE RANGO");
        break;
}





char TECLA;
 string linea;
Console.Write("DIGITE UNA SOLA TECLA");
Console.WriteLine();
linea = Console.ReadLine();
TECLA = char.Parse(linea);
switch (TECLA)
{
    case '1':
    case '2':
    case '3':
    case '4':
    case '5':
    case '6':
    case '7':
    case '8':
    case '9':
        ; Console.WriteLine("ES UNA CIFRA NUMERICA");
        break;
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        ; Console.WriteLine("ES UNA VOCAL");
        break;
    default:
        Console.WriteLine("ES UNA CONSONANTE");
        break;
}



int nuM = 0;
Console.WriteLine("Digite un numero");
nuM = int.Parse(Console.ReadLine());
for (int i = 1; i <= 10;i++)
{
    Console.WriteLine("{0}*{1}={2}",nuM,i,nuM*i);
}


double CANP, TOT, PORC;
string AREA, linea;
byte CAN, I;
 Console.Write("CUANTOS CALCULOS: "); linea = Console.ReadLine();
CAN = byte.Parse(linea);
Console.Write("DIGITE TOTAL DEL PRESUPUESTO: "); linea = Console.ReadLine();
CANP = double.Parse(linea);
for (I = 1; I <= CAN; I++)
{
    Console.Write("DIGITE ÁREA: "); AREA = Console.ReadLine();
    switch (AREA.ToUpper())
    {
        case "GINECOLOGIA":
            ; PORC = 40;
            break;
        case "TRAUMATOLOGIA":
            ; PORC = 30;
            break;
        case "PEDIATRIA":
            ; PORC = 30;
            break;
        default:
            PORC = 0;
            break;
    }
    TOT = (CANP * PORC) / 100;
    Console.WriteLine(AREA + " RECIBE " + String.Format("{0:C}", TOT));
}





byte NUM, I;
int SUMP = 0;
int SUMI = 0;
string linea;
Console.Write("NÚMERO MÁXIMO: "); linea = Console.ReadLine();
NUM = byte.Parse(linea);
for (I = 1; I <= NUM; I += 2)
{
    SUMP = SUMP + I;
}
for (I = 2; I <= NUM; I += 2)
{
    SUMI = SUMI + I;
}
Console.WriteLine("TOTAL EN PARES : " + SUMP);
Console.WriteLine("TOTAL EN IMPARES : " + SUMI);
Console.Write("Pulse una Tecla:"); Console.ReadLine();
*/













































































