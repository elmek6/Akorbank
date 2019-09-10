/*
 * Created by SharpDevelop.
 * User: OM
 * Date: 4/11/2012
 * Time: 1:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;//dataset icin

namespace AkorBank
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

		
		//Database dosya bin / debug icinde olmak zorunda
		OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=akorlar.mdb");
        OleDbCommand kmt = new OleDbCommand();
        DataTable dt = new DataTable();
        OleDbDataAdapter adtr = new OleDbDataAdapter();

        
		void Button1Click(object sender, EventArgs e)
		{

        
            kmt.Connection = bag;
       //     kmt.CommandType = CommandType.StoredProcedure;
            kmt.CommandText = "Select * from KEYVIOL1";
            OleDbDataAdapter adtr = new OleDbDataAdapter(kmt);
            bag.Open();
            adtr.Fill(dt);
            bindingSource1.DataSource = dt;
         
            bag.Close();
            
         
           
		}
		
		void BindingNavigatorMoveNextItemClick(object sender, EventArgs e)
		{
		//	richTextBox1.Text = dataGrid1.DataMember(dataGrid1,);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
            //dataGrid1.DataSource = dt;

          //  textBox2.Text = dt.Rows[0].ItemArray[4].ToString();


			//textBox2.DataBindings.Add(new Binding ("Text", dt, "Sozler"));
			textBox2.DataBindings.Add(new Binding ("Text", bindingSource1, "Sozler"));
            
		}
		
		void Button4Click(object sender, EventArgs e)
		{

			//dataGrid1.Update;
			button4.Text = dt.Rows[0].ItemArray[4].ToString();
/*			
	        bag.Open();
	        kmt.Connection = bag;
	        kmt.CommandText = "INSERT INTO musbil(Bos,Parca,Artist,Album,Sozler) VALUES ('" + t1 + "','" + t2 + "','" + t3 + "','" + t4 + "','" + t5 + "') ";
	        kmt.ExecuteNonQuery();
	        kmt.Dispose();
	        bag.Close();
	        //frm1.dtst.Tables["musbil"].Clear();
	        //frm1.listele();
*/	        
		}
	}
}
