# AppHours
Cálculo de horas extras

# Console
Aplicación de consola (.NET) c#

Requiere un archivo .txt en la Partición (D:) con el nombre test.txt con la respectiva información del nombre de un empleado y el horario de trabajo, 
indicando el tiempo y las horas.

Formato: RENE=MO10:00-12:00,TU10:00-12:00,TH01:00-03:00,SA14:00-18:00,SU20:00-21:00

# Descripción
Se define una interfaz ILectura para la lectura y la descomposición de las línea de información

La clase textService que implementa la interfaz ILectura para leer el archivo .txt

Las clases weekendModel y weekModel heredan de la clase week la cual contiene una lista de datos de los valores de horas, cada clase tiene como atributos los valores 
por rangos de horas en cada día

La clase Persona Model contiene nombres, valor total de horas y la lista de rangos de horas realizadas

#
Al realizar la lectura del archivo, cada línea de entrada se separa en subcadenas por expresiones de patrones regulares (= , -) hasta descomponer y obtener una
Lista de empleados con sus nombres y rango de horas realizadas diario.

El calculo de horas se realiza recorriendo los rangos de horas por cada empleado, calculando el total de horas realizadas y obteniendo el valor que le corresponde de 
las clases weekend o week


