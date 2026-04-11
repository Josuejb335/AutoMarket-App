# Documentación AutoMarket - Sistema de Gestión de Venta de Vehículos

## Índice
1. [Visión General del Sistema](#1-visión-general-del-sistema)
2. [Arquitectura](#2-arquitectura)
3. [Aplicación Servidor](#3-aplicación-servidor)
4. [Aplicación Cliente](#4-aplicación-cliente)
5. [Comunicación TCP](#5-comunicación-tcp)
6. [Base de Datos](#6-base-de-datos)
7. [Guía de Instalación y Configuración](#7-guía-de-instalación-y-configuración)
8. [Instrucciones de Uso](#8-instrucciones-de-uso)
9. [Solución de Problemas](#9-solución-de-problemas)

---

## 1. Visión General del Sistema

**AutoMarket** es un sistema de escritorio Windows desarrollado en C# (.NET Framework 4.7.2) para la gestión de ventas de vehículos. El sistema utiliza una arquitectura cliente-servidor con comunicación TCP/IP para permitir que múltiples clientes se conecten al servidor central.

### Funcionalidades Principales

**Servidor:**
- Gestión de vehículos, sucursales, categorías, vendedores y clientes
- Visualización de estadísticas y gráficos
- Monitoreo de recursos del sistema (CPU, RAM)
- Control de inventario por sucursal
- Procesamiento de ventas

**Cliente:**
- Consulta de sucursales disponibles
- Visualización de vehículos por sucursal
- Compra de vehículos
- Historial de compras personales

---

## 2. Arquitectura

El sistema está organizado en capas separadas siguiendo el patrón de arquitectura por capas.

### Proyectos/Capas

| Proyecto | Descripción |
|----------|-------------|
| `AppServidor` | Aplicación Windows Forms del servidor administrativo |
| `AppCliente` | Aplicación Windows Forms para clientes |
| `ComunicacionServidor` | Biblioteca de clases para comunicación TCP |
| `Logica` | Lógica de negocio y validaciones |
| `AccesoDatos` | Acceso a base de datos SQL Server |
| `CapaEntidades` | Clases de entidades (POCOs) |
| `Utilidades` | Utilidades compartidas (Logger, monitoreo, etc.) |

---

## 3. Aplicación Servidor

### 3.1 Estructura

```
AppServidor/
├── Program.cs                    # Punto de entrada
├── App.config                    # Configuración (cadena de conexión)
├── Presentacion/
│   ├── FrmMenuServidor.cs        # Formulario principal MDI
│   ├── FrmContHome.cs            # Dashboard con estadísticas
│   ├── FrmContConsultas.cs       # Consultas paginadas
│   ├── FrmContRecursos.cs       # Monitoreo de hardware
│   └── Presentacion_Registro/    # UserControls de registro
│       ├── ucRegistroCat.cs      # Categorías
│       ├── ucRegistroClie.cs     # Clientes
│       ├── ucRegistroSuc.cs      # Sucursales
│       ├── ucRegistroVeh.cs      # Vehículos
│       ├── ucRegistroVen.cs      # Vendedores
│       └── ucRegistroVehxSuc.cs  # Inventario por sucursal
```

### 3.2 Componentes Principales

#### ServidorSocket (`ComunicacionServidor/ServidorSocket.cs`)

Gestiona las conexiones TCP de los clientes:

```csharp
// Constantes configurables
private const string IP_SERVIDOR = "127.0.0.1";  // IP del servidor
private const int PUERTO = 15500;                // Puerto TCP
private const int MAX_CLIENTES = 10;             // Límite de conexiones
```

**Métodos principales:**
- `Iniciar()` - Inicia el servidor TCP
- `Detener()` - Detiene el servidor y cierra conexiones
- `EscucharConexiones()` - Hilo que acepta nuevas conexiones
- `AtenderCliente()` - Hilo individual para cada cliente
- `ProcesarMensaje()` - Procesa las peticiones entrantes

#### GestorRegistros (`Logica/GestorRegistros.cs`)

Maneja la inserción de datos con validaciones:
- `InsertarCategoria()` - Registra categorías de vehículos
- `InsertarCliente()` - Registra clientes nuevos
- `InsertarSucursal()` - Registra sucursales
- `InsertarVehiculo()` - Registra vehículos
- `InsertarVendedor()` - Registra vendedores
- `InsertarVenta()` - Registra ventas
- `InsertarVehiculoxSucursal()` - Gestiona inventario
- `ProcesarCompraTCP()` - Procesa compras desde clientes remotos (thread-safe)

#### GestorConsultas (`Logica/GestorConsultas.cs`)

Maneja las consultas a la base de datos:
- Listados paginados de todas las entidades
- Consultas para gráficos y estadísticas
- Métodos específicos para TCP (cliente-servidor)

#### MonitorHardware (`Utilidades/MonitorHardware.cs`)

Monitorea el uso de recursos del sistema:
- Uso de CPU
- Uso de memoria RAM
- Uso de Red

### 3.3 Acciones TCP Soportadas

| Acción | Descripción |
|----------|-------------|
| `VERIFICAR_ID` | Verifica si existe un cliente por identificación |
| `COMPRAR_VEHICULO` | Procesa una compra de vehículo |
| `CONSULTAR_SUCURSALES` | Devuelve lista de sucursales |
| `CONSULTAR_VEHICULOS_SUCURSAL` | Devuelve vehículos de una sucursal |
| `CONSULTAR_MIS_COMPRAS` | Devuelve historial de compras del cliente |

---

## 4. Aplicación Cliente

### 4.1 Estructura

```
AppCliente/
├── Program.cs                    # Punto de entrada
├── App.config                    # Configuración
├── Presentacion/
│   ├── FrmMenuCliente.cs         # Formulario principal
│   ├── UcLogin.cs               # Login con identificación
│   ├── UcHome.cs                # Pantalla de bienvenida
│   ├── UcConsulta.cs            # Consulta de sucursales/vehículos
│   └── UcCompra.cs              # Proceso de compra
└── Red/
    └── ClienteSocket.cs           # Gestión de conexión TCP
```

### 4.2 Flujo de Uso Cliente

1. **Login**: El cliente ingresa su identificación
2. **Verificación**: El sistema verifica si existe en la base de datos
3. **Home**: Pantalla de bienvenida con opciones
4. **Consulta**: Ver sucursales y vehículos disponibles
5. **Compra**: Seleccionar vehículo y procesar compra

### 4.3 ClienteSocket (`AppCliente/Red/ClienteSocket.cs`)

Gestiona la conexión TCP con el servidor:

```csharp
// Constantes configurables
private const string IP = "127.0.0.1";  // IP del servidor
private const int PUERTO = 15500;       // Puerto del servidor
```

**Métodos:**
- `Conectar(identificacion)` - Establece conexión y envía ID
- `EnviarPeticion(mensaje)` - Envía peticiones y recibe respuestas
- `Desconectar()` - Cierra la conexión

---

## 5. Comunicación TCP

### 5.1 Protocolo de Mensajes

Los mensajes se intercambian en formato JSON con la siguiente estructura:

```csharp
public class Mensaje
{
    public string Accion { get; set; }  // Tipo de operación
    public string Tipo { get; set; }    // OK / ERROR
    public string Datos { get; set; }   // Payload (JSON serializado)
}
```

### 5.2 Ejemplo de Flujo

**1. Conexión Cliente-Servidor:**
```json
// Cliente → Servidor
{
    "Accion": "CONECTAR",
    "Tipo": "",
    "Datos": "1234567890"
}

// Servidor → Cliente
{
    "Accion": "OK",
    "Tipo": "Conexion",
    "Datos": "Bienvenido"
}
```

**2. Consultar Sucursales:**
```json
// Cliente → Servidor
{
    "Accion": "CONSULTAR_SUCURSALES",
    "Tipo": "",
    "Datos": ""
}

// Servidor → Cliente
{
    "Accion": "CONSULTAR_SUCURSALES",
    "Tipo": "OK",
    "Datos": "[{\"IdSuc\":1,\"NombreSuc\":\"San José\"},...]"
}
```

**3. Comprar Vehículo:**
```json
// Cliente → Servidor
{
    "Accion": "COMPRAR_VEHICULO",
    "Tipo": "",
    "Datos": "{\"IdSucursal\":1,\"IdVehiculo\":5,\"Monto\":15000.00}"
}

// Servidor → Cliente
{
    "Accion": "COMPRAR_VEHICULO",
    "Tipo": "OK",
    "Datos": "Compra Exitosa"
}
```

### 5.3 Seguridad en Compras

El servidor implementa un semáforo (`lock`) para evitar condiciones de carrera cuando múltiples clientes intentan comprar el mismo vehículo simultáneamente:

```csharp
private static readonly object _lockCompra = new object();

lock (_lockCompra)
{
    // Procesar compra y actualizar inventario
}
```

---

## 6. Base de Datos

### 6.1 Configuración de Conexión

La cadena de conexión se configura en `/AppServidor/App.config` y ya tiene varios formatos, solo hay que descomentar y completar:

```xml
﻿<?xml version="1.0" encoding="utf-8" ?>
<configuration>

	<connectionStrings>

		<!-- CONEXIÓN ACTUAL (Servidor Linux en red) -->
		<add name="CnxAutoMarket"
			 connectionString="Server=192.168.#.##;Database=AutoMarket;User Id=sa;Password=test123;"
			 providerName="System.Data.SqlClient" />

		<!-- OPCIÓN 1: SQL Server local en Windows (localhost) -->
		<!--2
    <add name="CnxAutoMarket"
         connectionString="Server=localhost;Database=AutoMarket;User Id=sa;Password=tu_password;"
         providerName="System.Data.SqlClient" />
    -->

		<!-- OPCIÓN 2: SQL Server Express -->
		<!--
    <add name="CnxAutoMarket"
         connectionString="Server=.\SQLEXPRESS;Database=AutoMarket;Trusted_Connection=True;"
         providerName="System.Data.SqlClient" />
    -->

		<!-- OPCIÓN 3: Windows Authentication -->
		<!--
    <add name="CnxAutoMarket"
         connectionString="Server=localhost;Database=AutoMarket;Integrated Security=True;"
         providerName="System.Data.SqlClient" />
    -->

	</connectionStrings>

	<startup>
		<supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
	</startup>

</configuration>
```

### 6.2 Entidades del Sistema

| Entidad | Descripción |
|---------|-------------|
| `Cliente` | Información de clientes (ID, nombre, identificación, fecha nacimiento) |
| `Vendedor` | Información de vendedores (ID, nombre, identificación, teléfono) |
| `Sucursal` | Ubicaciones de venta (ID, nombre, dirección, teléfono, estado, encargado) |
| `Categoria` | Tipos de vehículos (ID, nombre, descripción) |
| `Vehiculo` | Catálogo de vehículos (ID, marca, modelo, año, precio, estado, categoría) |
| `VehiculoxSucursal` | Inventario (relación vehículo-sucursal con cantidad) |
| `Venta` | Registro de transacciones (ID, cliente, sucursal, vehículo, fecha, monto) |

### 6.3 ConexiónBD (`AccesoDatos/ConexionBD.cs`)

Clase base que proporciona conexión a SQL Server:

```csharp
protected SqlConnection ObtenerConexion()
{
    return new SqlConnection(cadenaConexion);
}
```

---

## 7. Guía de Instalación y Configuración

### 7.1 Requisitos Previos

- **Sistema Operativo**: Windows 10/11 o Windows Server 2016+
- **.NET Framework**: Versión 4.7.2 o superior
- **SQL Server**: 2016 o superior (Express Edition es suficiente)
- **Red**: Conexión de red entre servidor y clientes

### 7.2 Instalación de la Base de Datos

1. Crear la base de datos en SQL Server:
```sql
CREATE DATABASE AutoMarket;
GO
```

2. Ejecutar el script de creación de tablas (proporcionado aparte)

3. Crear usuario de acceso (opcional, puede usar autenticación Windows):
```sql
CREATE LOGIN sa WITH PASSWORD = 'Sqldevjos35.';
USE AutoMarket;
CREATE USER sa FOR LOGIN sa;
ALTER ROLE db_owner ADD MEMBER sa;
```

### 7.3 Configuración del Servidor

#### Paso 1: Configurar IP y Puerto

Editar `/AppServidor/App.config`:

```xml
﻿<?xml version="1.0" encoding="utf-8" ?>
<configuration>

	<connectionStrings>

		<!-- CONEXIÓN ACTUAL (Servidor Linux en red) -->
		<add name="CnxAutoMarket"
			 connectionString="Server=192.168.#.##;Database=AutoMarket;User Id=sa;Password=test123;"
			 providerName="System.Data.SqlClient" />

		<!-- OPCIÓN 1: SQL Server local en Windows (localhost) -->
		<!--2
    <add name="CnxAutoMarket"
         connectionString="Server=localhost;Database=AutoMarket;User Id=sa;Password=tu_password;"
         providerName="System.Data.SqlClient" />
    -->

		<!-- OPCIÓN 2: SQL Server Express -->
		<!--
    <add name="CnxAutoMarket"
         connectionString="Server=.\SQLEXPRESS;Database=AutoMarket;Trusted_Connection=True;"
         providerName="System.Data.SqlClient" />
    -->

		<!-- OPCIÓN 3: Windows Authentication -->
		<!--
    <add name="CnxAutoMarket"
         connectionString="Server=localhost;Database=AutoMarket;Integrated Security=True;"
         providerName="System.Data.SqlClient" />
    -->

	</connectionStrings>

	<startup>
		<supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
	</startup>

</configuration>
```

#### Paso 2: Configurar TCP/IP del Servidor

Editar `/ComunicacionServidor/ServidorSocket.cs`:

```csharp
// Cambiar según tu red
private const string IP_SERVIDOR = "192.168.0.10";  // IP fija del servidor
private const int PUERTO = 15500;                   // Puerto disponible
private const int MAX_CLIENTES = 10;                // Máximo de conexiones
```

#### Paso 3: Abrir Puerto en Firewall si ya no lo esta abierto

Abrir PowerShell como Administrador:

```powershell
# Abrir puerto 15500 TCP
New-NetFirewallRule -DisplayName "AutoMarket Server" -Direction Inbound -Protocol TCP -LocalPort 15500 -Action Allow
```

#### Paso 4: Compilar y Ejecutar

```bash
# En Visual Studio o MSBuild
msbuild AutoMarket.sln /p:Configuration=Release

# Ejecutar
AppServidor\bin\Release\AppServidor.exe
```

### 7.4 Configuración del Cliente

#### Paso 1: Configurar IP del Servidor

Editar `/AppCliente/Red/ClienteSocket.cs`:

```csharp
// Cambiar a la IP donde está corriendo el servidor
private const string IP = "192.168.0.10";  // IP del servidor
private const int PUERTO = 15500;          // Mismo puerto que el servidor
```

#### Paso 2: Compilar

```bash
msbuild AutoMarket.sln /p:Configuration=Release
```

### 7.5 Tabla de Configuración Rápida

| Componente | Archivo | Configuración | Valor Ejemplo |
|------------|---------|---------------|---------------|
| **DB Server** | `AppServidor/App.config` | `Server` | `192.168.0.11` |
| **DB User** | `AppServidor/App.config` | `User Id` | `sa` |
| **DB Password** | `AppServidor/App.config` | `Password` | `Sqldevjos35.` |
| **TCP IP** | `ComunicacionServidor/ServidorSocket.cs` | `IP_SERVIDOR` | `192.168.0.10` |
| **TCP Puerto** | `ComunicacionServidor/ServidorSocket.cs` | `PUERTO` | `15500` |
| **Client IP** | `AppCliente/Red/ClienteSocket.cs` | `IP` | `192.168.0.10` |
| **Client Puerto** | `AppCliente/Red/ClienteSocket.cs` | `PUERTO` | `15500` |

---

## 8. Instrucciones de Uso

### 8.1 Iniciar el Sistema

**Orden de inicio:**

1. **Verificar que SQL Server esté corriendo**
2. **Iniciar AppServidor**: Se abre el dashboard del servidor
3. **El servidor TCP se con el boton** (se muestra en logs)
4. **Iniciar AppCliente** en las estaciones de trabajo

### 8.2 Uso del Servidor

#### Dashboard Principal (FrmContHome)
- Muestra totales de: Vehículos, Sucursales, Categorías, Clientes, Vendedores, Ventas
- Gráficos: Estados de sucursales, Ventas mensuales, Registros de clientes

#### Registros
Acceder desde el menú lateral:
- **Categorías**: Registrar tipos de vehículos (SUV, Sedán, etc.)
- **Vendedores**: Registrar personal de ventas
- **Sucursales**: Registrar ubicaciones de venta
- **Vehículos**: Registrar catálogo de vehículos
- **Clientes**: Registrar clientes manualmente
- **Vehículos x Sucursal**: Asignar inventario a cada sucursal

#### Consultas
- Visualizar datos paginados de todas las entidades
- Ordenar por columnas
- Navegación entre páginas

#### Recursos
- Monitoreo en tiempo real de CPU y RAM del servidor

### 8.3 Uso del Cliente

#### Login
1. Ingresar número de identificación (cédula)
2. El sistema verifica si existe en la base de datos
3. Si no existe, contactar al administrador para registro

#### Consultar Sucursales
1. Seleccionar "Consultar" en el menú
2. Ver lista de sucursales disponibles
3. Seleccionar una sucursal para ver sus vehículos

#### Comprar Vehículo
1. En la consulta de sucursal, seleccionar un vehículo
2. El sistema muestra el precio y disponibilidad
3. Confirmar compra
4. El sistema procesa la transacción y actualiza inventario

#### Ver Mis Compras
1. Seleccionar "Mis Compras" en el menú
2. Visualizar historial de compras realizadas

### 8.4 Logs del Sistema

Los eventos se registran con colores:
- **Verde (1)**: Acciones exitosas
- **Azul (2)**: Información general
- **Rojo (3)**: Errores
- **Amarillo (4)**: Advertencias
- **Blanco (5)**: Mensajes neutros

---

## 9. Solución de Problemas

### 9.1 Problemas de Conexión a Base de Datos

| Síntoma | Causa | Solución |
|---------|-------|----------|
| "Cannot connect to SQL Server" | Servidor SQL no está corriendo | Iniciar servicio SQL Server |
| "Login failed" | Credenciales incorrectas | Verificar usuario y contraseña en App.config |
| "Network-related error" | Firewall bloqueando | Abrir puerto 1433 para SQL Server |
| "Database does not exist" | Base de datos no creada | Crear base de datos AutoMarket |

### 9.2 Problemas de Conexión TCP

| Síntoma | Causa | Solución |
|---------|-------|----------|
| "No hay conexión activa" | Servidor no iniciado | Iniciar AppServidor primero |
| "Connection refused" | IP o puerto incorrecto | Verificar IP_SERVIDOR y PUERTO |
| "Cliente Rechazado" | Límite de clientes alcanzado | Esperar a que se desconecte otro cliente |
| Timeout al conectar | Firewall bloqueando | Abrir puerto 15500 en firewall |

### 9.3 Errores de Compra

| Síntoma | Causa | Solución |
|---------|-------|----------|
| "No se pudo procesar la compra" | Sin inventario | Verificar disponibilidad del vehículo |
| "Cliente no registrado" | ID no existe | Registrar cliente en el servidor |
| Error de concurrencia | Múltiples compras simultáneas | Reintentar la operación |

### 9.4 Verificación de Puertos

En el servidor, verificar que el puerto esté escuchando:

```powershell
# Verificar puertos en uso
netstat -an | findstr 15500

# Debe mostrar: LISTENING
```

### 9.5 Verificación de Conectividad

Desde el cliente, probar conexión al servidor:

```powershell
# Probar conexión TCP
telnet 192.168.0.10 15500

# O usando PowerShell
Test-NetConnection -ComputerName 192.168.0.10 -Port 15500
```

---

## 10. Información Técnica Adicional

### 10.1 Dependencias NuGet

| Paquete | Versión | Uso |
|---------|---------|-----|
| Newtonsoft.Json | 13.0.4 | Serialización JSON para mensajes TCP |
| CuoreUI.Winforms | 2026.1.16 | Interfaz gráfica moderna |

### 10.2 Características de Seguridad Implementadas

1. **Validación de datos**: Todos los inputs son validados antes de insertarse
2. **Thread-safe**: Las compras usan `lock` para evitar condiciones de carrera
3. **Límite de conexiones**: Máximo 10 clientes simultáneos
4. **Manejo de excepciones**: Todos los métodos críticos tienen try-catch

### 10.3 Rendimiento

- Paginación implementada en todas las consultas
- Hilos de fondo (`IsBackground = true`) para no bloquear la UI
- Conexiones TCP por hilos separados para cada cliente

---

**Autor: Josue Jimenez Barrantes**
**Fecha Entrega: 12 de Abril de 2026**
**UNED - I Cuatrimestre 2026**
