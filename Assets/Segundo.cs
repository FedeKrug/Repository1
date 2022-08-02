using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1- En el sistema interno de un juego de estrategia, se genera un número entero positivo que
        //se usa para determinar el camino que tomara una IA.
        //Debemos indicar si el número ingresado es par, ya que de serlo la IA tomara una acción
        //diferente a la estipulada de forma convencional.

        int num = 5;
        
        if (num % 2 == 0)
        {
            print("es par, se ejecuta IA");
        }
        else
        {
            print("IA es impar, se queda quieto");
        }
        // x % y == z (x dividido y da resto z)


        //2- En un juego de cartas donde existen criaturas que tienen un determinado ataque, tenemos
        //la situación en la que dos de estos se ven enfrentados y se tiene que indicar lo siguiente:         
        //a.Si el ataque de las dos es igual: “Se destruyeron ambas criaturas.”
        //b.Si el ataque del primero es mayor al del segundo: “El primero aniquilo al segundo.”
        //c.Si el ataque del segundo es mayor al del primero: “El segundo aniquilo al primero.”

        float ataqueCriaturaOne = 0;
        float ataqueCriaturaTwo = 5;

        if (ataqueCriaturaOne == ataqueCriaturaTwo)
        {
            print("Ambas criaturas se mueren");
        }
        else
        {
            if (ataqueCriaturaOne> ataqueCriaturaTwo)
            {
                print("La primera criatura mató a la segunda");
            }
        }
        if (ataqueCriaturaOne<ataqueCriaturaTwo) 
        {
            print("La segunda criatura mató a la primera");
        }



        //3- Estamos desarrollando un juego que tiene un sistema de log interno y necesitamos
        //comprobar si el nombre de usuario ingresado es igual al de la base de datos. En caso de
        //serlo indicar <“Hola” mas su nombre de usuario >.Caso contrario indicar “El nombre de
        //usuario no es correcto.”
        string nombre;
        nombre = "Fede";
        string usuario ="Fedde";
        if (nombre==usuario)
        {
            print("Hola "+ nombre);
        }
        else
        {
            print("El nombre de usuario no es correcto");
        }

        //4- En un juego donde se define al ganador según los puntos que adquiere durante la partida,
        //existe un potenciador de puntos que aparece una sola vez por partida y cuyo efecto es
        //multiplicar por tres los puntos actuales del jugador y sumarle la mitad de sus puntos
        //originales.
        //Tenga en cuenta que el potenciador solo surte efecto si el jugador tiene por lo menos 250
        //puntos.

        float puntosOne = 250;
        float potenciador = puntosOne * 3 + (puntosOne * 1.5f);

        if (puntosOne >= 250)
        {
            print("se activa el potenciador" + potenciador);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
