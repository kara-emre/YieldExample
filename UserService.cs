namespace YieldExample
{
    /// <summary>
    /// Kullanıcı bilgilerini temsil eden sınıf.
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// Belirtilen sayıda rastgele kullanıcı oluşturur ve bunları bir liste olarak döndürür.
        /// </summary>
        /// <param name="count">Oluşturulacak kullanıcı sayısı.</param>
        /// <returns>Rastgele oluşturulmuş kullanıcıların listesi.</returns>
        public static List<UserDto> GenerateUsers(int count)
        {
            List<UserDto> users = new List<UserDto>();
            Random random = new Random();

            // Örnek isim ve soyisim listeleri
            string[] firstNames = { "John", "Jane", "Michael", "Emily", "David", "Sarah", "Chris", "Laura", "James", "Lisa" };
            string[] lastNames = { "Doe", "Smith", "Johnson", "Davis", "Brown", "Wilson", "Taylor", "Anderson", "Thomas", "Clark" };

            for (int i = 0; i < count; i++)
            {
                // Rastgele isim ve soyisim seçimi
                string firstName = firstNames[random.Next(firstNames.Length)];
                string lastName = lastNames[random.Next(lastNames.Length)];
                int age = random.Next(18, 65); // 18 ile 64 yaş arasında rastgele bir yaş

                // Yeni kullanıcıyı listeye ekle
                users.Add(new UserDto { FirstName = firstName, LastName = lastName, Age = age });
            }

            return users; // Oluşturulan kullanıcı listesini döndür
        }

        /// <summary>
        /// Belirtilen sayıda rastgele kullanıcı oluşturur ve bunları `yield` ile döndürür.
        /// Bu yöntem, kullanıcıları yalnızca ihtiyaç duyulduğunda oluşturur.
        /// </summary>
        /// <param name="count">Oluşturulacak kullanıcı sayısı.</param>
        /// <returns>Rastgele oluşturulmuş kullanıcıların akışını sağlar.</returns>
        public static IEnumerable<UserDto> GenerateYieldUsers(int count)
        {
            Random random = new Random();

            // Örnek isim ve soyisim listeleri
            string[] firstNames = { "John", "Jane", "Michael", "Emily", "David", "Sarah", "Chris", "Laura", "James", "Lisa" };
            string[] lastNames = { "Doe", "Smith", "Johnson", "Davis", "Brown", "Wilson", "Taylor", "Anderson", "Thomas", "Clark" };

            for (int i = 0; i < count; i++)
            {
                // Rastgele isim ve soyisim seçimi
                string firstName = firstNames[random.Next(firstNames.Length)];
                string lastName = lastNames[random.Next(lastNames.Length)];
                int age = random.Next(18, 65); // 18 ile 64 yaş arasında rastgele bir yaş

                // Yeni kullanıcıyı `yield return` ile döndür
                yield return new UserDto { FirstName = firstName, LastName = lastName, Age = age };
            }
        }
    }
}
