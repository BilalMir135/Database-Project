using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Standard_Books.Classes
{
    class Retreival
    {
        public void showCurrency(DataGridView dgv, DataGridViewColumn currencyId, DataGridViewColumn symbol, DataGridViewColumn currencyname, DataGridViewColumn exchangerate, string data=null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getCurrencyData", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getCurrencyDataLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);            
                currencyId.DataPropertyName = dt.Columns["ID"].ToString();
                symbol.DataPropertyName = dt.Columns["Symbol"].ToString();
                currencyname.DataPropertyName = dt.Columns["Currency Name"].ToString();
                exchangerate.DataPropertyName = dt.Columns["Exchange Rate"].ToString();                
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showFreighty(DataGridView dgv, DataGridViewColumn freightId, DataGridViewColumn abbre, DataGridViewColumn dest, DataGridViewColumn charges, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getFreightData", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getFreightDataLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                freightId.DataPropertyName = dt.Columns["ID"].ToString();
                abbre.DataPropertyName = dt.Columns["Abbreviation"].ToString();
                dest.DataPropertyName = dt.Columns["Destination"].ToString();
                charges.DataPropertyName = dt.Columns["Charges"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showPublisher(DataGridView dgv, DataGridViewColumn publisherId, DataGridViewColumn code, DataGridViewColumn name, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getPublisherData", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getPublisherDataLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                publisherId.DataPropertyName = dt.Columns["ID"].ToString();
                code.DataPropertyName = dt.Columns["Code"].ToString();
                name.DataPropertyName = dt.Columns["Name"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showSubject(DataGridView dgv, DataGridViewColumn subjectId, DataGridViewColumn subjectname, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getSubjectData", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getSubjectDataLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                subjectId.DataPropertyName = dt.Columns["ID"].ToString();
                subjectname.DataPropertyName = dt.Columns["Subject Name"].ToString();             
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showBooksSubject(DataGridView dgv, DataGridViewColumn subjectId, DataGridViewColumn subjectname, string ISBN)
        {
            try
            {            
                SqlCommand cmd = new SqlCommand("sp_getBooksSubject", Main_Class.connection);              
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                subjectId.DataPropertyName = dt.Columns["ID"].ToString();
                subjectname.DataPropertyName = dt.Columns["Name"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showAuthor(DataGridView dgv, DataGridViewColumn authorId, DataGridViewColumn authorname, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getAuthorData", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getAuthorDataLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                authorId.DataPropertyName = dt.Columns["ID"].ToString();
                authorname.DataPropertyName = dt.Columns["Author Name"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showBooks(DataGridView dgv, DataGridViewColumn ISBN, DataGridViewColumn Title, DataGridViewColumn authorID, DataGridViewColumn author, DataGridViewColumn subjectID, DataGridViewColumn subject, 
        DataGridViewColumn publisherID, DataGridViewColumn publisher, DataGridViewColumn pubyear, DataGridViewColumn currencyID, DataGridViewColumn currency, DataGridViewColumn price, DataGridViewColumn quantity, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getBooksData", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getBooksDataLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                ISBN.DataPropertyName = dt.Columns["ISBN"].ToString();
                Title.DataPropertyName = dt.Columns["Title"].ToString();
                authorID.DataPropertyName = dt.Columns["AuthorID"].ToString();
                author.DataPropertyName = dt.Columns["Author Name"].ToString();
                subjectID.DataPropertyName = dt.Columns["SubjectID"].ToString();
                subject.DataPropertyName = dt.Columns["Subject Name"].ToString();
                publisherID.DataPropertyName = dt.Columns["PublisherID"].ToString();
                publisher.DataPropertyName = dt.Columns["Publisher Name"].ToString();
                pubyear.DataPropertyName = dt.Columns["Publishing Year"].ToString();
                currencyID.DataPropertyName = dt.Columns["CurrencyID"].ToString();
                currency.DataPropertyName = dt.Columns["CurrencyName"].ToString();
                price.DataPropertyName = dt.Columns["Price"].ToString();              
                quantity.DataPropertyName = dt.Columns["Quantity"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showParty(DataGridView dgv, DataGridViewColumn partyId, DataGridViewColumn name, DataGridViewColumn address, DataGridViewColumn city, DataGridViewColumn province, DataGridViewColumn country, DataGridViewColumn phone,
        DataGridViewColumn fax, DataGridViewColumn email, DataGridViewColumn code, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getPartyData", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getPartyDataLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                partyId.DataPropertyName = dt.Columns["ID"].ToString();
                name.DataPropertyName = dt.Columns["Name"].ToString();
                address.DataPropertyName = dt.Columns["Address"].ToString();
                city.DataPropertyName = dt.Columns["City"].ToString();
                province.DataPropertyName = dt.Columns["Province"].ToString();
                country.DataPropertyName = dt.Columns["Country"].ToString();
                phone.DataPropertyName = dt.Columns["Phone"].ToString();
                fax.DataPropertyName = dt.Columns["Fax"].ToString();
                email.DataPropertyName = dt.Columns["Email"].ToString();
                code.DataPropertyName = dt.Columns["Code"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showSupplier(DataGridView dgv, DataGridViewColumn supplierId, DataGridViewColumn name, DataGridViewColumn address, DataGridViewColumn city, DataGridViewColumn province, DataGridViewColumn country, DataGridViewColumn phone,
        DataGridViewColumn fax, DataGridViewColumn email, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getSupplierData", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getSupplierDataLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                supplierId.DataPropertyName = dt.Columns["ID"].ToString();
                name.DataPropertyName = dt.Columns["Name"].ToString();
                address.DataPropertyName = dt.Columns["Address"].ToString();
                city.DataPropertyName = dt.Columns["City"].ToString();
                province.DataPropertyName = dt.Columns["Province"].ToString();
                country.DataPropertyName = dt.Columns["Country"].ToString();
                phone.DataPropertyName = dt.Columns["Phone"].ToString();
                fax.DataPropertyName = dt.Columns["Fax"].ToString();
                email.DataPropertyName = dt.Columns["Email"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showPurchase(DataGridView dgv, DataGridViewColumn purchaseId, DataGridViewColumn purchaseNo, DataGridViewColumn date, DataGridViewColumn supplierid, DataGridViewColumn supplier, DataGridViewColumn books, DataGridViewColumn amount, DataGridViewColumn totalamount, DataGridViewColumn reference, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getPurchase", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getPurchaseLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                purchaseId.DataPropertyName = dt.Columns["ID"].ToString();
                purchaseNo.DataPropertyName = dt.Columns["PurchaseNo"].ToString();
                supplierid.DataPropertyName = dt.Columns["SupplierID"].ToString();
                supplier.DataPropertyName = dt.Columns["Name"].ToString();
                date.DataPropertyName = dt.Columns["Date"].ToString();
                books.DataPropertyName = dt.Columns["Books"].ToString();
                amount.DataPropertyName = dt.Columns["Amount"].ToString();
                totalamount.DataPropertyName = dt.Columns["Total Amount"].ToString();
                reference.DataPropertyName = dt.Columns["Reference"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showPurchaseDetails(DataGridView dgv, DataGridViewColumn ISBN, DataGridViewColumn title, DataGridViewColumn price, DataGridViewColumn quantity, DataGridViewColumn amount, DataGridViewColumn discount, DataGridViewColumn finalamount, long purchaseid, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getPurchaseDetails", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getPurchaseDetailsLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.Parameters.AddWithValue("@PurchaseID", purchaseid);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                ISBN.DataPropertyName = dt.Columns["ISBN"].ToString();
                title.DataPropertyName = dt.Columns["Title"].ToString();
                price.DataPropertyName = dt.Columns["Price"].ToString();
                quantity.DataPropertyName = dt.Columns["Quantity"].ToString();
                amount.DataPropertyName = dt.Columns["Amount"].ToString();
                discount.DataPropertyName = dt.Columns["Discount"].ToString();
                finalamount.DataPropertyName = dt.Columns["FinalAmount"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showInvoice(DataGridView dgv, DataGridViewColumn invoiceId, DataGridViewColumn invoiceNo, DataGridViewColumn date, DataGridViewColumn batch, DataGridViewColumn partyid, DataGridViewColumn party, DataGridViewColumn books, DataGridViewColumn amount, DataGridViewColumn totalamount, DataGridViewColumn reference, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getInvoice", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getInvoiceLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                invoiceId.DataPropertyName = dt.Columns["ID"].ToString();
                invoiceNo.DataPropertyName = dt.Columns["InvoiceNo"].ToString();
                partyid.DataPropertyName = dt.Columns["PartyID"].ToString();
                party.DataPropertyName = dt.Columns["Name"].ToString();
                batch.DataPropertyName = dt.Columns["Batch"].ToString();
                date.DataPropertyName = dt.Columns["Date"].ToString();
                books.DataPropertyName = dt.Columns["Books"].ToString();
                totalamount.DataPropertyName = dt.Columns["Total Amount"].ToString();
                amount.DataPropertyName = dt.Columns["Amount"].ToString();
                reference.DataPropertyName = dt.Columns["Reference"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showInvoiceDetails(DataGridView dgv, DataGridViewColumn ISBN, DataGridViewColumn title, DataGridViewColumn price, DataGridViewColumn quantity, DataGridViewColumn amount, DataGridViewColumn discount, DataGridViewColumn finalamount, long invoiceid, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getInvoiceDetails", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getInvoiceDetailsLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.Parameters.AddWithValue("@InvoiceID", invoiceid);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                ISBN.DataPropertyName = dt.Columns["ISBN"].ToString();
                title.DataPropertyName = dt.Columns["Title"].ToString();
                price.DataPropertyName = dt.Columns["Price"].ToString();
                quantity.DataPropertyName = dt.Columns["Quantity"].ToString();
                amount.DataPropertyName = dt.Columns["Amount"].ToString();
                discount.DataPropertyName = dt.Columns["Discount"].ToString();
                finalamount.DataPropertyName = dt.Columns["FinalAmount"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showChallan(DataGridView dgv, DataGridViewColumn challanId, DataGridViewColumn challanNo, DataGridViewColumn date, DataGridViewColumn batch, DataGridViewColumn partyid, DataGridViewColumn party, DataGridViewColumn books, DataGridViewColumn amount, DataGridViewColumn totalamount, DataGridViewColumn reference, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getChallan", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getChallanLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                challanId.DataPropertyName = dt.Columns["ID"].ToString();
                challanNo.DataPropertyName = dt.Columns["ChallanNo"].ToString();
                partyid.DataPropertyName = dt.Columns["PartyID"].ToString();
                party.DataPropertyName = dt.Columns["Name"].ToString();
                batch.DataPropertyName = dt.Columns["Batch"].ToString();
                date.DataPropertyName = dt.Columns["Date"].ToString();
                books.DataPropertyName = dt.Columns["Books"].ToString();
                amount.DataPropertyName = dt.Columns["Amount"].ToString();
                totalamount.DataPropertyName = dt.Columns["Total Amount"].ToString();
                reference.DataPropertyName = dt.Columns["Reference"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showChallanDetails(DataGridView dgv, DataGridViewColumn ISBN, DataGridViewColumn title, DataGridViewColumn price, DataGridViewColumn quantity, DataGridViewColumn amount, DataGridViewColumn discount, DataGridViewColumn finalamount, long challanid, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getChallanDetails", Main_Class.connection);                   
                }
                else
                {
                    cmd = new SqlCommand("sp_getChallanDetailsLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.Parameters.AddWithValue("@ChallanID", challanid);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                ISBN.DataPropertyName = dt.Columns["ISBN"].ToString();
                title.DataPropertyName = dt.Columns["Title"].ToString();
                price.DataPropertyName = dt.Columns["Price"].ToString();
                quantity.DataPropertyName = dt.Columns["Quantity"].ToString();
                amount.DataPropertyName = dt.Columns["Amount"].ToString();
                discount.DataPropertyName = dt.Columns["Discount"].ToString();
                finalamount.DataPropertyName = dt.Columns["FinalAmount"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showQuotation(DataGridView dgv, DataGridViewColumn quotationId, DataGridViewColumn quotationNo, DataGridViewColumn date, DataGridViewColumn title, DataGridViewColumn partyid, DataGridViewColumn party, DataGridViewColumn books, DataGridViewColumn amount, DataGridViewColumn totalamount, DataGridViewColumn reference, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getQuotation", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getQuotationLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                quotationId.DataPropertyName = dt.Columns["ID"].ToString();
                quotationNo.DataPropertyName = dt.Columns["QuotationNo"].ToString();
                partyid.DataPropertyName = dt.Columns["PartyID"].ToString();
                party.DataPropertyName = dt.Columns["Name"].ToString();
                title.DataPropertyName = dt.Columns["Title"].ToString();
                date.DataPropertyName = dt.Columns["Date"].ToString();
                books.DataPropertyName = dt.Columns["Books"].ToString();
                amount.DataPropertyName = dt.Columns["Amount"].ToString();
                totalamount.DataPropertyName = dt.Columns["Total Amount"].ToString();
                reference.DataPropertyName = dt.Columns["Reference"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showQuotationDetails(DataGridView dgv, DataGridViewColumn ISBN, DataGridViewColumn title, DataGridViewColumn price, DataGridViewColumn quantity, DataGridViewColumn amount, DataGridViewColumn discount, DataGridViewColumn finalamount, long quotationid, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getQuotationDetails", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getQuotationDetailsLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.Parameters.AddWithValue("@QuotationID", quotationid);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                ISBN.DataPropertyName = dt.Columns["ISBN"].ToString();
                title.DataPropertyName = dt.Columns["Title"].ToString();
                price.DataPropertyName = dt.Columns["Price"].ToString();
                quantity.DataPropertyName = dt.Columns["Quantity"].ToString();
                amount.DataPropertyName = dt.Columns["Amount"].ToString();
                discount.DataPropertyName = dt.Columns["Discount"].ToString();
                finalamount.DataPropertyName = dt.Columns["FinalAmount"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void showReceipts(DataGridView dgv, DataGridViewColumn ID, DataGridViewColumn invoiceNo, DataGridViewColumn receiptNo, DataGridViewColumn date, DataGridViewColumn remarks, DataGridViewColumn cc,
        DataGridViewColumn incomeTax, DataGridViewColumn amount, DataGridViewColumn paidamount, DataGridViewColumn invoicedate, DataGridViewColumn invoiceamount, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("sp_getReceiptsData", Main_Class.connection);
                }
                else
                {
                    cmd = new SqlCommand("sp_getReceiptsDataLike", Main_Class.connection);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                ID.DataPropertyName = dt.Columns["ID"].ToString();
                invoiceNo.DataPropertyName = dt.Columns["InvoiceNo"].ToString();
                receiptNo.DataPropertyName = dt.Columns["ReceiptNo"].ToString();
                date.DataPropertyName = dt.Columns["Date"].ToString();
                remarks.DataPropertyName = dt.Columns["Remarks"].ToString();
                cc.DataPropertyName = dt.Columns["CC"].ToString();
                incomeTax.DataPropertyName = dt.Columns["IncomeTax"].ToString();
                amount.DataPropertyName = dt.Columns["Amount"].ToString();
                paidamount.DataPropertyName = dt.Columns["PaidAmount"].ToString();
                invoicedate.DataPropertyName = dt.Columns["InvoiceDate"].ToString();
                invoiceamount.DataPropertyName = dt.Columns["InvoiceAmount"].ToString();
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public void getData(string procedure, string display_member, string value_member, ComboBox cbx)
        {
            try
            {
                cbx.DataSource = null;
                cbx.Items.Clear();
                SqlCommand cmd = new SqlCommand(procedure, Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                cbx.DisplayMember = display_member;
                cbx.ValueMember = value_member;
                cbx.DataSource = dt;
                cbx.SelectedIndex = -1;                  
            }
            catch (Exception ex)
            {
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }

        private string[] BookData = new string[4];
        public string[] getBookbyISBN(string ISBN)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_getBookbyISBN", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                Main_Class.connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        BookData[0] = dr[0].ToString();
                        BookData[1] = dr[1].ToString();
                        BookData[2] = dr[2].ToString();
                        BookData[3] = dr[3].ToString();
                    }                 
                }
                else
                {
                    Custom_Message_Box.Show("No book available of ISBN no: "+ISBN, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
                }
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return BookData;
        }

        private string[] ChallanData = new string[9];
        public string[] getChallanbyChallanNo(string ChallanNo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_getChallanbyChallanNo", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ChallanNo", ChallanNo);
                Main_Class.connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ChallanData[0] = dr[0].ToString();
                        ChallanData[1] = dr[1].ToString();
                        ChallanData[2] = dr[2].ToString();
                        ChallanData[3] = dr[3].ToString();
                        ChallanData[4] = dr[4].ToString();
                        ChallanData[5] = dr[5].ToString();
                        ChallanData[6] = dr[6].ToString();
                        ChallanData[7] = dr[7].ToString();
                        ChallanData[8] = dr[8].ToString();
                    }
                }
                else
                {
                    Custom_Message_Box.Show("Challan Number " + ChallanNo+" doesnot exist.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
                }
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return ChallanData;
        }

        private string[] PurchaseData = new string[7];
        public string[] getPurchasebyPurchaseNo(string PurchaseNo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_getPurchasebyPurchaseNo", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PurchaseNo", PurchaseNo);
                Main_Class.connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        PurchaseData[0] = dr[0].ToString();
                        PurchaseData[1] = dr[1].ToString();
                        PurchaseData[2] = dr[2].ToString();
                        PurchaseData[3] = dr[3].ToString();
                        PurchaseData[4] = dr[4].ToString();
                        PurchaseData[5] = dr[5].ToString();
                        PurchaseData[6] = dr[6].ToString();
                    }
                }
                else
                {
                    Custom_Message_Box.Show("Purchase Number " + PurchaseNo + " doesnot exist.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
                }
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return PurchaseData;
        }

        private string[] InvoiceData = new string[16];
        public string[] getInvoicebyInvoiceNo(string InvoiceNo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_getInvoicebyInvoiceNo", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNo);
                Main_Class.connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        InvoiceData[0] = dr[0].ToString();
                        InvoiceData[1] = dr[1].ToString();
                        InvoiceData[2] = dr[2].ToString();
                        InvoiceData[3] = dr[3].ToString();
                        InvoiceData[4] = dr[4].ToString();
                        InvoiceData[5] = dr[5].ToString();
                        InvoiceData[6] = dr[6].ToString();
                        InvoiceData[7] = dr[7].ToString();
                        InvoiceData[8] = dr[8].ToString();
                        InvoiceData[9] = dr[9].ToString();
                        InvoiceData[10] = dr[10].ToString();
                        InvoiceData[11] = dr[11].ToString();
                        InvoiceData[12] = dr[12].ToString();
                        InvoiceData[13] = dr[13].ToString();
                        InvoiceData[14] = dr[14].ToString();
                        InvoiceData[15] = dr[15].ToString();
                    }
                }
                else
                {
                    Custom_Message_Box.Show("Invoice Number " + InvoiceNo + " doesnot exist.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
                }
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return InvoiceData;
        }

        private string[] QuotationData = new string[9];
        public string[] getQuotationbyQuotationNo(string QuotationNo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_getQuotationbyQuotationNo", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@QuotationNo", QuotationNo);
                Main_Class.connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        QuotationData[0] = dr[0].ToString();
                        QuotationData[1] = dr[1].ToString();
                        QuotationData[2] = dr[2].ToString();
                        QuotationData[3] = dr[3].ToString();
                        QuotationData[4] = dr[4].ToString();
                        QuotationData[5] = dr[5].ToString();
                        QuotationData[6] = dr[6].ToString();
                        QuotationData[7] = dr[7].ToString();
                        QuotationData[8] = dr[8].ToString();
                    }
                }
                else
                {
                    Custom_Message_Box.Show("Quotation Number " + QuotationNo + " doesnot exist.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
                }
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return QuotationData;
        }

        private string[] parameters = new string[12];
        public string[] getparameters()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_getParameters", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                Main_Class.connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        parameters[0] = dr[0].ToString();
                        parameters[1] = dr[1].ToString();
                        parameters[2] = dr[2].ToString();
                        parameters[3] = dr[3].ToString();
                        parameters[4] = dr[4].ToString();
                        parameters[5] = dr[5].ToString();
                        parameters[6] = dr[6].ToString();
                        parameters[7] = dr[7].ToString();
                        parameters[8] = dr[8].ToString();
                        parameters[9] = dr[9].ToString();
                        parameters[10] = dr[10].ToString();
                        parameters[11] = dr[11].ToString();
                    }
                }               
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return parameters;
        }      
        public void showDetails(DataGridView dgv, string procedure, string parameter, long id)
        {
            try
            {
                SqlCommand cmd;                         
                cmd = new SqlCommand(procedure, Main_Class.connection);
                cmd.Parameters.AddWithValue(parameter, id);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                foreach(DataRow row in dt.Rows)
                {
                    dgv.Rows.Add(0, row["ISBN"].ToString(), row["Title"].ToString(), row["Price"].ToString(), row["Quantity"].ToString(), row["Amount"].ToString(), row["Discount"].ToString(), row["FinalAmount"].ToString());
                }                               
            }
            catch (Exception ex)
            {

                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
        }
        public DataTable getDetails(string procedure, string parameter, long id)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand(procedure, Main_Class.connection);
                cmd.Parameters.AddWithValue(parameter, id);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);             
                adap.Fill(dt);             
            }
            catch (Exception ex)
            {
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return dt;
        }

        ReportDocument rd;
        public void getDataforReport(object data, string path, string procedure, string parameter, CrystalReportViewer crv, byte condition, short pubyear)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, Main_Class.connection);
                cmd.Parameters.AddWithValue(parameter, data);
                if (condition != 4 && pubyear != 1)
                {
                    cmd.Parameters.AddWithValue("@Condition", condition);
                    cmd.Parameters.AddWithValue("@PubYear", pubyear);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                rd = new ReportDocument();
                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;
                rd.Load(Application.StartupPath + path);
                rd.Refresh();
                rd.SetDataSource(dt);                
                crConnectionInfo.IntegratedSecurity = true;
                crConnectionInfo.ServerName = Properties.Settings.Default.ServerName;
                crConnectionInfo.DatabaseName = Properties.Settings.Default.Database;

                CrTables = rd.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }

                crv.ReportSource = rd;
                rd.SetParameterValue(0, data);
                if (condition != 4 && pubyear != 1)
                {
                    rd.SetParameterValue(1, condition);
                    rd.SetParameterValue(2, pubyear);
                }
                crv.SelectionMode = CrystalDecisions.Windows.Forms.SelectionMode.None;            
                crv.RefreshReport();
            }
            catch (Exception ex)
            {
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            
        }
        public void closerd()
        {
            if(rd!=null)
                 rd.Close();
        }

        private int stockquantity;
        public int getStockQuantity(string ISBN)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_getQuantity", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                Main_Class.connection.Open();
                stockquantity = Convert.ToInt32(cmd.ExecuteScalar());
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return stockquantity;
        }

        private int partyid;
        public int getPartybyCode(int code)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_getPartybyCode", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", code);
                Main_Class.connection.Open();
                partyid = Convert.ToInt32(cmd.ExecuteScalar());
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return partyid;
        }
        public int getCodebyPartyID(int partyid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_getCodebyPartyID", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PartyID", partyid);
                Main_Class.connection.Open();
                partyid = Convert.ToInt32(cmd.ExecuteScalar());
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return partyid;
        }

        private string currency_with_rate;
        public string getCurrencybyISBN(string ISBN)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_getCurrancybyISBN", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                Main_Class.connection.Open();
                currency_with_rate = cmd.ExecuteScalar().ToString();
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return currency_with_rate;
        }

        private string[] Receipt = new string[3];
        public string[] getInvoiceforReceipt(string InvoiceNo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_getInvoiceforReceipt", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNo);
                Main_Class.connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Receipt[0] = dr[0].ToString();
                        Receipt[1] = dr[1].ToString();
                        Receipt[2] = dr[2].ToString();                       
                    }
                }
                else
                {
                    Custom_Message_Box.Show("Invoice Number " + InvoiceNo + " doesnot exist.", "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
                }
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return Receipt;
        }
        private string[] links = new string[6];
        public string[] getlinks()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_getLinks", Main_Class.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                Main_Class.connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        links[0] = dr[0].ToString();
                        links[1] = dr[1].ToString();
                        links[2] = dr[2].ToString();
                        links[3] = dr[3].ToString();
                        links[4] = dr[4].ToString();
                        links[5] = dr[5].ToString();
                    }
                }
                Main_Class.connection.Close();
            }
            catch (Exception ex)
            {
                Main_Class.connection.Close();
                Custom_Message_Box.Show(ex.Message, "Error", MessageBoxIcons.Error, MessageBoxButtons.OK);
            }
            return links;
        }
    }
}
