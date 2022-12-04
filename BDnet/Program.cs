using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDnet
{
    internal static class Program
    {
        public static User usr;
        public static Form1 authForm;
        public static mainWindow mainWin;
        public static dish_statistic dish_Statistic;
        public static Order_compos order_Compos;
        public static addNewPerson addNewPerson;
        public static personalStat personalStatistic;
        public static PersonalUpdate personalUpdate;
        public static allView allview;
        public static oficiantsView oficiants;
        public static chefsView chefs;
        public static smallView smallview;
        public static smena_money smena;

        public static mainWindowChefs mainWindowChefs;
        public static receipt_for receipt;

        public static mainWindowOficiants oficiantsWindow;
        public static menuStatistic menuStat;
        public static order_compos_ofic ord_composit;
        public static get_check check;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            authForm= new Form1();
            mainWin= new mainWindow();
            dish_Statistic= new dish_statistic();
            order_Compos= new Order_compos();
            addNewPerson= new addNewPerson();
            personalStatistic= new personalStat();
            personalUpdate=new PersonalUpdate();
            allview= new allView();
            oficiants= new oficiantsView();
            chefs= new chefsView();
            smallview = new smallView();
            mainWindowChefs = new mainWindowChefs();
            receipt = new receipt_for();
            oficiantsWindow = new mainWindowOficiants();
            menuStat = new menuStatistic();
            ord_composit = new order_compos_ofic();
            check = new get_check();
            smena = new smena_money();
            Application.Run(authForm);
        }
    }
}
