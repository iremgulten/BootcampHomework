using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperORM
{
    public class CustomManager : ICustomManager<Customer, int>
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\Mssqllocaldb; initial Catalog = Customer; Integrated Security = True;");

        public bool DeleteCustomer(Customer item)
        {
            try
            {
                sqlOpen();
                connection.Query<Customer>(@"DELETE FROM [dbo].[Customers] WHERE CustomerID = @ID",item);
                return true;
            }catch (Exception ex)
            {
                throw new Exception("Silme işlemi gerçekleştirilemedi : "+ex.Message.ToString());
            }
            finally
            {
                sqlClose();
            }
        }

        public List<Customer> GetAll()
        {
            try
            {
                sqlOpen();
                List<Customer> customers = connection.Query<Customer>("SELECT * FROM [dbo].[Customers]").ToList();
                return customers;
            }catch (Exception ex)
            {
                throw new Exception("Listeleme işlemi gerçekleştirilemedi : " + ex.Message.ToString());
            }
            finally
            {
                sqlClose();
            }
        }

        public bool AddCustomer(Customer item)
        {
            try
            {
                sqlOpen();
                connection.Query<Customer>("INSERT INTO [dbo].[Customers] ([CustomerID],[CustomerName],[CustomerSurname],[CustomerAge]) VALUES (@CustomerName,@CustomerSurname,@CustomerAge)", item);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ekleme işlemi gerçekleştirilemedi : " + ex.Message.ToString());
            }
            finally
            {
                sqlClose();
            }
        }

        public bool UpdateCustomer(Customer item)
        {
            try
            {
                sqlOpen();
                connection.Query<Customer>("UPDATE [dbo].[Customers] SET [CustomerName]=@CustomerName, [CustomerSurname]= @CustomerSurname,[CustomerAge]=@CustomerAge",item);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Güncelleme işlemi gerçekleştirilemedi : " + ex.Message.ToString());
            }
            finally
            {
                sqlClose();
            }
        }
        public void sqlOpen()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void sqlClose()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
