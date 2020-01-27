using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Books.Classes
{
    class Deletion
    {
        public void delete(object id, string procedure, string parameter)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(parameter, id);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show("Data deleted successfully", "Record Deleted", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void delete_without_message(object id, string procedure, string parameter)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(parameter, id);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
    }
}
