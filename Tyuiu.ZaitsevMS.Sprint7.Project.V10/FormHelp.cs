using System;
using System.Windows.Forms;

namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
            FillHelpText();
        }

        private void FillHelpText()
        {
            richTextBoxHelp_ZMS.Clear();
            AppendHeader("Руководство пользователя — Система управления заказами\n");

            AppendSection("1. Запуск и интерфейс");
            AppendBody(
                "При запуске приложение автоматически загружает данные из файлов " +
                "Clients.csv и Orders.csv, расположенных рядом с исполняемым файлом. " +
                "Главное окно содержит таблицу заказов, строку поиска, меню и инструментальную панель.\n");

            AppendSection("2. Работа с заказами");
            AppendBody(
                "Добавить заказ — кнопка Добавить на панели или меню Данные -> Добавить заказ.\n" +
                "Редактировать — выберите строку в таблице, нажмите Изменить.\n" +
                "Удалить — выберите строку, нажмите Удалить и подтвердите.\n" +
                "Данные сохраняются в CSV автоматически после каждого изменения.\n");

            AppendSection("3. Поиск и фильтрация");
            AppendBody(
                "Введите текст в поле поиска на панели инструментов — таблица фильтруется " +
                "в реальном времени по номеру заказа, номеру счёта и названию товара. " +
                "Очистите поле, чтобы отобразить все записи.\n");

            AppendSection("4. Сортировка");
            AppendBody(
                "Нажмите на заголовок любого столбца в таблице — данные отсортируются " +
                "по возрастанию выбранного поля.\n");

            AppendSection("5. Справочник клиентов");
            AppendBody(
                "Откройте через меню Данные -> Справочник клиентов. Здесь можно добавлять, " +
                "редактировать и удалять клиентов. Изменения сразу сохраняются в Clients.csv.\n");

            AppendSection("6. Статистика и гистограмма");
            AppendBody(
                "Меню Вид -> Статистика или кнопка Статистика на панели. " +
                "Отображаются: количество заказов, общая сумма, среднее, минимальная и " +
                "максимальная стоимость, лучший клиент. " +
                "Гистограмма показывает суммарную стоимость заказов в разбивке по клиентам.\n");

            AppendSection("7. Форматы файлов");
            AppendBody(
                "Clients.csv: НомерСчёта;Фамилия;Имя;Отчество;Адрес;Телефон\n" +
                "Orders.csv: НомерЗаказа;НомерСчёта;Дата(дд.мм.гггг);Товар;Цена;Количество\n" +
                "Файлы можно редактировать вручную в любом текстовом редакторе.\n");

            AppendSection("8. Возможные проблемы");
            AppendBody(
                "Если таблица пуста — убедитесь, что CSV-файлы находятся рядом с .exe.\n" +
                "Если клиент не отображается в заказе — проверьте совпадение номера счёта.\n" +
                "Приложение не запускается — убедитесь, что установлен .NET Framework 4.7.2+.\n");
        }

        private void AppendHeader(string text)
        {
            richTextBoxHelp_ZMS.SelectionFont = new System.Drawing.Font(
                "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            richTextBoxHelp_ZMS.SelectionColor = System.Drawing.Color.DarkBlue;
            richTextBoxHelp_ZMS.AppendText(text);
        }

        private void AppendSection(string text)
        {
            richTextBoxHelp_ZMS.SelectionFont = new System.Drawing.Font(
                "Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            richTextBoxHelp_ZMS.SelectionColor = System.Drawing.Color.DarkSlateGray;
            richTextBoxHelp_ZMS.AppendText(text + "\n");
        }

        private void AppendBody(string text)
        {
            richTextBoxHelp_ZMS.SelectionFont = new System.Drawing.Font(
                "Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular);
            richTextBoxHelp_ZMS.SelectionColor = System.Drawing.Color.Black;
            richTextBoxHelp_ZMS.AppendText(text + "\n");
        }

        private void buttonCloseHelp_ZMS_Click(object sender, EventArgs e) => Close();
    }
}