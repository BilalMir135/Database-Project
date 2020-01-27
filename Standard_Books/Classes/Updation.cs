using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Books.Classes
{
    class Updation
    {
        public void updateCurrency(int id, string symbol, string currencyname, float exchangerate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateCurrency", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Symbol", symbol);
                cmd.Parameters.AddWithValue("@CurrencyName", currencyname);
                cmd.Parameters.AddWithValue("@ExchangeRate", exchangerate);
                cmd.Parameters.AddWithValue("@CurrencyID", id);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show(currencyname + " updated to the system successfully", "Record Updated", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void updateFreight(int id, string abb, string dest, float charges)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateFreight", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Abbreviation", abb);
                cmd.Parameters.AddWithValue("@Destination", dest);
                cmd.Parameters.AddWithValue("@Charges", charges);
                cmd.Parameters.AddWithValue("@FreightID", id);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show(dest + " updated to the system successfully", "Record Updated", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void updatePublisher(int id, string code, string name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updatePublisher", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.AddWithValue("@PublisherName", name);
                cmd.Parameters.AddWithValue("@PublisherID", id);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show(name + " updated to the system successfully", "Record Updated", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void updateSubject(int id, string subjectname)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateSubject", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubjectName", subjectname);
                cmd.Parameters.AddWithValue("@SubjectID", id);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show(subjectname + " updated to the system successfully", "Record Updated", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void updateAuthor(int id, string authorname)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateAuthor", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AuthorName", authorname);
                cmd.Parameters.AddWithValue("@AuthorID", id);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show(authorname + " updated to the system successfully", "Record Updated", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void updateBooks(string ISBN, string title, int authorID, int subjectID, int publisherID, short pubyear, int currencyID, float price, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateBooks", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@PublishingYear", pubyear);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@AuthorID", authorID);
                cmd.Parameters.AddWithValue("@SubjectID", subjectID);
                cmd.Parameters.AddWithValue("@PublisherID", publisherID);
                cmd.Parameters.AddWithValue("@CurrencyID", currencyID);
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
        public void updateParty(int id, string name, string address, string city, string province, string country, string phone, string fax, string email, int code)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateParty", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Province", province);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Fax", fax);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.AddWithValue("@PartyID", id);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show(name + " updated to the system successfully", "Record Updated", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void updateSupplier(int id, string name, string address, string city, string province, string country, string phone, string fax, string email)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateSupplier", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Province", province);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Fax", fax);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@SupplierID", id);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show(name + " updated to the system successfully", "Record Updated", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void updateParameter(int id, string[] parameters)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateParameters", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Address", parameters[0]);
                cmd.Parameters.AddWithValue("@City", parameters[1]);
                cmd.Parameters.AddWithValue("@Province", parameters[2]);
                cmd.Parameters.AddWithValue("@Country", parameters[3]);
                cmd.Parameters.AddWithValue("@Phone", parameters[4]);
                cmd.Parameters.AddWithValue("@Mobile", parameters[5]);
                cmd.Parameters.AddWithValue("@Email", parameters[6]);
                cmd.Parameters.AddWithValue("@Website", parameters[7]);
                cmd.Parameters.AddWithValue("@Remarks", parameters[8]);
                cmd.Parameters.AddWithValue("@SpecialRemarks", parameters[9]);
                cmd.Parameters.AddWithValue("@FYR", parameters[10]);
                cmd.Parameters.AddWithValue("@NTN ", parameters[11]);
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
        public void updateStock(string ISBN, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateStock", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
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
        public void updateApprovedChallan(long challanid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_approvedChallan", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ChallanID", challanid);
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
        public void updatePaidAmount(string invoiceno, float amount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updatePaidAmount", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PaidAmount", amount);
                cmd.Parameters.AddWithValue("@InoiceNo", invoiceno);
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
        public byte updateReceipt(long id, string receiptno, DateTime date, string remarks, string cheque_cash, float amount, float incometax)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateReceipt", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@ReceiptNo", receiptno);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Remarks", remarks);
                cmd.Parameters.AddWithValue("@Cheque_Cash", cheque_cash);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@IncomeTax", incometax);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show("Receipt No. " + receiptno + " updated successfully", "Success", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
                return 1;
            }
            return 0;
        }
        public void updateLinks(string[] links)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updateLinks", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Facebook", links[0]);
                cmd.Parameters.AddWithValue("@Gmail", links[1]);
                cmd.Parameters.AddWithValue("@Twitter", links[2]);
                cmd.Parameters.AddWithValue("@Outlook", links[3]);
                cmd.Parameters.AddWithValue("@Yahoo", links[4]);
                cmd.Parameters.AddWithValue("@SB", links[5]);
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
