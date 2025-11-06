# Gestion_Hospital

Aplicación de escritorio desarrollada en C# con Windows Forms para gestionar pacientes e ingresos hospitalarios. Permite registrar, editar y controlar los ingresos de pacientes, asegurando la integridad de los datos.

---

## 📋 Características principales

### 👤 Gestión de Pacientes
- Registro de pacientes con nombre, apellidos y edad.
- Validación de edad entre 1 y 120 años.
- Edición y eliminación de pacientes.
- Visualización clara de los datos del paciente.

### 🛏️ Gestión de Ingresos
- Registro de ingresos hospitalarios con:
  - Fecha de ingreso
  - Fecha de alta (opcional)
  - Motivo del ingreso
  - Habitación asignada
  - Especialidad médica
- Edición y eliminación de ingresos.
- Visualización en tabla con todos los ingresos del paciente.

---

## ✅ Validaciones implementadas

### 🔒 Reglas de negocio
- **Un solo ingreso activo por paciente**: no se permite registrar un nuevo ingreso si el paciente ya tiene uno sin fecha de alta.
- **Control al editar ingresos**: no se puede quitar la fecha de alta si el paciente ya tiene otro ingreso activo.
- **Fechas coherentes**: la fecha de alta no puede ser anterior a la fecha de ingreso.
- **Validación de edad**: la edad del paciente debe estar entre **1 y 120 años**. Si no se cumple, se muestra un mensaje de error y no se guarda.
- **Campos obligatorios en pacientes**: no se permite guardar un paciente si el nombre o los apellidos están vacíos o contienen solo espacios.
- **Campos obligatorios en ingresos**: motivo, habitación y especialidad deben estar completos.

### 📅 Fechas
- Se permite que la fecha de ingreso y la fecha de alta sean el mismo día.
- La comparación de fechas ignora la hora para evitar errores por minutos distintos.
- Los controles `DateTimePicker` están configurados en formato `Short` para mostrar solo la fecha.

---

## 🧠 Estructura del código

- `Paciente.cs` y `Ingreso.cs`: clases modelo que representan los datos.
- `Form1.cs`: formulario para ver los pacientes en DataGridView, ver estadisticas generales (total pacientes, edad media, total de ingresos e ingresos activos) y acceder a los otros formularios.
- `frmPaciente.cs`: formulario para gestionar pacientes (agregar/editar paciente).
- `frmIngresos.cs`: formulario para visualizar en DataGridView y administrar ingresos de un paciente.
- `frmIngreso.cs`: formulario para crear o editar un ingreso.

---

## 🧪 Recomendaciones técnicas

- Comparar fechas usando `.Date` para evitar errores por diferencias de hora.
- Evitar el uso de `return;` suelto en métodos, siguiendo buenas prácticas de control de flujo con variables booleanas.
- Validar todos los campos antes de guardar para evitar inconsistencias.

---


Desarrollado por **Alex**  
Proyecto académico — Gestión hospitalaria con C# y Windows Forms