# pav-application
Repositorio con el objetivo de alojar el Trabajo Práctico Integrador de la cátedra Programación de Aplicaciones Visuales 1. 

Aplicación de escritorio realizada en .NET usando C#.

Materia: Programación de Aplicaciones Visuales 1.
Curso: 3K5
Integrante: Marco Marchetti
Legajo: 67559

# Empresa: Methfarbi
# Rubro: Metalurgica

# Descripción:
Metfarbi es una fábrica metalúrgica dedicada a la producción de piezas a medida. El proceso comienza cuando un cliente solicita un pedido de piezas, a lo que se procede a crear una Orden de Trabajo en estado Generada, indicando sus detalles, los cuales señalan por qué máquinas tendrán que pasar las piezas durante su producción, durante cuanto tiempo estimado de trabajo, y también, el tiempo de calibración estimado. Una vez creada la Orden de Trabajo se calcula el precio total estimado y se le informa al cliente, si este acepta, la OT pasa a Cotizada y ya está lista para que empiece el proceso de producción. A medida que los operarios vayan terminando los trabajos (detalles de OT) se irá actualizando la Orden de Trabajo, y así sucesivamente hasta que se finalicen todos sus detalles, por lo cual, la OT pasa  Finalizada. 

# Alcances: 
Los alcances del sistema irán desde la creación de una Orden de Trabajo junto a sus detalles hasta la aceptación de la Orden de Trabajo, su seguimiento, y su finalización.

# Transacción principal:

Orden de Trabajo 

# ABMs:

Maquinas
Empleados
Responsables de Empresas
Clientes

# Reportes:

Reporte de diferencia entre horas estimadas y horas reales de trabajo.
Reporte de utilización por horas de máquinas.
