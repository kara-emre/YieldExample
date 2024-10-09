İşte `BenchmarkDotNet` kullanılarak yapılan performans test sonuçlarının güncellenmiş metni:

---

Bu çıktıda, `BenchmarkDotNet` kullanılarak yapılan iki metodun (yield kullanan ve kullanmayan) performans test sonuçları yer almaktadır.

### Genel Bilgiler
- **.NET Versiyonu**: 8.0.8
- **İşletim Sistemi**: Windows 11
- **İşlemci**: Intel Core i7-12700H
- **BenchmarkDotNet Sürümü**: 0.14.0

### Performans Sonuçları
| Metot           | Ortalama | Hata      | Standart Sapma |
|---------------- |---------:|----------:|----------------:|
| YieldExample    | 2.091 ms | 0.0410 ms | 0.0770 ms       |
| NonYieldExample | 5.630 ms | 0.1067 ms | 0.1530 ms       |

- `YieldExample`, `NonYieldExample` metoduna göre yaklaşık %62 daha hızlıdır.
- `Yield` kullanımı, bellek verimliliği ve işlem sürelerini önemli ölçüde azaltmaktadır.

### Detaylı Sonuçlar
- **YieldExample**:
  - Min: 1.983 ms, Max: 2.096 ms, Median: 0.1530 ms
  - Güven Aralığı: [2.014 ms; 2.079 ms]
  
- **NonYieldExample**:
  - Min: 5.103 ms, Max: 5.704 ms, Median: 5.355 ms
  - Güven Aralığı: [5.284 ms; 5.495 ms]

### Histogram
`YieldExample`, daha dar bir ölçüm aralığında yoğunlaşırken, `NonYieldExample` daha geniş bir aralığa yayılmıştır.

### Sonuç
`YieldExample` metodu, `NonYieldExample` metoduna göre çok daha hızlıdır ve `yield return` kullanımının performans avantajını açıkça ortaya koymaktadır.

![image](https://github.com/user-attachments/assets/cee03b1f-1e6d-4ada-9a3a-7282cf99df42)

--- 
