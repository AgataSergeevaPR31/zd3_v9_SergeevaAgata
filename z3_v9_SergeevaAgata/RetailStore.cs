using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z3_v9_SergeevaAgata
{
    public class RetailStore : Stores
    {
        //поле
        public int p; //количество покупателей
        //свойства
        public string Rating { get; set; } //рейтинг магазина
        public string Address { get; set; } //адрес
        public bool IsOnline { get; set; } //онлайн магазин или физический

        //коллекция для хранения истории добавлений магазинов
        private Queue<string> historyQueue = new Queue<string>();

        //конструктор
        public RetailStore(string title, string director, int salesCount, decimal monthlyRevenue, int visitorsCount, string rating, string address, bool isOnline)
            : base(title, director, salesCount, monthlyRevenue)
        {
            p = visitorsCount;
            Rating = rating;
            Address = address;
            IsOnline = isOnline;
        }

        //переопределённая функция вывода информации в dataGridView
        public override void Show(DataGridView dgv)
        {
            dgv.Rows.Add(
                title,
                director,
                salesCount,
                monthlyRevenue,
                p,
                Rating,
                Address,
                IsOnline,
                Math.Round(Q(), 2), //округление до двух знаков после запятой
                Math.Round(Qp(), 2) //округление до двух знаков после запятой
            );
        }

        //Функция, которая определяет «качество» объекта класса потомка, которая перекрывает функцию качества базового класса, выполняя вычисления по новой формуле.
        public decimal Qp()
        {
            if (p > 50000)
            {
                return 2 * Q(); // Если p больше 50000, возвращаем удвоенное значение Q()
            }
            else
            {
                return 0.5m * Q(); // Если p меньше или равно 50000, возвращаем половину значения Q()
            }
        }
 

        // Метод для добавления магазина и сохранения его в истории
        public void AddHistory(string storeName)
        {
            historyQueue.Enqueue($"{storeName} - {DateTime.Now}");
        }

        // Метод для вывода истории в listBox
        public void ShowHistory(ListBox listBox)
        {
            foreach (var entry in historyQueue)
            {
                listBox.Items.Add(entry);
            }
        }

        public Queue<string> GetHistoryQueue()
        {
            return historyQueue;
        }

    }
}
