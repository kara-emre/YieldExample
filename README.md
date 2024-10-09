Bu çıktıda, `BenchmarkDotNet` kullanılarak yapılan iki metot için (yield kullanan ve kullanmayan) performans test sonuçları yer alıyor. Aşağıda bu çıktının her bir kısmını açıklayacağım:

### Genel Bilgiler
- **.NET Versiyonu ve Ortam**: Testler, .NET 8.0.8 versiyonunda ve Windows 11 işletim sisteminde gerçekleştirildi. 
- **CPU Bilgisi**: Testler, 12. nesil Intel Core i7-12700H işlemcisi ile yapıldı.
- **BenchmarkDotNet Sürümü**: Kullanılan benchmark kütüphanesinin versiyonu 0.14.0.

### Metodların Performans Sonuçları
| Method          | Mean     | Error     | StdDev    |
|---------------- |---------:|----------:|----------:|
| YieldExample    | 2.091 ms | 0.0410 ms | 0.0770 ms |
| NonYieldExample | 5.630 ms | 0.1067 ms | 0.1530 ms |

- **Mean (Ortalama)**: Her iki metodun ortalama çalıştırma süresi.
  - `YieldExample`: 2.047 ms
  - `NonYieldExample`: 5.390 ms
  - `YieldExample`, `NonYieldExample` metoduna göre yaklaşık %62 daha hızlı çalışmaktadır.

- **Error (Hata)**: Ölçüm sonuçlarının güven aralığının yarısıdır. Bu, ortalamanın ne kadar güvenilir olduğunu gösterir.
  - `YieldExample`: 0.0324 ms
  - `NonYieldExample`: 0.1057 ms

- **StdDev (Standart Sapma)**: Ölçüm sonuçlarının ortalamadan ne kadar uzaklaştığını gösterir. Düşük değer, daha tutarlı sonuçlar anlamına gelir.
  - `YieldExample`: 0.0303 ms
  - `NonYieldExample`: 0.1766 ms (Bu, `NonYieldExample` için daha yüksek bir değişkenlik olduğunu gösterir.)

### Detaylı Sonuçlar
#### YieldExample Sonuçları
- **Runtime**: 2.047 ms
- **Min**: 1.983 ms (En kısa süre)
- **Max**: 2.096 ms (En uzun süre)
- **Median**: 2.052 ms (Orta değer)
- **Confidence Interval**: [2.014 ms; 2.079 ms] (99.9% güven aralığı)

#### NonYieldExample Sonuçları
- **Runtime**: 5.390 ms
- **Min**: 5.103 ms
- **Max**: 5.704 ms
- **Median**: 5.355 ms
- **Confidence Interval**: [5.284 ms; 5.495 ms] (99.9% güven aralığı)

### Histogram
- `YieldExample` ve `NonYieldExample` için histogramlar, her bir ölçüm aralığındaki sıklığı gösterir. `YieldExample` daha dar bir aralıkta yoğunlaşırken, `NonYieldExample` daha geniş bir aralığa yayılmıştır.

### Sonuç
- **Performans Farkı**: `YieldExample` metodu, `NonYieldExample` metoduna göre çok daha hızlıdır. Bu, `yield return` kullanımının büyük veri kümeleriyle çalışırken daha verimli bir yol sunduğunu gösteriyor. `Yield` kullanarak bellek verimliliği ve daha hızlı işlem süreleri sağlamak mümkündür.
  
Bu sonuçlar, `yield return` kullanımının performans avantajını açıkça ortaya koymaktadır. 
![image](https://github.com/user-attachments/assets/cee03b1f-1e6d-4ada-9a3a-7282cf99df42)
