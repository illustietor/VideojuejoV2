using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMjProgramarTutorial : MonoBehaviour {

    //¡Hola mundo!
    //Este es el tutorial de programación.
    //Aunque ya sepas programar te recomiendo echarle un vistazo.
    //No te preocupes: no es muy largo y este programa es muy sencillo de usar.
    //¡Pero tampoco te confies!
    //Siguen haciendo falta mucha práctica y vocabulario para dominarlo.

    //¿Que tal si empiezas escribiendome tu nombre?
    //Haz clic encima del texto resaltado y escribe.
    //Cuando termines pulsa la tecla ENTER o haz click fuera de la palabra.
    string tuNombre = "Nombre to guapo y to largo";


    //Vaya, acabas de guardar tu nombre en una variable.
    //¿Que qué leches es una variable?
    //Pues las variables son como cajitas que guardan cosas.
    //El problema es que cada cosa debe guardarse en un tipo de cajita concreta.

    //Por un lado tenemos el STRING donde se guarda el texto o conjunto de caracteres.
    //Pero si no queremos meterlos todos en la misma caja...
    //Siempre podemos guardarlos uno a uno en variables de tipo CHAR.
    //Las variables de tipo CHAR solo pueden guardar un caracter.
    //Un caracter es cualquier simbolo que puedes introducir con tu teclado.

    //Por ejemplo, si has introducido tu nombre antes:
    //Yo he preparado una caja tipo STRING.
    //Además la he nombrado "tuNombre" para acordarme de que valor estoy guardando ahí.
    //Seguramente habrás introducido un conjunto de caracteres, es decir, un STRING.
    //En cambio, si por lo general los nombres se compusieran por un solo caracter...
    //Me hubiera sido mas eficiente guardar tu nombre en una variable tipo CHAR.

    //¿Cual es la primera letra de tu apellido?
    char tuLetra = 'L';


    //Si durante el paso anterior te ha entrado curiosidad con lo que ya te he contado...
    //Es probable que te hayas puesto a escribir otras cosas...
    //Habrás podido comprobar que puedes introducir cualquier caracter de tu teclado.
    //PUES CON LAS VARIABLES DE LOS NÚMEROS NO PUEDES HACER ESO.
    int enteros = 123456;
    float decimales = 0.123456F;


    //Eso es, en las variables de INT y FLOAT solo puedes poner numericos.
    //En las de tipo INT solo puedes introducir numeros enteros. Nada de decimales.
    //Y es que para meter decimales tenemos las variables de tipo FLOAT.
    //¿Que por qué hay una para cada cosa?
    //Búscalo luego en Google que ahora no da tiempo.
    //Aquí lo importante es que sepas:
        //1. Reconocer cada tipo de valor
        //2. Asignarle el tipo correspondiente.
    
    //Prueba estos ejercicios a ver si te has enterado bien:

    string Ejercicio1 = "¿Que es esto?";
    char Ejercicio2 = '?';
    int Ejercicio3 = 69;
    float Ejercicio4 = 3.14F;

    //Si está bien hecho las palabras se ponen en amarillo.
    //Si está mal hecho las palabras se ponen en rojo.

    //Si crees que estás escribiendo bien las respuestas pero te sigue dando error...
    //Es posible que se me haya olvidado remarcarte algo muy importante...
    //Al final de la mayoría de líneas de código hay que escribir ";".
    //Los STRINGS siempre van entrecomilldos con comillas dobles >> "string".
    //Los CHAR por otro lado hay que entrecomillarlos con comillas simples >> 'C'
    //Y los FLOAT deben ir acompañados siempre por una F al final >> 0.5F
    //Prueba otra vez a ver si ahora te furula.

    //En programación es importante introducir el codigo ¡SIN FALTAS!
    //Si te equivocas introduciendo alguna letra el ordenador no sabrá interpretarlo...
    //Si el ordenador no lo interpreta seguramente algo te acabará fallando...
    //(Peores cosas se pueden hacer).

    //Como programador no solo te tocará introducir texto...
    //Tambien tendrás que CORREGIR los errores de otros.
    //Nadie es perfecto y cualquiera puede cometer fallos.
    //No la pagues mucho contigo mismo o con los demás.
    //Menos mal que tienes este avanzadísimo software de programación ¿eh?
    //Yo detecto todos lo errores por ti y así solo te encargas de corregirlos.
    //¡Hasta soy capaz de romper las reglas lógica computacional!
    //Todo con tal de hacerte la programación más fácil y divertida.

    //Recuerda que puedes acceder al Glosario haciendo click sobre el botón "GLOSARIO".
    //Ahí puedes consultar dudas sobre vocabulario y funciones de programación.
    //Ya se que al principio puede ser tedioso tener que estar consultandolo...
    //¡Pero ya verás como con el tiempo te las acabarás aprendiendo todas de memoria!


    //Y de regalo para terminar voy a explicarte qué son LOS BOOLEANOS.
    //(Que nombre tan gracioso tienen, ¿eh? Booleanos. Boooooooooooole...anos. Je je).
    //Los BOOLEANOS son variables que solo pueden guardar dos valores: "true" y "false".
    //Se usan para hacer preguntas con solo dos respuestas posibles.
    //"True" significa "verdadero" y quiere decir que la respuesta es verdadera.
    //"False" significa "falso" y quiere decir que la respuesta es falsa.

    //Por ejemplo:
    bool sumaVerdadera = 2 + 2 == 4;

    //En este caso concreto estamos preguntando si "2+2 (¿es igual a...?) 4".
    //Como probablemente ya sepas si tienes un mínimo de conocimientos matemáticos...
    //Sí: "2 + 2" es igual a "4", y por lo tanto "sumaVerdadera = true".
    //¿Facil de entender no?
    bool facilDeEntender = true;

    //¡Ah! ¡Y que casi se me olvida!
    //¿Ves ese botón grandote que pone "START"?
    //Está pensado para que lo uses cuando acabas de programar el juego pero...
    //¡Puede ser interesante que lo uses mientras programas!
    //Y es que por muy inteligente que te creas a la hora de diseñar el juego...
    //Muchas mecánicas de juego sólo se pueden llegar a pulir jugando.

    //Ahora sí, eso es todo ¡mucho ánimo y buena suerte!

}
