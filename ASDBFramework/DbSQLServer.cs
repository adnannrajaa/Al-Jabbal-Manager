using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace ASDBFramework
{
    public class DbSQLServer
    {
        //ExecuteReader(Return 1 or More Rows) ,
        //ExecuteScalar(Return Only 1 Value) And 
        //ExecuteNoQuery(Add Update Insert Delete Functionality)

        private string _connString;

        public DbSQLServer(string connString)
        {
            _connString = connString;
        }
        //<-------------                     ExecuteScalar(Return Only 1 Value) Start                      ------------>
       
        //...................................GetScalarValue Without Argu...............Start........
        public object GetScalarValue(string storedProceName)
        {
            object value=null;

            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();
                    value=cmd.ExecuteScalar();

                }
            }
            return value;
        }
        //...................................GetScalarValue Without Argu...............End........

        //...................................GetScalarValue With 1 Argu...............Start........
        public object GetScalarValue(string storedProceName,DBParameter parameter)
        {
            object value = null;

            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();
                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);
                    value = cmd.ExecuteScalar();

                }
            }
            return value;
        }
        //...................................GetScalarValue With 1 Argu...............End........

        //...................................GetScalarValue With 1 or More Argu...............Start........
        public object GetScalarValue(string storedProceName, DBParameter[] parameters)
        {
            object value = null;

            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();
                    foreach (var para in parameters)
                    {
                        cmd.Parameters.AddWithValue(para.Parameter, para.Value);
                    }
                    value = cmd.ExecuteScalar();

                }
            }
            return value;
        }
        //...................................GetScalarValue With 1 or More Argu...............End........

        //<-------------                     ExecuteScalar(Return Only 1 Value) End                   ------------>


        //<-------------                     ExecuteReader(Return 1 or More Rows)  Start                  ------------>

        //...................................ExecuteReader Without Argu...............Start........

        //we may use array ,collection,generics, data set and data table
        public DataTable GetDataList(string storedProceName)
        {
            DataTable dtData = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtData.Load(reader);
                    

                }
            }
            return dtData;
        }
        //...................................ExecuteReader Without Argu...............End........

        //...................................ExecuteReader With 1 Argu...............Start........

        //we may use array ,collection,generics, data set and data table
        public DataTable GetDataList(string storedProceName, DBParameter parameter)
        {
            DataTable dtData = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);

                    SqlDataReader reader = cmd.ExecuteReader();
                    dtData.Load(reader);


                }
            }
            return dtData;
        }
        //...................................ExecuteReader With 1 Argu...............End........

        //...................................ExecuteReader With 1 or more Argu...............Start........

        //we may use array ,collection,generics, data set and data table
        public DataTable GetDataList(string storedProceName, DBParameter[] parameters)
        {
            DataTable dtData = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    foreach (var para in parameters)
                    {
                        cmd.Parameters.AddWithValue(para.Parameter, para.Value);
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtData.Load(reader);


                }
            }
            return dtData;
        }
        //...................................ExecuteReader With 1 or more Argu...............End........


        //<-------------                     ExecuteReader(Return 1 or More Rows)  End                    ------------>




        //<-------------                     ExecuteNoQuery(Add Update Insert Delete Functionality) Start     ------------>


          public void SaveOrUpdateRecord(string storedProceName,object obj)
        {
            

            using (SqlConnection conn = new SqlConnection(_connString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    //parameters
                    Type type = obj.GetType();
                    BindingFlags flages = BindingFlags.Public | BindingFlags.Instance;
                    PropertyInfo[] properties = type.GetProperties(flages);
                    foreach (var prop in properties)
                    {
                        cmd.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(obj, null));
                    }
                    cmd.ExecuteNonQuery();

                }
            }
            
        }
      

        //<-------------                     ExecuteNoQuery(Add Update Insert Delete Functionality) End     ------------>
       
        
    }
}
