﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;//for DB connectivity: ADO.NET
using System.Data.SqlClient;//for DB connectivity: ADO.NET
using System.Configuration;//for web.config

public partial class AddTrain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        try{
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);//create DB Connection
        con.Open();//open DB connection

        string qry = "insert into Train values(@t1,@t2,@t3,@t4,@t5)";//SQL Query
        SqlCommand cmd = new SqlCommand(qry, con);//Send Query for execution
        cmd.Parameters.AddWithValue("@t1", TextBox1.Text);//Passing Paramiters to the Query
        cmd.Parameters.AddWithValue("@t2", TextBox2.Text);
        cmd.Parameters.AddWithValue("@t3", TextBox3.Text);
        cmd.Parameters.AddWithValue("@t4", TextBox4.Text);
        cmd.Parameters.AddWithValue("@t5", TextBox5.Text);
        int i = cmd.ExecuteNonQuery();//
        if (i == 1)
        {
            Label6.Visible = true;
            Label6.Text = "Record Saved SuccesFully";
        }
        con.Close();
        }
        catch (SqlException ex)//Exception  for catching error By using SqlException class
        {
            Response.Write(ex);
        }
    }
}