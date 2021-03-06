﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODEL.MyService;
using HELPER;

namespace VIEW_GUI.Users.Admin.SystemTables
{
    public partial class frmSizes : System.Web.UI.Page
    {
        private MyServiceClient client;
        private Sizes sizes;
       
        private GridViewColumnDefinitions columns;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new MyServiceClient();
            sizes = client.SelectAllSizes();

            // הגדרת עמודות
            columns = new GridViewColumnDefinitions();
            columns.Add(new GridViewColumnDefinition(
                                                        "Name",
                                                        "גודל",
                                                        ColumnType.STRING_COLUMN,
                                                        ColumnAligment.CENTER
                                                     )
                      );
            if (!IsPostBack)
            {
                // גריד עם אפשרויות עריכה
                GridViewUtilities.SetColumns<Size>(                //     Grid-הטיפוס המוצג ב
                                                   grdCities,     //            Grid-שם ה
                                                   sizes,         //           רשימת הישובים
                                                   columns,        //           רשימת העמודות 
                                                   20,             //            Grid-רוחב ה
                                                   true            //         לכלול עמודת עריכה
                                                  );
            }
        }

            protected void grdCities_RowEditing(object sender, GridViewEditEventArgs e)
            {
                Size size = sizes[e.NewEditIndex];
                pnlCity.Visible = true;
                txtCity.Text = size.Name;

                Session["EDITMODE"] = true;
                Session["OLDSIZE"] = size;
                grdCities.EditIndex = -1;

            }
            protected void grdCities_RowDeleting(object sender, GridViewDeleteEventArgs e)
            {
                Size size = sizes[e.RowIndex];

                client.DeleteSize(size);
                Response.Redirect(Request.RawUrl);

            }
            protected void btnAdd_Click(object sender, EventArgs e)
            {
                pnlCity.Visible = true;
            }
            protected void btnOk_Click(object sender, EventArgs e)
            {
                Size oldSize = (Size)Session["OLDSIZE"];

                Size newSize = new Size();
                newSize.Name = txtCity.Text;

                if (Session["EDITMODE"] == null || !(bool)Session["EDITMODE"])
                    client.AddSize(newSize);
                else
                {
                    client.ModifySize(oldSize, newSize);
                    Session["EDITMODE"] = false;
                    Session["OLDSIZE"] = null;
                }

                txtCity.Text = "";
                pnlCity.Visible = false;

                Response.Redirect(Request.RawUrl);
            }
            protected void btnCancel_Click(object sender, EventArgs e)
            {
                txtCity.Text = "";
                pnlCity.Visible = false;
            }
        protected void grdCities_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            // בדיקה אם השורה היא שורת נתונים
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // קח את הפקד הראשון בשורה – זהו פקד "פיקוד"
                DataControlFieldCell cell = (DataControlFieldCell)e.Row.Controls[0];

                // מתוך הפקד שנבחר, חלץ את תמונת ה"פיקוד"
                Image img = (Image)cell.Controls[2];
                // הפוך את התמונה לכפתור תמונה
                ImageButton imgBtn = (ImageButton)img;

                // אם הכפתור הוא כפתור מחיקה
                if (imgBtn.CommandName == "Delete")
                {
                    // הרכב את משפט השאלה
                    //        כולל שם הישוב
                    string message = @"האם למחוק את """ + DataBinder.Eval(e.Row.DataItem, "Name") + @""" ?";

                    // onclick הוסף לתמונה את האירוע 
                    img.Attributes.Add("onclick",
                         "javascript:" +
                         "if (!confirm('" + message + "')){ return false;}");

                }
            }


        }
    }
}