using RestSharp;
namespace Negocio
{
    public class ProductosAPI
    {
         List<Producto> products = new List<Producto>();

         public List<Producto> GetAll() {

            Producto producto = new Producto();
            producto.Id = 1;
            producto.Name = "Pelota";
            producto.Description = "Redonda, azul";
            products.Add(producto);
            Producto producto2 = new Producto();
            producto2.Id = 2;
            producto2.Name = "Pelota";
            producto2.Description = "Redonda, azul";
            products.Add(producto2);
            Producto producto3 = new Producto();
            producto3.Id = 3;
            producto3.Name = "Pelota";
            producto3.Description = "Redonda, azul";
            products.Add(producto3);
            return products;
        }
        public Producto Post() { return new Producto(); }
    }
}