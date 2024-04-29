Amaç:  Projede araştırmaya yönelik bölümlerde yer almaktadır. Projenin amacı girilen metin üzerinde arama yapmaya yöneliktir. Bunun için bir uzun metin girilebilen bileşen, bir tane de arama yapılan 
ifadenin girilebildiği textbox olmalıdır. Arama için “Çalıştır” butonu oluşturulmalıdır. Analiz sonuçları ayrı tabpage, loglama için ayrı bir tabpage olmalıdır. 
Gereksinimler:
1//Ekrandan girilen metin üzerinde, aranacak ifadenin girilip metin üzerinde analiz yapılması istenmektedir. Hesaplama öncesi aranacak ifadenin metin, karakter veya sayı içerip içermediği checkbox ile seçilip,
aranan değerin kontrolü kontrol() fonksiyonunda yapılmalıdır (Değer hatalı ise MessageBox ile uyarı verilmelidir).

2//İstenen analiz sonuçları Analiz Sonuçları tabPage’inde yazdırılacaktır. Hesaplamaların ayrı fonksiyonlarında yazılması gerekmektedir: 
• Girilen metnin ve aranan ifadenin uzunluğu 
• Aranan ifadenin metinde bulunup, bulunmadığı (bulunuyorsa ilk geçen index) 
• Metin içinde aranan ifade kaç kez geçtiği yazdırılmalı

3//Tasarımdaki Geri butonu bir önceki tabPage’e, İleri butonu ise sonraki tabPage’e geçmeyi sağlamalıdır.

4//Analiz sonuçları tabPage’inde yer alan Temizle butonu ile metin kutusunun içeriği temizlenmelidir.

5//Loglama tabPage’inde ise ListView bileşeninde analiz sonucu yer alacak bilgi şöyle olmalıdır. Her analiz sonucunda loglamaya bu bilgiler otomatik eklenmelidir. Bilgi içeriği 
• i. (i=1,2,3,….) metinde xxxx ifadesi aranmış ve yy defa bulunmuştur. Metnin uzunluğu x’tir.

6//Loglama tabPage’inde ise Temizle butonu ile liste temizlenmelidir. Ana Ekran butonu ile de Ana Ekran tabPage’ine geçiş yapılmalıdır.

7//Ekranda 3 ayrı tabpage omalı. Tab’ler arasında ileri-geri gezinme belirtildiği gibi yapılmalıdır. 

8//Program açıldığında sağ alt köşeden notification vermelidir. Bunun için NotifyIcon bileşeni kullanılmalıdır.
