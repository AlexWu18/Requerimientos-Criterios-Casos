### 10. Tomando el algoritmo de conversión de números arábigos o "decimales" a números Romanos
1. Cree un documento donde se listen los Requerimientos, Criterios de Aceptación y Casos de Prueba para una aplicación de consola.
2. Los casos de prueba deben ser de dos categorías: End-To-End (desde el UI) y Unitarios (caja blanca, código, bajo nivel).

**Requerimientos:**
* Los números Romanos específicos no se pueden repetir más de 3 veces.
* Asignar valores específicos a las distintas letras romanas.
* Los números romanos V, L y D no pueden repetirse nunca.
* Si un número romano compuesto tiene un número a la derecha menor que el de la izquierda entonces se suman ambos.

**Criterios de Aceptación:**
* El usuario debe evitar utilizar símbolos y solo podrá usar números.
* El algoritmo debe tener sentido al momento de convertir los números.
* El algoritmo debe calcular cada número y poder convertirlo en Romano.

**Caso de prueba:**

| **Validación de las letras Romanas** |
|--------------------------------------------------------------------------------------------------------|
| **Objetivo:**	La conversión de los valores decimales tenga relación con respecto a sus respectivas letras. |
| **Identificador:**	CSP01 |
| **Precondiciones:**	Ninguno |

| Pasos	| Resultado esperado |
|-------|:------------------:|
|1) Ingresar cualquier valor que se desea convertir.| 	Se coloque los números ingresados por el usuario|
|2) Presionar siguiente|	Se debe mostrar el resultado convertido.|

**Caso de prueba código:**

''' C#
 [TestMethod]
        public void RomanTest_3_III()
        {
            Assert.AreEqual("MMCMLVIII", NumeroArab.To(2958));
        }
'''

