#Sart Blokları
eposta = "admin@admin.com"
sifre="123"
if eposta=="admin@admin.com" and sifre=="123":
  print('Giriş Başarılı')
elif eposta="admin@admin.com" and sifre!="123":
  print('Şifreyi Yanlış Girdiniz.')
else:
  print("Yanlış bilgiler. Kontrol edip tekrar deneyiniz!!!")

#Fonksiyon
def  Kamp():
  kamplar=["Yazılım Gelistirme Kampı","Programlamaya Giriş Kampı"]
  #döngü
  for kamp in kamplar:
    print(kamp)

Kamp()
