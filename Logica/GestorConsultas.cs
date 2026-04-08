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

        // Listar paginado
        public List<Categoria> ListarCategoriasPaginado(int pagina, int tamaño, string ordenSQL)
            => cd.ListarCategoriasPaginado(pagina, tamaño, ordenSQL);

        public List<Cliente> ListarClientesPaginado(int pagina, int tamaño, string ordenSQL)
            => cld.ListarClientesPaginado(pagina, tamaño, ordenSQL);

        public List<Sucursal> ListarSucursalesPaginado(int pagina, int tamaño, string ordenSQL)
            => sd.ListarSucursalesPaginado(pagina, tamaño, ordenSQL);

        public List<Vehiculo> ListarVehiculosPaginado(int pagina, int tamaño, string ordenSQL)
            => vd.ListarVehiculosPaginado(pagina, tamaño, ordenSQL);

        public List<Vendedor> ListarVendedoresPaginado(int pagina, int tamaño, string ordenSQL)
            => vend.ListarVendedoresPaginado(pagina, tamaño, ordenSQL);

        public List<Venta> ListarVentasPaginado(int pagina, int tamaño, string ordenSQL)
            => vta.ListarVentasPaginado(pagina, tamaño, ordenSQL);

        public List<VehiculoxSucursal> ListarVehiculosxSucursalPaginado(int pagina, int tamaño, string ordenSQL)
            => vxsd.ListarVehiculoxSucursalPaginado(pagina, tamaño, ordenSQL);

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