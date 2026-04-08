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
            
            // Validaciones de campos
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
            // Agrega más validaciones como formato de cédula, correo, etc.
            
            return cld.InsertarCliente(c);
        }

        public bool InsertarSucursal(Sucursal s)
        {
            if (s == null) throw new ArgumentException("La sucursal no puede ser nula.");
            // Validaciones
            
            return sd.InsertarSucursal(s); 

        }

        public bool InsertarVehiculo(Vehiculo v)
        {
            if (v == null) throw new ArgumentException("El vehículo no puede ser nulo.");
            // Validaciones
            
            return vd.InsertarVehiculo(v); 

        }

        public bool InsertarVendedor(Vendedor v)
        {
            if (v == null) throw new ArgumentException("El vendedor no puede ser nulo.");
            // Validaciones
            
            return vend.InsertarVendedor(v);

        }

        public bool InsertarVenta(Venta v)
        {
            if (v == null) throw new ArgumentException("La venta no puede ser nula.");
            // Validaciones
            
            return vta.InsertarVenta(v);

        }

        public bool InsertarVehiculoxSucursal(VehiculoxSucursal vxs)
        {
            if (vxs == null) throw new ArgumentException("El registro no puede ser nulo.");
            // Validaciones
            
            return vxsd.InsertarVehiculoxSucursal(vxs);

        }
    }
}
