namespace Module14.Task14._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            //Сортировка сначала по Имени, затем по Фамилии
            var sortedPhoneBook = phoneBook.OrderBy(contact => contact.Name).ThenBy(contact => contact.LastName).ToList();

            //Вывод
            sortedPhoneBook.ForEach(b => Console.WriteLine($"{b.Name} {b.LastName} - phone:{b.PhoneNumber}, email:{b.Email}"));
            Console.ReadKey();
        }

        
    
    }
}
