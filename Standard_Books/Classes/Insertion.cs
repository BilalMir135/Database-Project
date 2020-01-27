using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Standard_Books.Classes
{
    class Insertion
    {
        public void insertCurrency(string symbol, string currencyname, float exchangerate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertCurrency", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Symbol", symbol);
                cmd.Parameters.AddWithValue("@CurrencyName", currencyname);
                cmd.Parameters.AddWithValue("@ExchangeRate", exchangerate);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show(currencyname + " added to the system successfully", "Record Added", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void insertFreight(string abbre, string dest, float charges)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertFreight", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Abbreviation", abbre);
                cmd.Parameters.AddWithValue("@Destination", dest);
                cmd.Parameters.AddWithValue("@Charges", charges);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show(dest + " added to the system successfully", "Record Added", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void insertPublisher(string code, string name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertPublisher", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.AddWithValue("@PublisherName", name);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show(name + " added to the system successfully", "Record Added", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void insertSubject(string subjectname)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertSubject", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubjectName", subjectname);               
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show(subjectname + " added to the system successfully", "Record Added", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        int AuthorID;
        public int insertAuthorfromBooks(string authorname)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertAuthor", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AuthorName", authorname);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "sp_getLastAuthorID";
                cmd.Parameters.Clear();
                AuthorID = Convert.ToInt32(cmd.ExecuteScalar());
                Main_Class.connection.Close();            
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return AuthorID;
        }
        public void insertAuthor(string authorname)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertAuthor", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AuthorName", authorname);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show(authorname + " added to the system successfully", "Record Added", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void insertBooks(string ISBN, string title, int authorID, int subjectID, int publisherID, short pubyear, int currencyID, float price, int quantity)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertBooks", Main_Class.connection);
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
        public void insertBooksSubject(string ISBN, int subjectID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertBooksSubject", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@SubjectID", subjectID);
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
        public void insertParty(string name, string address, string city, string province, string country, string phone, string fax, string email, int code)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertParty", Main_Class.connection);
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
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show(name + " added to the system successfully", "Record Added", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void insertSupplier(string name, string address, string city, string province, string country, string phone, string fax, string email)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertSupplier", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Province", province);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Fax", fax);
                cmd.Parameters.AddWithValue("@Email", email);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show(name + " added to the system successfully", "Record Added", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        private long PurchaseID;
        public long insertPurchase(string purchaseno, DateTime date, string reference, int quantity, float amount, float totalamount, int supplierid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertPurchase", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PurchaseNo", purchaseno);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Reference", reference);
                cmd.Parameters.AddWithValue("@BookQuantity", quantity);
                cmd.Parameters.AddWithValue("@TotalAmount", totalamount);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@SupplierID", supplierid);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "sp_getLastPurchaseID";
                cmd.Parameters.Clear();
                PurchaseID = Convert.ToInt64(cmd.ExecuteScalar());
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return PurchaseID;
        }

        private long InvoiceID;
        public long insertInvoice(string invoiceno, DateTime date, string batch, string reference, int quantity, float amount, float totalamount, int partyid, string freightname, float charges, int sp_discount, string currencylist, byte remarks, byte sremarks, byte ntn, int challanid=-0)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertInvoice", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InvoiceNo", invoiceno);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Batch", batch);
                cmd.Parameters.AddWithValue("@Reference", reference);
                cmd.Parameters.AddWithValue("@BookQuantity", quantity);
                cmd.Parameters.AddWithValue("@TotalAmount", totalamount);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@PartyID", partyid);
                cmd.Parameters.AddWithValue("@FreightName", freightname);
                cmd.Parameters.AddWithValue("@Charges", charges);
                cmd.Parameters.AddWithValue("@SpecialDiscount", sp_discount);
                cmd.Parameters.AddWithValue("@CurrencyList", currencylist);
                cmd.Parameters.AddWithValue("@ChallanID", challanid);
                cmd.Parameters.AddWithValue("@Remarks", remarks);
                cmd.Parameters.AddWithValue("@SpecialRemarks", sremarks);
                cmd.Parameters.AddWithValue("@NTN", ntn);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "sp_getLastInvoiceID";
                cmd.Parameters.Clear();
                InvoiceID = Convert.ToInt64(cmd.ExecuteScalar());
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return InvoiceID;
        }
        private long ChallanID;
        public long insertChallan(string challanno, DateTime date, string batch, string reference, int quantity, float amount, float totalamount, int partyid, string currencylist)
        {
            try
            {              
                SqlCommand cmd = new SqlCommand("sp_insertChallan", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ChallanNo", challanno);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Batch", batch);
                cmd.Parameters.AddWithValue("@Reference", reference);
                cmd.Parameters.AddWithValue("@BookQuantity", quantity);
                cmd.Parameters.AddWithValue("@TotalAmount", totalamount);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@PartyID", partyid);
                cmd.Parameters.AddWithValue("@CurrencyList", currencylist);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "sp_getLastChallanID";
                cmd.Parameters.Clear();
                ChallanID = Convert.ToInt64(cmd.ExecuteScalar());
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return ChallanID;
        }

        private long QuotationID;
        public long insertQuotation(string quotationno, DateTime date, string title, string reference, int quantity, float amount, float totalamount, int partyid, string currencylist)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertQuotation", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@QuotationNo", quotationno);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Reference", reference);
                cmd.Parameters.AddWithValue("@BookQuantity", quantity);
                cmd.Parameters.AddWithValue("@TotalAmount", totalamount);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@PartyID", partyid);
                cmd.Parameters.AddWithValue("@CurrencyList", currencylist);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "sp_getLastQuotationID";
                cmd.Parameters.Clear();
                QuotationID = Convert.ToInt64(cmd.ExecuteScalar());
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return QuotationID;
        }

        private int count;             
        public int insertBookDetails(long id, string parameter, string procedure, string ISBN, int quantity, float amount, float discount, float finalamount, float price=0)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(parameter, id);
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Discount", discount);
                cmd.Parameters.AddWithValue("@FinalAmount", finalamount);
                cmd.Parameters.AddWithValue("@Price", price);
                Main_Class.connection.Open();
                count = cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return count;
        }
        public byte insertReceipt(string invoiceno, string receiptno, DateTime date, string remarks, string cheque_cash, float amount, float incometax)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertReceipt", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InoiceNo", invoiceno);
                cmd.Parameters.AddWithValue("@ReceiptNo", receiptno);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Remarks", remarks);
                cmd.Parameters.AddWithValue("@Cheque_Cash", cheque_cash);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@IncomeTax", incometax);
                Main_Class.connection.Open();
                cmd.ExecuteNonQuery();
                Main_Class.connection.Close();
                Custom_Message_Box.Show("Receipt No. "+receiptno + " created successfully", "Success", MessageBoxIcons.Information, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();  //if error is due to the connection so we close it on exception
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
                return 1;
            }
            return 0;
        }
    }
}
