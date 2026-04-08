using System.Collections.Generic;
using CapaEntidades;
using AccesoDatos;

namespace Logica
{
    public class GestorConsultas
    {
        // instanciar las clases de datos
        private VehiculoDatos vd = new VehiculoDatos();
        private SucursalDatos sd = new SucursalDatos();
        private CategoriaDatos cd = new CategoriaDatos();
        private ClienteDatos cld = new ClienteDatos();
        private VendedorDatos vend = new VendedorDatos();
        private VentaDatos vta = new VentaDatos();
        private VehiculoxSucursalDatos vxsd = new VehiculoxSucursalDatos();

        // Obtener totales
        public int ObtenerTotalVehiculos() => vd.ObtenerTotalVehiculos();
        public int ObtenerTotalSucursales() => sd.ObtenerTotalSucursales();
        public int ObtenerTotalCategorias() => cd.ObtenerTotalCategorias();
        public int ObtenerTotalClientes() => cld.ObtenerTotalClientes();
        public int ObtenerTotalVendedores() => vend.ObtenerTotalVendedores();
        public int ObtenerTotalVentas() => vta.ObtenerTotalVentas();
        public int ObtenerTotalVehiculosxSucursal() => vxsd.ObtenerTotalVehiculoxSucursal();

        // Listar paginado con lógica de validación
        public List<Categoria> ListarCategoriasPaginado(int pagina, int tamaño, string ordenSQL)
        {
            ValidarPaginacion(ref pagina, ref tamaño, ref ordenSQL);
            return cd.ListarCategoriasPaginado(pagina, tamaño, ordenSQL);
        }

        public List<Cliente> ListarClientesPaginado(int pagina, int tamaño, string ordenSQL)
        {
            ValidarPaginacion(ref pagina, ref tamaño, ref ordenSQL);
            return cld.ListarClientesPaginado(pagina, tamaño, ordenSQL);
        }

        public List<Sucursal> ListarSucursalesPaginado(int pagina, int tamaño, string ordenSQL)
        {
            ValidarPaginacion(ref pagina, ref tamaño, ref ordenSQL);
            return sd.ListarSucursalesPaginado(pagina, tamaño, ordenSQL);
        }

        public List<Vehiculo> ListarVehiculosPaginado(int pagina, int tamaño, string ordenSQL)
        {
            ValidarPaginacion(ref pagina, ref tamaño, ref ordenSQL);
            return vd.ListarVehiculosPaginado(pagina, tamaño, ordenSQL);
        }

        public List<Vendedor> ListarVendedoresPaginado(int pagina, int tamaño, string ordenSQL)
        {
            ValidarPaginacion(ref pagina, ref tamaño, ref ordenSQL);
            return vend.ListarVendedoresPaginado(pagina, tamaño, ordenSQL);
        }

        public List<Venta> ListarVentasPaginado(int pagina, int tamaño, string ordenSQL)
        {
            ValidarPaginacion(ref pagina, ref tamaño, ref ordenSQL);
            return vta.ListarVentasPaginado(pagina, tamaño, ordenSQL);
        }

        public List<VehiculoxSucursal> ListarVehiculosxSucursalPaginado(int pagina, int tamaño, string ordenSQL)
        {
            ValidarPaginacion(ref pagina, ref tamaño, ref ordenSQL);
            return vxsd.ListarVehiculoxSucursalPaginado(pagina, tamaño, ordenSQL);
        }

        // Método privado de validación de negocio y reglas de paginación
        private void ValidarPaginacion(ref int pagina, ref int tamaño, ref string ordenSQL)
        {
            if (pagina < 1) pagina = 1;
            if (tamaño <= 0) tamaño = 10; // Tamaño por defecto si se envía mal
            if (string.IsNullOrWhiteSpace(ordenSQL)) ordenSQL = "1"; // Ordenar por la primera columna de forma predeterminada
        }

        // Métodos de los charts
        public Dictionary<string, int> ObtenerEstadoSucursales() => sd.ObtenerEstadoSucursales();
        public Dictionary<string, decimal> ObtenerVentasMensuales() => vta.ObtenerVentasMensuales();
        public Dictionary<string, decimal> ObtenerRegistrosClientesPorMes() => cld.ObtenerRegistrosClientesPorMes();

        //metodos obtener siguiente
        public int ObtenerProximoIdCat() => cd.ObtenerProximoId();
        public int ObtenerProximoIdClie() => cld.ObtenerProximoId();
        public int ObtenerProximoIdSuc() => sd.ObtenerProximoId();
        public int ObtenerProximoIdVeh() => vd.ObtenerProximoId();
        public int ObtenerProximoIdVend() => vend.ObtenerProximoId();
    }
}