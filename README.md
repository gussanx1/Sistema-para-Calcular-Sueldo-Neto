# 💼 Sistema de Cálculo de Sueldos - Patrón Estrategia y MVC

## 📖 Caso de Estudio: Laboratorio 15

Este proyecto desarrolla un sistema para calcular los sueldos netos de trabajadores de una empresa transnacional. El cálculo se basa en la categoría del trabajador: **Administrativo**, **Operario**, u **Obrero**. Se utiliza el **Patrón Estrategia** para modelar las reglas de negocio y el **Patrón MVC** para la implementación en **Visual C#**, con una base de datos en **SQL Server**.

---

## 🧮 Reglas de Negocio

### 1. **Categorías de Trabajadores**
- **Administrativo (Adm)**
- **Operario (Ope)**
- **Obrero (Obr)**

### 2. **Cálculo del Sueldo Neto**

#### **Administrativo**
- **Descuentos**:
  - AFP: 13% del sueldo básico.
  - 5ta. Categoría: 10% del sueldo básico.
- **Incrementos**:
  - Bono de productividad: 8% del sueldo básico.
  - Carga social: 5% del sueldo básico.

#### **Operario**
- **Descuentos**:
  - AFP: 10% del sueldo básico.
  - 5ta. Categoría: 8% del sueldo básico.
- **Incrementos**:
  - Bono de productividad: 6% del sueldo básico.
  - Carga social: 3% del sueldo básico.

#### **Obrero**
- **Descuentos**:
  - AFP: 7% del sueldo básico.
  - 5ta. Categoría: 4% del sueldo básico.
- **Incrementos**:
  - Bono de productividad: 4% del sueldo básico.
  - Carga social: 2% del sueldo básico.

---

## 🖥️ Implementación del Sistema

### **Diagrama de Clases**
Se utiliza el **Patrón Estrategia** para encapsular las reglas de cálculo de sueldos en diferentes estrategias, dependiendo de la categoría del trabajador.

- **Clase Base:** `Trabajador`
  - Atributos: `Categoria`, `Basico`, `Descripcion`.
  - Operaciones: `CalcularSueldoNeto()`.
- **Estrategias:** `SueldoAdministrativo`, `SueldoOperario`, `SueldoObrero`.

### **Arquitectura MVC**
1. **Modelo:**
   - Representa la tabla `Trabajador` de la base de datos **Empresa**.
   - Campos: `Categoria`, `Basico`, `Descripcion`.

2. **Vista:**
   - Formulario que permite:
     - Seleccionar una categoría de trabajador.
     - Calcular y mostrar:
       - Sueldo Básico.
       - Descuento por AFP.
       - Descuento por 5ta. Categoría.
       - Incremento por Productividad.
       - Incremento por Carga Social.
       - Sueldo Neto.

3. **Controlador:**
   - Gestiona la lógica del sistema y conecta la vista con el modelo.

---

## 🛢️ Base de Datos

- **Nombre de la Base de Datos:** `Empresa`
- **Tabla:** `Trabajador`
- **Estructura:**

| Campo         | Tipo de Dato     | Descripción       |
|---------------|------------------|-------------------|
| `Categoria`   | `VARCHAR(3)`     | Categoría del trabajador (Adm, Ope, Obr). |
| `Basico`      | `FLOAT`          | Sueldo básico del trabajador.            |
| `Descripcion` | `VARCHAR(20)`    | Descripción de la categoría.             |

- **Datos Iniciales:**

| Categoria | Basico | Descripcion    |
|-----------|--------|----------------|
| Adm       | 5000   | Administrativo |
| Ope       | 3000   | Operario       |
| Obr       | 2000   | Obrero         |

---

## 🚀 Requisitos del Sistema

1. **Lenguaje:** Visual C#.
2. **Base de Datos:** SQL Server.
3. **IDE:** Visual Studio.
4. **Modelo de Arquitectura:** MVC.

---

## 📌 Pasos para la Ejecución

1. Crear la base de datos `Empresa` y la tabla `Trabajador` en **SQL Server**.
2. Insertar los datos iniciales en la tabla.
3. Diseñar el diagrama de clases usando el **Patrón Estrategia**.
4. Implementar el sistema en **Visual C#** siguiendo el **Patrón MVC**.
5. Probar el formulario seleccionando categorías y verificando cálculos.

---

## 📋 Resultados Esperados

- Calcular correctamente el **sueldo neto** del trabajador según su categoría.
- Visualizar los detalles de cálculo:
  - Sueldo Básico.
  - Descuentos (AFP, 5ta. Categoría).
  - Incrementos (Productividad, Carga Social).
  - Sueldo Neto final.
- Proveer una interfaz amigable para los usuarios y una base de datos confiable.

---

## 🔗 Recursos Entregables

1. **Diagrama de Clases:** En formato PDF.
2. **Código Fuente:** Archivos de Visual C# implementando el sistema.
3. **Base de Datos:** Script SQL para la tabla `Trabajador`.


