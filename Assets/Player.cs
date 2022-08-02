using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num = 4;
        bool check = true;
        int enemyDamage = 60;
        int life = 50;
        //comprobaciones:  <(menor que)    >(mayor que)   <=(menor o igual que)  >= (mayor o igual que)
        check = life <= enemyDamage;
        print("el enemigo murió?" + check);
        // +: concatenar (sumar)
        //comprobaciones: == (igual) != (distinto)
        // life== enemyDamage ---> False 
        // life != enemyDamage ---> True
        // !: negar (opuesto). Por ejemplo:bool check = true; --> !check= false;
        print(num);
        // Dado el daño base de un personaje, realice un programa que calcule su daño
        //crítico sabiendo que la fórmula es:
        //DC = (daño base)² + 80 % del daño base
        float dañoCritico = (enemyDamage * enemyDamage) + (enemyDamage * 0.8f);
        print("el daño crítico es " + dañoCritico);
        print("el daño base del enemigo es " + enemyDamage);

        //Dada la vida de un personaje, indique si es urgente curarlo o no (true / false),
        //teniendo en cuenta que si tiene menos del 30 % debe ser curado, su vida
        //máxima es de 150.

        float McLife = 150;
        float dañoRecibido = 150;
        bool cura = true;
        if (dañoRecibido > (McLife * 0.3f))
        {
            print("hay que curar? " + check);
        }
        else
        {
            print("no hace falta curarse");
        }
        if ((dañoRecibido - McLife) <=0)
        {
            cura = false;
            print("está muerto " + cura);
        }
        //if(condición o comprobación)
        //{ 
        //Hacer una cosa;
        //}
        // si se hace un print en el if, y la condición es verdadera, se imprime ese mensaje
        // si se hace además, un print fuera del if, este se ejecuta después de un if verdadero, o solo si la condición del if es falsa.
        // else (es el caso contrario a la condición del if)
        // {
        // Hacer otra cosa;
        // }
        //else if:
        //  if ()
        //  {
        //      realizar
        //  }
        //  else
        //  {
        //      if ()
        //          {
        //          }
        //
        //  }

        //1- En el sistema interno de un juego de estrategia, se genera un número entero positivo que
        //se usa para determinar el camino que tomara una IA.
        //Debemos indicar si el número ingresado es par, ya que de serlo la IA tomara una acción
        //diferente a la estipulada de forma convencional.

        //2- En un juego de cartas donde existen criaturas que tienen un determinado ataque, tenemos
        //la situación en la que dos de estos se ven enfrentados y se tiene que indicar lo siguiente:         
        //a.Si el ataque de las dos es igual: “Se destruyeron ambas criaturas.”
        //b.Si el ataque del primero es mayor al del segundo: “El primero aniquilo al segundo.”
        //c.Si el ataque del segundo es mayor al del primero: “El segundo aniquilo al primero.”

        //3- Estamos desarrollando un juego que tiene un sistema de log interno y necesitamos
        //comprobar si el nombre de usuario ingresado es igual al de la base de datos. En caso de
        //serlo indicar <“Hola” mas su nombre de usuario >.Caso contrario indicar “El nombre de
        //usuario no es correcto.”

        //4- En un juego donde se define al ganador según los puntos que adquiere durante la partida,
        //existe un potenciador de puntos que aparece una sola vez por partida y cuyo efecto es
        //multiplicar por tres los puntos actuales del jugador y sumarle la mitad de sus puntos
        //originales.
        //Tenga en cuenta que el potenciador solo surte efecto si el jugador tiene por lo menos 250
        //puntos.


    }

    // Update is called once per frame
    void Update()
    {

    }
}
