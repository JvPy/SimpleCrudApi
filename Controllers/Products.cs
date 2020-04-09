using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;

namespace SimpleCrudApi.Controllers {
    
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase {

        [HttpGet]
        public List<Products> GetProducts(){
            List<Products> lstProducts = new List<Products>(){
                new Products(){
                    ID = 1,
                    Name = "Produto 1",
                    Description = "Produto do Tipo 1",
                    Price = 10
                },
                new Products(){
                    ID = 1,
                    Name = "Produto 1",
                    Description = "Produto do Tipo 1",
                    Price = 10
                }
            };

            return lstProducts;
        }

        [HttpPost]
        public void UpdateProduct(Products p){
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            string query = string.Format("UPDATE TProducts SET Name = {0}, Description = {1}, Price = {2}, LastUpdated = {3} WHERE IDProduct = {4}",
            p.Name, p.Description, p.Price, now, p.ID);

            using(SqlConnection sqlConn = new SqlConnection("ConnectionString")){
                sqlConn.Open();
                SqlCommand sql = new SqlCommand(query, sqlConn);
               
            }
        }

        [HttpPost]
        public void DeleteProduct(int id){  
            string query = string.Format("DELETE FROM TProducts WHERE IDProducts = {0}", id);
        }

        [HttpPost]
        public void CreateProduct(Products p){
            string now = DateTime.Now.ToString("yyyy-MM-dd");
            string query = string.Format("INSERT INTO TProducts (Name, Description, Price, CreatedOn, LastUpdated) VALUES = ({0}, {1}, {2}, {3}, {3})", p.Name, p.Description, p.Price, now, now);

        }
    }
}
