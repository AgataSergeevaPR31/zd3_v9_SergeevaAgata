using System.Windows.Forms;
using z3_v9_SergeevaAgata;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //проверяем значение Q, при salesCount = 10, monthlyRevenue = 1000.00m
        [Test]
        public void Q_MoreZero()
        {
            var store = new Stores("Магазин", "Иванов Иван Иванович", 10, 1000.00m);
            decimal result = store.Q();
            Assert.AreEqual(100.00m, result);
        }

        //проверяем значение Q, при salesCount = 0, monthlyRevenue = 1000.00m
        [Test]
        public void Q_LessZero()
        {
            var store = new Stores("Магазин", "Иванов Иван Иванович", 0, 1000.00m);
            decimal result = store.Q();
            Assert.AreEqual(0, result);
        }

        //проверяем происходит ли добавление данных в коллекцию ( и правильно ли это происходит)
        [Test]
        public void Add()
        {

            var storeList = new List<Stores>();
            var store = new Stores("Магазин", "Иванов Иван Иванович", 10, 100);

            store.AddStore(storeList, store);

            Assert.AreEqual(1, storeList.Count);
            Assert.AreEqual("Магазин", storeList[0].title);
            Assert.AreEqual("Иванов Иван Иванович", storeList[0].director);
            Assert.AreEqual(10, storeList[0].salesCount);
            Assert.AreEqual(100, storeList[0].monthlyRevenue);
        }

        //проверяем удаление магазин по названию (если он есть в списке)
        [Test]
        public void RemoveTitle_True()
        {
            var store = new Stores("Магазин", "Иванов Иван Иванович", 10, 100);
            var storeList = new List<Stores>
            {
            store,
            new Stores("Аптека", "Седых Зоя Фёдоровна", 20, 200)
            };
            var storeNameToRemove = "Магазин";


            var result = store.RemoveStore(storeList, storeNameToRemove);

            Assert.IsTrue(result); //проверяем, что произошло удаление
            Assert.AreEqual(1, storeList.Count); //проверяем, что в коллекции остался только один элемент
            Assert.IsFalse(storeList.Any(s => s.title.Equals(storeNameToRemove, StringComparison.OrdinalIgnoreCase))); //проверяем, что больше нет элемента с таким названием
        }

        //проверяем удаление магазин по названию (если такого нет в списке)
        [Test]
        public void RemoveTitle_False()
        {
            var store = new Stores("Магазин", "Иванов Иван Иванович", 10, 100);
            var storeList = new List<Stores>
            {
            store,
            new Stores("Аптека", "Седых Зоя Фёдоровна", 20, 200)
            };
            var storeNameToRemove = "Магнит";


            var result = store.RemoveStore(storeList, storeNameToRemove);

            Assert.IsFalse(result); //проверяем, что удаление не произошло
            Assert.AreEqual(2, storeList.Count); //проверяем, что в коллекции осталось два элемента
        }

        //проверяем удаление магазин по количеству продаж, когда вводимое значение больше/равно некоторым значениям продаж
        [Test]
        public void RemoveSalesCount_True()
        {
            var store = new Stores("Магазин", "Иванов Иван Иванович", 10, 100);
            var storeList = new List<Stores>
            {
            store,
            new Stores("Аптека", "Седых Зоя Фёдоровна", 20, 200),
            new Stores("Манит", "Сытин Константин Александрович", 50, 200)
            };

            int salesCountToRemove = 20;
            bool result = store.RemoveStore(storeList, salesCountToRemove);

            Assert.IsTrue(result); //проверка на то, что удаление произошло
            Assert.AreEqual(1, storeList.Count);
            Assert.IsFalse(storeList.Any(s => s.salesCount <= salesCountToRemove)); // Проверка, что магазины с salesCount <= 15 удалены
        }

        //проверяем удаление магазин по количеству продаж, когда вводимое значение меньше всех значений продаж
        [Test]
        public void RemoveSalesCount_False()
        {
            var store = new Stores("Магазин", "Иванов Иван Иванович", 10, 100);
            var storeList = new List<Stores>
            {
                 store,
                 new Stores("Аптека", "Седых Зоя Фёдоровна", 20, 200),
                 new Stores("Манит", "Сытин Константин Александрович", 50, 200)
            };

            int salesCountToRemove = 5;
            bool result = store.RemoveStore(storeList, salesCountToRemove);

            Assert.IsFalse(result); //проверка на то, что удаление произошло
            Assert.AreEqual(3, storeList.Count);
        }

        //проверяем удаление магазина по выручке за месяц, если водимое значение больше/равно некоторым значениям выручки
        [Test]
        public void RemoveMonthlyRevenue_True()
        {
            var store = new Stores("Магазин", "Иванов Иван Иванович", 10, 100);
            var storeList = new List<Stores>
            {
            store,
            new Stores("Аптека", "Седых Зоя Фёдоровна", 20, 200),
            new Stores("Манит", "Сытин Константин Александрович", 50, 100)
            };

            decimal monthlyRevenueToRemove = 150;
            bool result = store.RemoveStore(storeList, monthlyRevenueToRemove);

            Assert.IsTrue(result); //проверка на то, что удаление произошло
            Assert.AreEqual(1, storeList.Count);
            Assert.IsFalse(storeList.Any(s => s.monthlyRevenue <= monthlyRevenueToRemove)); // Проверка, что магазины с salesCount <= 15 удалены
        }

        //проверяем удаление магазина по выручке за месяц, если водимое значение меньше всех значений выручки
        [Test]
        public void RemoveMonthlyRevenue_False()
        {
            var store = new Stores("Магазин", "Иванов Иван Иванович", 10, 100);
            var storeList = new List<Stores>
            {
            store,
            new Stores("Аптека", "Седых Зоя Фёдоровна", 20, 200),
            new Stores("Манит", "Сытин Константин Александрович", 50, 100)
            };

            decimal monthlyRevenueToRemove = 99;
            bool result = store.RemoveStore(storeList, monthlyRevenueToRemove);

            Assert.IsFalse(result); //проверка на то, что удаление произошло
            Assert.AreEqual(3, storeList.Count);
        }


        //проверка на то, как считается значение Qp, если кол-во посетителей большее 50 тыс.
        [Test]
        public void Qp_More50000()
        {
            // Arrange
            var instance = new RetailStore("Магазин", "Иванов Иван Иванович", 10, 100, 60000, "4", "ул. Первомайская, 73", false);

            // Act
            var result = instance.Qp();

            // Assert
            Assert.AreEqual(20m, result); //
        }

        //проверка на то, как считается значение Qp, если кол-во посетителей меньше/равно 50 тыс.
        [Test]
        public void Qp_Less50000()
        {
            // Arrange
            var instance = new RetailStore("Магазин", "Иванов Иван Иванович", 10, 100, 50000, "4", "ул. Первомайская, 73", false);

            // Act
            var result = instance.Qp();

            // Assert
            Assert.AreEqual(5m, result);
        }

        //проверка на то, как добавляются магазины в историю ( и правльно ли это происходит)
        [Test]
        public void AddHistory()
        {
            var retailStore = new RetailStore("Магазин", "Иванов Иван Иванович", 10, 100, 50000, "4", "ул. Первомайская, 73", false);
            string storeName = "Магазин";

            retailStore.AddHistory(storeName);
            var historyQueue = retailStore.GetHistoryQueue();

            Assert.AreEqual(1, historyQueue.Count()); //проверяем, что в очереди 1 элемент

            //проверка на то, правильно ли начинается строка
            string sub = $"{storeName} - ";
            string value = historyQueue.Dequeue();
            Assert.IsTrue(value.StartsWith(sub));

            //проверим, есть ли время в элементе
            DateTime time;
            string[] parts = value.Split(" - ");
            Assert.AreEqual(2, parts.Length); //проверяем, что элмент состоит из двух частей
            Assert.IsTrue(DateTime.TryParse(parts[1], out time)); //проверяем время
        }

        //проверка на то, какие значения сохраняются в очереди истории
        [Test]
        public void GetHistoryQueue()
        {
            var retailStore = new RetailStore("Магазин", "Иванов Иван Иванович", 10, 100, 50000, "4", "ул. Первомайская, 73", false);
            string storeName = "Магазин";

            retailStore.AddHistory(storeName);

            //поучаем значения
            Queue<string> historyQueue = retailStore.GetHistoryQueue();

            Assert.IsNotNull(historyQueue); //проверяем, что очередь не пустая
            Assert.AreEqual(1, historyQueue.Count); //проверяем, что там есть 1 элемент

            //берём содержимое коллекции
            string value = historyQueue.Dequeue();

            //и проверяем, что она начинается с именно так, как нам надо
            Assert.IsTrue(value.StartsWith($"{storeName} - "));

            //проверим, есть ли время в элементе
            DateTime time;
            string[] part= value.Split(" - ");

            Assert.AreEqual(2, part.Length); //проверяем, что элмент состоит из двух частей
            Assert.IsTrue(DateTime.TryParse(part[1], out time)); //проверяем время

            //[Test]
            //public void ShowStores()
            //{

            //    var store = new Stores("Магазин", "Иванов Иван Иванович", 10, 100);

            //    var dgv = new DataGridView();
            //    dgv.Columns.Add("Title", "Title");
            //    dgv.Columns.Add("Director", "Director");
            //    dgv.Columns.Add("SalesCount", "Sales Count");
            //    dgv.Columns.Add("MonthlyRevenue", "Monthly Revenue");

            //    store.Show(dgv);

            //    Assert.AreEqual(1, dgv.Rows.Count); 
            //    Assert.AreEqual("Магазин", dgv.Rows[0].Cells["Title"].Value); 
            //    Assert.AreEqual("Иванов Иван Иванович", dgv.Rows[0].Cells["Director"].Value); 
            //    Assert.AreEqual(10, dgv.Rows[0].Cells["SalesCount"].Value); 
            //    Assert.AreEqual(100, dgv.Rows[0].Cells["MonthlyRevenue"].Value); 
            //}

            //[Test]
            //public void ShowHistory()
            //{
            //    var retailStore = new RetailStore("Магазин", "Иванов Иван Иванович", 10, 100, 50000, "4", "ул. Первомайская, 73", false);

            //    retailStore.AddHistory("Магазин - 2024-11-10 10:00:00");
            //    retailStore.AddHistory("Магазин - 2024-11-10 10:01:00");

            //    ListBox listBox = new ListBox();

            //    retailStore.ShowHistory(listBox);

            //    Assert.AreEqual(2, listBox.Items.Count); 
            //    Assert.AreEqual("Магазин - 2024-11-10 10:00:00", listBox.Items[0]); 
            //    Assert.AreEqual("Магазин - 2024-11-10 10:01:00", listBox.Items[1]);
            //}


        }

    }
}