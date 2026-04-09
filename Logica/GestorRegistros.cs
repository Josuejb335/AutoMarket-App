using System;
using System.Collections.Generic;
using CapaEntidades;
using AccesoDatos;

namespace Logica
{
    public class GestorRegistros
    {
        // Instancias de las clases de acceso a datos
        private VehiculoDatos vd = new VehiculoDatos();
        private SucursalDatos sd = new SucursalDatos();
        private CategoriaDatos cd = new CategoriaDatos();
        private ClienteDatos cld = new ClienteDatos();
        private VendedorDatos vend = new VendedorDatos();
        private VentaDatos vta = new VentaDatos();
        private VehiculoxSucursalDatos vxsd = new VehiculoxSucursalDatos();

        //metodos para insertar

        public bool InsertarCategoria(Categoria c)
        {
            if (c == null) throw new ArgumentException("La categoría no puede ser nula.");

            // Validaciones de datos antes de insertar
            if (string.IsNullOrWhiteSpace(c.NombreCat)) 
                throw new ArgumentException("El nombre de la categoría es obligatorio y no puede estar en blanco.");
            
            if (c.NombreCat.Length < 5) 
                throw new ArgumentException("El nombre de la categoría debe tener al menos 5 caracteres.");

            if (string.IsNullOrWhiteSpace(c.DescCat)) 
                throw new ArgumentException("La descripción no puede estar vacía.");

            return cd.InsertarCategoria(c); 
        }

        public bool InsertarCliente(Cliente c)
        {
            if (c == null) throw new ArgumentException("El cliente no puede ser nulo.");
            
            // Validaciones de datos
            ValidarIdentificacion(c.Ident);
            
            if (string.IsNullOrWhiteSpace(c.Nombre)) 
                throw new ArgumentException("El nombre del cliente es obligatorio.");
                
            if (c.FechaNacimiento > DateTime.Now) 
                throw new ArgumentException("La fecha de nacimiento no puede ser en el futuro.");
            
            return cld.InsertarCliente(c);
        }

        public bool InsertarSucursal(Sucursal s)
        {
            if (s == null) throw new ArgumentException("La sucursal no puede ser nula.");
            
            // Validaciones de datos
            if (string.IsNullOrWhiteSpace(s.NombreSuc))
                throw new ArgumentException("El nombre de la sucursal es obligatorio.");

            if (string.IsNullOrWhiteSpace(s.Direccion))
                throw new ArgumentException("La dirección de la sucursal es obligatoria.");

            ValidarTelefono(s.Telefono);

            if (s.Encargado == null || s.Encargado.IdVend <= 0)
                throw new ArgumentException("Debe asignar un vendedor encargado válido a la sucursal.");
            
            return sd.InsertarSucursal(s); 

        }

        public bool InsertarVehiculo(Vehiculo v)
        {
            if (v == null) throw new ArgumentException("El vehículo no puede ser nulo.");
            
            // Validaciones de datos
            if (string.IsNullOrWhiteSpace(v.Marca))
                throw new ArgumentException("La marca del vehículo es obligatoria y no puede estar en blanco.");
                
            if (string.IsNullOrWhiteSpace(v.Modelo))
                throw new ArgumentException("El modelo del vehículo es obligatorio.");
                
            if (v.Anio < 1900 || v.Anio > (DateTime.Now.Year + 1))
                throw new ArgumentException($"El año del vehículo debe ser válido (entre 1900 y {DateTime.Now.Year + 1}).");
                
            if (v.Precio <= 0)
                throw new ArgumentException("El precio del vehículo debe ser mayor a cero.");
                
            if (v.Cat == null || v.Cat.IdCat <= 0)
                throw new ArgumentException("Debe seleccionar una categoría válida para el vehículo.");

            // Validar que la categoría de verdad exista en la tabla CategoriaVehiculo
            if (!cd.ExisteCategoria(v.Cat.IdCat))
                throw new ArgumentException($"La categoría con el ID {v.Cat.IdCat} no existe en la base de datos.");

            // char en C# tiene el valor por defecto '\0' si no se asigna.
            if (v.Estado == '\0')
                throw new ArgumentException("El estado del vehículo es obligatorio.");
            
            return vd.InsertarVehiculo(v); 
        }

        public bool InsertarVendedor(Vendedor v)
        {
            if (v == null) throw new ArgumentException("El vendedor no puede ser nulo.");
            
            // Validaciones de datos
            ValidarIdentificacion(v.Ident);

            if (string.IsNullOrWhiteSpace(v.Nombre))
                throw new ArgumentException("El nombre del vendedor es obligatorio.");

            ValidarTelefono(v.Telefono);

            if (v.FechaNacimiento > DateTime.Now)
                throw new ArgumentException("La fecha de nacimiento no puede ser en el futuro.");
            
            return vend.InsertarVendedor(v);

        }

        public bool InsertarVenta(Venta v)
        {
            if (v == null) throw new ArgumentException("La venta no puede ser nula.");
            
            // Validaciones de datos
            if (v.Clie == null || v.Clie.IdCliente <= 0)
                throw new ArgumentException("La venta debe estar asociada a un cliente válido.");

            if (v.Suc == null || v.Suc.IdSuc <= 0)
                throw new ArgumentException("La venta debe estar asociada a una sucursal válida.");

            if (v.Veh == null || v.Veh.IdVehi <= 0)
                throw new ArgumentException("Debe seleccionar un vehículo válido para la venta.");

            if (v.Monto <= 0)
                throw new ArgumentException("El monto de la venta debe ser mayor a cero.");

            if (v.FechaVenta > DateTime.Now)
                throw new ArgumentException("La fecha de venta no puede ser en el futuro.");
            
            return vta.InsertarVenta(v);

        }

        public bool InsertarVehiculoxSucursal(VehiculoxSucursal vxs)
        {
            if (vxs == null) throw new ArgumentException("El registro no puede ser nulo.");
            
            // Validaciones de datos
            if (vxs.SucursalAsociada == null || vxs.SucursalAsociada.IdSuc <= 0)
                throw new ArgumentException("La sucursal asociada es obligatoria y debe ser válida.");

            if (vxs.VehiculoAsociado == null || vxs.VehiculoAsociado.IdVehi <= 0)
                throw new ArgumentException("El vehículo asociado es obligatorio y debe ser válido.");

            if (vxs.Cantidad < 0)
                throw new ArgumentException("La cantidad no puede ser un número negativo.");
            
            return vxsd.InsertarVehiculoxSucursal(vxs);

        }

        // Métodos auxiliares de validación
        private void ValidarTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono))
                throw new ArgumentException("El teléfono es obligatorio.");

            if (telefono.Trim().Length < 8)
                throw new ArgumentException("El teléfono debe tener al menos 8 dígitos.");
        }

        private void ValidarIdentificacion(string identificacion)
        {
            if (string.IsNullOrWhiteSpace(identificacion))
                throw new ArgumentException("La identificación es obligatoria.");

            if (identificacion.Trim().Length < 10)
                throw new ArgumentException("La identificación debe tener al menos 10 digitos.");
        }
    }
}
