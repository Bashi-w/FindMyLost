﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace FindMyLost
{
    public partial class ItemProfile : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public ItemProfile()
        {
            InitializeComponent();
        }

        public static string itemID = "";
        string SelectedItemID = ItemList.SelectedItemID;

        private void ItemProfile_Load(object sender, EventArgs e)
        {
            try
            {
                byte[] imageBytes;

                string sql = "SELECT * FROM Lost_Item WHERE item_id = '" + SelectedItemID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblCategory.Text = dr["item_category"].ToString();
                    lblID.Text = dr["item_id"].ToString();
                    lblBrand.Text = dr["item_brand"].ToString();
                    lblLastSeen.Text = dr["last_seen_location"].ToString();
                    lblAddInfo.Text = dr["additional_info"].ToString();

                    string item_color = dr["item_colour"].ToString();
                    if (item_color == "Red")
                    {
                        pbColor.BackColor = Color.FromArgb(80, 0, 0);
                    }
                    else if (item_color == "Orange")
                    {
                        pbColor.BackColor = Color.FromArgb(203, 92, 12);
                    }
                    else if (item_color == "Yellow")
                    {
                        pbColor.BackColor = Color.FromArgb(217, 181, 30);
                    }
                    else if (item_color == "Green")
                    {
                        pbColor.BackColor = Color.FromArgb(73, 94, 53);
                    }
                    else if (item_color == "Blue")
                    {
                        pbColor.BackColor = Color.FromArgb(0, 51, 102);
                    }
                    else if (item_color == "Purple")
                    {
                        pbColor.BackColor = Color.FromArgb(52, 32, 72);
                    }
                    else if (item_color == "Pink")
                    {
                        pbColor.BackColor = Color.FromArgb(241, 145, 155);
                    }
                    else if (item_color == "Beige")
                    {
                        pbColor.BackColor = Color.FromArgb(145, 121, 77);
                    }
                    else if (item_color == "Brown")
                    {
                        pbColor.BackColor = Color.FromArgb(68, 33, 18);
                    }
                    else if (item_color == "Gray")
                    {
                        pbColor.BackColor = Color.FromArgb(50, 50, 50);
                    }
                    else if (item_color == "Black")
                    {
                        pbColor.BackColor = Color.FromArgb(0, 0, 0);
                    }
                    else if (item_color == "White")
                    {
                        pbColor.BackColor = Color.FromArgb(255, 255, 255);
                    }

                    imageBytes = (byte[])dr["item_picture"];
                    MemoryStream ms = new MemoryStream(imageBytes);
                    Image img = Image.FromStream(ms);
                    pbItemPic.Image = img;

                    itemID = SelectedItemID;

                }
                else
                {
                    MessageBox.Show("Invalid Item ID.", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            Dashboard.DisplayEditItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete Item?", "FindMyLost", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string sql = "DELETE from Lost_Item WHERE item_id = '" + SelectedItemID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item deleted.", "FindMyLost", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                Dashboard.ShowItemList();
                Dashboard.ShowDefault();
            }
        }

        private void ItemProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

    }
}
