# ExamenIngreso

Respuestas:

PARTE F - 1 ¿Cómo se podría establecer a estos objetos como imprimibles?. 
- Si nos referimos a agregarle una funcionalidad extra, la manera de hacerlo seria mediante interfaces. Creando una nueva interface IPrintable y luego que las clases necesarias implementen la interfaz.

Por favor, especifica tu nombre completo: Franco Adrian Correia

¿C# permite herencia múltiple?

-No, cada clase puede heredar de una sola clase padre.

¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.

-Implementaria una clase abstracta sobre una interfaz si tuviera que utilizar no solo firmas de funcion sino tambien atributos, propiedas, metodos con cuerpo, etc.
Un ejemplo podria ser una clase abstracta Enemy que contenga metodos como Movimiento y Morir, y atributos como la velocidad y la vida. En un caso de Interfaz podria ser una interfaz IHitable para que todo objeto que yo quiera que sea golpeable tenga que implementar esta funcionalidad.

¿Qué implica una relación de Generalización entre dos clases?

Implica herencia, donde la subclase se considera como forma especializada de la clase padre. Esta ultima se considera como generalización de la subclase y la subclase se considera una especialización de la clase padre.

¿Qué implica una relación de Implementación entre una clase y una interfaz?

Que la clase que implementa la Interfaz esta obligada a implementar todas las firmas de metodos que contiene esta y ademas darle un cuerpo.

¿Qué diferencia hay entre la relación de Composición y la Agregación?

La composicion es una forma de Agregacion con una fuerte relacion de pertenencia. Por ende en la Composicion el TODO es responsable de disponer de sus PARTES y por ende si el TODO no existe, tampoco sus PARTES.
En la Agregacion la existencia de uno no implica la existencia del otro.

Indique V o F según corresponda. Diferencia entre Asociación y Agregación:

Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual.
[V]

Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1. 
[F]

Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación. 
[F]
