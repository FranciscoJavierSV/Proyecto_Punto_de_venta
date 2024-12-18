using System;
using System.Collections.Generic;
using System.Linq;

public class ArticuloCarrito
{
    public int ID { get; set; }
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
}

public class Carrito
{
    private List<ArticuloCarrito> articulos;
    private string usuario;

    public Carrito(string usuario)
    {
        this.usuario = usuario;
        articulos = new List<ArticuloCarrito>();
    }

    public decimal ObtenerTotal()
    {
        return articulos.Sum(a => a.Precio * a.Cantidad);
    }

    public void AñadirArticulo(ArticuloCarrito articulo, int existenciasDisponibles)
    {
        var articuloEnCarrito = articulos.FirstOrDefault(a => a.ID == articulo.ID);
        int cantidadTotalSolicitada = articulo.Cantidad;

        if (articuloEnCarrito != null)
        {
            cantidadTotalSolicitada += articuloEnCarrito.Cantidad;
        }

        if (cantidadTotalSolicitada <= existenciasDisponibles)
        {
            if (articuloEnCarrito == null)
            {
                articulos.Add(articulo);
            }
            else
            {
                articuloEnCarrito.Cantidad += articulo.Cantidad;
            }
        }
        else
        {
            throw new Exception($"No hay suficiente cantidad de {articulo.Nombre} en stock. Disponible: {existenciasDisponibles}");
        }
    }

    public List<ArticuloCarrito> ObtenerArticulos()
    {
        return articulos;
    }

    public string ObtenerUsuario()
    {
        return usuario;
    }
}
