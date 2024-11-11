using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z3_v9_SergeevaAgata
{
    public class Stores
    {
        //поля класса
        public string title; //название магазина
        public string director; //директор магазина
        public int salesCount; //количество продаж
        public decimal monthlyRevenue; //выручка за месяц

        //конструктор
        public Stores(string title, string director, int salesCount, decimal monthlyRevenue)
        {
            this.title = title;
            this.director = director;
            this.salesCount = salesCount;
            this.monthlyRevenue = monthlyRevenue;
        }
        //функция добавления элементов в коллекцию
        public void AddStore(List<Stores> storeList, Stores store)
        {
            storeList.Add(store);
        }


        //функция вывода информации в dataGridView
        public virtual void Show(DataGridView dgv)
        {
            dgv.Rows.Add(
                title,
                director,
                salesCount,
                monthlyRevenue
            );
        }

        //функция, которая определяет качество объекта – Q по заданной формуле
        public decimal Q()
        {
            if (salesCount > 0)
            {
                return monthlyRevenue / salesCount; // Если есть продажи, делим доход на количество продаж
            }
            else
            {
                return 0; // Если продаж нет, возвращаем 0
            }
        }

        //перегрузка №1. удаляющая элемент коллекции по названию магазина
        public bool RemoveStore(List<Stores> storeList, string storeName)
        {
            var storeToRemove = storeList.FirstOrDefault(s => s.title.Equals(storeName, StringComparison.OrdinalIgnoreCase));
            if (storeToRemove != null)
            {
                storeList.Remove(storeToRemove);
                return true;
            }
            return false;
        }

        //перегрузка №2. удаляющая элемент коллекции по названию количеству продаж
        public bool RemoveStore(List<Stores> storeList, int salesCount)
        {
            int removedCount = storeList.RemoveAll(s => s.salesCount <= salesCount);
            return removedCount > 0;
        }

        //перегрузка №3. удаляющая элемент коллекции по выручке за месяц
        public bool RemoveStore(List<Stores> storeList, decimal monthlyRevenue)
        {
            int removedCount = storeList.RemoveAll(s => s.monthlyRevenue <= monthlyRevenue);
            return removedCount > 0;
        }

    }
}
