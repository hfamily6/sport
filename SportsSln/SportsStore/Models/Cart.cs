using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models {
    public class Cart {
        public List<CartLine> Lines {get; set; } = new List<CartLine>();

        public void AddItem (Product product, int quantity) {
            CartLine line = Lines
                .Where (p => p.ProductId == product.ProductId)
                .FirstOrDefault();

            if (line == null) {
                Lines.Add(new CartLine {
                    Product = product,
                    Quantity = quantity
                });
            }
        }
    }
}