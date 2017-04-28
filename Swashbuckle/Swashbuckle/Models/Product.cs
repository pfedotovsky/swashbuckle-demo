using System.ComponentModel;

namespace Swashbuckle.Models
{
    public class Product
    {
        public int? ProductID { get; set; }

        /// <summary>
        ///  Product type id.
        /// </summary>
        public int? ProductTypeID { get; set; }

        /// <summary>
        ///  Product name.
        /// </summary>
        [DefaultValue("Name")]
        public string Name { get; set; }

        /// <summary>
        ///  Product description.
        /// </summary>
        [DefaultValue("Description")]
        public string Description { get; set; }

        /// <summary>
        ///  Is valid product.
        /// </summary>
        public bool? Valid { get; set; }
    }
}
