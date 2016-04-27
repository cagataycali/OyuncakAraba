NESNEYE YÖNELİK PROGRAMLAMA

ÖDEV #2

Teslim Tarihi: 18.04.2016

Önüne fırça takılmış odada dolaşan bir oyuncak araba hayal edin. Araba C# uygulamasıyla kontrol edilmektedir. Arabadaki fırça 2 farklı konumda olabilir: aşağıda veya yukarıda. Fırça aşağıdayken aracın gittiği yerleri boyamakta, fırça yukarıdayken hiçbir şey yapmamaktadır. Sizden bu sistemi C# ta modellemeniz istenmektedir. 

İçi başlangıç olarak 0 ile dolu kullanıcının belirleyeceği N*N boyutunda  bir dizi kullanacaksınız. Aracın nerede olduğunun, fırçanın aşağıda veya yukarıda olduğunun ve aracın yönünün kaydını tutacaksınız. Eğer araç boyut dışına çıkıyorsa, diğer taraftan girerek komutu tamamlayacaktır. Yani matrisin sağından çıkıyorsa solunda girerek devam edecek, aşağıdan çıkıyorsa yukarıdan devam edecek vs.  

Aracın ilk başta (0,0) konumunda, fırçanın yukarıda olduğunu ve aracın sağ tarafa dönük olduğunu varsayın. Aracı aşağıdaki komutlarla yöneteceksiniz.

1 Fırça aşağı

2 Fırça yukarı

3 Sağa dön

4 Sola dön

5_x x kadar ilerle(bulunduğu kare hariç.)

6 Zıpla(bulunduğu kare hariç  3 kare zıplar. Zıpladıktan sonra fırça yukarı pozisyona gelir.)

7 Geri dön.(180 derece döner)

8 Diziyi görüntüle

0 Programı sonlandır(0 görürse sonraki komutları dikkate almayacak.)


Araç bir yerden geçerken eğer fırça aşağıda ise dizide ilgili elemana 1 değeri atanacak. Görüntülenirken 1 değeri olan yerler “*” olarak görüntülenecek.

Komutlar aralarında + ile ayrılmış olacak. Örnek bir komut aşağıdaki gibidir.

Komutlar: BOYUT+5_5+3+5_1+3+1+5_4+4+5_7+4+5_4+4+5_3+4+5_2+7+6 +8+0

Komutlar çalıştığında örnek görüntü aşağıdaki gibidir. Bos karelerde 0 olacak
