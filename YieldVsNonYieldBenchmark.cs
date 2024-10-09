using BenchmarkDotNet.Attributes;

namespace YieldExample
{

    public class YieldVsNonYieldBenchmark
    {
        //Test edeceğimiz user adedi
        const int generateUserQuantity = 100000;

        /// <summary>
        /// `yield` kullanan veri seti örneğini çalıştırır.
        /// Bu metot, kullanıcıları tek tek ihtiyaç duyuldukça döndürür.
        /// </summary>
        [Benchmark]
        public void YieldExample()
        {
            foreach (UserDto user in GetYieldData())
            {
                // Kullanıcı verilerini işlemeye örnek olarak isimlerini yazdırıyoruz
                string fullName = $"Name : {user.FirstName} Surname : {user.LastName}";
            }
        }

        /// <summary>
        /// Normal liste döndürme işlemi.
        /// Bu metot tüm kullanıcı listesini bir kerede döndürür.
        /// </summary>
        [Benchmark]
        public void NonYieldExample()
        {
            foreach (UserDto user in GetData())
            {
                string fullName = $"Name : {user.FirstName} Surname : {user.LastName}";
            }
        }

        /// <summary>
        /// `yield return` ile kullanıcıları tek tek döndürür.
        /// Bu yöntemle sadece ihtiyaç duyulan veriler yüklenir.
        /// </summary>
        static IEnumerable<UserDto> GetYieldData()
        {
            foreach (var item in UserService.GenerateYieldUsers(generateUserQuantity))
            {
                yield return item; // Kullanıcıları tek tek döndürür
            }
        }

        /// <summary>
        /// Tüm kullanıcı listesini bir defada döndürür.
        /// Bu yöntem tüm veriyi hafızaya yükler ve tüm listeyi geri döner.
        /// </summary>
        static IEnumerable<UserDto> GetData()
        {
            return UserService.GenerateUsers(generateUserQuantity);
        }
    }
}
