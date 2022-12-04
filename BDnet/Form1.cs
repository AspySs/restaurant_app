using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BDnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            // Создать объект Command из объекта Connection.
            SqlCommand cmd = conn.CreateCommand();

            // Set Command Text
            String login = textBox2.Text;
            cmd.CommandText = "SELECT * FROM personal WHERE login=\'"+login+ "\'";
            DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                int pas_num = reader.GetOrdinal("password");
                String pass = reader.GetString(pas_num);
                if(pass == DBUtils.GetHash(textBox1.Text))
                {
                    Program.usr = new User(login, reader);
                    if (Program.usr.getStatus())
                    {
                        this.Visible = false;
                        visiblePages();
                        
                    }
                    else
                    {
                        MessageBox.Show("Вы были уволены", "Ошибка авторизации");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль, попробуйте снова", "Ошибка авторизации");
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден, попробуйте снова", "Ошибка авторизации");
            }
            reader.Close();
            conn.Close();
        }

        private void visiblePages()
        {
            Program.mainWindowChefs.tabControl1.TabPages.Remove(Program.mainWindowChefs.tabPage4);
            switch (Program.usr.getPosition()) {
                case "admin":
                    Program.mainWin.Visible = true;
                    Program.mainWin.label2.Text = Program.usr.getName();
                    Program.mainWin.label3.Text = label3.Text = Program.usr.getPosition();
                    break;
                case "chef":
                    Program.mainWindowChefs.Visible = true;
                    Program.mainWindowChefs.label2.Text = Program.usr.getName();
                    Program.mainWindowChefs.label3.Text = label3.Text = Program.usr.getPosition();
                    try
                    {
                        Program.mainWindowChefs.dish_queue1TableAdapter.Fill(Program.mainWindowChefs.dataSet1.dish_queue1, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.usr.getId(), typeof(int))))));
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    break;
                case "s-chef":
                    Program.mainWindowChefs.tabControl1.TabPages.Add(Program.mainWindowChefs.tabPage4);
                    Program.mainWindowChefs.Visible = true;
                    Program.mainWindowChefs.label2.Text = Program.usr.getName();
                    Program.mainWindowChefs.label3.Text = label3.Text = Program.usr.getPosition();
                    try
                    {
                        Program.mainWindowChefs.dish_queue1TableAdapter.Fill(Program.mainWindowChefs.dataSet1.dish_queue1, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.usr.getId(), typeof(int))))));
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    break;
                case "oficiant":
                    Program.oficiantsWindow.Visible = true;
                    Program.oficiantsWindow.label2.Text = Program.usr.getName();
                    Program.oficiantsWindow.label3.Text = label3.Text = Program.usr.getPosition();
                    Program.oficiantsWindow.comboBox4.Visible = false;
                    Program.oficiantsWindow.comboBox5.Visible = false;
                    Program.oficiantsWindow.button8.Visible = false;
                    Program.oficiantsWindow.find_free_tablesDataGridView.Visible = false;
                    Program.oficiantsWindow.label7.Visible = false;
                    Program.oficiantsWindow.label8.Visible = false;
                    try
                    {
                        Program.oficiantsWindow.select_for_oficiantsTableAdapter.Fill(Program.oficiantsWindow.dataSet1.select_for_oficiants, new System.Nullable<int>(((int)(System.Convert.ChangeType(Program.usr.getId(), typeof(int))))));
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    break;
                default:
                    MessageBox.Show("Неизвестная роль, обратитесь к администратору", "Ошибка авторизации");
                    break;
            }
        }

    }
}
