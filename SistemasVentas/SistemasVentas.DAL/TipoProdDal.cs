using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class TipoProdDal
    {
        public DataTable ListarTipoProdDal()
        {
            string consulta = "select * from tipoprod";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarTipoProdDal(TipoProd tipoprod)
        {
            string consulta = "insert into tipoprod values('" + tipoprod.Nombre + "'," +
                                                  "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public TipoProd ObtenerTipoProdId(int id)
        {
            string consulta = "select * from tipoprod where idtipoprod=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            TipoProd t = new TipoProd();

            if (tabla.Rows.Count > 0)
            {
                t.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                t.Nombre = tabla.Rows[0]["nombre"].ToString();
                t.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return t;

        }
        public void EditarTipoProdDal(TipoProd tp)
        {
            string consulta = "update tipoprod set nombre='" + tp.Nombre + "'" +
                                              "where idtipoprod=" + tp.IdTipoProd;
            conexion.Ejecutar(consulta);
        }
        public void EliminarTipoProdDal(int id)
        {
            string consulta = "delete from tipoprod where idtipoprod=" + id;
            conexion.Ejecutar(consulta);
        }
        public DataTable TipoProdDatosDal()
        {
            string consulta = "SELECT TP.NOMBRE TIPO_PRODUCTO,SUM(DV.CANTIDAD) AS CANTIDAD_TOTAL_VENDIDA " +
                "FROM TIPOPROD TP INNER JOIN PRODUCTO P ON TP.IDTIPOPROD = P.IDTIPOPROD " +
                "INNER JOIN DETALLEVENTA DV ON P.IDPRODUCTO = DV.IDPRODUCTO " +
                "GROUP BY TP.NOMBRE";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
