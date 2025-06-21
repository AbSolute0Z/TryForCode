using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace pol
{
    public class PartnerManager
    {
        private readonly Database _db;

        internal PartnerManager(Database db)
        {
            _db = db;
        }

        public DataTable GetAll()
        {

            string query = @"
                     SELECT
                     p.partner_id,
                     p.company_name,
                    pt.type_name AS partner_type,                   
                    p.director_name,
                    p.email,
                    p.phone,
                     p.legal_address,
                     p.inn,
                    p.rating,
                    p.created_at,
                    p.updated_at
                     FROM
                     partners p
                     JOIN
                     partner_types pt ON p.partner_type_id = pt.partner_type_id
                     ORDER BY
                     p.company_name";

            return _db.ExecuteQuery(query);
        }
        //остальная часть
        public DataTable GetProductTypes()
        {
            string query = "SELECT type_name, type_coefficient FROM product_types ORDER BY type_name";
            return _db.ExecuteQuery(query);
        }
        public bool AddProduct(string productType, string productName, string article, decimal minPrice)
        {
            string query = @"
                 INSERT INTO products (
                 product_type_id,
                 product_name,
                 article,
                 min_partner_price
                 )
                 VALUES (
                 (SELECT product_type_id FROM product_types WHERE type_name = @productType),
                 @productName,
                 @article,
                 @minPrice
                 )";

            var parameters = new NpgsqlParameter[]
            {
                     new NpgsqlParameter("@productType", productType),
                     new NpgsqlParameter("@productName", productName),
                     new NpgsqlParameter("@article", article),
                     new NpgsqlParameter("@minPrice", minPrice)
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }
        public DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null)
        {
            return _db.ExecuteQuery(query, parameters);
        }
        public int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
        {
            return _db.ExecuteNonQuery(query, parameters);
        }
        public object ExecuteScalar(string query, NpgsqlParameter[] parameters = null)
        {
            return _db.ExecuteScalar(query, parameters);
        }
        public DataTable GetPartnerTypes()
        {
            string query = "SELECT type_name FROM partner_types ORDER BY type_name";
            return _db.ExecuteQuery(query);
        }
        public DataTable GetProducts()
        {
            string query = "SELECT product_name FROM products ORDER BY product_name";
            return _db.ExecuteQuery(query);
        }
    }
}
