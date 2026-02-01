import pandas as pd
import matplotlib.pyplot as plt

# Fahrenheit'i Celsius'a ceviren fonksiyon
def fahrenheit_celsius(f):
    return (f - 32) * 5 / 9

# CSV dosyasini oku
df = pd.read_csv('temperatures.csv')

# Sicakliklari Celsius'a cevir
maksimum_c = [fahrenheit_celsius(x) for x in df["TMAX"]]
minimum_c = [fahrenheit_celsius(x) for x in df["TMIN"]]

# Grafik olustur
plt.style.use('ggplot')
plt.figure(figsize=(10, 6))

plt.plot(maksimum_c, color='red', label='Maksimum')
plt.plot(minimum_c, color='blue', label='Minimum')

plt.title('Olum Vadisi Sicakliklari - 2018', fontsize=16)
plt.xlabel('Gunler', fontsize=12)
plt.ylabel('Sicaklik (C)', fontsize=12)
plt.legend()

plt.show()